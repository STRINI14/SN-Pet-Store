namespace SN_Pet_Store
{
    partial class Cat_Pet_Care_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cat_Pet_Care_Sale));
            this.txtCatPetCareSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtCatPetCareSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtCatPetCareSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSaleTotal = new System.Windows.Forms.Label();
            this.txtCatPetCareSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSalePrice = new System.Windows.Forms.Label();
            this.txtCatPetCareSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSaleQuantity = new System.Windows.Forms.Label();
            this.cboCatPetCareSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogPetCareSaleItem = new System.Windows.Forms.Label();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.dgvCatPetCareSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtCatPetCareSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtCatPetCareSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.txtCatPetCareSaleFinalTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatPetCareSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCatPetCareSaleAmountDue
            // 
            this.txtCatPetCareSaleAmountDue.Location = new System.Drawing.Point(283, 587);
            this.txtCatPetCareSaleAmountDue.Name = "txtCatPetCareSaleAmountDue";
            this.txtCatPetCareSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtCatPetCareSaleAmountDue.TabIndex = 115;
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(29, 576);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 114;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtCatPetCareSaleDiscount
            // 
            this.txtCatPetCareSaleDiscount.Location = new System.Drawing.Point(283, 505);
            this.txtCatPetCareSaleDiscount.Name = "txtCatPetCareSaleDiscount";
            this.txtCatPetCareSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtCatPetCareSaleDiscount.TabIndex = 113;
            this.txtCatPetCareSaleDiscount.TextChanged += new System.EventHandler(this.txtCatPetCareSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(29, 494);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 112;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtCatPetCareSaleTotal
            // 
            this.txtCatPetCareSaleTotal.Location = new System.Drawing.Point(283, 430);
            this.txtCatPetCareSaleTotal.Name = "txtCatPetCareSaleTotal";
            this.txtCatPetCareSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtCatPetCareSaleTotal.TabIndex = 111;
            this.txtCatPetCareSaleTotal.TextChanged += new System.EventHandler(this.txtCatPetCareSaleTotal_TextChanged);
            // 
            // lblDogPetCareSaleTotal
            // 
            this.lblDogPetCareSaleTotal.AutoSize = true;
            this.lblDogPetCareSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleTotal.Location = new System.Drawing.Point(29, 420);
            this.lblDogPetCareSaleTotal.Name = "lblDogPetCareSaleTotal";
            this.lblDogPetCareSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetCareSaleTotal.TabIndex = 110;
            this.lblDogPetCareSaleTotal.Text = "TOTAL:";
            // 
            // txtCatPetCareSalePrice
            // 
            this.txtCatPetCareSalePrice.Location = new System.Drawing.Point(283, 256);
            this.txtCatPetCareSalePrice.Name = "txtCatPetCareSalePrice";
            this.txtCatPetCareSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtCatPetCareSalePrice.TabIndex = 109;
            this.txtCatPetCareSalePrice.TextChanged += new System.EventHandler(this.txtCatPetCareSalePrice_TextChanged);
            // 
            // lblDogPetCareSalePrice
            // 
            this.lblDogPetCareSalePrice.AutoSize = true;
            this.lblDogPetCareSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSalePrice.Location = new System.Drawing.Point(29, 246);
            this.lblDogPetCareSalePrice.Name = "lblDogPetCareSalePrice";
            this.lblDogPetCareSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetCareSalePrice.TabIndex = 108;
            this.lblDogPetCareSalePrice.Text = "PRICE:";
            // 
            // txtCatPetCareSaleQuantity
            // 
            this.txtCatPetCareSaleQuantity.Location = new System.Drawing.Point(283, 343);
            this.txtCatPetCareSaleQuantity.Name = "txtCatPetCareSaleQuantity";
            this.txtCatPetCareSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtCatPetCareSaleQuantity.TabIndex = 107;
            this.txtCatPetCareSaleQuantity.TextChanged += new System.EventHandler(this.txtCatPetCareSaleQuantity_TextChanged);
            // 
            // lblDogPetCareSaleQuantity
            // 
            this.lblDogPetCareSaleQuantity.AutoSize = true;
            this.lblDogPetCareSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleQuantity.Location = new System.Drawing.Point(29, 333);
            this.lblDogPetCareSaleQuantity.Name = "lblDogPetCareSaleQuantity";
            this.lblDogPetCareSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogPetCareSaleQuantity.TabIndex = 106;
            this.lblDogPetCareSaleQuantity.Text = "QUANTITY:";
            // 
            // cboCatPetCareSaleItems
            // 
            this.cboCatPetCareSaleItems.FormattingEnabled = true;
            this.cboCatPetCareSaleItems.Items.AddRange(new object[] {
            "MARLTONS GET OFF SPRAY",
            "FRONTLINE CAT BRUSH",
            "FLEA DOCTOR FOR CATS",
            "INSECT REPELLENT SPRAY",
            "MARLTONS DEWORMER",
            "KITTEN NURSING KIT",
            "STRESSFREE VALERIAN POWDER",
            "DENT TOOTHPASTE",
            "CAT PET E-MED",
            "ELECTRIC FLEA COMB",
            "CAT GROOMING KIT",
            "REGAL HEALTH TONIC"});
            this.cboCatPetCareSaleItems.Location = new System.Drawing.Point(283, 168);
            this.cboCatPetCareSaleItems.Name = "cboCatPetCareSaleItems";
            this.cboCatPetCareSaleItems.Size = new System.Drawing.Size(263, 21);
            this.cboCatPetCareSaleItems.TabIndex = 105;
            this.cboCatPetCareSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboCatPetCareSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(29, 75);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 104;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(283, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 103;
            // 
            // lblDogPetCareSaleItem
            // 
            this.lblDogPetCareSaleItem.AutoSize = true;
            this.lblDogPetCareSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleItem.Location = new System.Drawing.Point(29, 159);
            this.lblDogPetCareSaleItem.Name = "lblDogPetCareSaleItem";
            this.lblDogPetCareSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogPetCareSaleItem.TabIndex = 102;
            this.lblDogPetCareSaleItem.Text = "SELECT ITEM:";
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(701, 132);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 118;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(701, 85);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 117;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // dgvCatPetCareSale
            // 
            this.dgvCatPetCareSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatPetCareSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvCatPetCareSale.Location = new System.Drawing.Point(860, 85);
            this.dgvCatPetCareSale.Name = "dgvCatPetCareSale";
            this.dgvCatPetCareSale.Size = new System.Drawing.Size(491, 365);
            this.dgvCatPetCareSale.TabIndex = 116;
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
            this.button1.Location = new System.Drawing.Point(710, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 67);
            this.button1.TabIndex = 128;
            this.button1.Text = "CLEAR BOXES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(554, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 127;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(554, 521);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 67);
            this.btnClearFields.TabIndex = 126;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(710, 466);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 125;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtCatPetCareSaleChangeDue
            // 
            this.txtCatPetCareSaleChangeDue.Location = new System.Drawing.Point(1085, 591);
            this.txtCatPetCareSaleChangeDue.Name = "txtCatPetCareSaleChangeDue";
            this.txtCatPetCareSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtCatPetCareSaleChangeDue.TabIndex = 124;
            this.txtCatPetCareSaleChangeDue.TextChanged += new System.EventHandler(this.txtCatPetCareSaleChangeDue_TextChanged);
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(860, 465);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 123;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(862, 580);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 122;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtCatPetCareSaleAmountPaid
            // 
            this.txtCatPetCareSaleAmountPaid.Location = new System.Drawing.Point(1085, 535);
            this.txtCatPetCareSaleAmountPaid.Name = "txtCatPetCareSaleAmountPaid";
            this.txtCatPetCareSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtCatPetCareSaleAmountPaid.TabIndex = 121;
            this.txtCatPetCareSaleAmountPaid.TextChanged += new System.EventHandler(this.txtCatPetCareSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(862, 524);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 120;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // txtCatPetCareSaleFinalTotal
            // 
            this.txtCatPetCareSaleFinalTotal.Location = new System.Drawing.Point(1085, 480);
            this.txtCatPetCareSaleFinalTotal.Name = "txtCatPetCareSaleFinalTotal";
            this.txtCatPetCareSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtCatPetCareSaleFinalTotal.TabIndex = 119;
            // 
            // Cat_Pet_Care_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtCatPetCareSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtCatPetCareSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.txtCatPetCareSaleFinalTotal);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.dgvCatPetCareSale);
            this.Controls.Add(this.txtCatPetCareSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtCatPetCareSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtCatPetCareSaleTotal);
            this.Controls.Add(this.lblDogPetCareSaleTotal);
            this.Controls.Add(this.txtCatPetCareSalePrice);
            this.Controls.Add(this.lblDogPetCareSalePrice);
            this.Controls.Add(this.txtCatPetCareSaleQuantity);
            this.Controls.Add(this.lblDogPetCareSaleQuantity);
            this.Controls.Add(this.cboCatPetCareSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogPetCareSaleItem);
            this.Name = "Cat_Pet_Care_Sale";
            this.Text = "Cat_Pet_Care_Sale";
            this.Load += new System.EventHandler(this.Cat_Pet_Care_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatPetCareSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCatPetCareSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtCatPetCareSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtCatPetCareSaleTotal;
        private System.Windows.Forms.Label lblDogPetCareSaleTotal;
        private System.Windows.Forms.TextBox txtCatPetCareSalePrice;
        private System.Windows.Forms.Label lblDogPetCareSalePrice;
        private System.Windows.Forms.TextBox txtCatPetCareSaleQuantity;
        private System.Windows.Forms.Label lblDogPetCareSaleQuantity;
        private System.Windows.Forms.ComboBox cboCatPetCareSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogPetCareSaleItem;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.DataGridView dgvCatPetCareSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtCatPetCareSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtCatPetCareSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.TextBox txtCatPetCareSaleFinalTotal;
    }
}