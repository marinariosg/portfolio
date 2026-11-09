Public Class frmUpdatePassenger
    Private Sub frmUpdatePassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim dtStates As New DataTable

        Try

            'open
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me, "Database connection error." & vbNewLine & "The application will now close.", Me.Text + " Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If

            'build sql
            strSelect = "SELECT intStateID, strState FROM TStates"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

            drSourceTable = cmdSelect.ExecuteReader()

            dtStates.Load(drSourceTable)

            'display
            cboState.ValueMember = "intStateID"
            cboState.DisplayMember = "strState"
            cboState.DataSource = dtStates

            drSourceTable.Close()

            'build sql
            strSelect = "SELECT * FROM TPassengers " &
                "WHERE intPassengerID = " & g_intPassengerID

            'execute
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

            drSourceTable = cmdSelect.ExecuteReader()

            If drSourceTable.Read() Then

                txtFirstName.Text = drSourceTable("strFirstName").ToString()
                txtLastName.Text = drSourceTable("strLastName").ToString()
                txtAddress.Text = drSourceTable("strAddress").ToString()
                txtCity.Text = drSourceTable("strCity").ToString()

                'display
                cboState.SelectedValue = drSourceTable("intStateID")

                txtZip.Text = drSourceTable("strZip").ToString()
                txtPhoneNumber.Text = drSourceTable("strPhoneNumber").ToString()
                txtEmail.Text = drSourceTable("strEmail").ToString()

            End If
            drSourceTable.Close()
            CloseDatabaseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Close 
        Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strUpdate As String = ""
        Dim cmdUpdate As OleDb.OleDbCommand
        Dim intRowsAffected As Integer

        Try

            'open
            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show(Me,
                           "Database connection error." & vbNewLine &
                           "The application will now close.",
                           Me.Text + " Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Error)

                Me.Close()
            End If

            'validate
            If txtFirstName.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter a first name.")
                txtFirstName.Focus()
                Exit Sub
            End If

            If txtLastName.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter a last name.")
                txtLastName.Focus()
                Exit Sub
            End If

            If txtAddress.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter an address.")
                txtAddress.Focus()
                Exit Sub
            End If

            If txtCity.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter a city.")
                txtCity.Focus()
                Exit Sub
            End If

            If txtZip.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter a zip code.")
                txtZip.Focus()
                Exit Sub
            End If

            If txtPhoneNumber.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter a phone number.")
                txtPhoneNumber.Focus()
                Exit Sub
            End If
            If txtEmail.Text.Trim() = String.Empty Then
                MessageBox.Show("Please enter an email.")
                txtEmail.Focus()
                Exit Sub
            End If

            If InStr(txtEmail.Text, "@") = 0 Then
                MessageBox.Show("Please enter a valid email.")
                txtEmail.Focus()
                Exit Sub
            End If

            'build sql
            strUpdate = "UPDATE TPassengers " &
                    "SET strFirstName = ?, " &
                    "strLastName = ?, " &
                    "strAddress = ?, " &
                    "strCity = ?, " &
                    "intStateID = ?, " &
                    "strZip = ?, " &
                    "strPhoneNumber = ?, " &
                    "strEmail = ? " &
                    "WHERE intPassengerID = ?"

            cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)

            cmdUpdate.Parameters.AddWithValue("@strFirstName", txtFirstName.Text)
            cmdUpdate.Parameters.AddWithValue("@strLastName", txtLastName.Text)
            cmdUpdate.Parameters.AddWithValue("@strAddress", txtAddress.Text)
            cmdUpdate.Parameters.AddWithValue("@strCity", txtCity.Text)
            cmdUpdate.Parameters.AddWithValue("@intStateID", cboState.SelectedValue)
            cmdUpdate.Parameters.AddWithValue("@strZip", txtZip.Text)
            cmdUpdate.Parameters.AddWithValue("@strPhoneNumber", txtPhoneNumber.Text)
            cmdUpdate.Parameters.AddWithValue("@strEmail", txtEmail.Text)
            cmdUpdate.Parameters.AddWithValue("@intPassengerID", g_intPassengerID)

            'execute
            intRowsAffected = cmdUpdate.ExecuteNonQuery()

            'display
            If intRowsAffected > 0 Then
                MessageBox.Show("Passenger updated successfully.")
                Close()

            Else
                MessageBox.Show("Passenger was not updated.")
            End If

            'close
            CloseDatabaseConnection()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class