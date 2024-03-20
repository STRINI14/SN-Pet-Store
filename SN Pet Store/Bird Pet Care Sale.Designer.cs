namespace SN_Pet_Store
{
    partial class Bird_Pet_Care_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bird_Pet_Care_Sale));
            this.txtBirdPetCareSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSalePrice = new System.Windows.Forms.Label();
            this.txtBirdPetCareSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSaleQuantity = new System.Windows.Forms.Label();
            this.cboBirdPetCareSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogPetCareSaleItem = new System.Windows.Forms.Label();
            this.txtBirdPetCareSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtBirdPetCareSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtBirdPetCareSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSaleTotal = new System.Windows.Forms.Label();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.dgvBirdPetCareSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtBirdPetCareSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtBirdPetCareSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.txtBirdPetCareSaleFinalTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirdPetCareSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBirdPetCareSalePrice
            // 
            this.txtBirdPetCareSalePrice.Location = new System.Drawing.Point(298, 263);
            this.txtBirdPetCareSalePrice.Name = "txtBirdPetCareSalePrice";
            this.txtBirdPetCareSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtBirdPetCareSalePrice.TabIndex = 117;
            // 
            // lblDogPetCareSalePrice
            // 
            this.lblDogPetCareSalePrice.AutoSize = true;
            this.lblDogPetCareSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSalePrice.Location = new System.Drawing.Point(44, 253);
            this.lblDogPetCareSalePrice.Name = "lblDogPetCareSalePrice";
            this.lblDogPetCareSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetCareSalePrice.TabIndex = 116;
            this.lblDogPetCareSalePrice.Text = "PRICE:";
            // 
            // txtBirdPetCareSaleQuantity
            // 
            this.txtBirdPetCareSaleQuantity.Location = new System.Drawing.Point(298, 350);
            this.txtBirdPetCareSaleQuantity.Name = "txtBirdPetCareSaleQuantity";
            this.txtBirdPetCareSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtBirdPetCareSaleQuantity.TabIndex = 115;
            this.txtBirdPetCareSaleQuantity.TextChanged += new System.EventHandler(this.txtBirdPetCareSaleQuantity_TextChanged);
            // 
            // lblDogPetCareSaleQuantity
            // 
            this.lblDogPetCareSaleQuantity.AutoSize = true;
            this.lblDogPetCareSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleQuantity.Location = new System.Drawing.Point(44, 340);
            this.lblDogPetCareSaleQuantity.Name = "lblDogPetCareSaleQuantity";
            this.lblDogPetCareSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogPetCareSaleQuantity.TabIndex = 114;
            this.lblDogPetCareSaleQuantity.Text = "QUANTITY:";
            // 
            // cboBirdPetCareSaleItems
            // 
            this.cboBirdPetCareSaleItems.FormattingEnabled = true;
            this.cboBirdPetCareSaleItems.Items.AddRange(new object[] {
            "MEDIMUNE TABLETS",
            "MEDIVITAL PLUS",
            "BIRD SPIKE",
            "BATH SOLAR FOUNTAIN KIT",
            "MEDPET PARROT TONIC",
            "MEDPET PREMOLT TABLETS",
            "MILLET SPRAY",
            "MEDPET VITATON",
            "BEAPHAR PARROT CARE",
            "VITAKRAFT EARS OF MILLET",
            "AFRICAN GREY SHAMPOO",
            "COCKATOO SHAMPOO",
            "COCKATIEL BATH"});
            this.cboBirdPetCareSaleItems.Location = new System.Drawing.Point(298, 175);
            this.cboBirdPetCareSaleItems.Name = "cboBirdPetCareSaleItems";
            this.cboBirdPetCareSaleItems.Size = new System.Drawing.Size(263, 21);
            this.cboBirdPetCareSaleItems.TabIndex = 113;
            this.cboBirdPetCareSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboBirdPetCareSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(44, 82);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 112;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 111;
            // 
            // lblDogPetCareSaleItem
            // 
            this.lblDogPetCareSaleItem.AutoSize = true;
            this.lblDogPetCareSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleItem.Location = new System.Drawing.Point(44, 166);
            this.lblDogPetCareSaleItem.Name = "lblDogPetCareSaleItem";
            this.lblDogPetCareSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogPetCareSaleItem.TabIndex = 110;
            this.lblDogPetCareSaleItem.Text = "SELECT ITEM:";
            // 
            // txtBirdPetCareSaleAmountDue
            // 
            this.txtBirdPetCareSaleAmountDue.Location = new System.Drawing.Point(298, 594);
            this.txtBirdPetCareSaleAmountDue.Name = "txtBirdPetCareSaleAmountDue";
            this.txtBirdPetCareSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtBirdPetCareSaleAmountDue.TabIndex = 123;
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(44, 583);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 122;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtBirdPetCareSaleDiscount
            // 
            this.txtBirdPetCareSaleDiscount.Location = new System.Drawing.Point(298, 512);
            this.txtBirdPetCareSaleDiscount.Name = "txtBirdPetCareSaleDiscount";
            this.txtBirdPetCareSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtBirdPetCareSaleDiscount.TabIndex = 121;
            this.txtBirdPetCareSaleDiscount.TextChanged += new System.EventHandler(this.txtBirdPetCareSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(44, 501);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 120;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtBirdPetCareSaleTotal
            // 
            this.txtBirdPetCareSaleTotal.Location = new System.Drawing.Point(298, 437);
            this.txtBirdPetCareSaleTotal.Name = "txtBirdPetCareSaleTotal";
            this.txtBirdPetCareSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtBirdPetCareSaleTotal.TabIndex = 119;
            // 
            // lblDogPetCareSaleTotal
            // 
            this.lblDogPetCareSaleTotal.AutoSize = true;
            this.lblDogPetCareSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleTotal.Location = new System.Drawing.Point(44, 427);
            this.lblDogPetCareSaleTotal.Name = "lblDogPetCareSaleTotal";
            this.lblDogPetCareSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetCareSaleTotal.TabIndex = 118;
            this.lblDogPetCareSaleTotal.Text = "TOTAL:";
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(690, 140);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 126;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(690, 93);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 125;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // dgvBirdPetCareSale
            // 
            this.dgvBirdPetCareSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBirdPetCareSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvBirdPetCareSale.Location = new System.Drawing.Point(849, 93);
            this.dgvBirdPetCareSale.Name = "dgvBirdPetCareSale";
            this.dgvBirdPetCareSale.Size = new System.Drawing.Size(491, 365);
            this.dgvBirdPetCareSale.TabIndex = 124;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(699, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 67);
            this.button1.TabIndex = 138;
            this.button1.Text = "CLEAR BOXES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(543, 473);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 137;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(543, 528);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 67);
            this.btnClearFields.TabIndex = 136;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(699, 473);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 135;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtBirdPetCareSaleChangeDue
            // 
            this.txtBirdPetCareSaleChangeDue.Location = new System.Drawing.Point(1074, 598);
            this.txtBirdPetCareSaleChangeDue.Name = "txtBirdPetCareSaleChangeDue";
            this.txtBirdPetCareSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtBirdPetCareSaleChangeDue.TabIndex = 134;
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(849, 472);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 133;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(851, 587);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 132;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtBirdPetCareSaleAmountPaid
            // 
            this.txtBirdPetCareSaleAmountPaid.Location = new System.Drawing.Point(1074, 542);
            this.txtBirdPetCareSaleAmountPaid.Name = "txtBirdPetCareSaleAmountPaid";
            this.txtBirdPetCareSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtBirdPetCareSaleAmountPaid.TabIndex = 131;
            this.txtBirdPetCareSaleAmountPaid.TextChanged += new System.EventHandler(this.txtBirdPetCareSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(851, 531);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 130;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // txtBirdPetCareSaleFinalTotal
            // 
            this.txtBirdPetCareSaleFinalTotal.Location = new System.Drawing.Point(1074, 487);
            this.txtBirdPetCareSaleFinalTotal.Name = "txtBirdPetCareSaleFinalTotal";
            this.txtBirdPetCareSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtBirdPetCareSaleFinalTotal.TabIndex = 129;
            // 
            // Bird_Pet_Care_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtBirdPetCareSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtBirdPetCareSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.txtBirdPetCareSaleFinalTotal);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.dgvBirdPetCareSale);
            this.Controls.Add(this.txtBirdPetCareSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtBirdPetCareSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtBirdPetCareSaleTotal);
            this.Controls.Add(this.lblDogPetCareSaleTotal);
            this.Controls.Add(this.txtBirdPetCareSalePrice);
            this.Controls.Add(this.lblDogPetCareSalePrice);
            this.Controls.Add(this.txtBirdPetCareSaleQuantity);
            this.Controls.Add(this.lblDogPetCareSaleQuantity);
            this.Controls.Add(this.cboBirdPetCareSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogPetCareSaleItem);
            this.Name = "Bird_Pet_Care_Sale";
            this.Text = "Bird_Pet_Care_Sale";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirdPetCareSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirdPetCareSalePrice;
        private System.Windows.Forms.Label lblDogPetCareSalePrice;
        private System.Windows.Forms.TextBox txtBirdPetCareSaleQuantity;
        private System.Windows.Forms.Label lblDogPetCareSaleQuantity;
        private System.Windows.Forms.ComboBox cboBirdPetCareSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogPetCareSaleItem;
        private System.Windows.Forms.TextBox txtBirdPetCareSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtBirdPetCareSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtBirdPetCareSaleTotal;
        private System.Windows.Forms.Label lblDogPetCareSaleTotal;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.DataGridView dgvBirdPetCareSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtBirdPetCareSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtBirdPetCareSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.TextBox txtBirdPetCareSaleFinalTotal;
    }
}