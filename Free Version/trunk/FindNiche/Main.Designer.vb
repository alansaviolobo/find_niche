<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GroupBoxGenerateCount = New System.Windows.Forms.GroupBox
        Me.ButtonPR = New System.Windows.Forms.Button
        Me.ButtonProcess = New System.Windows.Forms.Button
        Me.SpinBoxThrottle = New System.Windows.Forms.NumericUpDown
        Me.LabelThrottle = New System.Windows.Forms.Label
        Me.CMForLV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectAll = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearAll = New System.Windows.Forms.ToolStripMenuItem
        Me.InvertSelection = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteSelected = New System.Windows.Forms.ToolStripMenuItem
        Me.CopySelected = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveFileDlg = New System.Windows.Forms.SaveFileDialog
        Me.GroupBoxFilter = New System.Windows.Forms.GroupBox
        Me.CheckBoxFilterCount = New System.Windows.Forms.CheckBox
        Me.CheckBoxFilterAvg = New System.Windows.Forms.CheckBox
        Me.CheckBoxFilterApprox = New System.Windows.Forms.CheckBox
        Me.SBCntMin = New System.Windows.Forms.NumericUpDown
        Me.SBCntMax = New System.Windows.Forms.NumericUpDown
        Me.ButtonShowOriginal = New System.Windows.Forms.Button
        Me.ButtonFilter = New System.Windows.Forms.Button
        Me.LabelFilterLower = New System.Windows.Forms.Label
        Me.LabelFilterUpper = New System.Windows.Forms.Label
        Me.SBAvgMin = New System.Windows.Forms.NumericUpDown
        Me.SBAvgMax = New System.Windows.Forms.NumericUpDown
        Me.SBApproxMax = New System.Windows.Forms.NumericUpDown
        Me.SBApproxMin = New System.Windows.Forms.NumericUpDown
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.GroupBoxGenerateKW = New System.Windows.Forms.GroupBox
        Me.CheckBoxAGKWR = New System.Windows.Forms.CheckBox
        Me.ButtonGenerateKW = New System.Windows.Forms.Button
        Me.ComboBoxGL = New System.Windows.Forms.ComboBox
        Me.LabelCountry = New System.Windows.Forms.Label
        Me.ComboBoxKeywordType = New System.Windows.Forms.ComboBox
        Me.LabelKeywordType = New System.Windows.Forms.Label
        Me.TextBoxSeedKeyword = New System.Windows.Forms.TextBox
        Me.LabelSeedKW = New System.Windows.Forms.Label
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.GroupBoxExport = New System.Windows.Forms.GroupBox
        Me.TextBoxExport = New System.Windows.Forms.TextBox
        Me.ButtonExport = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.ListViewCSV = New System.Windows.Forms.ListView
        Me.CollapsiblePanelBar2 = New Salamander.Windows.Forms.CollapsiblePanelBar
        Me.CollapsiblePanelResult = New Salamander.Windows.Forms.CollapsiblePanel
        Me.CollapsiblePanelFilter = New Salamander.Windows.Forms.CollapsiblePanel
        Me.CollapsiblePanelSW = New Salamander.Windows.Forms.CollapsiblePanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBoxAIR = New System.Windows.Forms.CheckBox
        Me.ButtonImport = New System.Windows.Forms.Button
        Me.TextBoxImport = New System.Windows.Forms.TextBox
        Me.ButtonSelectFile = New System.Windows.Forms.Button
        Me.LabelStatus = New System.Windows.Forms.Label
        Me.OpenFileDlg = New System.Windows.Forms.OpenFileDialog
        Me.GroupBoxGenerateCount.SuspendLayout()
        CType(Me.SpinBoxThrottle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMForLV.SuspendLayout()
        Me.GroupBoxFilter.SuspendLayout()
        CType(Me.SBCntMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBCntMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBAvgMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBAvgMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBApproxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBApproxMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGenerateKW.SuspendLayout()
        Me.GroupBoxExport.SuspendLayout()
        CType(Me.CollapsiblePanelBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CollapsiblePanelBar2.SuspendLayout()
        Me.CollapsiblePanelResult.SuspendLayout()
        Me.CollapsiblePanelFilter.SuspendLayout()
        Me.CollapsiblePanelSW.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxGenerateCount
        '
        Me.GroupBoxGenerateCount.Controls.Add(Me.ButtonPR)
        Me.GroupBoxGenerateCount.Controls.Add(Me.ButtonProcess)
        Me.GroupBoxGenerateCount.Controls.Add(Me.SpinBoxThrottle)
        Me.GroupBoxGenerateCount.Controls.Add(Me.LabelThrottle)
        Me.GroupBoxGenerateCount.Location = New System.Drawing.Point(12, 37)
        Me.GroupBoxGenerateCount.Name = "GroupBoxGenerateCount"
        Me.GroupBoxGenerateCount.Size = New System.Drawing.Size(418, 56)
        Me.GroupBoxGenerateCount.TabIndex = 0
        Me.GroupBoxGenerateCount.TabStop = False
        Me.GroupBoxGenerateCount.Text = "Generate Count"
        '
        'ButtonPR
        '
        Me.ButtonPR.Location = New System.Drawing.Point(330, 22)
        Me.ButtonPR.Name = "ButtonPR"
        Me.ButtonPR.Size = New System.Drawing.Size(78, 23)
        Me.ButtonPR.TabIndex = 27
        Me.ButtonPR.Text = "Pause"
        Me.ButtonPR.UseVisualStyleBackColor = True
        '
        'ButtonProcess
        '
        Me.ButtonProcess.Location = New System.Drawing.Point(246, 22)
        Me.ButtonProcess.Name = "ButtonProcess"
        Me.ButtonProcess.Size = New System.Drawing.Size(78, 23)
        Me.ButtonProcess.TabIndex = 26
        Me.ButtonProcess.Text = "Start"
        Me.ButtonProcess.UseVisualStyleBackColor = True
        '
        'SpinBoxThrottle
        '
        Me.SpinBoxThrottle.Location = New System.Drawing.Point(194, 22)
        Me.SpinBoxThrottle.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SpinBoxThrottle.Name = "SpinBoxThrottle"
        Me.SpinBoxThrottle.Size = New System.Drawing.Size(41, 20)
        Me.SpinBoxThrottle.TabIndex = 6
        Me.SpinBoxThrottle.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelThrottle
        '
        Me.LabelThrottle.AutoSize = True
        Me.LabelThrottle.Location = New System.Drawing.Point(9, 24)
        Me.LabelThrottle.Name = "LabelThrottle"
        Me.LabelThrottle.Size = New System.Drawing.Size(182, 13)
        Me.LabelThrottle.TabIndex = 5
        Me.LabelThrottle.Text = "Throttle (seconds between requests):"
        '
        'CMForLV
        '
        Me.CMForLV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectAll, Me.ClearAll, Me.InvertSelection, Me.DeleteSelected, Me.CopySelected})
        Me.CMForLV.Name = "CMForLV"
        Me.CMForLV.Size = New System.Drawing.Size(156, 114)
        '
        'SelectAll
        '
        Me.SelectAll.Name = "SelectAll"
        Me.SelectAll.Size = New System.Drawing.Size(155, 22)
        Me.SelectAll.Text = "Select All"
        '
        'ClearAll
        '
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(155, 22)
        Me.ClearAll.Text = "Clear All"
        '
        'InvertSelection
        '
        Me.InvertSelection.Name = "InvertSelection"
        Me.InvertSelection.Size = New System.Drawing.Size(155, 22)
        Me.InvertSelection.Text = "Invert Selection"
        '
        'DeleteSelected
        '
        Me.DeleteSelected.Name = "DeleteSelected"
        Me.DeleteSelected.Size = New System.Drawing.Size(155, 22)
        Me.DeleteSelected.Text = "Delete Selected"
        '
        'CopySelected
        '
        Me.CopySelected.Name = "CopySelected"
        Me.CopySelected.Size = New System.Drawing.Size(155, 22)
        Me.CopySelected.Text = "Copy Selected"
        '
        'SaveFileDlg
        '
        Me.SaveFileDlg.DefaultExt = "csv"
        Me.SaveFileDlg.Filter = "CSV files|*.csv"
        Me.SaveFileDlg.Title = "Save CSV file"
        '
        'GroupBoxFilter
        '
        Me.GroupBoxFilter.Controls.Add(Me.CheckBoxFilterCount)
        Me.GroupBoxFilter.Controls.Add(Me.CheckBoxFilterAvg)
        Me.GroupBoxFilter.Controls.Add(Me.CheckBoxFilterApprox)
        Me.GroupBoxFilter.Controls.Add(Me.SBCntMin)
        Me.GroupBoxFilter.Controls.Add(Me.SBCntMax)
        Me.GroupBoxFilter.Controls.Add(Me.ButtonShowOriginal)
        Me.GroupBoxFilter.Controls.Add(Me.ButtonFilter)
        Me.GroupBoxFilter.Controls.Add(Me.LabelFilterLower)
        Me.GroupBoxFilter.Controls.Add(Me.LabelFilterUpper)
        Me.GroupBoxFilter.Controls.Add(Me.SBAvgMin)
        Me.GroupBoxFilter.Controls.Add(Me.SBAvgMax)
        Me.GroupBoxFilter.Controls.Add(Me.SBApproxMax)
        Me.GroupBoxFilter.Controls.Add(Me.SBApproxMin)
        Me.GroupBoxFilter.Location = New System.Drawing.Point(12, 99)
        Me.GroupBoxFilter.Name = "GroupBoxFilter"
        Me.GroupBoxFilter.Size = New System.Drawing.Size(418, 106)
        Me.GroupBoxFilter.TabIndex = 7
        Me.GroupBoxFilter.TabStop = False
        Me.GroupBoxFilter.Text = "Filter List"
        '
        'CheckBoxFilterCount
        '
        Me.CheckBoxFilterCount.AutoSize = True
        Me.CheckBoxFilterCount.Location = New System.Drawing.Point(12, 76)
        Me.CheckBoxFilterCount.Name = "CheckBoxFilterCount"
        Me.CheckBoxFilterCount.Size = New System.Drawing.Size(62, 17)
        Me.CheckBoxFilterCount.TabIndex = 44
        Me.CheckBoxFilterCount.Text = "Phrase:"
        Me.CheckBoxFilterCount.UseVisualStyleBackColor = True
        '
        'CheckBoxFilterAvg
        '
        Me.CheckBoxFilterAvg.AutoSize = True
        Me.CheckBoxFilterAvg.Location = New System.Drawing.Point(12, 53)
        Me.CheckBoxFilterAvg.Name = "CheckBoxFilterAvg"
        Me.CheckBoxFilterAvg.Size = New System.Drawing.Size(59, 17)
        Me.CheckBoxFilterAvg.TabIndex = 43
        Me.CheckBoxFilterAvg.Text = "Global:"
        Me.CheckBoxFilterAvg.UseVisualStyleBackColor = True
        '
        'CheckBoxFilterApprox
        '
        Me.CheckBoxFilterApprox.AutoSize = True
        Me.CheckBoxFilterApprox.Location = New System.Drawing.Point(12, 29)
        Me.CheckBoxFilterApprox.Name = "CheckBoxFilterApprox"
        Me.CheckBoxFilterApprox.Size = New System.Drawing.Size(55, 17)
        Me.CheckBoxFilterApprox.TabIndex = 42
        Me.CheckBoxFilterApprox.Text = "Local:"
        Me.CheckBoxFilterApprox.UseVisualStyleBackColor = True
        '
        'SBCntMin
        '
        Me.SBCntMin.Location = New System.Drawing.Point(83, 78)
        Me.SBCntMin.Maximum = New Decimal(New Integer() {-559939584, 902409669, 54, 0})
        Me.SBCntMin.Minimum = New Decimal(New Integer() {1661992960, 1808227885, 5, -2147483648})
        Me.SBCntMin.Name = "SBCntMin"
        Me.SBCntMin.Size = New System.Drawing.Size(99, 20)
        Me.SBCntMin.TabIndex = 17
        '
        'SBCntMax
        '
        Me.SBCntMax.Location = New System.Drawing.Point(194, 78)
        Me.SBCntMax.Maximum = New Decimal(New Integer() {-559939584, 902409669, 54, 0})
        Me.SBCntMax.Minimum = New Decimal(New Integer() {1661992960, 1808227885, 5, -2147483648})
        Me.SBCntMax.Name = "SBCntMax"
        Me.SBCntMax.Size = New System.Drawing.Size(94, 20)
        Me.SBCntMax.TabIndex = 18
        '
        'ButtonShowOriginal
        '
        Me.ButtonShowOriginal.Location = New System.Drawing.Point(313, 61)
        Me.ButtonShowOriginal.Name = "ButtonShowOriginal"
        Me.ButtonShowOriginal.Size = New System.Drawing.Size(91, 23)
        Me.ButtonShowOriginal.TabIndex = 20
        Me.ButtonShowOriginal.Text = "Show Original"
        Me.ButtonShowOriginal.UseVisualStyleBackColor = True
        '
        'ButtonFilter
        '
        Me.ButtonFilter.Location = New System.Drawing.Point(314, 29)
        Me.ButtonFilter.Name = "ButtonFilter"
        Me.ButtonFilter.Size = New System.Drawing.Size(91, 23)
        Me.ButtonFilter.TabIndex = 19
        Me.ButtonFilter.Text = "Apply Filters"
        Me.ButtonFilter.UseVisualStyleBackColor = True
        '
        'LabelFilterLower
        '
        Me.LabelFilterLower.AutoSize = True
        Me.LabelFilterLower.Location = New System.Drawing.Point(80, 16)
        Me.LabelFilterLower.Name = "LabelFilterLower"
        Me.LabelFilterLower.Size = New System.Drawing.Size(47, 13)
        Me.LabelFilterLower.TabIndex = 8
        Me.LabelFilterLower.Text = "LOWER"
        '
        'LabelFilterUpper
        '
        Me.LabelFilterUpper.AutoSize = True
        Me.LabelFilterUpper.Location = New System.Drawing.Point(195, 16)
        Me.LabelFilterUpper.Name = "LabelFilterUpper"
        Me.LabelFilterUpper.Size = New System.Drawing.Size(44, 13)
        Me.LabelFilterUpper.TabIndex = 9
        Me.LabelFilterUpper.Text = "UPPER"
        '
        'SBAvgMin
        '
        Me.SBAvgMin.Location = New System.Drawing.Point(83, 55)
        Me.SBAvgMin.Maximum = New Decimal(New Integer() {-559939584, 902409669, 54, 0})
        Me.SBAvgMin.Minimum = New Decimal(New Integer() {1661992960, 1808227885, 5, -2147483648})
        Me.SBAvgMin.Name = "SBAvgMin"
        Me.SBAvgMin.Size = New System.Drawing.Size(99, 20)
        Me.SBAvgMin.TabIndex = 14
        '
        'SBAvgMax
        '
        Me.SBAvgMax.Location = New System.Drawing.Point(194, 55)
        Me.SBAvgMax.Maximum = New Decimal(New Integer() {-559939584, 902409669, 54, 0})
        Me.SBAvgMax.Minimum = New Decimal(New Integer() {1661992960, 1808227885, 5, -2147483648})
        Me.SBAvgMax.Name = "SBAvgMax"
        Me.SBAvgMax.Size = New System.Drawing.Size(94, 20)
        Me.SBAvgMax.TabIndex = 15
        '
        'SBApproxMax
        '
        Me.SBApproxMax.Location = New System.Drawing.Point(194, 32)
        Me.SBApproxMax.Maximum = New Decimal(New Integer() {-559939584, 902409669, 54, 0})
        Me.SBApproxMax.Minimum = New Decimal(New Integer() {1661992960, 1808227885, 5, -2147483648})
        Me.SBApproxMax.Name = "SBApproxMax"
        Me.SBApproxMax.Size = New System.Drawing.Size(94, 20)
        Me.SBApproxMax.TabIndex = 12
        '
        'SBApproxMin
        '
        Me.SBApproxMin.Location = New System.Drawing.Point(83, 32)
        Me.SBApproxMin.Maximum = New Decimal(New Integer() {-559939584, 902409669, 54, 0})
        Me.SBApproxMin.Minimum = New Decimal(New Integer() {1661992960, 1808227885, 5, -2147483648})
        Me.SBApproxMin.Name = "SBApproxMin"
        Me.SBApproxMin.Size = New System.Drawing.Size(99, 20)
        Me.SBApproxMin.TabIndex = 11
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkLabel1.Location = New System.Drawing.Point(0, 505)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(455, 23)
        Me.LinkLabel1.TabIndex = 27
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "For support and updates please visit www.nichetaser.com"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBoxGenerateKW
        '
        Me.GroupBoxGenerateKW.Controls.Add(Me.CheckBoxAGKWR)
        Me.GroupBoxGenerateKW.Controls.Add(Me.ButtonGenerateKW)
        Me.GroupBoxGenerateKW.Controls.Add(Me.ComboBoxGL)
        Me.GroupBoxGenerateKW.Controls.Add(Me.LabelCountry)
        Me.GroupBoxGenerateKW.Controls.Add(Me.ComboBoxKeywordType)
        Me.GroupBoxGenerateKW.Controls.Add(Me.LabelKeywordType)
        Me.GroupBoxGenerateKW.Controls.Add(Me.TextBoxSeedKeyword)
        Me.GroupBoxGenerateKW.Controls.Add(Me.LabelSeedKW)
        Me.GroupBoxGenerateKW.Controls.Add(Me.WebBrowser1)
        Me.GroupBoxGenerateKW.Location = New System.Drawing.Point(12, 28)
        Me.GroupBoxGenerateKW.Name = "GroupBoxGenerateKW"
        Me.GroupBoxGenerateKW.Size = New System.Drawing.Size(418, 150)
        Me.GroupBoxGenerateKW.TabIndex = 29
        Me.GroupBoxGenerateKW.TabStop = False
        Me.GroupBoxGenerateKW.Text = "Generate Keyword List"
        '
        'CheckBoxAGKWR
        '
        Me.CheckBoxAGKWR.AutoSize = True
        Me.CheckBoxAGKWR.Location = New System.Drawing.Point(98, 124)
        Me.CheckBoxAGKWR.Name = "CheckBoxAGKWR"
        Me.CheckBoxAGKWR.Size = New System.Drawing.Size(101, 17)
        Me.CheckBoxAGKWR.TabIndex = 29
        Me.CheckBoxAGKWR.Text = "Append Results"
        Me.CheckBoxAGKWR.UseVisualStyleBackColor = True
        '
        'ButtonGenerateKW
        '
        Me.ButtonGenerateKW.Location = New System.Drawing.Point(330, 119)
        Me.ButtonGenerateKW.Name = "ButtonGenerateKW"
        Me.ButtonGenerateKW.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGenerateKW.TabIndex = 23
        Me.ButtonGenerateKW.Text = "Generate"
        Me.ButtonGenerateKW.UseVisualStyleBackColor = True
        '
        'ComboBoxGL
        '
        Me.ComboBoxGL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxGL.FormattingEnabled = True
        Me.ComboBoxGL.Items.AddRange(New Object() {"All Countries & Territories:US", "United States:US", "United Kingdom:GB", "Afghanistan:AF", "Albania:AL", "Algeria:DZ", "American Samoa:AS", "Andorra:AD", "Angola:AO", "Anguilla:AI", "Antarctica:AQ", "Antigua and Barbuda:AG", "Argentina:AR", "Armenia:AM", "Aruba:AW", "Australia:AU", "Austria:AT", "Azerbaijan:AZ", "Bahamas:BS", "Bahrain:BH", "Bangladesh:BD", "Barbados:BB", "Belarus:BY", "Belgium:BE", "Belize:BZ", "Benin:BJ", "Bermuda:BM", "Bhutan:BT", "Bolivia:BO", "Bosnia and Herzegovina:BA", "Botswana:BW", "Bouvet Island:BV", "Brazil:BR", "British Indian Ocean Territory:IO", "Brunei Darussalam:BN", "Bulgaria:BG", "Burkina Faso:BF", "Burundi:BI", "Cambodia:KH", "Cameroon:CM", "Canada:CA", "Cape Verde:CV", "Cayman Islands:KY", "Central African Republic:CF", "Chad:TD", "Chile:CL", "China:CN", "Christmas Island:CX", "Cocos (Keeling) Islands:CC", "Colombia:CO", "Comoros:KM", "Congo:CG", "Congo, Democratic Republic:CD", "Cook Islands:CK", "Costa Rica:CR", "Cote d'Ivoire:CI", "Croatia:HR", "Cyprus:CY", "Czech Republic:CZ", "Denmark:DK", "Djibouti:DJ", "Dominica:DM", "Dominican Republic:DO", "East Timor:TL", "Ecuador:EC", "Egypt:EG", "El Salvador:SV", "Equatorial Guinea:GQ", "Eritrea:ER", "Estonia:EE", "Ethiopia:ET", "Falkland Islands (Malvinas):FK", "Faroe Islands:FO", "Fiji:FJ", "Finland:FI", "France:FR", "French Guiana:GF", "French Polynesia:PF", "French Southern Territories:TF", "Gabon:GA", "Gambia:GM", "Georgia:GE", "Germany:DE", "Ghana:GH", "Gibraltar:GI", "Greece:GR", "Greenland:GL", "Grenada:GD", "Guadeloupe:GP", "Guam:GU", "Guatemala:GT", "Guinea:GN", "Guinea-Bissau:GW", "Guyana:GY", "Haiti:HT", "Heard and McDonald Islands:HM", "Honduras:HN", "Hong Kong:HK", "Hungary:HU", "Iceland:IS", "India:IN", "Indonesia:ID", "Iraq:IQ", "Ireland:IE", "Israel:IL", "Italy:IT", "Jamaica:JM", "Japan:JP", "Jordan:JO", "Kazakhstan:KZ", "Kenya:KE", "Kiribati:KI", "Kuwait:KW", "Kyrgyzstan:KG", "Lao People's Democratic Republic:LA", "Latvia:LV", "Lebanon:LB", "Lesotho:LS", "Liberia:LR", "Libya:LY", "Liechtenstein:LI", "Lithuania:LT", "Luxembourg:LU", "Macau:MO", "Macedonia:MK", "Madagascar:MG", "Malawi:MW", "Malaysia:MY", "Maldives:MV", "Mali:ML", "Malta:MT", "Marshall Islands:MH", "Martinique:MQ", "Mauritania:MR", "Mauritius:MU", "Mayotte:YT", "Mexico:MX", "Micronesia:FM", "Moldova:MD", "Monaco:MC", "Mongolia:MN", "Montserrat:MS", "Morocco:MA", "Mozambique:MZ", "Namibia:NA", "Nauru:NR", "Nepal:NP", "Netherlands:NL", "Netherlands Antilles:AN", "New Caledonia:NC", "New Zealand:NZ", "Nicaragua:NI", "Niger:NE", "Nigeria:NG", "Niue:NU", "Norfolk Island:NF", "Northern Mariana Islands:MP", "Norway:NO", "Oman:OM", "Pakistan:PK", "Palau:PW", "Palestinian Territory:PS", "Panama:PA", "Papua New Guinea:PG", "Paraguay:PY", "Peru:PE", "Philippines:PH", "Pitcairn:PN", "Poland:PL", "Portugal:PT", "Puerto Rico:PR", "Qatar:QA", "Reunion:RE", "Romania:RO", "Russian Federation:RU", "Rwanda:RW", "Saint Kitts and Nevis:KN", "Saint Lucia:LC", "Saint Vincent and the Grenadines:VC", "Samoa:WS", "San Marino:SM", "Sao Tome and Principe:ST", "Saudi Arabia:SA", "Senegal:SN", "Serbia and Montenegro:CS", "Seychelles:SC", "Sierra Leone:SL", "Singapore:SG", "Slovakia:SK", "Slovenia:SI", "Solomon Islands:SB", "Somalia:SO", "South Africa:ZA", "South Georgia and The South Sandwich Islands:GS", "South Korea:KR", "Spain:ES", "Sri Lanka:LK", "St. Helena:SH", "St. Pierre and Miquelon:PM", "Suriname:SR", "Svalbard and Jan Mayen Islands:SJ", "Swaziland:SZ", "Sweden:SE", "Switzerland:CH", "Taiwan:TW", "Tajikistan:TJ", "Tanzania:TZ", "Thailand:TH", "Togo:TG", "Tokelau:TK", "Tonga:TO", "Trinidad and Tobago:TT", "Tunisia:TN", "Turkey:TR", "Turkmenistan:TM", "Turks and Caicos Islands:TC", "Tuvalu:TV", "Uganda:UG", "Ukraine:UA", "United Arab Emirates:AE", "United States Minor Outlying Islands:UM", "Uruguay:UY", "Uzbekistan:UZ", "Vanuatu:VU", "Vatican:VA", "Venezuela:VE", "Viet Nam:VN", "Virgin Islands (British):VG", "Virgin Islands (U.S.):VI", "Wallis and Futuna Islands:WF", "Western Sahara:EH", "Yemen:YE", "Zambia:ZM", "Zimbabwe:ZW"})
        Me.ComboBoxGL.Location = New System.Drawing.Point(97, 93)
        Me.ComboBoxGL.Name = "ComboBoxGL"
        Me.ComboBoxGL.Size = New System.Drawing.Size(213, 21)
        Me.ComboBoxGL.TabIndex = 4
        '
        'LabelCountry
        '
        Me.LabelCountry.AutoSize = True
        Me.LabelCountry.Location = New System.Drawing.Point(9, 94)
        Me.LabelCountry.Name = "LabelCountry"
        Me.LabelCountry.Size = New System.Drawing.Size(52, 13)
        Me.LabelCountry.TabIndex = 20
        Me.LabelCountry.Text = "Country : "
        '
        'ComboBoxKeywordType
        '
        Me.ComboBoxKeywordType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxKeywordType.FormattingEnabled = True
        Me.ComboBoxKeywordType.Items.AddRange(New Object() {"Exact", "Broad", "Phrase"})
        Me.ComboBoxKeywordType.Location = New System.Drawing.Point(330, 22)
        Me.ComboBoxKeywordType.Name = "ComboBoxKeywordType"
        Me.ComboBoxKeywordType.Size = New System.Drawing.Size(74, 21)
        Me.ComboBoxKeywordType.TabIndex = 6
        '
        'LabelKeywordType
        '
        Me.LabelKeywordType.AutoSize = True
        Me.LabelKeywordType.Location = New System.Drawing.Point(246, 25)
        Me.LabelKeywordType.Name = "LabelKeywordType"
        Me.LabelKeywordType.Size = New System.Drawing.Size(78, 13)
        Me.LabelKeywordType.TabIndex = 5
        Me.LabelKeywordType.Text = "Keyword Type:"
        '
        'TextBoxSeedKeyword
        '
        Me.TextBoxSeedKeyword.Location = New System.Drawing.Point(97, 22)
        Me.TextBoxSeedKeyword.Multiline = True
        Me.TextBoxSeedKeyword.Name = "TextBoxSeedKeyword"
        Me.TextBoxSeedKeyword.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxSeedKeyword.Size = New System.Drawing.Size(141, 56)
        Me.TextBoxSeedKeyword.TabIndex = 4
        '
        'LabelSeedKW
        '
        Me.LabelSeedKW.AutoSize = True
        Me.LabelSeedKW.Location = New System.Drawing.Point(9, 25)
        Me.LabelSeedKW.Name = "LabelSeedKW"
        Me.LabelSeedKW.Size = New System.Drawing.Size(79, 13)
        Me.LabelSeedKW.TabIndex = 3
        Me.LabelSeedKW.Text = "Seed Keyword:"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(398, -13)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.TabIndex = 28
        Me.WebBrowser1.Visible = False
        '
        'GroupBoxExport
        '
        Me.GroupBoxExport.Controls.Add(Me.TextBoxExport)
        Me.GroupBoxExport.Controls.Add(Me.ButtonExport)
        Me.GroupBoxExport.Location = New System.Drawing.Point(12, 272)
        Me.GroupBoxExport.Name = "GroupBoxExport"
        Me.GroupBoxExport.Size = New System.Drawing.Size(418, 57)
        Me.GroupBoxExport.TabIndex = 21
        Me.GroupBoxExport.TabStop = False
        Me.GroupBoxExport.Text = "Export"
        '
        'TextBoxExport
        '
        Me.TextBoxExport.Location = New System.Drawing.Point(132, 21)
        Me.TextBoxExport.Name = "TextBoxExport"
        Me.TextBoxExport.Size = New System.Drawing.Size(263, 20)
        Me.TextBoxExport.TabIndex = 28
        '
        'ButtonExport
        '
        Me.ButtonExport.Location = New System.Drawing.Point(23, 19)
        Me.ButtonExport.Name = "ButtonExport"
        Me.ButtonExport.Size = New System.Drawing.Size(91, 23)
        Me.ButtonExport.TabIndex = 27
        Me.ButtonExport.Text = "Export"
        Me.ButtonExport.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Copy Selected"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(251, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Delete Selected"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(4, 34)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "Select All"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(156, 34)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "Invert Selection"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(80, 34)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Clear All"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ListViewCSV
        '
        Me.ListViewCSV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListViewCSV.CheckBoxes = True
        Me.ListViewCSV.ContextMenuStrip = Me.CMForLV
        Me.ListViewCSV.Location = New System.Drawing.Point(4, 73)
        Me.ListViewCSV.Name = "ListViewCSV"
        Me.ListViewCSV.Size = New System.Drawing.Size(435, 150)
        Me.ListViewCSV.TabIndex = 26
        Me.ListViewCSV.UseCompatibleStateImageBehavior = False
        '
        'CollapsiblePanelBar2
        '
        Me.CollapsiblePanelBar2.BackColor = System.Drawing.SystemColors.Control
        Me.CollapsiblePanelBar2.Border = 8
        Me.CollapsiblePanelBar2.Controls.Add(Me.CollapsiblePanelResult)
        Me.CollapsiblePanelBar2.Controls.Add(Me.CollapsiblePanelFilter)
        Me.CollapsiblePanelBar2.Controls.Add(Me.CollapsiblePanelSW)
        Me.CollapsiblePanelBar2.Location = New System.Drawing.Point(3, 4)
        Me.CollapsiblePanelBar2.Name = "CollapsiblePanelBar2"
        Me.CollapsiblePanelBar2.Size = New System.Drawing.Size(458, 498)
        Me.CollapsiblePanelBar2.Spacing = 8
        Me.CollapsiblePanelBar2.TabIndex = 30
        '
        'CollapsiblePanelResult
        '
        Me.CollapsiblePanelResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CollapsiblePanelResult.BackColor = System.Drawing.SystemColors.Control
        Me.CollapsiblePanelResult.Controls.Add(Me.Button1)
        Me.CollapsiblePanelResult.Controls.Add(Me.Button5)
        Me.CollapsiblePanelResult.Controls.Add(Me.Button2)
        Me.CollapsiblePanelResult.Controls.Add(Me.ListViewCSV)
        Me.CollapsiblePanelResult.Controls.Add(Me.Button4)
        Me.CollapsiblePanelResult.Controls.Add(Me.Button3)
        Me.CollapsiblePanelResult.EndColour = System.Drawing.SystemColors.Menu
        Me.CollapsiblePanelResult.Image = Nothing
        Me.CollapsiblePanelResult.Location = New System.Drawing.Point(8, 668)
        Me.CollapsiblePanelResult.Name = "CollapsiblePanelResult"
        Me.CollapsiblePanelResult.PanelState = Salamander.Windows.Forms.PanelState.Expanded
        Me.CollapsiblePanelResult.Size = New System.Drawing.Size(442, 226)
        Me.CollapsiblePanelResult.StartColour = System.Drawing.Color.White
        Me.CollapsiblePanelResult.TabIndex = 31
        Me.CollapsiblePanelResult.TitleFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollapsiblePanelResult.TitleFontColour = System.Drawing.Color.Navy
        Me.CollapsiblePanelResult.TitleText = "Result"
        '
        'CollapsiblePanelFilter
        '
        Me.CollapsiblePanelFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CollapsiblePanelFilter.BackColor = System.Drawing.SystemColors.Control
        Me.CollapsiblePanelFilter.Controls.Add(Me.GroupBoxGenerateCount)
        Me.CollapsiblePanelFilter.Controls.Add(Me.GroupBoxFilter)
        Me.CollapsiblePanelFilter.EndColour = System.Drawing.SystemColors.Menu
        Me.CollapsiblePanelFilter.Image = Nothing
        Me.CollapsiblePanelFilter.Location = New System.Drawing.Point(8, 438)
        Me.CollapsiblePanelFilter.Name = "CollapsiblePanelFilter"
        Me.CollapsiblePanelFilter.PanelState = Salamander.Windows.Forms.PanelState.Expanded
        Me.CollapsiblePanelFilter.Size = New System.Drawing.Size(442, 222)
        Me.CollapsiblePanelFilter.StartColour = System.Drawing.Color.White
        Me.CollapsiblePanelFilter.TabIndex = 1
        Me.CollapsiblePanelFilter.TitleFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollapsiblePanelFilter.TitleFontColour = System.Drawing.Color.Navy
        Me.CollapsiblePanelFilter.TitleText = "Filter"
        '
        'CollapsiblePanelSW
        '
        Me.CollapsiblePanelSW.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CollapsiblePanelSW.BackColor = System.Drawing.SystemColors.Control
        Me.CollapsiblePanelSW.Controls.Add(Me.GroupBoxGenerateKW)
        Me.CollapsiblePanelSW.Controls.Add(Me.GroupBox1)
        Me.CollapsiblePanelSW.Controls.Add(Me.LabelStatus)
        Me.CollapsiblePanelSW.Controls.Add(Me.GroupBoxExport)
        Me.CollapsiblePanelSW.EndColour = System.Drawing.SystemColors.Menu
        Me.CollapsiblePanelSW.Image = Nothing
        Me.CollapsiblePanelSW.Location = New System.Drawing.Point(8, 8)
        Me.CollapsiblePanelSW.Name = "CollapsiblePanelSW"
        Me.CollapsiblePanelSW.PanelState = Salamander.Windows.Forms.PanelState.Expanded
        Me.CollapsiblePanelSW.Size = New System.Drawing.Size(442, 422)
        Me.CollapsiblePanelSW.StartColour = System.Drawing.Color.White
        Me.CollapsiblePanelSW.TabIndex = 0
        Me.CollapsiblePanelSW.TitleFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CollapsiblePanelSW.TitleFontColour = System.Drawing.Color.Navy
        Me.CollapsiblePanelSW.TitleText = "Seed Word"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxAIR)
        Me.GroupBox1.Controls.Add(Me.ButtonImport)
        Me.GroupBox1.Controls.Add(Me.TextBoxImport)
        Me.GroupBox1.Controls.Add(Me.ButtonSelectFile)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 82)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Import"
        '
        'CheckBoxAIR
        '
        Me.CheckBoxAIR.AutoSize = True
        Me.CheckBoxAIR.Enabled = False
        Me.CheckBoxAIR.Location = New System.Drawing.Point(98, 59)
        Me.CheckBoxAIR.Name = "CheckBoxAIR"
        Me.CheckBoxAIR.Size = New System.Drawing.Size(101, 17)
        Me.CheckBoxAIR.TabIndex = 30
        Me.CheckBoxAIR.Text = "Append Results"
        Me.CheckBoxAIR.UseVisualStyleBackColor = True
        '
        'ButtonImport
        '
        Me.ButtonImport.Enabled = False
        Me.ButtonImport.Location = New System.Drawing.Point(330, 53)
        Me.ButtonImport.Name = "ButtonImport"
        Me.ButtonImport.Size = New System.Drawing.Size(75, 23)
        Me.ButtonImport.TabIndex = 2
        Me.ButtonImport.Text = "Import"
        Me.ButtonImport.UseVisualStyleBackColor = True
        '
        'TextBoxImport
        '
        Me.TextBoxImport.Location = New System.Drawing.Point(97, 25)
        Me.TextBoxImport.Name = "TextBoxImport"
        Me.TextBoxImport.Size = New System.Drawing.Size(222, 20)
        Me.TextBoxImport.TabIndex = 1
        '
        'ButtonSelectFile
        '
        Me.ButtonSelectFile.Location = New System.Drawing.Point(16, 23)
        Me.ButtonSelectFile.Name = "ButtonSelectFile"
        Me.ButtonSelectFile.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSelectFile.TabIndex = 0
        Me.ButtonSelectFile.Text = "Select File"
        Me.ButtonSelectFile.UseVisualStyleBackColor = True
        '
        'LabelStatus
        '
        Me.LabelStatus.Location = New System.Drawing.Point(9, 378)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(421, 33)
        Me.LabelStatus.TabIndex = 24
        Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OpenFileDlg
        '
        Me.OpenFileDlg.AddExtension = False
        Me.OpenFileDlg.DefaultExt = "csv"
        Me.OpenFileDlg.Filter = "CSV files|*.csv"
        Me.OpenFileDlg.Title = "Select CSV File"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 525)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CollapsiblePanelBar2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(439, 509)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Niche Taser"
        Me.GroupBoxGenerateCount.ResumeLayout(False)
        Me.GroupBoxGenerateCount.PerformLayout()
        CType(Me.SpinBoxThrottle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMForLV.ResumeLayout(False)
        Me.GroupBoxFilter.ResumeLayout(False)
        Me.GroupBoxFilter.PerformLayout()
        CType(Me.SBCntMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBCntMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBAvgMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBAvgMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBApproxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBApproxMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGenerateKW.ResumeLayout(False)
        Me.GroupBoxGenerateKW.PerformLayout()
        Me.GroupBoxExport.ResumeLayout(False)
        Me.GroupBoxExport.PerformLayout()
        CType(Me.CollapsiblePanelBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CollapsiblePanelBar2.ResumeLayout(False)
        Me.CollapsiblePanelResult.ResumeLayout(False)
        Me.CollapsiblePanelFilter.ResumeLayout(False)
        Me.CollapsiblePanelSW.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxGenerateCount As System.Windows.Forms.GroupBox
    Friend WithEvents SpinBoxThrottle As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelThrottle As System.Windows.Forms.Label
    Friend WithEvents SaveFileDlg As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBoxFilter As System.Windows.Forms.GroupBox
    Friend WithEvents LabelFilterLower As System.Windows.Forms.Label
    Friend WithEvents LabelFilterUpper As System.Windows.Forms.Label
    Friend WithEvents SBAvgMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents SBAvgMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents SBApproxMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents SBApproxMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents ButtonFilter As System.Windows.Forms.Button
    Friend WithEvents ButtonShowOriginal As System.Windows.Forms.Button
    Friend WithEvents SBCntMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents SBCntMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ButtonProcess As System.Windows.Forms.Button
    Friend WithEvents CheckBoxFilterCount As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFilterAvg As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxFilterApprox As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonPR As System.Windows.Forms.Button
    Friend WithEvents CMForLV As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSelected As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopySelected As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvertSelection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonExport As System.Windows.Forms.Button
    Friend WithEvents TextBoxExport As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxExport As System.Windows.Forms.GroupBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents LabelSeedKW As System.Windows.Forms.Label
    Friend WithEvents TextBoxSeedKeyword As System.Windows.Forms.TextBox
    Friend WithEvents LabelKeywordType As System.Windows.Forms.Label
    Friend WithEvents ComboBoxKeywordType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelCountry As System.Windows.Forms.Label
    Friend WithEvents ComboBoxGL As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonGenerateKW As System.Windows.Forms.Button
    Friend WithEvents GroupBoxGenerateKW As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ListViewCSV As System.Windows.Forms.ListView
    Friend WithEvents CollapsiblePanelBar2 As Salamander.Windows.Forms.CollapsiblePanelBar
    Friend WithEvents CollapsiblePanelSW As Salamander.Windows.Forms.CollapsiblePanel
    Friend WithEvents CollapsiblePanelResult As Salamander.Windows.Forms.CollapsiblePanel
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents CollapsiblePanelFilter As Salamander.Windows.Forms.CollapsiblePanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonImport As System.Windows.Forms.Button
    Friend WithEvents TextBoxImport As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSelectFile As System.Windows.Forms.Button
    Friend WithEvents CheckBoxAGKWR As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAIR As System.Windows.Forms.CheckBox

End Class
