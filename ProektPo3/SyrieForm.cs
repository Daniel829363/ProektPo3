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
    public partial class SyrieForm : Form
    {
        private Form1 form1;
        public SyrieForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void syrieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.syrieBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }

        private void SyrieForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Edinica_izmerenia". При необходимости она может быть перемещена или удалена.
            this.edinica_izmereniaTableAdapter.Fill(this.mebelDataSet.Edinica_izmerenia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Syrie". При необходимости она может быть перемещена или удалена.
            this.syrieTableAdapter.Fill(this.mebelDataSet.Syrie);

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
