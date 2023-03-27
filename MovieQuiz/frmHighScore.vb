Public Class frmHighScore

    Public Sub doscore()
        If (playerScore < 1) Then
            lblmessage.Text = "Sorry Your Score Was Not Good Enough"
        Else
            lblmessage.Text = "Congratulations Your Score Will Be Added To The Hall Of Fame!"
            lstHighscore.Items.Add(playerName & vbTab & vbTab & playerScore)
        End If
    End Sub
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()


    End Sub
End Class