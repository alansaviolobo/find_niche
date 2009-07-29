<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Captcha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Captcha))
        Me.WebBrowserCaptcha = New System.Windows.Forms.WebBrowser
        Me.TextBoxCaptcha = New System.Windows.Forms.TextBox
        Me.ButtonRefresh = New System.Windows.Forms.Button
        Me.ButtonOK = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'WebBrowserCaptcha
        '
        Me.WebBrowserCaptcha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowserCaptcha.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowserCaptcha.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowserCaptcha.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserCaptcha.Name = "WebBrowserCaptcha"
        Me.WebBrowserCaptcha.ScriptErrorsSuppressed = True
        Me.WebBrowserCaptcha.ScrollBarsEnabled = False
        Me.WebBrowserCaptcha.Size = New System.Drawing.Size(320, 107)
        Me.WebBrowserCaptcha.TabIndex = 1
        '
        'TextBoxCaptcha
        '
        Me.TextBoxCaptcha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCaptcha.Location = New System.Drawing.Point(35, 127)
        Me.TextBoxCaptcha.Name = "TextBoxCaptcha"
        Me.TextBoxCaptcha.Size = New System.Drawing.Size(245, 20)
        Me.TextBoxCaptcha.TabIndex = 2
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(35, 173)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 4
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonOK.Location = New System.Drawing.Point(205, 173)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 3
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'Captcha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 208)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.TextBoxCaptcha)
        Me.Controls.Add(Me.WebBrowserCaptcha)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Captcha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Enter Captcha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowserCaptcha As System.Windows.Forms.WebBrowser
    Friend WithEvents TextBoxCaptcha As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonOK As System.Windows.Forms.Button

End Class
