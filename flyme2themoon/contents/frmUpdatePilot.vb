Imports System.Data.OleDb

Public Class frmUpdatePilot
    Private Sub frmUpdatePilot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDbCommand
        Dim drSourceTable As OleDbDataReader

        Try
            'open
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show("Database connection error.")
                Me.Close()
                Exit Sub
            End If

            'execute
            cmdSelect = New OleDbCommand("SelectPilotByID", m_conAdministrator)

            cmdSelect.CommandType = CommandType.StoredProcedure

            cmdSelect.Parameters.AddWithValue("@PilotID", g_intPilotID)

            drSourceTable = cmdSelect.ExecuteReader()

            'display
            If drSourceTable.Read() Then

                txtFirstName.Text = drSourceTable("strFirstName").ToString()
                txtLastName.Text = drSourceTable("strLastName").ToString()
                txtEmployeeID.Text = drSourceTable("strEmployeeID").ToString()

            End If

            'close
            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strUpdate As String = ""
        Dim cmdUpdate As OleDb.OleDbCommand
        Dim intRowsAffected As Integer

        Try

            'open
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show("Database connection error.")
                Me.Close()

            End If

            'validate
            If txtFirstName.Text.Trim() = String.Empty Then

                MessageBox.Show("Please enter a first name.")
                txtFirstName.Focus()
                Exit Sub

            End If

            If txtLastName.Text.Trim() = String.Empty Then

                MessageBox.Show("Please enter a last name.")
                txtLastName.Focus()
                Exit Sub

            End If

            If txtEmployeeID.Text.Trim() = String.Empty Then

                MessageBox.Show("Please enter an employee ID.")
                txtEmployeeID.Focus()
                Exit Sub

            End If

            'build sql
            strUpdate = "UPDATE TPilots " &
                    "SET strFirstName = ?, " &
                    "strLastName = ?, " &
                    "strEmployeeID = ? " &
                    "WHERE intPilotID = ?"

            cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)

            cmdUpdate.Parameters.AddWithValue("@strFirstName", txtFirstName.Text)
            cmdUpdate.Parameters.AddWithValue("@strLastName", txtLastName.Text)
            cmdUpdate.Parameters.AddWithValue("@strEmployeeID", txtEmployeeID.Text)
            cmdUpdate.Parameters.AddWithValue("@intPilotID", g_intPilotID)

            'execute
            intRowsAffected = cmdUpdate.ExecuteNonQuery()

            'display
            If intRowsAffected > 0 Then

                MessageBox.Show("Pilot updated successfully.")
                Close()

            Else

                MessageBox.Show("Pilot was not updated.")

            End If

            'close
            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Close()
    End Sub
End Class