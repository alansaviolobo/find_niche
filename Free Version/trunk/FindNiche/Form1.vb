Imports System
Imports System.Net
Imports System.IO
Imports Salamander.Windows.Forms

Public Class Form1

    Private MyColumnSorter As ListViewColumnSorter
    Private ErrorFile As String = "Error.log"

    Private IsHTTP As Boolean

    Private CMN_IDX As Integer
    Private KWS_IDX As Integer
    Private APPROX_IDX As Integer
    Private AVG_IDX As Integer
    Private CNT_IDX As Integer

    Private APPROX_DIDX As Integer
    Private AVG_DIDX As Integer
    Private CNT_DIDX As Integer

    Private BUFFER_LEN As Integer = 20
    Private BUFFER_TXT As String = "00000000000000000000"

    Private InputCSVContents As String
    Private GLCode As String

    Private Busy As Boolean
    Private WaitURL As String
    Private ErrorURL As String
    Private LoadedURL As String
    Private ErrorLoadingURL As Boolean

    Private Enum Status
        INIT
        KW_GENERATING
        KW_GENERATED
        PROCESSING
        AFTER_PROCESSING
        EXPORTING
        PAUSED
        AFTER_EXPORTING
    End Enum

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBoxKeywordType.SelectedIndex = 0
        ComboBoxGL.SelectedIndex = 0
        SetUIState(Status.INIT)
        If My.Computer.FileSystem.FileExists(ErrorFile) Then My.Computer.FileSystem.DeleteFile(ErrorFile)
        CollapsiblePanelResults.PanelState = PanelState.Collapsed
    End Sub

    Private Sub Form1_Closing(ByVal sender As System.Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        MyColumnSorter = Nothing
        End
    End Sub

    Private Sub ListViewCSV_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles ListViewCSV.ColumnClick
        'don't allow sorting in processing/paused state...

        If ButtonPR.Visible = True And ButtonPR.Text = "Resume" Then
            'processing -paused state
            Exit Sub
        End If

        ' Determine if the clicked column is already the column that is 
        ' being sorted.

        Dim MappedColumn As Integer

        Select Case e.Column
            Case APPROX_IDX
                MappedColumn = APPROX_DIDX
            Case AVG_IDX
                MappedColumn = AVG_DIDX
            Case CNT_IDX
                MappedColumn = CNT_DIDX
            Case Else
                MappedColumn = e.Column
        End Select

        If (MappedColumn = MyColumnSorter.SortColumn) Then
            ' Reverse the current sort direction for this column.
            If (MyColumnSorter.Order = SortOrder.Ascending) Then
                MyColumnSorter.Order = SortOrder.Descending
            Else
                MyColumnSorter.Order = SortOrder.Ascending
            End If
        Else
            ' Set the column number that is to be sorted; default to ascending.
            MyColumnSorter.SortColumn = MappedColumn
            MyColumnSorter.Order = SortOrder.Ascending
        End If

        ' Perform the sort with these new sort options.
        Me.ListViewCSV.Sort()
    End Sub

    Private Sub SetUIState(ByVal state As Status)

        Select Case state
            Case Status.INIT
                GroupBoxGenerateKW.Enabled = True
                GroupBoxFilter.Enabled = False
                GroupBoxGenerateCount.Enabled = False
                GroupBoxExport.Enabled = False
                ListViewCSV.Enabled = False
                ButtonPR.Visible = False
                'ComboBoxGKCountry.SelectedIndex = 219
            Case Status.KW_GENERATING
                GroupBoxGenerateKW.Enabled = False
                GroupBoxFilter.Enabled = False
                GroupBoxGenerateCount.Enabled = False
                ButtonProcess.Enabled = False
                GroupBoxExport.Enabled = False
                ListViewCSV.Enabled = False
                ButtonPR.Visible = False
            Case Status.KW_GENERATED
                GroupBoxGenerateKW.Enabled = True
                GroupBoxGenerateCount.Enabled = True
                GroupBoxFilter.Enabled = True
                ButtonProcess.Enabled = True
                GroupBoxExport.Enabled = True
                TextBoxExport.Enabled = False
                ListViewCSV.Enabled = True
                ButtonPR.Visible = False
            Case Status.PROCESSING
                GroupBoxGenerateKW.Enabled = False
                GroupBoxFilter.Enabled = False
                ButtonProcess.Enabled = False
                GroupBoxExport.Enabled = False
                ListViewCSV.Enabled = False

                GroupBoxGenerateCount.Enabled = True
                ButtonPR.Visible = True
                ButtonPR.Enabled = True
                ButtonProcess.Enabled = False
                ComboBoxGL.Enabled = False
                SpinBoxThrottle.Enabled = False

                ButtonPR.Enabled = True
                ButtonPR.Text = "Pause"
            Case Status.AFTER_PROCESSING
                GroupBoxGenerateKW.Enabled = True
                GroupBoxGenerateCount.Enabled = True
                ButtonProcess.Enabled = True
                SpinBoxThrottle.Enabled = True
                ComboBoxGL.Enabled = True
                GroupBoxFilter.Enabled = True
                ButtonProcess.Enabled = True
                GroupBoxExport.Enabled = True
                TextBoxExport.Enabled = False
                ListViewCSV.Enabled = True
                ButtonPR.Visible = False
            Case Status.EXPORTING
                GroupBoxGenerateCount.Enabled = False
                GroupBoxFilter.Enabled = False
                ButtonProcess.Enabled = False
                GroupBoxExport.Enabled = False
                ListViewCSV.Enabled = False
                ButtonPR.Visible = False
            Case Status.AFTER_EXPORTING
                GroupBoxGenerateCount.Enabled = True
                GroupBoxFilter.Enabled = True
                ButtonProcess.Enabled = True
                GroupBoxExport.Enabled = True
                TextBoxExport.Enabled = False
                ListViewCSV.Enabled = True
                ButtonPR.Visible = False
            Case Status.PAUSED
                GroupBoxGenerateKW.Enabled = True
                ComboBoxGL.Enabled = True
                GroupBoxGenerateCount.Enabled = True
                GroupBoxFilter.Enabled = False
                GroupBoxExport.Enabled = True
                TextBoxExport.Enabled = False
                ListViewCSV.Enabled = True

                ButtonProcess.Enabled = False
                SpinBoxThrottle.Enabled = True
                ButtonPR.Visible = True
                ButtonPR.Enabled = True
                ButtonPR.Text = "Resume"
        End Select
        Nap(10)

    End Sub


    Private Sub ButtonProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonProcess.Click

        LabelStatus.Text = "Processing..."

        SetUIState(Status.PROCESSING)

        Dim RetVal As Boolean

        RetVal = PopulateCount()
        If RetVal = False Then
            MsgBox(LabelStatus.Text)
            SetUIState(Status.INIT)
            GoTo Leave
        End If

        LabelStatus.Text = "Processing completed. File can now be exported."

        SetUIState(Status.AFTER_PROCESSING)
Leave:

    End Sub

    Private Function PopulateListView(ByVal txt As String) As Boolean

        Dim Retval As Boolean = False

        ListViewCSV.Clear()

        ListViewCSV.View = View.Details

        Dim row() As String

        row = Split(txt, vbNewLine)

        Dim col() As String

        '---------------------------------------------------------------------------
        'ColumnHeaders....

        Dim i As Integer, j As Integer
        Dim CH As ColumnHeader

        Dim IC As Integer = 1
        IsHTTP = False
        'If TextBoxCSVFile.Text.ToLower.Contains("-http.") Then
        '    CH = New ColumnHeader()
        '    CH.Text = "Common"
        '    Me.ListViewCSV.Columns.Add(CH)
        '    IC = 2
        '    IsHTTP = True
        'End If

        CH = New ColumnHeader()
        CH.Text = "Keywords"
        Me.ListViewCSV.Columns.Add(CH)

        CH = New ColumnHeader()
        CH.Text = "Local"
        Me.ListViewCSV.Columns.Add(CH)

        CH = New ColumnHeader()
        CH.Text = "Global"
        Me.ListViewCSV.Columns.Add(CH)

        CH = New ColumnHeader()
        CH.Text = "Phrase"
        Me.ListViewCSV.Columns.Add(CH)

        CH = New ColumnHeader()
        CH.Text = "DummyApprox"
        CH.Width = 0 'invisible
        Me.ListViewCSV.Columns.Add(CH)

        CH = New ColumnHeader()
        CH.Text = "DummyAverage"
        CH.Width = 0 'invisible
        Me.ListViewCSV.Columns.Add(CH)

        CH = New ColumnHeader()
        CH.Text = "DummyCount"
        CH.Width = 0 'invisible
        Me.ListViewCSV.Columns.Add(CH)
        '---------------------------------------------------------------------------
        'SET INDICES

        If IsHTTP = True Then
            CMN_IDX = 0
            KWS_IDX = 1
            APPROX_IDX = 2
            AVG_IDX = 3
            CNT_IDX = 4
            APPROX_DIDX = 5
            AVG_DIDX = 6
            CNT_DIDX = 7
        Else
            CMN_IDX = -1
            KWS_IDX = 0
            APPROX_IDX = 1
            AVG_IDX = 2
            CNT_IDX = 3
            APPROX_DIDX = 4
            AVG_DIDX = 5
            CNT_DIDX = 6
        End If
        '---------------------------------------------------------------------------
        'ADD ITEMS
        Dim LVI As ListViewItem
        Dim itxt As String

        'SBApproxMin.Value = 0
        'SBApproxMax.Value = 0
        'SBAvgMin.Value = 0
        'SBAvgMax.Value = 0

        For i = 0 To row.Length - 1
            If row(i) = vbNullString Then Continue For
            row(i) = row(i).Trim
            If row(i) = vbNullString Then Continue For

            col = Split(row(i), ",")

            itxt = col(0)
            If itxt <> vbNullString Then itxt = itxt.Trim

            LVI = New ListViewItem(itxt)
            For j = 1 To col.Length - 1
                If j <> IC Then
                    itxt = col(j)
                    If itxt <> vbNullString Then itxt = itxt.Trim
                    LVI.SubItems.Add(itxt)
                End If
                Nap(2)
            Next j

            If LVI.SubItems.Count - 1 < CNT_IDX Then
                LVI.SubItems.Add(Space(BUFFER_LEN))
            Else
                'already added
            End If
            'LVI.SubItems.Add(Space(BUFFER_LEN))
            LVI.SubItems.Add(Microsoft.VisualBasic.Strings.Right(BUFFER_TXT & LVI.SubItems(APPROX_IDX).Text, BUFFER_LEN))
            LVI.SubItems.Add(Microsoft.VisualBasic.Strings.Right(BUFFER_TXT & LVI.SubItems(AVG_IDX).Text, BUFFER_LEN))
            'LVI.SubItems.Add(BUFFER_TXT)

            If LVI.SubItems(CNT_IDX).Text = Space(BUFFER_LEN) Then
                LVI.SubItems.Add(BUFFER_TXT)
            Else
                LVI.SubItems.Add(Microsoft.VisualBasic.Strings.Right(BUFFER_TXT & LVI.SubItems(CNT_IDX).Text, BUFFER_LEN))
            End If
            Me.ListViewCSV.Items.Add(LVI)

        Next i

        'SBApproxMin.Value = 0
        'SBApproxMax.Value = 0
        'SBAvgMin.Value = 0
        'SBAvgMax.Value = 0
        'SBCntMin.Value = 0
        'SBCntMax.Value = 0
        '---------------------------------------------------------------------------
        'RESIZE
        For i = 0 To CNT_IDX
            ListViewCSV.Columns(i).Width = -2
        Next i
        '---------------------------------------------------------------------------
        'SORTER
        MyColumnSorter = New ListViewColumnSorter()
        Me.ListViewCSV.ListViewItemSorter = MyColumnSorter
        '---------------------------------------------------------------------------
        Retval = True

Leave:
        CH = Nothing
        LVI = Nothing
        Return Retval
    End Function

    Private Function PopulateCount() As Boolean

        Dim query As String
        Dim kw As String
        Dim gc As String

        Dim Retval As Boolean = False

        'http://www.google.com/search?hl=en&gl=US&q=%22diet+pills+online%22&btnG=Search

        Dim i As Integer
        Dim tmp As String

        For i = 0 To ListViewCSV.Items.Count - 1
            Nap(5)
            gc = vbNullString

            LabelStatus.Text = "Processing row " & i + 1 & " of " & ListViewCSV.Items.Count & "..."
            kw = ListViewCSV.Items(i).SubItems(KWS_IDX).Text

            ListViewCSV.Items(i).EnsureVisible()

            ListViewCSV.Items(i).SubItems(CNT_IDX).Text = "Processing..."
            ListViewCSV.Columns(KWS_IDX).Width = -2

            query = "http://www.google.com/search?hl=en&gl=" & Split(ComboBoxGL.SelectedItem.ToString, ":")(1) & "&q=%22" & kw & "%22&btnG=Search"

            gc = GetGoogleCount(query)

            Nap(5)
            If gc = "ERROR" Then
                ListViewCSV.Items(i).SubItems(CNT_IDX).Text = Space(BUFFER_LEN)
                GoTo Leave
            End If
            ListViewCSV.Items(i).SubItems(CNT_IDX).Text = gc
            ListViewCSV.Columns(KWS_IDX).Width = -2

            ListViewCSV.Items(i).SubItems(CNT_DIDX).Text = Microsoft.VisualBasic.Strings.Right(BUFFER_TXT & ListViewCSV.Items(i).SubItems(CNT_IDX).Text, BUFFER_LEN)

            DoDelay()

            tmp = kw & ",1," & ListViewCSV.Items(i).SubItems(APPROX_IDX).Text & "," & ListViewCSV.Items(i).SubItems(AVG_IDX).Text

            InputCSVContents = Replace(InputCSVContents, tmp & vbNewLine, tmp & "," & gc & vbNewLine)


        Next i

        For i = 0 To CNT_IDX
            ListViewCSV.Columns(i).Width = -2
        Next i

        ListViewCSV.Items(0).EnsureVisible()
        Retval = True

Leave:
        Return Retval
    End Function

    Private Function GetGoogleCount(ByVal query As String) As String
        Dim GoogleCnt As String = " "

        Dim Request As HttpWebRequest
        Dim Response As HttpWebResponse

        Dim Reader As StreamReader
        Dim ResponseStream As Stream
        Dim HtmlContent As String
        Dim HtmlDoc As System.Windows.Forms.HtmlDocument

        Dim HtmlElem As HtmlElement
        Dim txt As String
        Dim sp As Integer, ep As Integer

        WebBrowser1.Dispose()
        WebBrowser1 = New System.Windows.Forms.WebBrowser
        WebBrowser1.ScriptErrorsSuppressed = True

        HtmlContent = vbNullString

        Try
            Request = WebRequest.Create(query)
            Nap(5)
            Response = CType(Request.GetResponse(), HttpWebResponse)
            Nap(5)
            ResponseStream = Response.GetResponseStream()
            Nap(5)
            Reader = New StreamReader(ResponseStream)
            Nap(5)
            HtmlContent = Reader.ReadToEnd()
            Nap(5)
            WebBrowser1.Navigate("about:blank")
            Nap(5)
            HtmlDoc = CType(WebBrowser1.Document, System.Windows.Forms.HtmlDocument)

            HtmlDoc.Write(HtmlContent)

            HtmlElem = HtmlDoc.GetElementById("ssb")


            txt = HtmlElem.OuterText

            sp = InStr(txt, "of ")
            If sp > 1 Then
                ep = InStr(sp + 3, txt, " for ")

                GoogleCnt = Mid(txt, sp + 3, ep - (sp + 3))
                GoogleCnt = Replace(GoogleCnt, "about ", "")
                GoogleCnt = Replace(GoogleCnt, ",", "")
            End If
        Catch ex As Exception
            If HtmlContent <> vbNullString Then
                If HtmlContent.Contains("sorry") Then
                    LabelStatus.Text = "Google isn't allowing search. Please clear cookies and try later"
                    GoogleCnt = "ERROR"
                    GoTo Leave
                End If
            End If
            My.Computer.FileSystem.WriteAllText(ErrorFile, DateTime.Now.ToString() & " : Could not connect to " & query & " : " & ex.Message & vbNewLine, True)
        End Try

Leave:
        HtmlElem = Nothing
        HtmlDoc = Nothing
        ResponseStream = Nothing
        Reader = Nothing
        Response = Nothing
        Request = Nothing

        GoogleCnt = GoogleCnt.Trim
        If GoogleCnt = "" Then GoogleCnt = 0

        Return GoogleCnt
    End Function

    Private Sub Nap(ByVal cnt As Integer)
        While cnt > 0
            Application.DoEvents()
            cnt = cnt - 1
        End While
    End Sub

    Private Sub DoDelay()

        LabelStatus.Text = "Waiting for " & SpinBoxThrottle.Value & " seconds, before processing the next row..."
        Dim duration As Long
        duration = SpinBoxThrottle.Value * 1000

        Dim sw As New Stopwatch
        sw.Start()

        While sw.ElapsedMilliseconds < duration
            Nap(3)
            System.Threading.Thread.Sleep(200)
        End While

        sw.Stop()
        sw = Nothing
    End Sub

    Private Sub ButtonExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExport.Click

        'show save dlg
        Dim dlgrslt As DialogResult
        SaveFileDlg.FileName = vbNullString
        dlgrslt = SaveFileDlg.ShowDialog()

        Dim exportfilename As String
        Dim t As String

        If dlgrslt = Windows.Forms.DialogResult.OK Then

            SetUIState(Status.EXPORTING)
            LabelStatus.Text = "Exporting..."

            exportfilename = SaveFileDlg.FileName

            TextBoxExport.Text = exportfilename
            TextBoxExport.Enabled = False

            Nap(10)

            Dim row As Integer
            Dim col As Integer

            'column header
            If IsHTTP = True Then
                My.Computer.FileSystem.WriteAllText(exportfilename, "Common,Keywords,Approx,Average,Count," & vbNewLine, False)
            Else
                My.Computer.FileSystem.WriteAllText(exportfilename, "Keywords,Approx,Average,Count," & vbNewLine, False)
            End If

            'rows data
            For row = 0 To ListViewCSV.Items.Count - 1
                For col = 0 To CNT_IDX
                    t = ListViewCSV.Items(row).SubItems(col).Text
                    If t <> vbNullString Then
                        t = t.Trim
                    End If
                    My.Computer.FileSystem.WriteAllText(exportfilename, t & ",", True)
                Next col
                My.Computer.FileSystem.WriteAllText(exportfilename, vbNewLine, True)
            Next row

            LabelStatus.Text = "File successfully exported as " & exportfilename
            MsgBox(LabelStatus.Text)

            SetUIState(Status.AFTER_EXPORTING)
        End If

        dlgrslt = Nothing

    End Sub

    Private Sub ListViewCSV_ColumnWidthChanging(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnWidthChangingEventArgs)
        If e.ColumnIndex = APPROX_DIDX Or e.ColumnIndex = AVG_DIDX Or e.ColumnIndex = CNT_DIDX Then
            e.Cancel = True
            e.NewWidth = 0
        End If
    End Sub


    Private Sub ButtonFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFilter.Click
        FilterList()
        CollapsiblePanelGenerateKW.PanelState = PanelState.Collapsed
    End Sub

    Private Sub FilterList()
        LabelStatus.Text = "Filtering list..."

        If ListViewCSV.Items.Count < 1 Then
            LabelStatus.Text = "List is empty"
            GoTo Leave
        End If

        If CheckBoxFilterApprox.Checked = True Then
            If SBApproxMax.Value < SBApproxMin.Value Then
                CheckBoxFilterApprox.Checked = False
            End If
        End If

        If SBApproxMax.Value = 0 And SBApproxMin.Value = 0 Then
            CheckBoxFilterApprox.Checked = False
        End If

        If CheckBoxFilterAvg.Checked = True Then
            If SBAvgMax.Value < SBAvgMin.Value Then
                CheckBoxFilterAvg.Checked = False
            End If
        End If

        If SBAvgMax.Value = 0 And SBAvgMin.Value = 0 Then
            CheckBoxFilterAvg.Checked = False
        End If

        If CheckBoxFilterCount.Checked = True Then
            If SBCntMax.Value < SBCntMin.Value Then
                CheckBoxFilterCount.Checked = False
            End If
        End If

        If SBCntMax.Value = 0 And SBCntMin.Value = 0 Then
            CheckBoxFilterCount.Checked = False
        End If

        If CheckBoxFilterApprox.Checked = False And CheckBoxFilterAvg.Checked = False And CheckBoxFilterCount.Checked = False Then
            LabelStatus.Text = "Select atleast one filtering option - make sure that the upper value is greater than the lower value"
            GoTo Leave
        End If

        Dim i As Integer
        Dim tavg As Int64, tapprox As Int64, tcnt As Int64

        Dim RemoveThisRow As Boolean

        For i = 0 To ListViewCSV.Items.Count - 1
            If i >= ListViewCSV.Items.Count Then Exit For

            RemoveThisRow = False

            If CheckBoxFilterAvg.Checked = True Then
                Try
                    tavg = Convert.ToInt64(ListViewCSV.Items(i).SubItems(AVG_IDX).Text)

                    If tavg >= SBAvgMin.Value And tavg <= SBAvgMax.Value Then
                        'keep this row
                    Else
                        RemoveThisRow = True
                    End If
                Catch ex As Exception
                    Debug.Print(ex.Message)
                End Try

            End If

            If CheckBoxFilterApprox.Checked = True Then
                Try
                    tapprox = Convert.ToInt64(ListViewCSV.Items(i).SubItems(APPROX_IDX).Text)

                    If tapprox >= SBApproxMin.Value And tapprox <= SBApproxMax.Value Then
                        'keep this row
                    Else
                        RemoveThisRow = True
                    End If
                Catch ex As Exception
                    Debug.Print(ex.Message)
                End Try
            End If

            If CheckBoxFilterCount.Checked = True Then
                Try
                    tcnt = Convert.ToInt64(ListViewCSV.Items(i).SubItems(CNT_IDX).Text)
                    If tcnt >= SBCntMin.Value And tcnt <= SBCntMax.Value Then
                        'do nothing
                    Else
                        RemoveThisRow = True
                    End If
                Catch ex As Exception
                    Debug.Print(ex.Message)
                End Try
            End If

            If RemoveThisRow = True Then
                ListViewCSV.Items(i).Remove()
                i = i - 1
            End If

            Nap(5)
        Next i
        LabelStatus.Text = "List has been filtered"

Leave:
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("www.nichetaser.com")
    End Sub

    Private Sub ButtonGenerateKW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGenerateKW.Click
        Dim Retval As Boolean

        Retval = ValidateGK()

        If Retval = False Then
            GoTo Leave
        End If

        Retval = ProcessGK()
        If Retval = False Then
            GoTo Leave
        End If

Leave:
        If Retval = False Then
            SetUIState(Status.INIT)
        End If
        MsgBox(LabelStatus.Text)
        CollapsiblePanelGenerateKW.PanelState = PanelState.Collapsed 

    End Sub

    Private Function ValidateGK() As Boolean
        Dim Retval As Boolean = False

        If TextBoxSeedKeyword.Text = vbNullString Then
            LabelStatus.Text = "Enter Seed Keyword"
            GoTo Leave
        End If
        TextBoxSeedKeyword.Text = TextBoxSeedKeyword.Text.Trim

        If TextBoxSeedKeyword.Text = vbNullString Then
            LabelStatus.Text = "Enter Seed Keyword"
            GoTo Leave
        End If

        Retval = True

Leave:
        Return Retval
    End Function

    Private Function ProcessGK() As Boolean
        Dim Retval As Boolean = False

        Retval = GenerateKeywords()
        If Retval = False Then
            LabelStatus.Text = "Error occured"
            GoTo Leave
        End If

        Retval = True

Leave:
        Return Retval
    End Function

    Private Function GenerateKeywords() As Boolean
        Dim RetVal As Boolean = False
        SetUIState(Status.KW_GENERATING)

        Dim SeedKW As String
        Dim GoogleKWList As String = vbNullString

        Dim IsHTTP As Boolean = False

        SeedKW = TextBoxSeedKeyword.Text.Trim

        ListViewCSV.Items.Clear()

        LabelStatus.Text = "Generating keywords..."

        'run the keyword through Google Adwords
        RetVal = GetGoogleKWList(SeedKW, GoogleKWList)
        If RetVal = False Then
            GoTo Leave
        End If
        InputCSVContents = GoogleKWList

        RetVal = PopulateListView(GoogleKWList)
        If RetVal = False Then
            GoTo Leave
        End If

        LabelStatus.Text = "Keywords generated successfully"

        RetVal = True

        SetUIState(Status.KW_GENERATED)

Leave:
        Return RetVal

    End Function

    Private Function GetGoogleKWList(ByVal SeedKW As String, ByRef GoogleKWList As String) As Boolean

        'https://adwords.google.com/select/KeywordToolExternal

        Dim RetVal As Boolean = True
        Dim URL As String = vbNullString
        Dim HtmlDoc As HtmlDocument
        Dim HtmlElem As HtmlElement
        Dim HtmlColl As HtmlElementCollection
        Dim TempColl As HtmlElementCollection

        Dim KW As String, Adv As String, Approx As String, Avg As String
        Dim CD As Captcha
        Dim CT As String

        Dim i As Integer, j As Integer
        Dim tmp As String

        CleanIECookies()

        Try
            URL = "https://adwords.google.com/select/KeywordToolExternal"
            Busy = True
            ErrorURL = vbNullString
            WaitURL = URL
            WebBrowser1.Navigate(URL)

            RetVal = Wait()
            If RetVal = False Then GoTo Leave

            Nap(3)

            '-----------------------------------------------

            HtmlDoc = CType(WebBrowser1.Document, HtmlDocument)

            HtmlElem = HtmlDoc.GetElementById("kpVariationsTool-captchaImage")

ShowCaptcha:

            If HtmlElem Is Nothing = False Then
                CD = New Captcha
                'captcha
                Nap(300)

                CD.ShowDialog(Me)
                CT = CD.GetCaptchaText()

                HtmlElem = HtmlDoc.GetElementById("kpVariationsTool-captchaAnswer")
                HtmlElem.SetAttribute("value", CT)

                CD = Nothing
            End If

            'keyword
            Dim ci As Integer
            ''ci = ComboBoxGKCountry.SelectedIndex
            ''If ci > 0 Then ci = ci + 26 '1

            ci = ComboBoxGL.SelectedIndex

            Select Case ci
                Case 0
                    'All
                    ci = 0
                Case 1
                    'US
                    ci = 216 + 29

                Case 2
                    'GB
                    ci = 215 + 29

                Case Else
                    If ci < 220 Then
                        '2 => 27
                        ci = ci + 24 '25
                    Else
                        '219 => 245
                        ci = ci + 26 '27
                    End If
            End Select

            HtmlElem = HtmlDoc.GetElementById("countryList")
            HtmlElem.SetAttribute("selectedindex", -1)
            HtmlElem.SetAttribute("selectedindex", ci)
            Debug.Print(HtmlElem.GetAttribute("value"))

            'country
            HtmlElem = HtmlDoc.GetElementById("kpVariationsTool-keyword")
            HtmlElem.SetAttribute("value", SeedKW)


            'click button
            HtmlElem = HtmlDoc.GetElementById("kpKeywordPlanner-getKeywordsButton")

            Busy = True
            ErrorURL = vbNullString
            WaitURL = URL
            HtmlElem.InvokeMember("click")

            '-----------------------------------------------
            'Debug.Print("1")
            Do
                HtmlDoc = CType(WebBrowser1.Document, HtmlDocument)
                Nap(3)
                HtmlElem = HtmlDoc.GetElementById("kpLoadingMessage-keywordVariations")
                If HtmlElem.Style.ToLower.Contains("none") Then Exit Do

                'If HtmlDoc.Body.OuterText.Contains("Enter the letters as they are shown in the image above.") = False Then Exit Do
            Loop
            'Debug.Print("2")
            Nap(1000)

            HtmlDoc = CType(WebBrowser1.Document, HtmlDocument)
            'Debug.Print("3")
            'HtmlElem = HtmlDoc.GetElementById("kpVariationsTool-captchaImage")

            'If HtmlElem.GetAttribute("src").ToLower.Contains("nocache") Then GoTo ShowCaptcha
            HtmlElem = HtmlDoc.GetElementById("kpVariationsTool-captchaAnswer")

            If HtmlElem Is Nothing = False Then
                If HtmlElem.GetAttribute("value") = vbNullString Then
                    GoTo ShowCaptcha
                End If
            End If


            'Debug.Print("4")

            'set match type
            HtmlDoc = CType(WebBrowser1.Document, HtmlDocument)

            'Debug.Print("5")

            HtmlElem = HtmlDoc.GetElementById("kpMatchTypeSelector")
            HtmlElem.SetAttribute("selectedindex", -1)
            HtmlColl = HtmlElem.GetElementsByTagName("option")
            For i = 0 To HtmlColl.Count - 1
                Nap(2)
                If HtmlColl(i).OuterText = ComboBoxKeywordType.SelectedItem Then
                    HtmlElem.SetAttribute("selectedindex", i)
                    HtmlElem.InvokeMember("onchange")
                    Exit For
                End If
            Next i

            Nap(200)

            HtmlDoc = CType(WebBrowser1.Document, HtmlDocument)
            HtmlElem = HtmlDoc.GetElementById("kpResultsTable")

            HtmlColl = HtmlElem.GetElementsByTagName("TR")

            GoogleKWList = vbNullString
            For i = 0 To HtmlColl.Count - 1
                HtmlElem = HtmlColl(i)

                tmp = HtmlElem.GetAttribute("className").ToLower
                If tmp = "notKeyword".ToLower Then
                    Exit For
                End If


                If HtmlElem.Id = vbNullString Then Continue For
                If HtmlElem.Id.ToLower.Contains("tr_keywordvariations_") = False Then Continue For


                Nap(2)
                TempColl = HtmlElem.GetElementsByTagName("TD")

                KW = vbNullString
                Adv = vbNullString
                Approx = vbNullString
                Avg = vbNullString

                For j = 0 To TempColl.Count - 1
                    tmp = TempColl(j).GetAttribute("className").ToLower
                    Select Case tmp
                        Case "c0"
                            KW = Replace(TempColl(j).OuterText.Trim, "[", "")
                            KW = Replace(KW, "]", "")
                            KW = Replace(KW, """", "")
                            KW = Replace(KW, ",", "")
                            'KW = KW.trim

                        Case "c3"
                            ' ''Dim indf As Integer
                            ' ''Dim k As Integer
                            ' ''Dim itempcoll As HtmlElementCollection
                            ' ''Dim ttxt As String
                            ' ''Dim trnd As Double

                            ' ''itempcoll = TempColl(j).GetElementsByTagName("div")

                            ' ''indf = 0
                            ' ''For k = 1 To itempcoll.Count - 1
                            ' ''    If itempcoll(k).GetAttribute("className").ToLower = "indicatorBar filled".ToLower Then
                            ' ''        Try
                            ' ''            ttxt = itempcoll(k).Style.ToLower
                            ' ''            ttxt = Replace(ttxt, "width", "")
                            ' ''            ttxt = Replace(ttxt, ":", "")
                            ' ''            ttxt = Replace(ttxt, "px", "")
                            ' ''            If ttxt <> vbNullString Then ttxt = ttxt.Trim

                            ' ''            indf = Convert.ToInt16(ttxt)
                            ' ''        Catch ex As Exception
                            ' ''            indf = 0
                            ' ''        End Try
                            ' ''    End If
                            ' ''    Try
                            ' ''        trnd = indf / 42.0
                            ' ''        Adv = Math.Round(trnd, 2).ToString
                            ' ''    Catch ex As Exception

                            ' ''    End Try
                            ' ''Next k
                            Adv = "1"
                        Case "c4"
                            Approx = Replace(TempColl(j).OuterText.Trim, "Not enough data", "0")
                            Approx = Replace(Approx, ",", "")
                        Case "c5"
                            Avg = Replace(TempColl(j).OuterText.Trim, "Not enough data", "0")
                            Avg = Replace(Avg, ",", "")
                    End Select
                    If KW <> vbNullString And Adv <> vbNullString And Approx <> vbNullString And Avg <> vbNullString Then GoTo OutOfJ
                    Nap(2)
                Next j
OutOfJ:
                GoogleKWList = GoogleKWList & KW & "," & Adv & "," & Approx & "," & Avg & vbNewLine
                Nap(2)

                Nap(3)
            Next i

        Catch ex As Exception
            LabelStatus.Text = "Error occured"
            My.Computer.FileSystem.WriteAllText(ErrorFile, Now & " - Error in GoogleKWList for " & WaitURL & " - " & ex.Message & vbNewLine, True)
            RetVal = False
        End Try


Leave:
        TempColl = Nothing
        CD = Nothing
        HtmlColl = Nothing
        HtmlElem = Nothing
        HtmlDoc = Nothing
        Nap(3)

        Return RetVal
    End Function

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        Debug.Print(e.Url.AbsoluteUri)

        If e.Url.AbsoluteUri.Contains(WaitURL) Then
            Busy = False
            LoadedURL = e.Url.AbsoluteUri
            ErrorLoadingURL = False
        Else
            If ErrorURL <> vbNullString Then
                If e.Url.AbsoluteUri.Contains(ErrorURL) Then
                    Busy = False
                    LoadedURL = e.Url.AbsoluteUri
                    ErrorLoadingURL = True
                End If
            End If
        End If
    End Sub

    Private Function Wait() As Boolean
        Dim RetVal As Boolean
        RetVal = True

        Dim sw As New Stopwatch()

        sw.Start()

        While (Busy)
            Nap(3)

            If sw.ElapsedMilliseconds >= 300000 Then
                'My.Computer.FileSystem.WriteAllText(ErrorFile, Now & " : Error connecting to URL" & WaitURL & vbNewLine, True)
                sw.Stop()
                Busy = False
                RetVal = False
            End If
        End While

        sw = Nothing

        Return RetVal

    End Function

    Private Sub ButtonShowOriginal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonShowOriginal.Click
        PopulateListView(InputCSVContents)
        CollapsiblePanelGenerateKW.PanelState = PanelState.Collapsed
    End Sub

    Private Sub ButtonPR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPR.Click
        If ButtonPR.Text = "Pause" Then
            ButtonPR.Text = "Resume"
            SetUIState(Status.PAUSED)
            LabelStatus.Text = "Paused..."
            Do
                Nap(5)
                System.Threading.Thread.Sleep(200)
                If ButtonPR.Text = "Pause" Then Exit Do
            Loop

        Else
            ButtonPR.Text = "Pause"
            SetUIState(Status.PROCESSING)
            LabelStatus.Text = "Processing..."

        End If
    End Sub

    Private Sub SelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAll.Click, Button5.Click
        Dim i As Integer

        For i = 0 To ListViewCSV.Items.Count - 1
            ListViewCSV.Items(i).Checked = True
            Nap(3)
        Next i
    End Sub

    Private Sub ClearAllTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearAll.Click, Button4.Click
        Dim i As Integer

        For i = 0 To ListViewCSV.Items.Count - 1
            ListViewCSV.Items(i).Checked = False
            Nap(3)
        Next i
    End Sub

    Private Sub DeleteSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelected.Click, Button2.Click
        Dim i As Integer

        For i = 0 To ListViewCSV.CheckedItems.Count - 1
            ListViewCSV.CheckedItems(0).Remove()
            Nap(3)
        Next i

        LabelStatus.Text = "Selected rows deleted"
    End Sub

    Private Sub CleanIECookies()
        Dim DI As DirectoryInfo
        Dim FileArray As FileInfo() = Nothing

        Try
            DI = New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Cookies))
            FileArray = DI.GetFiles("*adword*.*", SearchOption.AllDirectories)
            For Each fi As FileInfo In FileArray
                Debug.WriteLine(fi.FullName)
                Try
                    My.Computer.FileSystem.DeleteFile(fi.FullName)
                Catch ex As Exception

                End Try
            Next

            FileArray = DI.GetFiles("*google*.*", SearchOption.AllDirectories)
            For Each fi As FileInfo In FileArray
                Debug.WriteLine(fi.FullName)
                Try
                    My.Computer.FileSystem.DeleteFile(fi.FullName)
                Catch ex As Exception

                End Try
            Next

        Catch ex As Exception

        End Try


    End Sub

    Private Sub CopySelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopySelected.Click, Button1.Click
        Dim i As Integer, j As Integer
        Dim CBBuff As String = vbNullString

        For i = 0 To ListViewCSV.CheckedItems.Count - 1
            For j = 0 To CNT_IDX
                CBBuff = CBBuff & ListViewCSV.CheckedItems(i).SubItems(j).Text
                If j < CNT_IDX Then
                    CBBuff = CBBuff & vbTab
                End If
                Nap(3)
            Next j
            CBBuff = CBBuff & vbNewLine
            Nap(3)
        Next i

        If CBBuff = vbNullString Then GoTo Leave

        My.Computer.Clipboard.SetText(CBBuff)

        LabelStatus.Text = "Selected rows copied to clip-board"

Leave:
    End Sub

    Private Sub InvertSelection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvertSelection.Click, Button3.Click
        Dim i As Integer

        For i = 0 To ListViewCSV.Items.Count - 1
            ListViewCSV.Items(i).Checked = Not ListViewCSV.Items(i).Checked
            Nap(3)
        Next i
    End Sub

    Private Sub CollapsiblePanelGenerateKW_PanelStateChanged(ByVal sender As System.Object, ByVal e As Salamander.Windows.Forms.PanelEventArgs) Handles CollapsiblePanelGenerateKW.PanelStateChanged
        If CollapsiblePanelGenerateKW.PanelState = PanelState.Collapsed Then
            CollapsiblePanelResults.PanelState = PanelState.Expanded
        ElseIf CollapsiblePanelGenerateKW.PanelState = PanelState.Expanded Then
            CollapsiblePanelResults.PanelState = PanelState.Collapsed
        End If
    End Sub

    Private Sub CollapsiblePanelResults_PanelStateChanged(ByVal sender As System.Object, ByVal e As Salamander.Windows.Forms.PanelEventArgs) Handles CollapsiblePanelResults.PanelStateChanged
        If CollapsiblePanelResults.PanelState = PanelState.Collapsed Then
            CollapsiblePanelGenerateKW.PanelState = PanelState.Expanded
        ElseIf CollapsiblePanelResults.PanelState = PanelState.Expanded Then
            CollapsiblePanelGenerateKW.PanelState = PanelState.Collapsed
        End If
    End Sub

    Private Sub CollapsiblePanelOptions_PanelStateChanged(ByVal sender As System.Object, ByVal e As Salamander.Windows.Forms.PanelEventArgs) Handles CollapsiblePanelOptions.PanelStateChanged
        If CollapsiblePanelOptions.PanelState = PanelState.Collapsed Then
            PanelOptions.Location = New Point(1, 62)
        ElseIf CollapsiblePanelOptions.PanelState = PanelState.Expanded Then
            PanelOptions.Location = New Point(1, 224)
        End If
    End Sub
End Class








