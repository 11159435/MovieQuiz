Public Class frmQuestion5

    Public Sub init()
        progressCount = 0
        tmrQ5.Enabled = True
        frmMain.playTrack("question5.wav")
        ProgressBarQ5.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        tmrQ5.Enabled = False
        If btnAnswer4.Checked = True Then
            playerScore = playerScore + 1

        End If
        frmHighScore.Show()
        frmHighScore.doscore()

    End Sub





    Private Sub tmrQ5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrQ5.Tick
        progressCount = progressCount + 1
        ProgressBarQ5.PerformStep()
        If progressCount = 10 Then

            MsgBox("Out of time, continue on to the next question.")

            tmrQ5.Enabled = False
            If btnAnswer4.Checked = True Then
                playerScore = playerScore + 1

            End If
            frmHighScore.Show()
            frmHighScore.doscore()


        End If
    End Sub
End Class




