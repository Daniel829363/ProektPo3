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
    public partial class IngridientyForm : Form
    {
        private Form1 form1;
        public IngridientyForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void ingridientyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingridientyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }

        private void IngridientyForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Syrie". При необходимости она может быть перемещена или удалена.
            this.syrieTableAdapter.Fill(this.mebelDataSet.Syrie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Gotovoe_produkci". При необходимости она может быть перемещена или удалена.
            this.gotovoe_produkciTableAdapter.Fill(this.mebelDataSet.Gotovoe_produkci);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Ingridienty". При необходимости она может быть перемещена или удалена.
            this.ingridientyTableAdapter.Fill(this.mebelDataSet.Ingridienty);

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
    }
}
