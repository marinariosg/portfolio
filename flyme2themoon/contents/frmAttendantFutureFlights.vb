Imports System.Data.OleDb

Public Class frmAttendantFutureFlights
    Private Sub frmAttendantFutureFlightsvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            strSelect = "SELECT F.strFlightNumber, F.dtmFlightDate, F.intMilesFlown " &
                        "FROM TFlights F " &
                        "JOIN TAttendantFlights AF ON F.intFlightID = AF.intFlightID " &
                        "WHERE AF.intAttendantID = " & g_intAttendantID &
                        " AND F.dtmFlightDate > GETDATE()"
            'execute
            cmdSelect = New OleDbCommand(strSelect, m_conAdministrator)

            drSourceTable = cmdSelect.ExecuteReader()

            'display
            lstFutureFlights.Items.Clear()

            While drSourceTable.Read()

                lstFutureFlights.Items.Add(
                    drSourceTable("strFlightNumber").ToString() & "    " &
                    drSourceTable("dtmFlightDate").ToString())

            End While

            drSourceTable.Close()

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