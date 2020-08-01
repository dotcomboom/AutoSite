<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallPack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstallPack))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Description = New System.Windows.Forms.RichTextBox
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.VS2017 = New System.Windows.Forms.ImageList(Me.components)
        Me.PackTitle = New System.Windows.Forms.Label
        Me.PackAuthor = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        '
        'OK_Button
        '
        resources.ApplyResources(Me.OK_Button, "OK_Button")
        Me.OK_Button.Name = "OK_Button"
        '
        'Cancel_Button
        '
        resources.ApplyResources(Me.Cancel_Button, "Cancel_Button")
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Name = "Cancel_Button"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Description
        '
        resources.ApplyResources(Me.Description, "Description")
        Me.Description.Name = "Description"
        Me.Description.Text = ""
        '
        'TreeView1
        '
        resources.ApplyResources(Me.TreeView1, "TreeView1")
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.ImageList = Me.VS2017
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {CType(resources.GetObject("TreeView1.Nodes"), System.Windows.Forms.TreeNode)})
        Me.TreeView1.ShowNodeToolTips = True
        '
        'VS2017
        '
        Me.VS2017.ImageStream = CType(resources.GetObject("VS2017.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.VS2017.TransparentColor = System.Drawing.Color.Transparent
        Me.VS2017.Images.SetKeyName(0, "Folder")
        Me.VS2017.Images.SetKeyName(1, "Template")
        Me.VS2017.Images.SetKeyName(2, "Page")
        Me.VS2017.Images.SetKeyName(3, "Include")
        Me.VS2017.Images.SetKeyName(4, "Build")
        Me.VS2017.Images.SetKeyName(5, "Attribute")
        Me.VS2017.Images.SetKeyName(6, "Value")
        Me.VS2017.Images.SetKeyName(7, "Zip")
        Me.VS2017.Images.SetKeyName(8, "Package")
        Me.VS2017.Images.SetKeyName(9, "Other")
        '
        'PackTitle
        '
        resources.ApplyResources(Me.PackTitle, "PackTitle")
        Me.PackTitle.Name = "PackTitle"
        '
        'PackAuthor
        '
        resources.ApplyResources(Me.PackAuthor, "PackAuthor")
        Me.PackAuthor.Name = "PackAuthor"
        '
        'BackgroundWorker1
        '
        '
        'InstallPack
        '
        Me.AcceptButton = Me.OK_Button
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.Controls.Add(Me.PackAuthor)
        Me.Controls.Add(Me.PackTitle)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimizeBox = False
        Me.Name = "InstallPack"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Description As System.Windows.Forms.RichTextBox
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents VS2017 As System.Windows.Forms.ImageList
    Friend WithEvents PackTitle As System.Windows.Forms.Label
    Friend WithEvents PackAuthor As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
