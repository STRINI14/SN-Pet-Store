namespace SN_Pet_Store
{
    partial class Fish_Pet_Care_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fish_Pet_Care_Sale));
            this.txtFishPetCareSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSalePrice = new System.Windows.Forms.Label();
            this.txtFishPetCareSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSaleQuantity = new System.Windows.Forms.Label();
            this.cboFishPetCareSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogPetCareSaleItem = new System.Windows.Forms.Label();
            this.txtFishPetCareSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtFishPetCareSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtFishPetCareSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSaleTotal = new System.Windows.Forms.Label();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.dgvFishPetCareSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtFishPetCareSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtFishPetCareSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.txtFishPetCareSaleFinalTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishPetCareSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFishPetCareSalePrice
            // 
            this.txtFishPetCareSalePrice.Location = new System.Drawing.Point(287, 260);
            this.txtFishPetCareSalePrice.Name = "txtFishPetCareSalePrice";
            this.txtFishPetCareSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtFishPetCareSalePrice.TabIndex = 125;
            // 
            // lblDogPetCareSalePrice
            // 
            this.lblDogPetCareSalePrice.AutoSize = true;
            this.lblDogPetCareSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSalePrice.Location = new System.Drawing.Point(33, 250);
            this.lblDogPetCareSalePrice.Name = "lblDogPetCareSalePrice";
            this.lblDogPetCareSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetCareSalePrice.TabIndex = 124;
            this.lblDogPetCareSalePrice.Text = "PRICE:";
            // 
            // txtFishPetCareSaleQuantity
            // 
            this.txtFishPetCareSaleQuantity.Location = new System.Drawing.Point(287, 347);
            this.txtFishPetCareSaleQuantity.Name = "txtFishPetCareSaleQuantity";
            this.txtFishPetCareSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtFishPetCareSaleQuantity.TabIndex = 123;
            this.txtFishPetCareSaleQuantity.TextChanged += new System.EventHandler(this.txtFishPetCareSaleQuantity_TextChanged);
            // 
            // lblDogPetCareSaleQuantity
            // 
            this.lblDogPetCareSaleQuantity.AutoSize = true;
            this.lblDogPetCareSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleQuantity.Location = new System.Drawing.Point(33, 337);
            this.lblDogPetCareSaleQuantity.Name = "lblDogPetCareSaleQuantity";
            this.lblDogPetCareSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogPetCareSaleQuantity.TabIndex = 122;
            this.lblDogPetCareSaleQuantity.Text = "QUANTITY:";
            // 
            // cboFishPetCareSaleItems
            // 
            this.cboFishPetCareSaleItems.FormattingEnabled = true;
            this.cboFishPetCareSaleItems.Items.AddRange(new object[] {
            "TETRA AQUASAFE",
            "TETRA GOLDFISH MEDICINE",
            "DARO AQUARIUM SALT",
            "TETRA ALGUMIN",
            "AQUASAFE WATER NEUTRALIZER",
            "ORGANIC ALGAE KIT",
            "TETRA AQUA EASY BALANCE",
            "TROPICAL GUPPY LIVEBEARERS",
            "TETRA CRYSTALWATER",
            "TETRA MEDICA FUNGISTOP",
            "QUICK START NITRIFYING BACTERIA",
            "SMALL PRIME GRAVEL CLEANER",
            "ORGANIC WATER QUALITY KIT",
            "ACTIVATED BONE CHARCOAL",
            "BULK ACTIVATED BONE CHARCOAL"});
            this.cboFishPetCareSaleItems.Location = new System.Drawing.Point(287, 172);
            this.cboFishPetCareSaleItems.Name = "cboFishPetCareSaleItems";
            this.cboFishPetCareSaleItems.Size = new System.Drawing.Size(263, 21);
            this.cboFishPetCareSaleItems.TabIndex = 121;
            this.cboFishPetCareSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboFishPetCareSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(33, 79);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 120;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(287, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 119;
            // 
            // lblDogPetCareSaleItem
            // 
            this.lblDogPetCareSaleItem.AutoSize = true;
            this.lblDogPetCareSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleItem.Location = new System.Drawing.Point(33, 163);
            this.lblDogPetCareSaleItem.Name = "lblDogPetCareSaleItem";
            this.lblDogPetCareSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogPetCareSaleItem.TabIndex = 118;
            this.lblDogPetCareSaleItem.Text = "SELECT ITEM:";
            // 
            // txtFishPetCareSaleAmountDue
            // 
            this.txtFishPetCareSaleAmountDue.Location = new System.Drawing.Point(287, 593);
            this.txtFishPetCareSaleAmountDue.Name = "txtFishPetCareSaleAmountDue";
            this.txtFishPetCareSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtFishPetCareSaleAmountDue.TabIndex = 131;
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(33, 582);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 130;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtFishPetCareSaleDiscount
            // 
            this.txtFishPetCareSaleDiscount.Location = new System.Drawing.Point(287, 511);
            this.txtFishPetCareSaleDiscount.Name = "txtFishPetCareSaleDiscount";
            this.txtFishPetCareSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtFishPetCareSaleDiscount.TabIndex = 129;
            this.txtFishPetCareSaleDiscount.TextChanged += new System.EventHandler(this.txtFishPetCareSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(33, 500);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 128;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtFishPetCareSaleTotal
            // 
            this.txtFishPetCareSaleTotal.Location = new System.Drawing.Point(287, 436);
            this.txtFishPetCareSaleTotal.Name = "txtFishPetCareSaleTotal";
            this.txtFishPetCareSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtFishPetCareSaleTotal.TabIndex = 127;
            // 
            // lblDogPetCareSaleTotal
            // 
            this.lblDogPetCareSaleTotal.AutoSize = true;
            this.lblDogPetCareSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleTotal.Location = new System.Drawing.Point(33, 426);
            this.lblDogPetCareSaleTotal.Name = "lblDogPetCareSaleTotal";
            this.lblDogPetCareSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetCareSaleTotal.TabIndex = 126;
            this.lblDogPetCareSaleTotal.Text = "TOTAL:";
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(690, 137);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 134;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(690, 90);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 133;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // dgvFishPetCareSale
            // 
            this.dgvFishPetCareSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFishPetCareSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvFishPetCareSale.Location = new System.Drawing.Point(849, 90);
            this.dgvFishPetCareSale.Name = "dgvFishPetCareSale";
            this.dgvFishPetCareSale.Size = new System.Drawing.Size(491, 365);
            this.dgvFishPetCareSale.TabIndex = 132;
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
            this.button1.Location = new System.Drawing.Point(691, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 67);
            this.button1.TabIndex = 148;
            this.button1.Text = "CLEAR BOXES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(535, 479);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 147;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(535, 534);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 67);
            this.btnClearFields.TabIndex = 146;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(691, 479);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 145;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtFishPetCareSaleChangeDue
            // 
            this.txtFishPetCareSaleChangeDue.Location = new System.Drawing.Point(1066, 604);
            this.txtFishPetCareSaleChangeDue.Name = "txtFishPetCareSaleChangeDue";
            this.txtFishPetCareSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtFishPetCareSaleChangeDue.TabIndex = 144;
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(841, 478);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 143;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(843, 593);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 142;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtFishPetCareSaleAmountPaid
            // 
            this.txtFishPetCareSaleAmountPaid.Location = new System.Drawing.Point(1066, 548);
            this.txtFishPetCareSaleAmountPaid.Name = "txtFishPetCareSaleAmountPaid";
            this.txtFishPetCareSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtFishPetCareSaleAmountPaid.TabIndex = 141;
            this.txtFishPetCareSaleAmountPaid.TextChanged += new System.EventHandler(this.txtFishPetCareSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(843, 537);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 140;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // txtFishPetCareSaleFinalTotal
            // 
            this.txtFishPetCareSaleFinalTotal.Location = new System.Drawing.Point(1066, 493);
            this.txtFishPetCareSaleFinalTotal.Name = "txtFishPetCareSaleFinalTotal";
            this.txtFishPetCareSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtFishPetCareSaleFinalTotal.TabIndex = 139;
            // 
            // Fish_Pet_Care_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtFishPetCareSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtFishPetCareSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.txtFishPetCareSaleFinalTotal);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.dgvFishPetCareSale);
            this.Controls.Add(this.txtFishPetCareSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtFishPetCareSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtFishPetCareSaleTotal);
            this.Controls.Add(this.lblDogPetCareSaleTotal);
            this.Controls.Add(this.txtFishPetCareSalePrice);
            this.Controls.Add(this.lblDogPetCareSalePrice);
            this.Controls.Add(this.txtFishPetCareSaleQuantity);
            this.Controls.Add(this.lblDogPetCareSaleQuantity);
            this.Controls.Add(this.cboFishPetCareSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogPetCareSaleItem);
            this.Name = "Fish_Pet_Care_Sale";
            this.Text = "Fish_Pet_Care_Sale";
            this.Load += new System.EventHandler(this.Fish_Pet_Care_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishPetCareSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFishPetCareSalePrice;
        private System.Windows.Forms.Label lblDogPetCareSalePrice;
        private System.Windows.Forms.TextBox txtFishPetCareSaleQuantity;
        private System.Windows.Forms.Label lblDogPetCareSaleQuantity;
        private System.Windows.Forms.ComboBox cboFishPetCareSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogPetCareSaleItem;
        private System.Windows.Forms.TextBox txtFishPetCareSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtFishPetCareSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtFishPetCareSaleTotal;
        private System.Windows.Forms.Label lblDogPetCareSaleTotal;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.DataGridView dgvFishPetCareSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtFishPetCareSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtFishPetCareSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.TextBox txtFishPetCareSaleFinalTotal;

    }
}