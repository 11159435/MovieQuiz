Public Class frmMain
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
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
        'set the URL of the windows media player to a new track 
        wmpQuiz.URL = track
        'play the new track
        wmpQuiz.Ctlcontrols.play()
    End Sub
End Class
