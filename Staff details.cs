using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Quiet_Attic_Films
{
    public partial class Staff_details : Form
    {
        string connectionString = "Data Source=ISHAN_SELLAHEWA;Initial Catalog=QuietAttic Films;Integrated Security=True;";
        public Staff_details()
        {
            InitializeComponent();
            LoadSalary_ID();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            FormQuiet_Attic_Films form = new FormQuiet_Attic_Films();
            form.Show();
            this.Close();
        }

        private void btnmm_Click(object sender, EventArgs e)
        {
            Main_menu form = new Main_menu();
            form.Show();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtsid.Clear();
            txtsfn.Clear();
            comboBoxst.Text = "";
            txtswd.Clear();
            comboBoxperday.Text = "";
            txtssalary.Clear();
            comboBoxpid.Text = "";
            comboBoxSID.Text = "";
            txtsid.Focus();
        }

        private void Staff_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quietAttic_FilmsDataSet7.Production' table. You can move, or remove it, as needed.
            this.productionTableAdapter.Fill(this.quietAttic_FilmsDataSet7.Production);
            txtsid.Clear();
            txtsfn.Clear();
            comboBoxst.Text = "";
            txtswd.Clear();
            comboBoxperday.Text = "";
            txtssalary.Clear();
            comboBoxpid.Text = "";
            comboBoxSID.Text = "";
            txtsid.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnsalary_Click(object sender, EventArgs e)
        {
            try
            {
                // Parse the values entered by the user
                int workingDays = int.Parse(txtswd.Text);
                decimal perDayCharge = decimal.Parse(comboBoxperday.Text);

                // Calculate the salary
                decimal salary = workingDays * perDayCharge;

                // Display the calculated salary
                txtssalary.Text = "" + salary.ToString("N2"); // Format as currency with two decimal places
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for working days and per day charge.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to insert data into the Staff table
                    string insertQuery = "INSERT INTO Staff (ID, Name, [Staff Type], [Working Day], [Salary], [Production ID]) " +
                                         "VALUES (@ID, @Name, @StaffType, @WorkingDay, @Salary, @ProductionID)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Parse the salary value as decimal
                        decimal salary = decimal.Parse(txtssalary.Text);

                        // Set parameter values
                        command.Parameters.AddWithValue("@ID", txtsid.Text);
                        command.Parameters.AddWithValue("@Name", txtsfn.Text);
                        command.Parameters.AddWithValue("@StaffType", comboBoxst.Text);
                        command.Parameters.AddWithValue("@WorkingDay", txtswd.Text);
                        command.Parameters.AddWithValue("@Salary", salary); // Set the Salary parameter as decimal
                        command.Parameters.AddWithValue("@ProductionID", Convert.ToInt32(comboBoxpid.SelectedValue)); // Assuming you have a ComboBox for selecting the production ID

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff registration successful!");
                            LoadSalary_ID();
                            // Optionally, clear form fields or perform other actions
                            txtsid.Clear();
                            txtsfn.Clear();
                            comboBoxst.Text = "";
                            txtswd.Clear();
                            comboBoxperday.Text = "";
                            txtssalary.Clear();
                            comboBoxpid.Text = "";
                            comboBoxSID.Text = "";
                            txtsid.Focus();
                            // Clear other fields as needed
                        }
                        else
                        {
                            MessageBox.Show("Staff registration failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxSID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSID.SelectedValue != null)
            {
                int selectedStaffID = Convert.ToInt32(comboBoxSID.SelectedValue);
                string connectionString = "Data Source=ISHAN_SELLAHEWA;Initial Catalog=QuietAttic Films;Integrated Security=True";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query_select = "SELECT * FROM Staff WHERE ID = @ID";
                        using (SqlCommand command = new SqlCommand(query_select, con))
                        {
                            command.Parameters.AddWithValue("@ID", selectedStaffID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Fill the form fields with data from the database based on the selected Property ID.
                                    txtsid.Text = reader["ID"].ToString();
                                    txtsfn.Text = reader["Name"].ToString();
                                    comboBoxst.Text = reader["Staff Type"].ToString();
                                    txtswd.Text = reader["Working Day"].ToString();
                                    txtssalary.Text = reader["Salary"].ToString();
                                    int ProductionID = Convert.ToInt32(reader["Production ID"]);
                                    comboBoxpid.SelectedValue = ProductionID; // Set the selected Production in the combo box.
                                    comboBoxpid.Text = reader["Production ID"].ToString();
                                }
                                else
                                {
                                    // If the selected Property ID is not found in the database, clear the form fields.
                                    txtsid.Clear();
                                    txtsfn.Clear();
                                    comboBoxst.Text = "";
                                    txtswd.Clear();
                                    comboBoxperday.Text = "";
                                    txtssalary.Clear();
                                    comboBoxpid.Text = "";
                                    comboBoxSID.Text = "";
                                    txtsid.Focus();
                                    MessageBox.Show("Selected Property ID not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while accessing the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadSalary_ID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to fetch registration numbers from the "Staff" table
                    string selectQuery = "SELECT ID FROM Staff";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear previous items and configure data binding
                            comboBoxSID.DataSource = null;
                            comboBoxSID.Items.Clear();
                            comboBoxSID.DisplayMember = "ID";
                            comboBoxSID.ValueMember = "ID";

                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            comboBoxSID.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading ID numbers from the database: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsid.Text))
            {
                MessageBox.Show("Please select a Staff to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to update data in the Staff table
                    string updateQuery = "UPDATE Staff SET Name = @Name, [Staff Type] = @StaffType, [Working Day] = @WorkingDay, [Salary] = @Salary, " +
                                         "[Production ID] = @ProductionID WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@ID", txtsid.Text);
                        command.Parameters.AddWithValue("@Name", txtsfn.Text);
                        command.Parameters.AddWithValue("@StaffType", comboBoxst.Text);
                        command.Parameters.AddWithValue("@WorkingDay", txtswd.Text);
                        command.Parameters.AddWithValue("@Salary", txtssalary.Text);
                        command.Parameters.AddWithValue("@ProductionID", Convert.ToInt32(comboBoxpid.SelectedValue));

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff update successful!");
                            // Optionally, clear form fields or perform other actions
                            txtsid.Clear();
                            txtsfn.Clear();
                            comboBoxst.Text = "";
                            txtswd.Clear();
                            comboBoxperday.Text = "";
                            txtssalary.Clear();
                            comboBoxpid.Text = "";
                            comboBoxSID.Text = "";
                            txtsid.Focus();
                            // Clear other fields as needed
                        }
                        else
                        {
                            MessageBox.Show("Staff update failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnedlet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsid.Text))
            {
                MessageBox.Show("Please select a Staff to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this Staff?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create a SQL query to delete a Staff record
                        string deleteQuery = "DELETE FROM Staff WHERE ID = @StaffID";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            // Set parameter values
                            command.Parameters.AddWithValue("@StaffID", txtsid.Text);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Staff deleted successfully!");
                                LoadSalary_ID();
                                // Optionally, clear form fields or perform other actions
                                txtsid.Clear();
                                txtsfn.Clear();
                                comboBoxst.Text = "";
                                txtswd.Clear();
                                comboBoxperday.Text = "";
                                txtssalary.Clear();
                                comboBoxpid.Text = "";
                                comboBoxSID.Text = "";
                                txtsid.Focus();
                                // Clear other fields as needed
                            }
                            else
                            {
                                MessageBox.Show("Staff deletion failed!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void comboBoxst_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

