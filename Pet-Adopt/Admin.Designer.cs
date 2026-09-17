namespace Pet_Adopt
{
    partial class Admin
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
            btnGrantAccess = new Button();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 157);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 0;
            label1.Text = "Admin Secret Password:";
            label1.Click += label1_Click;
            // 
            // btnGrantAccess
            // 
            btnGrantAccess.Location = new Point(316, 211);
            btnGrantAccess.Margin = new Padding(4);
            btnGrantAccess.Name = "btnGrantAccess";
            btnGrantAccess.Size = new Size(117, 39);
            btnGrantAccess.TabIndex = 1;
            btnGrantAccess.Text = "Grant Access";
            btnGrantAccess.UseVisualStyleBackColor = true;
            btnGrantAccess.Click += btnGrantAccess_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(393, 154);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(141, 29);
            txtPassword.TabIndex = 2;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 407);
            Controls.Add(txtPassword);
            Controls.Add(btnGrantAccess);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGrantAccess;
        private TextBox txtPassword;
    }
}