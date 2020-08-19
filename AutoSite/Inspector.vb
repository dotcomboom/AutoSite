Public Class Inspector

    Private Sub iterateControls(ByVal ctrl As Control, ByVal mode As String, Optional ByVal s As String = "")
        For Each c As Control In ctrl.Controls
            If mode = "combo" Then
                ComboBox1.Items.Add(c.Name)
            ElseIf mode = "select" Then
                If c.Name = s Then
                    PropertyGrid1.SelectedObject = c
                End If
            End If
            iterateControls(c, mode, s)
        Next
    End Sub

    Private Sub Inspector_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        iterateControls(Main, "combo")
    End Sub

    Private Sub ComboBox1_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)
        iterateControls(Main, "select", ComboBox1.SelectedItem)
    End Sub

    Private Sub PropertyGrid1_PropertyValueChanged(ByVal s As System.Object, ByVal e As System.Windows.Forms.PropertyValueChangedEventArgs) Handles PropertyGrid1.PropertyValueChanged
        TextBox1.AppendText(PropertyGrid1.SelectedObject.Name & "." & e.ChangedItem.PropertyDescriptor.DisplayName & vbTab & e.ChangedItem.Value.ToString & vbNewLine)
    End Sub

    Public Shared Function FindFocusedControl(ByVal control As Control) As Control
        Dim container = TryCast(control, IContainerControl)

        While container IsNot Nothing
            control = container.ActiveControl
            container = TryCast(control, IContainerControl)
        End While

        Return control
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button1.MouseHover
        Try
            PropertyGrid1.SelectedObject = FindFocusedControl(Main)
            ComboBox1.Text = FindFocusedControl(Main).Name
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            iterateControls(Main, "select", ComboBox1.SelectedItem)
        End If
    End Sub
End Class