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
    public partial class Payment_details : Form
    {
        string connectionString = "Data Source=ISHAN_SELLAHEWA;Initial Catalog=QuietAttic Films;Integrated Security=True";
        public Payment_details()
        {
            InitializeComponent();
            LoadPayment_ID();
        }

        private void lblamount_Click(object sender, EventArgs e)
        {

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
            txtpid.Clear();
            dateTimePickerpdate.Format = DateTimePickerFormat.Custom;
            dateTimePickerpdate.CustomFormat = "yyyy/MM/dd";
            DateTime thisDay = DateTime.Today;
            dateTimePickerpdate.Text = thisDay.ToString();
            txtpmethod.Clear();
            txtpamount.Clear();
            comboBoxpid.Text = "";
            comboBoxPayID.Text = "";
            txtpid.Focus();

        }

        private void Payment_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quietAttic_FilmsDataSet8.Production' table. You can move, or remove it, as needed.
            this.productionTableAdapter.Fill(this.quietAttic_FilmsDataSet8.Production);
            txtpid.Clear();
            dateTimePickerpdate.Format = DateTimePickerFormat.Custom;
            dateTimePickerpdate.CustomFormat = "yyyy/MM/dd";
            DateTime thisDay = DateTime.Today;
            dateTimePickerpdate.Text = thisDay.ToString();
            txtpmethod.Clear();
            txtpamount.Clear();
            comboBoxpid.Text = "";
            comboBoxPayID.Text = "";
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to insert data into the Payment table
                    string insertQuery = "INSERT INTO Payment (ID, Date, Method, [Amount], [Production ID]) " +
                                         "VALUES (@ID, @Date, @Method, @Amount, @ProductionID)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@ID", txtpid.Text);
                        command.Parameters.AddWithValue("@Date", dateTimePickerpdate.Value); // Use Value property for DateTimePicker
                        command.Parameters.AddWithValue("@Method", txtpmethod.Text);
                        command.Parameters.AddWithValue("@Amount", txtpamount.Text);
                        command.Parameters.AddWithValue("@ProductionID", Convert.ToInt32(comboBoxpid.SelectedValue));

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment registration successful!");
                            LoadPayment_ID();
                            // Optionally, clear form fields or perform other actions
                            txtpid.Clear();
                            dateTimePickerpdate.Format = DateTimePickerFormat.Custom;
                            dateTimePickerpdate.CustomFormat = "yyyy/MM/dd";
                            DateTime thisDay = DateTime.Today;
                            dateTimePickerpdate.Value = thisDay; // Use Value property for DateTimePicker
                            txtpmethod.Clear();
                            txtpamount.Clear();
                            comboBoxpid.Text = "";
                            comboBoxPayID.Text = "";
                            txtpid.Focus();
                            // Clear other fields as needed
                        }
                        else
                        {
                            MessageBox.Show("Payment registration failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while inserting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void comboBoxPayID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPayID.SelectedValue != null)
            {
                int selectedPaymentID = Convert.ToInt32(comboBoxPayID.SelectedValue);
                string connectionString = "Data Source=ISHAN_SELLAHEWA;Initial Catalog=QuietAttic Films;Integrated Security=True";

                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query_select = "SELECT * FROM Payment WHERE ID = @PaymentID";
                        using (SqlCommand command = new SqlCommand(query_select, con))
                        {
                            command.Parameters.AddWithValue("@PaymentID", selectedPaymentID);
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Fill the form fields with data from the database based on the selected Payment ID.
                                    txtpid.Text = reader["ID"].ToString();
                                    dateTimePickerpdate.Text = reader["Date"].ToString();
                                    txtpmethod.Text = reader["Method"].ToString();
                                    txtpamount.Text = reader["Amount"].ToString();
                                    int ProductionID = Convert.ToInt32(reader["Production ID"]);
                                    comboBoxpid.SelectedValue = ProductionID; // Set the selected client in the combo box.
                                    comboBoxpid.Text = reader["Production ID"].ToString();
                                }
                                else
                                {
                                    // If the selected Payment ID is not found in the database, clear the form fields.
                                    txtpid.Clear();
                                    dateTimePickerpdate.Format = DateTimePickerFormat.Custom;
                                    dateTimePickerpdate.CustomFormat = "yyyy/MM/dd";
                                    DateTime thisDay = DateTime.Today;
                                    dateTimePickerpdate.Text = thisDay.ToString();
                                    txtpmethod.Clear();
                                    txtpamount.Clear();
                                    comboBoxpid.Text = "";
                                    comboBoxPayID.Text = "";
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

        private void LoadPayment_ID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to fetch registration numbers from the "Payment" table
                    string selectQuery = "SELECT ID FROM Payment";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear previous items and configure data binding
                            comboBoxPayID.DataSource = null;
                            comboBoxPayID.Items.Clear();
                            comboBoxPayID.DisplayMember = "ID";
                            comboBoxPayID.ValueMember = "ID";

                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            comboBoxPayID.DataSource = dt;
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
            if (string.IsNullOrWhiteSpace(txtpid.Text))
            {
                MessageBox.Show("Please select a Payment to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Create a SQL query to update data in the Payment table
                    string updateQuery = "UPDATE Payment SET Date = @Date, [Method] = @Method, " +
                                         "Amount = @Amount, [Production ID] = @ProductionID WHERE ID = @PaymentID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@ID", txtpid.Text);
                        command.Parameters.AddWithValue("@Date", dateTimePickerpdate.Text);
                        command.Parameters.AddWithValue("@Method", txtpmethod.Text);
                        command.Parameters.AddWithValue("@Amount", txtpamount.Text);
                        command.Parameters.AddWithValue("@ProductionID", Convert.ToInt32(comboBoxpid.SelectedValue)); 

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Payment update successful!");
                            // Optionally, clear form fields or perform other actions
                            txtpid.Clear();
                            dateTimePickerpdate.Format = DateTimePickerFormat.Custom;
                            dateTimePickerpdate.CustomFormat = "yyyy/MM/dd";
                            DateTime thisDay = DateTime.Today;
                            dateTimePickerpdate.Text = thisDay.ToString();
                            txtpmethod.Clear();
                            txtpamount.Clear();
                            comboBoxpid.Text = "";
                            comboBoxPayID.Text = "";
                            txtpid.Focus();
                            // Clear other fields as needed
                        }
                        else
                        {
                            MessageBox.Show("Payment update failed!");
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
            if (string.IsNullOrWhiteSpace(txtpid.Text))
            {
                MessageBox.Show("Please select a Payment to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this Payment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Create a SQL query to delete a production record
                        string deleteQuery = "DELETE FROM Payment WHERE ID = @PaymentID";

                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            // Set parameter values
                            command.Parameters.AddWithValue("@PaymentID", txtpid.Text);

                            // Execute the query
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Payment deleted successfully!");
                                LoadPayment_ID();
                                // Optionally, clear form fields or perform other actions
                                txtpid.Clear();
                                dateTimePickerpdate.Format = DateTimePickerFormat.Custom;
                                dateTimePickerpdate.CustomFormat = "yyyy/MM/dd";
                                DateTime thisDay = DateTime.Today;
                                dateTimePickerpdate.Text = thisDay.ToString();
                                txtpmethod.Clear();
                                txtpamount.Clear();
                                comboBoxpid.Text = "";
                                comboBoxPayID.Text = "";
                                txtpid.Focus();
                                // Clear other fields as needed
                            }
                            else
                            {
                                MessageBox.Show("Payment deletion failed!");
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
