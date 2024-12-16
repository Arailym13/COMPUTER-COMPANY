Public Class LoginForm1



    ' TODO: вставить код для настраиваемой аутентификации с использованием переданного имени пользователя и пароля 
    ' (См. статью по адресу https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' Пользовательский принципал можно затем подключить к принципалу потока следующим образом: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' где CustomPrincipal - реализация интерфейса IPrincipal, используемая для аутентификации. 
    ' Впоследствии My.User будет возвращать идентификационную информацию, заключенную в объекте CustomPrincipal,
    ' например, имя пользователя, отображаемое имя и т.д.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim login As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        ' Проверяем логин и пароль
        If login = "admin" And password = "admin" Then

            Form1.Show()
            Me.Hide() ' Скрываем текущую форму входа
        ElseIf login = "manager" And password = "manager" Then
            managerform.Show()
            Me.Hide() ' Скрываем текущую форму входа

        Else
            ' Если логин или пароль неправильные
            MessageBox.Show("Неверный логин или пароль. Попробуйте еще раз.")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form12.Show()
    End Sub

    Private Sub PasswordTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

    End Sub
End Class
