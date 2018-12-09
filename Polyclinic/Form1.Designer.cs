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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.поликлиникаDataSet = new Polyclinic.ПоликлиникаDataSet();
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пациентTableAdapter = new Polyclinic.ПоликлиникаDataSetTableAdapters.ПациентTableAdapter();
            this.tableAdapterManager = new Polyclinic.ПоликлиникаDataSetTableAdapters.TableAdapterManager();
            this.пациентBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.пациентBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.пациентDataGridView = new System.Windows.Forms.DataGridView();
            this.списокРегистратурыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокРегистратурыTableAdapter = new Polyclinic.ПоликлиникаDataSetTableAdapters.СписокРегистратурыTableAdapter();
            this.списокРегистратурыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingNavigator)).BeginInit();
            this.пациентBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пациентDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // поликлиникаDataSet
            // 
            this.поликлиникаDataSet.DataSetName = "ПоликлиникаDataSet";
            this.поликлиникаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пациентBindingSource
            // 
            this.пациентBindingSource.DataMember = "Пациент";
            this.пациентBindingSource.DataSource = this.поликлиникаDataSet;
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
            // пациентBindingNavigator
            // 
            this.пациентBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.пациентBindingNavigator.BindingSource = this.пациентBindingSource;
            this.пациентBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.пациентBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.пациентBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.пациентBindingNavigatorSaveItem});
            this.пациентBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.пациентBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.пациентBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.пациентBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.пациентBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.пациентBindingNavigator.Name = "пациентBindingNavigator";
            this.пациентBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.пациентBindingNavigator.Size = new System.Drawing.Size(1166, 25);
            this.пациентBindingNavigator.TabIndex = 0;
            this.пациентBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // пациентBindingNavigatorSaveItem
            // 
            this.пациентBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.пациентBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("пациентBindingNavigatorSaveItem.Image")));
            this.пациентBindingNavigatorSaveItem.Name = "пациентBindingNavigatorSaveItem";
            this.пациентBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.пациентBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.пациентBindingNavigatorSaveItem.Click += new System.EventHandler(this.пациентBindingNavigatorSaveItem_Click);
            // 
            // пациентDataGridView
            // 
            this.пациентDataGridView.AllowUserToAddRows = false;
            this.пациентDataGridView.AllowUserToDeleteRows = false;
            this.пациентDataGridView.AutoGenerateColumns = false;
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
            this.пациентDataGridView.Location = new System.Drawing.Point(12, 28);
            this.пациентDataGridView.Name = "пациентDataGridView";
            this.пациентDataGridView.ReadOnly = true;
            this.пациентDataGridView.RowHeadersVisible = false;
            this.пациентDataGridView.Size = new System.Drawing.Size(974, 220);
            this.пациентDataGridView.TabIndex = 1;
            this.пациентDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.пациентDataGridView_CellClick);
            this.пациентDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.пациентDataGridView_CellContentClick);
            // 
            // списокРегистратурыBindingSource
            // 
            this.списокРегистратурыBindingSource.DataMember = "Пациент_СписокРегистратуры";
            this.списокРегистратурыBindingSource.DataSource = this.пациентBindingSource;
            // 
            // списокРегистратурыTableAdapter
            // 
            this.списокРегистратурыTableAdapter.ClearBeforeFill = true;
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
            this.списокРегистратурыDataGridView.Location = new System.Drawing.Point(12, 254);
            this.списокРегистратурыDataGridView.Name = "списокРегистратурыDataGridView";
            this.списокРегистратурыDataGridView.RowHeadersVisible = false;
            this.списокРегистратурыDataGridView.Size = new System.Drawing.Size(974, 159);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код пациента";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код пациента";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Адрес проживания";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адрес проживания";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Дата рождения";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Пол";
            this.dataGridViewTextBoxColumn5.HeaderText = "Пол";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn6.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Признак льгот";
            this.dataGridViewTextBoxColumn7.HeaderText = "Признак льгот";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Image = global::Polyclinic.Properties.Resources.DeleteRed;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 533);
            this.Controls.Add(this.списокРегистратурыDataGridView);
            this.Controls.Add(this.пациентDataGridView);
            this.Controls.Add(this.пациентBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.поликлиникаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingNavigator)).EndInit();
            this.пациентBindingNavigator.ResumeLayout(false);
            this.пациентBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.пациентDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокРегистратурыDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ПоликлиникаDataSet поликлиникаDataSet;
        private System.Windows.Forms.BindingSource пациентBindingSource;
        private ПоликлиникаDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private ПоликлиникаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator пациентBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton пациентBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView пациентDataGridView;
        private System.Windows.Forms.BindingSource списокРегистратурыBindingSource;
        private ПоликлиникаDataSetTableAdapters.СписокРегистратурыTableAdapter списокРегистратурыTableAdapter;
        private System.Windows.Forms.DataGridView списокРегистратурыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
    }
}

