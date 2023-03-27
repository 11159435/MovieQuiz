Public Class frmQuestion1
    

    Public Sub init()
        progressCount = 0
        tmrQ1.Enabled = True
        frmMain.playTrack("question1.wav")
        ProgressBarQ1.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub





    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        tmrQ1.Enabled = False
        If btnAnswer2.Checked = True Then
            playerScore = playerScore + 1

        End If
        frmQuestion2.Show()
        frmQuestion2.init()

    End Sub





    Private Sub tmrQ1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrQ1.Tick
        progressCount = progressCount + 1
        ProgressBarQ1.PerformStep()
        If progressCount = 10 Then

            MsgBox("Out of time, continue on to the next question.")

            tmrQ1.Enabled = False
            If btnAnswer2.Checked = True Then
                playerScore = playerScore + 1

            End If
            frmQuestion2.Show()
            frmQuestion2.init()


        End If
    End Sub


End Class