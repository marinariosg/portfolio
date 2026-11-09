Public Class frmShowPassenger
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmShowPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader

            'open
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine & "The application will now close.", Me.Text + " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()

            End If

            'build sql
            strSelect = "SELECT TPassengers.*, TStates.* " & "FROM TPassengers JOIN TStates " & "ON TPassengers.intStateID = TStates.intStateID "

            'execute
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            'display
            lstPassengers.Items.Add("Roster of All Passengers")
            lstPassengers.Items.Add("")
            lstPassengers.Items.Add("=======================================")

            While drSourceTable.Read()

                lstPassengers.Items.Add("")

                lstPassengers.Items.Add("First Name: " & vbTab &
                                        drSourceTable("strFirstName"))

                lstPassengers.Items.Add("Last Name: " & vbTab &
                                        drSourceTable("strLastName"))

                lstPassengers.Items.Add("Address: " & vbTab &
                                        drSourceTable("strAddress"))

                lstPassengers.Items.Add("City: " & vbTab &
                                        drSourceTable("strCity"))

                lstPassengers.Items.Add("State: " & vbTab &
                                        drSourceTable("strState"))

                lstPassengers.Items.Add("Zip Code: " & vbTab &
                                        drSourceTable("strZip"))

                lstPassengers.Items.Add("Phone Number: " & vbTab &
                                        drSourceTable("strPhoneNumber"))

                lstPassengers.Items.Add("Email: " & vbTab &
                                        drSourceTable("strEmail"))

                lstPassengers.Items.Add(" ")
                lstPassengers.Items.Add("=======================================")
            End While

            'close
            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lstPassengers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPassengers.SelectedIndexChanged

    End Sub
End Class