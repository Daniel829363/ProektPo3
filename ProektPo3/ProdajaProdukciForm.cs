using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektPo3
{
    public partial class ProdajaProdukciForm : Form
    {
        private Form1 form1;
        private Form2 form2;
        public ProdajaProdukciForm(Form1 form1,Form2 form2)
        {
            InitializeComponent();
            this.form1 = form1;
            this.form2 = form2;
        }

        private void prodaja_produkciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prodaja_produkciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mebelDataSet);

        }
        BudjetForm budjetForm=new BudjetForm();
        public string retCountGP(String id)
        {
            string query = "SELECT Count FROM Gotovoe_produkci WHERE id="+id;

            using (SqlConnection connection = new SqlConnection(budjetForm.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        // Используйте ExecuteScalar для получения одного значения
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            // Замените textBox1 на имя вашего TextBox
                            return result.ToString();
                        }
                        else
                        {
                            return ("Значение не найдено.");
                        }
                    }
                    catch (Exception ex)
                    {
                        return ("Ошибка: " + ex.Message);
                    }
                }
            }
        }
        private void ProdajaProdukciForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.mebelDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Gotovoe_produkci". При необходимости она может быть перемещена или удалена.
            this.gotovoe_produkciTableAdapter.Fill(this.mebelDataSet.Gotovoe_produkci);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Prodaja_produkci". При необходимости она может быть перемещена или удалена.
            this.prodaja_produkciTableAdapter.Fill(this.mebelDataSet.Prodaja_produkci);

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

        private void produkciaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(produkciaComboBox.SelectedValue!=null)
            {
                textBox1.Text = retCountGP(produkciaComboBox.SelectedValue.ToString());
            }
        }
    }
}
