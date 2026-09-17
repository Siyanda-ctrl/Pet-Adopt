namespace Pet_Adopt
{
    partial class btnRegisterR
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
            label2 = new Label();
            txtUserNameR = new TextBox();
            label1 = new Label();
            txtNewPassword = new TextBox();
            txtPhysicalAddress = new TextBox();
            label3 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            label6 = new Label();
            cmbGender = new ComboBox();
            btbRegister = new Button();
            label7 = new Label();
            txtConfirmP = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 3;
            label2.Text = "User Name:";
            // 
            // txtUserNameR
            // 
            txtUserNameR.Location = new Point(366, 42);
            txtUserNameR.Margin = new Padding(4);
            txtUserNameR.Name = "txtUserNameR";
            txtUserNameR.Size = new Size(305, 29);
            txtUserNameR.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 87);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 5;
            label1.Text = "New Password:";
            label1.Click += label1_Click;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(366, 84);
            txtNewPassword.Margin = new Padding(4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(305, 29);
            txtNewPassword.TabIndex = 6;
            // 
            // txtPhysicalAddress
            // 
            txtPhysicalAddress.Location = new Point(366, 176);
            txtPhysicalAddress.Margin = new Padding(4);
            txtPhysicalAddress.Name = "txtPhysicalAddress";
            txtPhysicalAddress.Size = new Size(305, 29);
            txtPhysicalAddress.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(210, 179);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 8;
            label3.Text = "Physical Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(210, 277);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 11;
            label5.Text = "Phone Number:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(366, 226);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(305, 29);
            txtEmail.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(366, 274);
            txtPhoneNumber.Margin = new Padding(4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(305, 29);
            txtPhoneNumber.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(210, 325);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 13;
            label6.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(366, 322);
            cmbGender.Margin = new Padding(4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(171, 29);
            cmbGender.TabIndex = 14;
            // 
            // btbRegister
            // 
            btbRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btbRegister.Location = new Point(366, 377);
            btbRegister.Margin = new Padding(4);
            btbRegister.Name = "btbRegister";
            btbRegister.Size = new Size(125, 41);
            btbRegister.TabIndex = 15;
            btbRegister.Text = "Register";
            btbRegister.UseVisualStyleBackColor = true;
            btbRegister.Click += btbRegister_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(210, 131);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(152, 21);
            label7.TabIndex = 16;
            label7.Text = "Confirm Password:";
            // 
            // txtConfirmP
            // 
            txtConfirmP.Location = new Point(366, 128);
            txtConfirmP.Margin = new Padding(4);
            txtConfirmP.Name = "txtConfirmP";
            txtConfirmP.Size = new Size(305, 29);
            txtConfirmP.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(210, 229);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // btnRegisterR
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 446);
            Controls.Add(txtConfirmP);
            Controls.Add(label7);
            Controls.Add(btbRegister);
            Controls.Add(cmbGender);
            Controls.Add(label6);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPhysicalAddress);
            Controls.Add(txtNewPassword);
            Controls.Add(label1);
            Controls.Add(txtUserNameR);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "btnRegisterR";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtUserNameR;
        private Label label1;
        private TextBox txtNewPassword;
        private TextBox txtPhysicalAddress;
        private Label label3;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Label label6;
        private ComboBox cmbGender;
        private Button btbRegister;
        private Label label7;
        private TextBox txtConfirmP;
        private Label label4;
    }
}