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
    public partial class DoljnostiForm : Form
    {
        private Form1 form1;
        public DoljnostiForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void doljnostiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doljnostiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }

        private void DoljnostiForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Doljnosti". При необходимости она может быть перемещена или удалена.
            this.doljnostiTableAdapter.Fill(this.mebelDataSet.Doljnosti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Doljnosti". При необходимости она может быть перемещена или удалена.
            this.doljnostiTableAdapter.Fill(this.mebelDataSet.Doljnosti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Doljnosti". При необходимости она может быть перемещена или удалена.
            this.doljnostiTableAdapter.Fill(this.mebelDataSet.Doljnosti);

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

        private void doljnostiBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.doljnostiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }

        private void doljnostiBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.doljnostiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }
    }
}
