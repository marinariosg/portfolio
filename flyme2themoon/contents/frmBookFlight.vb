Imports System.Data.OleDb
Public Class frmBookFlight
    Private Sub frmBookFlight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim dtFlights As New DataTable

        Try
            'open
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show("Database connection error.")
                Me.Close()

            End If

            'build sql
            strSelect = "SELECT intFlightID, strFlightNumber " &
            "FROM TFlights " &
            "WHERE dtmFlightDate > GETDATE()"

            'execute
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

            drSourceTable = cmdSelect.ExecuteReader()

            dtFlights.Load(drSourceTable)

            'display
            cboFlights.ValueMember = "intFlightID"
            cboFlights.DisplayMember = "strFlightNumber"
            cboFlights.DataSource = dtFlights
            'close
            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        Dim strSelect As String
        Dim strInsert As String
        Dim cmdSelect As OleDb.OleDbCommand
        Dim cmdInsert As OleDb.OleDbCommand
        Dim intNextID As Integer

        Try
            'validate
            If txtSeat.Text.Trim() = String.Empty Then

                MessageBox.Show("Please enter a seat.")
                txtSeat.Focus()

                Exit Sub

            End If

            If MessageBox.Show("Book this flight?",
                               "Confirm Booking",
                               MessageBoxButtons.YesNo) = DialogResult.No Then

                Exit Sub

            End If

            'open
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show("Database connection error.")
                Me.Close()

            End If

            'build sql
            strSelect = "SELECT MAX(intFlightPassengerID) + 1 AS NextID " &
                        "FROM TFlightPassengers"

            'execute
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

            intNextID = CInt(cmdSelect.ExecuteScalar())

            'build sql
            strInsert = "INSERT INTO TFlightPassengers " &
                        "(intFlightPassengerID, intFlightID, intPassengerID, strSeat) " &
                        "VALUES (?, ?, ?, ?)"

            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            cmdInsert.Parameters.AddWithValue("@intFlightPassengerID", intNextID)
            cmdInsert.Parameters.AddWithValue("@intFlightID", cboFlights.SelectedValue)
            cmdInsert.Parameters.AddWithValue("@intPassengerID", g_intPassengerID)
            cmdInsert.Parameters.AddWithValue("@strSeat", txtSeat.Text)

            'execute
            cmdInsert.ExecuteNonQuery()

            'display
            MessageBox.Show("Flight booked successfully.")

            'close
            CloseDatabaseConnection()

            Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

End Class