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
        Me.Equals = New System.Windows.Forms.TextBox
        Me.PassLabel = New System.Windows.Forms.Label
        Me.FastColoredTextBox1 = New FastColoredTextBoxNS.FastColoredTextBox
        Me.Yesnt = New System.Windows.Forms.CheckBox
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AttIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(183, 337)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(4, 4)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(101, 4)
        Me.Cancel_Button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(89, 28)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Explanation
        '
        Me.Explanation.Location = New System.Drawing.Point(12, 11)
        Me.Explanation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Explanation.Name = "Explanation"
        Me.Explanation.Size = New System.Drawing.Size(365, 87)
        Me.Explanation.TabIndex = 1
        Me.Explanation.Text = resources.GetString("Explanation.Text")
        '
        'AttLabel
        '
        Me.AttLabel.AutoSize = True
        Me.AttLabel.Location = New System.Drawing.Point(12, 106)
        Me.AttLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AttLabel.Name = "AttLabel"
        Me.AttLabel.Size = New System.Drawing.Size(121, 17)
        Me.AttLabel.TabIndex = 4
        Me.AttLabel.Text = "Attribute to query:"
        '
        'Attribute
        '
        Me.Attribute.FormattingEnabled = True
        Me.Attribute.Location = New System.Drawing.Point(161, 102)
        Me.Attribute.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Attribute.Name = "Attribute"
        Me.Attribute.Size = New System.Drawing.Size(215, 24)
        Me.Attribute.TabIndex = 5
        Me.Attribute.Text = "path"
        '
        'AttIcon
        '
        Me.AttIcon.Image = CType(resources.GetObject("AttIcon.Image"), System.Drawing.Image)
        Me.AttIcon.Location = New System.Drawing.Point(139, 106)
        Me.AttIcon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AttIcon.Name = "AttIcon"
        Me.AttIcon.Size = New System.Drawing.Size(16, 16)
        Me.AttIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AttIcon.TabIndex = 6
        Me.AttIcon.TabStop = False
        '
        'Equals
        '
        Me.Equals.Location = New System.Drawing.Point(76, 134)
        Me.Equals.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Equals.Name = "Equals"
        Me.Equals.Size = New System.Drawing.Size(300, 22)
        Me.Equals.TabIndex = 9
        Me.Equals.Text = "index.html"
        '
        'PassLabel
        '
        Me.PassLabel.AutoSize = True
        Me.PassLabel.Location = New System.Drawing.Point(13, 172)
        Me.PassLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PassLabel.Name = "PassLabel"
        Me.PassLabel.Size = New System.Drawing.Size(214, 17)
        Me.PassLabel.TabIndex = 11
        Me.PassLabel.Text = "If conditional passes, render out:"
        '
        'FastColoredTextBox1
        '
        Me.FastColoredTextBox1.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.FastColoredTextBox1.AutoIndentCharsPatterns = "^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>[^;=]+);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "^\s*(case|default)\s*[^:]*" & _
            "(?<range>:)\s*(?<range>[^;]+);"
        Me.FastColoredTextBox1.AutoScrollMinSize = New System.Drawing.Size(31, 18)
        Me.FastColoredTextBox1.BackBrush = Nothing
        Me.FastColoredTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FastColoredTextBox1.CharHeight = 18
        Me.FastColoredTextBox1.CharWidth = 10
        Me.FastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.FastColoredTextBox1.IsReplaceMode = False
        Me.FastColoredTextBox1.Language = FastColoredTextBoxNS.Language.HTML
        Me.FastColoredTextBox1.Location = New System.Drawing.Point(17, 196)
        Me.FastColoredTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FastColoredTextBox1.Name = "FastColoredTextBox1"
        Me.FastColoredTextBox1.Paddings = New System.Windows.Forms.Padding(0)
        Me.FastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FastColoredTextBox1.ServiceColors = CType(resources.GetObject("FastColoredTextBox1.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.FastColoredTextBox1.Size = New System.Drawing.Size(360, 133)
        Me.FastColoredTextBox1.TabIndex = 12
        Me.FastColoredTextBox1.Zoom = 100
        '
        'Yesnt
        '
        Me.Yesnt.AutoSize = True
        Me.Yesnt.Location = New System.Drawing.Point(15, 134)
        Me.Yesnt.Name = "Yesnt"
        Me.Yesnt.Size = New System.Drawing.Size(60, 21)
        Me.Yesnt.TabIndex = 13
        Me.Yesnt.Text = "NOT"
        Me.Yesnt.UseVisualStyleBackColor = True
        '
        'AddConditional
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(391, 388)
        Me.Controls.Add(Me.Yesnt)
        Me.Controls.Add(Me.FastColoredTextBox1)
        Me.Controls.Add(Me.PassLabel)
        Me.Controls.Add(Me.Equals)
        Me.Controls.Add(Me.AttIcon)
        Me.Controls.Add(Me.Attribute)
        Me.Controls.Add(Me.AttLabel)
        Me.Controls.Add(Me.Explanation)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddConditional"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Insert Conditional"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.AttIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FastColoredTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Equals As System.Windows.Forms.TextBox
    Friend WithEvents PassLabel As System.Windows.Forms.Label
    Friend WithEvents FastColoredTextBox1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Yesnt As System.Windows.Forms.CheckBox

End Class
