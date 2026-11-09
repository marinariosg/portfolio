Public Class frmShowFutureFlights
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader

        Try

            'open 
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                    "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                Me.Close()
            End If

            'build sql
            strSelect = "SELECT F.strFlightNumber, " &
            "F.dtmFlightDate, " &
            "F.dtmTimeofDeparture, " &
            "F.dtmTimeOfLanding " &
            "FROM TFlights F " &
            "INNER JOIN TFlightPassengers FP " &
            "ON F.intFlightID = FP.intFlightID " &
            "WHERE FP.intPassengerID = " & g_intPassengerID &
            "AND F.dtmFlightDate > GETDATE()"

            'execute
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            'display
            lstFutureFlights.Items.Clear()
            lstFutureFlights.Items.Add("=============================")

            While drSourceTable.Read()

                lstFutureFlights.Items.Add("")
                lstFutureFlights.Items.Add("Flight Number: " & drSourceTable("strFlightNumber"))
                lstFutureFlights.Items.Add("Flight Date: " & drSourceTable("dtmFlightDate"))
                lstFutureFlights.Items.Add("Departure Time: " & drSourceTable("dtmTimeofDeparture"))
                lstFutureFlights.Items.Add("Arrival : " & drSourceTable("dtmTimeOfLanding"))

                lstFutureFlights.Items.Add("")
                lstFutureFlights.Items.Add("=============================")
            End While

            If lstFutureFlights.Items.Count = 0 Then

                lstFutureFlights.Items.Add("No future flights exist.")

            End If

            'close
            drSourceTable.Close()


            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lstFutureFlights_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFutureFlights.SelectedIndexChanged

    End Sub

    Private Sub frmShowFutureFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
