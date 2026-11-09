Imports System.Data.OleDb

Public Class frmShowAttendantFlights

    Dim blnFormLoad As Boolean = True

          Private Sub frmShowAttendantFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim strSelect As String = ""
        Dim cmdSelect As OleDbCommand
        Dim drSourceTable As OleDbDataReader
        Dim dts As New DataTable

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


            strSelect = "SELECT intAttendantID, strLastName FROM TAttendants"

            ' execute
            cmdSelect = New OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()

            dts.Load(drSourceTable)

            ' display
            cboAttendants.ValueMember = "intAttendantID"
            cboAttendants.DisplayMember = "strLastName"
            cboAttendants.DataSource = dts

            cboAttendants.SelectedIndex = -1

            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub cboAttendants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAttendants.SelectedIndexChanged

        If blnFormLoad Or cboAttendants.SelectedIndex = -1 Then

            blnFormLoad = False
            Exit Sub

        End If

        Dim strSelect As String = ""
        Dim cmdSelect As OleDbCommand
        Dim drSourceTable As OleDbDataReader

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


            strSelect = "SELECT TF.strFlightNumber, TF.dtmFlightDate, " &
                        "TF.dtmTimeOfDeparture, TF.dtmTimeOfLanding " &
                        "FROM TFlights AS TF " &
                        "JOIN TAttendantFlights AS TAF " &
                        "ON TF.intFlightID = TAF.intFlightID " &
                        "WHERE TAF.intAttendantID = ?"

            cmdSelect = New OleDbCommand(strSelect, m_conAdministrator)

            cmdSelect.Parameters.AddWithValue("@AttendantID",
                                              cboAttendants.SelectedValue)

            ' execute
            drSourceTable = cmdSelect.ExecuteReader()

            lstAttendantFlights.Items.Clear()

            lstAttendantFlights.Items.Add("=============================")

            'display attendants information
            While drSourceTable.Read()

                lstAttendantFlights.Items.Add("")

                lstAttendantFlights.Items.Add("Flight Number: " &
                                              drSourceTable("strFlightNumber"))

                lstAttendantFlights.Items.Add("Flight Date: " &
                                              drSourceTable("dtmFlightDate"))

                lstAttendantFlights.Items.Add("Departure Time: " &
                                              drSourceTable("dtmTimeOfDeparture"))

                lstAttendantFlights.Items.Add("Arrival Time: " &
                                              drSourceTable("dtmTimeOfLanding"))

                lstAttendantFlights.Items.Add("")
                lstAttendantFlights.Items.Add("=============================")

            End While

            'close
            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub
End Class