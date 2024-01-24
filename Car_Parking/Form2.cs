using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Parking
{
    public partial class RSForm : Form
    {
        public RSForm()
        {
            InitializeComponent();
        }

        private void car_ownerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.car_ownerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.carParkingDataSet);

        }

        private void RSForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carParkingDataSet.cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carParkingDataSet.cars);
            // TODO: This line of code loads data into the 'carParkingDataSet.car_owner' table. You can move, or remove it, as needed.
            this.car_ownerTableAdapter.Fill(this.carParkingDataSet.car_owner);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to confirm the changes?"
                , "Change data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                car_ownerBindingSource.EndEdit();
                car_ownerTableAdapter.Update(carParkingDataSet);
                carsTableAdapter.Update(carParkingDataSet);
            }
        }
    }
}
