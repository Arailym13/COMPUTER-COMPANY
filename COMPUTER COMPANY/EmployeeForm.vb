Public Class EmployeeForm
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet.Employees". При необходимости она может быть перемещена или удалена.
        Me.EmployeesTableAdapter.Fill(Me.Computer_companyDataSet.Employees)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class