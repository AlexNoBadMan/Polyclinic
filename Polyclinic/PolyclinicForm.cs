using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop;

namespace Polyclinic
{
    public partial class PolyclinicForm : Form
    {
        public PolyclinicForm()
        {
            InitializeComponent();
        }

        #region Методы
        enum ResultClick
        {
            None,
            Change,
            Delete,
            Other
        }

        private ResultClick ResultCellContenClick(DataGridViewCellEventArgs e, DataGridView dataGridView, string message)
        {
            if (e.ColumnIndex == dataGridView.ColumnCount - 1)
            {
                var deleteDiaolg = MessageBox.Show(message, "Внимание!", MessageBoxButtons.YesNo);
                if (deleteDiaolg == DialogResult.Yes)
                {
                    return ResultClick.Delete;
                }
                return ResultClick.None;
            }
            if (e.ColumnIndex == dataGridView.ColumnCount - 2)
            {
                return ResultClick.Change;
            }
            return ResultClick.Other;
        }

        private void ChangeCursor(DataGridViewCellEventArgs e, DataGridView dataGridView)
        {
            dataGridView.Cursor = e.ColumnIndex > dataGridView.ColumnCount - 3 ? Cursors.Hand : Cursors.Default;
        }

        private void RegistrySaveChanges()
        {
            Validate();
            RegistryBindingSource.EndEdit();
            RegistryTableAdapter.Update(polyDataSet);
            RegistryViewTableAdapter.Fill(polyDataSet.СписокРегистратуры);
        }

        private void CardSaveChanges()
        {
            Validate();
            CardBindingSource.EndEdit();
            CardTableAdapter.Update(polyDataSet);
            CardViewTableAdapter.Fill(polyDataSet.СхемаЛечения);
        }

        private void DoctorSaveChanges()
        {
            Validate();
            DoctorBindingSource.EndEdit();
            DoctorTableAdapter.Update(polyDataSet);
        }

        private void DiagnosesSaveChanges()
        {
            Validate();
            DiagnosesBindingSource.EndEdit();
            DiagnosesTableAdapter.Update(polyDataSet);
        }

        private void SpecialtySaveChanges()
        {
            Validate();
            SpecialtyBindingSource.EndEdit();
            SpecialtyTableAdapter.Update(polyDataSet);
        }

        private void SaveChanges(BindingSource bindingSource)
        {
            Validate();
            bindingSource.EndEdit();
            tableAdapterManager.UpdateAll(polyDataSet);
        }

        public void ChangeDisplayElements(DataGridView dataGrid, Button button, Panel panel, bool show)
        {
            if (show)
           {
                dataGrid.Visible = true;
                button.Visible = true;
                panel.Visible = false;
            }
            else
            {
                dataGrid.Visible = false;
                button.Visible = false;
                panel.Visible = true;
            }
        }

        public void EnableDisplayElements(bool enable)
        {
            if (enable)
            {
                ControlBox = true;
                ((Control)tabPage2).Enabled = true;
                ((Control)tabPage3).Enabled = true;
                ((Control)tabPage4).Enabled = true;
            }
            else
            {
                ControlBox = false;
                ((Control)tabPage2).Enabled = false;
                ((Control)tabPage3).Enabled = false;
                ((Control)tabPage4).Enabled = false;
            }
        }

        private void EnableDisplayElements(DataGridView dataGridView, Button button, Panel panel, bool show)
        {
            if (show)
            {
                dataGridView.Enabled = true;
                dataGridView.Height = 608;
                button.Visible = true;
                panel.Visible = false;
            }
            else
            {
                dataGridView.Enabled = false;
                dataGridView.Height = 464;
                button.Visible = false;
                panel.Visible = true;
            }
        }

        private void ExportInExcel(DataGridView dataGridView)
        {
            try
            {
                WaitForm waitForm = new WaitForm();
                waitForm.Show();

                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dataGridView.ColumnCount - 2; i++)
                {
                    ExcelApp.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;

                    for (int j = 0; j < dataGridView.RowCount; j++)
                    {
                        ExcelApp.Cells[j + 2, i + 1] = (dataGridView[i, j].Value).ToString();
                    }
                }
                ExcelApp.Columns.AutoFit();
                ExcelApp.Visible = true;

                waitForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка экспорта: " + ex.Message);
            }
        }
        #endregion

        private void PolyclinicForm_Load(object sender, EventArgs e)
        {
            DoctorDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold);
            CardTableAdapter.Fill(polyDataSet.Амбулаторная_карта);
            DiagnosesTableAdapter.Fill(polyDataSet.Диагнозы);
            SpecialtyTableAdapter.Fill(polyDataSet.Категория_врачебной_специальности);
            CardViewTableAdapter.Fill(polyDataSet.СхемаЛечения);
            PatientTableAdapter.Fill(polyDataSet.Пациент);
            DoctorTableAdapter.Fill(polyDataSet.Врачи);
            RegistryTableAdapter.Fill(polyDataSet.Регистратура);
            RegistryViewTableAdapter.Fill(polyDataSet.СписокРегистратуры);
        }

        private void PolyclinicForm_SizeChanged(object sender, EventArgs e)
        {
            PolyclinicTabControl.Left = ClientSize.Width / 2 - PolyclinicTabControl.Width / 2;
            PolyclinicTabControl.Top = ClientSize.Height / 2 - PolyclinicTabControl.Height / 2;
        }


        #region Работа с данными таблицы "Пациент"
        private void PatientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < PatientDataGridView.ColumnCount - 2)
            {
                return;
            }

            var resultClick = ResultCellContenClick(e, PatientDataGridView,
                $"Вы действительно хотите удалить данные о пациенте \"{PatientDataGridView.Rows[e.RowIndex].Cells[1].Value}\"");
            if (resultClick == ResultClick.Delete)
            {
                PatientDataGridView.Rows.RemoveAt(e.RowIndex);
                SaveChanges(PatientBindingSource);
            }
            else if (resultClick == ResultClick.Change)
            {
                EnableDisplayElements(false);
                ChangeDisplayElements(PatientDataGridView, PatientAddButton, PatientPanel, false);
            }
        }

        private void PatientDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, PatientDataGridView);
        }

        private void PatientAddButton_Click(object sender, EventArgs e)
        {
            EnableDisplayElements(false);
            PatientBindingSource.AddNew();
            полComboBox.SelectedValue = -1;
            льготыComboBox.SelectedValue = -1;
            дата_рожденияDateTimePicker.Value = DateTime.Parse("12.12.2000");
            ChangeDisplayElements(PatientDataGridView, PatientAddButton, PatientPanel, false);
        }

        private void PatientSaveButton_Click(object sender, EventArgs e)
        {
            EnableDisplayElements(true);
            SaveChanges(PatientBindingSource);
            ChangeDisplayElements(PatientDataGridView, PatientAddButton, PatientPanel, true);
        }

        private void PatientCancelButton_Click(object sender, EventArgs e)
        {
            EnableDisplayElements(true);
            PatientBindingSource.CancelEdit();
            ChangeDisplayElements(PatientDataGridView, PatientAddButton, PatientPanel, true);
        }
        #endregion

        #region Работа с данными представления "Список Регистратуры"
        private void RegistryViewDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistryBindingSource.Position = e.RowIndex;
        }

        private void RegistryViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < RegistryViewDataGridView.ColumnCount - 2)
            {
                return;
            }

            var resultClick = ResultCellContenClick(e, RegistryViewDataGridView, "Вы действительно хотите удалить данные о приёме");
            if (resultClick == ResultClick.Delete)
            {
                var id = Convert.ToInt32(RegistryViewDataGridView.Rows[e.RowIndex].Cells[0].Value);
                polyDataSet.Регистратура.First(x => x.id == id).Delete();
                RegistrySaveChanges();
            }
            else if (resultClick == ResultClick.Change)
            {
                EnableDisplayElements(false);
                PatientGroupBox.Enabled = false;
                ChangeDisplayElements(RegistryViewDataGridView, RegistryAddButton, RegistryPanel, false);
            }
        }

        private void RegistryViewDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, RegistryViewDataGridView);
        }

        private void RegistryAddButton_Click(object sender, EventArgs e)
        {
            EnableDisplayElements(false);
            RegistryBindingSource.AddNew();
            PatientGroupBox.Enabled = false;
            код_пациентаComboBox.SelectedValue = PatientDataGridView.CurrentRow.Cells[0].Value;
            дата_и_время_приёмаDateTimePicker.Value = DateTime.Now;
            ChangeDisplayElements(RegistryViewDataGridView, RegistryAddButton, RegistryPanel, false);
        }

        private void RegistrySaveButton_Click(object sender, EventArgs e)
        {
            RegistrySaveChanges();
            EnableDisplayElements(true);
            PatientGroupBox.Enabled = true;
            ChangeDisplayElements(RegistryViewDataGridView, RegistryAddButton, RegistryPanel, true);
        }

        private void RegistryCancelButton_Click(object sender, EventArgs e)
        {
            EnableDisplayElements(true);
            PatientGroupBox.Enabled = true;
            RegistryBindingSource.CancelEdit();
            ChangeDisplayElements(RegistryViewDataGridView, RegistryAddButton, RegistryPanel, true);
        }
        #endregion

        #region Работа с данными представления "Схема лечения"
        private void CardViewDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CardBindingSource.Position = e.RowIndex;
        }

        private void CardViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < CardViewDataGridView.ColumnCount - 2)
            {
                return;
            }

            var resultClick = ResultCellContenClick(e, CardViewDataGridView, "Вы действительно хотите удалить данные о диагнозе");
            if (resultClick == ResultClick.Delete)
            {
                var id = Convert.ToInt32(CardViewDataGridView.Rows[e.RowIndex].Cells[0].Value);
                polyDataSet.Амбулаторная_карта.First(x => x.id == id).Delete();
                CardSaveChanges();
            }
            else if (resultClick == ResultClick.Change)
            {
                EnableDisplayElements(false);
                PatientGroupBox.Enabled = false;
                ChangeDisplayElements(CardViewDataGridView, CardAddButton, CardPanel, false);
            }
        }

        private void CardViewDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, CardViewDataGridView);
        }

        private void CardAddButton_Click(object sender, EventArgs e)
        {
            CardBindingSource.AddNew();
            EnableDisplayElements(false);
            PatientGroupBox.Enabled = false;
            код_пациентаComboBox1.SelectedValue = PatientDataGridView.CurrentRow.Cells[0].Value;
            ChangeDisplayElements(CardViewDataGridView, CardAddButton, CardPanel, false);
        }

        private void CardSaveButton_Click(object sender, EventArgs e)
        {
            CardSaveChanges();
            EnableDisplayElements(true);
            PatientGroupBox.Enabled = true;
            ChangeDisplayElements(CardViewDataGridView, CardAddButton, CardPanel, true);
        }

        private void CardCancelButton_Click(object sender, EventArgs e)
        {
            EnableDisplayElements(true);
            CardBindingSource.CancelEdit();
            PatientGroupBox.Enabled = true;
            ChangeDisplayElements(CardViewDataGridView, CardAddButton, CardPanel, true);
        }
        #endregion

        #region Работа с данными таблицы "Врачи"
        private void DoctorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < DoctorDataGridView.ColumnCount - 2)
            {
                return;
            }

            var result = ResultCellContenClick(e, DoctorDataGridView, $"Вы действительно хотите удалить данные о {DoctorDataGridView.Rows[e.RowIndex].Cells[1].Value}");
            if (result == ResultClick.Delete)
            {
                DoctorDataGridView.Rows.RemoveAt(e.RowIndex);
                DoctorSaveChanges();
            }
            else if (result == ResultClick.Change)
            {
                EnableDisplayElements(DoctorDataGridView, DoctorAddButton, DoctorPanel, false);
            }
        }

        private void DoctorDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, DoctorDataGridView);
        }

        private void DoctorAddButton_Click(object sender, EventArgs e)
        {
            DoctorBindingSource.AddNew();
            EnableDisplayElements(DoctorDataGridView, DoctorAddButton, DoctorPanel, false);
        }

        private void DoctorSaveButton_Click(object sender, EventArgs e)
        {
            DoctorSaveChanges();
            EnableDisplayElements(DoctorDataGridView, DoctorAddButton, DoctorPanel, true);
        }

        private void DoctorCancelButton_Click(object sender, EventArgs e)
        {
            DoctorBindingSource.CancelEdit();
            EnableDisplayElements(DoctorDataGridView, DoctorAddButton, DoctorPanel, true);
        }
        #endregion

        #region Работа с данными таблицы "Диагнозы"
        private void DiagnosesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < DiagnosesDataGridView.ColumnCount - 2)
            {
                return;
            }

            var result = ResultCellContenClick(e, DiagnosesDataGridView, "Вы действительно хотите удалить данные о диагнозе");
            if (result == ResultClick.Delete)
            {
                DiagnosesDataGridView.Rows.RemoveAt(e.RowIndex);
                DiagnosesSaveChanges();
            }
            else if (result == ResultClick.Change)
            {
                EnableDisplayElements(DiagnosesDataGridView, DiagnosesAddButton, DiagnosesPanel, false);
            }
        }

        private void DiagnosesDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, DiagnosesDataGridView);
        }

        private void DiagnosesAddButton_Click(object sender, EventArgs e)
        {
            DiagnosesBindingSource.AddNew();
            EnableDisplayElements(DiagnosesDataGridView, DiagnosesAddButton, DiagnosesPanel, false);
        }

        private void DiagnosesSaveButton_Click(object sender, EventArgs e)
        {
            DiagnosesSaveChanges();
            EnableDisplayElements(DiagnosesDataGridView, DiagnosesAddButton, DiagnosesPanel, true);
        }

        private void DiagnosesCancelButton_Click(object sender, EventArgs e)
        {
            DiagnosesBindingSource.CancelEdit();
            EnableDisplayElements(DiagnosesDataGridView, DiagnosesAddButton, DiagnosesPanel, true);
        }
        #endregion

        #region Работа с данными таблицы "Категория врачебной специальности"
        private void SpecialtyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < SpecialtyDataGridView.ColumnCount - 2)
            {
                return;
            }

            var result = ResultCellContenClick(e, SpecialtyDataGridView, "Вы действительно хотите удалить данные о диагнозе");
            if (result == ResultClick.Delete)
            {
                SpecialtyDataGridView.Rows.RemoveAt(e.RowIndex);
                SpecialtySaveChanges();
            }
            else if (result == ResultClick.Change)
            {
                EnableDisplayElements(SpecialtyDataGridView, SpecialtyAddButton, SpecialtyPanel, false);
            }
        }

        private void SpecialtyDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            ChangeCursor(e, SpecialtyDataGridView);
        }

        private void SpecialtyAddButton_Click(object sender, EventArgs e)
        {
            SpecialtyBindingSource.AddNew();
            EnableDisplayElements(SpecialtyDataGridView, SpecialtyAddButton, SpecialtyPanel, false);
        }

        private void SpecialtySaveButton_Click(object sender, EventArgs e)
        {
            SpecialtySaveChanges();
            EnableDisplayElements(SpecialtyDataGridView, SpecialtyAddButton, SpecialtyPanel, true);
        }

        private void SpecialtyCancelButton_Click(object sender, EventArgs e)
        {
            SpecialtyBindingSource.CancelEdit();
            EnableDisplayElements(SpecialtyDataGridView, SpecialtyAddButton, SpecialtyPanel, true);
        }
        #endregion

        #region Экспорт в Excel
        private void DoctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportInExcel(DoctorDataGridView);
        }

        private void PatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportInExcel(PatientDataGridView);
        }

        private void DiagnosesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportInExcel(DiagnosesDataGridView);
        }

        private void RegistryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportInExcel(RegistryViewDataGridView);
        }

        private void CardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportInExcel(CardViewDataGridView);
        }

        private void SpecialtyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportInExcel(SpecialtyDataGridView);
        }
        #endregion

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
