Public Class CheatGame

    Private ReadOnly DeckSize = 52  ' Must be divisible by 4

    Private ReadOnly CardTypes As String() = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"}

    Private ReadOnly Pile As New ArrayList
    Private ReadOnly CPU1Deck As New ArrayList
    Private ReadOnly CPU2Deck As New ArrayList
    Private ReadOnly CPU3Deck As New ArrayList
    Private ReadOnly PlayerDeck As New ArrayList

    Private FreeTurn As Boolean = True
    Private LastCardPlayed As String = "Ace"
    Private PlayerWasCheating As Boolean
    Private CPUWasCheating As Boolean

    Private Turn As Integer ' 0 is player's turn, 1-3 is CPU

    Private ReadOnly R As New Random

    Private Sub UpdateUI()
        CPU1Cards.Text = CPU1Deck.Count & " card"
        If Not CPU1Deck.Count = 1 Then
            CPU1Cards.Text &= "s"
        End If
        CPU2Cards.Text = CPU2Deck.Count & " card"
        If Not CPU2Deck.Count = 1 Then
            CPU2Cards.Text &= "s"
        End If
        CPU3Cards.Text = CPU3Deck.Count & " card"
        If Not CPU3Deck.Count = 1 Then
            CPU3Cards.Text &= "s"
        End If
        PileCards.Text = Pile.Count & " card"
        If Not Pile.Count = 1 Then
            PileCards.Text &= "s"
        End If
        If Pile.Count = 0 Then
            PileCards.Font = New Font(PileCards.Font, FontStyle.Bold)
        Else
            PileCards.Font = New Font(PileCards.Font, FontStyle.Regular)
        End If
        YourCards.Text = PlayerDeck.Count & " card"
        If Not PlayerDeck.Count = 1 Then
            YourCards.Text &= "s"
        End If
        CardList.Items.Clear()
        PlayerDeck.Sort()
        For Each card In PlayerDeck
            CardList.Items.Add(card)
        Next
        Me.Refresh()
        _Turn.Text = Turn

        If Turn = 0 Then
            CPUTurn.Hide()
            Accuse.Hide()
            Allow.Hide()
            PickCard.Show()
            MakeMove.Show()
            MakeMove.Enabled = False
            'Safe.Visible = (Pile.Count = 0)
            Safe.Visible = False
            FreeRound.Visible = FreeTurn
        Else
            CPUTurn.Show()
            Accuse.Show()
            Allow.Show()
            PickCard.Hide()
            MakeMove.Hide()
            Safe.Visible = False
            FreeRound.Visible = False
        End If

        PickCard.Items.Clear()
        If FreeTurn Then
            PickCard.Items.AddRange(CardTypes)
        Else
            Dim lower = Array.IndexOf(CardTypes, LastCardPlayed) - 1
            Dim higher = Array.IndexOf(CardTypes, LastCardPlayed) + 1
            If lower = -1 Then
                lower = CardTypes.GetLength(0) - 1
            End If
            If higher > CardTypes.GetLength(0) - 1 Then
                higher = 0
            End If
            PickCard.Items.Add(CardTypes(lower))
            PickCard.Items.Add(LastCardPlayed)
            PickCard.Items.Add(CardTypes(higher))
        End If
    End Sub

    Private Sub CheatGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CaughtNotif.Text = ""
        For index As Integer = 1 To DeckSize / 4
            CPU1Deck.Add(CardTypes(R.Next(0, CardTypes.Length - 1)))
        Next
        For index As Integer = 1 To DeckSize / 4
            CPU2Deck.Add(CardTypes(R.Next(0, CardTypes.Length - 1)))
        Next
        For index As Integer = 1 To DeckSize / 4
            CPU3Deck.Add(CardTypes(R.Next(0, CardTypes.Length - 1)))
        Next
        For index As Integer = 1 To DeckSize / 4
            PlayerDeck.Add(CardTypes(R.Next(0, CardTypes.Length - 1)))
        Next
        UpdateUI()
    End Sub

    Private Sub doTurn()
        If CPU1Deck.Count = 0 Then
            MsgBox("CPU 1 won!")
            Me.Parent.Dispose()
        ElseIf CPU2Deck.Count = 0 Then
            MsgBox("CPU 2 won!")
            Me.Parent.Dispose()
        ElseIf CPU3Deck.Count = 0 Then
            MsgBox("CPU 3 won!")
            Me.Parent.Dispose()
        ElseIf PlayerDeck.Count = 0 Then
            MsgBox("You won!")
            Me.Parent.Dispose()
        End If

        If R.Next(1, 3) = 2 Then
            CPUWasCheating = True
        Else
            CPUWasCheating = False
        End If

        Dim max = 5

        If Turn = 1 Then
            If CPU1Deck.Count < max Then
                max = CPU1Deck.Count
            End If
        ElseIf Turn = 2 Then
            If CPU2Deck.Count < max Then
                max = CPU2Deck.Count
            End If
        ElseIf Turn = 3 Then
            If CPU3Deck.Count < max Then
                max = CPU3Deck.Count
            End If
        End If

        Dim num = R.Next(1, max)
        'Dim type = CardTypes(R.Next(0, CardTypes.Length - 1))
        Dim type = LastCardPlayed

        Dim lower = Array.IndexOf(CardTypes, LastCardPlayed) - 1
        Dim higher = Array.IndexOf(CardTypes, LastCardPlayed) + 1
        If lower = -1 Then
            lower = CardTypes.GetLength(0) - 1
        End If
        If higher > CardTypes.GetLength(0) - 1 Then
            higher = 0
        End If

        If R.Next(1, 3) = 2 Then
            type = CardTypes(lower)
        End If
        If R.Next(1, 3) = 2 Then
            type = CardTypes(higher)
        End If

        For index As Integer = 1 To num
            Pile.Add(type)
            If Turn = 1 Then
                CPU1Deck.RemoveAt(0)
            ElseIf Turn = 2 Then
                CPU2Deck.RemoveAt(0)
            ElseIf Turn = 3 Then
                CPU3Deck.RemoveAt(0)
            End If
        Next

        Dim s = ""

        If Not num = 1 Then
            s = "s"
        End If

        Dim htype = type
        If htype = "2" Then
            htype = "two"
        ElseIf htype = "3" Then
            htype = "three"
        ElseIf htype = "4" Then
            htype = "four"
        ElseIf htype = "5" Then
            htype = "five"
        ElseIf htype = "6" Then
            htype = "six"
        ElseIf htype = "7" Then
            htype = "seven"
        ElseIf htype = "8" Then
            htype = "eight"
        ElseIf htype = "9" Then
            htype = "nine"
        ElseIf htype = "10" Then
            htype = "ten"
        End If

        CPUTurn.Text = "CPU " & Turn & " played " & num & " " & htype & " card" & s
        Accuse.Text = "Accuse CPU " & Turn & " of cheating!"
        Allow.Text = "Let CPU " & Turn & " slide"

        LastCardPlayed = type

        UpdateUI()
    End Sub

    Private Sub MakeMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakeMove.Click
        MakeMove.Text = "Make your move"
        LastCardPlayed = PickCard.Text
        PlayerWasCheating = False
        Dim toRemove As New ArrayList
        For Each item As String In CardList.SelectedItems
            If Not item = LastCardPlayed Then
                PlayerWasCheating = True
            End If
            Pile.Add(item)
            toRemove.Add(item)
        Next
        For Each item In toRemove
            PlayerDeck.Remove(item)
        Next

        Dim coin = R.Next(1, 3)
        Label4.Text = coin
        CaughtNotif.Font = New Font(CaughtNotif.Font, FontStyle.Regular)
        If coin = 2 Then
            Dim cpu = R.Next(1, 3)
            If PlayerWasCheating Then
                CaughtNotif.Font = New Font(CaughtNotif.Font, FontStyle.Bold)
                CaughtNotif.Text = "You got caught by CPU " & cpu & "! +" & Pile.Count
                For Each card In Pile
                    PlayerDeck.Add(card)
                Next
                Pile.Clear()
                CaughtNotif.Show()
            Else
                CaughtNotif.Text = "CPU " & cpu & " tried to accuse you" & Environment.NewLine & " and got +" & Pile.Count & "!"
                For Each card In Pile
                    If cpu = 1 Then
                        CPU1Deck.Add(card)
                    ElseIf cpu = 2 Then
                        CPU2Deck.Add(card)
                    ElseIf cpu = 3 Then
                        CPU3Deck.Add(card)
                    End If
                Next
                Pile.Clear()
                CaughtNotif.Show()
            End If
        Else
            CaughtNotif.Text = ""
            If PlayerWasCheating And Pile.Count > 0 Then
                CaughtNotif.Text = "Phew!"
            End If
        End If

        Turn += 1
        FreeTurn = False
        doTurn()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PickCard.SelectedIndexChanged
        If CardList.SelectedItems.Count < 5 And CardList.SelectedItems.Count > 0 Then
            MakeMove.Enabled = True
        End If
    End Sub

    Private Sub CardList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CardList.SelectedIndexChanged, PickCard.SelectedIndexChanged
        If CardList.SelectedItems.Count > 4 Then
            CardList.SelectedItems.Clear()
        End If
        If CardList.SelectedItems.Count > 0 Then
            If Not PickCard.SelectedIndex = -1 Then
                MakeMove.Enabled = True
            End If
        End If
        MakeMove.Text = "Make your move"
        MakeMove.Font = New Font(MakeMove.Font, FontStyle.Regular)
        For Each item As String In CardList.SelectedItems
            If (Not item = PickCard.Text) And MakeMove.Visible Then
                MakeMove.Text = "Cheat"
                MakeMove.Font = New Font(MakeMove.Font, FontStyle.Bold)
            End If
        Next
    End Sub

    Private Sub Accuse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Accuse.Click
        If CPUWasCheating Then
            CaughtNotif.Text = "CPU " & Turn & " was caught and got +" & Pile.Count
            FreeTurn = True
            For Each card In Pile
                If Turn = 1 Then
                    CPU1Deck.Add(card)
                ElseIf Turn = 2 Then
                    CPU2Deck.Add(card)
                ElseIf Turn = 3 Then
                    CPU3Deck.Add(card)
                End If
            Next
            Pile.Clear()
        Else
            CaughtNotif.Font = New Font(CaughtNotif.Font, FontStyle.Bold)
            CaughtNotif.Text = "CPU " & Turn & " was not cheating! +" & Pile.Count
            For Each card In Pile
                PlayerDeck.Add(card)
            Next
            Pile.Clear()
        End If
        If Turn = 3 Then
            Turn = 0
            UpdateUI()
        Else
            Turn += 1
            doTurn()
        End If
    End Sub

    Private Sub Allow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allow.Click
        CaughtNotif.Text = ""
        If Turn = 3 Then
            Turn = 0
            UpdateUI()
        Else
            Turn += 1
            doTurn()
        End If
    End Sub

End Class