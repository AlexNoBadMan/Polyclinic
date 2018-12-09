namespace Polyclinic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label адрес_проживанияLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label признак_льготLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.пациентDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поликлиникаDataSet = new Polyclinic.ПоликлиникаDataSet();
            this.списокРегистратурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокРегистратурыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.адрес_проживанияTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.признак_льготComboBox = new System.Windows.Forms.ComboBox();
            this.пациентTableAdapter = new Polyclinic.ПоликлиникаDataSetTableAdapters.ПациентTableAdapter();
            this.tableAdapterManager = new Polyclinic.ПоликлиникаDataSetTableAdapters.TableAdapterManager();
            this.списокРегистратурыTableAdapter = new Polyclinic.ПоликлиникаDataSetTableAdapters.СписокРегистратурыTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.схема_леченияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.схема_леченияTableAdapter = new Polyclinic.ПоликлиникаDataSetTableAdapters.Схема_леченияTableAdapter();
            this.схема_леченияDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            фИОLabel = new System.Windows.Forms.Label();
            адрес_проживанияLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            признак_льготLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.пациентDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.схема_леченияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.схема_леченияDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(26, 85);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(59, 24);
            фИОLabel.TabIndex = 2;
            фИОLabel.Text = "ФИО:";
            // 
            // адрес_проживанияLabel
            // 
            адрес_проживанияLabel.AutoSize = true;
            адрес_проживанияLabel.Location = new System.Drawing.Point(26, 120);
            адрес_проживанияLabel.Name = "адрес_проживанияLabel";
            адрес_проживанияLabel.Size = new System.Drawing.Size(188, 24);
            адрес_проживанияLabel.TabIndex = 4;
            адрес_проживанияLabel.Text = "Адрес проживания:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(26, 156);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(155, 24);
            дата_рожденияLabel.TabIndex = 6;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(26, 190);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(49, 24);
            полLabel.TabIndex = 8;
            полLabel.Text = "Пол:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(26, 228);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(95, 24);
            телефонLabel.TabIndex = 10;
            телефонLabel.Text = "Телефон:";
            // 
            // признак_льготLabel
            // 
            признак_льготLabel.AutoSize = true;
            признак_льготLabel.Location = new System.Drawing.Point(26, 263);
            признак_льготLabel.Name = "признак_льготLabel";
            признак_льготLabel.Size = new System.Drawing.Size(146, 24);
            признак_льготLabel.TabIndex = 12;
            признак_льготLabel.Text = "Признак льгот:";
            // 
            // пациентDataGridView
            // 
            this.пациентDataGridView.AllowUserToAddRows = false;
            this.пациентDataGridView.AllowUserToDeleteRows = false;
            this.пациентDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.пациентDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.пациентDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пациентDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Column1,
            this.Column2});
            this.пациентDataGridView.DataSource = this.пациентBindingSource;
            this.пациентDataGridView.Location = new System.Drawing.Point(6, 33);
            this.пациентDataGridView.Name = "пациентDataGridView";
            this.пациентDataGridView.RowHeadersVisible = false;
            this.пациентDataGridView.Size = new System.Drawing.Size(974, 220);
            this.пациентDataGridView.TabIndex = 1;
            this.пациентDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.пациентDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код пациента";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код пациента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Адрес проживания";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес проживания";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn5.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn6.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Признак льгот";
            this.dataGridViewTextBoxColumn7.HeaderText = "Признак льгот";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Добавить";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Text = "Добавить";
            this.Column1.UseColumnTextForLinkValue = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Код пациента";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Удалить";
            this.Column2.TrackVisitedState = false;
            this.Column2.UseColumnTextForLinkValue = true;
            // 
            // пациентBindingSource
            // 
            this.пациентBindingSource.DataMember = "Пациент";
            this.пациентBindingSource.DataSource = this.поликлиникаDataSet;
            // 
            // поликлиникаDataSet
            // 
            this.поликлиникаDataSet.DataSetName = "ПоликлиникаDataSet";
            this.поликлиникаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокРегистратурыBindingSource
            // 
            this.списокРегистратурыBindingSource.DataMember = "Пациент_СписокРегистратуры";
            this.списокРегистратурыBindingSource.DataSource = this.пациентBindingSource;
            // 
            // списокРегистратурыDataGridView
            // 
            this.списокРегистратурыDataGridView.AutoGenerateColumns = false;
            this.списокРегистратурыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.списокРегистратурыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.списокРегистратурыDataGridView.DataSource = this.списокРегистратурыBindingSource;
            this.списокРегистратурыDataGridView.Location = new System.Drawing.Point(8, 28);
            this.списокРегистратурыDataGridView.Name = "списокРегистратурыDataGridView";
            this.списокРегистратурыDataGridView.RowHeadersVisible = false;
            this.списокРегистратурыDataGridView.Size = new System.Drawing.Size(320, 159);
            this.списокРегистратурыDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Код пациента";
            this.dataGridViewTextBoxColumn8.HeaderText = "Код пациента";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Пациент";
            this.dataGridViewTextBoxColumn9.HeaderText = "Пациент";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Код врача";
            this.dataGridViewTextBoxColumn10.HeaderText = "Код врача";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Лечащий врач";
            this.dataGridViewTextBoxColumn11.HeaderText = "Лечащий врач";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Дата и время приёма";
            this.dataGridViewTextBoxColumn12.HeaderText = "Дата и время приёма";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.пациентDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(4, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 269);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о пациенте:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.списокРегистратурыDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(4, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 337);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(фИОLabel);
            this.groupBox3.Controls.Add(this.фИОTextBox);
            this.groupBox3.Controls.Add(адрес_проживанияLabel);
            this.groupBox3.Controls.Add(this.адрес_проживанияTextBox);
            this.groupBox3.Controls.Add(дата_рожденияLabel);
            this.groupBox3.Controls.Add(this.дата_рожденияDateTimePicker);
            this.groupBox3.Controls.Add(полLabel);
            this.groupBox3.Controls.Add(this.полComboBox);
            this.groupBox3.Controls.Add(телефонLabel);
            this.groupBox3.Controls.Add(this.телефонTextBox);
            this.groupBox3.Controls.Add(признак_льготLabel);
            this.groupBox3.Controls.Add(this.признак_льготComboBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(1010, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 360);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавить нового пациента:";
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(220, 82);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(200, 29);
            this.фИОTextBox.TabIndex = 3;
            // 
            // адрес_проживанияTextBox
            // 
            this.адрес_проживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентBindingSource, "Адрес проживания", true));
            this.адрес_проживанияTextBox.Location = new System.Drawing.Point(220, 117);
            this.адрес_проживанияTextBox.Name = "адрес_проживанияTextBox";
            this.адрес_проживанияTextBox.Size = new System.Drawing.Size(200, 29);
            this.адрес_проживанияTextBox.TabIndex = 5;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.пациентBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(220, 152);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.дата_рожденияDateTimePicker.TabIndex = 7;
            // 
            // полComboBox
            // 
            this.полComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентBindingSource, "Пол", true));
            this.полComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.полComboBox.FormattingEnabled = true;
            this.полComboBox.Items.AddRange(new object[] {
            "Муж.",
            "Жен."});
            this.полComboBox.Location = new System.Drawing.Point(220, 187);
            this.полComboBox.Name = "полComboBox";
            this.полComboBox.Size = new System.Drawing.Size(200, 32);
            this.полComboBox.TabIndex = 9;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(220, 225);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(200, 29);
            this.телефонTextBox.TabIndex = 11;
            // 
            // признак_льготComboBox
            // 
            this.признак_льготComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентBindingSource, "Признак льгот", true));
            this.признак_льготComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.признак_льготComboBox.FormattingEnabled = true;
            this.признак_льготComboBox.Items.AddRange(new object[] {
            "Да ",
            "Нет"});
            this.признак_льготComboBox.Location = new System.Drawing.Point(220, 260);
            this.признак_льготComboBox.Name = "признак_льготComboBox";
            this.признак_льготComboBox.Size = new System.Drawing.Size(200, 32);
            this.признак_льготComboBox.TabIndex = 13;
            // 
            // пациентTableAdapter
            // 
            this.пациентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Polyclinic.ПоликлиникаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Амбулаторная_картаTableAdapter = null;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.ДиагнозыTableAdapter = null;
            this.tableAdapterManager.Категория_врачебной_специальностиTableAdapter = null;
            this.tableAdapterManager.ПациентTableAdapter = this.пациентTableAdapter;
            this.tableAdapterManager.РегистратураTableAdapter = null;
            // 
            // списокРегистратурыTableAdapter
            // 
            this.списокРегистратурыTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.схема_леченияDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(411, 305);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(593, 301);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // схема_леченияBindingSource
            // 
            this.схема_леченияBindingSource.DataMember = "Пациент_Схема лечения";
            this.схема_леченияBindingSource.DataSource = this.пациентBindingSource;
            // 
            // схема_леченияTableAdapter
            // 
            this.схема_леченияTableAdapter.ClearBeforeFill = true;
            // 
            // схема_леченияDataGridView
            // 
            this.схема_леченияDataGridView.AutoGenerateColumns = false;
            this.схема_леченияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.схема_леченияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.схема_леченияDataGridView.DataSource = this.схема_леченияBindingSource;
            this.схема_леченияDataGridView.Location = new System.Drawing.Point(36, 28);
            this.схема_леченияDataGridView.Name = "схема_леченияDataGridView";
            this.схема_леченияDataGridView.Size = new System.Drawing.Size(537, 159);
            this.схема_леченияDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Код пациента";
            this.dataGridViewTextBoxColumn13.HeaderText = "Код пациента";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Код врача";
            this.dataGridViewTextBoxColumn14.HeaderText = "Код врача";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Код диагноза";
            this.dataGridViewTextBoxColumn15.HeaderText = "Код диагноза";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn16.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Описание схемы лечения и назначений";
            this.dataGridViewTextBoxColumn17.HeaderText = "Описание схемы лечения и назначений";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1020, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1020, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.пациентDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.схема_леченияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.схема_леченияDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ПоликлиникаDataSet поликлиникаDataSet;
        private System.Windows.Forms.BindingSource пациентBindingSource;
        private ПоликлиникаDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private ПоликлиникаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView пациентDataGridView;
        private System.Windows.Forms.BindingSource списокРегистратурыBindingSource;
        private ПоликлиникаDataSetTableAdapters.СписокРегистратурыTableAdapter списокРегистратурыTableAdapter;
        private System.Windows.Forms.DataGridView списокРегистратурыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox адрес_проживанияTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.ComboBox полComboBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.ComboBox признак_льготComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.BindingSource схема_леченияBindingSource;
        private ПоликлиникаDataSetTableAdapters.Схема_леченияTableAdapter схема_леченияTableAdapter;
        private System.Windows.Forms.DataGridView схема_леченияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

