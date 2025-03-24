Public Class frmMain
    Private Sub bntStart_Click(sender As Object, e As EventArgs) Handles bntStart.Click
        frmQuestion1.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class
