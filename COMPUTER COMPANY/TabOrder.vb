Public Class TabOrder
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TabOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "Computer_companyDataSet.Orders". При необходимости она может быть перемещена или удалена.
        Me.OrdersTableAdapter.Fill(Me.Computer_companyDataSet.Orders)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = OrderDateDataGridViewTextBoxColumn
            Case 1
                Col = DeliveryDateDataGridViewTextBoxColumn
            Case 2
                Col = CustomerIDDataGridViewTextBoxColumn
            Case 3
                Col = ComponentID1DataGridViewTextBoxColumn
            Case 4
                Col = ComponentID2DataGridViewTextBoxColumn
            Case 5
                Col = ComponentID3DataGridViewTextBoxColumn
            Case 6
                Col = PrepaymentPercentageDataGridViewTextBoxColumn
            Case 7
                Col = PaymentStatusDataGridViewCheckBoxColumn
            Case 8
                Col = FulfillmentStatusDataGridViewCheckBoxColumn
            Case 9
                Col = TotalCostDataGridViewTextBoxColumn
            Case 10
                Col = OverallWarrantyPeriodDataGridViewTextBoxColumn
            Case 11
                Col = ServiceID1DataGridViewTextBoxColumn
            Case 12
                Col = ServiceID2DataGridViewTextBoxColumn
            Case 13
                Col = ServiceID3DataGridViewTextBoxColumn
            Case 13
                Col = EmployeeIDDataGridViewTextBoxColumn

        End Select
        If RadioButton1.Checked Then
            DataGridView1.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            DataGridView1.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OrdersBindingSource.Filter = "Full_Name='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OrdersBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            For j As Integer = 0 To DataGridView1.RowCount - 1
                DataGridView1.Item(i, j).Style.BackColor = Color.White
                DataGridView1.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i As Integer = 0 To DataGridView1.ColumnCount - 1
            For j As Integer = 0 To DataGridView1.RowCount - 1
                If DataGridView1.Item(i, j).Value IsNot Nothing AndAlso
Not IsDBNull(DataGridView1.Item(i, j).Value) Then

                    If InStr(DataGridView1.Item(i, j).Value.ToString(), TextBox1.Text, CompareMethod.Text) > 0 Then
                        DataGridView1.Item(i, j).Style.BackColor = Color.AliceBlue
                        DataGridView1.Item(i, j).Style.ForeColor = Color.Blue
                    End If
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class