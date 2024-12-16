Public Class Form17
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet.Orders". При необходимости она может быть перемещена или удалена.
        Me.OrdersTableAdapter.Fill(Me.Computer_companyDataSet.Orders)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class