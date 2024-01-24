namespace Car_Parking
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.owneridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carParkingDataSet = new Car_Parking.CarParkingDataSet();
            this.carownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.parkingplaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.File = new System.Windows.Forms.MenuStrip();
            this.Fіle = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.carownerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parkingplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.car_ownerTableAdapter = new Car_Parking.CarParkingDataSetTableAdapters.car_ownerTableAdapter();
            this.carsTableAdapter = new Car_Parking.CarParkingDataSetTableAdapters.carsTableAdapter();
            this.parking_placeTableAdapter = new Car_Parking.CarParkingDataSetTableAdapters.parking_placeTableAdapter();
            this.tableAdapterManager1 = new Car_Parking.CarParkingDataSetTableAdapters.TableAdapterManager();
            this.tableAdapterManager2 = new Car_Parking.CarParkingDataSetTableAdapters.TableAdapterManager();
            this.textSearchByBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filterApplay = new System.Windows.Forms.Button();
            this.filterClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingplaceBindingSource)).BeginInit();
            this.Fіle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.owneridDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // owneridDataGridViewTextBoxColumn
            // 
            this.owneridDataGridViewTextBoxColumn.DataPropertyName = "owner_id";
            this.owneridDataGridViewTextBoxColumn.HeaderText = "owner_id";
            this.owneridDataGridViewTextBoxColumn.Name = "owneridDataGridViewTextBoxColumn";
            this.owneridDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.carownerBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.carownerBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 330);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // parkingplaceBindingSource
            // 
            this.parkingplaceBindingSource.DataMember = "parking_place";
            this.parkingplaceBindingSource.DataSource = this.bindingSource1;
            // 
            // File
            // 
            this.File.Location = new System.Drawing.Point(0, 24);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(1174, 24);
            this.File.TabIndex = 6;
            this.File.Text = "File";
            // 
            // Fіle
            // 
            this.Fіle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.viewToolStripMenuItem,
            this.editFormToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.Fіle.Location = new System.Drawing.Point(0, 0);
            this.Fіle.Name = "Fіle";
            this.Fіle.Size = new System.Drawing.Size(1174, 24);
            this.Fіle.TabIndex = 7;
            this.Fіle.Text = "File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exiteToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exiteToolStripMenuItem
            // 
            this.exiteToolStripMenuItem.Name = "exiteToolStripMenuItem";
            this.exiteToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exiteToolStripMenuItem.Text = "Exit";
            this.exiteToolStripMenuItem.Click += new System.EventHandler(this.exiteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carownerToolStripMenuItem,
            this.carsToolStripMenuItem,
            this.parkingplaceToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem2.Text = "Database";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // carownerToolStripMenuItem
            // 
            this.carownerToolStripMenuItem.Name = "carownerToolStripMenuItem";
            this.carownerToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.carownerToolStripMenuItem.Text = "car_owner";
            this.carownerToolStripMenuItem.Click += new System.EventHandler(this.carownerToolStripMenuItem_Click);
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.carsToolStripMenuItem.Text = "cars";
            this.carsToolStripMenuItem.Click += new System.EventHandler(this.carsToolStripMenuItem_Click);
            // 
            // parkingplaceToolStripMenuItem
            // 
            this.parkingplaceToolStripMenuItem.Name = "parkingplaceToolStripMenuItem";
            this.parkingplaceToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.parkingplaceToolStripMenuItem.Text = "parking_place";
            this.parkingplaceToolStripMenuItem.Click += new System.EventHandler(this.parkingplaceToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movingToolStripMenuItem,
            this.queryEditToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // movingToolStripMenuItem
            // 
            this.movingToolStripMenuItem.Name = "movingToolStripMenuItem";
            this.movingToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.movingToolStripMenuItem.Text = "Moving";
            this.movingToolStripMenuItem.Click += new System.EventHandler(this.movingToolStripMenuItem_Click);
            // 
            // queryEditToolStripMenuItem
            // 
            this.queryEditToolStripMenuItem.Name = "queryEditToolStripMenuItem";
            this.queryEditToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.queryEditToolStripMenuItem.Text = "QueryEdit";
            this.queryEditToolStripMenuItem.Click += new System.EventHandler(this.queryEditToolStripMenuItem_Click);
            // 
            // editFormToolStripMenuItem
            // 
            this.editFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.editFormToolStripMenuItem.Name = "editFormToolStripMenuItem";
            this.editFormToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.editFormToolStripMenuItem.Text = "EditForm";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cars";
            // 
            // car_ownerTableAdapter
            // 
            this.car_ownerTableAdapter.ClearBeforeFill = true;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // parking_placeTableAdapter
            // 
            this.parking_placeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.car_ownerTableAdapter = this.car_ownerTableAdapter;
            this.tableAdapterManager1.car_placeTableAdapter = null;
            this.tableAdapterManager1.carsTableAdapter = this.carsTableAdapter;
            this.tableAdapterManager1.parking_placeTableAdapter = this.parking_placeTableAdapter;
            this.tableAdapterManager1.parkingTableAdapter = null;
            this.tableAdapterManager1.passesTableAdapter = null;
            this.tableAdapterManager1.paymentTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Car_Parking.CarParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.car_ownerTableAdapter = null;
            this.tableAdapterManager2.car_placeTableAdapter = null;
            this.tableAdapterManager2.carsTableAdapter = null;
            this.tableAdapterManager2.Connection = null;
            this.tableAdapterManager2.parking_placeTableAdapter = null;
            this.tableAdapterManager2.parkingTableAdapter = null;
            this.tableAdapterManager2.passesTableAdapter = null;
            this.tableAdapterManager2.paymentTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = Car_Parking.CarParkingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // textSearchByBrand
            // 
            this.textSearchByBrand.Location = new System.Drawing.Point(0, 58);
            this.textSearchByBrand.Name = "textSearchByBrand";
            this.textSearchByBrand.Size = new System.Drawing.Size(100, 20);
            this.textSearchByBrand.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search by brand";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(301, 55);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 11;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(137, 57);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(100, 20);
            this.textSurname.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search by surname";
            // 
            // filterApplay
            // 
            this.filterApplay.Location = new System.Drawing.Point(426, 54);
            this.filterApplay.Name = "filterApplay";
            this.filterApplay.Size = new System.Drawing.Size(75, 23);
            this.filterApplay.TabIndex = 14;
            this.filterApplay.Text = "Filter Applay";
            this.filterApplay.UseVisualStyleBackColor = true;
            this.filterApplay.Click += new System.EventHandler(this.filterApplay_Click);
            // 
            // filterClear
            // 
            this.filterClear.Location = new System.Drawing.Point(548, 54);
            this.filterClear.Name = "filterClear";
            this.filterClear.Size = new System.Drawing.Size(75, 23);
            this.filterClear.TabIndex = 15;
            this.filterClear.Text = "Filter Clear";
            this.filterClear.UseVisualStyleBackColor = true;
            this.filterClear.Click += new System.EventHandler(this.filterClear_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 450);
            this.Controls.Add(this.filterClear);
            this.Controls.Add(this.filterApplay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSearchByBrand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.File);
            this.Controls.Add(this.Fіle);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.File;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parkingplaceBindingSource)).EndInit();
            this.Fіle.ResumeLayout(false);
            this.Fіle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private CarParkingDataSet carParkingDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carownerBindingSource;
        private CarParkingDataSetTableAdapters.car_ownerTableAdapter car_ownerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn owneridDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarParkingDataSetTableAdapters.carsTableAdapter carsTableAdapter;
        private System.Windows.Forms.BindingSource parkingplaceBindingSource;
        private CarParkingDataSetTableAdapters.parking_placeTableAdapter parking_placeTableAdapter;
        private System.Windows.Forms.MenuStrip File;
        private System.Windows.Forms.MenuStrip Fіle;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem carownerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parkingplaceToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private CarParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private CarParkingDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.TextBox textSearchByBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button filterApplay;
        private System.Windows.Forms.Button filterClear;
    }
}

