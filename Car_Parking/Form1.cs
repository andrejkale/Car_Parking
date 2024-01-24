using Car_Parking.CarParkingDataSetTableAdapters;
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
using SortOrder = System.Data.SqlClient.SortOrder;

namespace Car_Parking
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carParkingDataSet.parking_place' table. You can move, or remove it, as needed.
            this.parking_placeTableAdapter.Fill(this.carParkingDataSet.parking_place);
            // TODO: This line of code loads data into the 'carParkingDataSet.cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carParkingDataSet.cars);
            // TODO: This line of code loads data into the 'carParkingDataSet.car_owner' table. You can move, or remove it, as needed.
            this.car_ownerTableAdapter.Fill(this.carParkingDataSet.car_owner);
            dataGridView1.AutoGenerateColumns = true;

        }

        private void exiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            car_ownerTableAdapter.Update(carParkingDataSet);
            carsTableAdapter.Update(carParkingDataSet.cars);
            parking_placeTableAdapter.Update(carParkingDataSet);
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void carsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = carsBindingSource;
            dataGridView1.DataSource = carsBindingSource;
            label1.Text = "Cars";
        }

        private void carownerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = carownerBindingSource;
            dataGridView1.DataSource = carownerBindingSource;
            label1.Text = "Car owner";
        }

        private void parkingplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = parkingplaceBindingSource;
            dataGridView1.DataSource = parkingplaceBindingSource;
            label1.Text = "Parking place";
        }

        private void movingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new RSForm();
            rs.ShowDialog();
            car_ownerTableAdapter.Fill(carParkingDataSet.car_owner);
            carsTableAdapter.Fill(carParkingDataSet.cars);
            parking_placeTableAdapter.Fill(carParkingDataSet.parking_place);
        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.Show();
        }

        private bool edit;
        private bool delete;

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = false;
            var edt = new EditForm();
            edt.ShowDialog();
            carsTableAdapter.Fill(carParkingDataSet.cars);
            carParkingDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delete = true;
            carsTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            carsTableAdapter.Fill(carParkingDataSet.cars);
            carParkingDataSet.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = true;
            var cr = new CarParkingDataSet.carsDataTable();
            carsTableAdapter.FillBy(cr, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            object[] row = cr.Rows[0].ItemArray;
            var edt = new EditForm(
                Convert.ToInt32(row[0]), 
                row[1].ToString(), 
                row[2].ToString(),
                row[3].ToString(),
                Convert.ToBoolean(row[4]),
                Convert.ToBoolean(row[5]),
                Convert.ToInt32(row[6]),
                Convert.ToInt32(row[7])
                );
            edt.ShowDialog();
            carsTableAdapter.Fill(carParkingDataSet.cars);
            carParkingDataSet.AcceptChanges();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchText = textSearchByBrand.Text;
            string searchSurname = textSurname.Text;

            const string ConnectionString = @"Data Source=DESKTOP-ANDRE\SQLEXPRESS;Initial Catalog=CarParking;Integrated Security=True";
            string query = "SELECT * FROM CARS JOIN CAR_OWNER ON CARS.OWNER_ID = CAR_OWNER.OWNER_ID WHERE brand LIKE @searchText AND surname LIKE @searchSurname";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    command.Parameters.AddWithValue("@searchSurname", "%" + searchSurname + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dataGridView1.Columns[e.ColumnIndex].Name;

            DataGridView_Sort(columnName);

        }

        private SortOrder sortOrder = SortOrder.Ascending;
        private DataView dataView;
        private BindingSource bindingSource;
        private BindingSource bindingSourceFilter;

        private void DataGridView_Sort(string columnName)
        {
            if (bindingSource == null)
            {
                // Якщо BindingSource ще не створено, створіть його на основі поточного DataSource
                bindingSource = (BindingSource)dataGridView1.DataSource;
            }

            // Отримайте DataView і використайте його для сортування
            dataView = (DataView)bindingSource.List;

            // Визначте напрямок сортування
            string sortOrderString = (sortOrder == SortOrder.Ascending) ? "ASC" : "DESC";

            // Задайте сортування для DataView
            try
            {
                dataView.Sort = $"{columnName} {sortOrderString}";
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(@"Error:" + ex.Message);
            }

            // Оновіть BindingSource, щоб оновити DataGridView
            bindingSource.DataSource = dataView;
            bindingSource.ResetBindings(false);

            // Змініть напрямок сортування для наступного разу
            sortOrder = (sortOrder == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;

            bindingSource = null;
        }

        private void filterApplay_Click(object sender, EventArgs e)
        {
            string searchText = textSearchByBrand.Text;
            string searchSurname = textSurname.Text;

            // Ваше підключення до бази даних
            string connectionString = @"Data Source=DESKTOP-ANDRE\SQLEXPRESS;Initial Catalog=CarParking;Integrated Security=True";

            // Ваш SQL-запит для вибору даних з бази даних
            string query = "SELECT * FROM CARS JOIN CAR_OWNER ON CARS.OWNER_ID = CAR_OWNER.OWNER_ID WHERE brand LIKE @searchText AND surname LIKE @searchSurname"; ;

            // Створіть підключення та команду
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    command.Parameters.AddWithValue("@searchSurname", "%" + searchSurname + "%");
                    // Створіть об'єкт DataAdapter та заповніть DataSet
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Створіть BindingSource та прив'яжіть його до DataGridView
                    bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;
                    dataGridView1.DataSource = bindingSource;
                }
            }

            bindingSource.Filter = $"brand LIKE '%{searchText}%' AND surname LIKE '%{searchSurname}%'";

            bindingSource.ResetBindings(false);

        }

        private void filterClear_Click(object sender, EventArgs e)
        {
            // Скидання фільтра
            bindingSource.RemoveFilter();

            // Оновіть дані у DataGridView
            bindingSource.ResetBindings(false);

            textSearchByBrand.Clear();
            textSurname.Clear();

            string searchText = textSearchByBrand.Text;
            string searchSurname = textSurname.Text;

            const string ConnectionString = @"Data Source=DESKTOP-ANDRE\SQLEXPRESS;Initial Catalog=CarParking;Integrated Security=True";
            string query = "SELECT * FROM CARS JOIN CAR_OWNER ON CARS.OWNER_ID = CAR_OWNER.OWNER_ID WHERE brand LIKE @searchText AND surname LIKE @searchSurname";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    command.Parameters.AddWithValue("@searchSurname", "%" + searchSurname + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var stat = new Statistics();
            stat.Show();
        }
    }
}
