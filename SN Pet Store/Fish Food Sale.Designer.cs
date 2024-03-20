namespace SN_Pet_Store
{
    partial class Fish_Food_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fish_Food_Sale));
            this.txtFishFoodSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogFoodSalePrice = new System.Windows.Forms.Label();
            this.txtFishFoodSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleQuantity = new System.Windows.Forms.Label();
            this.cboFishFoodSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogFoodSaleItem = new System.Windows.Forms.Label();
            this.txtFishFoodSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtFishFoodSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtFishFoodSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleTotal = new System.Windows.Forms.Label();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.dgvFishFoodSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearBoxes = new System.Windows.Forms.Button();
            this.txtFishFoodSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtFishFoodSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtFishFoodSaleFinalTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishFoodSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFishFoodSalePrice
            // 
            this.txtFishFoodSalePrice.Location = new System.Drawing.Point(286, 268);
            this.txtFishFoodSalePrice.Name = "txtFishFoodSalePrice";
            this.txtFishFoodSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtFishFoodSalePrice.TabIndex = 47;
            this.txtFishFoodSalePrice.TextChanged += new System.EventHandler(this.txtFishFoodSalePrice_TextChanged);
            // 
            // lblDogFoodSalePrice
            // 
            this.lblDogFoodSalePrice.AutoSize = true;
            this.lblDogFoodSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSalePrice.Location = new System.Drawing.Point(32, 257);
            this.lblDogFoodSalePrice.Name = "lblDogFoodSalePrice";
            this.lblDogFoodSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogFoodSalePrice.TabIndex = 46;
            this.lblDogFoodSalePrice.Text = "PRICE:";
            // 
            // txtFishFoodSaleQuantity
            // 
            this.txtFishFoodSaleQuantity.Location = new System.Drawing.Point(286, 355);
            this.txtFishFoodSaleQuantity.Name = "txtFishFoodSaleQuantity";
            this.txtFishFoodSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtFishFoodSaleQuantity.TabIndex = 45;
            this.txtFishFoodSaleQuantity.TextChanged += new System.EventHandler(this.txtFishFoodSaleQuantity_TextChanged);
            // 
            // lblDogFoodSaleQuantity
            // 
            this.lblDogFoodSaleQuantity.AutoSize = true;
            this.lblDogFoodSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleQuantity.Location = new System.Drawing.Point(32, 345);
            this.lblDogFoodSaleQuantity.Name = "lblDogFoodSaleQuantity";
            this.lblDogFoodSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleQuantity.TabIndex = 44;
            this.lblDogFoodSaleQuantity.Text = "QUANTITY:";
            // 
            // cboFishFoodSaleItems
            // 
            this.cboFishFoodSaleItems.FormattingEnabled = true;
            this.cboFishFoodSaleItems.Items.AddRange(new object[] {
            "MARLTONS GOLDFISH FLAKES FOOD",
            "GRANTS TROPICAL FLAKE FOOD",
            "TETRAMIN TROPICAL FLAKES",
            "GOLDFISH FLAKES",
            "GOLDFISH GRANULES",
            "BLOODWORM TREATS POND FOOD",
            "BOTTOM FEEDERS FISH FOOD",
            "PRIMA GRANULES",
            "BETTA BIO GOLD",
            "TROPICAL FISH FLOATING PELLETS",
            "HOLIDAY FOOD",
            "HOLIDAY BLOCK",
            "KOI FOOD PELLETS SMALL",
            "GOLDFISH WEEKEND STICKS",
            "HIKARI VIBRA BITES",
            "GRANTS KOI MEDIUM POND PELLETS"});
            this.cboFishFoodSaleItems.Location = new System.Drawing.Point(286, 174);
            this.cboFishFoodSaleItems.Name = "cboFishFoodSaleItems";
            this.cboFishFoodSaleItems.Size = new System.Drawing.Size(354, 21);
            this.cboFishFoodSaleItems.TabIndex = 43;
            this.cboFishFoodSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboFishFoodSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(32, 81);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 42;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // lblDogFoodSaleItem
            // 
            this.lblDogFoodSaleItem.AutoSize = true;
            this.lblDogFoodSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleItem.Location = new System.Drawing.Point(32, 165);
            this.lblDogFoodSaleItem.Name = "lblDogFoodSaleItem";
            this.lblDogFoodSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleItem.TabIndex = 40;
            this.lblDogFoodSaleItem.Text = "SELECT ITEM:";
            // 
            // txtFishFoodSaleAmountDue
            // 
            this.txtFishFoodSaleAmountDue.Location = new System.Drawing.Point(286, 608);
            this.txtFishFoodSaleAmountDue.Name = "txtFishFoodSaleAmountDue";
            this.txtFishFoodSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtFishFoodSaleAmountDue.TabIndex = 88;
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(32, 597);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 87;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtFishFoodSaleDiscount
            // 
            this.txtFishFoodSaleDiscount.Location = new System.Drawing.Point(286, 526);
            this.txtFishFoodSaleDiscount.Name = "txtFishFoodSaleDiscount";
            this.txtFishFoodSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtFishFoodSaleDiscount.TabIndex = 86;
            this.txtFishFoodSaleDiscount.TextChanged += new System.EventHandler(this.txtFishFoodSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(32, 515);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 85;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtFishFoodSaleTotal
            // 
            this.txtFishFoodSaleTotal.Location = new System.Drawing.Point(286, 439);
            this.txtFishFoodSaleTotal.Name = "txtFishFoodSaleTotal";
            this.txtFishFoodSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtFishFoodSaleTotal.TabIndex = 84;
            this.txtFishFoodSaleTotal.TextChanged += new System.EventHandler(this.txtFishFoodSaleTotal_TextChanged);
            // 
            // lblDogFoodSaleTotal
            // 
            this.lblDogFoodSaleTotal.AutoSize = true;
            this.lblDogFoodSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleTotal.Location = new System.Drawing.Point(32, 429);
            this.lblDogFoodSaleTotal.Name = "lblDogFoodSaleTotal";
            this.lblDogFoodSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogFoodSaleTotal.TabIndex = 83;
            this.lblDogFoodSaleTotal.Text = "TOTAL:";
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(682, 139);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 95;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(682, 92);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 94;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // dgvFishFoodSale
            // 
            this.dgvFishFoodSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFishFoodSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvFishFoodSale.Location = new System.Drawing.Point(849, 92);
            this.dgvFishFoodSale.Name = "dgvFishFoodSale";
            this.dgvFishFoodSale.Size = new System.Drawing.Size(491, 381);
            this.dgvFishFoodSale.TabIndex = 93;
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
            // btnClearBoxes
            // 
            this.btnClearBoxes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClearBoxes.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBoxes.Location = new System.Drawing.Point(682, 553);
            this.btnClearBoxes.Name = "btnClearBoxes";
            this.btnClearBoxes.Size = new System.Drawing.Size(134, 59);
            this.btnClearBoxes.TabIndex = 112;
            this.btnClearBoxes.Text = "CLEAR BOXES";
            this.btnClearBoxes.UseVisualStyleBackColor = false;
            this.btnClearBoxes.Click += new System.EventHandler(this.btnClearBoxes_Click);
            // 
            // txtFishFoodSaleChangeDue
            // 
            this.txtFishFoodSaleChangeDue.Location = new System.Drawing.Point(1075, 621);
            this.txtFishFoodSaleChangeDue.Name = "txtFishFoodSaleChangeDue";
            this.txtFishFoodSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtFishFoodSaleChangeDue.TabIndex = 111;
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(850, 495);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 110;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(852, 610);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 109;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtFishFoodSaleAmountPaid
            // 
            this.txtFishFoodSaleAmountPaid.Location = new System.Drawing.Point(1075, 565);
            this.txtFishFoodSaleAmountPaid.Name = "txtFishFoodSaleAmountPaid";
            this.txtFishFoodSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtFishFoodSaleAmountPaid.TabIndex = 108;
            this.txtFishFoodSaleAmountPaid.TextChanged += new System.EventHandler(this.txtFishFoodSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(852, 554);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 107;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(542, 496);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 106;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(542, 554);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 59);
            this.btnClearFields.TabIndex = 105;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(682, 495);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 104;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtFishFoodSaleFinalTotal
            // 
            this.txtFishFoodSaleFinalTotal.Location = new System.Drawing.Point(1075, 510);
            this.txtFishFoodSaleFinalTotal.Name = "txtFishFoodSaleFinalTotal";
            this.txtFishFoodSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtFishFoodSaleFinalTotal.TabIndex = 103;
            // 
            // Fish_Food_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.btnClearBoxes);
            this.Controls.Add(this.txtFishFoodSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtFishFoodSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtFishFoodSaleFinalTotal);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.dgvFishFoodSale);
            this.Controls.Add(this.txtFishFoodSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtFishFoodSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtFishFoodSaleTotal);
            this.Controls.Add(this.lblDogFoodSaleTotal);
            this.Controls.Add(this.txtFishFoodSalePrice);
            this.Controls.Add(this.lblDogFoodSalePrice);
            this.Controls.Add(this.txtFishFoodSaleQuantity);
            this.Controls.Add(this.lblDogFoodSaleQuantity);
            this.Controls.Add(this.cboFishFoodSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogFoodSaleItem);
            this.Name = "Fish_Food_Sale";
            this.Text = "Fish_Food_Sale";
            this.Load += new System.EventHandler(this.Fish_Food_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishFoodSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFishFoodSalePrice;
        private System.Windows.Forms.Label lblDogFoodSalePrice;
        private System.Windows.Forms.TextBox txtFishFoodSaleQuantity;
        private System.Windows.Forms.Label lblDogFoodSaleQuantity;
        private System.Windows.Forms.ComboBox cboFishFoodSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogFoodSaleItem;
        private System.Windows.Forms.TextBox txtFishFoodSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtFishFoodSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtFishFoodSaleTotal;
        private System.Windows.Forms.Label lblDogFoodSaleTotal;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.DataGridView dgvFishFoodSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnClearBoxes;
        private System.Windows.Forms.TextBox txtFishFoodSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtFishFoodSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtFishFoodSaleFinalTotal;
    }
}