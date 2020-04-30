Public Class StartPage

    Private Sub StartPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Recent1.Visible = My.Settings.recents.Count > 0
        Recent2.Visible = My.Settings.recents.Count > 1
        Recent3.Visible = My.Settings.recents.Count > 2
        Recent4.Visible = My.Settings.recents.Count > 3
        Recent5.Visible = My.Settings.recents.Count > 4
        R1.Visible = My.Settings.recents.Count > 0
        R2.Visible = My.Settings.recents.Count > 1
        R3.Visible = My.Settings.recents.Count > 2
        R4.Visible = My.Settings.recents.Count > 3
        R5.Visible = My.Settings.recents.Count > 4
        If My.Settings.recents.Count > 0 Then
            Recent1.Text = My.Settings.recents(0)
            Recent1.Tag = My.Settings.recents(0)
        Else
            R1.Show()
            R1.Text = "You have no recent sites yet."
        End If
        If My.Settings.recents.Count > 1 Then
            Recent2.Text = My.Settings.recents(1)
            Recent2.Tag = My.Settings.recents(1)
        End If
        If My.Settings.recents.Count > 2 Then
            Recent3.Text = My.Settings.recents(2)
            Recent3.Tag = My.Settings.recents(2)
        End If
        If My.Settings.recents.Count > 3 Then
            Recent4.Text = My.Settings.recents(3)
            Recent4.Tag = My.Settings.recents(3)
        End If
        If My.Settings.recents.Count > 4 Then
            Recent5.Text = My.Settings.recents(4)
            Recent5.Tag = My.Settings.recents(4)
        End If
    End Sub

    Private Sub OpenLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles OpenLink.LinkClicked
        Main.OpenFolder_Click()
    End Sub

    Private Sub Recent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recent1.Click, Recent2.Click, Recent3.Click, Recent4.Click, Recent5.Click
        Main.openSite(sender.Tag, False)
    End Sub

End Class