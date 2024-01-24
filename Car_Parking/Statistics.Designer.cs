namespace Car_Parking
{
    partial class Statistics
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
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.byBrand = new System.Windows.Forms.Label();
            this.byPayment = new System.Windows.Forms.Label();
            this.showStatistics = new System.Windows.Forms.Button();
            this.dataGridViewStatistics = new System.Windows.Forms.DataGridView();
            this.carParkingDataSet = new Car_Parking.CarParkingDataSet();
            this.carParkingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsTableAdapter = new Car_Parking.CarParkingDataSetTableAdapters.carsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(12, 48);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrand.TabIndex = 0;
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(179, 48);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(100, 20);
            this.textBoxPayment.TabIndex = 1;
            // 
            // byBrand
            // 
            this.byBrand.AutoSize = true;
            this.byBrand.Location = new System.Drawing.Point(13, 29);
            this.byBrand.Name = "byBrand";
            this.byBrand.Size = new System.Drawing.Size(93, 13);
            this.byBrand.TabIndex = 2;
            this.byBrand.Text = "Statistics by brand";
            // 
            // byPayment
            // 
            this.byPayment.AutoSize = true;
            this.byPayment.Location = new System.Drawing.Point(179, 29);
            this.byPayment.Name = "byPayment";
            this.byPayment.Size = new System.Drawing.Size(129, 13);
            this.byPayment.TabIndex = 3;
            this.byPayment.Text = "Statistics by payment type";
            // 
            // showStatistics
            // 
            this.showStatistics.Location = new System.Drawing.Point(691, 45);
            this.showStatistics.Name = "showStatistics";
            this.showStatistics.Size = new System.Drawing.Size(97, 23);
            this.showStatistics.TabIndex = 4;
            this.showStatistics.Text = "Show statistics";
            this.showStatistics.UseVisualStyleBackColor = true;
            this.showStatistics.Click += new System.EventHandler(this.showStatistics_Click);
            // 
            // dataGridViewStatistics
            // 
            this.dataGridViewStatistics.AllowUserToOrderColumns = true;
            this.dataGridViewStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics.Location = new System.Drawing.Point(12, 89);
            this.dataGridViewStatistics.Name = "dataGridViewStatistics";
            this.dataGridViewStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStatistics.Size = new System.Drawing.Size(776, 208);
            this.dataGridViewStatistics.TabIndex = 5;
            // 
            // carParkingDataSet
            // 
            this.carParkingDataSet.DataSetName = "CarParkingDataSet";
            this.carParkingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carParkingDataSetBindingSource
            // 
            this.carParkingDataSetBindingSource.DataSource = this.carParkingDataSet;
            this.carParkingDataSetBindingSource.Position = 0;
            // 
            // carsBindingSource
            // 
            this.carsBindingSource.DataMember = "cars";
            this.carsBindingSource.DataSource = this.carParkingDataSetBindingSource;
            // 
            // carsTableAdapter
            // 
            this.carsTableAdapter.ClearBeforeFill = true;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewStatistics);
            this.Controls.Add(this.showStatistics);
            this.Controls.Add(this.byPayment);
            this.Controls.Add(this.byBrand);
            this.Controls.Add(this.textBoxPayment);
            this.Controls.Add(this.textBoxBrand);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carParkingDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.Label byBrand;
        private System.Windows.Forms.Label byPayment;
        private System.Windows.Forms.Button showStatistics;
        private System.Windows.Forms.DataGridView dataGridViewStatistics;
        private System.Windows.Forms.BindingSource carParkingDataSetBindingSource;
        private CarParkingDataSet carParkingDataSet;
        private System.Windows.Forms.BindingSource carsBindingSource;
        private CarParkingDataSetTableAdapters.carsTableAdapter carsTableAdapter;
    }
}