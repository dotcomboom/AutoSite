<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Build
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
        Me.Progress = New System.Windows.Forms.ProgressBar
        Me.Status = New System.Windows.Forms.Label
        Me.Log = New System.Windows.Forms.TextBox
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.SuspendLayout()
        '
        'Progress
        '
        Me.Progress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Progress.Location = New System.Drawing.Point(12, 12)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(400, 23)
        Me.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Progress.TabIndex = 0
        '
        'Status
        '
        Me.Status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Status.Location = New System.Drawing.Point(12, 42)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(400, 30)
        Me.Status.TabIndex = 1
        Me.Status.Text = "Building... This may take a while depending on the size of your site."
        Me.Status.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Log
        '
        Me.Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Log.Location = New System.Drawing.Point(12, 75)
        Me.Log.Multiline = True
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Log.Size = New System.Drawing.Size(400, 226)
        Me.Log.TabIndex = 2
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Build
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 313)
        Me.ControlBox = False
        Me.Controls.Add(Me.Log)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Progress)
        Me.MinimizeBox = False
        Me.Name = "Build"
        Me.ShowIcon = False
        Me.Text = "Apricot"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Progress As System.Windows.Forms.ProgressBar
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents Log As System.Windows.Forms.TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
