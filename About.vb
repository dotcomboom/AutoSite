Public Class About

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Version.Text = "v" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor
        If My.Application.Info.Version.Build > 0 Then
            Version.Text &= "." & My.Application.Info.Version.Build
        End If
        If My.Application.Info.Version.Revision > 0 Then
            Version.Text &= "." & My.Application.Info.Version.Revision
        End If
        Me.Text = "About AutoSite XL " & Version.Text
    End Sub

    Private Sub GithubLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles GithubLink.LinkClicked
        Process.Start("https://github.com/dotcomboom/AutoSite-XL")
    End Sub

    Private Sub WebsiteLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles WebsiteLink.LinkClicked
        Process.Start("https://dotcomboom.somnolescent.net/autosite/xl")
    End Sub

    Private Sub PyGithubLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PyGithubLink.LinkClicked
        Process.Start("https://github.com/dotcomboom/AutoSite/")
    End Sub

    Private Sub PyWebsiteLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles PyWebsiteLink.LinkClicked
        Process.Start("https://dotcomboom.somnolescent.net/autosite")
    End Sub
End Class