Imports System.Windows.Forms

Public Class AddConditional
    Public output = ""

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim ineq = ""
        If Yesnt.Checked Then
            ineq = "!"
        End If
        For Each line In Display.Lines
            If Not output = "" Then
                output &= vbNewLine
            End If
            output &= "[" & Attribute.Text & ineq & "=" & EqualsTxt.Text & "]" & line.Replace(vbNewLine, "").Replace("\n", "") & "[/" & Attribute.Text & ineq & "=]"
        Next
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
        Display.WordWrap = My.Settings.WordWrap
        Display.VirtualSpace = My.Settings.VirtualSpace
        Display.WideCaret = My.Settings.WideCaret
        Display.Font = My.Settings.editorFont
    End Sub
End Class
