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
    public partial class GotovoeProdukciForm : Form
    {
        private Form1 form1;
        public GotovoeProdukciForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void gotovoe_produkciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gotovoe_produkciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }

        private void GotovoeProdukciForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Edinica_izmerenia". При необходимости она может быть перемещена или удалена.
            this.edinica_izmereniaTableAdapter.Fill(this.mebelDataSet.Edinica_izmerenia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Gotovoe_produkci". При необходимости она может быть перемещена или удалена.
            this.gotovoe_produkciTableAdapter.Fill(this.mebelDataSet.Gotovoe_produkci);

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
