Public Class frmAttendantMain
    Private Sub btnUpdateProfile_Click(sender As Object, e As EventArgs) Handles btnUpdateProfile.Click

        Dim frm As New frmUpdateAttendant
        frm.ShowDialog()
    End Sub

    Private Sub btnPastFLights_Click(sender As Object, e As EventArgs) Handles btnPastFLights.Click
        Dim frm As New frmAttendantPastFlights
        frm.ShowDialog()
    End Sub

    Private Sub btnFutureFlights_Click(sender As Object, e As EventArgs) Handles btnFutureFlights.Click
        Dim frm As New frmAttendantFutureFlights
        frm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        g_intAttendantID = 0
        Dim frm As New frmLogin
        frm.Show()
        Me.Close()
    End Sub

    Private Sub frmAttendantMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class