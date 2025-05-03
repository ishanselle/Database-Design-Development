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
    public partial class Location_details : Form
    {
        string connectionString = "Data Source=ISHAN_SELLAHEWA;Initial Catalog=QuietAttic Films;Integrated Security=True;";
        public Location_details()
        {
            InitializeComponent();
            LoadLocation_ID();
        }

        private void Location_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quietAttic_FilmsDataSet5.Production' table. You can move, or remove it, as needed.
            this.productionTableAdapter.Fill(this.quietAttic_FilmsDataSet5.Production);
            txtlid.Clear();
            txtlname.Clear();
            txtladdress.Clear();
            txtlt.Clear();
            txtlcn.Clear();
            comboBoxpid.Text = "";
            comboBoxLID.Text = "";
            txtlid.Focus();
        }

        private void btnmm_Click(object sender, EventArgs e)
        {
            Main_menu form = new Main_menu();
            form.Show();
            this.Close();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            FormQuiet_Attic_Films form = new FormQuiet_Attic_Films();
            form.Show();
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtlid.Clear();
            txtlname.Clear();
            txtladdress.Clear();
            txtlt.Clear();
            txtlcn.Clear();
            comboBoxpid.Text = "";
            comboBoxLID.Text = "";
            txtlid.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to insert data into the Location table
                    string insertQuery = "INSERT INTO Location (ID, Name, Address, [Contact No], [Location Type], [Production ID]) " +
                                         "VALUES (@ID, @Name, @Address, @ContactNo, @LocationType, @ProductionID)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@ID", txtlid.Text);
                        command.Parameters.AddWithValue("@Name", txtlname.Text);
                        command.Parameters.AddWithValue("@Address", txtladdress.Text);
                        command.Parameters.AddWithValue("@ContactNo", txtlcn.Text); // Fix the parameter name
                        command.Parameters.AddWithValue("@LocationType", txtlt.Text);
                        command.Parameters.AddWithValue("@ProductionID", Convert.ToInt32(comboBoxpid.SelectedValue)); // Assuming you have a ComboBox for selecting the production ID

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Location registration successful!");
                            LoadLocation_ID();
                            // Optionally, clear form fields or perform other actions
                            txtlid.Clear();
                            txtlname.Clear();
                            txtladdress.Clear();
                            txtlt.Clear();
                            txtlcn.Clear();
                            comboBoxpid.Text = "";
                            comboBoxLID.Text = "";
                            txtlid.Focus();
                            // Clear other fields as needed
                        }
                        else
                        {
                            MessageBox.Show("Location registration failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxLID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLID.SelectedValue != null)
            {
                int selectedPropertyID = Convert.ToInt32(comboBoxLID.SelectedValue);
                string connectionString = "Data Source=ISHAN_SELLAHEWA;Initial Catalog=QuietAttic Films;Integrated Security=True";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query_select = "SELECT * FROM Location WHERE ID = @ID";
                        using (SqlCommand command = new SqlCommand(query_select, con))
                        {
                            command.Parameters.AddWithValue("@ID", selectedPropertyID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Fill the form fields with data from the database based on the selected Location ID.
                                    txtlid.Text = reader["ID"].ToString();
                                    txtlname.Text = reader["Name"].ToString();
                                    txtladdress.Text = reader["Address"].ToString();
                                    txtlcn.Text = reader["Contact No"].ToString();
                                    txtlt.Text = reader["Location Type"].ToString();
                                    int ProductionID = Convert.ToInt32(reader["Production ID"]);
                                    comboBoxpid.SelectedValue = ProductionID; // Set the selected Production in the combo box.
                                    comboBoxpid.Text = reader["Production ID"].ToString();
                                }
                                else
                                {
                                    // If the selected Location ID is not found in the database, clear the form fields.
                                    txtlid.Clear();
                                    txtlname.Clear();
                                    txtladdress.Clear();
                                    txtlt.Clear();
                                    txtlcn.Clear();
                                    comboBoxpid.Text = "";
                                    comboBoxLID.Text = "";
                                    txtlid.Focus();
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

        private void LoadLocation_ID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to fetch registration numbers from the "Property" table
                    string selectQuery = "SELECT ID FROM Location";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear previous items and configure data binding
                            comboBoxLID.DataSource = null;
                            comboBoxLID.Items.Clear();
                            comboBoxLID.DisplayMember = "ID";
                            comboBoxLID.ValueMember = "ID";

                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            comboBoxLID.DataSource = dt;
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
            if (string.IsNullOrWhiteSpace(txtlid.Text))
            {
                MessageBox.Show("Please select a Property to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to update data in the Location table
                    string updateQuery = "UPDATE Location SET Name = @Name, Address = @Address, [Contact No] = @ContactNo, [Location Type] = @LocationType, " +
                                         "[Production ID] = @ProductionID WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@ID", txtlid.Text);
                        command.Parameters.AddWithValue("@Name", txtlname.Text);
                        command.Parameters.AddWithValue("@Address", txtladdress.Text);
                        command.Parameters.AddWithValue("@ContactNo", txtlcn.Text);
                        command.Parameters.AddWithValue("@LocationType", txtlt.Text);
                        command.Parameters.AddWithValue("@ProductionID", Convert.ToInt32(comboBoxpid.SelectedValue)); // Assuming you have a ComboBox for selecting the client

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Location update successful!");
                            // Optionally, clear form fields or perform other actions
                            txtlid.Clear();
                            txtlname.Clear();
                            txtladdress.Clear();
                            txtlt.Clear();
                            txtlcn.Clear();
                            comboBoxpid.Text = "";
                            comboBoxLID.Text = "";
                            txtlid.Focus();
                            // Clear other fields as needed
                        }
                        else
                        {
                            MessageBox.Show("Location update failed!");
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
            if (string.IsNullOrWhiteSpace(txtlid.Text))
            {
                MessageBox.Show("Please select a Location to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this Location?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create a SQL query to delete a Location record
                        string deleteQuery = "DELETE FROM Location WHERE ID = @LocationID";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            // Set parameter values
                            command.Parameters.AddWithValue("@LocationID", txtlid.Text);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Location deleted successfully!");
                                LoadLocation_ID();
                                // Optionally, clear form fields or perform other actions
                                txtlid.Clear();
                                txtlname.Clear();
                                txtladdress.Clear();
                                txtlt.Clear();
                                txtlcn.Clear();
                                comboBoxpid.Text = "";
                                comboBoxLID.Text = "";
                                txtlid.Focus();
                                // Clear other fields as needed
                            }
                            else
                            {
                                MessageBox.Show("Property deletion failed!");
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
    }
}
