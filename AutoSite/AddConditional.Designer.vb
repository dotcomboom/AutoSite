<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddConditional
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddConditional))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Explanation = New System.Windows.Forms.Label
        Me.AttLabel = New System.Windows.Forms.Label
        Me.Attribute = New System.Windows.Forms.ComboBox
        Me.AttIcon = New System.Windows.Forms.PictureBox
        Me.PassLabel = New System.Windows.Forms.Label
        Me.Display = New FastColoredTextBoxNS.FastColoredTextBox
        Me.NotChk = New System.Windows.Forms.CheckBox
        Me.Value = New System.Windows.Forms.ComboBox
        Me.Empty = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AttIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.OK_Button.BackColor = System.Drawing.Color.White
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        resources.ApplyResources(Me.Cancel_Button, "Cancel_Button")
        Me.Cancel_Button.BackColor = System.Drawing.Color.White
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Explanation
        '
        resources.ApplyResources(Me.Explanation, "Explanation")
        Me.Explanation.Name = "Explanation"
        '
        'AttLabel
        '
        resources.ApplyResources(Me.AttLabel, "AttLabel")
        Me.AttLabel.Name = "AttLabel"
        '
        'Attribute
        '
        resources.ApplyResources(Me.Attribute, "Attribute")
        Me.Attribute.FormattingEnabled = True
        Me.Attribute.Name = "Attribute"
        '
        'AttIcon
        '
        resources.ApplyResources(Me.AttIcon, "AttIcon")
        Me.AttIcon.Name = "AttIcon"
        Me.AttIcon.TabStop = False
        '
        'PassLabel
        '
        resources.ApplyResources(Me.PassLabel, "PassLabel")
        Me.PassLabel.Name = "PassLabel"
        '
        'Display
        '
        resources.ApplyResources(Me.Display, "Display")
        Me.Display.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.Display.AutoIndentCharsPatterns = Global.AutoSite.My.Resources.Resources.openProject
        Me.Display.BackBrush = Nothing
        Me.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Display.CharHeight = 14
        Me.Display.CharWidth = 8
        Me.Display.CommentPrefix = Nothing
        Me.Display.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Display.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Display.IsReplaceMode = False
        Me.Display.Language = FastColoredTextBoxNS.Language.HTML
        Me.Display.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.Display.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.Display.Name = "Display"
        Me.Display.Paddings = New System.Windows.Forms.Padding(0)
        Me.Display.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.Display.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.Display.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Display.ServiceColors = CType(resources.GetObject("Display.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.Display.Zoom = 100
        '
        'NotChk
        '
        resources.ApplyResources(Me.NotChk, "NotChk")
        Me.NotChk.Name = "NotChk"
        Me.NotChk.UseVisualStyleBackColor = True
        '
        'Value
        '
        resources.ApplyResources(Me.Value, "Value")
        Me.Value.FormattingEnabled = True
        Me.Value.Name = "Value"
        '
        'Empty
        '
        resources.ApplyResources(Me.Empty, "Empty")
        Me.Empty.Name = "Empty"
        Me.Empty.UseVisualStyleBackColor = True
        '
        'AddConditional
        '
        Me.AcceptButton = Me.OK_Button
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.Controls.Add(Me.Empty)
        Me.Controls.Add(Me.Value)
        Me.Controls.Add(Me.NotChk)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.PassLabel)
        Me.Controls.Add(Me.AttIcon)
        Me.Controls.Add(Me.Attribute)
        Me.Controls.Add(Me.AttLabel)
        Me.Controls.Add(Me.Explanation)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MinimizeBox = False
        Me.Name = "AddConditional"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.AttIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Explanation As System.Windows.Forms.Label
    Friend WithEvents AttLabel As System.Windows.Forms.Label
    Friend WithEvents Attribute As System.Windows.Forms.ComboBox
    Friend WithEvents AttIcon As System.Windows.Forms.PictureBox
    Friend WithEvents PassLabel As System.Windows.Forms.Label
    Friend WithEvents Display As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents NotChk As System.Windows.Forms.CheckBox
    Friend WithEvents Value As System.Windows.Forms.ComboBox
    Friend WithEvents Empty As System.Windows.Forms.CheckBox

End Class
