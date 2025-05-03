using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiet_Attic_Films
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure, Do you really want to exit....?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabelClient_d_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Client_details obj = new Client_details();
            obj.Show();
            this.Hide();
        }

        private void linkLabelProduction_d_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Production_details obj = new Production_details();
            obj.Show();
            this.Hide();
        }

        private void linkLabelProperty_d_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Property_details obj = new Property_details();
            obj.Show();
            this.Hide();
        }

        private void linkLabelLocation_D_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Location_details obj = new Location_details();
            obj.Show();
            this.Hide();
        }

        private void linkLabelStaff_d_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Staff_details obj = new Staff_details();
            obj.Show();
            this.Hide();
        }

        private void linkLabelPayment_d_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Payment_details obj = new Payment_details();
            obj.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            FormQuiet_Attic_Films form = new FormQuiet_Attic_Films();
            form.Show();
            this.Close();
        }
    }
}
