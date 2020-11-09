Public Class StartPage

    Private Sub StartPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Recent1.Visible = My.Settings.recents.Count > 0
        Recent2.Visible = My.Settings.recents.Count > 1
        Recent3.Visible = My.Settings.recents.Count > 2
        Recent4.Visible = My.Settings.recents.Count > 3
        Recent5.Visible = My.Settings.recents.Count > 4
        RWarn.Visible = My.Settings.recents.Count = 0
        R1.Visible = My.Settings.recents.Count > 0
        R2.Visible = My.Settings.recents.Count > 1
        R3.Visible = My.Settings.recents.Count > 2
        R4.Visible = My.Settings.recents.Count > 3
        R5.Visible = My.Settings.recents.Count > 4
        If My.Settings.recents.Count > 0 Then
            Recent1.Text = My.Settings.recents(0)
            Recent1.Tag = My.Settings.recents(0)
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
        Me.Font = Main.getFont()
    End Sub

    Private Sub NewSite_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewSite.LinkClicked
        Main.browseForSite(True)
    End Sub
    Private Sub OpenSite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles OpenSite.LinkClicked
        Main.browseForSite(False)
    End Sub

    Private Sub Recent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recent1.Click, Recent2.Click, Recent3.Click, Recent4.Click, Recent5.Click
        Main.openSite(sender.Tag, False)
    End Sub

    
    Sub StartPagePaint(sender As Object, e As PaintEventArgs)
    	Dim s = RWarn.Size
    	s.Width = Me.Width - RWarn.Location.x - 10
    	RWarn.Size = s
    End Sub
End Class