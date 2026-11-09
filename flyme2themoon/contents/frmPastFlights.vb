Imports System.Data.OleDb
Public Class frmPastFlights
    Private Sub frmPastFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader

        Try
            'open
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show("Database connection error.")
                Me.Close()

            End If
            'build sql
            strSelect = "SELECT F.strFlightNumber, F.dtmFlightDate, F.intMilesFlown " &
                        "FROM TFlights F " &
                        "JOIN TFlightPassengers FP ON F.intFlightID = FP.intFlightID " &
                         "WHERE FP.intPassengerID = " & g_intPassengerID &
                         "AND F.dtmFlightDate < GETDATE()"

            'execute
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

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
            'build sql
            strSelect = "SELECT SUM(F.intMilesFlown) AS TotalMiles " &
                        "FROM TFlights F " &
                        "JOIN TFlightPassengers FP ON F.intFlightID = FP.intFlightID " &
                           "WHERE FP.intPassengerID = " & g_intPassengerID &
                           "AND F.dtmFlightDate < GETDATE()"
            'execute
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

            Dim objMiles As Object

            objMiles = cmdSelect.ExecuteScalar()
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