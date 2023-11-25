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
    public partial class ProizvodstvoProdukciForm : Form
    {
        private Form1 form1;
        public ProizvodstvoProdukciForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void proizvodstvo_produkciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proizvodstvo_produkciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }

        private void ProizvodstvoProdukciForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.mebelDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Gotovoe_produkci". При необходимости она может быть перемещена или удалена.
            this.gotovoe_produkciTableAdapter.Fill(this.mebelDataSet.Gotovoe_produkci);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Proizvodstvo_produkci". При необходимости она может быть перемещена или удалена.
            this.proizvodstvo_produkciTableAdapter.Fill(this.mebelDataSet.Proizvodstvo_produkci);

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

        private void button1_Click(object sender, EventArgs e)
        {
            Report newForm = new Report(dateTimePicker1.Value, dateTimePicker2.Value, "..\\..\\Proiz.rdlc", 3);
            newForm.Show();
        }
    }
}
