<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabOrder
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Computer_companyDataSet = New COMPUTER_COMPANY.Computer_companyDataSet()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.OrdersTableAdapter()
        Me.OrderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComponentID1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComponentID2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComponentID3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrepaymentPercentageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FulfillmentStatusDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TotalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverallWarrantyPeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceID1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceID2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceID3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(343, 602)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(316, 22)
        Me.TextBox1.TabIndex = 37
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrderDateDataGridViewTextBoxColumn, Me.DeliveryDateDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.ComponentID1DataGridViewTextBoxColumn, Me.ComponentID2DataGridViewTextBoxColumn, Me.ComponentID3DataGridViewTextBoxColumn, Me.PrepaymentPercentageDataGridViewTextBoxColumn, Me.PaymentStatusDataGridViewCheckBoxColumn, Me.FulfillmentStatusDataGridViewCheckBoxColumn, Me.TotalCostDataGridViewTextBoxColumn, Me.OverallWarrantyPeriodDataGridViewTextBoxColumn, Me.ServiceID1DataGridViewTextBoxColumn, Me.ServiceID2DataGridViewTextBoxColumn, Me.ServiceID3DataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrdersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(52, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(673, 348)
        Me.DataGridView1.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox1.Location = New System.Drawing.Point(731, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(390, 508)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сортировка "
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(24, 372)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(266, 29)
        Me.RadioButton2.TabIndex = 16
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Сортировка по убыванию"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 22
        Me.ListBox1.Items.AddRange(New Object() {"Дата заказа", "Дата исполнения", "Код заказчика", "Код комплектующего 1", "Код комплектующего 2", "Код комплектующего 3", "Доля предоплаты", "Отметка об оплате", "Отметка об исполнении", "Общая стоимость", "Срок общей гарантии", "Код услуги 1", "Код услуги 2", "Код услуги 3", "Код сотрудника"})
        Me.ListBox1.Location = New System.Drawing.Point(22, 63)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(341, 246)
        Me.ListBox1.TabIndex = 14
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(24, 337)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(297, 29)
        Me.RadioButton1.TabIndex = 15
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Сортировка по возрастанию"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(94, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 51)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Сортировать "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Поле для сортировки"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.OrdersBindingSource1
        Me.ComboBox1.DisplayMember = "Order_Date"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(343, 547)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(316, 24)
        Me.ComboBox1.TabIndex = 34
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.Location = New System.Drawing.Point(939, 613)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 51)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Закрыть"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(252, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 29)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Таблица Заказы"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(753, 613)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 51)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Найти"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(941, 556)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 51)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Показать все"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(755, 556)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 51)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Фильтровать"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(235, 591)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 22)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Критерии"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(223, 545)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 22)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Дата заказа"
        '
        'Computer_companyDataSet
        '
        Me.Computer_companyDataSet.DataSetName = "Computer_companyDataSet"
        Me.Computer_companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.Computer_companyDataSet
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'OrderDateDataGridViewTextBoxColumn
        '
        Me.OrderDateDataGridViewTextBoxColumn.DataPropertyName = "Order_Date"
        Me.OrderDateDataGridViewTextBoxColumn.HeaderText = "Order_Date"
        Me.OrderDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OrderDateDataGridViewTextBoxColumn.Name = "OrderDateDataGridViewTextBoxColumn"
        Me.OrderDateDataGridViewTextBoxColumn.Width = 125
        '
        'DeliveryDateDataGridViewTextBoxColumn
        '
        Me.DeliveryDateDataGridViewTextBoxColumn.DataPropertyName = "Delivery_Date"
        Me.DeliveryDateDataGridViewTextBoxColumn.HeaderText = "Delivery_Date"
        Me.DeliveryDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DeliveryDateDataGridViewTextBoxColumn.Name = "DeliveryDateDataGridViewTextBoxColumn"
        Me.DeliveryDateDataGridViewTextBoxColumn.Width = 125
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID"
        Me.CustomerIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        Me.CustomerIDDataGridViewTextBoxColumn.Width = 125
        '
        'ComponentID1DataGridViewTextBoxColumn
        '
        Me.ComponentID1DataGridViewTextBoxColumn.DataPropertyName = "Component_ID_1"
        Me.ComponentID1DataGridViewTextBoxColumn.HeaderText = "Component_ID_1"
        Me.ComponentID1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ComponentID1DataGridViewTextBoxColumn.Name = "ComponentID1DataGridViewTextBoxColumn"
        Me.ComponentID1DataGridViewTextBoxColumn.Width = 125
        '
        'ComponentID2DataGridViewTextBoxColumn
        '
        Me.ComponentID2DataGridViewTextBoxColumn.DataPropertyName = "Component_ID_2"
        Me.ComponentID2DataGridViewTextBoxColumn.HeaderText = "Component_ID_2"
        Me.ComponentID2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ComponentID2DataGridViewTextBoxColumn.Name = "ComponentID2DataGridViewTextBoxColumn"
        Me.ComponentID2DataGridViewTextBoxColumn.Width = 125
        '
        'ComponentID3DataGridViewTextBoxColumn
        '
        Me.ComponentID3DataGridViewTextBoxColumn.DataPropertyName = "Component_ID_3"
        Me.ComponentID3DataGridViewTextBoxColumn.HeaderText = "Component_ID_3"
        Me.ComponentID3DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ComponentID3DataGridViewTextBoxColumn.Name = "ComponentID3DataGridViewTextBoxColumn"
        Me.ComponentID3DataGridViewTextBoxColumn.Width = 125
        '
        'PrepaymentPercentageDataGridViewTextBoxColumn
        '
        Me.PrepaymentPercentageDataGridViewTextBoxColumn.DataPropertyName = "Prepayment_Percentage"
        Me.PrepaymentPercentageDataGridViewTextBoxColumn.HeaderText = "Prepayment_Percentage"
        Me.PrepaymentPercentageDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PrepaymentPercentageDataGridViewTextBoxColumn.Name = "PrepaymentPercentageDataGridViewTextBoxColumn"
        Me.PrepaymentPercentageDataGridViewTextBoxColumn.Width = 125
        '
        'PaymentStatusDataGridViewCheckBoxColumn
        '
        Me.PaymentStatusDataGridViewCheckBoxColumn.DataPropertyName = "Payment_Status"
        Me.PaymentStatusDataGridViewCheckBoxColumn.HeaderText = "Payment_Status"
        Me.PaymentStatusDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.PaymentStatusDataGridViewCheckBoxColumn.Name = "PaymentStatusDataGridViewCheckBoxColumn"
        Me.PaymentStatusDataGridViewCheckBoxColumn.Width = 125
        '
        'FulfillmentStatusDataGridViewCheckBoxColumn
        '
        Me.FulfillmentStatusDataGridViewCheckBoxColumn.DataPropertyName = "Fulfillment_Status"
        Me.FulfillmentStatusDataGridViewCheckBoxColumn.HeaderText = "Fulfillment_Status"
        Me.FulfillmentStatusDataGridViewCheckBoxColumn.MinimumWidth = 6
        Me.FulfillmentStatusDataGridViewCheckBoxColumn.Name = "FulfillmentStatusDataGridViewCheckBoxColumn"
        Me.FulfillmentStatusDataGridViewCheckBoxColumn.Width = 125
        '
        'TotalCostDataGridViewTextBoxColumn
        '
        Me.TotalCostDataGridViewTextBoxColumn.DataPropertyName = "Total_Cost"
        Me.TotalCostDataGridViewTextBoxColumn.HeaderText = "Total_Cost"
        Me.TotalCostDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TotalCostDataGridViewTextBoxColumn.Name = "TotalCostDataGridViewTextBoxColumn"
        Me.TotalCostDataGridViewTextBoxColumn.Width = 125
        '
        'OverallWarrantyPeriodDataGridViewTextBoxColumn
        '
        Me.OverallWarrantyPeriodDataGridViewTextBoxColumn.DataPropertyName = "Overall_Warranty_Period"
        Me.OverallWarrantyPeriodDataGridViewTextBoxColumn.HeaderText = "Overall_Warranty_Period"
        Me.OverallWarrantyPeriodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OverallWarrantyPeriodDataGridViewTextBoxColumn.Name = "OverallWarrantyPeriodDataGridViewTextBoxColumn"
        Me.OverallWarrantyPeriodDataGridViewTextBoxColumn.Width = 125
        '
        'ServiceID1DataGridViewTextBoxColumn
        '
        Me.ServiceID1DataGridViewTextBoxColumn.DataPropertyName = "Service_ID_1"
        Me.ServiceID1DataGridViewTextBoxColumn.HeaderText = "Service_ID_1"
        Me.ServiceID1DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ServiceID1DataGridViewTextBoxColumn.Name = "ServiceID1DataGridViewTextBoxColumn"
        Me.ServiceID1DataGridViewTextBoxColumn.Width = 125
        '
        'ServiceID2DataGridViewTextBoxColumn
        '
        Me.ServiceID2DataGridViewTextBoxColumn.DataPropertyName = "Service_ID_2"
        Me.ServiceID2DataGridViewTextBoxColumn.HeaderText = "Service_ID_2"
        Me.ServiceID2DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ServiceID2DataGridViewTextBoxColumn.Name = "ServiceID2DataGridViewTextBoxColumn"
        Me.ServiceID2DataGridViewTextBoxColumn.Width = 125
        '
        'ServiceID3DataGridViewTextBoxColumn
        '
        Me.ServiceID3DataGridViewTextBoxColumn.DataPropertyName = "Service_ID_3"
        Me.ServiceID3DataGridViewTextBoxColumn.HeaderText = "Service_ID_3"
        Me.ServiceID3DataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ServiceID3DataGridViewTextBoxColumn.Name = "ServiceID3DataGridViewTextBoxColumn"
        Me.ServiceID3DataGridViewTextBoxColumn.Width = 125
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID"
        Me.EmployeeIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.Width = 125
        '
        'OrdersBindingSource1
        '
        Me.OrdersBindingSource1.DataMember = "Orders"
        Me.OrdersBindingSource1.DataSource = Me.Computer_companyDataSet
        '
        'TabOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1173, 667)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "TabOrder"
        Me.Text = "TabOrder"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Computer_companyDataSet As Computer_companyDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As Computer_companyDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents OrderDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeliveryDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComponentID1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComponentID2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComponentID3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrepaymentPercentageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FulfillmentStatusDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OverallWarrantyPeriodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceID1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceID2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServiceID3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrdersBindingSource1 As BindingSource
End Class
