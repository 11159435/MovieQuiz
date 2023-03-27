Public Class frmQuestion2
    


    Public Sub init()
        progressCount = 0
        tmrQ2.Enabled = True
        frmMain.playTrack("question2.wav")
        ProgressBarQ2.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub





    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        tmrQ2.Enabled = False
        If btnAnswer1.Checked = True Then
            playerScore = playerScore + 1

        End If
        frmQuestion3.Show()
        frmQuestion3.init()

    End Sub





    Private Sub tmrQ2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrQ2.Tick
        progressCount = progressCount + 1
        ProgressBarQ2.PerformStep()
        If progressCount = 10 Then

            MsgBox("Out of time, continue on to the next question.")

            tmrQ2.Enabled = False
            If btnAnswer1.Checked = True Then
                playerScore = playerScore + 1

            End If
            frmQuestion3.Show()
            frmQuestion3.init()


        End If
    End Sub

    Private Sub frmQuestion2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
