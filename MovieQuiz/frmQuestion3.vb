Public Class frmQuestion3



    Public Sub init()
        progressCount = 0
        tmrQ3.Enabled = True
        frmMain.playTrack("question3.wav")
        ProgressBarQ3.Value = 0
        btnAnswer1.Checked = False
        btnAnswer2.Checked = False
        btnAnswer3.Checked = False
        btnAnswer4.Checked = False

    End Sub





    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        tmrQ3.Enabled = False
        If btnAnswer4.Checked = True Then
            playerScore = playerScore + 1

        End If
        frmQuestion4.Show()
        frmQuestion4.init()

    End Sub





    Private Sub tmrQ3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrQ3.Tick
        progressCount = progressCount + 1
        ProgressBarQ3.PerformStep()
        If progressCount = 10 Then

            MsgBox("Out of time, continue on to the next question.")

            tmrQ3.Enabled = False
            If btnAnswer4.Checked = True Then
                playerScore = playerScore + 1

            End If
            frmQuestion4.Show()
            frmQuestion4.init()


        End If
    End Sub

    Private Sub frmQuestion3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
