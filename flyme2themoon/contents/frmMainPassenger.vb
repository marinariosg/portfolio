Public Class frmMainPassenger
    Private Sub btnPassenger_Click(sender As Object, e As EventArgs) Handles btnAddPassenger.Click
        frmAddPassenger.ShowDialog()

    End Sub

    Private Sub btnUpdatePassenger_Click(sender As Object, e As EventArgs) Handles btnUpdatePassenger.Click
        Dim frmUpdatePassenger As New frmUpdatePassenger
        frmUpdatePassenger.ShowDialog()
    End Sub

    Private Sub btnShowPassenger_Click(sender As Object, e As EventArgs) Handles btnShowPassenger.Click
        frmShowPassenger.ShowDialog()
    End Sub

    Private Sub btnDeletePassenger_Click(sender As Object, e As EventArgs) Handles btnDeletePassenger.Click
        Dim frmDeletePassenger As New frmDeletePassenger
        frmDeletePassenger.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmMainPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class