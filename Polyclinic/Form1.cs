using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyclinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                
                ((Control)tabPage2).Enabled = true;
                ((Control)tabPage3).Enabled = true;
                ((Control)tabPage4).Enabled = true;
            }
            else
            {
                ((Control)tabPage2).Enabled = false;
                ((Control)tabPage3).Enabled = false;
                ((Control)tabPage4).Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.Амбулаторная_карта". При необходимости она может быть перемещена или удалена.
            this.CardTableAdapter.Fill(this.polyDataSet.Амбулаторная_карта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.Диагнозы". При необходимости она может быть перемещена или удалена.
            this.DiagnosesTableAdapter.Fill(this.polyDataSet.Диагнозы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.Категория_врачебной_специальности". При необходимости она может быть перемещена или удалена.
            this.SpecialtyTableAdapter.Fill(this.polyDataSet.Категория_врачебной_специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.СхемаЛечения". При необходимости она может быть перемещена или удалена.
            this.CardViewTableAdapter.Fill(this.polyDataSet.СхемаЛечения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.Пациент". При необходимости она может быть перемещена или удалена.
            this.PatientTableAdapter.Fill(this.polyDataSet.Пациент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.DoctorTableAdapter.Fill(this.polyDataSet.Врачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.Регистратура". При необходимости она может быть перемещена или удалена.
            this.RegistryTableAdapter.Fill(this.polyDataSet.Регистратура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.СписокРегистратуры". При необходимости она может быть перемещена или удалена.
            this.RegistryViewTableAdapter.Fill(this.polyDataSet.СписокРегистратуры);
        }

        private void PatientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 8)
            {
                var deleteDiaolg = MessageBox.Show($"Вы действительно хотите удалить данные о пациенте \"{PatientDataGridView.Rows[e.RowIndex].Cells[1].Value}\"",
                                        "Внимание!", MessageBoxButtons.YesNo);
                if (deleteDiaolg == DialogResult.Yes)
                {
                    PatientDataGridView.Rows.RemoveAt(e.RowIndex);
                    SaveChanges(PatientBindingSource);
                }
                return;
            }

            if (e.ColumnIndex == 7)
            {
                EnableDisplayElements(false);
                ChangeDisplayElements(PatientDataGridView, PatientAddButton, PatientPanel, false);
            }
        }

        private void PatientDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            PatientDataGridView.Cursor = e.ColumnIndex > 6 ? Cursors.Hand : Cursors.Default;
        }

        private void PatientAddButton_Click(object sender, EventArgs e)
        {
            EnableDisplayElements(false);
            PatientBindingSource.AddNew();
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

        private void RegistryViewDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RegistryBindingSource.Position = e.RowIndex;
        }

        private void RegistryViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 7)
            {
                var deleteDiaolg = MessageBox.Show($"Вы действительно хотите удалить данные о приёме",
                                                        "Внимание!", MessageBoxButtons.YesNo);
                if (deleteDiaolg == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(RegistryViewDataGridView.Rows[e.RowIndex].Cells[0].Value);
                    polyDataSet.Регистратура.First(x => x.id == id).Delete();
                    RegistrySaveChanges();
                }
                return;
            }

            if (e.ColumnIndex == 6)
            {
                EnableDisplayElements(false);
                PatientGroupBox.Enabled = false;
                ChangeDisplayElements(RegistryViewDataGridView, RegistryAddButton, RegistryPanel, false);
            }
        }

        private void RegistryViewDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            RegistryViewDataGridView.Cursor = e.ColumnIndex > 5 ? Cursors.Hand : Cursors.Default;
        }

        private void RegistryAddButton_Click(object sender, EventArgs e)
        {
            EnableDisplayElements(false);
            RegistryBindingSource.AddNew();
            PatientGroupBox.Enabled = false;
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

        private void CardViewDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CardBindingSource.Position = e.RowIndex;
        }

        private void CardViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 7)
            {
                var deleteDiaolg = MessageBox.Show($"Вы действительно хотите удалить данные о диагнозе",
                                                        "Внимание!", MessageBoxButtons.YesNo);
                if (deleteDiaolg == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(CardViewDataGridView.Rows[e.RowIndex].Cells[0].Value);
                    polyDataSet.Амбулаторная_карта.First(x => x.id == id).Delete();
                    CardSaveChanges();
                }
                return;
            }

            if (e.ColumnIndex == 6)
            {
                EnableDisplayElements(false);
                PatientGroupBox.Enabled = false;
                ChangeDisplayElements(CardViewDataGridView, CardAddButton, CardPanel, false);
            }
        }

        private void CardViewDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            CardViewDataGridView.Cursor = e.ColumnIndex > 5 ? Cursors.Hand : Cursors.Default;
        }

        private void CardAddButton_Click(object sender, EventArgs e)
        {
            CardBindingSource.AddNew();
            EnableDisplayElements(false);
            PatientGroupBox.Enabled = false;
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
    }
}
