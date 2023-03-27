Public Class frmQuestion4



    Public Sub init()
        progressCount = 0
        tmrQ4.Enabled = True
        frmMain.playTrack("question4.wav")
        ProgressBarQ4.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub





    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        tmrQ4.Enabled = False
        If btnAnswer2.Checked = True Then
            playerScore = playerScore + 1

        End If
        frmQuestion5.Show()
        frmQuestion5.Init()

    End Sub





    Private Sub tmrQ4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrQ4.Tick
        progressCount = progressCount + 1
        ProgressBarQ4.PerformStep()
        If progressCount = 10 Then

            MsgBox("Out of time, continue on to the next question.")

            tmrQ4.Enabled = False
            If btnAnswer2.Checked = True Then
                playerScore = playerScore + 1

            End If
            frmQuestion5.Show()
            frmQuestion5.Init()


        End If
    End Sub
End Class