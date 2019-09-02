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
        Me.aboutText = New System.Windows.Forms.RichTextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.version = New System.Windows.Forms.Label
        Me.GithubLink = New System.Windows.Forms.LinkLabel
        Me.WebsiteLink = New System.Windows.Forms.LinkLabel
        Me.Py3AutoSite = New System.Windows.Forms.Label
        Me.PyWebsiteLink = New System.Windows.Forms.LinkLabel
        Me.PyGithubLink = New System.Windows.Forms.LinkLabel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.License = New System.Windows.Forms.TabPage
        Me.Changelog = New System.Windows.Forms.TabPage
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.License.SuspendLayout()
        Me.Changelog.SuspendLayout()
        Me.SuspendLayout()
        '
        'aboutText
        '
        Me.aboutText.BackColor = System.Drawing.SystemColors.Window
        Me.aboutText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aboutText.Cursor = System.Windows.Forms.Cursors.Default
        Me.aboutText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aboutText.Location = New System.Drawing.Point(3, 3)
        Me.aboutText.Name = "aboutText"
        Me.aboutText.ReadOnly = True
        Me.aboutText.Size = New System.Drawing.Size(286, 236)
        Me.aboutText.TabIndex = 0
        Me.aboutText.Text = resources.GetString("aboutText.Text")
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(318, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'version
        '
        Me.version.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version.Location = New System.Drawing.Point(12, 97)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(75, 13)
        Me.version.TabIndex = 3
        Me.version.Text = "v0.0.0.0"
        Me.version.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GithubLink
        '
        Me.GithubLink.AutoSize = True
        Me.GithubLink.Location = New System.Drawing.Point(12, 121)
        Me.GithubLink.Name = "GithubLink"
        Me.GithubLink.Size = New System.Drawing.Size(38, 13)
        Me.GithubLink.TabIndex = 4
        Me.GithubLink.TabStop = True
        Me.GithubLink.Text = "Github"
        '
        'WebsiteLink
        '
        Me.WebsiteLink.AutoSize = True
        Me.WebsiteLink.Location = New System.Drawing.Point(12, 142)
        Me.WebsiteLink.Name = "WebsiteLink"
        Me.WebsiteLink.Size = New System.Drawing.Size(46, 13)
        Me.WebsiteLink.TabIndex = 5
        Me.WebsiteLink.TabStop = True
        Me.WebsiteLink.Text = "Website"
        '
        'Py3AutoSite
        '
        Me.Py3AutoSite.Location = New System.Drawing.Point(12, 168)
        Me.Py3AutoSite.Name = "Py3AutoSite"
        Me.Py3AutoSite.Size = New System.Drawing.Size(61, 30)
        Me.Py3AutoSite.TabIndex = 7
        Me.Py3AutoSite.Text = "Python3 AutoSite"
        '
        'PyWebsiteLink
        '
        Me.PyWebsiteLink.AutoSize = True
        Me.PyWebsiteLink.Location = New System.Drawing.Point(12, 220)
        Me.PyWebsiteLink.Name = "PyWebsiteLink"
        Me.PyWebsiteLink.Size = New System.Drawing.Size(46, 13)
        Me.PyWebsiteLink.TabIndex = 9
        Me.PyWebsiteLink.TabStop = True
        Me.PyWebsiteLink.Text = "Website"
        '
        'PyGithubLink
        '
        Me.PyGithubLink.AutoSize = True
        Me.PyGithubLink.Location = New System.Drawing.Point(12, 199)
        Me.PyGithubLink.Name = "PyGithubLink"
        Me.PyGithubLink.Size = New System.Drawing.Size(38, 13)
        Me.PyGithubLink.TabIndex = 8
        Me.PyGithubLink.TabStop = True
        Me.PyGithubLink.Text = "Github"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.License)
        Me.TabControl1.Controls.Add(Me.Changelog)
        Me.TabControl1.Location = New System.Drawing.Point(93, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(300, 268)
        Me.TabControl1.TabIndex = 10
        '
        'License
        '
        Me.License.Controls.Add(Me.aboutText)
        Me.License.Location = New System.Drawing.Point(4, 22)
        Me.License.Name = "License"
        Me.License.Padding = New System.Windows.Forms.Padding(3)
        Me.License.Size = New System.Drawing.Size(292, 242)
        Me.License.TabIndex = 0
        Me.License.Text = "License"
        Me.License.UseVisualStyleBackColor = True
        '
        'Changelog
        '
        Me.Changelog.Controls.Add(Me.RichTextBox1)
        Me.Changelog.Location = New System.Drawing.Point(4, 22)
        Me.Changelog.Name = "Changelog"
        Me.Changelog.Padding = New System.Windows.Forms.Padding(3)
        Me.Changelog.Size = New System.Drawing.Size(292, 242)
        Me.Changelog.TabIndex = 1
        Me.Changelog.Text = "Changelog"
        Me.Changelog.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(286, 236)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 324)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PyWebsiteLink)
        Me.Controls.Add(Me.PyGithubLink)
        Me.Controls.Add(Me.Py3AutoSite)
        Me.Controls.Add(Me.WebsiteLink)
        Me.Controls.Add(Me.GithubLink)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "About"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.License.ResumeLayout(False)
        Me.Changelog.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents aboutText As System.Windows.Forms.RichTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents version As System.Windows.Forms.Label
    Friend WithEvents GithubLink As System.Windows.Forms.LinkLabel
    Friend WithEvents WebsiteLink As System.Windows.Forms.LinkLabel
    Friend WithEvents Py3AutoSite As System.Windows.Forms.Label
    Friend WithEvents PyWebsiteLink As System.Windows.Forms.LinkLabel
    Friend WithEvents PyGithubLink As System.Windows.Forms.LinkLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents License As System.Windows.Forms.TabPage
    Friend WithEvents Changelog As System.Windows.Forms.TabPage
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
