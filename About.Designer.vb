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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'aboutText
        '
        Me.aboutText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aboutText.BackColor = System.Drawing.SystemColors.Control
        Me.aboutText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aboutText.Cursor = System.Windows.Forms.Cursors.Default
        Me.aboutText.Location = New System.Drawing.Point(93, 12)
        Me.aboutText.Name = "aboutText"
        Me.aboutText.ReadOnly = True
        Me.aboutText.Size = New System.Drawing.Size(215, 202)
        Me.aboutText.TabIndex = 0
        Me.aboutText.Text = resources.GetString("aboutText.Text")
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(233, 220)
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
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 258)
        Me.Controls.Add(Me.PyWebsiteLink)
        Me.Controls.Add(Me.PyGithubLink)
        Me.Controls.Add(Me.Py3AutoSite)
        Me.Controls.Add(Me.WebsiteLink)
        Me.Controls.Add(Me.GithubLink)
        Me.Controls.Add(Me.version)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.aboutText)
        Me.MaximizeBox = False
        Me.Name = "About"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
