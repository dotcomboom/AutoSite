Public Class About

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Version.Text = My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        If My.Application.Info.Version.Build > 0 Then
            Version.Text &= "." & My.Application.Info.Version.Build
        End If
        If My.Application.Info.Version.Revision > 0 Then
            Version.Text &= "." & My.Application.Info.Version.Revision
        End If
        Version.Text &= " " & My.Application.Info.Description
        If Application.VisualStyleState = VisualStyles.VisualStyleState.NoneEnabled Then
            Me.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub GithubLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GithubLink.LinkClicked
        Process.Start("https://github.com/dotcomboom/AutoSite")
    End Sub

    Private Sub WebsiteLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles WebsiteLink.LinkClicked
        Process.Start("https://dotcomboom.somnolescent.net/autosite")
    End Sub

    Private Sub About_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, LicenseBox.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.NumPad5 Then
            Dim egg = "?"
            While egg.Length < 256
                egg &= "?"
            End While
            Me.Text = egg
            For Each control As Control In Me.Controls
                control.Text = egg
                For Each ctl As Control In control.Controls
                    ctl.Text = egg
                Next
            Next
        End If
    End Sub
End Class