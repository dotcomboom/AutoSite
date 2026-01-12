Public Class StartPage

    Private Sub StartPage_Load() Handles MyBase.Load
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
        dateFormat.Text = My.Settings.modDateFormat
    End Sub

    Private Sub NewSite_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles NewSite.LinkClicked
        Main.browseForSite(True)
    End Sub
    Private Sub OpenSite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles OpenSite.LinkClicked
        Main.browseForSite(False)
    End Sub

    Private Sub Recent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recent1.Click, Recent2.Click, Recent3.Click, Recent4.Click, Recent5.Click
        If My.Computer.FileSystem.DirectoryExists(sender.tag) Then
            Main.openSite(sender.Tag, False)
        Else
            If MsgBox(String.Format(My.Resources.Question_RemoveFromRecents, sender.Tag), MsgBoxStyle.Question + MsgBoxStyle.YesNo, Application.ProductName) = MsgBoxResult.Yes Then
                My.Settings.recents.Remove(sender.Tag)
                Me.StartPage_Load()
                Main.updateRecents()
            End If
        End If
    End Sub


    Sub StartPagePaint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim s = RWarn.Size
        s.Width = Me.Width - RWarn.Location.X - 16
        RWarn.Size = s
    End Sub

    Private Sub dateFormat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateFormat.TextChanged
        Label5.Text = Apricot.calcModified(Today, dateFormat.Text)
        My.Settings.modDateFormat = dateFormat.Text
    End Sub
End Class