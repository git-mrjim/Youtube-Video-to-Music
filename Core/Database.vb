Imports MySql.Data.MySqlClient

' This codes is responsible for interacting in the database to create user, load user and 
' checked if the user is exist in the database

Public Class Database

    Public Shared connection As MySqlConnection

    ' The Connect function is for connecting to database with a connection string
    ' it's require to connect first before call the other functions
    Public Shared Sub Connect()
        Dim connectionString As String = "server=localhost;user=root;password=Jimz_shy_04444;database=ytvtm"
        connection = New MySqlConnection(connectionString)
    End Sub

    ' The AddUser function is quearing to the database to add a new user in the table 
    ' this is used to the SignupForm to add the data entered in the textboxes 
    Public Shared Function AddUser(username As String, password As String, isMale As Boolean) As Boolean
        Dim query As String = "INSERT INTO users (username, password, isMale) VALUES (@username, @password, @isMale)"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)
        command.Parameters.AddWithValue("@isMale", isMale)

        Try

            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()

            Return True

        Catch ex As Exception

            Return False

        End Try

    End Function

    ' The LoadUser function is responsible for check the data provided in parameter if exist in the database 
    ' and then load the user data
    Public Shared Function LoadUser(username As String, password As String) As Dictionary(Of String, Object)
        Dim userData As Dictionary(Of String, Object)

        Dim query As String = "SELECT username, isMale FROM users WHERE username = @username AND password = @password"
        Dim command As New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)

        connection.Open()
        Dim reader As MySqlDataReader = command.ExecuteReader()

        If reader.Read() Then

            userData = New Dictionary(Of String, Object)
            userData.Add("username", reader.GetString("username"))
            userData.Add("isMale", reader.GetBoolean("isMale"))
            reader.Close()
            connection.Close()

            Return userData

        Else

            userData = New Dictionary(Of String, Object)
            userData.Add("username", "")
            reader.Close()
            connection.Close()

            Return userData

        End If

    End Function

End Class
