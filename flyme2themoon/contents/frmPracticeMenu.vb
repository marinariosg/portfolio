Public Class frmPracticeMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnFutureFlights_Click(sender As Object, e As EventArgs) Handles btnFutureFlights.Click
        Dim frm As New frmShowFutureFlights

        frm.Show()

    End Sub

    Private Sub btnPassengerFlights_Click(sender As Object, e As EventArgs) Handles btnPassengerFlights.Click

        Dim frm As New frmShowPassengerFlights

        frm.Show()

    End Sub

    Private Sub btnPilotFlights_Click(sender As Object, e As EventArgs) Handles btnPilotFlights.Click

        Dim frm As New frmShowPilotFlights

        frm.Show()

    End Sub

    Private Sub btnAttendantFlight_Click(sender As Object, e As EventArgs) Handles btnAttendantFlight.Click
        Dim frm As New frmShowAttendantFlights

        frm.Show()

    End Sub

    Private Sub frmPracticeMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class