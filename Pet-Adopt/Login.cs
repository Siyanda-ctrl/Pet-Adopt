namespace Pet_Adopt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //Hides the password with '*'
            txtPassword.PasswordChar = '*';
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // Show or hide the password based on the checkbox state
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //open registration form
            btnRegisterR registrationForm = new btnRegisterR();
            registrationForm.Show();
            this.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //connection with the stream
            StreamReader reader = new StreamReader("C:\\Users\\sakid\\source\\repos\\Pet-Adopt\\Pet-Adopt\\registration.txt");

            //declaring variables
            string username = txtUserName.Text, password = txtPassword.Text, line = "";
            string[] arrayReg = new string[2];
            bool isValid = false;

            //read the file and check if the username and password match
            using (reader)
            {

                while ((line = reader.ReadLine()) != null)
                {
                    arrayReg[0] = line;
                    arrayReg[1] = reader.ReadLine();

                    if ((arrayReg[0] == username) && (arrayReg[1] == password))
                    {
                        isValid = true;
                        break;
                    }
                }
                if (isValid)
                {
                    MessageBox.Show("Login successful", "Success");
                    this.Hide();

                    AdopterOrDoner_Page adPage = new AdopterOrDoner_Page();
                    adPage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Error");
                    return;
                }
                
            }

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        //Admin button
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin AdminForm = new Admin();
            AdminForm.Show();
            this.Hide();
        }
    }

}
