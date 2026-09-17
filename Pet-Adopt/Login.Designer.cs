namespace Pet_Adopt

{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            btnLogin = new Button();
            chkShowPassword = new CheckBox();
            label3 = new Label();
            btnRegister = new Button();
            btnAdmin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 132);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(229, 156);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(265, 29);
            txtPassword.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 55);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 2;
            label2.Text = "User Name:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(229, 79);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(265, 29);
            txtUserName.TabIndex = 0;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(320, 273);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(229, 220);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(147, 25);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 327);
            label3.Name = "label3";
            label3.Size = new Size(32, 21);
            label3.TabIndex = 6;
            label3.Text = "OR";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(229, 382);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(86, 32);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(408, 382);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(86, 32);
            btnAdmin.TabIndex = 8;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 532);
            Controls.Add(btnAdmin);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtUserName;
        private Button btnLogin;
        private CheckBox chkShowPassword;
        private Label label3;
        private Button btnRegister;
        private Button btnAdmin;
    }
}