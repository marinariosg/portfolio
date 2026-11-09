Public Class frmDeletePassenger
    Private Sub frmDeletePassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim dt As New DataTable

        Try
            'open
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine & "The application will now close.", Me.Text + "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()

            End If

            'build sql
            strSelect = "SELECT intPassengerID, " &
                    "strFirstName + ' ' + strLastName AS PassengerName " &
                    "FROM TPassengers"

            'execute
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()
            dt.Load(drSourceTable)

            'display
            cboPassengers.ValueMember = "intPassengerID"
            cboPassengers.DisplayMember = "PassengerName"
            cboPassengers.DataSource = dt

            'close
            drSourceTable.Close()
            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub cboPassengers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPassengers.SelectedIndexChanged
        Dim strDelete As String = ""
        Dim cmdDelete As OleDb.OleDbCommand
        Dim intRowsAffected As Integer

        'validate
        Try
            If MessageBox.Show("Delete selected passenger?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Sub

            End If

            'open
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine & "The application will now close.", Me.Text + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()

            End If

            'build sql
            strDelete = "DELETE FROM TPassengers WHERE intPassengerID = ?"
            cmdDelete = New OleDb.OleDbCommand(strDelete, m_conAdministrator)
            cmdDelete.Parameters.AddWithValue("@intPassengerID", cboPassengers.SelectedValue)

            'execute
            intRowsAffected = cmdDelete.ExecuteNonQuery()

            'display
            If intRowsAffected > 0 Then
                MessageBox.Show("Passenger deleted successfully.")
                Close()
            Else
                MessageBox.Show("Passenger was not deleted.")
            End If
            'close
            CloseDatabaseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class