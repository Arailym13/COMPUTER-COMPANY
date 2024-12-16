Public Class Form9


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Computer_companyDataGridView)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet.Employees". При необходимости она может быть перемещена или удалена.
        Me.EmployeesTableAdapter.Fill(Me.Computer_companyDataGridView.Employees)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub





    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn2
            Case 1
                Col = DataGridViewTextBoxColumn3
            Case 2
                Col = DataGridViewTextBoxColumn4
            Case 3
                Col = DataGridViewTextBoxColumn5
            Case 4
                Col = DataGridViewTextBoxColumn6
            Case 5
                Col = DataGridViewTextBoxColumn7
            Case 6
                Col = DataGridViewTextBoxColumn8

        End Select
        If RadioButton1.Checked Then
            EmployeesDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            EmployeesDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EmployeesBindingSource.Filter = "Full_Name='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EmployeesBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        For i As Integer = 0 To EmployeesDataGridView.ColumnCount - 1
            For j As Integer = 0 To EmployeesDataGridView.RowCount - 1
                EmployeesDataGridView.Item(i, j).Style.BackColor = Color.White
                EmployeesDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i As Integer = 0 To EmployeesDataGridView.ColumnCount - 1
            For j As Integer = 0 To EmployeesDataGridView.RowCount - 1
                If EmployeesDataGridView.Item(i, j).Value IsNot Nothing AndAlso
               Not IsDBNull(EmployeesDataGridView.Item(i, j).Value) Then

                    If InStr(EmployeesDataGridView.Item(i, j).Value.ToString(), TextBox1.Text, CompareMethod.Text) > 0 Then
                        EmployeesDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                        EmployeesDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                    End If
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub FillByToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles FillByToolStrip.ItemClicked

    End Sub

    Private Sub EmployeesDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeesDataGridView.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub EmployeesBindingNavigator_RefreshItems(sender As Object, e As EventArgs)
    End Sub
End Class