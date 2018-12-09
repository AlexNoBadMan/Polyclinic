using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void пациентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пациентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.поликлиникаDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "поликлиникаDataSet.Схема_лечения". При необходимости она может быть перемещена или удалена.
            this.схема_леченияTableAdapter.Fill(this.поликлиникаDataSet.Схема_лечения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "поликлиникаDataSet.СписокРегистратуры". При необходимости она может быть перемещена или удалена.
            this.списокРегистратурыTableAdapter.Fill(this.поликлиникаDataSet.СписокРегистратуры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "поликлиникаDataSet.Пациент". При необходимости она может быть перемещена или удалена.
            this.пациентTableAdapter.Fill(this.поликлиникаDataSet.Пациент);

        }

        private void пациентDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = пациентDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell is DataGridViewLinkCell && cell.Value.Equals("Удалить"))
            {
                var deleteDiaolg = MessageBox.Show($"Вы действительно хотите удалить данные о пациенте \"{пациентDataGridView.Rows[e.RowIndex].Cells[1].Value}\"",
                                                        "Внимание!", MessageBoxButtons.YesNo);
                if (deleteDiaolg == DialogResult.Yes)
                {
                    пациентDataGridView.Rows.RemoveAt(e.RowIndex);
                    пациентTableAdapter.Update(поликлиникаDataSet.Пациент);
                    поликлиникаDataSet.AcceptChanges();
                }
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            пациентDataGridView.Visible = false;
            пациентBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пациентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.поликлиникаDataSet);
            пациентDataGridView.Visible = true;
        }
    }
}
