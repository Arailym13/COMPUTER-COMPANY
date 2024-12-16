<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim Position_IDLabel As System.Windows.Forms.Label
        Dim Position_NameLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim ResponsibilitiesLabel As System.Windows.Forms.Label
        Dim RequirementsLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Computer_companyDataSet = New COMPUTER_COMPANY.Computer_companyDataSet()
        Me.PositionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionsTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.PositionsTableAdapter()
        Me.TableAdapterManager = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.TableAdapterManager()
        Me.Position_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Position_NameTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.ResponsibilitiesTextBox = New System.Windows.Forms.TextBox()
        Me.RequirementsTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Position_IDLabel = New System.Windows.Forms.Label()
        Position_NameLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        ResponsibilitiesLabel = New System.Windows.Forms.Label()
        RequirementsLabel = New System.Windows.Forms.Label()
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Position_IDLabel
        '
        Position_IDLabel.AutoSize = True
        Position_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Position_IDLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Position_IDLabel.Location = New System.Drawing.Point(77, 217)
        Position_IDLabel.Name = "Position_IDLabel"
        Position_IDLabel.Size = New System.Drawing.Size(135, 29)
        Position_IDLabel.TabIndex = 2
        Position_IDLabel.Text = "Position ID:"
        '
        'Position_NameLabel
        '
        Position_NameLabel.AutoSize = True
        Position_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Position_NameLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Position_NameLabel.Location = New System.Drawing.Point(35, 255)
        Position_NameLabel.Name = "Position_NameLabel"
        Position_NameLabel.Size = New System.Drawing.Size(177, 29)
        Position_NameLabel.TabIndex = 4
        Position_NameLabel.Text = "Position Name:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        SalaryLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        SalaryLabel.Location = New System.Drawing.Point(126, 296)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(86, 29)
        SalaryLabel.TabIndex = 6
        SalaryLabel.Text = "Salary:"
        '
        'ResponsibilitiesLabel
        '
        ResponsibilitiesLabel.AutoSize = True
        ResponsibilitiesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ResponsibilitiesLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        ResponsibilitiesLabel.Location = New System.Drawing.Point(21, 337)
        ResponsibilitiesLabel.Name = "ResponsibilitiesLabel"
        ResponsibilitiesLabel.Size = New System.Drawing.Size(191, 29)
        ResponsibilitiesLabel.TabIndex = 8
        ResponsibilitiesLabel.Text = "Responsibilities:"
        '
        'RequirementsLabel
        '
        RequirementsLabel.AutoSize = True
        RequirementsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        RequirementsLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        RequirementsLabel.Location = New System.Drawing.Point(42, 383)
        RequirementsLabel.Name = "RequirementsLabel"
        RequirementsLabel.Size = New System.Drawing.Size(170, 29)
        RequirementsLabel.TabIndex = 10
        RequirementsLabel.Text = "Requirements:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(75, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 77)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Таблица ""Должности"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Computer_companyDataSet
        '
        Me.Computer_companyDataSet.DataSetName = "Computer_companyDataSet"
        Me.Computer_companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PositionsBindingSource
        '
        Me.PositionsBindingSource.DataMember = "Positions"
        Me.PositionsBindingSource.DataSource = Me.Computer_companyDataSet
        '
        'PositionsTableAdapter
        '
        Me.PositionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Component_TypesTableAdapter = Nothing
        Me.TableAdapterManager.ComponentsTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.PositionsTableAdapter = Me.PositionsTableAdapter
        Me.TableAdapterManager.ServicesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Position_IDTextBox
        '
        Me.Position_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PositionsBindingSource, "Position_ID", True))
        Me.Position_IDTextBox.Location = New System.Drawing.Point(241, 224)
        Me.Position_IDTextBox.Name = "Position_IDTextBox"
        Me.Position_IDTextBox.Size = New System.Drawing.Size(219, 22)
        Me.Position_IDTextBox.TabIndex = 3
        '
        'Position_NameTextBox
        '
        Me.Position_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PositionsBindingSource, "Position_Name", True))
        Me.Position_NameTextBox.Location = New System.Drawing.Point(241, 262)
        Me.Position_NameTextBox.Name = "Position_NameTextBox"
        Me.Position_NameTextBox.Size = New System.Drawing.Size(219, 22)
        Me.Position_NameTextBox.TabIndex = 5
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PositionsBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(241, 303)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(219, 22)
        Me.SalaryTextBox.TabIndex = 7
        '
        'ResponsibilitiesTextBox
        '
        Me.ResponsibilitiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PositionsBindingSource, "Responsibilities", True))
        Me.ResponsibilitiesTextBox.Location = New System.Drawing.Point(241, 344)
        Me.ResponsibilitiesTextBox.Name = "ResponsibilitiesTextBox"
        Me.ResponsibilitiesTextBox.Size = New System.Drawing.Size(219, 22)
        Me.ResponsibilitiesTextBox.TabIndex = 9
        '
        'RequirementsTextBox
        '
        Me.RequirementsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PositionsBindingSource, "Requirements", True))
        Me.RequirementsTextBox.Location = New System.Drawing.Point(241, 385)
        Me.RequirementsTextBox.Name = "RequirementsTextBox"
        Me.RequirementsTextBox.Size = New System.Drawing.Size(219, 22)
        Me.RequirementsTextBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(615, 435)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 54)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Отчет "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(527, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 54)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Первая"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(694, 180)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 54)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Последняя"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(527, 262)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 54)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Предыдущая"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.Location = New System.Drawing.Point(694, 262)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 54)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Следущая"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button6.Location = New System.Drawing.Point(527, 348)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 54)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "Добавить"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Control
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button7.Location = New System.Drawing.Point(694, 348)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(141, 54)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "Удалить"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Control
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button8.Location = New System.Drawing.Point(602, 101)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(141, 54)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "Сохранить"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Control
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button10.Location = New System.Drawing.Point(697, 515)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(138, 51)
        Me.Button10.TabIndex = 33
        Me.Button10.Text = "Закрыть"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Form4
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
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(RequirementsLabel)
        Me.Controls.Add(Me.RequirementsTextBox)
        Me.Controls.Add(ResponsibilitiesLabel)
        Me.Controls.Add(Me.ResponsibilitiesTextBox)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Position_NameLabel)
        Me.Controls.Add(Me.Position_NameTextBox)
        Me.Controls.Add(Position_IDLabel)
        Me.Controls.Add(Me.Position_IDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.Text = "Таблица ""Должности"""
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Computer_companyDataSet As Computer_companyDataSet
    Friend WithEvents PositionsBindingSource As BindingSource
    Friend WithEvents PositionsTableAdapter As Computer_companyDataSetTableAdapters.PositionsTableAdapter
    Friend WithEvents TableAdapterManager As Computer_companyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Position_IDTextBox As TextBox
    Friend WithEvents Position_NameTextBox As TextBox
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents ResponsibilitiesTextBox As TextBox
    Friend WithEvents RequirementsTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button10 As Button
End Class
