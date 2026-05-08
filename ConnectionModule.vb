Imports MySql.Data.MySqlClient
Imports MySqlConnector

Public Module ConnectionModule

    Private ReadOnly connString As String = "server=localhost;user id=root;password=;database=dbml;"

    Private _conn As MySqlConnection = Nothing

    Public Function GetConnection() As MySqlConnection
        If _conn Is Nothing Then
            _conn = New MySqlConnection(connString)
        End If
        Return _conn
    End Function

    Public Sub OpenConnection()
        Dim conn = GetConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        Dim conn = GetConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Public Function CreateCommand(query As String) As MySqlCommand
        Return New MySqlCommand(query, GetConnection())
    End Function

End Module