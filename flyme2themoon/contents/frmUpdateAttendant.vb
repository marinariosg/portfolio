Imports System.Data.OleDb
Public Class frmUpdateAttendant
    Private Sub frmUpdateAttendant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strSelect As String = ""
        Dim cmdSelect As OleDbCommand
        Dim drSourceTable As OleDbDataReader

        Try
            'open
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show("Database connection error.")
                Me.Close()

            End If
            'build sql
            strSelect = "SELECT * FROM TAttendants " &
                        "WHERE intAttendantID = ?"
            'execute
            cmdSelect = New OleDbCommand(strSelect, m_conAdministrator)

            cmdSelect.Parameters.AddWithValue("@AttendantID", g_intAttendantID)

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
        Dim cmdUpdate As OleDbCommand
        Dim intRowsAffected As Integer

        Try
            'open
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show("Database connection error.")
                Me.Close()

            End If

            If txtFirstName.Text.Trim() = String.Empty Then

                MessageBox.Show("Please enter a first name.")
                txtFirstName.Focus()
                Exit Sub

            End If
            'validate
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
            strUpdate = "UPDATE TAttendants " &
                    "SET strFirstName = ?, " &
                    "strLastName = ?, " &
                    "strEmployeeID = ? " &
                    "WHERE intAttendantID = ?"
            'execute
            cmdUpdate = New OleDbCommand(strUpdate, m_conAdministrator)

            cmdUpdate.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
            cmdUpdate.Parameters.AddWithValue("@LastName", txtLastName.Text)
            cmdUpdate.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text)
            cmdUpdate.Parameters.AddWithValue("@AttendantID", g_intAttendantID)

            intRowsAffected = cmdUpdate.ExecuteNonQuery()
            'display
            If intRowsAffected > 0 Then

                MessageBox.Show("Attendant updated successfully.")

            Else

                MessageBox.Show("Attendant was not updated.")

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