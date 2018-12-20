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
            регистратураBindingSource.EndEdit();
            регистратураTableAdapter.Update(polyDataSet);
            списокРегистратурыTableAdapter.Fill(polyDataSet.СписокРегистратуры);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.Диагнозы". При необходимости она может быть перемещена или удалена.
            this.диагнозыTableAdapter.Fill(this.polyDataSet.Диагнозы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.Категория_врачебной_специальности". При необходимости она может быть перемещена или удалена.
            this.категория_врачебной_специальностиTableAdapter.Fill(this.polyDataSet.Категория_врачебной_специальности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.СхемаЛечения". При необходимости она может быть перемещена или удалена.
            this.схемаЛеченияTableAdapter.Fill(this.polyDataSet.СхемаЛечения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.Пациент". При необходимости она может быть перемещена или удалена.
            this.пациентTableAdapter.Fill(this.polyDataSet.Пациент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.polyDataSet.Врачи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.Регистратура". При необходимости она может быть перемещена или удалена.
            this.регистратураTableAdapter.Fill(this.polyDataSet.Регистратура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "polyDataSet.СписокРегистратуры". При необходимости она может быть перемещена или удалена.
            this.списокРегистратурыTableAdapter.Fill(this.polyDataSet.СписокРегистратуры);
        }


        private void PatientAddButton_Click(object sender, EventArgs e)
        {
            пациентBindingSource.AddNew();
            дата_рожденияDateTimePicker.Value = DateTime.Parse("12.12.2000");
            ChangeDisplayElements(пациентDataGridView, PatientAddButton, PatientPanel, false);
        }

        private void PatientSaveButton_Click(object sender, EventArgs e)
        {
            SaveChanges(пациентBindingSource);
            ChangeDisplayElements(пациентDataGridView, PatientAddButton, PatientPanel, true);
        }

        private void PatientCancelButton_Click(object sender, EventArgs e)
        {
            пациентBindingSource.CancelEdit();
            ChangeDisplayElements(пациентDataGridView, PatientAddButton, PatientPanel, true);
        }

        private void пациентDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            пациентDataGridView.Cursor = e.ColumnIndex > 6 ? Cursors.Hand : Cursors.Default;
        }

        private void пациентDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 8)
            {
                var deleteDiaolg = MessageBox.Show($"Вы действительно хотите удалить данные о пациенте \"{пациентDataGridView.Rows[e.RowIndex].Cells[1].Value}\"",
                                        "Внимание!", MessageBoxButtons.YesNo);
                if (deleteDiaolg == DialogResult.Yes)
                {
                    пациентDataGridView.Rows.RemoveAt(e.RowIndex);
                    SaveChanges(пациентBindingSource);
                }
                return;
            }

            if (e.ColumnIndex == 7)
            {
                ChangeDisplayElements(пациентDataGridView, PatientAddButton, PatientPanel, false);
            }
        }

        private void списокРегистратурыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 7)
            {
                var deleteDiaolg = MessageBox.Show($"Вы действительно хотите удалить данные о пациенте",
                                                        "Внимание!", MessageBoxButtons.YesNo);
                if (deleteDiaolg == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(списокРегистратурыDataGridView.Rows[e.RowIndex].Cells[0].Value);
                    polyDataSet.Регистратура.First(x => x.id == id).Delete();
                    RegistrySaveChanges();
                }
                return;
            }
            if (e.ColumnIndex == 6)
            {
                ChangeDisplayElements(списокРегистратурыDataGridView, RegistryAddButton, RegistryPanel, false);
            }
        }

        private void RegistryAddButton_Click(object sender, EventArgs e)
        {
            регистратураBindingSource.AddNew();
            дата_и_время_приёмаDateTimePicker.Value = DateTime.Now;
            ChangeDisplayElements(списокРегистратурыDataGridView, RegistryAddButton, RegistryPanel, false);
        }

        private void RegistryCancelButton_Click(object sender, EventArgs e)
        {
            регистратураBindingSource.CancelEdit();
            ChangeDisplayElements(списокРегистратурыDataGridView, RegistryAddButton, RegistryPanel, true);
        }

        private void RegistrySaveButton_Click(object sender, EventArgs e)
        {
            RegistrySaveChanges();
            ChangeDisplayElements(списокРегистратурыDataGridView, RegistryAddButton, RegistryPanel, true);
        }

        private void списокРегистратурыDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            регистратураBindingSource.Position = e.RowIndex;
        }

        private void списокРегистратурыDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            списокРегистратурыDataGridView.Cursor = e.ColumnIndex > 5 ? Cursors.Hand : Cursors.Default;
        }
    }
}
