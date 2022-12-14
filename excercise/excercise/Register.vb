Public Class Register

    Private Sub BtnRegist_Click(sender As Object, e As EventArgs) Handles BtnRegist.Click
        If TextBoxNewUsername.Text.Length > 0 And TextBoxNewPassword.Text.Length > 0 Then
            MessageBox.Show("Akun ditambahkan")
            Login.users.AddUserDatabase(TextBoxNewUsername.Text, TextBoxNewPassword.Text)
            Me.Close()
        Else
            MessageBox.Show("Lengkapi data")
        End If

        'Dim username As String = TextBoxNewUsername.Text
        'Dim password As String = TextBoxNewPassword.Text
        ''Login.users.add_user(username, password)

        Login.Show()

    End Sub
End Class