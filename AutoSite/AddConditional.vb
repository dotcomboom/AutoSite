Public Class AddConditional
    Public output = ""

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Empty.Checked Then
            Value.Text = ""
        End If
        Dim ineq = ""
        If NotChk.Checked Then
            ineq = "!"
        End If
        For Each line In Display.Lines
            If Not output = "" Then
                output &= vbNewLine
            End If
            output &= "[" & Attribute.Text & ineq & "=" & Value.Text & "]" & line.Replace(vbNewLine, "").Replace("\n", "") & "[/" & Attribute.Text & ineq & "=]"
        Next
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Populate() Handles Attribute.SelectedIndexChanged, Attribute.TextChanged
        For Each att As TreeNode In Main.AttributeTree.Nodes
            If att.Text = Attribute.Text Then
                Value.Items.Clear()
                For Each val As TreeNode In att.Nodes
                    Value.Items.Add(val.Text)
                Next
            End If
        Next
    End Sub

    Private Sub AddConditional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each att As TreeNode In Main.AttributeTree.Nodes
            Attribute.Items.Add(att.Text)
        Next
        Populate()
        Display.WordWrap = My.Settings.WordWrap
        Display.VirtualSpace = My.Settings.VirtualSpace
        Display.WideCaret = My.Settings.WideCaret
        Display.Font = My.Settings.editorFont
        If Application.VisualStyleState = VisualStyles.VisualStyleState.NoneEnabled Then
            Me.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub AddConditional_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Empty_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Empty.CheckedChanged
        Value.Enabled = (Not Empty.Checked)
    End Sub

End Class