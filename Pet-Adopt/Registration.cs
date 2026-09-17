using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Pet_Adopt
{
    public partial class btnRegisterR : Form
    {
        public btnRegisterR()
        {
            InitializeComponent();
            //Hide password
            txtNewPassword.PasswordChar = '*';
            txtConfirmP.PasswordChar = '*';
        }

        private void btbRegister_Click(object sender, EventArgs e)
        {
            //declaring variables
            string usernameR = txtUserNameR.Text, passwordR = txtNewPassword.Text, confirmP = txtConfirmP.Text, email = txtEmail.Text, phoneNumber = txtPhoneNumber.Text;
            //connection with the stream 
            StreamWriter writer = new StreamWriter("C:\\Users\\sakid\\source\\repos\\Pet-Adopt\\Pet-Adopt\\registration.txt");
            //string to char array
            char[] phoneArray = new char[10];
            phoneArray = phoneNumber.ToCharArray();

            using (writer)
            {
                //Username
                if (string.IsNullOrEmpty(usernameR))
                {
                    MessageBox.Show("Please enter a username!", "Error");
                    txtUserNameR.Focus();
                    return;
                }
                else
                {
                    writer.WriteLine(usernameR);
                }

                //Password
                if (passwordR.Length >= 8)
                {
                    writer.WriteLine(passwordR);
                }

                else
                {
                    MessageBox.Show("Password must be at least 8 characters long!", "Error");
                    txtNewPassword.Focus();
                    return;
                }

                if (passwordR != confirmP)
                {
                    MessageBox.Show("Passwords do not match!", "Error");
                    txtConfirmP.Focus();
                    return;
                }

                //Email
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please enter an email!", "Error");
                    txtEmail.Focus();
                    return;
                }
                else
                {
                    writer.WriteLine(email);
                }

                //Phone Number
                if (phoneArray[0] == '0' && phoneArray.Length == 10 && phoneArray.All(char.IsDigit))
                {
                    writer.WriteLine(phoneNumber);
                }

                else if (phoneArray[0] != '0')
                {
                    MessageBox.Show("Phone number must start with 0!", "Error");
                    txtPhoneNumber.Focus();
                    return;
                }
                else if (phoneArray.Length != 10)
                {
                    MessageBox.Show("Phone number must be 10 digits long!", "Error");
                    txtPhoneNumber.Focus();
                    return;
                }
                else if (!phoneArray.All(char.IsDigit))
                {
                    MessageBox.Show("Phone number must contain only digits!", "Error");
                    txtPhoneNumber.Focus();
                    return;
                }

                //Gender
                if (cmbGender.SelectedItem == "Male")
                {
                    writer.WriteLine("Male");
                }
                else if (cmbGender.SelectedItem == "Female")
                {
                    writer.WriteLine("Female");
                }
                else
                {
                    MessageBox.Show("Please select a gender!", "Error");
                    cmbGender.Focus();
                    return;
                }

                //Message 
                MessageBox.Show("Registration successful", "Success");

                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
