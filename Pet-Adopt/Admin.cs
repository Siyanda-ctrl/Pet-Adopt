using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Pet_Adopt
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            //Hide password
            txtPassword.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Button for admin's password
        private void btnGrantAccess_Click(object sender, EventArgs e)
        {
            string adminPassword = "petadopt";

            if (txtPassword.Text == adminPassword)
            {
                MessageBox.Show("Access granted.");
                Admin_Dashboard adminD = new Admin_Dashboard();
                adminD.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid admin password.");
            }

        }
    }
}
