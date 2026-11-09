Public Class frmAddPassenger
    Private Sub frmAddPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand
        Dim drSourceTable As OleDb.OleDbDataReader
        Dim dt As DataTable = New DataTable

        Try

            If OpenDatabaseConnectionSQLServer() = False Then
                MessageBox.Show("Database connection error.")
                Me.Close()
            End If

            strSelect = "SELECT intStateID, strState FROM TStates"
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader()
            dt.Load(drSourceTable)

            cboState.ValueMember = "intStateID"
            cboState.DisplayMember = "strState"
            cboState.DataSource = dt

            drSourceTable.Close()

            CloseDatabaseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

        Dim strSelect As String = ""
        Dim strInsert As String = ""

        Dim cmdSelect As OleDb.OleDbCommand
        Dim cmdInsert As OleDb.OleDbCommand

        Dim drSourceTable As OleDb.OleDbDataReader

        Dim intNextPassengerID As Integer
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
            strSelect = "SELECT ISNULL(MAX(intPassengerID),0) + 1 AS intNextID FROM TPassengers"

            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

            drSourceTable = cmdSelect.ExecuteReader()

            drSourceTable.Read()

            intNextPassengerID = drSourceTable("intNextID")

            drSourceTable.Close()

            'build sql for insert
            strInsert = "INSERT INTO TPassengers " &
                        "(intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail) " &
                        "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"

            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            cmdInsert.Parameters.AddWithValue("@intPassengerID", intNextPassengerID)
            cmdInsert.Parameters.AddWithValue("@strFirstName", txtFirstName.Text)
            cmdInsert.Parameters.AddWithValue("@strLastName", txtLastName.Text)
            cmdInsert.Parameters.AddWithValue("@strAddress", txtAddress.Text)
            cmdInsert.Parameters.AddWithValue("@strCity", txtCity.Text)
            cmdInsert.Parameters.AddWithValue("@intStateID", cboState.SelectedValue)
            cmdInsert.Parameters.AddWithValue("@strZip", txtZip.Text)
            cmdInsert.Parameters.AddWithValue("@strPhoneNumber", txtPhoneNumber.Text)
            cmdInsert.Parameters.AddWithValue("@strEmail", txtEmail.Text)

            'execute
            intRowsAffected = cmdInsert.ExecuteNonQuery()

            'display
            If intRowsAffected > 0 Then

                MessageBox.Show("Passenger added successfully.")

            Else

                MessageBox.Show("Passenger was not added.")

            End If

            'close

            CloseDatabaseConnection()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'close form
        Close()
    End Sub
End Class