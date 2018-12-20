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
            System.Windows.Forms.Label признак_льготLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label адрес_проживанияLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label код_пациентаLabel;
            System.Windows.Forms.Label код_врачаLabel;
            System.Windows.Forms.Label дата_и_время_приёмаLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.регистратураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polyDataSet = new Polyclinic.PolyDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.схема_леченияDataGridView = new System.Windows.Forms.DataGridView();
            this.схемаЛеченияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.признак_льготComboBox = new System.Windows.Forms.ComboBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.полComboBox = new System.Windows.Forms.ComboBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.адрес_проживанияTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.списокРегистратурыDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПациентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пациентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.врачDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИВремяПриёмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistryChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.RegistryDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.списокРегистратурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.пациентDataGridView = new System.Windows.Forms.DataGridView();
            this.кодПациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.признакЛьготDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PatientDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.пациентTableAdapter = new Polyclinic.PolyDataSetTableAdapters.ПациентTableAdapter();
            this.tableAdapterManager = new Polyclinic.PolyDataSetTableAdapters.TableAdapterManager();
            this.списокРегистратурыTableAdapter = new Polyclinic.PolyDataSetTableAdapters.СписокРегистратурыTableAdapter();
            this.регистратураTableAdapter = new Polyclinic.PolyDataSetTableAdapters.РегистратураTableAdapter();
            this.врачиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.врачиTableAdapter = new Polyclinic.PolyDataSetTableAdapters.ВрачиTableAdapter();
            this.врачиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistryGroup = new System.Windows.Forms.GroupBox();
            this.RegistryCancel = new System.Windows.Forms.Button();
            this.RegistrySave = new System.Windows.Forms.Button();
            this.код_пациентаComboBox = new System.Windows.Forms.ComboBox();
            this.код_врачаComboBox = new System.Windows.Forms.ComboBox();
            this.дата_и_время_приёмаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.схемаЛеченияTableAdapter = new Polyclinic.PolyDataSetTableAdapters.СхемаЛеченияTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПациентаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодВрачаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДиагнозаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            признак_льготLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            адрес_проживанияLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            код_пациентаLabel = new System.Windows.Forms.Label();
            код_врачаLabel = new System.Windows.Forms.Label();
            дата_и_время_приёмаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.регистратураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.схема_леченияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.схемаЛеченияBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пациентDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиDataGridView)).BeginInit();
            this.RegistryGroup.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(26, 228);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(95, 24);
            телефонLabel.TabIndex = 10;
            телефонLabel.Text = "Телефон:";
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
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(26, 156);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(155, 24);
            дата_рожденияLabel.TabIndex = 6;
            дата_рожденияLabel.Text = "Дата рождения:";
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
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(26, 85);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(59, 24);
            фИОLabel.TabIndex = 2;
            фИОLabel.Text = "ФИО:";
            // 
            // код_пациентаLabel
            // 
            код_пациентаLabel.AutoSize = true;
            код_пациентаLabel.Location = new System.Drawing.Point(21, 58);
            код_пациентаLabel.Name = "код_пациентаLabel";
            код_пациентаLabel.Size = new System.Drawing.Size(140, 24);
            код_пациентаLabel.TabIndex = 2;
            код_пациентаLabel.Text = "Код пациента:";
            // 
            // код_врачаLabel
            // 
            код_врачаLabel.AutoSize = true;
            код_врачаLabel.Location = new System.Drawing.Point(21, 99);
            код_врачаLabel.Name = "код_врачаLabel";
            код_врачаLabel.Size = new System.Drawing.Size(107, 24);
            код_врачаLabel.TabIndex = 4;
            код_врачаLabel.Text = "Код врача:";
            // 
            // дата_и_время_приёмаLabel
            // 
            дата_и_время_приёмаLabel.AutoSize = true;
            дата_и_время_приёмаLabel.Location = new System.Drawing.Point(21, 141);
            дата_и_время_приёмаLabel.Name = "дата_и_время_приёмаLabel";
            дата_и_время_приёмаLabel.Size = new System.Drawing.Size(208, 24);
            дата_и_время_приёмаLabel.TabIndex = 6;
            дата_и_время_приёмаLabel.Text = "Дата и время приёма:";
            // 
            // регистратураBindingSource
            // 
            this.регистратураBindingSource.DataMember = "FK_Регистратура_Пациент";
            this.регистратураBindingSource.DataSource = this.пациентBindingSource;
            // 
            // пациентBindingSource
            // 
            this.пациентBindingSource.DataMember = "Пациент";
            this.пациентBindingSource.DataSource = this.polyDataSet;
            // 
            // polyDataSet
            // 
            this.polyDataSet.DataSetName = "PolyDataSet";
            this.polyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // схема_леченияDataGridView
            // 
            this.схема_леченияDataGridView.AllowUserToAddRows = false;
            this.схема_леченияDataGridView.AllowUserToDeleteRows = false;
            this.схема_леченияDataGridView.AutoGenerateColumns = false;
            this.схема_леченияDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.схема_леченияDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.схема_леченияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.схема_леченияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.кодПациентаDataGridViewTextBoxColumn2,
            this.кодВрачаDataGridViewTextBoxColumn1,
            this.кодДиагнозаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn});
            this.схема_леченияDataGridView.DataSource = this.схемаЛеченияBindingSource;
            this.схема_леченияDataGridView.Location = new System.Drawing.Point(6, 22);
            this.схема_леченияDataGridView.Name = "схема_леченияDataGridView";
            this.схема_леченияDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.схема_леченияDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.схема_леченияDataGridView.RowHeadersVisible = false;
            this.схема_леченияDataGridView.RowTemplate.Height = 24;
            this.схема_леченияDataGridView.Size = new System.Drawing.Size(475, 272);
            this.схема_леченияDataGridView.TabIndex = 0;
            // 
            // схемаЛеченияBindingSource
            // 
            this.схемаЛеченияBindingSource.DataMember = "Пациент_СхемаЛечения";
            this.схемаЛеченияBindingSource.DataSource = this.пациентBindingSource;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.схема_леченияDataGridView);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(499, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(487, 300);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Диагнозы:";
            // 
            // признак_льготComboBox
            // 
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
            // телефонTextBox
            // 
            this.телефонTextBox.Location = new System.Drawing.Point(220, 225);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(200, 29);
            this.телефонTextBox.TabIndex = 11;
            // 
            // полComboBox
            // 
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
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(220, 152);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.дата_рожденияDateTimePicker.TabIndex = 7;
            // 
            // адрес_проживанияTextBox
            // 
            this.адрес_проживанияTextBox.Location = new System.Drawing.Point(220, 117);
            this.адрес_проживанияTextBox.Name = "адрес_проживанияTextBox";
            this.адрес_проживанияTextBox.Size = new System.Drawing.Size(200, 29);
            this.адрес_проживанияTextBox.TabIndex = 5;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.Location = new System.Drawing.Point(220, 82);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(200, 29);
            this.фИОTextBox.TabIndex = 3;
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
            this.groupBox3.Location = new System.Drawing.Point(1196, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 360);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавить нового пациента:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.списокРегистратурыDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(4, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 300);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Приёмы:";
            // 
            // списокРегистратурыDataGridView
            // 
            this.списокРегистратурыDataGridView.AllowUserToAddRows = false;
            this.списокРегистратурыDataGridView.AllowUserToDeleteRows = false;
            this.списокРегистратурыDataGridView.AutoGenerateColumns = false;
            this.списокРегистратурыDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.списокРегистратурыDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.списокРегистратурыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.списокРегистратурыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.кодПациентаDataGridViewTextBoxColumn1,
            this.пациентDataGridViewTextBoxColumn,
            this.кодВрачаDataGridViewTextBoxColumn,
            this.врачDataGridViewTextBoxColumn,
            this.датаИВремяПриёмаDataGridViewTextBoxColumn,
            this.RegistryChangeColumn,
            this.RegistryDeleteColumn});
            this.списокРегистратурыDataGridView.DataSource = this.списокРегистратурыBindingSource;
            this.списокРегистратурыDataGridView.Location = new System.Drawing.Point(6, 22);
            this.списокРегистратурыDataGridView.Name = "списокРегистратурыDataGridView";
            this.списокРегистратурыDataGridView.ReadOnly = true;
            this.списокРегистратурыDataGridView.RowHeadersVisible = false;
            this.списокРегистратурыDataGridView.RowTemplate.Height = 25;
            this.списокРегистратурыDataGridView.Size = new System.Drawing.Size(475, 272);
            this.списокРегистратурыDataGridView.TabIndex = 0;
            this.списокРегистратурыDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.списокРегистратурыDataGridView_CellClick);
            this.списокРегистратурыDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.списокРегистратурыDataGridView_CellContentClick);
            this.списокРегистратурыDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.списокРегистратурыDataGridView_CellMouseEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // кодПациентаDataGridViewTextBoxColumn1
            // 
            this.кодПациентаDataGridViewTextBoxColumn1.DataPropertyName = "Код пациента";
            this.кодПациентаDataGridViewTextBoxColumn1.HeaderText = "Код пациента";
            this.кодПациентаDataGridViewTextBoxColumn1.Name = "кодПациентаDataGridViewTextBoxColumn1";
            this.кодПациентаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодПациентаDataGridViewTextBoxColumn1.Visible = false;
            // 
            // пациентDataGridViewTextBoxColumn
            // 
            this.пациентDataGridViewTextBoxColumn.DataPropertyName = "Пациент";
            this.пациентDataGridViewTextBoxColumn.HeaderText = "Пациент";
            this.пациентDataGridViewTextBoxColumn.Name = "пациентDataGridViewTextBoxColumn";
            this.пациентDataGridViewTextBoxColumn.ReadOnly = true;
            this.пациентDataGridViewTextBoxColumn.Visible = false;
            // 
            // кодВрачаDataGridViewTextBoxColumn
            // 
            this.кодВрачаDataGridViewTextBoxColumn.DataPropertyName = "Код врача";
            this.кодВрачаDataGridViewTextBoxColumn.HeaderText = "Код врача";
            this.кодВрачаDataGridViewTextBoxColumn.Name = "кодВрачаDataGridViewTextBoxColumn";
            this.кодВрачаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодВрачаDataGridViewTextBoxColumn.Visible = false;
            // 
            // врачDataGridViewTextBoxColumn
            // 
            this.врачDataGridViewTextBoxColumn.DataPropertyName = "Врач";
            this.врачDataGridViewTextBoxColumn.FillWeight = 230.3357F;
            this.врачDataGridViewTextBoxColumn.HeaderText = "Врач";
            this.врачDataGridViewTextBoxColumn.Name = "врачDataGridViewTextBoxColumn";
            this.врачDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаИВремяПриёмаDataGridViewTextBoxColumn
            // 
            this.датаИВремяПриёмаDataGridViewTextBoxColumn.DataPropertyName = "Дата и время приёма";
            this.датаИВремяПриёмаDataGridViewTextBoxColumn.FillWeight = 108F;
            this.датаИВремяПриёмаDataGridViewTextBoxColumn.HeaderText = "Приём";
            this.датаИВремяПриёмаDataGridViewTextBoxColumn.Name = "датаИВремяПриёмаDataGridViewTextBoxColumn";
            this.датаИВремяПриёмаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RegistryChangeColumn
            // 
            this.RegistryChangeColumn.FillWeight = 20F;
            this.RegistryChangeColumn.HeaderText = "Редактировать";
            this.RegistryChangeColumn.Image = global::Polyclinic.Properties.Resources.edit_icon;
            this.RegistryChangeColumn.Name = "RegistryChangeColumn";
            this.RegistryChangeColumn.ReadOnly = true;
            this.RegistryChangeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RegistryChangeColumn.ToolTipText = "Редактировать";
            // 
            // RegistryDeleteColumn
            // 
            this.RegistryDeleteColumn.FillWeight = 20F;
            this.RegistryDeleteColumn.HeaderText = "Удалить";
            this.RegistryDeleteColumn.Image = global::Polyclinic.Properties.Resources.delete_icon;
            this.RegistryDeleteColumn.Name = "RegistryDeleteColumn";
            this.RegistryDeleteColumn.ReadOnly = true;
            this.RegistryDeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RegistryDeleteColumn.ToolTipText = "Удалить";
            // 
            // списокРегистратурыBindingSource
            // 
            this.списокРегистратурыBindingSource.DataMember = "FK_Пациент_СписокРегистратуры";
            this.списокРегистратурыBindingSource.DataSource = this.пациентBindingSource;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.пациентDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 269);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о пациенте:";
            // 
            // пациентDataGridView
            // 
            this.пациентDataGridView.AllowUserToAddRows = false;
            this.пациентDataGridView.AllowUserToDeleteRows = false;
            this.пациентDataGridView.AutoGenerateColumns = false;
            this.пациентDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.пациентDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.пациентDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пациентDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПациентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.адресПроживанияDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.признакЛьготDataGridViewTextBoxColumn,
            this.PatientChangeColumn,
            this.PatientDeleteColumn});
            this.пациентDataGridView.DataSource = this.пациентBindingSource;
            this.пациентDataGridView.Location = new System.Drawing.Point(6, 25);
            this.пациентDataGridView.Name = "пациентDataGridView";
            this.пациентDataGridView.ReadOnly = true;
            this.пациентDataGridView.RowHeadersVisible = false;
            this.пациентDataGridView.RowTemplate.Height = 25;
            this.пациентDataGridView.Size = new System.Drawing.Size(968, 238);
            this.пациентDataGridView.TabIndex = 1;
            this.пациентDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.пациентDataGridView_CellContentClick);
            // 
            // кодПациентаDataGridViewTextBoxColumn
            // 
            this.кодПациентаDataGridViewTextBoxColumn.DataPropertyName = "Код пациента";
            this.кодПациентаDataGridViewTextBoxColumn.HeaderText = "Код пациента";
            this.кодПациентаDataGridViewTextBoxColumn.Name = "кодПациентаDataGridViewTextBoxColumn";
            this.кодПациентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодПациентаDataGridViewTextBoxColumn.Visible = false;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.FillWeight = 296.1124F;
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресПроживанияDataGridViewTextBoxColumn
            // 
            this.адресПроживанияDataGridViewTextBoxColumn.DataPropertyName = "Адрес проживания";
            this.адресПроживанияDataGridViewTextBoxColumn.FillWeight = 140F;
            this.адресПроживанияDataGridViewTextBoxColumn.HeaderText = "Адрес проживания";
            this.адресПроживанияDataGridViewTextBoxColumn.Name = "адресПроживанияDataGridViewTextBoxColumn";
            this.адресПроживанияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаРожденияDataGridViewTextBoxColumn
            // 
            this.датаРожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата рождения";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.датаРожденияDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.датаРожденияDataGridViewTextBoxColumn.FillWeight = 90F;
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.полDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.полDataGridViewTextBoxColumn.FillWeight = 40F;
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.телефонDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.телефонDataGridViewTextBoxColumn.FillWeight = 90F;
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // признакЛьготDataGridViewTextBoxColumn
            // 
            this.признакЛьготDataGridViewTextBoxColumn.DataPropertyName = "Признак льгот";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.признакЛьготDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.признакЛьготDataGridViewTextBoxColumn.FillWeight = 57F;
            this.признакЛьготDataGridViewTextBoxColumn.HeaderText = "Льготы";
            this.признакЛьготDataGridViewTextBoxColumn.Name = "признакЛьготDataGridViewTextBoxColumn";
            this.признакЛьготDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PatientChangeColumn
            // 
            this.PatientChangeColumn.FillWeight = 19.6F;
            this.PatientChangeColumn.HeaderText = "Редактировать";
            this.PatientChangeColumn.Image = global::Polyclinic.Properties.Resources.edit_icon;
            this.PatientChangeColumn.Name = "PatientChangeColumn";
            this.PatientChangeColumn.ReadOnly = true;
            this.PatientChangeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PatientDeleteColumn
            // 
            this.PatientDeleteColumn.FillWeight = 19.7F;
            this.PatientDeleteColumn.HeaderText = "Удалить";
            this.PatientDeleteColumn.Image = global::Polyclinic.Properties.Resources.delete_icon;
            this.PatientDeleteColumn.Name = "PatientDeleteColumn";
            this.PatientDeleteColumn.ReadOnly = true;
            this.PatientDeleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // пациентTableAdapter
            // 
            this.пациентTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Polyclinic.PolyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // регистратураTableAdapter
            // 
            this.регистратураTableAdapter.ClearBeforeFill = true;
            // 
            // врачиBindingSource
            // 
            this.врачиBindingSource.DataMember = "Врачи";
            this.врачиBindingSource.DataSource = this.polyDataSet;
            // 
            // врачиTableAdapter
            // 
            this.врачиTableAdapter.ClearBeforeFill = true;
            // 
            // врачиDataGridView
            // 
            this.врачиDataGridView.AutoGenerateColumns = false;
            this.врачиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.врачиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.врачиDataGridView.DataSource = this.врачиBindingSource;
            this.врачиDataGridView.Location = new System.Drawing.Point(407, 677);
            this.врачиDataGridView.Name = "врачиDataGridView";
            this.врачиDataGridView.Size = new System.Drawing.Size(472, 220);
            this.врачиDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код врача";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код врача";
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Код категории специальности";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код категории специальности";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // RegistryGroup
            // 
            this.RegistryGroup.Controls.Add(this.RegistryCancel);
            this.RegistryGroup.Controls.Add(this.RegistrySave);
            this.RegistryGroup.Controls.Add(код_пациентаLabel);
            this.RegistryGroup.Controls.Add(this.код_пациентаComboBox);
            this.RegistryGroup.Controls.Add(код_врачаLabel);
            this.RegistryGroup.Controls.Add(this.код_врачаComboBox);
            this.RegistryGroup.Controls.Add(дата_и_время_приёмаLabel);
            this.RegistryGroup.Controls.Add(this.дата_и_время_приёмаDateTimePicker);
            this.RegistryGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistryGroup.Location = new System.Drawing.Point(1196, 500);
            this.RegistryGroup.Name = "RegistryGroup";
            this.RegistryGroup.Size = new System.Drawing.Size(561, 245);
            this.RegistryGroup.TabIndex = 16;
            this.RegistryGroup.TabStop = false;
            this.RegistryGroup.Text = "Регистраутра";
            // 
            // RegistryCancel
            // 
            this.RegistryCancel.Location = new System.Drawing.Point(295, 187);
            this.RegistryCancel.Name = "RegistryCancel";
            this.RegistryCancel.Size = new System.Drawing.Size(125, 32);
            this.RegistryCancel.TabIndex = 9;
            this.RegistryCancel.Text = "Отмена";
            this.RegistryCancel.UseVisualStyleBackColor = true;
            this.RegistryCancel.Click += new System.EventHandler(this.RegistryCancel_Click);
            // 
            // RegistrySave
            // 
            this.RegistrySave.Location = new System.Drawing.Point(128, 187);
            this.RegistrySave.Name = "RegistrySave";
            this.RegistrySave.Size = new System.Drawing.Size(125, 32);
            this.RegistrySave.TabIndex = 8;
            this.RegistrySave.Text = "Сохранить";
            this.RegistrySave.UseVisualStyleBackColor = true;
            this.RegistrySave.Click += new System.EventHandler(this.RegistrySave_Click);
            // 
            // код_пациентаComboBox
            // 
            this.код_пациентаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.регистратураBindingSource, "Код пациента", true));
            this.код_пациентаComboBox.DataSource = this.пациентBindingSource;
            this.код_пациентаComboBox.DisplayMember = "ФИО";
            this.код_пациентаComboBox.FormattingEnabled = true;
            this.код_пациентаComboBox.Location = new System.Drawing.Point(235, 55);
            this.код_пациентаComboBox.Name = "код_пациентаComboBox";
            this.код_пациентаComboBox.Size = new System.Drawing.Size(300, 32);
            this.код_пациентаComboBox.TabIndex = 3;
            this.код_пациентаComboBox.ValueMember = "Код пациента";
            // 
            // код_врачаComboBox
            // 
            this.код_врачаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.регистратураBindingSource, "Код врача", true));
            this.код_врачаComboBox.DataSource = this.врачиBindingSource;
            this.код_врачаComboBox.DisplayMember = "ФИО";
            this.код_врачаComboBox.FormattingEnabled = true;
            this.код_врачаComboBox.Location = new System.Drawing.Point(235, 96);
            this.код_врачаComboBox.Name = "код_врачаComboBox";
            this.код_врачаComboBox.Size = new System.Drawing.Size(300, 32);
            this.код_врачаComboBox.TabIndex = 5;
            this.код_врачаComboBox.ValueMember = "Код врача";
            // 
            // дата_и_время_приёмаDateTimePicker
            // 
            this.дата_и_время_приёмаDateTimePicker.CustomFormat = "d.MM.yyyy HH:m";
            this.дата_и_время_приёмаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.регистратураBindingSource, "Дата и время приёма", true));
            this.дата_и_время_приёмаDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.дата_и_время_приёмаDateTimePicker.Location = new System.Drawing.Point(235, 137);
            this.дата_и_время_приёмаDateTimePicker.Name = "дата_и_время_приёмаDateTimePicker";
            this.дата_и_время_приёмаDateTimePicker.Size = new System.Drawing.Size(300, 29);
            this.дата_и_время_приёмаDateTimePicker.TabIndex = 7;
            // 
            // схемаЛеченияTableAdapter
            // 
            this.схемаЛеченияTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(4, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 621);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поликлиника";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 588);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // кодПациентаDataGridViewTextBoxColumn2
            // 
            this.кодПациентаDataGridViewTextBoxColumn2.DataPropertyName = "Код пациента";
            this.кодПациентаDataGridViewTextBoxColumn2.HeaderText = "Код пациента";
            this.кодПациентаDataGridViewTextBoxColumn2.Name = "кодПациентаDataGridViewTextBoxColumn2";
            this.кодПациентаDataGridViewTextBoxColumn2.ReadOnly = true;
            this.кодПациентаDataGridViewTextBoxColumn2.Visible = false;
            // 
            // кодВрачаDataGridViewTextBoxColumn1
            // 
            this.кодВрачаDataGridViewTextBoxColumn1.DataPropertyName = "Код врача";
            this.кодВрачаDataGridViewTextBoxColumn1.HeaderText = "Код врача";
            this.кодВрачаDataGridViewTextBoxColumn1.Name = "кодВрачаDataGridViewTextBoxColumn1";
            this.кодВрачаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодВрачаDataGridViewTextBoxColumn1.Visible = false;
            // 
            // кодДиагнозаDataGridViewTextBoxColumn
            // 
            this.кодДиагнозаDataGridViewTextBoxColumn.DataPropertyName = "Код диагноза";
            this.кодДиагнозаDataGridViewTextBoxColumn.FillWeight = 28.93401F;
            this.кодДиагнозаDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодДиагнозаDataGridViewTextBoxColumn.Name = "кодДиагнозаDataGridViewTextBoxColumn";
            this.кодДиагнозаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодДиагнозаDataGridViewTextBoxColumn.Visible = false;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.FillWeight = 52.54832F;
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Диагноз";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn
            // 
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.DataPropertyName = "Описание схемы лечения и назначений";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.FillWeight = 218.5177F;
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.HeaderText = "Схемы лечения и назначения";
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.Name = "описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn";
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.RegistryGroup);
            this.Controls.Add(this.врачиDataGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.регистратураBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.схема_леченияDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.схемаЛеченияBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.пациентDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиDataGridView)).EndInit();
            this.RegistryGroup.ResumeLayout(false);
            this.RegistryGroup.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView схема_леченияDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox признак_льготComboBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.ComboBox полComboBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox адрес_проживанияTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView пациентDataGridView;
        private System.Windows.Forms.DataGridView списокРегистратурыDataGridView;
        private System.Windows.Forms.BindingSource пациентBindingSource;
        private PolyDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private PolyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PolyDataSetTableAdapters.СписокРегистратурыTableAdapter списокРегистратурыTableAdapter;
        private System.Windows.Forms.DataGridView врачиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource списокРегистратурыBindingSource;
        private System.Windows.Forms.GroupBox RegistryGroup;
        private System.Windows.Forms.ComboBox код_пациентаComboBox;
        private System.Windows.Forms.ComboBox код_врачаComboBox;
        private System.Windows.Forms.DateTimePicker дата_и_время_приёмаDateTimePicker;
        private System.Windows.Forms.Button RegistryCancel;
        private System.Windows.Forms.Button RegistrySave;
        private System.Windows.Forms.BindingSource схемаЛеченияBindingSource;
        private PolyDataSetTableAdapters.СхемаЛеченияTableAdapter схемаЛеченияTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПациентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn пациентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn врачDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИВремяПриёмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn RegistryChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn RegistryDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПациентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресПроживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаРожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn полDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn признакЛьготDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn PatientChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn PatientDeleteColumn;
        private System.Windows.Forms.BindingSource врачиBindingSource;
        private PolyDataSet polyDataSet;
        private PolyDataSetTableAdapters.РегистратураTableAdapter регистратураTableAdapter;
        private PolyDataSetTableAdapters.ВрачиTableAdapter врачиTableAdapter;
        private System.Windows.Forms.BindingSource регистратураBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПациентаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВрачаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДиагнозаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn;
    }
}

