Option Explicit On
Imports System.Data.OleDb

Public Module modDatabaseUtilities

    Public m_conAdministrator As OleDbConnection

    Private m_strDatabaseConnectionStringSQLServer As String =
     "Provider=SQLOLEDB;" &
    "Server=MARINA-DELL\SQLEXPRESS;" &
    "Database=dbFlyMe2theMoon;" &
    "Integrated Security=SSPI;"

    ' FUNCTION - OpenDatabaseConnectionSQLServer
    Public Function OpenDatabaseConnectionSQLServer() As Boolean

        Dim blnResult As Boolean
        blnResult = False

        Try
            m_conAdministrator = New OleDbConnection(m_strDatabaseConnectionStringSQLServer)
            m_conAdministrator.Open()
            blnResult = True

        Catch excError As Exception
            MessageBox.Show(excError.Message)

        End Try

        Return blnResult

    End Function

    ' FUNCTION - CloseDatabaseConnection
    Public Function CloseDatabaseConnection() As Boolean

        Dim blnResult As Boolean
        blnResult = False

        Try

            If m_conAdministrator IsNot Nothing Then

                If m_conAdministrator.State <> ConnectionState.Closed Then
                    m_conAdministrator.Close()
                End If

                m_conAdministrator.Dispose()
                m_conAdministrator = Nothing

            End If

            blnResult = True

        Catch excError As Exception

            MessageBox.Show(excError.Message)

        End Try

        Return blnResult

    End Function


End Module
