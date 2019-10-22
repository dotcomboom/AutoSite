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
        Me.Py3AutoSite = New System.Windows.Forms.Label
        Me.PyWebsiteLink = New System.Windows.Forms.LinkLabel
        Me.PyGithubLink = New System.Windows.Forms.LinkLabel
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
        Me.LicenseBox.Location = New System.Drawing.Point(4, 4)
        Me.LicenseBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LicenseBox.Name = "LicenseBox"
        Me.LicenseBox.ReadOnly = True
        Me.LicenseBox.Size = New System.Drawing.Size(521, 373)
        Me.LicenseBox.TabIndex = 0
        Me.LicenseBox.Text = resources.GetString("LicenseBox.Text")
        '
        'OK
        '
        Me.OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK.Location = New System.Drawing.Point(561, 433)
        Me.OK.Margin = New System.Windows.Forms.Padding(4)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(100, 28)
        Me.OK.TabIndex = 1
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(16, 15)
        Me.Logo.Margin = New System.Windows.Forms.Padding(4)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(100, 96)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo.TabIndex = 2
        Me.Logo.TabStop = False
        '
        'Version
        '
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(16, 119)
        Me.Version.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(100, 16)
        Me.Version.TabIndex = 3
        Me.Version.Text = "v0.0.0.0"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GithubLink
        '
        Me.GithubLink.AutoSize = True
        Me.GithubLink.Location = New System.Drawing.Point(16, 149)
        Me.GithubLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GithubLink.Name = "GithubLink"
        Me.GithubLink.Size = New System.Drawing.Size(50, 17)
        Me.GithubLink.TabIndex = 4
        Me.GithubLink.TabStop = True
        Me.GithubLink.Text = "Github"
        '
        'WebsiteLink
        '
        Me.WebsiteLink.AutoSize = True
        Me.WebsiteLink.Location = New System.Drawing.Point(16, 175)
        Me.WebsiteLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WebsiteLink.Name = "WebsiteLink"
        Me.WebsiteLink.Size = New System.Drawing.Size(59, 17)
        Me.WebsiteLink.TabIndex = 5
        Me.WebsiteLink.TabStop = True
        Me.WebsiteLink.Text = "Website"
        '
        'Py3AutoSite
        '
        Me.Py3AutoSite.Location = New System.Drawing.Point(16, 207)
        Me.Py3AutoSite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Py3AutoSite.Name = "Py3AutoSite"
        Me.Py3AutoSite.Size = New System.Drawing.Size(81, 37)
        Me.Py3AutoSite.TabIndex = 7
        Me.Py3AutoSite.Text = "Python3 AutoSite"
        '
        'PyWebsiteLink
        '
        Me.PyWebsiteLink.AutoSize = True
        Me.PyWebsiteLink.Location = New System.Drawing.Point(16, 271)
        Me.PyWebsiteLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PyWebsiteLink.Name = "PyWebsiteLink"
        Me.PyWebsiteLink.Size = New System.Drawing.Size(59, 17)
        Me.PyWebsiteLink.TabIndex = 9
        Me.PyWebsiteLink.TabStop = True
        Me.PyWebsiteLink.Text = "Website"
        '
        'PyGithubLink
        '
        Me.PyGithubLink.AutoSize = True
        Me.PyGithubLink.Location = New System.Drawing.Point(16, 245)
        Me.PyGithubLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PyGithubLink.Name = "PyGithubLink"
        Me.PyGithubLink.Size = New System.Drawing.Size(50, 17)
        Me.PyGithubLink.TabIndex = 8
        Me.PyGithubLink.TabStop = True
        Me.PyGithubLink.Text = "Github"
        '
        'Tabs
        '
        Me.Tabs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tabs.Controls.Add(Me.License)
        Me.Tabs.Controls.Add(Me.Changelog)
        Me.Tabs.Location = New System.Drawing.Point(124, 15)
        Me.Tabs.Margin = New System.Windows.Forms.Padding(4)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(537, 410)
        Me.Tabs.TabIndex = 10
        '
        'License
        '
        Me.License.Controls.Add(Me.LicenseBox)
        Me.License.Location = New System.Drawing.Point(4, 25)
        Me.License.Margin = New System.Windows.Forms.Padding(4)
        Me.License.Name = "License"
        Me.License.Padding = New System.Windows.Forms.Padding(4)
        Me.License.Size = New System.Drawing.Size(529, 381)
        Me.License.TabIndex = 0
        Me.License.Text = "License"
        Me.License.UseVisualStyleBackColor = True
        '
        'Changelog
        '
        Me.Changelog.Controls.Add(Me.ChangelogBox)
        Me.Changelog.Location = New System.Drawing.Point(4, 25)
        Me.Changelog.Margin = New System.Windows.Forms.Padding(4)
        Me.Changelog.Name = "Changelog"
        Me.Changelog.Padding = New System.Windows.Forms.Padding(4)
        Me.Changelog.Size = New System.Drawing.Size(529, 381)
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
        Me.ChangelogBox.Location = New System.Drawing.Point(4, 4)
        Me.ChangelogBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ChangelogBox.Name = "ChangelogBox"
        Me.ChangelogBox.ReadOnly = True
        Me.ChangelogBox.Size = New System.Drawing.Size(521, 373)
        Me.ChangelogBox.TabIndex = 1
        Me.ChangelogBox.Text = resources.GetString("ChangelogBox.Text")
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.OK
        Me.ClientSize = New System.Drawing.Size(677, 479)
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.PyWebsiteLink)
        Me.Controls.Add(Me.PyGithubLink)
        Me.Controls.Add(Me.Py3AutoSite)
        Me.Controls.Add(Me.WebsiteLink)
        Me.Controls.Add(Me.GithubLink)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.OK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "About"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
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
    Friend WithEvents Py3AutoSite As System.Windows.Forms.Label
    Friend WithEvents PyWebsiteLink As System.Windows.Forms.LinkLabel
    Friend WithEvents PyGithubLink As System.Windows.Forms.LinkLabel
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents License As System.Windows.Forms.TabPage
    Friend WithEvents Changelog As System.Windows.Forms.TabPage
    Friend WithEvents ChangelogBox As System.Windows.Forms.RichTextBox
End Class
