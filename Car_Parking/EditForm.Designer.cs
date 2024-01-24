namespace Car_Parking
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_RegistrationMark = new System.Windows.Forms.TextBox();
            this.textBox_Brand = new System.Windows.Forms.TextBox();
            this.textBox_Model = new System.Windows.Forms.TextBox();
            this.textBox_Owner_id = new System.Windows.Forms.TextBox();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carParkingDataSet = new Car_Parking.CarParkingDataSet();
            this.carownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carParkingDataSet1 = new Car_Parking.CarParkingDataSet();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.RegistrationMark = new System.Windows.Forms.Label();
            this.Brand = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Place_id = new System.Windows.Forms.Label();
            this.Owner_id = new System.Windows.Forms.Label();
            this.Damage = new System.Windows.Forms.Label();
            this.Incompleteness = new System.Windows.Forms.Label();
            this.carsTableAdapter = new Car_Parking.CarParkingDataSetTableAdapters.carsTableAdapter();
            this.tableAdapterManager1 = new Car_Parking.CarParkingDataSetTableAdapters.TableAdapterManager();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.car_ownerTableAdapter = new Car_Parking.CarParkingDataSetTableAdapters.car_ownerTableAdapter();
            this.comboBox_Place_id = new System.Windows.Forms.ComboBox();
            this.parkingplaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carParkingDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parking_placeTableAdapter = new Car_Parking.CarParkingDataSetTableAdapters.parking_placeTableAdapter();
            this.carParkingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_ownerTableAdapter1 = new Car_Parking.CarParkingDataSetTableAdapters.car_ownerTableAdapter();
            this.checkBox_Damage = new System.Windows.Forms.CheckBox();
            this.checkBox_Incompleteness = new System.Windows.Forms.CheckBox();
            this.carsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingplaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_RegistrationMark
            // 
            this.textBox_RegistrationMark.Location = new System.Drawing.Point(189, 41);
            this.textBox_RegistrationMark.Name = "textBox_RegistrationMark";
            this.textBox_RegistrationMark.Size = new System.Drawing.Size(185, 20);
            this.textBox_RegistrationMark.TabIndex = 0;
            // 
            // textBox_Brand
            // 
            this.textBox_Brand.Location = new System.Drawing.Point(189, 88);
            this.textBox_Brand.Name = "textBox_Brand";
            this.textBox_Brand.Size = new System.Drawing.Size(185, 20);
            this.textBox_Brand.TabIndex = 1;
            // 
            // textBox_Model
            // 
            this.textBox_Model.Location = new System.Drawing.Point(189, 130);
            this.textBox_Model.Name = "textBox_Model";
            this.textBox_Model.Size = new System.Drawing.Size(185, 20);
            this.textBox_Model.TabIndex = 2;
            // 
            // textBox_Owner_id
            // 
            this.textBox_Owner_id.Location = new System.Drawing.Point(189, 315);
            this.textBox_Owner_id.Name = "textBox_Owner_id";
            this.textBox_Owner_id.Size = new System.Drawing.Size(185, 20);
            this.textBox_Owner_id.TabIndex = 4;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "cars";
            this.carsBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.carParkingDataSet;
            this.bindingSource1.Position = 0;
            // 
            // carParkingDataSet
            // 
            this.carParkingDataSet.DataSetName = "CarParkingDataSet";
            this.carParkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carownerBindingSource
            // 
            this.carownerBindingSource.DataMember = "car_owner";
            this.carownerBindingSource.DataSource = this.carParkingDataSet1;
            // 
            // carParkingDataSet1
            // 
            this.carParkingDataSet1.DataSetName = "CarParkingDataSet";
            this.carParkingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(24, 432);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(90, 30);
            this.Ok.TabIndex = 8;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(237, 432);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 30);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // RegistrationMark
            // 
            this.RegistrationMark.AutoSize = true;
            this.RegistrationMark.Location = new System.Drawing.Point(31, 44);
            this.RegistrationMark.Name = "RegistrationMark";
            this.RegistrationMark.Size = new System.Drawing.Size(87, 13);
            this.RegistrationMark.TabIndex = 10;
            this.RegistrationMark.Text = "RegistrationMark";
            this.RegistrationMark.Click += new System.EventHandler(this.label1_Click);
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(31, 88);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(35, 13);
            this.Brand.TabIndex = 11;
            this.Brand.Text = "Brand";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(31, 130);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(36, 13);
            this.Model.TabIndex = 12;
            this.Model.Text = "Model";
            // 
            // Place_id
            // 
            this.Place_id.AutoSize = true;
            this.Place_id.Location = new System.Drawing.Point(30, 274);
            this.Place_id.Name = "Place_id";
            this.Place_id.Size = new System.Drawing.Size(48, 13);
            this.Place_id.TabIndex = 13;
            this.Place_id.Text = "Place_id";
            // 
            // Owner_id
            // 
            this.Owner_id.AutoSize = true;
            this.Owner_id.Location = new System.Drawing.Point(32, 322);
            this.Owner_id.Name = "Owner_id";
            this.Owner_id.Size = new System.Drawing.Size(52, 13);
            this.Owner_id.TabIndex = 14;
            this.Owner_id.Text = "Owner_id";
            // 
            // Damage
            // 
            this.Damage.AutoSize = true;
            this.Damage.Location = new System.Drawing.Point(31, 174);
            this.Damage.Name = "Damage";
            this.Damage.Size = new System.Drawing.Size(47, 13);
            this.Damage.TabIndex = 15;
            this.Damage.Text = "Damage";
            // 
            // Incompleteness
            // 
            this.Incompleteness.AutoSize = true;
            this.Incompleteness.Location = new System.Drawing.Point(31, 227);
            this.Incompleteness.Name = "Incompleteness";
            this.Incompleteness.Size = new System.Drawing.Size(81, 13);
            this.Incompleteness.TabIndex = 16;
            this.Incompleteness.Text = "Incompleteness";
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.car_ownerTableAdapter = null;
            this.tableAdapterManager1.carsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager1.parking_placeTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Car_Parking.CarParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "cars";
            this.bindingSource2.DataSource = this.carParkingDataSet;
            // 
            // car_ownerTableAdapter
            // 
            this.car_ownerTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_Place_id
            // 
            this.comboBox_Place_id.DataSource = this.parkingplaceBindingSource;
            this.comboBox_Place_id.DisplayMember = "place_id";
            this.comboBox_Place_id.FormattingEnabled = true;
            this.comboBox_Place_id.Location = new System.Drawing.Point(189, 271);
            this.comboBox_Place_id.Name = "comboBox_Place_id";
            this.comboBox_Place_id.Size = new System.Drawing.Size(185, 21);
            this.comboBox_Place_id.TabIndex = 18;
            this.comboBox_Place_id.ValueMember = "place_id";
            // 
            // parkingplaceBindingSource
            // 
            this.parkingplaceBindingSource.DataMember = "parking_place";
            this.parkingplaceBindingSource.DataSource = this.carParkingDataSet1;
            // 
            // carsBindingSource1
            // 
            this.carsBindingSource1.DataMember = "cars";
            this.carsBindingSource1.DataSource = this.carParkingDataSetBindingSource1;
            // 
            // carParkingDataSetBindingSource1
            // 
            this.carParkingDataSetBindingSource1.DataSource = this.carParkingDataSet;
            this.carParkingDataSetBindingSource1.Position = 0;
            // 
            // parking_placeTableAdapter
            // 
            this.parking_placeTableAdapter.ClearBeforeFill = true;
            // 
            // carParkingDataSetBindingSource
            // 
            this.carParkingDataSetBindingSource.DataSource = this.carParkingDataSet;
            this.carParkingDataSetBindingSource.Position = 0;
            // 
            // car_ownerTableAdapter1
            // 
            this.car_ownerTableAdapter1.ClearBeforeFill = true;
            // 
            // checkBox_Damage
            // 
            this.checkBox_Damage.AutoSize = true;
            this.checkBox_Damage.Location = new System.Drawing.Point(189, 173);
            this.checkBox_Damage.Name = "checkBox_Damage";
            this.checkBox_Damage.Size = new System.Drawing.Size(66, 17);
            this.checkBox_Damage.TabIndex = 19;
            this.checkBox_Damage.Text = "Damage";
            this.checkBox_Damage.UseVisualStyleBackColor = true;
            this.checkBox_Damage.CheckedChanged += new System.EventHandler(this.checkBox_Damage_CheckedChanged);
            // 
            // checkBox_Incompleteness
            // 
            this.checkBox_Incompleteness.AutoSize = true;
            this.checkBox_Incompleteness.Location = new System.Drawing.Point(189, 226);
            this.checkBox_Incompleteness.Name = "checkBox_Incompleteness";
            this.checkBox_Incompleteness.Size = new System.Drawing.Size(97, 17);
            this.checkBox_Incompleteness.TabIndex = 20;
            this.checkBox_Incompleteness.Text = "ncompleteness";
            this.checkBox_Incompleteness.UseVisualStyleBackColor = true;
            // 
            // carsBindingSource2
            // 
            this.carsBindingSource2.DataMember = "cars";
            this.carsBindingSource2.DataSource = this.bindingSource1;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 474);
            this.Controls.Add(this.checkBox_Incompleteness);
            this.Controls.Add(this.checkBox_Damage);
            this.Controls.Add(this.comboBox_Place_id);
            this.Controls.Add(this.Incompleteness);
            this.Controls.Add(this.Damage);
            this.Controls.Add(this.Owner_id);
            this.Controls.Add(this.Place_id);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Brand);
            this.Controls.Add(this.RegistrationMark);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.textBox_Owner_id);
            this.Controls.Add(this.textBox_Model);
            this.Controls.Add(this.textBox_Brand);
            this.Controls.Add(this.textBox_RegistrationMark);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingplaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_RegistrationMark;
        private System.Windows.Forms.TextBox textBox_Brand;
        private System.Windows.Forms.TextBox textBox_Model;
        private System.Windows.Forms.TextBox textBox_Owner_id;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label RegistrationMark;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Place_id;
        private System.Windows.Forms.Label Owner_id;
        private System.Windows.Forms.Label Damage;
        private System.Windows.Forms.Label Incompleteness;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CarParkingDataSet carParkingDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarParkingDataSetTableAdapters.carsTableAdapter carsTableAdapter;
        private CarParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private CarParkingDataSet carParkingDataSet1;
        private System.Windows.Forms.BindingSource carownerBindingSource;
        private CarParkingDataSetTableAdapters.car_ownerTableAdapter car_ownerTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_Place_id;
        private System.Windows.Forms.BindingSource parkingplaceBindingSource;
        private CarParkingDataSetTableAdapters.parking_placeTableAdapter parking_placeTableAdapter;
        private System.Windows.Forms.BindingSource carParkingDataSetBindingSource1;
        private System.Windows.Forms.BindingSource carParkingDataSetBindingSource;
        private System.Windows.Forms.BindingSource carsBindingSource1;
        private CarParkingDataSetTableAdapters.car_ownerTableAdapter car_ownerTableAdapter1;
        private System.Windows.Forms.CheckBox checkBox_Damage;
        private System.Windows.Forms.CheckBox checkBox_Incompleteness;
        private System.Windows.Forms.BindingSource carsBindingSource2;
    }
}