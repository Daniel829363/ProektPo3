using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektPo3
{
    public partial class ZakupkaSyriaForm : Form
    {
        private Form1 form1;
        public ZakupkaSyriaForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void zakupka_syriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zakupka_syriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }
        BudjetForm budjetForm = new BudjetForm();
        private void ZakupkaSyriaForm_Load(object sender, EventArgs e)
        {
            
            
            textBox1.Text = budjetForm.Budjetsum();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Syrie". При необходимости она может быть перемещена или удалена.
            this.syrieTableAdapter.Fill(this.mebelDataSet.Syrie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.mebelDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Zakupka_syria". При необходимости она может быть перемещена или удалена.
            this.zakupka_syriaTableAdapter.Fill(this.mebelDataSet.Zakupka_syria);

        }

        private void backtoform2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(form1);
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            newForm.TopLevel = false;
            form1.AddDataToPanel(newForm);
            newForm.Show();
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            dataDateTimePicker.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report newForm = new Report(dateTimePicker1.Value, dateTimePicker2.Value, "..\\..\\Zakupka.rdlc",1);
            newForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
