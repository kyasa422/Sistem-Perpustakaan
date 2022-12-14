Imports System.Data.SqlClient
Imports System.Media
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Users
    'Private username As String
    'Private password As String
    Private new_user As New ArrayList()
    'Private TripleDes As New TripleDESCryptoServiceProvider '


    '-------- login database ---------
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan_visual"


    Public Property GSusername() As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property GSPassword() As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    'Public Function EncrypData(ByVal plaintext As String) As String
    '    'convert the plaintext string to a byte array
    '    Dim PlainTextByte() As Byte =
    '        System.Text.Encoding.Unicode.GetBytes(plaintext)

    '    'create the stream
    '    Dim ms As New System.IO.MemoryStream
    '    'create the encoder to write to the stream
    '    Dim encStream As New CryptoStream(ms.TripleDES.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

    '    'use the crypto stream to write the byte array to the stream 
    '    encStream.Write(PlainTextByte, 0, PlainTextByte.Length)
    '    encStream.FlushFinalBlock()

    '    'convert the encrypted stream to a printable string
    '    Return Convert.ToBase64String(ms.ToArray)
    'End Function

    Public Function checkAuth(username As String, Password As String) As Boolean

        For Each result In new_user
            Dim plainUsername = String.Compare(username, result(0))
            Dim plainPassword = String.Compare(Password, result(1))

            If plainUsername = 0 Then
                If plainPassword = 0 Then
                    Return True
                End If
            End If
        Next


        'static password
        'Dim realPassword As String = EncrypData("1234")
        'Dim realUsername As String = "Fazril"

        'If String.Compare(username, realUsername) = 0 And String.Compare(EncrypData(plainPasword), realPassword) = 0 Then
        '    Return True

        'Else
        '    Return False
        'End If
    End Function

    Public Function add_user(username As String, password As String)
        new_user.Add({username, password})
    End Function



    '------------ user database ------------

    Public Function EncrpytMD5(ByVal password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function


    Public Function AddUserDatabase(username_regist As String, password_regist As String)
        Try
            Dim today = Date.Now()

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO users VALUES('', '" _
                & username_regist & "', '" _
                & EncrpytMD5(password_regist) & "', '" _
                & today.ToString("yyyy/MM/dd") & "')"

            'Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function


    Public Function CheckAuthDatabase(username_login As String, password_login As String) As List(Of String)
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
            + "password=" + password + ";" + "database =" + database

            dbConn.Open()

            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT id_user, username FROM users WHERE 
                            username='" & username_login & "'AND password= '" & EncrpytMD5(password_login) & "'"

            sqlCommand.CommandText = queryAuth
            Debug.WriteLine(queryAuth)
            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
            Return result
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function


End Class
