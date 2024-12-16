Imports System.Data.SqlClient

Public Class Form19
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrWhiteSpace(Full_NameTextBox.Text) OrElse
     String.IsNullOrWhiteSpace(AddressTextBox.Text) OrElse
     String.IsNullOrWhiteSpace(PhoneTextBox.Text) Then
            MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            ' Вставка данных через TableAdapter
            Me.CustomersTableAdapter.Insert(Full_NameTextBox.Text, AddressTextBox.Text, PhoneTextBox.Text)

            ' Обновление данных в DataSet
            Me.CustomersTableAdapter.Fill(Me.Computer_companyDataSet.Customers)

            MessageBox.Show("Вы успешно зарегистрированы как клиент!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close() ' Закрыть форму
        Catch sqlEx As SqlException
            ' Обработка ошибки SQL
            MessageBox.Show("Ошибка SQL: " & sqlEx.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            ' Общая обработка ошибок
            MessageBox.Show("Ошибка: " & ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        CustomersBindingSource.AddNew()
    End Sub

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet.Customers". При необходимости она может быть перемещена или удалена.
        Me.CustomersTableAdapter.Fill(Me.Computer_companyDataSet.Customers)
        Me.CustomersTableAdapter.Fill(Me.Computer_companyDataSet.Customers)

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Computer_companyDataSet)

    End Sub

    Private Sub CustomersBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub
End Class