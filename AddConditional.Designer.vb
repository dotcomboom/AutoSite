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
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(190, 384)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(171, 38)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.White
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(77, 30)
        Me.OK_Button.TabIndex = 5
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.White
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cancel_Button.Location = New System.Drawing.Point(89, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(78, 30)
        Me.Cancel_Button.TabIndex = 6
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Explanation
        '
        Me.Explanation.Location = New System.Drawing.Point(9, 8)
        Me.Explanation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Explanation.Name = "Explanation"
        Me.Explanation.Size = New System.Drawing.Size(319, 101)
        Me.Explanation.TabIndex = 1
        Me.Explanation.Text = resources.GetString("Explanation.Text")
        '
        'AttLabel
        '
        Me.AttLabel.AutoSize = True
        Me.AttLabel.Location = New System.Drawing.Point(9, 116)
        Me.AttLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AttLabel.Name = "AttLabel"
        Me.AttLabel.Size = New System.Drawing.Size(123, 19)
        Me.AttLabel.TabIndex = 2
        Me.AttLabel.Text = "Attribute to query:"
        '
        'Attribute
        '
        Me.Attribute.FormattingEnabled = True
        Me.Attribute.Location = New System.Drawing.Point(157, 113)
        Me.Attribute.Margin = New System.Windows.Forms.Padding(4)
        Me.Attribute.Name = "Attribute"
        Me.Attribute.Size = New System.Drawing.Size(199, 25)
        Me.Attribute.TabIndex = 1
        Me.Attribute.Text = "path"
        '
        'AttIcon
        '
        Me.AttIcon.Image = CType(resources.GetObject("AttIcon.Image"), System.Drawing.Image)
        Me.AttIcon.Location = New System.Drawing.Point(136, 119)
        Me.AttIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.AttIcon.Name = "AttIcon"
        Me.AttIcon.Size = New System.Drawing.Size(16, 16)
        Me.AttIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AttIcon.TabIndex = 6
        Me.AttIcon.TabStop = False
        '
        'PassLabel
        '
        Me.PassLabel.AutoSize = True
        Me.PassLabel.Location = New System.Drawing.Point(9, 208)
        Me.PassLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PassLabel.Name = "PassLabel"
        Me.PassLabel.Size = New System.Drawing.Size(207, 19)
        Me.PassLabel.TabIndex = 11
        Me.PassLabel.Text = "If conditional passes, render out:"
        '
        'Display
        '
        Me.Display.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.Display.AutoIndentCharsPatterns = Global.AutoSite_XL.My.Resources.Resources.openProject
        Me.Display.AutoScrollMinSize = New System.Drawing.Size(31, 18)
        Me.Display.BackBrush = Nothing
        Me.Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Display.CharHeight = 18
        Me.Display.CharWidth = 10
        Me.Display.CommentPrefix = Nothing
        Me.Display.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Display.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Display.IsReplaceMode = False
        Me.Display.Language = FastColoredTextBoxNS.Language.HTML
        Me.Display.LeftBracket = Global.Microsoft.VisualBasic.ChrW(60)
        Me.Display.LeftBracket2 = Global.Microsoft.VisualBasic.ChrW(40)
        Me.Display.Location = New System.Drawing.Point(13, 234)
        Me.Display.Margin = New System.Windows.Forms.Padding(4)
        Me.Display.Name = "Display"
        Me.Display.Paddings = New System.Windows.Forms.Padding(0)
        Me.Display.RightBracket = Global.Microsoft.VisualBasic.ChrW(62)
        Me.Display.RightBracket2 = Global.Microsoft.VisualBasic.ChrW(41)
        Me.Display.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Display.ServiceColors = CType(resources.GetObject("Display.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.Display.Size = New System.Drawing.Size(347, 141)
        Me.Display.TabIndex = 4
        Me.Display.Zoom = 100
        '
        'NotChk
        '
        Me.NotChk.AutoSize = True
        Me.NotChk.Location = New System.Drawing.Point(12, 145)
        Me.NotChk.Name = "NotChk"
        Me.NotChk.Size = New System.Drawing.Size(58, 23)
        Me.NotChk.TabIndex = 2
        Me.NotChk.Text = "NOT"
        Me.NotChk.UseVisualStyleBackColor = True
        '
        'Value
        '
        Me.Value.FormattingEnabled = True
        Me.Value.Location = New System.Drawing.Point(69, 144)
        Me.Value.Margin = New System.Windows.Forms.Padding(4)
        Me.Value.Name = "Value"
        Me.Value.Size = New System.Drawing.Size(287, 25)
        Me.Value.TabIndex = 3
        Me.Value.Text = "index.md"
        '
        'Empty
        '
        Me.Empty.AutoSize = True
        Me.Empty.Location = New System.Drawing.Point(69, 174)
        Me.Empty.Name = "Empty"
        Me.Empty.Size = New System.Drawing.Size(70, 23)
        Me.Empty.TabIndex = 12
        Me.Empty.Text = "Empty"
        Me.Empty.UseVisualStyleBackColor = True
        '
        'AddConditional
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(372, 439)
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
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddConditional"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Insert Conditional"
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
