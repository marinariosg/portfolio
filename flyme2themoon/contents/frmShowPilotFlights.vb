Imports System.Data.OleDb

Public Class frmShowPilotFlights
    Dim blnFormLoad As Boolean = True
    Private Sub frmShowPilotFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strSelect As String = ""
        Dim cmdSelect As OleDbCommand
        Dim drSourceTable As OleDbDataReader
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

            ' Build the select statement
            strSelect = "SELECT intPilotID, strLastName FROM TPilots"

            ' Retrieve all records
            cmdSelect = New OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            dts.Load(drSourceTable)

            cboPilots.ValueMember = "intPilotID"
            cboPilots.DisplayMember = "strLastName"
            cboPilots.DataSource = dts

            cboPilots.SelectedIndex = -1

            ' Clean up
            drSourceTable.Close()

            ' close database connection
            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub cboPilots_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPilots.SelectedIndexChanged

        If blnFormLoad Or cboPilots.SelectedIndex = -1 Then

            blnFormLoad = False
            Exit Sub

        End If

        Dim strSelect As String = ""
        Dim cmdSelect As OleDbCommand
        Dim drSourceTable As OleDbDataReader

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

            ' Build the select statement
            strSelect = "SELECT TF.strFlightNumber, TF.dtmFlightDate, " &
                        "TF.dtmTimeOfDeparture, TF.dtmTimeOfLanding " &
                        "FROM TFlights AS TF " &
                        "JOIN TPilotFlights AS TPF " &
                        "ON TF.intFlightID = TPF.intFlightID " &
                        "WHERE TPF.intPilotID = ?"

            cmdSelect = New OleDbCommand(strSelect, m_conAdministrator)

            cmdSelect.Parameters.AddWithValue("@PilotID",
                                              cboPilots.SelectedValue)

            ' Retrieve all records
            drSourceTable = cmdSelect.ExecuteReader()

            lstPilotFlights.Items.Clear()

            lstPilotFlights.Items.Add("=============================")

            While drSourceTable.Read()

                lstPilotFlights.Items.Add("")

                lstPilotFlights.Items.Add("Flight Number: " &
                                          drSourceTable("strFlightNumber"))

                lstPilotFlights.Items.Add("Flight Date: " &
                                          drSourceTable("dtmFlightDate"))

                lstPilotFlights.Items.Add("Departure Time: " &
                                          drSourceTable("dtmTimeOfDeparture"))

                lstPilotFlights.Items.Add("Arrival Time: " &
                                          drSourceTable("dtmTimeOfLanding"))

                lstPilotFlights.Items.Add("")
                lstPilotFlights.Items.Add("=============================")

            End While

            ' Clean up
            drSourceTable.Close()

            ' close database connection
            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

End Class
