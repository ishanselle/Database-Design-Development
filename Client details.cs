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
    public partial class Client_details : Form
    {
        private string connectionString = "Data Source=ISHAN_SELLAHEWA;Initial Catalog=QuietAttic Films;Integrated Security=True";
        public Client_details()
        {
            InitializeComponent();
        }

        private void YourForm_Load(object sender, EventArgs e)
        {
            LoadClient_ID();
        }

        private void LoadClient_ID()
        {
            string connectionString = "Data Source=ISHAN_SELLAHEWA;Initial Catalog=QuietAttic Films;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT ID FROM Client";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear previous items and configure data binding
                            comboBoxCid.DataSource = null;
                            comboBoxCid.Items.Clear();
                            comboBoxCid.DisplayMember = "ID";
                            comboBoxCid.ValueMember = "ID";

                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            comboBoxCid.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data from the database: " + ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
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
            txtcid.Clear();
            txtcfn.Clear();
            txtccn.Clear();
            txtcaddress.Clear();
            txtcemail.Clear();
            comboBoxCid.Text = "";
            txtcid.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to insert data
                    string insertQuery = "INSERT INTO Client (ID, Name, [Contact No], Address, Email) VALUES (@ID, @Name, @ContactNo, @Address, @Email)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", txtcid.Text);
                        command.Parameters.AddWithValue("@Name", txtcfn.Text);
                        command.Parameters.AddWithValue("@ContactNo", txtccn.Text);
                        command.Parameters.AddWithValue("@Address", txtcaddress.Text);
                        command.Parameters.AddWithValue("@Email", txtcemail.Text);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!");
                            LoadClient_ID();
                            // Clear the text boxes or perform other actions as needed
                            txtcid.Clear();
                            txtcfn.Clear();
                            txtccn.Clear();
                            txtcaddress.Clear();
                            txtcemail.Clear();
                            comboBoxCid.Text = "";
                            txtcid.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }
        }

        private void Client_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quietAttic_FilmsDataSet2.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.quietAttic_FilmsDataSet2.Client);
            txtcid.Clear();
            txtcfn.Clear();
            txtccn.Clear();
            txtcaddress.Clear();
            txtcemail.Clear();
            comboBoxCid.Text = "";
            txtcid.Focus();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to update data in the "Client" table
                    string updateQuery = "UPDATE Client SET Name = @Name, [Contact No] = @ContactNo, Address = @Address, Email = @Email WHERE ID = @ID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Set parameter values from your text boxes
                        command.Parameters.AddWithValue("@ID", txtcid.Text);
                        command.Parameters.AddWithValue("@Name", txtcfn.Text);
                        command.Parameters.AddWithValue("@ContactNo", txtccn.Text);
                        command.Parameters.AddWithValue("@Address", txtcaddress.Text);
                        command.Parameters.AddWithValue("@Email", txtcemail.Text);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful!");
                            txtcid.Clear();
                            txtcfn.Clear();
                            txtccn.Clear();
                            txtcaddress.Clear();
                            txtcemail.Clear();
                            comboBoxCid.Text = "";
                            txtcid.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Update failed. The specified client ID was not found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                {
                    LoadClient_ID();

                }
            }
        }

        private void btnedlet_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if an item is selected in the ComboBox
                    if (comboBoxCid.SelectedItem != null)
                    {
                        // Assuming your ComboBox is bound to a data source
                        DataRowView selectedRow = comboBoxCid.SelectedItem as DataRowView;

                        if (selectedRow != null)
                        {
                            // Extract the value from the "ID" column
                            int selectedClientID = Convert.ToInt32(selectedRow["ID"]);

                            // Create a SQL query to delete the client's record from the "Client" table
                            string deleteQuery = "DELETE FROM Client WHERE ID = @ID";

                            using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                            {
                                // Set the parameter for the client ID
                                command.Parameters.AddWithValue("@ID", selectedClientID);

                                // Execute the query
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Deletion successful!");
                                    LoadClient_ID();
                                    // You may want to clear the client information from the TextBoxes here
                                    txtcid.Clear();
                                    txtcfn.Clear();
                                    txtccn.Clear();
                                    txtcaddress.Clear();
                                    txtcemail.Clear();
                                    comboBoxCid.Text = "";
                                    txtcid.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("Deletion failed. The specified client ID was not found.");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a client from the ComboBox.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void comboBoxCid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCid.SelectedValue != null)
            {
                int selectedClientID = Convert.ToInt32(comboBoxCid.SelectedValue);
                string connectionString = "Data Source=ISHAN_SELLAHEWA;Initial Catalog=QuietAttic Films;Integrated Security=True";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query_select = "SELECT * FROM Client WHERE ID = @ClientID";
                        using (SqlCommand command = new SqlCommand(query_select, con))
                        {
                            command.Parameters.AddWithValue("@ClientID", selectedClientID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Fill the form fields with data from the database based on the selected client ID.
                                    txtcid.Text = reader["ID"].ToString();
                                    txtcfn.Text = reader["Name"].ToString();
                                    txtccn.Text = reader["Contact No"].ToString();
                                    txtcaddress.Text = reader["Address"].ToString();
                                    txtcemail.Text = reader["Email"].ToString();

                                    // Add code to fill other fields as needed
                                }
                                else
                                {
                                    // If the selected client ID is not found in the database, clear the form fields.
                                    ClearFormFields();
                                    MessageBox.Show("Selected client ID not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void ClearFormFields()
        {
            // Add code to clear all form fields as needed
            txtcfn.Clear();
            txtccn.Clear();
            txtcaddress.Clear();
            txtcemail.Clear();

            // Clear other fields
        }
    }
    }
