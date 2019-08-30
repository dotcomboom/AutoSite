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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'aboutText
        '
        Me.aboutText.BackColor = System.Drawing.SystemColors.Control
        Me.aboutText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aboutText.Cursor = System.Windows.Forms.Cursors.Default
        Me.aboutText.Location = New System.Drawing.Point(93, 12)
        Me.aboutText.Name = "aboutText"
        Me.aboutText.ReadOnly = True
        Me.aboutText.Size = New System.Drawing.Size(215, 143)
        Me.aboutText.TabIndex = 0
        Me.aboutText.Text = "AutoSite XL is powered by these most excellent open source libraries:" & Global.Microsoft.VisualBasic.ChrW(10) & "  - FastCol" & _
            "oredTextBox" & Global.Microsoft.VisualBasic.ChrW(10) & "  - CommonMark.NET"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(233, 162)
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
        Me.version.AutoSize = True
        Me.version.Location = New System.Drawing.Point(12, 97)
        Me.version.Name = "version"
        Me.version.Size = New System.Drawing.Size(46, 13)
        Me.version.TabIndex = 3
        Me.version.Text = "v0.0.0.0"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 197)
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
End Class
