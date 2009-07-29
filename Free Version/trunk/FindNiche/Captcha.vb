Imports System.Windows.Forms

Public Class Captcha

    Private CT As String
    Public Function GetCaptchaText() As String

        'While CT = vbNullString
        '    Nap(500)
        'End While

        Return CT
    End Function

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        ShowCaptcha()
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Dim tmp As String
        tmp = TextBoxCaptcha.Text
        If tmp <> vbNullString Then tmp = tmp.Trim

        If tmp = vbNullString Then Exit Sub

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        CT = tmp
        Me.Close()
    End Sub

    Private Sub Captcha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CT = vbNullString
        Me.Visible = True
        ShowCaptcha()
    End Sub

    Private Sub ShowCaptcha()
        WebBrowserCaptcha.Navigate("https://adwords.google.com/select/KeywordToolCaptcha")
        TextBoxCaptcha.Focus()
    End Sub

    Private Sub Nap(ByVal cnt As Integer)

        While cnt > 0
            Application.DoEvents()
            cnt = cnt - 1
        End While
    End Sub

End Class
