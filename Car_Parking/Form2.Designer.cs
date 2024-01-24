namespace Car_Parking
{
    partial class RSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSForm));
            System.Windows.Forms.Label owner_idLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label carLabel;
            System.Windows.Forms.Label mobile_phoneLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label streetLabel;
            System.Windows.Forms.Label building_numberLabel;
            System.Windows.Forms.Label apartmentLabel;
            this.carParkingDataSet = new Car_Parking.CarParkingDataSet();
            this.car_ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_ownerTableAdapter = new Car_Parking.CarParkingDataSetTableAdapters.car_ownerTableAdapter();
            this.tableAdapterManager = new Car_Parking.CarParkingDataSetTableAdapters.TableAdapterManager();
            this.car_ownerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.car_ownerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.owner_idTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.carTextBox = new System.Windows.Forms.TextBox();
            this.mobile_phoneTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.building_numberTextBox = new System.Windows.Forms.TextBox();
            this.apartmentTextBox = new System.Windows.Forms.TextBox();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new Car_Parking.CarParkingDataSetTableAdapters.carsTableAdapter();
            this.carsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            owner_idLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            carLabel = new System.Windows.Forms.Label();
            mobile_phoneLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            streetLabel = new System.Windows.Forms.Label();
            building_numberLabel = new System.Windows.Forms.Label();
            apartmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_ownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_ownerBindingNavigator)).BeginInit();
            this.car_ownerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carParkingDataSet
            // 
            this.carParkingDataSet.DataSetName = "CarParkingDataSet";
            this.carParkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // car_ownerBindingSource
            // 
            this.car_ownerBindingSource.DataMember = "car_owner";
            this.car_ownerBindingSource.DataSource = this.carParkingDataSet;
            // 
            // car_ownerTableAdapter
            // 
            this.car_ownerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.car_ownerTableAdapter = this.car_ownerTableAdapter;
            this.tableAdapterManager.carsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager.parking_placeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Car_Parking.CarParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // car_ownerBindingNavigator
            // 
            this.car_ownerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.car_ownerBindingNavigator.BindingSource = this.car_ownerBindingSource;
            this.car_ownerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.car_ownerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.car_ownerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.car_ownerBindingNavigatorSaveItem});
            this.car_ownerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.car_ownerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.car_ownerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.car_ownerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.car_ownerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.car_ownerBindingNavigator.Name = "car_ownerBindingNavigator";
            this.car_ownerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.car_ownerBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.car_ownerBindingNavigator.TabIndex = 0;
            this.car_ownerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // car_ownerBindingNavigatorSaveItem
            // 
            this.car_ownerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.car_ownerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("car_ownerBindingNavigatorSaveItem.Image")));
            this.car_ownerBindingNavigatorSaveItem.Name = "car_ownerBindingNavigatorSaveItem";
            this.car_ownerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.car_ownerBindingNavigatorSaveItem.Text = "Save Data";
            this.car_ownerBindingNavigatorSaveItem.Click += new System.EventHandler(this.car_ownerBindingNavigatorSaveItem_Click);
            // 
            // owner_idLabel
            // 
            owner_idLabel.AutoSize = true;
            owner_idLabel.Location = new System.Drawing.Point(67, 55);
            owner_idLabel.Name = "owner_idLabel";
            owner_idLabel.Size = new System.Drawing.Size(50, 13);
            owner_idLabel.TabIndex = 1;
            owner_idLabel.Text = "owner id:";
            // 
            // owner_idTextBox
            // 
            this.owner_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_ownerBindingSource, "owner_id", true));
            this.owner_idTextBox.Location = new System.Drawing.Point(157, 52);
            this.owner_idTextBox.Name = "owner_idTextBox";
            this.owner_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.owner_idTextBox.TabIndex = 2;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(67, 81);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(50, 13);
            surnameLabel.TabIndex = 3;
            surnameLabel.Text = "surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_ownerBindingSource, "surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(157, 78);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 4;
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(67, 107);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(55, 13);
            first_nameLabel.TabIndex = 5;
            first_nameLabel.Text = "first name:";
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_ownerBindingSource, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(157, 104);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.first_nameTextBox.TabIndex = 6;
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(67, 133);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(61, 13);
            patronymicLabel.TabIndex = 7;
            patronymicLabel.Text = "patronymic:";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_ownerBindingSource, "patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(157, 130);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(100, 20);
            this.patronymicTextBox.TabIndex = 8;
            // 
            // carLabel
            // 
            carLabel.AutoSize = true;
            carLabel.Location = new System.Drawing.Point(67, 159);
            carLabel.Name = "carLabel";
            carLabel.Size = new System.Drawing.Size(25, 13);
            carLabel.TabIndex = 9;
            carLabel.Text = "car:";
            // 
            // carTextBox
            // 
            this.carTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_ownerBindingSource, "car", true));
            this.carTextBox.Location = new System.Drawing.Point(157, 156);
            this.carTextBox.Name = "carTextBox";
            this.carTextBox.Size = new System.Drawing.Size(100, 20);
            this.carTextBox.TabIndex = 10;
            // 
            // mobile_phoneLabel
            // 
            mobile_phoneLabel.AutoSize = true;
            mobile_phoneLabel.Location = new System.Drawing.Point(67, 185);
            mobile_phoneLabel.Name = "mobile_phoneLabel";
            mobile_phoneLabel.Size = new System.Drawing.Size(73, 13);
            mobile_phoneLabel.TabIndex = 11;
            mobile_phoneLabel.Text = "mobile phone:";
            // 
            // mobile_phoneTextBox
            // 
            this.mobile_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_ownerBindingSource, "mobile_phone", true));
            this.mobile_phoneTextBox.Location = new System.Drawing.Point(157, 182);
            this.mobile_phoneTextBox.Name = "mobile_phoneTextBox";
            this.mobile_phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobile_phoneTextBox.TabIndex = 12;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(67, 211);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(26, 13);
            cityLabel.TabIndex = 13;
            cityLabel.Text = "city:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_ownerBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(157, 208);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 20);
            this.cityTextBox.TabIndex = 14;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new System.Drawing.Point(67, 237);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new System.Drawing.Size(36, 13);
            streetLabel.TabIndex = 15;
            streetLabel.Text = "street:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_ownerBindingSource, "street", true));
            this.streetTextBox.Location = new System.Drawing.Point(157, 234);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(100, 20);
            this.streetTextBox.TabIndex = 16;
            // 
            // building_numberLabel
            // 
            building_numberLabel.AutoSize = true;
            building_numberLabel.Location = new System.Drawing.Point(67, 263);
            building_numberLabel.Name = "building_numberLabel";
            building_numberLabel.Size = new System.Drawing.Size(84, 13);
            building_numberLabel.TabIndex = 17;
            building_numberLabel.Text = "building number:";
            // 
            // building_numberTextBox
            // 
            this.building_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_ownerBindingSource, "building_number", true));
            this.building_numberTextBox.Location = new System.Drawing.Point(157, 260);
            this.building_numberTextBox.Name = "building_numberTextBox";
            this.building_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.building_numberTextBox.TabIndex = 18;
            // 
            // apartmentLabel
            // 
            apartmentLabel.AutoSize = true;
            apartmentLabel.Location = new System.Drawing.Point(67, 289);
            apartmentLabel.Name = "apartmentLabel";
            apartmentLabel.Size = new System.Drawing.Size(57, 13);
            apartmentLabel.TabIndex = 19;
            apartmentLabel.Text = "apartment:";
            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.car_ownerBindingSource, "apartment", true));
            this.apartmentTextBox.Location = new System.Drawing.Point(157, 286);
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.Size = new System.Drawing.Size(100, 20);
            this.apartmentTextBox.TabIndex = 20;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "FK__cars__owner_id__3C69FB99";
            this.carsBindingSource.DataSource = this.car_ownerBindingSource;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // carsDataGridView
            // 
            this.carsDataGridView.AutoGenerateColumns = false;
            this.carsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.carsDataGridView.DataSource = this.carsBindingSource;
            this.carsDataGridView.Location = new System.Drawing.Point(0, 312);
            this.carsDataGridView.Name = "carsDataGridView";
            this.carsDataGridView.Size = new System.Drawing.Size(800, 155);
            this.carsDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "car_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "car_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "registrationMark";
            this.dataGridViewTextBoxColumn2.HeaderText = "registrationMark";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "brand";
            this.dataGridViewTextBoxColumn3.HeaderText = "brand";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn4.HeaderText = "model";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "damage";
            this.dataGridViewCheckBoxColumn1.HeaderText = "damage";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "incompleteness";
            this.dataGridViewCheckBoxColumn2.HeaderText = "incompleteness";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "place_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "place_id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "owner_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "owner_id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.carsDataGridView);
            this.Controls.Add(owner_idLabel);
            this.Controls.Add(this.owner_idTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(carLabel);
            this.Controls.Add(this.carTextBox);
            this.Controls.Add(mobile_phoneLabel);
            this.Controls.Add(this.mobile_phoneTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(streetLabel);
            this.Controls.Add(this.streetTextBox);
            this.Controls.Add(building_numberLabel);
            this.Controls.Add(this.building_numberTextBox);
            this.Controls.Add(apartmentLabel);
            this.Controls.Add(this.apartmentTextBox);
            this.Controls.Add(this.car_ownerBindingNavigator);
            this.Name = "RSForm";
            this.Text = "Moving";
            this.Load += new System.EventHandler(this.RSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_ownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_ownerBindingNavigator)).EndInit();
            this.car_ownerBindingNavigator.ResumeLayout(false);
            this.car_ownerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CarParkingDataSet carParkingDataSet;
        private System.Windows.Forms.BindingSource car_ownerBindingSource;
        private CarParkingDataSetTableAdapters.car_ownerTableAdapter car_ownerTableAdapter;
        private CarParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator car_ownerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton car_ownerBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox owner_idTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox carTextBox;
        private System.Windows.Forms.TextBox mobile_phoneTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TextBox building_numberTextBox;
        private System.Windows.Forms.TextBox apartmentTextBox;
        private CarParkingDataSetTableAdapters.carsTableAdapter carsTableAdapter;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private System.Windows.Forms.DataGridView carsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}