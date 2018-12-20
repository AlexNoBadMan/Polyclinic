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
            System.Windows.Forms.Label код_пациентаLabel;
            System.Windows.Forms.Label код_врачаLabel;
            System.Windows.Forms.Label дата_и_время_приёмаLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label адрес_проживанияLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label полLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label признак_льготLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.регистратураBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polyDataSet = new Polyclinic.PolyDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.PatientAddButton = new System.Windows.Forms.Button();
            this.схема_леченияDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПациентаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодВрачаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДиагнозаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosesChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DiagnosesDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.схемаЛеченияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RegistryAddButton = new System.Windows.Forms.Button();
            this.списокРегистратурыDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПациентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИВремяПриёмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistryChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.RegistryDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.списокРегистратурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PatientGroupBox = new System.Windows.Forms.GroupBox();
            this.PatientPanel = new System.Windows.Forms.Panel();
            this.PatientCancelButton = new System.Windows.Forms.Button();
            this.PatientSaveButton = new System.Windows.Forms.Button();
            this.признак_льготTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.адрес_проживанияTextBox = new System.Windows.Forms.TextBox();
            this.полTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.RegistryCancelButton = new System.Windows.Forms.Button();
            this.RegistrySaveButton = new System.Windows.Forms.Button();
            this.код_пациентаComboBox = new System.Windows.Forms.ComboBox();
            this.код_врачаComboBox = new System.Windows.Forms.ComboBox();
            this.дата_и_время_приёмаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.схемаЛеченияTableAdapter = new Polyclinic.PolyDataSetTableAdapters.СхемаЛеченияTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.диагнозыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.диагнозыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.категория_врачебной_специальностиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категория_врачебной_специальностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegistryPanel = new System.Windows.Forms.Panel();
            this.категория_врачебной_специальностиTableAdapter = new Polyclinic.PolyDataSetTableAdapters.Категория_врачебной_специальностиTableAdapter();
            this.диагнозыTableAdapter = new Polyclinic.PolyDataSetTableAdapters.ДиагнозыTableAdapter();
            код_пациентаLabel = new System.Windows.Forms.Label();
            код_врачаLabel = new System.Windows.Forms.Label();
            дата_и_время_приёмаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            адрес_проживанияLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            признак_льготLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.регистратураBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.схема_леченияDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.схемаЛеченияBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыBindingSource)).BeginInit();
            this.PatientGroupBox.SuspendLayout();
            this.PatientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пациентDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозыBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категория_врачебной_специальностиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.категория_врачебной_специальностиBindingSource)).BeginInit();
            this.RegistryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // код_пациентаLabel
            // 
            код_пациентаLabel.AutoSize = true;
            код_пациентаLabel.Location = new System.Drawing.Point(23, 64);
            код_пациентаLabel.Name = "код_пациентаLabel";
            код_пациентаLabel.Size = new System.Drawing.Size(149, 24);
            код_пациентаLabel.TabIndex = 2;
            код_пациентаLabel.Text = "ФИО пациента:";
            // 
            // код_врачаLabel
            // 
            код_врачаLabel.AutoSize = true;
            код_врачаLabel.Location = new System.Drawing.Point(22, 102);
            код_врачаLabel.Name = "код_врачаLabel";
            код_врачаLabel.Size = new System.Drawing.Size(116, 24);
            код_врачаLabel.TabIndex = 4;
            код_врачаLabel.Text = "ФИО врача:";
            // 
            // дата_и_время_приёмаLabel
            // 
            дата_и_время_приёмаLabel.AutoSize = true;
            дата_и_время_приёмаLabel.Location = new System.Drawing.Point(22, 141);
            дата_и_время_приёмаLabel.Name = "дата_и_время_приёмаLabel";
            дата_и_время_приёмаLabel.Size = new System.Drawing.Size(207, 24);
            дата_и_время_приёмаLabel.TabIndex = 6;
            дата_и_время_приёмаLabel.Text = "Время и дата приёма:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(210, 3);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(59, 24);
            фИОLabel.TabIndex = 2;
            фИОLabel.Text = "ФИО:";
            // 
            // адрес_проживанияLabel
            // 
            адрес_проживанияLabel.AutoSize = true;
            адрес_проживанияLabel.Location = new System.Drawing.Point(210, 38);
            адрес_проживанияLabel.Name = "адрес_проживанияLabel";
            адрес_проживанияLabel.Size = new System.Drawing.Size(188, 24);
            адрес_проживанияLabel.TabIndex = 4;
            адрес_проживанияLabel.Text = "Адрес проживания:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(210, 74);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(155, 24);
            дата_рожденияLabel.TabIndex = 6;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // полLabel
            // 
            полLabel.AutoSize = true;
            полLabel.Location = new System.Drawing.Point(210, 108);
            полLabel.Name = "полLabel";
            полLabel.Size = new System.Drawing.Size(49, 24);
            полLabel.TabIndex = 8;
            полLabel.Text = "Пол:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(210, 143);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(95, 24);
            телефонLabel.TabIndex = 10;
            телефонLabel.Text = "Телефон:";
            // 
            // признак_льготLabel
            // 
            признак_льготLabel.AutoSize = true;
            признак_льготLabel.Location = new System.Drawing.Point(210, 178);
            признак_льготLabel.Name = "признак_льготLabel";
            признак_льготLabel.Size = new System.Drawing.Size(146, 24);
            признак_льготLabel.TabIndex = 12;
            признак_льготLabel.Text = "Признак льгот:";
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
            // 
            // PatientAddButton
            // 
            this.PatientAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientAddButton.Image = global::Polyclinic.Properties.Resources.add_icon;
            this.PatientAddButton.Location = new System.Drawing.Point(6, 266);
            this.PatientAddButton.Name = "PatientAddButton";
            this.PatientAddButton.Size = new System.Drawing.Size(968, 30);
            this.PatientAddButton.TabIndex = 7;
            this.PatientAddButton.UseVisualStyleBackColor = true;
            this.PatientAddButton.Click += new System.EventHandler(this.PatientAddButton_Click);
            // 
            // схема_леченияDataGridView
            // 
            this.схема_леченияDataGridView.AllowUserToAddRows = false;
            this.схема_леченияDataGridView.AllowUserToDeleteRows = false;
            this.схема_леченияDataGridView.AutoGenerateColumns = false;
            this.схема_леченияDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.схема_леченияDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.схема_леченияDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.схема_леченияDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.схема_леченияDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.кодПациентаDataGridViewTextBoxColumn2,
            this.кодВрачаDataGridViewTextBoxColumn1,
            this.кодДиагнозаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn,
            this.DiagnosesChangeColumn,
            this.DiagnosesDeleteColumn});
            this.схема_леченияDataGridView.DataSource = this.схемаЛеченияBindingSource;
            this.схема_леченияDataGridView.Location = new System.Drawing.Point(6, 22);
            this.схема_леченияDataGridView.Name = "схема_леченияDataGridView";
            this.схема_леченияDataGridView.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.схема_леченияDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.схема_леченияDataGridView.RowHeadersVisible = false;
            this.схема_леченияDataGridView.RowTemplate.Height = 24;
            this.схема_леченияDataGridView.Size = new System.Drawing.Size(396, 272);
            this.схема_леченияDataGridView.TabIndex = 0;
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
            this.наименованиеDataGridViewTextBoxColumn.FillWeight = 65F;
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Диагноз";
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn
            // 
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.DataPropertyName = "Описание схемы лечения и назначений";
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.FillWeight = 218.5177F;
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.HeaderText = "Схемы лечения и назначения";
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.Name = "описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn";
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DiagnosesChangeColumn
            // 
            this.DiagnosesChangeColumn.FillWeight = 20.5F;
            this.DiagnosesChangeColumn.HeaderText = "Редактировать";
            this.DiagnosesChangeColumn.Image = global::Polyclinic.Properties.Resources.edit_icon;
            this.DiagnosesChangeColumn.Name = "DiagnosesChangeColumn";
            this.DiagnosesChangeColumn.ReadOnly = true;
            // 
            // DiagnosesDeleteColumn
            // 
            this.DiagnosesDeleteColumn.FillWeight = 20.5F;
            this.DiagnosesDeleteColumn.HeaderText = "Удалить";
            this.DiagnosesDeleteColumn.Image = global::Polyclinic.Properties.Resources.delete_icon;
            this.DiagnosesDeleteColumn.Name = "DiagnosesDeleteColumn";
            this.DiagnosesDeleteColumn.ReadOnly = true;
            // 
            // схемаЛеченияBindingSource
            // 
            this.схемаЛеченияBindingSource.DataMember = "Пациент_СхемаЛечения";
            this.схемаЛеченияBindingSource.DataSource = this.пациентBindingSource;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.схема_леченияDataGridView);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(578, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 333);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Диагнозы:";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Polyclinic.Properties.Resources.add_icon;
            this.button4.Location = new System.Drawing.Point(6, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(396, 30);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RegistryAddButton);
            this.groupBox2.Controls.Add(this.RegistryPanel);
            this.groupBox2.Controls.Add(this.списокРегистратурыDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 333);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Приёмы:";
            // 
            // RegistryAddButton
            // 
            this.RegistryAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistryAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistryAddButton.Image = global::Polyclinic.Properties.Resources.add_icon;
            this.RegistryAddButton.Location = new System.Drawing.Point(6, 296);
            this.RegistryAddButton.Name = "RegistryAddButton";
            this.RegistryAddButton.Size = new System.Drawing.Size(556, 30);
            this.RegistryAddButton.TabIndex = 1;
            this.RegistryAddButton.UseVisualStyleBackColor = true;
            this.RegistryAddButton.Click += new System.EventHandler(this.RegistryAddButton_Click);
            // 
            // списокРегистратурыDataGridView
            // 
            this.списокРегистратурыDataGridView.AllowUserToAddRows = false;
            this.списокРегистратурыDataGridView.AllowUserToDeleteRows = false;
            this.списокРегистратурыDataGridView.AutoGenerateColumns = false;
            this.списокРегистратурыDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.списокРегистратурыDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.списокРегистратурыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.списокРегистратурыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.кодПациентаDataGridViewTextBoxColumn1,
            this.кодВрачаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn1,
            this.датаИВремяПриёмаDataGridViewTextBoxColumn,
            this.RegistryChangeColumn,
            this.RegistryDeleteColumn});
            this.списокРегистратурыDataGridView.DataSource = this.списокРегистратурыBindingSource;
            this.списокРегистратурыDataGridView.Location = new System.Drawing.Point(6, 22);
            this.списокРегистратурыDataGridView.Name = "списокРегистратурыDataGridView";
            this.списокРегистратурыDataGridView.ReadOnly = true;
            this.списокРегистратурыDataGridView.RowHeadersVisible = false;
            this.списокРегистратурыDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.списокРегистратурыDataGridView.RowTemplate.Height = 25;
            this.списокРегистратурыDataGridView.Size = new System.Drawing.Size(556, 272);
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
            // кодВрачаDataGridViewTextBoxColumn
            // 
            this.кодВрачаDataGridViewTextBoxColumn.DataPropertyName = "Код врача";
            this.кодВрачаDataGridViewTextBoxColumn.HeaderText = "Код врача";
            this.кодВрачаDataGridViewTextBoxColumn.Name = "кодВрачаDataGridViewTextBoxColumn";
            this.кодВрачаDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодВрачаDataGridViewTextBoxColumn.Visible = false;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.FillWeight = 135.8779F;
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.FillWeight = 67F;
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Категория";
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            this.наименованиеDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // датаИВремяПриёмаDataGridViewTextBoxColumn
            // 
            this.датаИВремяПриёмаDataGridViewTextBoxColumn.DataPropertyName = "Дата и время приёма";
            this.датаИВремяПриёмаDataGridViewTextBoxColumn.FillWeight = 75F;
            this.датаИВремяПриёмаDataGridViewTextBoxColumn.HeaderText = "Приём";
            this.датаИВремяПриёмаDataGridViewTextBoxColumn.Name = "датаИВремяПриёмаDataGridViewTextBoxColumn";
            this.датаИВремяПриёмаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RegistryChangeColumn
            // 
            this.RegistryChangeColumn.FillWeight = 13.5F;
            this.RegistryChangeColumn.HeaderText = "Редактировать";
            this.RegistryChangeColumn.Image = global::Polyclinic.Properties.Resources.edit_icon;
            this.RegistryChangeColumn.Name = "RegistryChangeColumn";
            this.RegistryChangeColumn.ReadOnly = true;
            this.RegistryChangeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RegistryChangeColumn.ToolTipText = "Редактировать";
            // 
            // RegistryDeleteColumn
            // 
            this.RegistryDeleteColumn.FillWeight = 14F;
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
            // PatientGroupBox
            // 
            this.PatientGroupBox.Controls.Add(this.PatientAddButton);
            this.PatientGroupBox.Controls.Add(this.пациентDataGridView);
            this.PatientGroupBox.Controls.Add(this.PatientPanel);
            this.PatientGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientGroupBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PatientGroupBox.Location = new System.Drawing.Point(6, 6);
            this.PatientGroupBox.Name = "PatientGroupBox";
            this.PatientGroupBox.Size = new System.Drawing.Size(980, 304);
            this.PatientGroupBox.TabIndex = 3;
            this.PatientGroupBox.TabStop = false;
            this.PatientGroupBox.Text = "Информация о пациенте:";
            // 
            // PatientPanel
            // 
            this.PatientPanel.Controls.Add(this.PatientCancelButton);
            this.PatientPanel.Controls.Add(this.PatientSaveButton);
            this.PatientPanel.Controls.Add(фИОLabel);
            this.PatientPanel.Controls.Add(this.признак_льготTextBox);
            this.PatientPanel.Controls.Add(признак_льготLabel);
            this.PatientPanel.Controls.Add(this.фИОTextBox);
            this.PatientPanel.Controls.Add(this.телефонTextBox);
            this.PatientPanel.Controls.Add(адрес_проживанияLabel);
            this.PatientPanel.Controls.Add(телефонLabel);
            this.PatientPanel.Controls.Add(this.адрес_проживанияTextBox);
            this.PatientPanel.Controls.Add(this.полTextBox);
            this.PatientPanel.Controls.Add(дата_рожденияLabel);
            this.PatientPanel.Controls.Add(полLabel);
            this.PatientPanel.Controls.Add(this.дата_рожденияDateTimePicker);
            this.PatientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.PatientPanel.Location = new System.Drawing.Point(3, 22);
            this.PatientPanel.Name = "PatientPanel";
            this.PatientPanel.Size = new System.Drawing.Size(974, 279);
            this.PatientPanel.TabIndex = 19;
            this.PatientPanel.Visible = false;
            // 
            // PatientCancelButton
            // 
            this.PatientCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientCancelButton.Image = global::Polyclinic.Properties.Resources.delete_icon;
            this.PatientCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PatientCancelButton.Location = new System.Drawing.Point(530, 226);
            this.PatientCancelButton.Name = "PatientCancelButton";
            this.PatientCancelButton.Size = new System.Drawing.Size(165, 32);
            this.PatientCancelButton.TabIndex = 15;
            this.PatientCancelButton.Text = "Отмена";
            this.PatientCancelButton.UseVisualStyleBackColor = true;
            this.PatientCancelButton.Click += new System.EventHandler(this.PatientCancelButton_Click);
            // 
            // PatientSaveButton
            // 
            this.PatientSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientSaveButton.Image = global::Polyclinic.Properties.Resources.Save_icon;
            this.PatientSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PatientSaveButton.Location = new System.Drawing.Point(313, 226);
            this.PatientSaveButton.Name = "PatientSaveButton";
            this.PatientSaveButton.Size = new System.Drawing.Size(165, 32);
            this.PatientSaveButton.TabIndex = 14;
            this.PatientSaveButton.Text = "Сохранить";
            this.PatientSaveButton.UseVisualStyleBackColor = true;
            this.PatientSaveButton.Click += new System.EventHandler(this.PatientSaveButton_Click);
            // 
            // признак_льготTextBox
            // 
            this.признак_льготTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентBindingSource, "Признак льгот", true));
            this.признак_льготTextBox.Location = new System.Drawing.Point(404, 175);
            this.признак_льготTextBox.Name = "признак_льготTextBox";
            this.признак_льготTextBox.Size = new System.Drawing.Size(346, 29);
            this.признак_льготTextBox.TabIndex = 13;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(404, 0);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(346, 29);
            this.фИОTextBox.TabIndex = 3;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(404, 140);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(346, 29);
            this.телефонTextBox.TabIndex = 11;
            // 
            // адрес_проживанияTextBox
            // 
            this.адрес_проживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентBindingSource, "Адрес проживания", true));
            this.адрес_проживанияTextBox.Location = new System.Drawing.Point(404, 35);
            this.адрес_проживанияTextBox.Name = "адрес_проживанияTextBox";
            this.адрес_проживанияTextBox.Size = new System.Drawing.Size(346, 29);
            this.адрес_проживанияTextBox.TabIndex = 5;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.пациентBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(404, 105);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(346, 29);
            this.полTextBox.TabIndex = 9;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.пациентBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(404, 70);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(346, 29);
            this.дата_рожденияDateTimePicker.TabIndex = 7;
            // 
            // пациентDataGridView
            // 
            this.пациентDataGridView.AllowUserToAddRows = false;
            this.пациентDataGridView.AllowUserToDeleteRows = false;
            this.пациентDataGridView.AutoGenerateColumns = false;
            this.пациентDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.пациентDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
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
            this.пациентDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.пациентDataGridView_CellMouseEnter);
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
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.датаРожденияDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle24;
            this.датаРожденияDataGridViewTextBoxColumn.FillWeight = 90F;
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.полDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle25;
            this.полDataGridViewTextBoxColumn.FillWeight = 40F;
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.телефонDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle26;
            this.телефонDataGridViewTextBoxColumn.FillWeight = 90F;
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // признакЛьготDataGridViewTextBoxColumn
            // 
            this.признакЛьготDataGridViewTextBoxColumn.DataPropertyName = "Признак льгот";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.признакЛьготDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle27;
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
            this.врачиDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.врачиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.врачиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.врачиDataGridView.DataSource = this.врачиBindingSource;
            this.врачиDataGridView.Location = new System.Drawing.Point(3, 3);
            this.врачиDataGridView.Name = "врачиDataGridView";
            this.врачиDataGridView.Size = new System.Drawing.Size(986, 274);
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
            // RegistryCancelButton
            // 
            this.RegistryCancelButton.Image = global::Polyclinic.Properties.Resources.delete_icon;
            this.RegistryCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistryCancelButton.Location = new System.Drawing.Point(298, 189);
            this.RegistryCancelButton.Name = "RegistryCancelButton";
            this.RegistryCancelButton.Size = new System.Drawing.Size(165, 32);
            this.RegistryCancelButton.TabIndex = 9;
            this.RegistryCancelButton.Text = "Отмена";
            this.RegistryCancelButton.UseVisualStyleBackColor = true;
            this.RegistryCancelButton.Click += new System.EventHandler(this.RegistryCancelButton_Click);
            // 
            // RegistrySaveButton
            // 
            this.RegistrySaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrySaveButton.Image = global::Polyclinic.Properties.Resources.Save_icon;
            this.RegistrySaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistrySaveButton.Location = new System.Drawing.Point(94, 189);
            this.RegistrySaveButton.Name = "RegistrySaveButton";
            this.RegistrySaveButton.Size = new System.Drawing.Size(165, 32);
            this.RegistrySaveButton.TabIndex = 8;
            this.RegistrySaveButton.Text = "Сохранить";
            this.RegistrySaveButton.UseVisualStyleBackColor = true;
            this.RegistrySaveButton.Click += new System.EventHandler(this.RegistrySaveButton_Click);
            // 
            // код_пациентаComboBox
            // 
            this.код_пациентаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.регистратураBindingSource, "Код пациента", true));
            this.код_пациентаComboBox.DataSource = this.пациентBindingSource;
            this.код_пациентаComboBox.DisplayMember = "ФИО";
            this.код_пациентаComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_пациентаComboBox.FormattingEnabled = true;
            this.код_пациентаComboBox.Location = new System.Drawing.Point(237, 61);
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
            this.код_врачаComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_врачаComboBox.FormattingEnabled = true;
            this.код_врачаComboBox.Location = new System.Drawing.Point(237, 99);
            this.код_врачаComboBox.Name = "код_врачаComboBox";
            this.код_врачаComboBox.Size = new System.Drawing.Size(300, 32);
            this.код_врачаComboBox.TabIndex = 5;
            this.код_врачаComboBox.ValueMember = "Код врача";
            // 
            // дата_и_время_приёмаDateTimePicker
            // 
            this.дата_и_время_приёмаDateTimePicker.CustomFormat = "HH:m d.MM.yyyy";
            this.дата_и_время_приёмаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.регистратураBindingSource, "Дата и время приёма", true));
            this.дата_и_время_приёмаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_и_время_приёмаDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.дата_и_время_приёмаDateTimePicker.Location = new System.Drawing.Point(237, 137);
            this.дата_и_время_приёмаDateTimePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.дата_и_время_приёмаDateTimePicker.Name = "дата_и_время_приёмаDateTimePicker";
            this.дата_и_время_приёмаDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(160, 29);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 683);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.PatientGroupBox);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поликлиника";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.врачиDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Врачи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.диагнозыDataGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(992, 646);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Диагнозы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // диагнозыDataGridView
            // 
            this.диагнозыDataGridView.AutoGenerateColumns = false;
            this.диагнозыDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.диагнозыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.диагнозыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.диагнозыDataGridView.DataSource = this.диагнозыBindingSource;
            this.диагнозыDataGridView.Location = new System.Drawing.Point(6, 6);
            this.диагнозыDataGridView.Name = "диагнозыDataGridView";
            this.диагнозыDataGridView.Size = new System.Drawing.Size(980, 220);
            this.диагнозыDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Код диагноза";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код диагноза";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn7.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // диагнозыBindingSource
            // 
            this.диагнозыBindingSource.DataMember = "Диагнозы";
            this.диагнозыBindingSource.DataSource = this.polyDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.категория_врачебной_специальностиDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(992, 646);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Специальности";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // категория_врачебной_специальностиDataGridView
            // 
            this.категория_врачебной_специальностиDataGridView.AutoGenerateColumns = false;
            this.категория_врачебной_специальностиDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.категория_врачебной_специальностиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.категория_врачебной_специальностиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.категория_врачебной_специальностиDataGridView.DataSource = this.категория_врачебной_специальностиBindingSource;
            this.категория_врачебной_специальностиDataGridView.Location = new System.Drawing.Point(6, 6);
            this.категория_врачебной_специальностиDataGridView.Name = "категория_врачебной_специальностиDataGridView";
            this.категория_врачебной_специальностиDataGridView.Size = new System.Drawing.Size(980, 220);
            this.категория_врачебной_специальностиDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код категории специальности";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код категории специальности";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Наименование";
            this.dataGridViewTextBoxColumn5.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // категория_врачебной_специальностиBindingSource
            // 
            this.категория_врачебной_специальностиBindingSource.DataMember = "Категория врачебной специальности";
            this.категория_врачебной_специальностиBindingSource.DataSource = this.polyDataSet;
            // 
            // RegistryPanel
            // 
            this.RegistryPanel.Controls.Add(this.RegistryCancelButton);
            this.RegistryPanel.Controls.Add(код_врачаLabel);
            this.RegistryPanel.Controls.Add(this.RegistrySaveButton);
            this.RegistryPanel.Controls.Add(this.дата_и_время_приёмаDateTimePicker);
            this.RegistryPanel.Controls.Add(код_пациентаLabel);
            this.RegistryPanel.Controls.Add(дата_и_время_приёмаLabel);
            this.RegistryPanel.Controls.Add(this.код_пациентаComboBox);
            this.RegistryPanel.Controls.Add(this.код_врачаComboBox);
            this.RegistryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegistryPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.RegistryPanel.Location = new System.Drawing.Point(3, 22);
            this.RegistryPanel.Name = "RegistryPanel";
            this.RegistryPanel.Size = new System.Drawing.Size(562, 308);
            this.RegistryPanel.TabIndex = 18;
            this.RegistryPanel.Visible = false;
            // 
            // категория_врачебной_специальностиTableAdapter
            // 
            this.категория_врачебной_специальностиTableAdapter.ClearBeforeFill = true;
            // 
            // диагнозыTableAdapter
            // 
            this.диагнозыTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 690);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
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
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыBindingSource)).EndInit();
            this.PatientGroupBox.ResumeLayout(false);
            this.PatientPanel.ResumeLayout(false);
            this.PatientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пациентDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.диагнозыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозыBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.категория_врачебной_специальностиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.категория_врачебной_специальностиBindingSource)).EndInit();
            this.RegistryPanel.ResumeLayout(false);
            this.RegistryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button PatientAddButton;
        private System.Windows.Forms.DataGridView схема_леченияDataGridView;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox PatientGroupBox;
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
        private System.Windows.Forms.ComboBox код_пациентаComboBox;
        private System.Windows.Forms.ComboBox код_врачаComboBox;
        private System.Windows.Forms.DateTimePicker дата_и_время_приёмаDateTimePicker;
        private System.Windows.Forms.Button RegistryCancelButton;
        private System.Windows.Forms.Button RegistrySaveButton;
        private System.Windows.Forms.BindingSource схемаЛеченияBindingSource;
        private PolyDataSetTableAdapters.СхемаЛеченияTableAdapter схемаЛеченияTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПациентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВрачаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаИВремяПриёмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn RegistryChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn RegistryDeleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодПациентаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодВрачаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодДиагнозаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn DiagnosesChangeColumn;
        private System.Windows.Forms.DataGridViewImageColumn DiagnosesDeleteColumn;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox адрес_проживанияTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.TextBox полTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox признак_льготTextBox;
        private System.Windows.Forms.Panel RegistryPanel;
        private System.Windows.Forms.Panel PatientPanel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.BindingSource категория_врачебной_специальностиBindingSource;
        private PolyDataSetTableAdapters.Категория_врачебной_специальностиTableAdapter категория_врачебной_специальностиTableAdapter;
        private System.Windows.Forms.DataGridView категория_врачебной_специальностиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource диагнозыBindingSource;
        private PolyDataSetTableAdapters.ДиагнозыTableAdapter диагнозыTableAdapter;
        private System.Windows.Forms.DataGridView диагнозыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button RegistryAddButton;
        private System.Windows.Forms.Button PatientSaveButton;
        private System.Windows.Forms.Button PatientCancelButton;
    }
}

