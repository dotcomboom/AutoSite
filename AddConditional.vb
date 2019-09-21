Imports System.Windows.Forms

Public Class AddConditional
    Public output = ""

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim out = ""
        Dim ineq = ""
        If Yesnt.Checked Then
            ineq = "!"
        End If
        For Each line In FastColoredTextBox1.Lines
            If Not out = "" Then
                out &= vbNewLine
            End If
            out &= "[" & Attribute.Text & ineq & "=" & EqualsTxt.Text & "]" & line.Replace(vbNewLine, "").Replace("\n", "") & "[/" & Attribute.Text & ineq & "=]"
        Next
        output = out
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddConditional_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each att As TreeNode In Form1.AttributeTree.Nodes
            Attribute.Items.Add(att.Text)
        Next
    End Sub
End Class
