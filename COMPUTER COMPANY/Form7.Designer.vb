<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Order_DateLabel As System.Windows.Forms.Label
        Dim Delivery_DateLabel As System.Windows.Forms.Label
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim Component_ID_1Label As System.Windows.Forms.Label
        Dim Component_ID_2Label As System.Windows.Forms.Label
        Dim Component_ID_3Label As System.Windows.Forms.Label
        Dim Prepayment_PercentageLabel As System.Windows.Forms.Label
        Dim Payment_StatusLabel As System.Windows.Forms.Label
        Dim Fulfillment_StatusLabel As System.Windows.Forms.Label
        Dim Total_CostLabel As System.Windows.Forms.Label
        Dim Overall_Warranty_PeriodLabel As System.Windows.Forms.Label
        Dim Service_ID_1Label As System.Windows.Forms.Label
        Dim Service_ID_2Label As System.Windows.Forms.Label
        Dim Service_ID_3Label As System.Windows.Forms.Label
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Computer_companyDataSet = New COMPUTER_COMPANY.Computer_companyDataSet()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.OrdersTableAdapter()
        Me.TableAdapterManager = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.TableAdapterManager()
        Me.Order_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Delivery_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Prepayment_PercentageTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.Fulfillment_StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.Total_CostTextBox = New System.Windows.Forms.TextBox()
        Me.Overall_Warranty_PeriodTextBox = New System.Windows.Forms.TextBox()
        Me.Employee_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.CustomersTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComponentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ComponentsTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.ComponentsTableAdapter()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.ServicesTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.ServicesTableAdapter()
        Me.Button8 = New System.Windows.Forms.Button()
        Order_DateLabel = New System.Windows.Forms.Label()
        Delivery_DateLabel = New System.Windows.Forms.Label()
        Customer_IDLabel = New System.Windows.Forms.Label()
        Component_ID_1Label = New System.Windows.Forms.Label()
        Component_ID_2Label = New System.Windows.Forms.Label()
        Component_ID_3Label = New System.Windows.Forms.Label()
        Prepayment_PercentageLabel = New System.Windows.Forms.Label()
        Payment_StatusLabel = New System.Windows.Forms.Label()
        Fulfillment_StatusLabel = New System.Windows.Forms.Label()
        Total_CostLabel = New System.Windows.Forms.Label()
        Overall_Warranty_PeriodLabel = New System.Windows.Forms.Label()
        Service_ID_1Label = New System.Windows.Forms.Label()
        Service_ID_2Label = New System.Windows.Forms.Label()
        Service_ID_3Label = New System.Windows.Forms.Label()
        Employee_IDLabel = New System.Windows.Forms.Label()
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Order_DateLabel
        '
        Order_DateLabel.AutoSize = True
        Order_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Order_DateLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Order_DateLabel.Location = New System.Drawing.Point(105, 143)
        Order_DateLabel.Name = "Order_DateLabel"
        Order_DateLabel.Size = New System.Drawing.Size(104, 22)
        Order_DateLabel.TabIndex = 2
        Order_DateLabel.Text = "Order Date:"
        '
        'Delivery_DateLabel
        '
        Delivery_DateLabel.AutoSize = True
        Delivery_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Delivery_DateLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Delivery_DateLabel.Location = New System.Drawing.Point(89, 171)
        Delivery_DateLabel.Name = "Delivery_DateLabel"
        Delivery_DateLabel.Size = New System.Drawing.Size(123, 22)
        Delivery_DateLabel.TabIndex = 4
        Delivery_DateLabel.Text = "Delivery Date:"
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Customer_IDLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Customer_IDLabel.Location = New System.Drawing.Point(28, 420)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(97, 22)
        Customer_IDLabel.TabIndex = 6
        Customer_IDLabel.Text = "Customer :"
        '
        'Component_ID_1Label
        '
        Component_ID_1Label.AutoSize = True
        Component_ID_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Component_ID_1Label.ForeColor = System.Drawing.SystemColors.HotTrack
        Component_ID_1Label.Location = New System.Drawing.Point(20, 448)
        Component_ID_1Label.Name = "Component_ID_1Label"
        Component_ID_1Label.Size = New System.Drawing.Size(122, 22)
        Component_ID_1Label.TabIndex = 8
        Component_ID_1Label.Text = "Component 1:"
        '
        'Component_ID_2Label
        '
        Component_ID_2Label.AutoSize = True
        Component_ID_2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Component_ID_2Label.ForeColor = System.Drawing.SystemColors.HotTrack
        Component_ID_2Label.Location = New System.Drawing.Point(20, 476)
        Component_ID_2Label.Name = "Component_ID_2Label"
        Component_ID_2Label.Size = New System.Drawing.Size(122, 22)
        Component_ID_2Label.TabIndex = 10
        Component_ID_2Label.Text = "Component 2:"
        '
        'Component_ID_3Label
        '
        Component_ID_3Label.AutoSize = True
        Component_ID_3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Component_ID_3Label.ForeColor = System.Drawing.SystemColors.HotTrack
        Component_ID_3Label.Location = New System.Drawing.Point(20, 504)
        Component_ID_3Label.Name = "Component_ID_3Label"
        Component_ID_3Label.Size = New System.Drawing.Size(122, 22)
        Component_ID_3Label.TabIndex = 12
        Component_ID_3Label.Text = "Component 3:"
        '
        'Prepayment_PercentageLabel
        '
        Prepayment_PercentageLabel.AutoSize = True
        Prepayment_PercentageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Prepayment_PercentageLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Prepayment_PercentageLabel.Location = New System.Drawing.Point(28, 230)
        Prepayment_PercentageLabel.Name = "Prepayment_PercentageLabel"
        Prepayment_PercentageLabel.Size = New System.Drawing.Size(208, 22)
        Prepayment_PercentageLabel.TabIndex = 14
        Prepayment_PercentageLabel.Text = "Prepayment Percentage:"
        '
        'Payment_StatusLabel
        '
        Payment_StatusLabel.AutoSize = True
        Payment_StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Payment_StatusLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Payment_StatusLabel.Location = New System.Drawing.Point(96, 256)
        Payment_StatusLabel.Name = "Payment_StatusLabel"
        Payment_StatusLabel.Size = New System.Drawing.Size(141, 22)
        Payment_StatusLabel.TabIndex = 16
        Payment_StatusLabel.Text = "Payment Status:"
        '
        'Fulfillment_StatusLabel
        '
        Fulfillment_StatusLabel.AutoSize = True
        Fulfillment_StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Fulfillment_StatusLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Fulfillment_StatusLabel.Location = New System.Drawing.Point(85, 286)
        Fulfillment_StatusLabel.Name = "Fulfillment_StatusLabel"
        Fulfillment_StatusLabel.Size = New System.Drawing.Size(152, 22)
        Fulfillment_StatusLabel.TabIndex = 18
        Fulfillment_StatusLabel.Text = "Fulfillment Status:"
        '
        'Total_CostLabel
        '
        Total_CostLabel.AutoSize = True
        Total_CostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Total_CostLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Total_CostLabel.Location = New System.Drawing.Point(139, 314)
        Total_CostLabel.Name = "Total_CostLabel"
        Total_CostLabel.Size = New System.Drawing.Size(98, 22)
        Total_CostLabel.TabIndex = 20
        Total_CostLabel.Text = "Total Cost:"
        '
        'Overall_Warranty_PeriodLabel
        '
        Overall_Warranty_PeriodLabel.AutoSize = True
        Overall_Warranty_PeriodLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Overall_Warranty_PeriodLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Overall_Warranty_PeriodLabel.Location = New System.Drawing.Point(28, 342)
        Overall_Warranty_PeriodLabel.Name = "Overall_Warranty_PeriodLabel"
        Overall_Warranty_PeriodLabel.Size = New System.Drawing.Size(207, 22)
        Overall_Warranty_PeriodLabel.TabIndex = 22
        Overall_Warranty_PeriodLabel.Text = "Overall Warranty Period:"
        '
        'Service_ID_1Label
        '
        Service_ID_1Label.AutoSize = True
        Service_ID_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Service_ID_1Label.ForeColor = System.Drawing.SystemColors.HotTrack
        Service_ID_1Label.Location = New System.Drawing.Point(267, 424)
        Service_ID_1Label.Name = "Service_ID_1Label"
        Service_ID_1Label.Size = New System.Drawing.Size(90, 22)
        Service_ID_1Label.TabIndex = 24
        Service_ID_1Label.Text = "Service 1:"
        '
        'Service_ID_2Label
        '
        Service_ID_2Label.AutoSize = True
        Service_ID_2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Service_ID_2Label.ForeColor = System.Drawing.SystemColors.HotTrack
        Service_ID_2Label.Location = New System.Drawing.Point(267, 452)
        Service_ID_2Label.Name = "Service_ID_2Label"
        Service_ID_2Label.Size = New System.Drawing.Size(90, 22)
        Service_ID_2Label.TabIndex = 26
        Service_ID_2Label.Text = "Service 2:"
        '
        'Service_ID_3Label
        '
        Service_ID_3Label.AutoSize = True
        Service_ID_3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Service_ID_3Label.ForeColor = System.Drawing.SystemColors.HotTrack
        Service_ID_3Label.Location = New System.Drawing.Point(267, 480)
        Service_ID_3Label.Name = "Service_ID_3Label"
        Service_ID_3Label.Size = New System.Drawing.Size(90, 22)
        Service_ID_3Label.TabIndex = 28
        Service_ID_3Label.Text = "Service 3:"
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.Location = New System.Drawing.Point(98, 589)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(88, 16)
        Employee_IDLabel.TabIndex = 30
        Employee_IDLabel.Text = "Employee ID:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(23, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(701, 71)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Таблица ""Заказы"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Component_TypesTableAdapter = Nothing
        Me.TableAdapterManager.ComponentsTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Me.OrdersTableAdapter
        Me.TableAdapterManager.PositionsTableAdapter = Nothing
        Me.TableAdapterManager.ServicesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Order_DateDateTimePicker
        '
        Me.Order_DateDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.Highlight
        Me.Order_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "Order_Date", True))
        Me.Order_DateDateTimePicker.Location = New System.Drawing.Point(233, 140)
        Me.Order_DateDateTimePicker.Name = "Order_DateDateTimePicker"
        Me.Order_DateDateTimePicker.Size = New System.Drawing.Size(245, 22)
        Me.Order_DateDateTimePicker.TabIndex = 3
        '
        'Delivery_DateDateTimePicker
        '
        Me.Delivery_DateDateTimePicker.CalendarForeColor = System.Drawing.SystemColors.Highlight
        Me.Delivery_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "Delivery_Date", True))
        Me.Delivery_DateDateTimePicker.Location = New System.Drawing.Point(233, 168)
        Me.Delivery_DateDateTimePicker.Name = "Delivery_DateDateTimePicker"
        Me.Delivery_DateDateTimePicker.Size = New System.Drawing.Size(245, 22)
        Me.Delivery_DateDateTimePicker.TabIndex = 5
        '
        'Prepayment_PercentageTextBox
        '
        Me.Prepayment_PercentageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Prepayment_Percentage", True))
        Me.Prepayment_PercentageTextBox.Location = New System.Drawing.Point(323, 215)
        Me.Prepayment_PercentageTextBox.Name = "Prepayment_PercentageTextBox"
        Me.Prepayment_PercentageTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Prepayment_PercentageTextBox.TabIndex = 15
        '
        'Payment_StatusCheckBox
        '
        Me.Payment_StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrdersBindingSource, "Payment_Status", True))
        Me.Payment_StatusCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Payment_StatusCheckBox.Location = New System.Drawing.Point(328, 254)
        Me.Payment_StatusCheckBox.Name = "Payment_StatusCheckBox"
        Me.Payment_StatusCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Payment_StatusCheckBox.TabIndex = 17
        Me.Payment_StatusCheckBox.Text = "CheckBox1"
        Me.Payment_StatusCheckBox.UseVisualStyleBackColor = True
        '
        'Fulfillment_StatusCheckBox
        '
        Me.Fulfillment_StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.OrdersBindingSource, "Fulfillment_Status", True))
        Me.Fulfillment_StatusCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Fulfillment_StatusCheckBox.Location = New System.Drawing.Point(328, 284)
        Me.Fulfillment_StatusCheckBox.Name = "Fulfillment_StatusCheckBox"
        Me.Fulfillment_StatusCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.Fulfillment_StatusCheckBox.TabIndex = 19
        Me.Fulfillment_StatusCheckBox.Text = "CheckBox1"
        Me.Fulfillment_StatusCheckBox.UseVisualStyleBackColor = True
        '
        'Total_CostTextBox
        '
        Me.Total_CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Total_Cost", True))
        Me.Total_CostTextBox.Location = New System.Drawing.Point(323, 314)
        Me.Total_CostTextBox.Name = "Total_CostTextBox"
        Me.Total_CostTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Total_CostTextBox.TabIndex = 21
        '
        'Overall_Warranty_PeriodTextBox
        '
        Me.Overall_Warranty_PeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Overall_Warranty_Period", True))
        Me.Overall_Warranty_PeriodTextBox.Location = New System.Drawing.Point(323, 344)
        Me.Overall_Warranty_PeriodTextBox.Name = "Overall_Warranty_PeriodTextBox"
        Me.Overall_Warranty_PeriodTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Overall_Warranty_PeriodTextBox.TabIndex = 23
        '
        'Employee_IDTextBox
        '
        Me.Employee_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Employee_ID", True))
        Me.Employee_IDTextBox.Location = New System.Drawing.Point(192, 586)
        Me.Employee_IDTextBox.Name = "Employee_IDTextBox"
        Me.Employee_IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Employee_IDTextBox.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(508, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 54)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Отчет"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(690, 444)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 54)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Таблица"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Control
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button7.Location = New System.Drawing.Point(606, 111)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(141, 54)
        Me.Button7.TabIndex = 40
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button6.Location = New System.Drawing.Point(690, 356)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 54)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.Location = New System.Drawing.Point(690, 279)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 54)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Следущая"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(690, 198)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 54)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(508, 356)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 54)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Control
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button10.Location = New System.Drawing.Point(508, 279)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(141, 54)
        Me.Button10.TabIndex = 35
        Me.Button10.Text = "Предыдущая"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button11.Location = New System.Drawing.Point(508, 198)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(141, 54)
        Me.Button11.TabIndex = 34
        Me.Button11.Text = "Первая"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CustomersBindingSource
        Me.ComboBox1.DisplayMember = "Full_Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(143, 422)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(115, 24)
        Me.ComboBox1.TabIndex = 41
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.Computer_companyDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ComponentsBindingSource
        Me.ComboBox2.DisplayMember = "Brand"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(143, 448)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(114, 24)
        Me.ComboBox2.TabIndex = 42
        '
        'ComponentsBindingSource
        '
        Me.ComponentsBindingSource.DataMember = "Components"
        Me.ComponentsBindingSource.DataSource = Me.Computer_companyDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.ComponentsBindingSource
        Me.ComboBox3.DisplayMember = "Brand"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(143, 476)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(114, 24)
        Me.ComboBox3.TabIndex = 43
        '
        'ComboBox4
        '
        Me.ComboBox4.DataSource = Me.ComponentsBindingSource
        Me.ComboBox4.DisplayMember = "Brand"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(143, 502)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(114, 24)
        Me.ComboBox4.TabIndex = 44
        '
        'ComponentsTableAdapter
        '
        Me.ComponentsTableAdapter.ClearBeforeFill = True
        '
        'ComboBox5
        '
        Me.ComboBox5.DataSource = Me.ServicesBindingSource
        Me.ComboBox5.DisplayMember = "Name"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(363, 424)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(115, 24)
        Me.ComboBox5.TabIndex = 45
        '
        'ServicesBindingSource
        '
        Me.ServicesBindingSource.DataMember = "Services"
        Me.ServicesBindingSource.DataSource = Me.Computer_companyDataSet
        '
        'ComboBox6
        '
        Me.ComboBox6.DataSource = Me.ServicesBindingSource
        Me.ComboBox6.DisplayMember = "Name"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(363, 452)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(115, 24)
        Me.ComboBox6.TabIndex = 46
        '
        'ComboBox7
        '
        Me.ComboBox7.DataSource = Me.ServicesBindingSource
        Me.ComboBox7.DisplayMember = "Name"
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(363, 482)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(115, 24)
        Me.ComboBox7.TabIndex = 47
        '
        'ServicesTableAdapter
        '
        Me.ServicesTableAdapter.ClearBeforeFill = True
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Control
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button8.Location = New System.Drawing.Point(609, 506)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(138, 51)
        Me.Button8.TabIndex = 48
        Me.Button8.Text = "Закрыть"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(868, 569)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Employee_IDLabel)
        Me.Controls.Add(Me.Employee_IDTextBox)
        Me.Controls.Add(Service_ID_3Label)
        Me.Controls.Add(Service_ID_2Label)
        Me.Controls.Add(Service_ID_1Label)
        Me.Controls.Add(Overall_Warranty_PeriodLabel)
        Me.Controls.Add(Me.Overall_Warranty_PeriodTextBox)
        Me.Controls.Add(Total_CostLabel)
        Me.Controls.Add(Me.Total_CostTextBox)
        Me.Controls.Add(Fulfillment_StatusLabel)
        Me.Controls.Add(Me.Fulfillment_StatusCheckBox)
        Me.Controls.Add(Payment_StatusLabel)
        Me.Controls.Add(Me.Payment_StatusCheckBox)
        Me.Controls.Add(Prepayment_PercentageLabel)
        Me.Controls.Add(Me.Prepayment_PercentageTextBox)
        Me.Controls.Add(Component_ID_3Label)
        Me.Controls.Add(Component_ID_2Label)
        Me.Controls.Add(Component_ID_1Label)
        Me.Controls.Add(Customer_IDLabel)
        Me.Controls.Add(Delivery_DateLabel)
        Me.Controls.Add(Me.Delivery_DateDateTimePicker)
        Me.Controls.Add(Order_DateLabel)
        Me.Controls.Add(Me.Order_DateDateTimePicker)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form7"
        Me.Text = "Таблица ""Заказы"""
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Computer_companyDataSet As Computer_companyDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As Computer_companyDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents TableAdapterManager As Computer_companyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Order_DateDateTimePicker As DateTimePicker
    Friend WithEvents Delivery_DateDateTimePicker As DateTimePicker
    Friend WithEvents Prepayment_PercentageTextBox As TextBox
    Friend WithEvents Payment_StatusCheckBox As CheckBox
    Friend WithEvents Fulfillment_StatusCheckBox As CheckBox
    Friend WithEvents Total_CostTextBox As TextBox
    Friend WithEvents Overall_Warranty_PeriodTextBox As TextBox
    Friend WithEvents Employee_IDTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As Computer_companyDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ComponentsBindingSource As BindingSource
    Friend WithEvents ComponentsTableAdapter As Computer_companyDataSetTableAdapters.ComponentsTableAdapter
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents ServicesBindingSource As BindingSource
    Friend WithEvents ServicesTableAdapter As Computer_companyDataSetTableAdapters.ServicesTableAdapter
    Friend WithEvents Button8 As Button
End Class
