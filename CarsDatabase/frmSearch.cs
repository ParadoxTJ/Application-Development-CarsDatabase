using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.TblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.TblCar);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            frmCars newform = new frmCars();
            newform.Show();
            this.Hide();

        }



        private void btnRun_Click(object sender, EventArgs e)
        {
                string selectedField = cboField.SelectedItem.ToString();
                string selectedOperator = cboOperator.SelectedItem.ToString();
                string searchText = txtValue.Text;

                // Check if all criteria are filled
                if (!string.IsNullOrWhiteSpace(selectedField) && !string.IsNullOrWhiteSpace(selectedOperator) && !string.IsNullOrWhiteSpace(searchText))
                {
                    // Get the data based on the selected criteria
                    DataTable matchingData = new DataTable();

                    // Define columns
                    matchingData.Columns.Add("VehicleRegNo", typeof(string));
                    matchingData.Columns.Add("Make", typeof(string));
                    matchingData.Columns.Add("EngineSize", typeof(string));
                    matchingData.Columns.Add("DateRegistered", typeof(DateTime));
                    matchingData.Columns.Add("RentalPerDay", typeof(decimal));
                    matchingData.Columns.Add("Available", typeof(bool));

                    // LINQ query to filter data
                    var query = hireDataSet.TblCar.AsEnumerable()
                        .Where(row => (selectedField == "All" || row[selectedField].ToString() == searchText));

                    foreach (DataRow row in query)
                    {
                        matchingData.Rows.Add(row["VehicleRegNo"], row["Make"], row["EngineSize"], row["DateRegistered"], row["RentalPerDay"], row["Available"]);
                    }

                    // Display the matching data in the DataGridView
                    dataGridView1.DataSource = matchingData;
                }
                else
                {
                    // Display a message to the user indicating that all criteria must be filled
                    MessageBox.Show("Please fill in all search criteria.");
                }
            }


        }
    }





