Imports System.Data.OleDb

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim strSQL As String
        Dim cmd As OleDbCommand
        Dim dr As OleDbDataReader

        Try
            'open
            If OpenDatabaseConnectionSQLServer() = False Then

                MessageBox.Show("Database connection error.")
                Exit Sub
            End If

            'build sql
            strSQL = "SELECT strRole, intUserID FROM TUserLogins " & "WHERE strUserName = ? AND strPassword = ?"

            'execute
            cmd = New OleDbCommand(strSQL, m_conAdministrator)
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)

            dr = cmd.ExecuteReader()

            'display
            If dr.Read() Then
                Dim strRole As String
                Dim intID As Integer

                strRole = dr("strRole").ToString()
                intID = CInt(dr("intUserID"))
                If strRole = "Customer" Then

                    g_intPassengerID = intID

                    Dim frm As New frmCustomerMain
                    frm.Show()
                    Me.Hide()

                ElseIf strRole = "Pilot" Then

                    g_intPilotID = intID

                    Dim frm As New frmPilotMain
                    frm.Show()
                    Me.Hide()

                ElseIf strRole = "Attendant" Then

                    g_intAttendantID = intID

                    Dim frm As New frmAttendantMain
                    frm.Show()
                    Me.Hide()

                ElseIf strRole = "Admin" Then

                    MessageBox.Show("The Admin workflow will be completed in a later enhancement.")

                End If



            Else
                MessageBox.Show("Invalid username or password.")

            End If
            'close
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenDatabaseConnectionSQLServer()
    End Sub
End Class