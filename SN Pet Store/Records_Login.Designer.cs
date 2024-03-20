namespace SN_Pet_Store
{
    partial class Records_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtLoginPassword);
            this.panel1.Controls.Add(this.txtLoginUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(376, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 210);
            this.panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Coral;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(364, 162);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(163, 35);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(435, 118);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(163, 20);
            this.txtLoginPassword.TabIndex = 4;
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(435, 38);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(163, 20);
            this.txtLoginUsername.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.SlateBlue;
            this.lblPassword.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(249, 107);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(158, 31);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.SlateBlue;
            this.lblUsername.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(249, 28);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(158, 31);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "USERNAME:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 244);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(1171, 75);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(169, 49);
            this.btnBackToLogin.TabIndex = 40;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(1140, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // Records_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.panel1);
            this.Name = "Records_Login";
            this.Text = "Records_Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}