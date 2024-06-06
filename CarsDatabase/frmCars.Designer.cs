namespace CarsDatabase
{
    partial class frmCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCars));
            this.txtVehicleRegistrationNumber = new System.Windows.Forms.TextBox();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet = new CarsDatabase.hireDataSet();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtDateRegistered = new System.Windows.Forms.TextBox();
            this.txtRentalPerDay = new System.Windows.Forms.TextBox();
            this.cbxAvailable = new System.Windows.Forms.CheckBox();
            this.lblVehicleRegNumber = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblEngineSize = new System.Windows.Forms.Label();
            this.lblDateRegistered = new System.Windows.Forms.Label();
            this.lblRentalPerDay = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tblCarTableAdapter = new CarsDatabase.hireDataSetTableAdapters.TblCarTableAdapter();
            this.tableAdapterManager = new CarsDatabase.hireDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVehicleRegistrationNumber
            // 
            this.txtVehicleRegistrationNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "VehicleRegNo", true));
            this.txtVehicleRegistrationNumber.Location = new System.Drawing.Point(347, 124);
            this.txtVehicleRegistrationNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtVehicleRegistrationNumber.Name = "txtVehicleRegistrationNumber";
            this.txtVehicleRegistrationNumber.Size = new System.Drawing.Size(207, 23);
            this.txtVehicleRegistrationNumber.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txtVehicleRegistrationNumber, "Please enter vehicle registration number");
            // 
            // tblCarBindingSource
            // 
            this.tblCarBindingSource.DataMember = "TblCar";
            this.tblCarBindingSource.DataSource = this.hireDataSet;
            this.tblCarBindingSource.CurrentChanged += new System.EventHandler(this.tblCarBindingSource_CurrentChanged);
            // 
            // hireDataSet
            // 
            this.hireDataSet.DataSetName = "hireDataSet";
            this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMake
            // 
            this.txtMake.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "Make", true));
            this.txtMake.Location = new System.Drawing.Point(347, 170);
            this.txtMake.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(207, 23);
            this.txtMake.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtMake, "Please enter vehicle make");
            // 
            // txtDateRegistered
            // 
            this.txtDateRegistered.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "DateRegistered", true));
            this.txtDateRegistered.Location = new System.Drawing.Point(347, 258);
            this.txtDateRegistered.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDateRegistered.Name = "txtDateRegistered";
            this.txtDateRegistered.Size = new System.Drawing.Size(207, 23);
            this.txtDateRegistered.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtDateRegistered, "Please enter date registered");
            // 
            // txtRentalPerDay
            // 
            this.txtRentalPerDay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "RentalPerDay", true));
            this.txtRentalPerDay.Location = new System.Drawing.Point(347, 309);
            this.txtRentalPerDay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtRentalPerDay.Name = "txtRentalPerDay";
            this.txtRentalPerDay.Size = new System.Drawing.Size(207, 23);
            this.txtRentalPerDay.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtRentalPerDay, "Please enter rental per day");
            this.txtRentalPerDay.TextChanged += new System.EventHandler(this.txtRentalPerDay_TextChanged);
            // 
            // cbxAvailable
            // 
            this.cbxAvailable.AutoSize = true;
            this.cbxAvailable.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblCarBindingSource, "Available", true));
            this.cbxAvailable.Location = new System.Drawing.Point(347, 358);
            this.cbxAvailable.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbxAvailable.Name = "cbxAvailable";
            this.cbxAvailable.Size = new System.Drawing.Size(15, 14);
            this.cbxAvailable.TabIndex = 5;
            this.cbxAvailable.UseVisualStyleBackColor = true;
            // 
            // lblVehicleRegNumber
            // 
            this.lblVehicleRegNumber.AutoSize = true;
            this.lblVehicleRegNumber.Location = new System.Drawing.Point(92, 128);
            this.lblVehicleRegNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblVehicleRegNumber.Name = "lblVehicleRegNumber";
            this.lblVehicleRegNumber.Size = new System.Drawing.Size(249, 16);
            this.lblVehicleRegNumber.TabIndex = 6;
            this.lblVehicleRegNumber.Text = "Vehicle Registration Number:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(92, 174);
            this.lblMake.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(53, 16);
            this.lblMake.TabIndex = 7;
            this.lblMake.Text = "Make:";
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.Location = new System.Drawing.Point(92, 214);
            this.lblEngineSize.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(96, 16);
            this.lblEngineSize.TabIndex = 8;
            this.lblEngineSize.Text = "Engine Size:";
            // 
            // lblDateRegistered
            // 
            this.lblDateRegistered.AutoSize = true;
            this.lblDateRegistered.Location = new System.Drawing.Point(92, 266);
            this.lblDateRegistered.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDateRegistered.Name = "lblDateRegistered";
            this.lblDateRegistered.Size = new System.Drawing.Size(136, 16);
            this.lblDateRegistered.TabIndex = 9;
            this.lblDateRegistered.Text = "Date Registered:";
            // 
            // lblRentalPerDay
            // 
            this.lblRentalPerDay.AutoSize = true;
            this.lblRentalPerDay.Location = new System.Drawing.Point(92, 318);
            this.lblRentalPerDay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRentalPerDay.Name = "lblRentalPerDay";
            this.lblRentalPerDay.Size = new System.Drawing.Size(135, 16);
            this.lblRentalPerDay.TabIndex = 10;
            this.lblRentalPerDay.Text = "Rental Per Day:";
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Castellar", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(92, 353);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(91, 16);
            this.lblAvailable.TabIndex = 11;
            this.lblAvailable.Text = "Available:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bodoni MT Poster Compressed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(337, 60);
            this.lblName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 31);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Bowman Car Hire";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(448, 425);
            this.txtCount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(164, 23);
            this.txtCount.TabIndex = 13;
            this.txtCount.Text = "1 of 15";
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.Aqua;
            this.btnFirst.Location = new System.Drawing.Point(250, 422);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(63, 28);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "&First";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Aqua;
            this.btnPrevious.Location = new System.Drawing.Point(323, 421);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(97, 28);
            this.btnPrevious.TabIndex = 15;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Aqua;
            this.btnNext.Location = new System.Drawing.Point(648, 422);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 28);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.Aqua;
            this.btnLast.Location = new System.Drawing.Point(722, 422);
            this.btnLast.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(60, 28);
            this.btnLast.TabIndex = 17;
            this.btnLast.Text = "&Last";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Aqua;
            this.btnExit.Location = new System.Drawing.Point(922, 295);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 28);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Aqua;
            this.btnCancel.Location = new System.Drawing.Point(922, 258);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 28);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aqua;
            this.btnSearch.Location = new System.Drawing.Point(922, 223);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 28);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Aqua;
            this.btnDelete.Location = new System.Drawing.Point(922, 187);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 28);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Aqua;
            this.btnAdd.Location = new System.Drawing.Point(922, 151);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 28);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Aqua;
            this.btnUpdate.Location = new System.Drawing.Point(922, 116);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 28);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "EngineSize", true));
            this.txtEngineSize.Location = new System.Drawing.Point(347, 214);
            this.txtEngineSize.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(207, 23);
            this.txtEngineSize.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtEngineSize, "Please enter vehicle engine size");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1138, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // tblCarTableAdapter
            // 
            this.tblCarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TblCarTableAdapter = this.tblCarTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarsDatabase.hireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1138, 500);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtEngineSize);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAvailable);
            this.Controls.Add(this.lblRentalPerDay);
            this.Controls.Add(this.lblDateRegistered);
            this.Controls.Add(this.lblEngineSize);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblVehicleRegNumber);
            this.Controls.Add(this.cbxAvailable);
            this.Controls.Add(this.txtRentalPerDay);
            this.Controls.Add(this.txtDateRegistered);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtVehicleRegistrationNumber);
            this.Font = new System.Drawing.Font("Castellar", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCars";
            this.Text = "Task A  Dante Naidoo10/10/23";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVehicleRegistrationNumber;
        private hireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private hireDataSetTableAdapters.TblCarTableAdapter tblCarTableAdapter;
        private hireDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtDateRegistered;
        private System.Windows.Forms.TextBox txtRentalPerDay;
        private System.Windows.Forms.CheckBox cbxAvailable;
        private System.Windows.Forms.Label lblVehicleRegNumber;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblEngineSize;
        private System.Windows.Forms.Label lblDateRegistered;
        private System.Windows.Forms.Label lblRentalPerDay;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}