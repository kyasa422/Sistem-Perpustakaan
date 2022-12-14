Public Class Login

    Public Shared perpus As Perpus
    Public Shared users As Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        users = New Users()
        perpus = New Perpus()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TextBoxUsername.Text
        Dim plainPassword As String = TextBoxPassword.Text

        Dim data_user As List(Of String) = users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            users.GSusername = data_user(1)
            perpus.Show()
            Me.Hide()
        Else
            MessageBox.Show("Salah Password")
        End If

        'Dim AuthStatus As Boolean = users.checkAuth(plainUsername, plainPassword)
        ''MessageBox.Show(AuthStatus)
        'If AuthStatus Then
        '    Perpus.Show()
        'End If

        'Try
        '    If AuthStatus = False Then
        '        Throw New System.Exception()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Username atau Password salah")
        'End Try
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Register.Show()
    End Sub

End Class