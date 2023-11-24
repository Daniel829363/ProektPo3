using System;
using System.Windows.Forms;

namespace ProektPo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public void AddDataToPanel(Form data)
        {
            panel1.Controls.Add(data);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);

            // Установите родителя для формы в Panel.
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(newForm);

            // Покажите форму.
            newForm.Show();
        }
    }
}
