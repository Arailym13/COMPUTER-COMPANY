Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet.Services". При необходимости она может быть перемещена или удалена.
        Me.ServicesTableAdapter.Fill(Me.Computer_companyDataSet.Services)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer2.RefreshReport
    End Sub
End Class