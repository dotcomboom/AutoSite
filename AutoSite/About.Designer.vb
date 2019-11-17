<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.LicenseBox = New System.Windows.Forms.RichTextBox
        Me.OK = New System.Windows.Forms.Button
        Me.Logo = New System.Windows.Forms.PictureBox
        Me.Version = New System.Windows.Forms.Label
        Me.GithubLink = New System.Windows.Forms.LinkLabel
        Me.WebsiteLink = New System.Windows.Forms.LinkLabel
        Me.Tabs = New System.Windows.Forms.TabControl
        Me.License = New System.Windows.Forms.TabPage
        Me.Changelog = New System.Windows.Forms.TabPage
        Me.ChangelogBox = New System.Windows.Forms.RichTextBox
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tabs.SuspendLayout()
        Me.License.SuspendLayout()
        Me.Changelog.SuspendLayout()
        Me.SuspendLayout()
        '
        'LicenseBox
        '
        Me.LicenseBox.BackColor = System.Drawing.SystemColors.Window
        Me.LicenseBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LicenseBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.LicenseBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LicenseBox.Location = New System.Drawing.Point(5, 5)
        Me.LicenseBox.Margin = New System.Windows.Forms.Padding(5)
        Me.LicenseBox.Name = "LicenseBox"
        Me.LicenseBox.ReadOnly = True
        Me.LicenseBox.Size = New System.Drawing.Size(339, 272)
        Me.LicenseBox.TabIndex = 0
        Me.LicenseBox.Text = resources.GetString("LicenseBox.Text")
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK.Location = New System.Drawing.Point(402, 333)
        Me.OK.Margin = New System.Windows.Forms.Padding(5)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 23)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(10, 10)
        Me.Logo.Margin = New System.Windows.Forms.Padding(5)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(103, 128)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 2
        Me.Logo.TabStop = False
        '
        'Version
        '
        Me.Version.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(10, 143)
        Me.Version.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(103, 21)
        Me.Version.TabIndex = 3
        Me.Version.Text = "0.0.0.0"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GithubLink
        '
        Me.GithubLink.AutoSize = True
        Me.GithubLink.Location = New System.Drawing.Point(6, 164)
        Me.GithubLink.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.GithubLink.Name = "GithubLink"
        Me.GithubLink.Size = New System.Drawing.Size(45, 15)
        Me.GithubLink.TabIndex = 4
        Me.GithubLink.TabStop = True
        Me.GithubLink.Text = "GitHub"
        '
        'WebsiteLink
        '
        Me.WebsiteLink.AutoSize = True
        Me.WebsiteLink.Location = New System.Drawing.Point(64, 164)
        Me.WebsiteLink.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.WebsiteLink.Name = "WebsiteLink"
        Me.WebsiteLink.Size = New System.Drawing.Size(49, 15)
        Me.WebsiteLink.TabIndex = 5
        Me.WebsiteLink.TabStop = True
        Me.WebsiteLink.Text = "Website"
        '
        'Tabs
        '
        Me.Tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabs.Controls.Add(Me.License)
        Me.Tabs.Controls.Add(Me.Changelog)
        Me.Tabs.Location = New System.Drawing.Point(120, 10)
        Me.Tabs.Margin = New System.Windows.Forms.Padding(5)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(357, 310)
        Me.Tabs.TabIndex = 10
        '
        'License
        '
        Me.License.Controls.Add(Me.LicenseBox)
        Me.License.Location = New System.Drawing.Point(4, 24)
        Me.License.Margin = New System.Windows.Forms.Padding(5)
        Me.License.Name = "License"
        Me.License.Padding = New System.Windows.Forms.Padding(5)
        Me.License.Size = New System.Drawing.Size(349, 282)
        Me.License.TabIndex = 0
        Me.License.Text = "License"
        Me.License.UseVisualStyleBackColor = True
        '
        'Changelog
        '
        Me.Changelog.Controls.Add(Me.ChangelogBox)
        Me.Changelog.Location = New System.Drawing.Point(4, 24)
        Me.Changelog.Margin = New System.Windows.Forms.Padding(5)
        Me.Changelog.Name = "Changelog"
        Me.Changelog.Padding = New System.Windows.Forms.Padding(5)
        Me.Changelog.Size = New System.Drawing.Size(349, 282)
        Me.Changelog.TabIndex = 1
        Me.Changelog.Text = "Changelog"
        Me.Changelog.UseVisualStyleBackColor = True
        '
        'ChangelogBox
        '
        Me.ChangelogBox.BackColor = System.Drawing.SystemColors.Window
        Me.ChangelogBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChangelogBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChangelogBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangelogBox.Location = New System.Drawing.Point(5, 5)
        Me.ChangelogBox.Margin = New System.Windows.Forms.Padding(5)
        Me.ChangelogBox.Name = "ChangelogBox"
        Me.ChangelogBox.ReadOnly = True
        Me.ChangelogBox.Size = New System.Drawing.Size(339, 272)
        Me.ChangelogBox.TabIndex = 1
        Me.ChangelogBox.Text = resources.GetString("ChangelogBox.Text")
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.OK
        Me.ClientSize = New System.Drawing.Size(491, 370)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.WebsiteLink)
        Me.Controls.Add(Me.GithubLink)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.OK)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "About"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About AutoSite"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabs.ResumeLayout(False)
        Me.License.ResumeLayout(False)
        Me.Changelog.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LicenseBox As System.Windows.Forms.RichTextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents GithubLink As System.Windows.Forms.LinkLabel
    Friend WithEvents WebsiteLink As System.Windows.Forms.LinkLabel
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents License As System.Windows.Forms.TabPage
    Friend WithEvents Changelog As System.Windows.Forms.TabPage
    Friend WithEvents ChangelogBox As System.Windows.Forms.RichTextBox
End Class
