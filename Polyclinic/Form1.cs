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
            //tableAdapterManager.UpdateAll(polyDataSet);
        }

        private void пациентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           /* this.Validate();
            this.пациентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.поликлиникаDataSet);*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                    Validate();
                    пациентBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(polyDataSet);
                    
                }
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* пациентDataGridView.Visible = false;*/
//             пациентBindingSource.AddNew();
            регистратураBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //пациентDataGridView.Visible = true;
        }

        private void списокРегистратурыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 7)
            {
               /* var cell = списокРегистратурыDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell is DataGridViewLinkCell && cell.Value.Equals("Удалить"))
                {*/
                    var deleteDiaolg = MessageBox.Show($"Вы действительно хотите удалить данные о пациенте",
                                                            "Внимание!", MessageBoxButtons.YesNo);
                    if (deleteDiaolg == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(списокРегистратурыDataGridView.Rows[e.RowIndex].Cells[0].Value);
                        polyDataSet.Регистратура.First(x => x.id == id).Delete();
                        //polyDataSet.Регистратура.Rows.Remove(www);
                        //www.Delete();
                        //
                        //регистратураDataGridView.Rows.RemoveAt(e.RowIndex);
                        //списокРегистратурыTableAdapter.Update();
                        Validate();
                        регистратураBindingSource.EndEdit();
                        списокРегистратурыBindingSource.EndEdit();
                        регистратураTableAdapter.Update(polyDataSet);
                        //tableAdapterManager.UpdateAll(polyDataSet);
                        списокРегистратурыTableAdapter.Fill(polyDataSet.СписокРегистратуры);//списокРегистратурыDataGridView.Rows.RemoveAt(e.RowIndex);
                                                                                            //                        polyDataSet.AcceptChanges();
                    }
                    return;
                //}
            }

        }

        private void RegistrySave_Click(object sender, EventArgs e)
        {
            RegistrySaveChanges();
        }

        private void RegistryCancel_Click(object sender, EventArgs e)
        {
            регистратураBindingSource.CancelEdit();
        }

        private void списокРегистратурыDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            регистратураBindingSource.Position = e.RowIndex;
        }
    }
}
