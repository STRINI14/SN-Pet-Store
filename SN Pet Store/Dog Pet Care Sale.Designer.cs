namespace SN_Pet_Store
{
    partial class Dog_Pet_Care_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dog_Pet_Care_Sale));
            this.txtDogPetCareSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSalePrice = new System.Windows.Forms.Label();
            this.txtDogPetCareSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSaleQuantity = new System.Windows.Forms.Label();
            this.cboDogPetCareSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogPetCareSaleItem = new System.Windows.Forms.Label();
            this.txtDogPetCareSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSaleTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtDogPetCareSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtDogPetCareSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.txtDogPetCareSaleFinalTotal = new System.Windows.Forms.TextBox();
            this.txtDogPetCareSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtDogPetCareSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.dgvDogPetCareSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogPetCareSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDogPetCareSalePrice
            // 
            this.txtDogPetCareSalePrice.Location = new System.Drawing.Point(287, 260);
            this.txtDogPetCareSalePrice.Name = "txtDogPetCareSalePrice";
            this.txtDogPetCareSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtDogPetCareSalePrice.TabIndex = 39;
            this.txtDogPetCareSalePrice.TextChanged += new System.EventHandler(this.txtDogPetCareSalePrice_TextChanged);
            // 
            // lblDogPetCareSalePrice
            // 
            this.lblDogPetCareSalePrice.AutoSize = true;
            this.lblDogPetCareSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSalePrice.Location = new System.Drawing.Point(33, 250);
            this.lblDogPetCareSalePrice.Name = "lblDogPetCareSalePrice";
            this.lblDogPetCareSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetCareSalePrice.TabIndex = 38;
            this.lblDogPetCareSalePrice.Text = "PRICE:";
            // 
            // txtDogPetCareSaleQuantity
            // 
            this.txtDogPetCareSaleQuantity.Location = new System.Drawing.Point(287, 347);
            this.txtDogPetCareSaleQuantity.Name = "txtDogPetCareSaleQuantity";
            this.txtDogPetCareSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtDogPetCareSaleQuantity.TabIndex = 37;
            this.txtDogPetCareSaleQuantity.TextChanged += new System.EventHandler(this.txtDogPetCareSaleQuantity_TextChanged);
            // 
            // lblDogPetCareSaleQuantity
            // 
            this.lblDogPetCareSaleQuantity.AutoSize = true;
            this.lblDogPetCareSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleQuantity.Location = new System.Drawing.Point(33, 337);
            this.lblDogPetCareSaleQuantity.Name = "lblDogPetCareSaleQuantity";
            this.lblDogPetCareSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogPetCareSaleQuantity.TabIndex = 36;
            this.lblDogPetCareSaleQuantity.Text = "QUANTITY:";
            // 
            // cboDogPetCareSaleItems
            // 
            this.cboDogPetCareSaleItems.FormattingEnabled = true;
            this.cboDogPetCareSaleItems.Items.AddRange(new object[] {
            "PUPPY SHAMPOO",
            "TICK POWDER",
            "MARLTONS GET OFF SPRAY",
            "DOG FIRST AID KIT",
            "3 IN 1 ODOUR NEUTRALISER",
            "PET NAIL TRIMMER",
            "MEDICATED SHAMPOO",
            "INSECT REPELLENT TEA TREE OIL",
            "SINGLE PET RAMP",
            "PET E MED INJECTION",
            "BOB MARTIN SPOT ON LARGE",
            "SKIN CARE REMEDY",
            "CANI-VIT TABLETS",
            "PET HAIR REMOVER",
            "PEE POST",
            "FLEA AND TICK SHAMPOO",
            "DOG SKIN SUPPLEMENT",
            "WOUND GEL",
            "DESHEDDING BRUSH",
            "POTTY TRAINER",
            "PARASITICIDE PACK"});
            this.cboDogPetCareSaleItems.Location = new System.Drawing.Point(287, 172);
            this.cboDogPetCareSaleItems.Name = "cboDogPetCareSaleItems";
            this.cboDogPetCareSaleItems.Size = new System.Drawing.Size(263, 21);
            this.cboDogPetCareSaleItems.TabIndex = 35;
            this.cboDogPetCareSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboDogPetCareSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(33, 79);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 34;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(287, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // lblDogPetCareSaleItem
            // 
            this.lblDogPetCareSaleItem.AutoSize = true;
            this.lblDogPetCareSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleItem.Location = new System.Drawing.Point(33, 163);
            this.lblDogPetCareSaleItem.Name = "lblDogPetCareSaleItem";
            this.lblDogPetCareSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogPetCareSaleItem.TabIndex = 32;
            this.lblDogPetCareSaleItem.Text = "SELECT ITEM:";
            // 
            // txtDogPetCareSaleTotal
            // 
            this.txtDogPetCareSaleTotal.Location = new System.Drawing.Point(287, 434);
            this.txtDogPetCareSaleTotal.Name = "txtDogPetCareSaleTotal";
            this.txtDogPetCareSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtDogPetCareSaleTotal.TabIndex = 41;
            this.txtDogPetCareSaleTotal.TextChanged += new System.EventHandler(this.txtDogPetCareSaleTotal_TextChanged);
            // 
            // lblDogPetCareSaleTotal
            // 
            this.lblDogPetCareSaleTotal.AutoSize = true;
            this.lblDogPetCareSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleTotal.Location = new System.Drawing.Point(33, 424);
            this.lblDogPetCareSaleTotal.Name = "lblDogPetCareSaleTotal";
            this.lblDogPetCareSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetCareSaleTotal.TabIndex = 40;
            this.lblDogPetCareSaleTotal.Text = "TOTAL:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(711, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 67);
            this.button1.TabIndex = 97;
            this.button1.Text = "CLEAR BOXES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(555, 463);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 96;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(555, 518);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 67);
            this.btnClearFields.TabIndex = 95;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(711, 463);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 94;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtDogPetCareSaleChangeDue
            // 
            this.txtDogPetCareSaleChangeDue.Location = new System.Drawing.Point(1086, 588);
            this.txtDogPetCareSaleChangeDue.Name = "txtDogPetCareSaleChangeDue";
            this.txtDogPetCareSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtDogPetCareSaleChangeDue.TabIndex = 93;
            this.txtDogPetCareSaleChangeDue.TextChanged += new System.EventHandler(this.txtDogPetCareSaleChangeDue_TextChanged);
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(861, 462);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 92;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(863, 577);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 91;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtDogPetCareSaleAmountPaid
            // 
            this.txtDogPetCareSaleAmountPaid.Location = new System.Drawing.Point(1086, 532);
            this.txtDogPetCareSaleAmountPaid.Name = "txtDogPetCareSaleAmountPaid";
            this.txtDogPetCareSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtDogPetCareSaleAmountPaid.TabIndex = 90;
            this.txtDogPetCareSaleAmountPaid.TextChanged += new System.EventHandler(this.txtDogAccSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(863, 521);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 89;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // txtDogPetCareSaleFinalTotal
            // 
            this.txtDogPetCareSaleFinalTotal.Location = new System.Drawing.Point(1086, 477);
            this.txtDogPetCareSaleFinalTotal.Name = "txtDogPetCareSaleFinalTotal";
            this.txtDogPetCareSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtDogPetCareSaleFinalTotal.TabIndex = 88;
            this.txtDogPetCareSaleFinalTotal.TextChanged += new System.EventHandler(this.txtDogPetCareSaleFinalTotal_TextChanged);
            // 
            // txtDogPetCareSaleAmountDue
            // 
            this.txtDogPetCareSaleAmountDue.Location = new System.Drawing.Point(287, 591);
            this.txtDogPetCareSaleAmountDue.Name = "txtDogPetCareSaleAmountDue";
            this.txtDogPetCareSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtDogPetCareSaleAmountDue.TabIndex = 101;
            this.txtDogPetCareSaleAmountDue.TextChanged += new System.EventHandler(this.txtDogPetCareSaleAmountDue_TextChanged);
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(33, 580);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 100;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtDogPetCareSaleDiscount
            // 
            this.txtDogPetCareSaleDiscount.Location = new System.Drawing.Point(287, 509);
            this.txtDogPetCareSaleDiscount.Name = "txtDogPetCareSaleDiscount";
            this.txtDogPetCareSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtDogPetCareSaleDiscount.TabIndex = 99;
            this.txtDogPetCareSaleDiscount.TextChanged += new System.EventHandler(this.txtDogPetSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(33, 498);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 98;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // dgvDogPetCareSale
            // 
            this.dgvDogPetCareSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogPetCareSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvDogPetCareSale.Location = new System.Drawing.Point(861, 79);
            this.dgvDogPetCareSale.Name = "dgvDogPetCareSale";
            this.dgvDogPetCareSale.Size = new System.Drawing.Size(491, 365);
            this.dgvDogPetCareSale.TabIndex = 102;
            this.dgvDogPetCareSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDogPetCareSale_CellContentClick);
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
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(702, 126);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 104;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(702, 79);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 103;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // Dog_Pet_Care_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.dgvDogPetCareSale);
            this.Controls.Add(this.txtDogPetCareSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtDogPetCareSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtDogPetCareSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtDogPetCareSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.txtDogPetCareSaleFinalTotal);
            this.Controls.Add(this.txtDogPetCareSaleTotal);
            this.Controls.Add(this.lblDogPetCareSaleTotal);
            this.Controls.Add(this.txtDogPetCareSalePrice);
            this.Controls.Add(this.lblDogPetCareSalePrice);
            this.Controls.Add(this.txtDogPetCareSaleQuantity);
            this.Controls.Add(this.lblDogPetCareSaleQuantity);
            this.Controls.Add(this.cboDogPetCareSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogPetCareSaleItem);
            this.Name = "Dog_Pet_Care_Sale";
            this.Text = "Dog_Pet_Care_Sale";
            this.Load += new System.EventHandler(this.Dog_Pet_Care_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogPetCareSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDogPetCareSalePrice;
        private System.Windows.Forms.Label lblDogPetCareSalePrice;
        private System.Windows.Forms.TextBox txtDogPetCareSaleQuantity;
        private System.Windows.Forms.Label lblDogPetCareSaleQuantity;
        private System.Windows.Forms.ComboBox cboDogPetCareSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogPetCareSaleItem;
        private System.Windows.Forms.TextBox txtDogPetCareSaleTotal;
        private System.Windows.Forms.Label lblDogPetCareSaleTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtDogPetCareSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtDogPetCareSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.TextBox txtDogPetCareSaleFinalTotal;
        private System.Windows.Forms.TextBox txtDogPetCareSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtDogPetCareSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.DataGridView dgvDogPetCareSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnBackToLogin;
    }
}