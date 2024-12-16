Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet3.Customers". При необходимости она может быть перемещена или удалена.
        Me.CustomersTableAdapter.Fill(Me.Computer_companyDataSet3.Customers)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class