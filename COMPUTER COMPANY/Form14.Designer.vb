<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form14
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
        Dim Component_ID_2Label1 As System.Windows.Forms.Label
        Dim Component_ID_3Label1 As System.Windows.Forms.Label
        Dim Component_ID_3Label2 As System.Windows.Forms.Label
        Dim Prepayment_PercentageLabel As System.Windows.Forms.Label
        Dim Service_ID_1Label1 As System.Windows.Forms.Label
        Dim Service_ID_2Label1 As System.Windows.Forms.Label
        Dim Service_ID_3Label1 As System.Windows.Forms.Label
        Dim Employee_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Computer_companyDataSet = New COMPUTER_COMPANY.Computer_companyDataSet()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.OrdersTableAdapter()
        Me.TableAdapterManager = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.TableAdapterManager()
        Me.OrdersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.OrdersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.cmbService1 = New System.Windows.Forms.ComboBox()
        Me.ServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ОтделКадровBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Отдел_кадровTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.Отдел_кадровTableAdapter()
        Me.ServicesTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.ServicesTableAdapter()
        Me.cmbService2 = New System.Windows.Forms.ComboBox()
        Me.ServicesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbService3 = New System.Windows.Forms.ComboBox()
        Me.ServicesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbComponent1 = New System.Windows.Forms.ComboBox()
        Me.ComponentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComponentsTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.ComponentsTableAdapter()
        Me.cmbComponent2 = New System.Windows.Forms.ComboBox()
        Me.ComponentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbComponent3 = New System.Windows.Forms.ComboBox()
        Me.ComponentsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Order_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Delivery_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Prepayment_PercentageTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.CustomersTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.EmployeesTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Order_DateLabel = New System.Windows.Forms.Label()
        Delivery_DateLabel = New System.Windows.Forms.Label()
        Customer_IDLabel = New System.Windows.Forms.Label()
        Component_ID_1Label = New System.Windows.Forms.Label()
        Component_ID_2Label1 = New System.Windows.Forms.Label()
        Component_ID_3Label1 = New System.Windows.Forms.Label()
        Component_ID_3Label2 = New System.Windows.Forms.Label()
        Prepayment_PercentageLabel = New System.Windows.Forms.Label()
        Service_ID_1Label1 = New System.Windows.Forms.Label()
        Service_ID_2Label1 = New System.Windows.Forms.Label()
        Service_ID_3Label1 = New System.Windows.Forms.Label()
        Employee_IDLabel = New System.Windows.Forms.Label()
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrdersBindingNavigator.SuspendLayout()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ОтделКадровBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Order_DateLabel
        '
        Order_DateLabel.AutoSize = True
        Order_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Order_DateLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Order_DateLabel.Location = New System.Drawing.Point(43, 123)
        Order_DateLabel.Name = "Order_DateLabel"
        Order_DateLabel.Size = New System.Drawing.Size(99, 18)
        Order_DateLabel.TabIndex = 39
        Order_DateLabel.Text = "Дата заказа:"
        '
        'Delivery_DateLabel
        '
        Delivery_DateLabel.AutoSize = True
        Delivery_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Delivery_DateLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Delivery_DateLabel.Location = New System.Drawing.Point(9, 158)
        Delivery_DateLabel.Name = "Delivery_DateLabel"
        Delivery_DateLabel.Size = New System.Drawing.Size(133, 18)
        Delivery_DateLabel.TabIndex = 40
        Delivery_DateLabel.Text = "Дата исполнения:"
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Customer_IDLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Customer_IDLabel.Location = New System.Drawing.Point(101, 297)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(48, 18)
        Customer_IDLabel.TabIndex = 41
        Customer_IDLabel.Text = "ФИО:"
        '
        'Component_ID_1Label
        '
        Component_ID_1Label.AutoSize = True
        Component_ID_1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Component_ID_1Label.ForeColor = System.Drawing.SystemColors.HotTrack
        Component_ID_1Label.Location = New System.Drawing.Point(37, 350)
        Component_ID_1Label.Name = "Component_ID_1Label"
        Component_ID_1Label.Size = New System.Drawing.Size(102, 18)
        Component_ID_1Label.TabIndex = 42
        Component_ID_1Label.Text = "Component 1:"
        '
        'Component_ID_2Label1
        '
        Component_ID_2Label1.AutoSize = True
        Component_ID_2Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Component_ID_2Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Component_ID_2Label1.Location = New System.Drawing.Point(37, 378)
        Component_ID_2Label1.Name = "Component_ID_2Label1"
        Component_ID_2Label1.Size = New System.Drawing.Size(102, 18)
        Component_ID_2Label1.TabIndex = 43
        Component_ID_2Label1.Text = "Component 2:"
        '
        'Component_ID_3Label1
        '
        Component_ID_3Label1.AutoSize = True
        Component_ID_3Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Component_ID_3Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Component_ID_3Label1.Location = New System.Drawing.Point(37, 406)
        Component_ID_3Label1.Name = "Component_ID_3Label1"
        Component_ID_3Label1.Size = New System.Drawing.Size(108, 18)
        Component_ID_3Label1.TabIndex = 44
        Component_ID_3Label1.Text = "Component ID "
        '
        'Component_ID_3Label2
        '
        Component_ID_3Label2.AutoSize = True
        Component_ID_3Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Component_ID_3Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Component_ID_3Label2.Location = New System.Drawing.Point(37, 406)
        Component_ID_3Label2.Name = "Component_ID_3Label2"
        Component_ID_3Label2.Size = New System.Drawing.Size(102, 18)
        Component_ID_3Label2.TabIndex = 45
        Component_ID_3Label2.Text = "Component 3:"
        '
        'Prepayment_PercentageLabel
        '
        Prepayment_PercentageLabel.AutoSize = True
        Prepayment_PercentageLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Prepayment_PercentageLabel.Location = New System.Drawing.Point(484, 240)
        Prepayment_PercentageLabel.Name = "Prepayment_PercentageLabel"
        Prepayment_PercentageLabel.Size = New System.Drawing.Size(122, 16)
        Prepayment_PercentageLabel.TabIndex = 46
        Prepayment_PercentageLabel.Text = "Доля предоплаты"
        '
        'Service_ID_1Label1
        '
        Service_ID_1Label1.AutoSize = True
        Service_ID_1Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Service_ID_1Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Service_ID_1Label1.Location = New System.Drawing.Point(60, 457)
        Service_ID_1Label1.Name = "Service_ID_1Label1"
        Service_ID_1Label1.Size = New System.Drawing.Size(73, 18)
        Service_ID_1Label1.TabIndex = 48
        Service_ID_1Label1.Text = "Service 1:"
        '
        'Service_ID_2Label1
        '
        Service_ID_2Label1.AutoSize = True
        Service_ID_2Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Service_ID_2Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Service_ID_2Label1.Location = New System.Drawing.Point(60, 485)
        Service_ID_2Label1.Name = "Service_ID_2Label1"
        Service_ID_2Label1.Size = New System.Drawing.Size(73, 18)
        Service_ID_2Label1.TabIndex = 49
        Service_ID_2Label1.Text = "Service 2:"
        '
        'Service_ID_3Label1
        '
        Service_ID_3Label1.AutoSize = True
        Service_ID_3Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Service_ID_3Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Service_ID_3Label1.Location = New System.Drawing.Point(60, 513)
        Service_ID_3Label1.Name = "Service_ID_3Label1"
        Service_ID_3Label1.Size = New System.Drawing.Size(73, 18)
        Service_ID_3Label1.TabIndex = 50
        Service_ID_3Label1.Text = "Service 3:"
        '
        'Employee_IDLabel
        '
        Employee_IDLabel.AutoSize = True
        Employee_IDLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Employee_IDLabel.Location = New System.Drawing.Point(462, 197)
        Employee_IDLabel.Name = "Employee_IDLabel"
        Employee_IDLabel.Size = New System.Drawing.Size(144, 16)
        Employee_IDLabel.TabIndex = 51
        Employee_IDLabel.Text = "Указать сотрудника:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(643, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 39)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "добавления заказа"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(643, 426)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(664, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 16)
        Me.Label6.TabIndex = 16
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
        'OrdersBindingNavigator
        '
        Me.OrdersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OrdersBindingNavigator.BindingSource = Me.OrdersBindingSource
        Me.OrdersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OrdersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OrdersBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.OrdersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OrdersBindingNavigatorSaveItem})
        Me.OrdersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OrdersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OrdersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OrdersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OrdersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OrdersBindingNavigator.Name = "OrdersBindingNavigator"
        Me.OrdersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OrdersBindingNavigator.Size = New System.Drawing.Size(872, 31)
        Me.OrdersBindingNavigator.TabIndex = 17
        Me.OrdersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 28)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'OrdersBindingNavigatorSaveItem
        '
        Me.OrdersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OrdersBindingNavigatorSaveItem.Image = CType(resources.GetObject("OrdersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OrdersBindingNavigatorSaveItem.Name = "OrdersBindingNavigatorSaveItem"
        Me.OrdersBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.OrdersBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'cmbService1
        '
        Me.cmbService1.DataSource = Me.ServicesBindingSource
        Me.cmbService1.DisplayMember = "Name"
        Me.cmbService1.FormattingEnabled = True
        Me.cmbService1.Location = New System.Drawing.Point(148, 451)
        Me.cmbService1.Name = "cmbService1"
        Me.cmbService1.Size = New System.Drawing.Size(231, 24)
        Me.cmbService1.TabIndex = 27
        '
        'ServicesBindingSource
        '
        Me.ServicesBindingSource.DataMember = "Services"
        Me.ServicesBindingSource.DataSource = Me.Computer_companyDataSet
        '
        'ОтделКадровBindingSource
        '
        Me.ОтделКадровBindingSource.DataMember = "Отдел кадров"
        Me.ОтделКадровBindingSource.DataSource = Me.Computer_companyDataSet
        '
        'Отдел_кадровTableAdapter
        '
        Me.Отдел_кадровTableAdapter.ClearBeforeFill = True
        '
        'ServicesTableAdapter
        '
        Me.ServicesTableAdapter.ClearBeforeFill = True
        '
        'cmbService2
        '
        Me.cmbService2.DataSource = Me.ServicesBindingSource1
        Me.cmbService2.DisplayMember = "Name"
        Me.cmbService2.FormattingEnabled = True
        Me.cmbService2.Location = New System.Drawing.Point(148, 481)
        Me.cmbService2.Name = "cmbService2"
        Me.cmbService2.Size = New System.Drawing.Size(231, 24)
        Me.cmbService2.TabIndex = 29
        '
        'ServicesBindingSource1
        '
        Me.ServicesBindingSource1.DataMember = "Services"
        Me.ServicesBindingSource1.DataSource = Me.Computer_companyDataSet
        '
        'cmbService3
        '
        Me.cmbService3.DataSource = Me.ServicesBindingSource2
        Me.cmbService3.DisplayMember = "Name"
        Me.cmbService3.FormattingEnabled = True
        Me.cmbService3.Location = New System.Drawing.Point(148, 511)
        Me.cmbService3.Name = "cmbService3"
        Me.cmbService3.Size = New System.Drawing.Size(231, 24)
        Me.cmbService3.TabIndex = 30
        '
        'ServicesBindingSource2
        '
        Me.ServicesBindingSource2.DataMember = "Services"
        Me.ServicesBindingSource2.DataSource = Me.Computer_companyDataSet
        '
        'cmbComponent1
        '
        Me.cmbComponent1.DataSource = Me.ComponentsBindingSource
        Me.cmbComponent1.DisplayMember = "Brand"
        Me.cmbComponent1.FormattingEnabled = True
        Me.cmbComponent1.Location = New System.Drawing.Point(148, 342)
        Me.cmbComponent1.Name = "cmbComponent1"
        Me.cmbComponent1.Size = New System.Drawing.Size(231, 24)
        Me.cmbComponent1.TabIndex = 31
        '
        'ComponentsBindingSource
        '
        Me.ComponentsBindingSource.DataMember = "Components"
        Me.ComponentsBindingSource.DataSource = Me.Computer_companyDataSet
        '
        'ComponentsTableAdapter
        '
        Me.ComponentsTableAdapter.ClearBeforeFill = True
        '
        'cmbComponent2
        '
        Me.cmbComponent2.DataSource = Me.ComponentsBindingSource1
        Me.cmbComponent2.DisplayMember = "Brand"
        Me.cmbComponent2.FormattingEnabled = True
        Me.cmbComponent2.Location = New System.Drawing.Point(148, 375)
        Me.cmbComponent2.Name = "cmbComponent2"
        Me.cmbComponent2.Size = New System.Drawing.Size(231, 24)
        Me.cmbComponent2.TabIndex = 32
        '
        'ComponentsBindingSource1
        '
        Me.ComponentsBindingSource1.DataMember = "Components"
        Me.ComponentsBindingSource1.DataSource = Me.Computer_companyDataSet
        '
        'cmbComponent3
        '
        Me.cmbComponent3.DataSource = Me.ComponentsBindingSource2
        Me.cmbComponent3.DisplayMember = "Brand"
        Me.cmbComponent3.FormattingEnabled = True
        Me.cmbComponent3.Location = New System.Drawing.Point(148, 403)
        Me.cmbComponent3.Name = "cmbComponent3"
        Me.cmbComponent3.Size = New System.Drawing.Size(231, 24)
        Me.cmbComponent3.TabIndex = 33
        '
        'ComponentsBindingSource2
        '
        Me.ComponentsBindingSource2.DataMember = "Components"
        Me.ComponentsBindingSource2.DataSource = Me.Computer_companyDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.Location = New System.Drawing.Point(83, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 29)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Создание заказа"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(148, 210)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(231, 54)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "Стать клиентом"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Order_DateDateTimePicker
        '
        Me.Order_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "Order_Date", True))
        Me.Order_DateDateTimePicker.Location = New System.Drawing.Point(148, 120)
        Me.Order_DateDateTimePicker.Name = "Order_DateDateTimePicker"
        Me.Order_DateDateTimePicker.Size = New System.Drawing.Size(231, 22)
        Me.Order_DateDateTimePicker.TabIndex = 40
        '
        'Delivery_DateDateTimePicker
        '
        Me.Delivery_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OrdersBindingSource, "Delivery_Date", True))
        Me.Delivery_DateDateTimePicker.Location = New System.Drawing.Point(148, 158)
        Me.Delivery_DateDateTimePicker.Name = "Delivery_DateDateTimePicker"
        Me.Delivery_DateDateTimePicker.Size = New System.Drawing.Size(231, 22)
        Me.Delivery_DateDateTimePicker.TabIndex = 41
        '
        'Prepayment_PercentageTextBox
        '
        Me.Prepayment_PercentageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OrdersBindingSource, "Prepayment_Percentage", True))
        Me.Prepayment_PercentageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Prepayment_PercentageTextBox.Location = New System.Drawing.Point(613, 240)
        Me.Prepayment_PercentageTextBox.Name = "Prepayment_PercentageTextBox"
        Me.Prepayment_PercentageTextBox.Size = New System.Drawing.Size(225, 24)
        Me.Prepayment_PercentageTextBox.TabIndex = 47
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CustomersBindingSource
        Me.ComboBox1.DisplayMember = "Full_Name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(148, 294)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(231, 24)
        Me.ComboBox1.TabIndex = 48
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
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(617, 105)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(221, 54)
        Me.Button4.TabIndex = 51
        Me.Button4.Text = "Выбрать сотрудника"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.EmployeesBindingSource
        Me.ComboBox2.DisplayMember = "Full_Name"
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(613, 194)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(225, 26)
        Me.ComboBox2.TabIndex = 53
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.Computer_companyDataSet
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(496, 329)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 54
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(872, 595)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Employee_IDLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Service_ID_3Label1)
        Me.Controls.Add(Service_ID_2Label1)
        Me.Controls.Add(Service_ID_1Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Prepayment_PercentageLabel)
        Me.Controls.Add(Me.Prepayment_PercentageTextBox)
        Me.Controls.Add(Component_ID_3Label2)
        Me.Controls.Add(Component_ID_3Label1)
        Me.Controls.Add(Component_ID_2Label1)
        Me.Controls.Add(Component_ID_1Label)
        Me.Controls.Add(Customer_IDLabel)
        Me.Controls.Add(Delivery_DateLabel)
        Me.Controls.Add(Me.Delivery_DateDateTimePicker)
        Me.Controls.Add(Order_DateLabel)
        Me.Controls.Add(Me.Order_DateDateTimePicker)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbComponent3)
        Me.Controls.Add(Me.cmbComponent2)
        Me.Controls.Add(Me.cmbComponent1)
        Me.Controls.Add(Me.cmbService3)
        Me.Controls.Add(Me.cmbService2)
        Me.Controls.Add(Me.cmbService1)
        Me.Controls.Add(Me.OrdersBindingNavigator)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form14"
        Me.Text = "Form14"
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrdersBindingNavigator.ResumeLayout(False)
        Me.OrdersBindingNavigator.PerformLayout()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ОтделКадровBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub Component_ID_1Label_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Computer_companyDataSet As Computer_companyDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As Computer_companyDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents TableAdapterManager As Computer_companyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OrdersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents OrdersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents cmbService1 As ComboBox
    Friend WithEvents ОтделКадровBindingSource As BindingSource
    Friend WithEvents Отдел_кадровTableAdapter As Computer_companyDataSetTableAdapters.Отдел_кадровTableAdapter
    Friend WithEvents ServicesBindingSource As BindingSource
    Friend WithEvents ServicesTableAdapter As Computer_companyDataSetTableAdapters.ServicesTableAdapter
    Friend WithEvents cmbService2 As ComboBox
    Friend WithEvents ServicesBindingSource1 As BindingSource
    Friend WithEvents cmbService3 As ComboBox
    Friend WithEvents cmbComponent1 As ComboBox
    Friend WithEvents ComponentsBindingSource As BindingSource
    Friend WithEvents ComponentsTableAdapter As Computer_companyDataSetTableAdapters.ComponentsTableAdapter
    Friend WithEvents cmbComponent2 As ComboBox
    Friend WithEvents cmbComponent3 As ComboBox
    Friend WithEvents ServicesBindingSource2 As BindingSource
    Friend WithEvents ComponentsBindingSource1 As BindingSource
    Friend WithEvents ComponentsBindingSource2 As BindingSource
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Order_DateDateTimePicker As DateTimePicker
    Friend WithEvents Delivery_DateDateTimePicker As DateTimePicker
    Friend WithEvents Prepayment_PercentageTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As Computer_companyDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents EmployeesTableAdapter As Computer_companyDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents TextBox1 As TextBox
End Class
