Public Class frmShowPassengerFlights
    Dim blnFormLoad As Boolean = True
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmShowPassengerFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim dts As DataTable = New DataTable

        Try

            ' open database
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show(Me,
                            "Database connection error." & vbNewLine &
                            "The application will now close.",
                            Me.Text + " Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

                Me.Close()

            End If

            strSelect = "SELECT intPassengerID, " &
                    "strFirstName + ' ' + strLastName AS PassengerName " &
                    "FROM TPassengers"
            'execute
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

            drSourceTable = cmdSelect.ExecuteReader()

            dts.Load(drSourceTable)

            'display
            cboPassengers.ValueMember = "intPassengerID"
            cboPassengers.DisplayMember = "PassengerName"
            cboPassengers.DataSource = dts

            cboPassengers.SelectedIndex = -1

            drSourceTable.Close()

            CloseDatabaseConnection()



        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub cboPassengers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPassengers.SelectedIndexChanged
        If blnFormLoad Or cboPassengers.SelectedIndex = -1 Then

            blnFormLoad = False
            Exit Sub

        End If

        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader

        Try

            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show(Me,
                                "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)

                Me.Close()

            End If

            strSelect = "SELECT TF.strFlightNumber, " &
                        "TF.dtmFlightDate, " &
                        "TF.dtmTimeofDeparture, " &
                        "TF.dtmTimeOfLanding " &
                        "FROM TFlights TF " &
                        "JOIN TFlightPassengers TFP " &
                        "ON TF.intFlightID = TFP.intFlightID " &
                        "WHERE TFP.intPassengerID = ?"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

            cmdSelect.Parameters.AddWithValue("@PassengerID",
                                              cboPassengers.SelectedValue)

            drSourceTable = cmdSelect.ExecuteReader()

            lstPassengerFlights.Items.Clear()

            'display flight information
            While drSourceTable.Read()

                lstPassengerFlights.Items.Add("")

                lstPassengerFlights.Items.Add("Flight Number: " &
                                              drSourceTable("strFlightNumber"))

                lstPassengerFlights.Items.Add("Flight Date: " &
                                              drSourceTable("dtmFlightDate"))

                lstPassengerFlights.Items.Add("Departure Time: " &
                                              drSourceTable("dtmTimeofDeparture"))

                lstPassengerFlights.Items.Add("Arrival Time: " &
                                              drSourceTable("dtmTimeOfLanding"))

                lstPassengerFlights.Items.Add("")
                lstPassengerFlights.Items.Add("===================")

            End While

            'close
            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub lstPassengerFlights_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPassengerFlights.SelectedIndexChanged

    End Sub
End Class