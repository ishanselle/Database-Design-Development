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
    public partial class Production_details : Form
    {
        string connectionString = "Data Source=ISHAN_SELLAHEWA;Initial Catalog=QuietAttic Films;Integrated Security=True";
        public Production_details()
        {
            InitializeComponent();
            LoadProduction_ID();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            FormQuiet_Attic_Films form = new FormQuiet_Attic_Films();
            form.Show();
            this.Close();
        }

        private void YourForm_Load(object sender, EventArgs e)
        {
            LoadProduction_ID();
            comboBoxcid.Text = "";
            txtpid.Clear();
            txtpname.Clear();
            comboBoxppt.Text = "";
            dateTimePickerpdate.Format = DateTimePickerFormat.Custom;
            dateTimePickerpdate.CustomFormat = "yyyy/MM/dd";
            DateTime thisDay = DateTime.Today;
            dateTimePickerpdate.Text = thisDay.ToString();
            comboBoxcid.Text = "";
            comboBoxproid.Text = "";
            txtpid.Focus();
        }

        private void LoadProduction_ID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to fetch registration numbers from the "Production" table
                    string selectQuery = "SELECT ID FROM Production";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear previous items and configure data binding
                            comboBoxproid.DataSource = null;
                            comboBoxproid.Items.Clear();
                            comboBoxproid.DisplayMember = "ID";
                            comboBoxproid.ValueMember = "ID";

                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            comboBoxproid.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading ID numbers from the database: " + ex.Message);
                }
            }
        }


        private void comboBoxcid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtpid.Clear();
            txtpname.Clear();
            comboBoxppt.Text = "";
            dateTimePickerpdate.Format = DateTimePickerFormat.Custom;
            dateTimePickerpdate.CustomFormat = "yyyy/MM/dd";
            DateTime thisDay = DateTime.Today;
            dateTimePickerpdate.Text = thisDay.ToString();
            comboBoxcid.Text = "";
            comboBoxproid.Text = "";
            txtpid.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnmm_Click(object sender, EventArgs e)
        {
            Main_menu form = new Main_menu();
            form.Show();
            this.Close();
        }

        private void Production_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quietAttic_FilmsDataSet4.Production' table. You can move, or remove it, as needed.
            this.productionTableAdapter.Fill(this.quietAttic_FilmsDataSet4.Production);
            // TODO: This line of code loads data into the 'quietAttic_FilmsDataSet3.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.quietAttic_FilmsDataSet3.Client);
            {
                txtpid.Clear();
                txtpname.Clear();
                comboBoxppt.Text = "";
                dateTimePickerpdate.Format = DateTimePickerFormat.Custom;
                dateTimePickerpdate.CustomFormat = "yyyy/MM/dd";
                DateTime thisDay = DateTime.Today;
                dateTimePickerpdate.Text = thisDay.ToString();
                comboBoxcid.Text = "";
                comboBoxproid.Text = "";
                txtpid.Focus();
            }


        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to insert data into the Production table
                    string insertQuery = "INSERT INTO Production (ID, Name, [Production Type], Date, [Client ID]) " +
                                         "VALUES (@ID, @Name, @ProductionType, @ProductionDate, @ClientID)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@ID", txtpid.Text);
                        command.Parameters.AddWithValue("@Name", txtpname.Text);
                        command.Parameters.AddWithValue("@ProductionType", comboBoxppt.Text);
                        command.Parameters.AddWithValue("@ProductionDate", dateTimePickerpdate.Value);
                        command.Parameters.AddWithValue("@ClientID", Convert.ToInt32(comboBoxcid.SelectedValue)); // Assuming you have a ComboBox for selecting the client

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Production registration successful!");
                            LoadProduction_ID();
                            // Optionally, clear form fields or perform other actions
                            txtpid.Clear();
                            txtpname.Clear();
                            comboBoxppt.Text = "";
                            dateTimePickerpdate.Format = DateTimePickerFormat.Custom;
                            dateTimePickerpdate.CustomFormat = "yyyy/MM/dd";
                            DateTime thisDay = DateTime.Today;
                            dateTimePickerpdate.Text = thisDay.ToString();
                            comboBoxcid.Text = "";
                            comboBoxproid.Text = "";
                            txtpid.Focus();
                            // Clear other fields as needed
                        }
                        else
                        {
                            MessageBox.Show("Production registration failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBoxproid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxproid.SelectedValue != null)
            {
                int selectedProductionID = Convert.ToInt32(comboBoxproid.SelectedValue);
                string connectionString = "Data Source=ISHAN_SELLAHEWA;Initial Catalog=QuietAttic Films;Integrated Security=True";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query_select = "SELECT * FROM Production WHERE ID = @ProductionID";
                        using (SqlCommand command = new SqlCommand(query_select, con))
                        {
                            command.Parameters.AddWithValue("@ProductionID", selectedProductionID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Fill the form fields with data from the database based on the selected production ID.
                                    txtpid.Text = reader["ID"].ToString();
                                    txtpname.Text = reader["Name"].ToString();
                                    comboBoxppt.Text = reader["Production Type"].ToString();
                                    dateTimePickerpdate.Value = Convert.ToDateTime(reader["Date"]);
                                    int clientID = Convert.ToInt32(reader["Client ID"]);
                                    comboBoxcid.SelectedValue = clientID; // Set the selected client in the combo box.
                                    comboBoxcid.Text = reader["Client ID"].ToString();
                                }
                                else
                                {
                                    // If the selected production ID is not found in the database, clear the form fields.
                                    txtpid.Clear();
                                    txtpname.Clear();
                                    comboBoxppt.Text = "";
                                    dateTimePickerpdate.Format = DateTimePickerFormat.Custom;
                                    dateTimePickerpdate.CustomFormat = "yyyy/MM/dd";
                                    DateTime thisDay = DateTime.Today;
                                    dateTimePickerpdate.Text = thisDay.ToString();
                                    comboBoxcid.Text = "";
                                    comboBoxproid.Text = "";
                                    txtpid.Focus();
                                    MessageBox.Show("Selected production ID not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpid.Text))
            {
                MessageBox.Show("Please select a production to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to update data in the Production table
                    string updateQuery = "UPDATE Production SET Name = @Name, [Production Type] = @ProductionType, " +
                                         "Date = @ProductionDate, [Client ID] = @ClientID WHERE ID = @ProductionID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@ProductionID", txtpid.Text);
                        command.Parameters.AddWithValue("@Name", txtpname.Text);
                        command.Parameters.AddWithValue("@ProductionType", comboBoxppt.Text);
                        command.Parameters.AddWithValue("@ProductionDate", dateTimePickerpdate.Value);
                        command.Parameters.AddWithValue("@ClientID", Convert.ToInt32(comboBoxcid.SelectedValue)); // Assuming you have a ComboBox for selecting the client

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Production update successful!");
                            // Optionally, clear form fields or perform other actions
                            txtpid.Clear();
                            txtpname.Clear();
                            comboBoxppt.Text = "";
                            dateTimePickerpdate.Value = DateTime.Today;
                            comboBoxcid.Text = "";
                            txtpid.Focus();
                            // Clear other fields as needed
                        }
                        else
                        {
                            MessageBox.Show("Production update failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                {
                    LoadProduction_ID();
                }
            }
        }

        private void btnedlet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpid.Text))
            {
                MessageBox.Show("Please select a production to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this production?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create a SQL query to delete a production record
                        string deleteQuery = "DELETE FROM Production WHERE ID = @ProductionID";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            // Set parameter values
                            command.Parameters.AddWithValue("@ProductionID", txtpid.Text);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Production deleted successfully!");
                                LoadProduction_ID();
                                // Optionally, clear form fields or perform other actions
                                txtpid.Clear();
                                txtpname.Clear();
                                comboBoxppt.Text = "";
                                dateTimePickerpdate.Value = DateTime.Today;
                                comboBoxcid.Text = ""; // Clear the selected client
                                txtpid.Focus();
                                // Clear other fields as needed
                            }
                            else
                            {
                                MessageBox.Show("Production deletion failed!");
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