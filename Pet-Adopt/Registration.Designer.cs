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
            label4 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            label6 = new Label();
            cmbGender = new ComboBox();
            btbRegister = new Button();
            label7 = new Label();
            txtConfirmP = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(147, 48);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 3;
            label2.Text = "User Name:";
            // 
            // txtUserNameR
            // 
            txtUserNameR.Location = new Point(304, 48);
            txtUserNameR.Name = "txtUserNameR";
            txtUserNameR.Size = new Size(215, 23);
            txtUserNameR.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 103);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 5;
            label1.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(304, 103);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(215, 23);
            txtNewPassword.TabIndex = 6;
            // 
            // txtPhysicalAddress
            // 
            txtPhysicalAddress.Location = new Point(304, 201);
            txtPhysicalAddress.Name = "txtPhysicalAddress";
            txtPhysicalAddress.Size = new Size(215, 23);
            txtPhysicalAddress.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(147, 201);
            label3.Name = "label3";
            label3.Size = new Size(141, 21);
            label3.TabIndex = 8;
            label3.Text = "Physical Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(147, 262);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(147, 320);
            label5.Name = "label5";
            label5.Size = new Size(131, 21);
            label5.TabIndex = 11;
            label5.Text = "Phone Number:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(304, 262);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(215, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(304, 320);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(215, 23);
            txtPhoneNumber.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(147, 375);
            label6.Name = "label6";
            label6.Size = new Size(70, 21);
            label6.TabIndex = 13;
            label6.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(304, 375);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 14;
            // 
            // btbRegister
            // 
            btbRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btbRegister.Location = new Point(321, 435);
            btbRegister.Name = "btbRegister";
            btbRegister.Size = new Size(94, 36);
            btbRegister.TabIndex = 15;
            btbRegister.Text = "Register";
            btbRegister.UseVisualStyleBackColor = true;
            btbRegister.Click += btbRegister_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(147, 156);
            label7.Name = "label7";
            label7.Size = new Size(152, 21);
            label7.TabIndex = 16;
            label7.Text = "Confirm Password:";
            // 
            // txtConfirmP
            // 
            txtConfirmP.Location = new Point(304, 154);
            txtConfirmP.Name = "txtConfirmP";
            txtConfirmP.Size = new Size(215, 23);
            txtConfirmP.TabIndex = 17;
            // 
            // btnRegisterR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
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
        private Label label4;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Label label6;
        private ComboBox cmbGender;
        private Button btbRegister;
        private Label label7;
        private TextBox txtConfirmP;
    }
}