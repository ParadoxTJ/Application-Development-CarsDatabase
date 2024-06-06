namespace CarsDatabase
{
    partial class frmSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vehicleRegNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRegisteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalPerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet = new CarsDatabase.hireDataSet();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tblCarTableAdapter = new CarsDatabase.hireDataSetTableAdapters.TblCarTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValue);
            this.groupBox1.Controls.Add(this.lblOperator);
            this.groupBox1.Controls.Add(this.lblField);
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.cboOperator);
            this.groupBox1.Controls.Add(this.cboField);
            this.groupBox1.Location = new System.Drawing.Point(62, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(870, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(497, 54);
            this.lblValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(58, 16);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Value:";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(253, 53);
            this.lblOperator.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(87, 16);
            this.lblOperator.TabIndex = 4;
            this.lblOperator.Text = "Operator:";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(10, 53);
            this.lblField.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(48, 16);
            this.lblField.TabIndex = 3;
            this.lblField.Text = "Field:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(502, 74);
            this.txtValue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(164, 23);
            this.txtValue.TabIndex = 2;
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">="});
            this.cboOperator.Location = new System.Drawing.Point(258, 73);
            this.cboOperator.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(199, 24);
            this.cboOperator.TabIndex = 1;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Items.AddRange(new object[] {
            "Make",
            "Engine Size",
            "RentalPerDay",
            "Available"});
            this.cboField.Location = new System.Drawing.Point(10, 73);
            this.cboField.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(199, 24);
            this.cboField.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleRegNoDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.engineSizeDataGridViewTextBoxColumn,
            this.dateRegisteredDataGridViewTextBoxColumn,
            this.rentalPerDayDataGridViewTextBoxColumn,
            this.availableDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblCarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 188);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1180, 274);
            this.dataGridView1.TabIndex = 1;
            // 
            // vehicleRegNoDataGridViewTextBoxColumn
            // 
            this.vehicleRegNoDataGridViewTextBoxColumn.DataPropertyName = "VehicleRegNo";
            this.vehicleRegNoDataGridViewTextBoxColumn.HeaderText = "VehicleRegNo";
            this.vehicleRegNoDataGridViewTextBoxColumn.Name = "vehicleRegNoDataGridViewTextBoxColumn";
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            // 
            // engineSizeDataGridViewTextBoxColumn
            // 
            this.engineSizeDataGridViewTextBoxColumn.DataPropertyName = "EngineSize";
            this.engineSizeDataGridViewTextBoxColumn.HeaderText = "EngineSize";
            this.engineSizeDataGridViewTextBoxColumn.Name = "engineSizeDataGridViewTextBoxColumn";
            // 
            // dateRegisteredDataGridViewTextBoxColumn
            // 
            this.dateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.HeaderText = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.Name = "dateRegisteredDataGridViewTextBoxColumn";
            // 
            // rentalPerDayDataGridViewTextBoxColumn
            // 
            this.rentalPerDayDataGridViewTextBoxColumn.DataPropertyName = "RentalPerDay";
            this.rentalPerDayDataGridViewTextBoxColumn.HeaderText = "RentalPerDay";
            this.rentalPerDayDataGridViewTextBoxColumn.Name = "rentalPerDayDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewCheckBoxColumn
            // 
            this.availableDataGridViewCheckBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewCheckBoxColumn.HeaderText = "Available";
            this.availableDataGridViewCheckBoxColumn.Name = "availableDataGridViewCheckBoxColumn";
            // 
            // tblCarBindingSource
            // 
            this.tblCarBindingSource.DataMember = "TblCar";
            this.tblCarBindingSource.DataSource = this.hireDataSet;
            // 
            // hireDataSet
            // 
            this.hireDataSet.DataSetName = "hireDataSet";
            this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Cyan;
            this.btnRun.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(978, 36);
            this.btnRun.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(193, 49);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Cyan;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(978, 117);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(193, 49);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tblCarTableAdapter
            // 
            this.tblCarTableAdapter.ClearBeforeFill = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1222, 492);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Castellar", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSearch";
            this.Text = "Task A Dante Naidoo 10/10/23";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private hireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private hireDataSetTableAdapters.TblCarTableAdapter tblCarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRegisteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalPerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
    }
}