namespace SN_Pet_Store
{
    partial class Bird_Food_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bird_Food_Sale));
            this.txtBirdFoodSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogFoodSalePrice = new System.Windows.Forms.Label();
            this.txtBirdFoodSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleQuantity = new System.Windows.Forms.Label();
            this.cboBirdFoodSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogFoodSaleItem = new System.Windows.Forms.Label();
            this.txtBirdFoodSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtBirdFoodSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtBirdFoodSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleTotal = new System.Windows.Forms.Label();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.dgvBirdFoodSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearBoxes = new System.Windows.Forms.Button();
            this.txtBirdFoodSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtBirdFoodSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtBirdFoodSaleFinalTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirdFoodSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBirdFoodSalePrice
            // 
            this.txtBirdFoodSalePrice.Location = new System.Drawing.Point(295, 267);
            this.txtBirdFoodSalePrice.Name = "txtBirdFoodSalePrice";
            this.txtBirdFoodSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtBirdFoodSalePrice.TabIndex = 39;
            this.txtBirdFoodSalePrice.TextChanged += new System.EventHandler(this.txtBirdFoodSalePrice_TextChanged);
            // 
            // lblDogFoodSalePrice
            // 
            this.lblDogFoodSalePrice.AutoSize = true;
            this.lblDogFoodSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSalePrice.Location = new System.Drawing.Point(41, 256);
            this.lblDogFoodSalePrice.Name = "lblDogFoodSalePrice";
            this.lblDogFoodSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogFoodSalePrice.TabIndex = 38;
            this.lblDogFoodSalePrice.Text = "PRICE:";
            // 
            // txtBirdFoodSaleQuantity
            // 
            this.txtBirdFoodSaleQuantity.Location = new System.Drawing.Point(295, 354);
            this.txtBirdFoodSaleQuantity.Name = "txtBirdFoodSaleQuantity";
            this.txtBirdFoodSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtBirdFoodSaleQuantity.TabIndex = 37;
            this.txtBirdFoodSaleQuantity.TextChanged += new System.EventHandler(this.txtBirdFoodSaleQuantity_TextChanged);
            // 
            // lblDogFoodSaleQuantity
            // 
            this.lblDogFoodSaleQuantity.AutoSize = true;
            this.lblDogFoodSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleQuantity.Location = new System.Drawing.Point(41, 344);
            this.lblDogFoodSaleQuantity.Name = "lblDogFoodSaleQuantity";
            this.lblDogFoodSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleQuantity.TabIndex = 36;
            this.lblDogFoodSaleQuantity.Text = "QUANTITY:";
            // 
            // cboBirdFoodSaleItems
            // 
            this.cboBirdFoodSaleItems.FormattingEnabled = true;
            this.cboBirdFoodSaleItems.Items.AddRange(new object[] {
            "MARLTONS BUDGIE SEED MIX",
            "MARLTONS GARDEN BIRD SEED MIX",
            "MARLTONS WILD BIRD SEED MIX",
            "MARLTONS WILD BIRD SEED MIX 10KG",
            "MARLTONS PARROT FOOD",
            "TROPICAL PARROT FOOD",
            "PARROT FOOD PLUMAGE ENHANCER",
            "PARROT FOOD FRUIT AND NUT",
            "PARROT FOOD CHILLI",
            "COCKATIEL MIX",
            "CANARY MIXED BIRD SEED",
            "COCKATIEL SEED",
            "BUDGIE SEED TUB",
            "PARROT FOOD TUB",
            "PARROT FOOD SMALL PELLETS",
            "COCKATIEL MIX LARGE",
            "PARROT FRUIT CHUNKS",
            "GRANULATED FOOD FOR COCKATIELS"});
            this.cboBirdFoodSaleItems.Location = new System.Drawing.Point(295, 173);
            this.cboBirdFoodSaleItems.Name = "cboBirdFoodSaleItems";
            this.cboBirdFoodSaleItems.Size = new System.Drawing.Size(354, 21);
            this.cboBirdFoodSaleItems.TabIndex = 35;
            this.cboBirdFoodSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboBirdFoodSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(41, 80);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 34;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(295, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // lblDogFoodSaleItem
            // 
            this.lblDogFoodSaleItem.AutoSize = true;
            this.lblDogFoodSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleItem.Location = new System.Drawing.Point(41, 164);
            this.lblDogFoodSaleItem.Name = "lblDogFoodSaleItem";
            this.lblDogFoodSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleItem.TabIndex = 32;
            this.lblDogFoodSaleItem.Text = "SELECT ITEM:";
            // 
            // txtBirdFoodSaleAmountDue
            // 
            this.txtBirdFoodSaleAmountDue.Location = new System.Drawing.Point(295, 621);
            this.txtBirdFoodSaleAmountDue.Name = "txtBirdFoodSaleAmountDue";
            this.txtBirdFoodSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtBirdFoodSaleAmountDue.TabIndex = 82;
            this.txtBirdFoodSaleAmountDue.TextChanged += new System.EventHandler(this.txtBirdFoodSaleAmountDue_TextChanged);
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(41, 610);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 81;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtBirdFoodSaleDiscount
            // 
            this.txtBirdFoodSaleDiscount.Location = new System.Drawing.Point(295, 539);
            this.txtBirdFoodSaleDiscount.Name = "txtBirdFoodSaleDiscount";
            this.txtBirdFoodSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtBirdFoodSaleDiscount.TabIndex = 80;
            this.txtBirdFoodSaleDiscount.TextChanged += new System.EventHandler(this.txtBirdFoodSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(41, 528);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 79;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtBirdFoodSaleTotal
            // 
            this.txtBirdFoodSaleTotal.Location = new System.Drawing.Point(295, 452);
            this.txtBirdFoodSaleTotal.Name = "txtBirdFoodSaleTotal";
            this.txtBirdFoodSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtBirdFoodSaleTotal.TabIndex = 78;
            this.txtBirdFoodSaleTotal.TextChanged += new System.EventHandler(this.txtBirdFoodSaleTotal_TextChanged);
            // 
            // lblDogFoodSaleTotal
            // 
            this.lblDogFoodSaleTotal.AutoSize = true;
            this.lblDogFoodSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleTotal.Location = new System.Drawing.Point(41, 442);
            this.lblDogFoodSaleTotal.Name = "lblDogFoodSaleTotal";
            this.lblDogFoodSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogFoodSaleTotal.TabIndex = 77;
            this.lblDogFoodSaleTotal.Text = "TOTAL:";
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(682, 138);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 92;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(682, 91);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 91;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // dgvBirdFoodSale
            // 
            this.dgvBirdFoodSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBirdFoodSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvBirdFoodSale.Location = new System.Drawing.Point(849, 91);
            this.dgvBirdFoodSale.Name = "dgvBirdFoodSale";
            this.dgvBirdFoodSale.Size = new System.Drawing.Size(491, 381);
            this.dgvBirdFoodSale.TabIndex = 90;
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
            this.btnClearBoxes.Location = new System.Drawing.Point(682, 556);
            this.btnClearBoxes.Name = "btnClearBoxes";
            this.btnClearBoxes.Size = new System.Drawing.Size(134, 59);
            this.btnClearBoxes.TabIndex = 102;
            this.btnClearBoxes.Text = "CLEAR BOXES";
            this.btnClearBoxes.UseVisualStyleBackColor = false;
            this.btnClearBoxes.Click += new System.EventHandler(this.btnClearBoxes_Click);
            // 
            // txtBirdFoodSaleChangeDue
            // 
            this.txtBirdFoodSaleChangeDue.Location = new System.Drawing.Point(1075, 624);
            this.txtBirdFoodSaleChangeDue.Name = "txtBirdFoodSaleChangeDue";
            this.txtBirdFoodSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtBirdFoodSaleChangeDue.TabIndex = 101;
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(850, 498);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 100;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(852, 613);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 99;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtBirdFoodSaleAmountPaid
            // 
            this.txtBirdFoodSaleAmountPaid.Location = new System.Drawing.Point(1075, 568);
            this.txtBirdFoodSaleAmountPaid.Name = "txtBirdFoodSaleAmountPaid";
            this.txtBirdFoodSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtBirdFoodSaleAmountPaid.TabIndex = 98;
            this.txtBirdFoodSaleAmountPaid.TextChanged += new System.EventHandler(this.txtBirdFoodSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(852, 557);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 97;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(542, 499);
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
            this.btnClearFields.Location = new System.Drawing.Point(542, 557);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 59);
            this.btnClearFields.TabIndex = 95;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(682, 498);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 94;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtBirdFoodSaleFinalTotal
            // 
            this.txtBirdFoodSaleFinalTotal.Location = new System.Drawing.Point(1075, 513);
            this.txtBirdFoodSaleFinalTotal.Name = "txtBirdFoodSaleFinalTotal";
            this.txtBirdFoodSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtBirdFoodSaleFinalTotal.TabIndex = 93;
            // 
            // Bird_Food_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.btnClearBoxes);
            this.Controls.Add(this.txtBirdFoodSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtBirdFoodSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtBirdFoodSaleFinalTotal);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.dgvBirdFoodSale);
            this.Controls.Add(this.txtBirdFoodSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtBirdFoodSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtBirdFoodSaleTotal);
            this.Controls.Add(this.lblDogFoodSaleTotal);
            this.Controls.Add(this.txtBirdFoodSalePrice);
            this.Controls.Add(this.lblDogFoodSalePrice);
            this.Controls.Add(this.txtBirdFoodSaleQuantity);
            this.Controls.Add(this.lblDogFoodSaleQuantity);
            this.Controls.Add(this.cboBirdFoodSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogFoodSaleItem);
            this.Name = "Bird_Food_Sale";
            this.Text = "Bird_Food_Sale";
            this.Load += new System.EventHandler(this.Bird_Food_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirdFoodSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirdFoodSalePrice;
        private System.Windows.Forms.Label lblDogFoodSalePrice;
        private System.Windows.Forms.TextBox txtBirdFoodSaleQuantity;
        private System.Windows.Forms.Label lblDogFoodSaleQuantity;
        private System.Windows.Forms.ComboBox cboBirdFoodSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogFoodSaleItem;
        private System.Windows.Forms.TextBox txtBirdFoodSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtBirdFoodSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtBirdFoodSaleTotal;
        private System.Windows.Forms.Label lblDogFoodSaleTotal;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.DataGridView dgvBirdFoodSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnClearBoxes;
        private System.Windows.Forms.TextBox txtBirdFoodSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtBirdFoodSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtBirdFoodSaleFinalTotal;
    }
}