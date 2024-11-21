namespace login
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btnregiser = new Button();
            txtUsername = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnregiser
            // 
            btnregiser.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregiser.ForeColor = Color.IndianRed;
            btnregiser.Location = new Point(136, 304);
            btnregiser.Name = "btnregiser";
            btnregiser.Size = new Size(148, 45);
            btnregiser.TabIndex = 0;
            btnregiser.Text = "Register";
            btnregiser.UseVisualStyleBackColor = true;
            btnregiser.Click += btnregiser_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(136, 46);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(238, 27);
            txtUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(25, 50);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 2;
            label1.Text = "UserName";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(136, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(238, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(25, 109);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 27);
            txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(136, 231);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(238, 27);
            txtPhone.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(25, 178);
            label3.Name = "label3";
            label3.Size = new Size(54, 23);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(25, 238);
            label4.Name = "label4";
            label4.Size = new Size(57, 23);
            label4.TabIndex = 8;
            label4.Text = "Phone";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.b4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(663, 361);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(btnregiser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Register";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnregiser;
        private TextBox txtUsername;
        private Label label1;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label label3;
        private Label label4;
    }
}