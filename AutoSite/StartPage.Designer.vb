<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartPage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartPage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewSite = New System.Windows.Forms.LinkLabel()
        Me.Recent1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Recent2 = New System.Windows.Forms.LinkLabel()
        Me.Recent3 = New System.Windows.Forms.LinkLabel()
        Me.Recent4 = New System.Windows.Forms.LinkLabel()
        Me.Recent5 = New System.Windows.Forms.LinkLabel()
        Me.OpenSite = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.R1 = New System.Windows.Forms.PictureBox()
        Me.R2 = New System.Windows.Forms.PictureBox()
        Me.R3 = New System.Windows.Forms.PictureBox()
        Me.R4 = New System.Windows.Forms.PictureBox()
        Me.R5 = New System.Windows.Forms.PictureBox()
        Me.RWarn = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Start"
        '
        'NewSite
        '
        Me.NewSite.ActiveLinkColor = System.Drawing.Color.Gainsboro
        Me.NewSite.AutoEllipsis = True
        Me.NewSite.AutoSize = True
        Me.NewSite.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.NewSite.ForeColor = System.Drawing.Color.Black
        Me.NewSite.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.NewSite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.NewSite.LinkColor = System.Drawing.Color.White
        Me.NewSite.Location = New System.Drawing.Point(53, 67)
        Me.NewSite.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.NewSite.Name = "NewSite"
        Me.NewSite.Size = New System.Drawing.Size(62, 15)
        Me.NewSite.TabIndex = 7
        Me.NewSite.TabStop = True
        Me.NewSite.Text = "New Site..."
        Me.NewSite.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Recent1
        '
        Me.Recent1.ActiveLinkColor = System.Drawing.Color.Gainsboro
        Me.Recent1.AutoEllipsis = True
        Me.Recent1.AutoSize = True
        Me.Recent1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Recent1.ForeColor = System.Drawing.Color.Black
        Me.Recent1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Recent1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.Recent1.LinkColor = System.Drawing.Color.White
        Me.Recent1.Location = New System.Drawing.Point(180, 67)
        Me.Recent1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Recent1.Name = "Recent1"
        Me.Recent1.Size = New System.Drawing.Size(52, 15)
        Me.Recent1.TabIndex = 8
        Me.Recent1.TabStop = True
        Me.Recent1.Text = "Recent 1"
        Me.Recent1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(157, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Open recent"
        '
        'Recent2
        '
        Me.Recent2.ActiveLinkColor = System.Drawing.Color.Gainsboro
        Me.Recent2.AutoEllipsis = True
        Me.Recent2.AutoSize = True
        Me.Recent2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Recent2.ForeColor = System.Drawing.Color.Black
        Me.Recent2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Recent2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.Recent2.LinkColor = System.Drawing.Color.White
        Me.Recent2.Location = New System.Drawing.Point(180, 93)
        Me.Recent2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Recent2.Name = "Recent2"
        Me.Recent2.Size = New System.Drawing.Size(52, 15)
        Me.Recent2.TabIndex = 10
        Me.Recent2.TabStop = True
        Me.Recent2.Text = "Recent 2"
        Me.Recent2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Recent3
        '
        Me.Recent3.ActiveLinkColor = System.Drawing.Color.Gainsboro
        Me.Recent3.AutoEllipsis = True
        Me.Recent3.AutoSize = True
        Me.Recent3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Recent3.ForeColor = System.Drawing.Color.Black
        Me.Recent3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Recent3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.Recent3.LinkColor = System.Drawing.Color.White
        Me.Recent3.Location = New System.Drawing.Point(180, 119)
        Me.Recent3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Recent3.Name = "Recent3"
        Me.Recent3.Size = New System.Drawing.Size(52, 15)
        Me.Recent3.TabIndex = 11
        Me.Recent3.TabStop = True
        Me.Recent3.Text = "Recent 3"
        Me.Recent3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Recent4
        '
        Me.Recent4.ActiveLinkColor = System.Drawing.Color.Gainsboro
        Me.Recent4.AutoEllipsis = True
        Me.Recent4.AutoSize = True
        Me.Recent4.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Recent4.ForeColor = System.Drawing.Color.Black
        Me.Recent4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Recent4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.Recent4.LinkColor = System.Drawing.Color.White
        Me.Recent4.Location = New System.Drawing.Point(180, 145)
        Me.Recent4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Recent4.Name = "Recent4"
        Me.Recent4.Size = New System.Drawing.Size(52, 15)
        Me.Recent4.TabIndex = 12
        Me.Recent4.TabStop = True
        Me.Recent4.Text = "Recent 4"
        Me.Recent4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Recent5
        '
        Me.Recent5.ActiveLinkColor = System.Drawing.Color.Gainsboro
        Me.Recent5.AutoEllipsis = True
        Me.Recent5.AutoSize = True
        Me.Recent5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Recent5.ForeColor = System.Drawing.Color.Black
        Me.Recent5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Recent5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.Recent5.LinkColor = System.Drawing.Color.White
        Me.Recent5.Location = New System.Drawing.Point(180, 171)
        Me.Recent5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Recent5.Name = "Recent5"
        Me.Recent5.Size = New System.Drawing.Size(52, 15)
        Me.Recent5.TabIndex = 13
        Me.Recent5.TabStop = True
        Me.Recent5.Text = "Recent 5"
        Me.Recent5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OpenSite
        '
        Me.OpenSite.ActiveLinkColor = System.Drawing.Color.Gainsboro
        Me.OpenSite.AutoEllipsis = True
        Me.OpenSite.AutoSize = True
        Me.OpenSite.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.OpenSite.ForeColor = System.Drawing.Color.Black
        Me.OpenSite.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.OpenSite.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.OpenSite.LinkColor = System.Drawing.Color.White
        Me.OpenSite.Location = New System.Drawing.Point(53, 95)
        Me.OpenSite.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.OpenSite.Name = "OpenSite"
        Me.OpenSite.Size = New System.Drawing.Size(67, 15)
        Me.OpenSite.TabIndex = 19
        Me.OpenSite.TabStop = True
        Me.OpenSite.Text = "Open Site..."
        Me.OpenSite.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PictureBox1.Image = Global.AutoSite.My.Resources.Resources.NewSite
        Me.PictureBox1.Location = New System.Drawing.Point(34, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(34, 94)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'R1
        '
        Me.R1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.R1.Image = Global.AutoSite.My.Resources.Resources.Web
        Me.R1.Location = New System.Drawing.Point(161, 66)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(16, 16)
        Me.R1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.R1.TabIndex = 22
        Me.R1.TabStop = False
        '
        'R2
        '
        Me.R2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.R2.Image = Global.AutoSite.My.Resources.Resources.Web
        Me.R2.Location = New System.Drawing.Point(161, 92)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(16, 16)
        Me.R2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.R2.TabIndex = 23
        Me.R2.TabStop = False
        '
        'R3
        '
        Me.R3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.R3.Image = Global.AutoSite.My.Resources.Resources.Web
        Me.R3.Location = New System.Drawing.Point(161, 118)
        Me.R3.Name = "R3"
        Me.R3.Size = New System.Drawing.Size(16, 16)
        Me.R3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.R3.TabIndex = 24
        Me.R3.TabStop = False
        '
        'R4
        '
        Me.R4.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.R4.Image = Global.AutoSite.My.Resources.Resources.Web
        Me.R4.Location = New System.Drawing.Point(161, 144)
        Me.R4.Name = "R4"
        Me.R4.Size = New System.Drawing.Size(16, 16)
        Me.R4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.R4.TabIndex = 25
        Me.R4.TabStop = False
        '
        'R5
        '
        Me.R5.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.R5.Image = Global.AutoSite.My.Resources.Resources.Web
        Me.R5.Location = New System.Drawing.Point(161, 170)
        Me.R5.Name = "R5"
        Me.R5.Size = New System.Drawing.Size(16, 16)
        Me.R5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.R5.TabIndex = 26
        Me.R5.TabStop = False
        '
        'RWarn
        '
        Me.RWarn.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.RWarn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RWarn.ForeColor = System.Drawing.Color.White
        Me.RWarn.Location = New System.Drawing.Point(158, 66)
        Me.RWarn.Name = "RWarn"
        Me.RWarn.Size = New System.Drawing.Size(331, 57)
        Me.RWarn.TabIndex = 14
        Me.RWarn.Text = "Sites you work on will show up here for quick access."
        Me.RWarn.Visible = False
        '
        'StartPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Controls.Add(Me.R5)
        Me.Controls.Add(Me.R4)
        Me.Controls.Add(Me.R3)
        Me.Controls.Add(Me.R2)
        Me.Controls.Add(Me.R1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.OpenSite)
        Me.Controls.Add(Me.Recent5)
        Me.Controls.Add(Me.Recent4)
        Me.Controls.Add(Me.Recent3)
        Me.Controls.Add(Me.Recent2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Recent1)
        Me.Controls.Add(Me.NewSite)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RWarn)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "StartPage"
        Me.Size = New System.Drawing.Size(562, 374)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewSite As System.Windows.Forms.LinkLabel
    Friend WithEvents Recent1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Recent2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Recent3 As System.Windows.Forms.LinkLabel
    Friend WithEvents Recent4 As System.Windows.Forms.LinkLabel
    Friend WithEvents Recent5 As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenSite As LinkLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents R1 As PictureBox
    Friend WithEvents R2 As PictureBox
    Friend WithEvents R3 As PictureBox
    Friend WithEvents R4 As PictureBox
    Friend WithEvents R5 As PictureBox
    Friend WithEvents RWarn As Label
End Class
