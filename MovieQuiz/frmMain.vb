Public Class frmMain

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

        playerScore = 0

        If (txtName.Text = "") Then
            MsgBox("Please Enter Your Name")
        Else
            'save the player name to the global variable
            playerName = txtName.Text
            'show the first question form
            frmQuestion1.Show()
            'use the local sub procedure to initialise the form
            frmQuestion1.init()
            'set the player name to blank for game restart
            txtName.Text = ""
            'hide this form
            Me.Hide()
        End If

    End Sub

    Public Sub playTrack(ByVal track As String)

        'stop the windows media player 
        wmpQuiz.Ctlcontrols.stop()
        'set the URL of the windows media player to a new track to play
        wmpQuiz.URL = track
        'play the new track
        wmpQuiz.Ctlcontrols.play()

    End Sub

    Public Sub stopTrack()
        'stop the windows media player
        wmpQuiz.Ctlcontrols.stop()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'exit the application
        Application.Exit()
    End Sub

End Class
