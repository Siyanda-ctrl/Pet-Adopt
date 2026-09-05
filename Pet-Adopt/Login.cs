namespace Pet_Adopt
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegisterR registrationForm = new btnRegisterR();
            registrationForm.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("C:\\Users\\sakid\\source\\repos\\Pet-Adopt\\Pet-Adopt\\registration.txt");

            string username = txtUserName.Text, password = txtPassword.Text, line = "";
            string[] arrayReg = new string[5];
            int count = 0;


            using(reader)
            {
                line = reader.ReadLine();
                
                while(line != null)
                {
                    arrayReg[count] = line;
                   
                    if (arrayReg[0] == username && arrayReg[1] == password)
                    {
                        MessageBox.Show("Login successful", "Success");

                        this.Hide();
                    }
                    line = reader.ReadLine();
                    count++;
                }
                
                
            }

        }


    }
}
