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
        resources.ApplyResources(Me.LicenseBox, "LicenseBox")
        Me.LicenseBox.Name = "LicenseBox"
        Me.LicenseBox.ReadOnly = True
        '
        'OK
        '
        resources.ApplyResources(Me.OK, "OK")
        Me.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OK.Name = "OK"
        Me.OK.UseVisualStyleBackColor = True
        '
        'Logo
        '
        resources.ApplyResources(Me.Logo, "Logo")
        Me.Logo.Name = "Logo"
        Me.Logo.TabStop = False
        '
        'Version
        '
        resources.ApplyResources(Me.Version, "Version")
        Me.Version.Name = "Version"
        '
        'GithubLink
        '
        resources.ApplyResources(Me.GithubLink, "GithubLink")
        Me.GithubLink.Name = "GithubLink"
        Me.GithubLink.TabStop = True
        '
        'WebsiteLink
        '
        resources.ApplyResources(Me.WebsiteLink, "WebsiteLink")
        Me.WebsiteLink.Name = "WebsiteLink"
        Me.WebsiteLink.TabStop = True
        '
        'Tabs
        '
        resources.ApplyResources(Me.Tabs, "Tabs")
        Me.Tabs.Controls.Add(Me.License)
        Me.Tabs.Controls.Add(Me.Changelog)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        '
        'License
        '
        Me.License.Controls.Add(Me.LicenseBox)
        resources.ApplyResources(Me.License, "License")
        Me.License.Name = "License"
        Me.License.UseVisualStyleBackColor = True
        '
        'Changelog
        '
        Me.Changelog.Controls.Add(Me.ChangelogBox)
        resources.ApplyResources(Me.Changelog, "Changelog")
        Me.Changelog.Name = "Changelog"
        Me.Changelog.UseVisualStyleBackColor = True
        '
        'ChangelogBox
        '
        Me.ChangelogBox.BackColor = System.Drawing.SystemColors.Window
        Me.ChangelogBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ChangelogBox.Cursor = System.Windows.Forms.Cursors.Default
        resources.ApplyResources(Me.ChangelogBox, "ChangelogBox")
        Me.ChangelogBox.Name = "ChangelogBox"
        Me.ChangelogBox.ReadOnly = True
        '
        'About
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.OK
        Me.Controls.Add(Me.Tabs)
        Me.Controls.Add(Me.WebsiteLink)
        Me.Controls.Add(Me.GithubLink)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.OK)
        Me.Name = "About"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tabs.ResumeLayout(False)
        Me.License.ResumeLayout(False)
        Me.Changelog.ResumeLayout(False)
        Me.ResumeLayout(False)

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
