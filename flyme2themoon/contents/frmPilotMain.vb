Public Class frmPilotMain
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        g_intPilotID = 0
        Dim frm As New frmLogin
        frm.Show()
        Close()

    End Sub

    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click
        Dim frm As New frmUpdatePilot
        frm.ShowDialog()
    End Sub

    Private Sub frmPilotMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub btnPastFlight_Click(sender As Object, e As EventArgs) Handles btnPastFlight.Click
        Dim frm As New frmPilotPastFlights
        frm.ShowDialog()
    End Sub

    Private Sub btnFutureFlights_Click(sender As Object, e As EventArgs) Handles btnFutureFlights.Click

        Dim frm As New frmPilotFutureFlights
        frm.ShowDialog()
    End Sub
End Class