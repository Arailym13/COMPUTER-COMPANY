Public Class LoginForm1



    ' TODO: �������� ��� ��� ������������� �������������� � �������������� ����������� ����� ������������ � ������ 
    ' (��. ������ �� ������ https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' ���������������� ��������� ����� ����� ���������� � ���������� ������ ��������� �������: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' ��� CustomPrincipal - ���������� ���������� IPrincipal, ������������ ��� ��������������. 
    ' ������������ My.User ����� ���������� ����������������� ����������, ����������� � ������� CustomPrincipal,
    ' ��������, ��� ������������, ������������ ��� � �.�.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim login As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        ' ��������� ����� � ������
        If login = "admin" And password = "admin" Then

            Form1.Show()
            Me.Hide() ' �������� ������� ����� �����
        ElseIf login = "manager" And password = "manager" Then
            managerform.Show()
            Me.Hide() ' �������� ������� ����� �����

        Else
            ' ���� ����� ��� ������ ������������
            MessageBox.Show("�������� ����� ��� ������. ���������� ��� ���.")
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
