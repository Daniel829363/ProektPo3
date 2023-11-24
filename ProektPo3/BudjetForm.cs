using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProektPo3
{
    public partial class BudjetForm : Form
    {
        private Form1 form1;
        public BudjetForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        public BudjetForm()
        {
        }

        private void BudjetForm_Load(object sender, EventArgs e)
        {
            sumTextBox.Text = Budjetsum();

        }
        public string connectionString = "Data Source=DESKTOP-6RRLLP7;Initial Catalog=Mebel;Integrated Security=True";

        public void addbudjet(String sum)
        {
            double sum2 = Convert.ToDouble(sum) + Convert.ToDouble(Budjetsum());
            string updateQuery = "UPDATE Budjet SET Sum = @update WHERE id=1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    // Замените "NewValue" и "YourParameter" на свои значения
                    command.Parameters.AddWithValue("@update", sum2);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Данные успешно обновлены.");

                        }
                        else
                        {
                            MessageBox.Show("Обновление данных не выполнено.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
        }
        public string Budjetsum()
        {
            string query = "SELECT Sum FROM Budjet WHERE id=1";

            using (SqlConnection connection = new SqlConnection(connectionString))
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
            addbudjet(textBox1.Text);
            sumTextBox.Text = Budjetsum();

        }
    }
}
