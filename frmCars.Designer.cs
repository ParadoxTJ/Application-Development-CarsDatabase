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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.lblEngineSize = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lvlAvailable = new System.Windows.Forms.Label();
            this.lblRentPerDay = new System.Windows.Forms.Label();
            this.lblDayReg = new System.Windows.Forms.Label();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.txtRentPerDay = new System.Windows.Forms.TextBox();
            this.txtDayReg = new System.Windows.Forms.TextBox();
            this.txtEngineSize = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.cbxAvailable = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.hireDataSet = new CarsDatabase.HireDataSet();
            this.tblCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCarsTableAdapter = new CarsDatabase.HireDataSetTableAdapters.tblCarsTableAdapter();
            this.tableAdapterManager = new CarsDatabase.HireDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(268, 9);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(196, 28);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Bowman Car Hire";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(619, 58);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(619, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(619, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(619, 203);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(619, 145);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(75, 23);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "&Search";
            this.lblSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(619, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(159, 251);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 7;
            this.btnFirst.Text = "&First";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(240, 251);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(427, 252);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(508, 251);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 10;
            this.btnLast.Text = "&Last";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(321, 254);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 20);
            this.txtCount.TabIndex = 11;
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Location = new System.Drawing.Point(138, 55);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(134, 13);
            this.lblRegNumber.TabIndex = 12;
            this.lblRegNumber.Text = "Vehicle registration number";
            // 
            // lblEngineSize
            // 
            this.lblEngineSize.AutoSize = true;
            this.lblEngineSize.Location = new System.Drawing.Point(211, 126);
            this.lblEngineSize.Name = "lblEngineSize";
            this.lblEngineSize.Size = new System.Drawing.Size(61, 13);
            this.lblEngineSize.TabIndex = 13;
            this.lblEngineSize.Text = "Engine size";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(237, 97);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 14;
            this.lblMake.Text = "Make";
            // 
            // lvlAvailable
            // 
            this.lvlAvailable.AutoSize = true;
            this.lvlAvailable.Location = new System.Drawing.Point(221, 215);
            this.lvlAvailable.Name = "lvlAvailable";
            this.lvlAvailable.Size = new System.Drawing.Size(50, 13);
            this.lvlAvailable.TabIndex = 15;
            this.lvlAvailable.Text = "Available";
            // 
            // lblRentPerDay
            // 
            this.lblRentPerDay.AutoSize = true;
            this.lblRentPerDay.Location = new System.Drawing.Point(196, 191);
            this.lblRentPerDay.Name = "lblRentPerDay";
            this.lblRentPerDay.Size = new System.Drawing.Size(76, 13);
            this.lblRentPerDay.TabIndex = 16;
            this.lblRentPerDay.Text = "Rental per day";
            // 
            // lblDayReg
            // 
            this.lblDayReg.AutoSize = true;
            this.lblDayReg.Location = new System.Drawing.Point(193, 158);
            this.lblDayReg.Name = "lblDayReg";
            this.lblDayReg.Size = new System.Drawing.Size(79, 13);
            this.lblDayReg.TabIndex = 17;
            this.lblDayReg.Text = "Date registered";
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Location = new System.Drawing.Point(321, 55);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRegNumber.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txtRegNumber, "Reg");
            // 
            // txtRentPerDay
            // 
            this.txtRentPerDay.Location = new System.Drawing.Point(321, 188);
            this.txtRentPerDay.Name = "txtRentPerDay";
            this.txtRentPerDay.Size = new System.Drawing.Size(100, 20);
            this.txtRentPerDay.TabIndex = 19;
            // 
            // txtDayReg
            // 
            this.txtDayReg.Location = new System.Drawing.Point(321, 155);
            this.txtDayReg.Name = "txtDayReg";
            this.txtDayReg.Size = new System.Drawing.Size(100, 20);
            this.txtDayReg.TabIndex = 20;
            // 
            // txtEngineSize
            // 
            this.txtEngineSize.Location = new System.Drawing.Point(321, 119);
            this.txtEngineSize.Name = "txtEngineSize";
            this.txtEngineSize.Size = new System.Drawing.Size(100, 20);
            this.txtEngineSize.TabIndex = 21;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(321, 94);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 22;
            // 
            // cbxAvailable
            // 
            this.cbxAvailable.AutoSize = true;
            this.cbxAvailable.Location = new System.Drawing.Point(321, 214);
            this.cbxAvailable.Name = "cbxAvailable";
            this.cbxAvailable.Size = new System.Drawing.Size(15, 14);
            this.cbxAvailable.TabIndex = 23;
            this.cbxAvailable.UseVisualStyleBackColor = true;
            // 
            // hireDataSet
            // 
            this.hireDataSet.DataSetName = "HireDataSet";
            this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCarsBindingSource
            // 
            this.tblCarsBindingSource.DataMember = "tblCars";
            this.tblCarsBindingSource.DataSource = this.hireDataSet;
            // 
            // tblCarsTableAdapter
            // 
            this.tblCarsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCarsTableAdapter = this.tblCarsTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarsDatabase.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(732, 285);
            this.Controls.Add(this.cbxAvailable);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtEngineSize);
            this.Controls.Add(this.txtDayReg);
            this.Controls.Add(this.txtRentPerDay);
            this.Controls.Add(this.txtRegNumber);
            this.Controls.Add(this.lblDayReg);
            this.Controls.Add(this.lblRentPerDay);
            this.Controls.Add(this.lvlAvailable);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblEngineSize);
            this.Controls.Add(this.lblRegNumber);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblCompanyName);
            this.Name = "frmCars";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button lblSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.Label lblEngineSize;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lvlAvailable;
        private System.Windows.Forms.Label lblRentPerDay;
        private System.Windows.Forms.Label lblDayReg;
        private System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.TextBox txtRentPerDay;
        private System.Windows.Forms.TextBox txtDayReg;
        private System.Windows.Forms.TextBox txtEngineSize;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.CheckBox cbxAvailable;
        private System.Windows.Forms.ToolTip toolTip1;
        private HireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarsBindingSource;
        private HireDataSetTableAdapters.tblCarsTableAdapter tblCarsTableAdapter;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}