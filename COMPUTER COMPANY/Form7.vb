Imports System.Data.SqlClient

Public Class Form7
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Computer_companyDataSet)

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet.Services". При необходимости она может быть перемещена или удалена.
        Me.ServicesTableAdapter.Fill(Me.Computer_companyDataSet.Services)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet.Components". При необходимости она может быть перемещена или удалена.
        Me.ComponentsTableAdapter.Fill(Me.Computer_companyDataSet.Components)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet.Customers". При необходимости она может быть перемещена или удалена.
        Me.CustomersTableAdapter.Fill(Me.Computer_companyDataSet.Customers)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet.Orders". При необходимости она может быть перемещена или удалена.
        Me.OrdersTableAdapter.Fill(Me.Computer_companyDataSet.Orders)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form17.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabOrder.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        OrdersBindingSource.MoveFirst()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OrdersBindingSource.MoveLast()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        OrdersBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OrdersBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OrdersBindingSource.AddNew()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        OrdersBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Computer_companyDataSet)
    End Sub

    Private Sub Customer_IDTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
    End Sub
End Class