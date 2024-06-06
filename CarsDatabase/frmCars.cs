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

namespace CarsDatabase
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.TblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.TblCar);

        }

        private void tblCarBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            frmSearch newForm = new frmSearch();
            newForm.Show();
            this.Hide();

        }

        private void txtRentalPerDay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tblCarBindingSource.EndEdit();
                this.tblCarTableAdapter.Update(this.hireDataSet);
                MessageBox.Show("Data updated .");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Update failed: " + ex.Message);
            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveFirst();
            txtCount.Text = (tblCarBindingSource.Position + 1) + " of " + (tblCarBindingSource.Count);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtVehicleRegistrationNumber.Clear();
            txtMake.Clear();
            txtEngineSize.Clear();
            txtDateRegistered.Clear();
            txtRentalPerDay.Clear();
            cbxAvailable.Checked = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MovePrevious();
            txtCount.Text = (tblCarBindingSource.Position + 1) + " of " + (tblCarBindingSource.Count);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveNext();
            txtCount.Text = (tblCarBindingSource.Position + 1) + " of " + (tblCarBindingSource.Count);

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tblCarBindingSource.MoveLast();
            txtCount.Text = (tblCarBindingSource.Position + 1) + " of " + (tblCarBindingSource.Count);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                tblCarBindingSource.RemoveCurrent();
                MessageBox.Show("Record deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message, "Error");                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow existingRow = hireDataSet.Tables["TblCar"].Rows.Cast<DataRow>()
    .FirstOrDefault(row => row["VehicleRegNo"].ToString() == txtVehicleRegistrationNumber.Text);

            if (existingRow != null)
            {
                
                existingRow["Make"] = txtMake.Text;
                existingRow["EngineSize"] = txtEngineSize.Text;
                existingRow["DateRegistered"] = DateTime.Parse(txtDateRegistered.Text);
                existingRow["RentalPerDay"] = decimal.Parse(txtRentalPerDay.Text);
                existingRow["Available"] = cbxAvailable.Checked;

                MessageBox.Show("Record Updated");
            }
            else
            {
                
                DataRow newRow = hireDataSet.Tables["TblCar"].NewRow();
                newRow["VehicleRegNo"] = txtVehicleRegistrationNumber.Text;
                newRow["Make"] = txtMake.Text;
                newRow["EngineSize"] = txtEngineSize.Text;
                newRow["DateRegistered"] = DateTime.Parse(txtDateRegistered.Text);
                newRow["RentalPerDay"] = decimal.Parse(txtRentalPerDay.Text);
                newRow["Available"] = cbxAvailable.Checked;

                hireDataSet.Tables["TblCar"].Rows.Add(newRow);
                hireDataSet.Tables["TblCar"].AcceptChanges();

                MessageBox.Show("New Record Added");
            }


        }
    }
}
