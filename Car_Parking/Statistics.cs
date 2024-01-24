using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Car_Parking
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }
        const string ConnectionString = @"Data Source=DESKTOP-ANDRE\SQLEXPRESS;Initial Catalog=CarParking;Integrated Security=True";

        private void showStatistics_Click(object sender, EventArgs e)
        {
            string brand = textBoxBrand.Text;
            string payment = textBoxPayment.Text;
            string query;
            if (!brand.Equals(""))
            {
                query = "SELECT brand, COUNT(brand) AS BrandCount, model, COUNT(model) AS ModelCount FROM CARS WHERE brand LIKE @brand GROUP By brand, model";
            }
            else
            {
                query = "SELECT price, COUNT(price) AS PriceCount, SUM(price) AS PriceSumm FROM payment WHERE payment_type LIKE @payment GROUP By price;";
            }
          
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Додайте параметр для введеного тексту
                    command.Parameters.AddWithValue("@brand", "%" + brand + "%");
                    command.Parameters.AddWithValue("@payment", "%" + payment + "%");

                    // Виконайте запит та отримайте результати
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Оновіть DataGridView знайденими даними 
                    dataGridViewStatistics.DataSource = dataTable;
                    ExportToExcel(dataTable);
                }

                textBoxBrand.Clear();
                textBoxPayment.Clear();
                connection.Close();
            }

        }

        private void ExportToExcel(DataTable dataTable)
        {
            string dateTimeString = DateTime.Now.ToString("yyyyMMddHHmmss"); // Поточна дата і час у форматі "yyyyMMddHHmmss"
            string filePath = $"E:\\ХНУРЄ\\Високорівневі мови програмування та фреймворки\\CarParkingProject\\statistic_{dateTimeString}.xlsx"; // Додайте дату і час до імені файлу
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Статистика"); // Створення аркушу Excel

                // Заповнюємо аркуш даними з DataTable
                worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                // Зберігаємо файл Excel
                package.Save();

                // Відкриваємо файл Excel
                System.Diagnostics.Process.Start(filePath);
            }
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carParkingDataSet.cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carParkingDataSet.cars);

        }
    }
}
