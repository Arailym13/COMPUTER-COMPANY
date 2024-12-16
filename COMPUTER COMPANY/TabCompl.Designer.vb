<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TabCompl
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
        Me.ComponentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComponentsTableAdapter = New COMPUTER_COMPANY.Computer_companyDataSetTableAdapters.ComponentsTableAdapter()
        Me.ComponentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountryofOriginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharacteristicsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WarrantyPeriodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComponentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ComponentIDDataGridViewTextBoxColumn, Me.TypeIDDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.CountryofOriginDataGridViewTextBoxColumn, Me.ReleaseDateDataGridViewTextBoxColumn, Me.CharacteristicsDataGridViewTextBoxColumn, Me.WarrantyPeriodDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ComponentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 113)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(673, 348)
        Me.DataGridView1.TabIndex = 25
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
        Me.GroupBox1.Location = New System.Drawing.Point(701, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(409, 496)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сортировка "
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(24, 381)
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
        Me.ListBox1.Items.AddRange(New Object() {"Код комплектующего", "Код вида", "Марка", "Фирма производитель", "Страна производитель", "Дата выпуска", "Характеристики", "Срок гарантия", "Описание", "Цена"})
        Me.ListBox1.Location = New System.Drawing.Point(22, 93)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(335, 246)
        Me.ListBox1.TabIndex = 14
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(24, 346)
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
        Me.Button1.Location = New System.Drawing.Point(90, 416)
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
        Me.Label2.Location = New System.Drawing.Point(19, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Поле для сортировки"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ComponentsBindingSource1
        Me.ComboBox1.DisplayMember = "Brand"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(313, 548)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(316, 24)
        Me.ComboBox1.TabIndex = 22
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button5.Location = New System.Drawing.Point(909, 602)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(138, 51)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Закрыть"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(222, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Таблица  Комплектующие"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.Location = New System.Drawing.Point(723, 602)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 51)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Найти"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.Location = New System.Drawing.Point(909, 545)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(138, 51)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Показать все"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(723, 545)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 51)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Фильтровать"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(205, 592)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Критерии"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(243, 546)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 22)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Brand"
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
        'ComponentIDDataGridViewTextBoxColumn
        '
        Me.ComponentIDDataGridViewTextBoxColumn.DataPropertyName = "Component_ID"
        Me.ComponentIDDataGridViewTextBoxColumn.HeaderText = "Component_ID"
        Me.ComponentIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ComponentIDDataGridViewTextBoxColumn.Name = "ComponentIDDataGridViewTextBoxColumn"
        Me.ComponentIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComponentIDDataGridViewTextBoxColumn.Width = 125
        '
        'TypeIDDataGridViewTextBoxColumn
        '
        Me.TypeIDDataGridViewTextBoxColumn.DataPropertyName = "Type_ID"
        Me.TypeIDDataGridViewTextBoxColumn.HeaderText = "Type_ID"
        Me.TypeIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TypeIDDataGridViewTextBoxColumn.Name = "TypeIDDataGridViewTextBoxColumn"
        Me.TypeIDDataGridViewTextBoxColumn.Width = 125
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "Brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.BrandDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        Me.BrandDataGridViewTextBoxColumn.Width = 125
        '
        'ManufacturerDataGridViewTextBoxColumn
        '
        Me.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn"
        Me.ManufacturerDataGridViewTextBoxColumn.Width = 125
        '
        'CountryofOriginDataGridViewTextBoxColumn
        '
        Me.CountryofOriginDataGridViewTextBoxColumn.DataPropertyName = "Country_of_Origin"
        Me.CountryofOriginDataGridViewTextBoxColumn.HeaderText = "Country_of_Origin"
        Me.CountryofOriginDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CountryofOriginDataGridViewTextBoxColumn.Name = "CountryofOriginDataGridViewTextBoxColumn"
        Me.CountryofOriginDataGridViewTextBoxColumn.Width = 125
        '
        'ReleaseDateDataGridViewTextBoxColumn
        '
        Me.ReleaseDateDataGridViewTextBoxColumn.DataPropertyName = "Release_Date"
        Me.ReleaseDateDataGridViewTextBoxColumn.HeaderText = "Release_Date"
        Me.ReleaseDateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ReleaseDateDataGridViewTextBoxColumn.Name = "ReleaseDateDataGridViewTextBoxColumn"
        Me.ReleaseDateDataGridViewTextBoxColumn.Width = 125
        '
        'CharacteristicsDataGridViewTextBoxColumn
        '
        Me.CharacteristicsDataGridViewTextBoxColumn.DataPropertyName = "Characteristics"
        Me.CharacteristicsDataGridViewTextBoxColumn.HeaderText = "Characteristics"
        Me.CharacteristicsDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CharacteristicsDataGridViewTextBoxColumn.Name = "CharacteristicsDataGridViewTextBoxColumn"
        Me.CharacteristicsDataGridViewTextBoxColumn.Width = 125
        '
        'WarrantyPeriodDataGridViewTextBoxColumn
        '
        Me.WarrantyPeriodDataGridViewTextBoxColumn.DataPropertyName = "Warranty_Period"
        Me.WarrantyPeriodDataGridViewTextBoxColumn.HeaderText = "Warranty_Period"
        Me.WarrantyPeriodDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WarrantyPeriodDataGridViewTextBoxColumn.Name = "WarrantyPeriodDataGridViewTextBoxColumn"
        Me.WarrantyPeriodDataGridViewTextBoxColumn.Width = 125
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 125
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.Width = 125
        '
        'ComponentsBindingSource1
        '
        Me.ComponentsBindingSource1.DataMember = "Components"
        Me.ComponentsBindingSource1.DataSource = Me.Computer_companyDataSet
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(313, 603)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(316, 22)
        Me.TextBox1.TabIndex = 26
        '
        'TabCompl
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
        Me.Name = "TabCompl"
        Me.Text = "Form18"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Computer_companyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents ComponentsBindingSource As BindingSource
    Friend WithEvents ComponentsTableAdapter As Computer_companyDataSetTableAdapters.ComponentsTableAdapter
    Friend WithEvents ComponentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CountryofOriginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CharacteristicsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WarrantyPeriodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComponentsBindingSource1 As BindingSource
    Friend WithEvents TextBox1 As TextBox
End Class
