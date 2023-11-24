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
    public partial class EdinicaIzmereniaForm : Form
    {
        private Form1 form1;
        public EdinicaIzmereniaForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void edinica_izmereniaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.edinica_izmereniaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }

        private void EdinicaIzmereniaForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Edinica_izmerenia". При необходимости она может быть перемещена или удалена.
            this.edinica_izmereniaTableAdapter.Fill(this.mebelDataSet.Edinica_izmerenia);

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
