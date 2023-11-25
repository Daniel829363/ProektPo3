using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ReportDataSource = Microsoft.Reporting.WinForms.ReportDataSource;

namespace ProektPo3
{
    public partial class Report : Form
    {
        private DateTime dateA;
        private DateTime dateB;
        private String reportPath;
        private int a;
        public Report(DateTime datetimeA, DateTime datetimeB,String path,int a)
        {
            InitializeComponent();
            dateA = datetimeA;
            dateB = datetimeB;
            reportPath= path;
            this.a = a;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Syrie". При необходимости она может быть перемещена или удалена.
            this.syrieTableAdapter.Fill(this.mebelDataSet.Syrie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.ZakupkaView". При необходимости она может быть перемещена или удалена.
            this.zakupkaViewTableAdapter.Fill(this.mebelDataSet.ZakupkaView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mebelDataSet.Zakupka_syria". При необходимости она может быть перемещена или удалена.
            this.zakupka_syriaTableAdapter.Fill(this.mebelDataSet.Zakupka_syria);


            ReportDataSource reportDataSource = new ReportDataSource();

            // Установка имени и значения источника данных отчета
            
                reportDataSource.Name = "DataSet1"; // Имя вашего источника данных отчета
                reportDataSource.Value = GetData(); // Метод, который возвращает данные для отчета
            
            

            // Очистка текущих источников данных отчета
            reportViewer1.LocalReport.DataSources.Clear();

            // Добавление нового источника данных отчета
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.ReportPath = reportPath;


            // Обновление отчета
            reportViewer1.RefreshReport();
        }
        public string connectionString = "Data Source=DESKTOP-6RRLLP7;Initial Catalog=Mebel;Integrated Security=True";

        private DataTable GetData()
        {
            DataTable dataTable = new DataTable();

            // Создание подключения к базе данных
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Открытие подключения
                connection.Open();
                string selectQuery;

                // Создание команды SQL для выборки данных из таблицы
                if (a == 1)
                {
                     selectQuery = "SELECT * FROM ZakupkaView " +
                        "WHERE (ZakupkaView.Data >= @DateA AND ZakupkaView.Data <= @DateB)";
                }else if(a == 2)
                {
                     selectQuery = "SELECT * FROM ProdajView " +
                        "WHERE (ProdajView.Data >= @DateA AND ProdajView.Data <= @DateB)";
                }
                else
                {
                     selectQuery = "SELECT * FROM ProizView " +
                        "WHERE (ProizView.Data >= @DateA AND ProizView.Data <= @DateB)";
                }
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    // Добавление параметров к команде
                    selectCommand.Parameters.AddWithValue("@DateA", dateA);
                    selectCommand.Parameters.AddWithValue("@DateB", dateB);

                    // Создание адаптера данных
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand))
                    {
                        // Заполнение DataTable данными из базы данных
                        dataAdapter.Fill(dataTable);
                    }
                }

                // Закрытие подключения
                connection.Close();
            }

            return dataTable;
        }


    }
}
