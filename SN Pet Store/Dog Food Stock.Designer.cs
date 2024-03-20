namespace SN_Pet_Store
{
    partial class Dog_Food_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dog_Food_Stock));
            this.lblDogFoodItem = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogFoodDate = new System.Windows.Forms.Label();
            this.lblDogFoodQuantity = new System.Windows.Forms.Label();
            this.lblDateExpiring = new System.Windows.Forms.Label();
            this.dateTimePickerdfs = new System.Windows.Forms.DateTimePicker();
            this.txtDogFoodQuantity = new System.Windows.Forms.TextBox();
            this.txtDogFoodPrice = new System.Windows.Forms.TextBox();
            this.lblDogFoodPrice = new System.Windows.Forms.Label();
            this.btnDogFoodSave = new System.Windows.Forms.Button();
            this.txtDogFoodWeight = new System.Windows.Forms.TextBox();
            this.lblDogFoodWeight = new System.Windows.Forms.Label();
            this.txtDogFoodStockItems = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDogFoodItem
            // 
            this.lblDogFoodItem.AutoSize = true;
            this.lblDogFoodItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodItem.Location = new System.Drawing.Point(28, 171);
            this.lblDogFoodItem.Name = "lblDogFoodItem";
            this.lblDogFoodItem.Size = new System.Drawing.Size(94, 31);
            this.lblDogFoodItem.TabIndex = 0;
            this.lblDogFoodItem.Text = "ITEM:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(282, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lblDogFoodDate
            // 
            this.lblDogFoodDate.AutoSize = true;
            this.lblDogFoodDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodDate.Location = new System.Drawing.Point(28, 83);
            this.lblDogFoodDate.Name = "lblDogFoodDate";
            this.lblDogFoodDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodDate.TabIndex = 3;
            this.lblDogFoodDate.Text = "DATE ENTERED:";
            // 
            // lblDogFoodQuantity
            // 
            this.lblDogFoodQuantity.AutoSize = true;
            this.lblDogFoodQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodQuantity.Location = new System.Drawing.Point(28, 264);
            this.lblDogFoodQuantity.Name = "lblDogFoodQuantity";
            this.lblDogFoodQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodQuantity.TabIndex = 4;
            this.lblDogFoodQuantity.Text = "QUANTITY:";
            // 
            // lblDateExpiring
            // 
            this.lblDateExpiring.AutoSize = true;
            this.lblDateExpiring.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateExpiring.Location = new System.Drawing.Point(28, 546);
            this.lblDateExpiring.Name = "lblDateExpiring";
            this.lblDateExpiring.Size = new System.Drawing.Size(238, 31);
            this.lblDateExpiring.TabIndex = 5;
            this.lblDateExpiring.Text = "DATE EXPIRING:";
            // 
            // dateTimePickerdfs
            // 
            this.dateTimePickerdfs.Location = new System.Drawing.Point(282, 554);
            this.dateTimePickerdfs.Name = "dateTimePickerdfs";
            this.dateTimePickerdfs.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerdfs.TabIndex = 6;
            this.dateTimePickerdfs.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtDogFoodQuantity
            // 
            this.txtDogFoodQuantity.Location = new System.Drawing.Point(282, 274);
            this.txtDogFoodQuantity.Name = "txtDogFoodQuantity";
            this.txtDogFoodQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtDogFoodQuantity.TabIndex = 7;
            // 
            // txtDogFoodPrice
            // 
            this.txtDogFoodPrice.Location = new System.Drawing.Point(282, 450);
            this.txtDogFoodPrice.Name = "txtDogFoodPrice";
            this.txtDogFoodPrice.Size = new System.Drawing.Size(200, 20);
            this.txtDogFoodPrice.TabIndex = 9;
            this.txtDogFoodPrice.TextChanged += new System.EventHandler(this.txtDogFoodPrice_TextChanged);
            // 
            // lblDogFoodPrice
            // 
            this.lblDogFoodPrice.AutoSize = true;
            this.lblDogFoodPrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodPrice.Location = new System.Drawing.Point(28, 440);
            this.lblDogFoodPrice.Name = "lblDogFoodPrice";
            this.lblDogFoodPrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogFoodPrice.TabIndex = 8;
            this.lblDogFoodPrice.Text = "PRICE:";
            // 
            // btnDogFoodSave
            // 
            this.btnDogFoodSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDogFoodSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDogFoodSave.Location = new System.Drawing.Point(34, 614);
            this.btnDogFoodSave.Name = "btnDogFoodSave";
            this.btnDogFoodSave.Size = new System.Drawing.Size(197, 45);
            this.btnDogFoodSave.TabIndex = 10;
            this.btnDogFoodSave.Text = "SAVE";
            this.btnDogFoodSave.UseVisualStyleBackColor = false;
            this.btnDogFoodSave.Click += new System.EventHandler(this.btnDogFoodSave_Click);
            // 
            // txtDogFoodWeight
            // 
            this.txtDogFoodWeight.Location = new System.Drawing.Point(282, 361);
            this.txtDogFoodWeight.Name = "txtDogFoodWeight";
            this.txtDogFoodWeight.Size = new System.Drawing.Size(200, 20);
            this.txtDogFoodWeight.TabIndex = 12;
            // 
            // lblDogFoodWeight
            // 
            this.lblDogFoodWeight.AutoSize = true;
            this.lblDogFoodWeight.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodWeight.Location = new System.Drawing.Point(28, 351);
            this.lblDogFoodWeight.Name = "lblDogFoodWeight";
            this.lblDogFoodWeight.Size = new System.Drawing.Size(126, 31);
            this.lblDogFoodWeight.TabIndex = 11;
            this.lblDogFoodWeight.Text = "WEIGHT:";
            // 
            // txtDogFoodStockItems
            // 
            this.txtDogFoodStockItems.Location = new System.Drawing.Point(282, 182);
            this.txtDogFoodStockItems.Name = "txtDogFoodStockItems";
            this.txtDogFoodStockItems.Size = new System.Drawing.Size(343, 20);
            this.txtDogFoodStockItems.TabIndex = 13;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(285, 614);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(197, 45);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(1200, 94);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(140, 43);
            this.btnBackToLogin.TabIndex = 15;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // Dog_Food_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDogFoodStockItems);
            this.Controls.Add(this.txtDogFoodWeight);
            this.Controls.Add(this.lblDogFoodWeight);
            this.Controls.Add(this.btnDogFoodSave);
            this.Controls.Add(this.txtDogFoodPrice);
            this.Controls.Add(this.lblDogFoodPrice);
            this.Controls.Add(this.txtDogFoodQuantity);
            this.Controls.Add(this.dateTimePickerdfs);
            this.Controls.Add(this.lblDateExpiring);
            this.Controls.Add(this.lblDogFoodQuantity);
            this.Controls.Add(this.lblDogFoodDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogFoodItem);
            this.Name = "Dog_Food_Stock";
            this.Text = "Dog_Food_Stock";
            this.Load += new System.EventHandler(this.Dog_Food_Stock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDogFoodItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogFoodDate;
        private System.Windows.Forms.Label lblDogFoodQuantity;
        private System.Windows.Forms.Label lblDateExpiring;
        private System.Windows.Forms.DateTimePicker dateTimePickerdfs;
        private System.Windows.Forms.TextBox txtDogFoodQuantity;
        private System.Windows.Forms.TextBox txtDogFoodPrice;
        private System.Windows.Forms.Label lblDogFoodPrice;
        private System.Windows.Forms.Button btnDogFoodSave;
        private System.Windows.Forms.TextBox txtDogFoodWeight;
        private System.Windows.Forms.Label lblDogFoodWeight;
        private System.Windows.Forms.TextBox txtDogFoodStockItems;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackToLogin;
    }
}