﻿namespace Polyclinic
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
            System.Windows.Forms.Label код_пациентаLabel1;
            System.Windows.Forms.Label код_врачаLabel1;
            System.Windows.Forms.Label код_диагнозаLabel;
            System.Windows.Forms.Label описание_схемы_лечения_и_назначенийLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RegistryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PatientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.polyDataSet = new Polyclinic.PolyDataSet();
            this.CardSaveButton = new System.Windows.Forms.Button();
            this.PatientAddButton = new System.Windows.Forms.Button();
            this.CardViewDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПациентаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодВрачаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодДиагнозаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosesChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DiagnosesDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.CardViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CardGroupBox = new System.Windows.Forms.GroupBox();
            this.CardAddButton = new System.Windows.Forms.Button();
            this.RegistryGroupBox = new System.Windows.Forms.GroupBox();
            this.RegistryAddButton = new System.Windows.Forms.Button();
            this.RegistryPanel = new System.Windows.Forms.Panel();
            this.RegistryCancelButton = new System.Windows.Forms.Button();
            this.RegistrySaveButton = new System.Windows.Forms.Button();
            this.дата_и_время_приёмаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.код_пациентаComboBox = new System.Windows.Forms.ComboBox();
            this.код_врачаComboBox = new System.Windows.Forms.ComboBox();
            this.DoctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RegistryViewDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодПациентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодВрачаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаИВремяПриёмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistryChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.RegistryDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.RegistryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.PatientDataGridView = new System.Windows.Forms.DataGridView();
            this.кодПациентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаРожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.полDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.признакЛьготDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientChangeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PatientDeleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PatientTableAdapter = new Polyclinic.PolyDataSetTableAdapters.ПациентTableAdapter();
            this.tableAdapterManager = new Polyclinic.PolyDataSetTableAdapters.TableAdapterManager();
            this.RegistryViewTableAdapter = new Polyclinic.PolyDataSetTableAdapters.СписокРегистратурыTableAdapter();
            this.RegistryTableAdapter = new Polyclinic.PolyDataSetTableAdapters.РегистратураTableAdapter();
            this.DoctorTableAdapter = new Polyclinic.PolyDataSetTableAdapters.ВрачиTableAdapter();
            this.врачиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardViewTableAdapter = new Polyclinic.PolyDataSetTableAdapters.СхемаЛеченияTableAdapter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.диагнозыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.категория_врачебной_специальностиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpecialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpecialtyTableAdapter = new Polyclinic.PolyDataSetTableAdapters.Категория_врачебной_специальностиTableAdapter();
            this.DiagnosesTableAdapter = new Polyclinic.PolyDataSetTableAdapters.ДиагнозыTableAdapter();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.CardCancelButton = new System.Windows.Forms.Button();
            this.CardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.код_пациентаComboBox1 = new System.Windows.Forms.ComboBox();
            this.код_врачаComboBox1 = new System.Windows.Forms.ComboBox();
            this.код_диагнозаComboBox = new System.Windows.Forms.ComboBox();
            this.описание_схемы_лечения_и_назначенийTextBox = new System.Windows.Forms.TextBox();
            this.CardTableAdapter = new Polyclinic.PolyDataSetTableAdapters.Амбулаторная_картаTableAdapter();
            код_пациентаLabel = new System.Windows.Forms.Label();
            код_врачаLabel = new System.Windows.Forms.Label();
            дата_и_время_приёмаLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            адрес_проживанияLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            полLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            признак_льготLabel = new System.Windows.Forms.Label();
            код_пациентаLabel1 = new System.Windows.Forms.Label();
            код_врачаLabel1 = new System.Windows.Forms.Label();
            код_диагнозаLabel = new System.Windows.Forms.Label();
            описание_схемы_лечения_и_назначенийLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RegistryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardViewBindingSource)).BeginInit();
            this.CardGroupBox.SuspendLayout();
            this.RegistryGroupBox.SuspendLayout();
            this.RegistryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistryViewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistryViewBindingSource)).BeginInit();
            this.PatientGroupBox.SuspendLayout();
            this.PatientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.диагнозыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosesBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.категория_врачебной_специальностиDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtyBindingSource)).BeginInit();
            this.CardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // код_пациентаLabel
            // 
            код_пациентаLabel.AutoSize = true;
            код_пациентаLabel.Location = new System.Drawing.Point(4, 64);
            код_пациентаLabel.Name = "код_пациентаLabel";
            код_пациентаLabel.Size = new System.Drawing.Size(92, 24);
            код_пациентаLabel.TabIndex = 2;
            код_пациентаLabel.Text = "Пациент:";
            // 
            // код_врачаLabel
            // 
            код_врачаLabel.AutoSize = true;
            код_врачаLabel.Location = new System.Drawing.Point(3, 102);
            код_врачаLabel.Name = "код_врачаLabel";
            код_врачаLabel.Size = new System.Drawing.Size(58, 24);
            код_врачаLabel.TabIndex = 4;
            код_врачаLabel.Text = "Врач:";
            // 
            // дата_и_время_приёмаLabel
            // 
            дата_и_время_приёмаLabel.AutoSize = true;
            дата_и_время_приёмаLabel.Location = new System.Drawing.Point(3, 141);
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
            // код_пациентаLabel1
            // 
            код_пациентаLabel1.AutoSize = true;
            код_пациентаLabel1.Location = new System.Drawing.Point(3, 9);
            код_пациентаLabel1.Name = "код_пациентаLabel1";
            код_пациентаLabel1.Size = new System.Drawing.Size(92, 24);
            код_пациентаLabel1.TabIndex = 10;
            код_пациентаLabel1.Text = "Пациент:";
            // 
            // код_врачаLabel1
            // 
            код_врачаLabel1.AutoSize = true;
            код_врачаLabel1.Location = new System.Drawing.Point(3, 47);
            код_врачаLabel1.Name = "код_врачаLabel1";
            код_врачаLabel1.Size = new System.Drawing.Size(58, 24);
            код_врачаLabel1.TabIndex = 12;
            код_врачаLabel1.Text = "Врач:";
            // 
            // код_диагнозаLabel
            // 
            код_диагнозаLabel.AutoSize = true;
            код_диагнозаLabel.Location = new System.Drawing.Point(3, 85);
            код_диагнозаLabel.Name = "код_диагнозаLabel";
            код_диагнозаLabel.Size = new System.Drawing.Size(91, 24);
            код_диагнозаLabel.TabIndex = 14;
            код_диагнозаLabel.Text = "Диагноз:";
            // 
            // описание_схемы_лечения_и_назначенийLabel
            // 
            описание_схемы_лечения_и_назначенийLabel.AutoSize = true;
            описание_схемы_лечения_и_назначенийLabel.Location = new System.Drawing.Point(3, 123);
            описание_схемы_лечения_и_назначенийLabel.Name = "описание_схемы_лечения_и_назначенийLabel";
            описание_схемы_лечения_и_назначенийLabel.Size = new System.Drawing.Size(92, 24);
            описание_схемы_лечения_и_назначенийLabel.TabIndex = 16;
            описание_схемы_лечения_и_назначенийLabel.Text = "Лечение:";
            // 
            // RegistryBindingSource
            // 
            this.RegistryBindingSource.DataMember = "FK_Регистратура_Пациент";
            this.RegistryBindingSource.DataSource = this.PatientBindingSource;
            // 
            // PatientBindingSource
            // 
            this.PatientBindingSource.DataMember = "Пациент";
            this.PatientBindingSource.DataSource = this.polyDataSet;
            // 
            // polyDataSet
            // 
            this.polyDataSet.DataSetName = "PolyDataSet";
            this.polyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CardSaveButton
            // 
            this.CardSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CardSaveButton.Image = global::Polyclinic.Properties.Resources.Save_icon;
            this.CardSaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CardSaveButton.Location = new System.Drawing.Point(13, 236);
            this.CardSaveButton.Name = "CardSaveButton";
            this.CardSaveButton.Size = new System.Drawing.Size(165, 32);
            this.CardSaveButton.TabIndex = 8;
            this.CardSaveButton.Text = "Сохранить";
            this.CardSaveButton.UseVisualStyleBackColor = true;
            this.CardSaveButton.Click += new System.EventHandler(this.CardSaveButton_Click);
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
            // CardViewDataGridView
            // 
            this.CardViewDataGridView.AllowUserToAddRows = false;
            this.CardViewDataGridView.AllowUserToDeleteRows = false;
            this.CardViewDataGridView.AutoGenerateColumns = false;
            this.CardViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CardViewDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.CardViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CardViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CardViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.кодПациентаDataGridViewTextBoxColumn2,
            this.кодВрачаDataGridViewTextBoxColumn1,
            this.кодДиагнозаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn,
            this.DiagnosesChangeColumn,
            this.DiagnosesDeleteColumn});
            this.CardViewDataGridView.DataSource = this.CardViewBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CardViewDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CardViewDataGridView.Location = new System.Drawing.Point(6, 22);
            this.CardViewDataGridView.Name = "CardViewDataGridView";
            this.CardViewDataGridView.ReadOnly = true;
            this.CardViewDataGridView.RowHeadersVisible = false;
            this.CardViewDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CardViewDataGridView.RowTemplate.Height = 24;
            this.CardViewDataGridView.Size = new System.Drawing.Size(396, 272);
            this.CardViewDataGridView.TabIndex = 0;
            this.CardViewDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CardViewDataGridView_CellClick);
            this.CardViewDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CardViewDataGridView_CellContentClick);
            this.CardViewDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.CardViewDataGridView_CellMouseEnter);
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
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.описаниеСхемыЛеченияИНазначенийDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
            // CardViewBindingSource
            // 
            this.CardViewBindingSource.DataMember = "Пациент_СхемаЛечения";
            this.CardViewBindingSource.DataSource = this.PatientBindingSource;
            // 
            // CardGroupBox
            // 
            this.CardGroupBox.Controls.Add(this.CardAddButton);
            this.CardGroupBox.Controls.Add(this.CardViewDataGridView);
            this.CardGroupBox.Controls.Add(this.CardPanel);
            this.CardGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.CardGroupBox.Location = new System.Drawing.Point(578, 308);
            this.CardGroupBox.Name = "CardGroupBox";
            this.CardGroupBox.Size = new System.Drawing.Size(408, 333);
            this.CardGroupBox.TabIndex = 6;
            this.CardGroupBox.TabStop = false;
            this.CardGroupBox.Text = "Диагнозы:";
            // 
            // CardAddButton
            // 
            this.CardAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CardAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CardAddButton.Image = global::Polyclinic.Properties.Resources.add_icon;
            this.CardAddButton.Location = new System.Drawing.Point(6, 296);
            this.CardAddButton.Name = "CardAddButton";
            this.CardAddButton.Size = new System.Drawing.Size(396, 30);
            this.CardAddButton.TabIndex = 1;
            this.CardAddButton.UseVisualStyleBackColor = true;
            this.CardAddButton.Click += new System.EventHandler(this.CardAddButton_Click);
            // 
            // RegistryGroupBox
            // 
            this.RegistryGroupBox.Controls.Add(this.RegistryAddButton);
            this.RegistryGroupBox.Controls.Add(this.RegistryViewDataGridView);
            this.RegistryGroupBox.Controls.Add(this.RegistryPanel);
            this.RegistryGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistryGroupBox.Location = new System.Drawing.Point(6, 308);
            this.RegistryGroupBox.Name = "RegistryGroupBox";
            this.RegistryGroupBox.Size = new System.Drawing.Size(568, 333);
            this.RegistryGroupBox.TabIndex = 4;
            this.RegistryGroupBox.TabStop = false;
            this.RegistryGroupBox.Text = "Приёмы:";
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
            this.RegistryPanel.Location = new System.Drawing.Point(3, 25);
            this.RegistryPanel.Name = "RegistryPanel";
            this.RegistryPanel.Size = new System.Drawing.Size(562, 305);
            this.RegistryPanel.TabIndex = 18;
            this.RegistryPanel.Visible = false;
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
            // дата_и_время_приёмаDateTimePicker
            // 
            this.дата_и_время_приёмаDateTimePicker.CustomFormat = "HH:m d.MM.yyyy";
            this.дата_и_время_приёмаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.RegistryBindingSource, "Дата и время приёма", true));
            this.дата_и_время_приёмаDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_и_время_приёмаDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.дата_и_время_приёмаDateTimePicker.Location = new System.Drawing.Point(216, 137);
            this.дата_и_время_приёмаDateTimePicker.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.дата_и_время_приёмаDateTimePicker.Name = "дата_и_время_приёмаDateTimePicker";
            this.дата_и_время_приёмаDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.дата_и_время_приёмаDateTimePicker.Size = new System.Drawing.Size(343, 29);
            this.дата_и_время_приёмаDateTimePicker.TabIndex = 7;
            // 
            // код_пациентаComboBox
            // 
            this.код_пациентаComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.код_пациентаComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.код_пациентаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.RegistryBindingSource, "Код пациента", true));
            this.код_пациентаComboBox.DataSource = this.PatientBindingSource;
            this.код_пациентаComboBox.DisplayMember = "ФИО";
            this.код_пациентаComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_пациентаComboBox.FormattingEnabled = true;
            this.код_пациентаComboBox.Location = new System.Drawing.Point(216, 61);
            this.код_пациентаComboBox.Name = "код_пациентаComboBox";
            this.код_пациентаComboBox.Size = new System.Drawing.Size(343, 32);
            this.код_пациентаComboBox.TabIndex = 3;
            this.код_пациентаComboBox.ValueMember = "Код пациента";
            // 
            // код_врачаComboBox
            // 
            this.код_врачаComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.код_врачаComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.код_врачаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.RegistryBindingSource, "Код врача", true));
            this.код_врачаComboBox.DataSource = this.DoctorBindingSource;
            this.код_врачаComboBox.DisplayMember = "ФИО";
            this.код_врачаComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.код_врачаComboBox.FormattingEnabled = true;
            this.код_врачаComboBox.Location = new System.Drawing.Point(216, 99);
            this.код_врачаComboBox.Name = "код_врачаComboBox";
            this.код_врачаComboBox.Size = new System.Drawing.Size(343, 32);
            this.код_врачаComboBox.TabIndex = 5;
            this.код_врачаComboBox.ValueMember = "Код врача";
            // 
            // DoctorBindingSource
            // 
            this.DoctorBindingSource.DataMember = "Врачи";
            this.DoctorBindingSource.DataSource = this.polyDataSet;
            // 
            // RegistryViewDataGridView
            // 
            this.RegistryViewDataGridView.AllowUserToAddRows = false;
            this.RegistryViewDataGridView.AllowUserToDeleteRows = false;
            this.RegistryViewDataGridView.AutoGenerateColumns = false;
            this.RegistryViewDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.RegistryViewDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.RegistryViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegistryViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.кодПациентаDataGridViewTextBoxColumn1,
            this.кодВрачаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn1,
            this.датаИВремяПриёмаDataGridViewTextBoxColumn,
            this.RegistryChangeColumn,
            this.RegistryDeleteColumn});
            this.RegistryViewDataGridView.DataSource = this.RegistryViewBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RegistryViewDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.RegistryViewDataGridView.Location = new System.Drawing.Point(6, 22);
            this.RegistryViewDataGridView.Name = "RegistryViewDataGridView";
            this.RegistryViewDataGridView.ReadOnly = true;
            this.RegistryViewDataGridView.RowHeadersVisible = false;
            this.RegistryViewDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RegistryViewDataGridView.RowTemplate.Height = 25;
            this.RegistryViewDataGridView.Size = new System.Drawing.Size(556, 272);
            this.RegistryViewDataGridView.TabIndex = 0;
            this.RegistryViewDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistryViewDataGridView_CellClick);
            this.RegistryViewDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistryViewDataGridView_CellContentClick);
            this.RegistryViewDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistryViewDataGridView_CellMouseEnter);
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
            // RegistryViewBindingSource
            // 
            this.RegistryViewBindingSource.DataMember = "FK_Пациент_СписокРегистратуры";
            this.RegistryViewBindingSource.DataSource = this.PatientBindingSource;
            // 
            // PatientGroupBox
            // 
            this.PatientGroupBox.Controls.Add(this.PatientAddButton);
            this.PatientGroupBox.Controls.Add(this.PatientDataGridView);
            this.PatientGroupBox.Controls.Add(this.PatientPanel);
            this.PatientGroupBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
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
            this.PatientPanel.Location = new System.Drawing.Point(3, 25);
            this.PatientPanel.Name = "PatientPanel";
            this.PatientPanel.Size = new System.Drawing.Size(974, 276);
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
            this.признак_льготTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PatientBindingSource, "Признак льгот", true));
            this.признак_льготTextBox.Location = new System.Drawing.Point(404, 175);
            this.признак_льготTextBox.Name = "признак_льготTextBox";
            this.признак_льготTextBox.Size = new System.Drawing.Size(346, 29);
            this.признак_льготTextBox.TabIndex = 13;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PatientBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(404, 0);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(346, 29);
            this.фИОTextBox.TabIndex = 3;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PatientBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(404, 140);
            this.телефонTextBox.MaxLength = 19;
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(346, 29);
            this.телефонTextBox.TabIndex = 11;
            // 
            // адрес_проживанияTextBox
            // 
            this.адрес_проживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PatientBindingSource, "Адрес проживания", true));
            this.адрес_проживанияTextBox.Location = new System.Drawing.Point(404, 35);
            this.адрес_проживанияTextBox.Name = "адрес_проживанияTextBox";
            this.адрес_проживанияTextBox.Size = new System.Drawing.Size(346, 29);
            this.адрес_проживанияTextBox.TabIndex = 5;
            // 
            // полTextBox
            // 
            this.полTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PatientBindingSource, "Пол", true));
            this.полTextBox.Location = new System.Drawing.Point(404, 105);
            this.полTextBox.Name = "полTextBox";
            this.полTextBox.Size = new System.Drawing.Size(346, 29);
            this.полTextBox.TabIndex = 9;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.PatientBindingSource, "Дата рождения", true));
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(404, 70);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(346, 29);
            this.дата_рожденияDateTimePicker.TabIndex = 7;
            // 
            // PatientDataGridView
            // 
            this.PatientDataGridView.AllowUserToAddRows = false;
            this.PatientDataGridView.AllowUserToDeleteRows = false;
            this.PatientDataGridView.AutoGenerateColumns = false;
            this.PatientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.PatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодПациентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.адресПроживанияDataGridViewTextBoxColumn,
            this.датаРожденияDataGridViewTextBoxColumn,
            this.полDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.признакЛьготDataGridViewTextBoxColumn,
            this.PatientChangeColumn,
            this.PatientDeleteColumn});
            this.PatientDataGridView.DataSource = this.PatientBindingSource;
            this.PatientDataGridView.Location = new System.Drawing.Point(6, 25);
            this.PatientDataGridView.Name = "PatientDataGridView";
            this.PatientDataGridView.ReadOnly = true;
            this.PatientDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.PatientDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientDataGridView.RowTemplate.Height = 25;
            this.PatientDataGridView.Size = new System.Drawing.Size(968, 238);
            this.PatientDataGridView.TabIndex = 1;
            this.PatientDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientDataGridView_CellContentClick);
            this.PatientDataGridView.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientDataGridView_CellMouseEnter);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.датаРожденияDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.датаРожденияDataGridViewTextBoxColumn.FillWeight = 90F;
            this.датаРожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датаРожденияDataGridViewTextBoxColumn.Name = "датаРожденияDataGridViewTextBoxColumn";
            this.датаРожденияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // полDataGridViewTextBoxColumn
            // 
            this.полDataGridViewTextBoxColumn.DataPropertyName = "Пол";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.полDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.полDataGridViewTextBoxColumn.FillWeight = 40F;
            this.полDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.полDataGridViewTextBoxColumn.Name = "полDataGridViewTextBoxColumn";
            this.полDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.телефонDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.телефонDataGridViewTextBoxColumn.FillWeight = 90F;
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // признакЛьготDataGridViewTextBoxColumn
            // 
            this.признакЛьготDataGridViewTextBoxColumn.DataPropertyName = "Признак льгот";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.признакЛьготDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
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
            // PatientTableAdapter
            // 
            this.PatientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Polyclinic.PolyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Амбулаторная_картаTableAdapter = null;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.ДиагнозыTableAdapter = null;
            this.tableAdapterManager.Категория_врачебной_специальностиTableAdapter = null;
            this.tableAdapterManager.ПациентTableAdapter = this.PatientTableAdapter;
            this.tableAdapterManager.РегистратураTableAdapter = null;
            // 
            // RegistryViewTableAdapter
            // 
            this.RegistryViewTableAdapter.ClearBeforeFill = true;
            // 
            // RegistryTableAdapter
            // 
            this.RegistryTableAdapter.ClearBeforeFill = true;
            // 
            // DoctorTableAdapter
            // 
            this.DoctorTableAdapter.ClearBeforeFill = true;
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
            this.врачиDataGridView.DataSource = this.DoctorBindingSource;
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
            // CardViewTableAdapter
            // 
            this.CardViewTableAdapter.ClearBeforeFill = true;
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
            this.tabPage1.Controls.Add(this.RegistryGroupBox);
            this.tabPage1.Controls.Add(this.CardGroupBox);
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
            this.диагнозыDataGridView.DataSource = this.DiagnosesBindingSource;
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
            // DiagnosesBindingSource
            // 
            this.DiagnosesBindingSource.DataMember = "Диагнозы";
            this.DiagnosesBindingSource.DataSource = this.polyDataSet;
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
            this.категория_врачебной_специальностиDataGridView.DataSource = this.SpecialtyBindingSource;
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
            // SpecialtyBindingSource
            // 
            this.SpecialtyBindingSource.DataMember = "Категория врачебной специальности";
            this.SpecialtyBindingSource.DataSource = this.polyDataSet;
            // 
            // SpecialtyTableAdapter
            // 
            this.SpecialtyTableAdapter.ClearBeforeFill = true;
            // 
            // DiagnosesTableAdapter
            // 
            this.DiagnosesTableAdapter.ClearBeforeFill = true;
            // 
            // CardPanel
            // 
            this.CardPanel.Controls.Add(this.CardCancelButton);
            this.CardPanel.Controls.Add(this.код_пациентаComboBox1);
            this.CardPanel.Controls.Add(код_врачаLabel1);
            this.CardPanel.Controls.Add(this.код_врачаComboBox1);
            this.CardPanel.Controls.Add(this.код_диагнозаComboBox);
            this.CardPanel.Controls.Add(this.описание_схемы_лечения_и_назначенийTextBox);
            this.CardPanel.Controls.Add(this.CardSaveButton);
            this.CardPanel.Controls.Add(описание_схемы_лечения_и_назначенийLabel);
            this.CardPanel.Controls.Add(код_пациентаLabel1);
            this.CardPanel.Controls.Add(код_диагнозаLabel);
            this.CardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.CardPanel.Location = new System.Drawing.Point(3, 25);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(402, 305);
            this.CardPanel.TabIndex = 18;
            this.CardPanel.Visible = false;
            // 
            // CardCancelButton
            // 
            this.CardCancelButton.Image = global::Polyclinic.Properties.Resources.delete_icon;
            this.CardCancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CardCancelButton.Location = new System.Drawing.Point(224, 236);
            this.CardCancelButton.Name = "CardCancelButton";
            this.CardCancelButton.Size = new System.Drawing.Size(165, 32);
            this.CardCancelButton.TabIndex = 18;
            this.CardCancelButton.Text = "Отмена";
            this.CardCancelButton.UseVisualStyleBackColor = true;
            this.CardCancelButton.Click += new System.EventHandler(this.CardCancelButton_Click);
            // 
            // CardBindingSource
            // 
            this.CardBindingSource.DataMember = "FK_Амбулаторная карта_Пациент";
            this.CardBindingSource.DataSource = this.PatientBindingSource;
            // 
            // код_пациентаComboBox1
            // 
            this.код_пациентаComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CardBindingSource, "Код пациента", true));
            this.код_пациентаComboBox1.DataSource = this.PatientBindingSource;
            this.код_пациентаComboBox1.DisplayMember = "ФИО";
            this.код_пациентаComboBox1.FormattingEnabled = true;
            this.код_пациентаComboBox1.Location = new System.Drawing.Point(92, 6);
            this.код_пациентаComboBox1.Name = "код_пациентаComboBox1";
            this.код_пациентаComboBox1.Size = new System.Drawing.Size(307, 32);
            this.код_пациентаComboBox1.TabIndex = 11;
            this.код_пациентаComboBox1.ValueMember = "Код пациента";
            // 
            // код_врачаComboBox1
            // 
            this.код_врачаComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CardBindingSource, "Код врача", true));
            this.код_врачаComboBox1.DataSource = this.DoctorBindingSource;
            this.код_врачаComboBox1.DisplayMember = "ФИО";
            this.код_врачаComboBox1.FormattingEnabled = true;
            this.код_врачаComboBox1.Location = new System.Drawing.Point(92, 44);
            this.код_врачаComboBox1.Name = "код_врачаComboBox1";
            this.код_врачаComboBox1.Size = new System.Drawing.Size(307, 32);
            this.код_врачаComboBox1.TabIndex = 13;
            this.код_врачаComboBox1.ValueMember = "Код врача";
            // 
            // код_диагнозаComboBox
            // 
            this.код_диагнозаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CardBindingSource, "Код диагноза", true));
            this.код_диагнозаComboBox.DataSource = this.DiagnosesBindingSource;
            this.код_диагнозаComboBox.DisplayMember = "Наименование";
            this.код_диагнозаComboBox.FormattingEnabled = true;
            this.код_диагнозаComboBox.Location = new System.Drawing.Point(92, 82);
            this.код_диагнозаComboBox.Name = "код_диагнозаComboBox";
            this.код_диагнозаComboBox.Size = new System.Drawing.Size(307, 32);
            this.код_диагнозаComboBox.TabIndex = 15;
            this.код_диагнозаComboBox.ValueMember = "Код диагноза";
            // 
            // описание_схемы_лечения_и_назначенийTextBox
            // 
            this.описание_схемы_лечения_и_назначенийTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CardBindingSource, "Описание схемы лечения и назначений", true));
            this.описание_схемы_лечения_и_назначенийTextBox.Location = new System.Drawing.Point(92, 120);
            this.описание_схемы_лечения_и_назначенийTextBox.Multiline = true;
            this.описание_схемы_лечения_и_назначенийTextBox.Name = "описание_схемы_лечения_и_назначенийTextBox";
            this.описание_схемы_лечения_и_назначенийTextBox.Size = new System.Drawing.Size(307, 110);
            this.описание_схемы_лечения_и_назначенийTextBox.TabIndex = 17;
            // 
            // CardTableAdapter
            // 
            this.CardTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1008, 691);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegistryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardViewBindingSource)).EndInit();
            this.CardGroupBox.ResumeLayout(false);
            this.RegistryGroupBox.ResumeLayout(false);
            this.RegistryPanel.ResumeLayout(false);
            this.RegistryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistryViewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistryViewBindingSource)).EndInit();
            this.PatientGroupBox.ResumeLayout(false);
            this.PatientPanel.ResumeLayout(false);
            this.PatientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.врачиDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.диагнозыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiagnosesBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.категория_врачебной_специальностиDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpecialtyBindingSource)).EndInit();
            this.CardPanel.ResumeLayout(false);
            this.CardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CardSaveButton;
        private System.Windows.Forms.Button PatientAddButton;
        private System.Windows.Forms.DataGridView CardViewDataGridView;
        private System.Windows.Forms.GroupBox CardGroupBox;
        private System.Windows.Forms.GroupBox RegistryGroupBox;
        private System.Windows.Forms.GroupBox PatientGroupBox;
        private System.Windows.Forms.DataGridView PatientDataGridView;
        private System.Windows.Forms.DataGridView RegistryViewDataGridView;
        private System.Windows.Forms.BindingSource PatientBindingSource;
        private PolyDataSetTableAdapters.ПациентTableAdapter PatientTableAdapter;
        private PolyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PolyDataSetTableAdapters.СписокРегистратурыTableAdapter RegistryViewTableAdapter;
        private System.Windows.Forms.DataGridView врачиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource RegistryViewBindingSource;
        private System.Windows.Forms.ComboBox код_пациентаComboBox;
        private System.Windows.Forms.ComboBox код_врачаComboBox;
        private System.Windows.Forms.DateTimePicker дата_и_время_приёмаDateTimePicker;
        private System.Windows.Forms.Button RegistryCancelButton;
        private System.Windows.Forms.Button RegistrySaveButton;
        private System.Windows.Forms.BindingSource CardViewBindingSource;
        private PolyDataSetTableAdapters.СхемаЛеченияTableAdapter CardViewTableAdapter;
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
        private System.Windows.Forms.BindingSource DoctorBindingSource;
        private PolyDataSet polyDataSet;
        private PolyDataSetTableAdapters.РегистратураTableAdapter RegistryTableAdapter;
        private PolyDataSetTableAdapters.ВрачиTableAdapter DoctorTableAdapter;
        private System.Windows.Forms.BindingSource RegistryBindingSource;
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
        private System.Windows.Forms.BindingSource SpecialtyBindingSource;
        private PolyDataSetTableAdapters.Категория_врачебной_специальностиTableAdapter SpecialtyTableAdapter;
        private System.Windows.Forms.DataGridView категория_врачебной_специальностиDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource DiagnosesBindingSource;
        private PolyDataSetTableAdapters.ДиагнозыTableAdapter DiagnosesTableAdapter;
        private System.Windows.Forms.DataGridView диагнозыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button CardAddButton;
        private System.Windows.Forms.Button RegistryAddButton;
        private System.Windows.Forms.Button PatientSaveButton;
        private System.Windows.Forms.Button PatientCancelButton;
        private System.Windows.Forms.Panel CardPanel;
        private PolyDataSetTableAdapters.Амбулаторная_картаTableAdapter CardTableAdapter;
        private System.Windows.Forms.ComboBox код_пациентаComboBox1;
        private System.Windows.Forms.ComboBox код_врачаComboBox1;
        private System.Windows.Forms.ComboBox код_диагнозаComboBox;
        private System.Windows.Forms.TextBox описание_схемы_лечения_и_назначенийTextBox;
        private System.Windows.Forms.BindingSource CardBindingSource;
        private System.Windows.Forms.Button CardCancelButton;
    }
}

