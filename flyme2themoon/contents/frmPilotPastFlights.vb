Imports System.Data.OleDb
Public Class frmPilotPastFlights
    Private Sub frmPilotPastFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelect As OleDbCommand
        Dim drSourceTable As OleDbDataReader
        Dim cmdMiles As OleDbCommand
        Dim objMiles As Object

        Try

            'open
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show("Database connection error.")
                Me.Close()

            End If

            'execute
            cmdSelect = New OleDbCommand("SelectPilotPastFlights", m_conAdministrator)

            cmdSelect.CommandType = CommandType.StoredProcedure

            cmdSelect.Parameters.AddWithValue("@PilotID", g_intPilotID)

            drSourceTable = cmdSelect.ExecuteReader()

            'display
            lstPastFlights.Items.Clear()

            While drSourceTable.Read()

                lstPastFlights.Items.Add(
                    drSourceTable("strFlightNumber").ToString() & "    " &
                    drSourceTable("dtmFlightDate").ToString() & "    " &
                    drSourceTable("intMilesFlown").ToString() & " miles")

            End While

            drSourceTable.Close()

            'execute
            cmdMiles = New OleDbCommand("SelectPilotPastMilesTotal", m_conAdministrator)

            cmdMiles.CommandType = CommandType.StoredProcedure

            cmdMiles.Parameters.AddWithValue("@PilotID", g_intPilotID)

            objMiles = cmdMiles.ExecuteScalar()

            'display
            If IsDBNull(objMiles) Then

                lblTotalMiles.Text = "Total Miles: 0"

            Else
                lblTotalMiles.Text = "Total Miles: " & objMiles.ToString()
            End If

            'close
            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class