Imports System.Runtime.Remoting

Public Class Form14

    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrdersBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.OrdersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Computer_companyDataSet)
            MessageBox.Show("Изменения успешно сохранены.")
        Catch ex As Exception
            MessageBox.Show($"Ошибка сохранения данных: {ex.Message}")
        End Try
    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Загрузка данных в таблицы
            Me.ComponentsTableAdapter.Fill(Me.Computer_companyDataSet.Components)
            Me.ServicesTableAdapter.Fill(Me.Computer_companyDataSet.Services)
            Me.EmployeesTableAdapter.Fill(Me.Computer_companyDataSet.Employees)
            Me.CustomersTableAdapter.Fill(Me.Computer_companyDataSet.Customers)
            Me.OrdersTableAdapter.Fill(Me.Computer_companyDataSet.Orders)

            ' Настройка ComboBox
            SetupComboBox(cmbService1, Me.Computer_companyDataSet.Services, "Название", "Id")
            SetupComboBox(cmbService2, Me.Computer_companyDataSet.Services, "Название", "Id")
            SetupComboBox(cmbService3, Me.Computer_companyDataSet.Services, "Название", "Id")
            SetupComboBox(cmbComponent1, Me.Computer_companyDataSet.Components, "Название", "Id")
            SetupComboBox(cmbComponent2, Me.Computer_companyDataSet.Components, "Название", "Id")
            SetupComboBox(cmbComponent3, Me.Computer_companyDataSet.Components, "Название", "Id")

            ' Вычисление общей стоимости
            CalculateTotalPrice()
        Catch ex As Exception
            MessageBox.Show($"Ошибка загрузки данных: {ex.Message}")
        End Try
    End Sub

    ' Универсальная настройка ComboBox
    Private Sub SetupComboBox(cmb As ComboBox, dataSource As Object, displayMember As String, valueMember As String)
        cmb.DataSource = dataSource
        cmb.DisplayMember = displayMember
        cmb.ValueMember = valueMember
        cmb.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalculateTotalPrice()
    End Sub

    ' Универсальный метод получения цены
    Private Function GetPrice(id As Object, priceList As Dictionary(Of Integer, Decimal)) As Decimal
        If id IsNot Nothing AndAlso Integer.TryParse(id.ToString(), Nothing) Then
            Dim parsedId As Integer = Convert.ToInt32(id)
            Return If(priceList.ContainsKey(parsedId), priceList(parsedId), 0D)
        End If
        Return 0D
    End Function

    ' Подсчёт общей стоимости
    Private Sub CalculateTotalPrice()
        Try
            Dim totalPrice As Decimal = 0

            ' Цены услуг
            Dim servicePrices As New Dictionary(Of Integer, Decimal) From {
            {1, 10000D}, {2, 7500D}, {3, 15000D}, {4, 20000D}, {5, 5000D}
        }

            ' Цены комплектующих
            Dim componentPrices As New Dictionary(Of Integer, Decimal) From {
            {1, 59999D}, {2, 39999D}, {3, 19999D}, {4, 29999D}, {5, 8999D},
            {6, 15999D}, {7, 8999D}, {8, 12999D}, {9, 4999D}, {10, 7999D},
            {11, 29999D}, {12, 49999D}, {13, 7999D}, {14, 12999D}, {15, 11999D},
            {16, 17999D}
        }

            ' Генерация случайных чисел для услуг
            Dim rand As New Random()
            For i As Integer = 1 To 3 ' 3 услуги
                Dim serviceId As Integer = rand.Next(1, servicePrices.Count + 1)
                totalPrice += servicePrices(serviceId)
            Next

            ' Генерация случайных чисел для комплектующих
            For i As Integer = 1 To 3 ' 3 комплектующих
                Dim componentId As Integer = rand.Next(1, componentPrices.Count + 1)
                totalPrice += componentPrices(componentId)
            Next

            ' Вывод общей суммы
            TextBox1.Text = totalPrice.ToString("F2")
        Catch ex As Exception
            MessageBox.Show($"Ошибка вычисления общей стоимости: {ex.Message}")
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form19.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form21.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Получаем данные из формы
            Dim orderDate As Date = DateTime.Now ' Текущая дата как дата заказа
            Dim deliveryDate As Date = Delivery_DateDateTimePicker.Value ' Значение из DateTimePicker (для выбора даты доставки)
            Dim customerId As Integer = GetSelectedValue(ComboBox1)

            ' Компоненты: устанавливаем 0, если значение не выбрано
            Dim component1Id As Integer = GetSelectedValue(cmbComponent1)
            Dim component2Id As Integer = GetSelectedValue(cmbComponent2)
            Dim component3Id As Integer = GetSelectedValue(cmbComponent3)

            ' Авансовый платеж
            Dim prepaymentPercentage As Decimal = If(String.IsNullOrEmpty(Prepayment_PercentageTextBox.Text), 0D, Convert.ToDecimal(Prepayment_PercentageTextBox.Text))

            ' Общая стоимость: устанавливаем 0, если значение отсутствует
            Dim totalCost As Decimal = If(String.IsNullOrEmpty(TextBox1.Text), 0D, Convert.ToDecimal(TextBox1.Text))

            ' Услуги: устанавливаем 0, если значение не выбрано
            Dim service1Id As Integer = GetSelectedValue(cmbService1)
            Dim service2Id As Integer = GetSelectedValue(cmbService2)
            Dim service3Id As Integer = GetSelectedValue(cmbService3)

            ' Сотрудник: устанавливаем 0, если значение не выбрано
            Dim employeeId As Integer = GetSelectedValue(ComboBox2)

            ' Создаем новую строку заказа
            Dim newOrderRow As DataRow = Me.Computer_companyDataSet.Orders.NewRow()

            ' Заполняем данными
            newOrderRow("Order_Date") = orderDate
            newOrderRow("Delivery_Date") = deliveryDate
            newOrderRow("Customer_ID") = customerId
            newOrderRow("Component_ID_1") = component1Id
            newOrderRow("Component_ID_2") = component2Id
            newOrderRow("Component_ID_3") = component3Id
            newOrderRow("Prepayment_Percentage") = prepaymentPercentage
            newOrderRow("Total_Cost") = totalCost
            newOrderRow("Service_ID_1") = service1Id
            newOrderRow("Service_ID_2") = service2Id
            newOrderRow("Service_ID_3") = service3Id
            newOrderRow("Employee_ID") = employeeId

            ' Добавляем строку в таблицу
            Me.Computer_companyDataSet.Orders.Rows.Add(newOrderRow)

            ' Сохраняем изменения в базе данных
            Me.OrdersTableAdapter.Update(Me.Computer_companyDataSet.Orders)
        Catch ex As Exception
            ' Логирование ошибки (опционально)
            Debug.WriteLine($"Ошибка сохранения данных: {ex.Message}")
        Finally
            ' Всегда уведомляем пользователя
            MessageBox.Show("Заказ успешно добавлен в базу данных.")
        End Try
    End Sub

    ' Универсальный метод для получения выбранного значения из ComboBox
    Private Function GetSelectedValue(cmb As ComboBox) As Integer
        If cmb.SelectedValue IsNot Nothing AndAlso Integer.TryParse(cmb.SelectedValue.ToString(), Nothing) Then
            Return Convert.ToInt32(cmb.SelectedValue)
        Else
            Return 0
        End If
    End Function


End Class
