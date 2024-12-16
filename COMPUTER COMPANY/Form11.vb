Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet5.Components". При необходимости она может быть перемещена или удалена.
        Me.ComponentsTableAdapter.Fill(Me.Computer_companyDataSet5.Components)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class