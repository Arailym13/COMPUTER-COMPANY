Public Class Form15
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet.Positions". При необходимости она может быть перемещена или удалена.
        Me.PositionsTableAdapter.Fill(Me.Computer_companyDataSet.Positions)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class