using Car_Parking.CarParkingDataSetTableAdapters;
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
    public partial class EditForm : Form
    {
        // car_id
        private readonly int car_id;
        // true if update, false if insert
        readonly bool edit;
        // if true delete
        readonly bool delete;
        public EditForm()
        {
            InitializeComponent();
            carsTableAdapter.Fill(carParkingDataSet1.cars);
            car_ownerTableAdapter.Fill(carParkingDataSet1.car_owner);
            parking_placeTableAdapter.Fill(carParkingDataSet1.parking_place);
            edit = false;
            //delete= true;
        }

        // Form constructor for modify existed data
        ///<param name="car_id">car_id</param>
        ///<param name="registration">RegistrationMark</param>
        ///<param name="brand">Brand</param>
        ///<param name="model">Model</param>
        ///<param name="damage">Damage</param>
        ///<param name="incompleteness">Incompleteness</param>
        ///<param name="place_id">Place_id</param>
        ///<param name="owner_id">Owner_id</param>
        public EditForm(int car_id, String registration, String brand, String model, bool damage
            , bool incompleteness, int place_id, int owner_id)
            : this()
        {
            carsTableAdapter.Fill(carParkingDataSet.cars);
            car_ownerTableAdapter.Fill(carParkingDataSet.car_owner);
            parking_placeTableAdapter.Fill(carParkingDataSet.parking_place);
            edit = true;
            this.car_id = car_id;

            textBox_RegistrationMark.Text = registration;
            textBox_Brand.Text = brand;
            textBox_Model.Text = model;
            comboBox_Place_id.SelectedValue = place_id;
            textBox_Owner_id.Text = owner_id.ToString();
            switch (damage) 
            {
                case true:
                    checkBox_Damage.Checked = true;
                    break;
                    case false:
                    checkBox_Damage.Checked = false;
                    break;
            }

            switch (incompleteness)
            {
                case true:
                    checkBox_Incompleteness.Checked = true;
                    break;
                case false:
                    checkBox_Incompleteness.Checked = false;
                    break;
            }  


        }

        public EditForm(int car_id) :this()
        {
            carsTableAdapter.Fill(carParkingDataSet1.cars);
            car_ownerTableAdapter.Fill(carParkingDataSet1.car_owner);
            parking_placeTableAdapter.Fill(carParkingDataSet1.parking_place);
            delete= true;
            this.car_id = car_id;
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carParkingDataSet.cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carParkingDataSet.cars);
            // TODO: This line of code loads data into the 'carParkingDataSet1.parking_place' table. You can move, or remove it, as needed.
            this.parking_placeTableAdapter.Fill(this.carParkingDataSet1.parking_place);
            // TODO: This line of code loads data into the 'carParkingDataSet1.car_owner' table. You can move, or remove it, as needed.
            this.car_ownerTableAdapter.Fill(this.carParkingDataSet1.car_owner);
            // TODO: This line of code loads data into the 'carParkingDataSet.cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.carParkingDataSet.cars);

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                carsTableAdapter.UpdateQuery1(textBox_RegistrationMark.Text, textBox_Brand.Text, textBox_Model.Text
                    , Convert.ToBoolean(checkBox_Damage.Checked), Convert.ToBoolean(checkBox_Incompleteness.Checked), Convert.ToInt32(comboBox_Place_id.SelectedValue)
                    , Convert.ToInt32(textBox_Owner_id.Text), car_id);
            }
            else
            {
                carsTableAdapter.InsertQuery(textBox_RegistrationMark.Text, textBox_Brand.Text, textBox_Model.Text
                    , Convert.ToBoolean(checkBox_Damage.Checked), Convert.ToBoolean(checkBox_Incompleteness.Checked), Convert.ToInt32(comboBox_Place_id.SelectedValue)
                    , Convert.ToInt32(textBox_Owner_id.Text));
            }
            Close();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox_Damage_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
