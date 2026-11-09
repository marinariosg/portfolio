Imports System.Data.OleDb

Public Class frmPilotFutureFlights
    Private Sub frmPilotFutureFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cmdSelect As OleDbCommand
        Dim drSourceTable As OleDbDataReader

        Try
            'open
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show("Database connection error.")
                Me.Close()
            End If

            cmdSelect = New OleDbCommand("SelectPilotFutureFlights", m_conAdministrator)
            cmdSelect.CommandType = CommandType.StoredProcedure
            cmdSelect.Parameters.AddWithValue("@PilotID", g_intPilotID)

            'execute
            drSourceTable = cmdSelect.ExecuteReader()

            'display
            lstFutureFlights.Items.Clear()

            While drSourceTable.Read()

                lstFutureFlights.Items.Add(
                    drSourceTable("strFlightNumber").ToString())

            End While

            If lstFutureFlights.Items.Count = 0 Then

                lstFutureFlights.Items.Add("No Future Flights Found")

            End If

            'close
            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class