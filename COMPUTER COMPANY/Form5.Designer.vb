<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim Component_IDLabel As System.Windows.Forms.Label
        Dim Type_IDLabel As System.Windows.Forms.Label
        Dim BrandLabel As System.Windows.Forms.Label
        Dim ManufacturerLabel As System.Windows.Forms.Label
        Dim Country_of_OriginLabel As System.Windows.Forms.Label
        Dim Release_DateLabel As System.Windows.Forms.Label
        Dim CharacteristicsLabel As System.Windows.Forms.Label
        Dim Warranty_PeriodLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Computer_companyDataSet = New COMPUTER_COMPANY.Computer_companyDataSet()
        Me.ComponentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComponentsTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.ComponentsTableAdapter()
        Me.TableAdapterManager = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.TableAdapterManager()
        Me.Component_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Type_IDTextBox = New System.Windows.Forms.TextBox()
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.ManufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.Country_of_OriginTextBox = New System.Windows.Forms.TextBox()
        Me.Release_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CharacteristicsTextBox = New System.Windows.Forms.TextBox()
        Me.Warranty_PeriodTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Component_IDLabel = New System.Windows.Forms.Label()
        Type_IDLabel = New System.Windows.Forms.Label()
        BrandLabel = New System.Windows.Forms.Label()
        ManufacturerLabel = New System.Windows.Forms.Label()
        Country_of_OriginLabel = New System.Windows.Forms.Label()
        Release_DateLabel = New System.Windows.Forms.Label()
        CharacteristicsLabel = New System.Windows.Forms.Label()
        Warranty_PeriodLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Component_IDLabel
        '
        Component_IDLabel.AutoSize = True
        Component_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Component_IDLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Component_IDLabel.Location = New System.Drawing.Point(50, 127)
        Component_IDLabel.Name = "Component_IDLabel"
        Component_IDLabel.Size = New System.Drawing.Size(173, 29)
        Component_IDLabel.TabIndex = 2
        Component_IDLabel.Text = "Component ID:"
        '
        'Type_IDLabel
        '
        Type_IDLabel.AutoSize = True
        Type_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Type_IDLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Type_IDLabel.Location = New System.Drawing.Point(113, 166)
        Type_IDLabel.Name = "Type_IDLabel"
        Type_IDLabel.Size = New System.Drawing.Size(103, 29)
        Type_IDLabel.TabIndex = 4
        Type_IDLabel.Text = "Type ID:"
        '
        'BrandLabel
        '
        BrandLabel.AutoSize = True
        BrandLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        BrandLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        BrandLabel.Location = New System.Drawing.Point(133, 211)
        BrandLabel.Name = "BrandLabel"
        BrandLabel.Size = New System.Drawing.Size(83, 29)
        BrandLabel.TabIndex = 6
        BrandLabel.Text = "Brand:"
        '
        'ManufacturerLabel
        '
        ManufacturerLabel.AutoSize = True
        ManufacturerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        ManufacturerLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        ManufacturerLabel.Location = New System.Drawing.Point(58, 251)
        ManufacturerLabel.Name = "ManufacturerLabel"
        ManufacturerLabel.Size = New System.Drawing.Size(158, 29)
        ManufacturerLabel.TabIndex = 8
        ManufacturerLabel.Text = "Manufacturer:"
        '
        'Country_of_OriginLabel
        '
        Country_of_OriginLabel.AutoSize = True
        Country_of_OriginLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Country_of_OriginLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Country_of_OriginLabel.Location = New System.Drawing.Point(17, 293)
        Country_of_OriginLabel.Name = "Country_of_OriginLabel"
        Country_of_OriginLabel.Size = New System.Drawing.Size(199, 29)
        Country_of_OriginLabel.TabIndex = 10
        Country_of_OriginLabel.Text = "Country of Origin:"
        '
        'Release_DateLabel
        '
        Release_DateLabel.AutoSize = True
        Release_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Release_DateLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Release_DateLabel.Location = New System.Drawing.Point(51, 331)
        Release_DateLabel.Name = "Release_DateLabel"
        Release_DateLabel.Size = New System.Drawing.Size(165, 29)
        Release_DateLabel.TabIndex = 12
        Release_DateLabel.Text = "Release Date:"
        '
        'CharacteristicsLabel
        '
        CharacteristicsLabel.AutoSize = True
        CharacteristicsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        CharacteristicsLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        CharacteristicsLabel.Location = New System.Drawing.Point(39, 372)
        CharacteristicsLabel.Name = "CharacteristicsLabel"
        CharacteristicsLabel.Size = New System.Drawing.Size(177, 29)
        CharacteristicsLabel.TabIndex = 14
        CharacteristicsLabel.Text = "Characteristics:"
        '
        'Warranty_PeriodLabel
        '
        Warranty_PeriodLabel.AutoSize = True
        Warranty_PeriodLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Warranty_PeriodLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        Warranty_PeriodLabel.Location = New System.Drawing.Point(25, 411)
        Warranty_PeriodLabel.Name = "Warranty_PeriodLabel"
        Warranty_PeriodLabel.Size = New System.Drawing.Size(191, 29)
        Warranty_PeriodLabel.TabIndex = 16
        Warranty_PeriodLabel.Text = "Warranty Period:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DescriptionLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        DescriptionLabel.Location = New System.Drawing.Point(75, 456)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(141, 29)
        DescriptionLabel.TabIndex = 18
        DescriptionLabel.Text = "Description:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        PriceLabel.ForeColor = System.Drawing.SystemColors.HotTrack
        PriceLabel.Location = New System.Drawing.Point(133, 497)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(75, 29)
        PriceLabel.TabIndex = 20
        PriceLabel.Text = "Price:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(23, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(567, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Таблица ""Комплектующие"""
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Computer_companyDataSet
        '
        Me.Computer_companyDataSet.DataSetName = "Computer_companyDataSet"
        Me.Computer_companyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Component_TypesTableAdapter = Nothing
        Me.TableAdapterManager.ComponentsTableAdapter = Me.ComponentsTableAdapter
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.PositionsTableAdapter = Nothing
        Me.TableAdapterManager.ServicesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Component_IDTextBox
        '
        Me.Component_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComponentsBindingSource, "Component_ID", True))
        Me.Component_IDTextBox.Location = New System.Drawing.Point(242, 134)
        Me.Component_IDTextBox.Name = "Component_IDTextBox"
        Me.Component_IDTextBox.Size = New System.Drawing.Size(230, 22)
        Me.Component_IDTextBox.TabIndex = 3
        '
        'Type_IDTextBox
        '
        Me.Type_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComponentsBindingSource, "Type_ID", True))
        Me.Type_IDTextBox.Location = New System.Drawing.Point(242, 173)
        Me.Type_IDTextBox.Name = "Type_IDTextBox"
        Me.Type_IDTextBox.Size = New System.Drawing.Size(230, 22)
        Me.Type_IDTextBox.TabIndex = 5
        '
        'BrandTextBox
        '
        Me.BrandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComponentsBindingSource, "Brand", True))
        Me.BrandTextBox.Location = New System.Drawing.Point(242, 218)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(230, 22)
        Me.BrandTextBox.TabIndex = 7
        '
        'ManufacturerTextBox
        '
        Me.ManufacturerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComponentsBindingSource, "Manufacturer", True))
        Me.ManufacturerTextBox.Location = New System.Drawing.Point(242, 258)
        Me.ManufacturerTextBox.Name = "ManufacturerTextBox"
        Me.ManufacturerTextBox.Size = New System.Drawing.Size(230, 22)
        Me.ManufacturerTextBox.TabIndex = 9
        '
        'Country_of_OriginTextBox
        '
        Me.Country_of_OriginTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComponentsBindingSource, "Country_of_Origin", True))
        Me.Country_of_OriginTextBox.Location = New System.Drawing.Point(242, 300)
        Me.Country_of_OriginTextBox.Name = "Country_of_OriginTextBox"
        Me.Country_of_OriginTextBox.Size = New System.Drawing.Size(230, 22)
        Me.Country_of_OriginTextBox.TabIndex = 11
        '
        'Release_DateDateTimePicker
        '
        Me.Release_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComponentsBindingSource, "Release_Date", True))
        Me.Release_DateDateTimePicker.Location = New System.Drawing.Point(242, 338)
        Me.Release_DateDateTimePicker.Name = "Release_DateDateTimePicker"
        Me.Release_DateDateTimePicker.Size = New System.Drawing.Size(236, 22)
        Me.Release_DateDateTimePicker.TabIndex = 13
        '
        'CharacteristicsTextBox
        '
        Me.CharacteristicsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComponentsBindingSource, "Characteristics", True))
        Me.CharacteristicsTextBox.Location = New System.Drawing.Point(242, 379)
        Me.CharacteristicsTextBox.Name = "CharacteristicsTextBox"
        Me.CharacteristicsTextBox.Size = New System.Drawing.Size(236, 22)
        Me.CharacteristicsTextBox.TabIndex = 15
        '
        'Warranty_PeriodTextBox
        '
        Me.Warranty_PeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComponentsBindingSource, "Warranty_Period", True))
        Me.Warranty_PeriodTextBox.Location = New System.Drawing.Point(242, 418)
        Me.Warranty_PeriodTextBox.Name = "Warranty_PeriodTextBox"
        Me.Warranty_PeriodTextBox.Size = New System.Drawing.Size(236, 22)
        Me.Warranty_PeriodTextBox.TabIndex = 17
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComponentsBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(242, 463)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(236, 22)
        Me.DescriptionTextBox.TabIndex = 19
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComponentsBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(242, 504)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(236, 22)
        Me.PriceTextBox.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Location = New System.Drawing.Point(674, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 54)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Отчет"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(509, 416)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 54)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Таблица"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Control
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button8.Location = New System.Drawing.Point(584, 91)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(141, 54)
        Me.Button8.TabIndex = 30
        Me.Button8.Text = "Сохранить"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Control
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button7.Location = New System.Drawing.Point(676, 338)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(141, 54)
        Me.Button7.TabIndex = 29
        Me.Button7.Text = "Удалить"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Control
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button6.Location = New System.Drawing.Point(509, 338)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 54)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Добавить"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Control
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.Location = New System.Drawing.Point(676, 252)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(141, 54)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "Следущая"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Control
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(509, 252)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 54)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "Предыдущая"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Control
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(676, 170)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 54)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Последняя"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Control
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button9.Location = New System.Drawing.Point(509, 170)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(141, 54)
        Me.Button9.TabIndex = 24
        Me.Button9.Text = "Первая"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.Control
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button10.Location = New System.Drawing.Point(509, 497)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(141, 54)
        Me.Button10.TabIndex = 34
        Me.Button10.Text = "Закрыть"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Control
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button11.Location = New System.Drawing.Point(676, 497)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(141, 54)
        Me.Button11.TabIndex = 35
        Me.Button11.Text = "Диаграмма"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(868, 569)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Warranty_PeriodLabel)
        Me.Controls.Add(Me.Warranty_PeriodTextBox)
        Me.Controls.Add(CharacteristicsLabel)
        Me.Controls.Add(Me.CharacteristicsTextBox)
        Me.Controls.Add(Release_DateLabel)
        Me.Controls.Add(Me.Release_DateDateTimePicker)
        Me.Controls.Add(Country_of_OriginLabel)
        Me.Controls.Add(Me.Country_of_OriginTextBox)
        Me.Controls.Add(ManufacturerLabel)
        Me.Controls.Add(Me.ManufacturerTextBox)
        Me.Controls.Add(BrandLabel)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(Type_IDLabel)
        Me.Controls.Add(Me.Type_IDTextBox)
        Me.Controls.Add(Component_IDLabel)
        Me.Controls.Add(Me.Component_IDTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form5"
        Me.Text = "Таблица ""Комплектующие"""
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Computer_companyDataSet As Computer_companyDataSet
    Friend WithEvents ComponentsBindingSource As BindingSource
    Friend WithEvents ComponentsTableAdapter As Computer_companyDataSetTableAdapters.ComponentsTableAdapter
    Friend WithEvents TableAdapterManager As Computer_companyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Component_IDTextBox As TextBox
    Friend WithEvents Type_IDTextBox As TextBox
    Friend WithEvents BrandTextBox As TextBox
    Friend WithEvents ManufacturerTextBox As TextBox
    Friend WithEvents Country_of_OriginTextBox As TextBox
    Friend WithEvents Release_DateDateTimePicker As DateTimePicker
    Friend WithEvents CharacteristicsTextBox As TextBox
    Friend WithEvents Warranty_PeriodTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
End Class
