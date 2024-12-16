<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim Service_IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CostLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Computer_companyDataSet = New COMPUTER_COMPANY.Computer_companyDataSet()
        Me.ServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicesTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.ServicesTableAdapter()
        Me.TableAdapterManager = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.TableAdapterManager()
        Me.Service_IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.CostTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Service_IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CostLabel = New System.Windows.Forms.Label()
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Service_IDLabel
        '
        Service_IDLabel.AutoSize = True
        Service_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Service_IDLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Service_IDLabel.Location = New System.Drawing.Point(40, 203)
        Service_IDLabel.Name = "Service_IDLabel"
        Service_IDLabel.Size = New System.Drawing.Size(129, 29)
        Service_IDLabel.TabIndex = 2
        Service_IDLabel.Text = "Service ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        NameLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        NameLabel.Location = New System.Drawing.Point(85, 257)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(84, 29)
        NameLabel.TabIndex = 4
        NameLabel.Text = "Name:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DescriptionLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        DescriptionLabel.Location = New System.Drawing.Point(28, 304)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(141, 29)
        DescriptionLabel.TabIndex = 6
        DescriptionLabel.Text = "Description:"
        '
        'CostLabel
        '
        CostLabel.AutoSize = True
        CostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        CostLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        CostLabel.Location = New System.Drawing.Point(101, 351)
        CostLabel.Name = "CostLabel"
        CostLabel.Size = New System.Drawing.Size(68, 29)
        CostLabel.TabIndex = 8
        CostLabel.Text = "Cost:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(-7, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(513, 59)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Таблица ""Услуг"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Computer_companyDataSet
        '
        Me.Computer_companyDataSet.DataSetName = "Computer_companyDataSet"
        Me.Computer_companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServicesBindingSource
        '
        Me.ServicesBindingSource.DataMember = "Services"
        Me.ServicesBindingSource.DataSource = Me.Computer_companyDataSet
        '
        'ServicesTableAdapter
        '
        Me.ServicesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Component_TypesTableAdapter = Nothing
        Me.TableAdapterManager.ComponentsTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.PositionsTableAdapter = Nothing
        Me.TableAdapterManager.ServicesTableAdapter = Me.ServicesTableAdapter
        Me.TableAdapterManager.UpdateOrder = COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Service_IDTextBox
        '
        Me.Service_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "Service_ID", True))
        Me.Service_IDTextBox.Location = New System.Drawing.Point(190, 210)
        Me.Service_IDTextBox.Name = "Service_IDTextBox"
        Me.Service_IDTextBox.Size = New System.Drawing.Size(214, 22)
        Me.Service_IDTextBox.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(190, 257)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(214, 22)
        Me.NameTextBox.TabIndex = 5
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(190, 311)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(214, 22)
        Me.DescriptionTextBox.TabIndex = 7
        '
        'CostTextBox
        '
        Me.CostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicesBindingSource, "Cost", True))
        Me.CostTextBox.Location = New System.Drawing.Point(190, 358)
        Me.CostTextBox.Name = "CostTextBox"
        Me.CostTextBox.Size = New System.Drawing.Size(214, 22)
        Me.CostTextBox.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(579, 426)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 54)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Отчет"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Control
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button8.Location = New System.Drawing.Point(579, 102)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(141, 54)
        Me.Button8.TabIndex = 44
        Me.Button8.Text = "Сохранить"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Control
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button7.Location = New System.Drawing.Point(671, 349)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(141, 54)
        Me.Button7.TabIndex = 43
        Me.Button7.Text = "Удалить"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button6.Location = New System.Drawing.Point(504, 349)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 54)
        Me.Button6.TabIndex = 42
        Me.Button6.Text = "Добавить"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.Location = New System.Drawing.Point(671, 263)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 54)
        Me.Button5.TabIndex = 41
        Me.Button5.Text = "Следущая"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(504, 263)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 54)
        Me.Button4.TabIndex = 40
        Me.Button4.Text = "Предыдущая"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(671, 181)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 54)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "Последняя"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Control
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button9.Location = New System.Drawing.Point(504, 181)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(141, 54)
        Me.Button9.TabIndex = 38
        Me.Button9.Text = "Первая"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Control
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button10.Location = New System.Drawing.Point(674, 506)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(138, 51)
        Me.Button10.TabIndex = 45
        Me.Button10.Text = "Закрыть"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(868, 569)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CostLabel)
        Me.Controls.Add(Me.CostTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Service_IDLabel)
        Me.Controls.Add(Me.Service_IDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form8"
        Me.Text = "Таблица ""Услуг"""
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Computer_companyDataSet As Computer_companyDataSet
    Friend WithEvents ServicesBindingSource As BindingSource
    Friend WithEvents ServicesTableAdapter As Computer_companyDataSetTableAdapters.ServicesTableAdapter
    Friend WithEvents TableAdapterManager As Computer_companyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Service_IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents CostTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
End Class
