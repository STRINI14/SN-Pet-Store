namespace SN_Pet_Store
{
    partial class Dog_Acc_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dog_Acc_Sale));
            this.txtDogAccSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogAccSalePrice = new System.Windows.Forms.Label();
            this.txtDogAccSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogAccSaleQuantity = new System.Windows.Forms.Label();
            this.cboDogAccSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogAccSaleItem = new System.Windows.Forms.Label();
            this.txtDogAccSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogAccSaleTotal = new System.Windows.Forms.Label();
            this.txtDogAccSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtDogAccSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtDogAccSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtDogAccSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.txtDogAccSaleFinalTotal = new System.Windows.Forms.TextBox();
            this.dgvDogAccSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogAccSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDogAccSalePrice
            // 
            this.txtDogAccSalePrice.Location = new System.Drawing.Point(289, 260);
            this.txtDogAccSalePrice.Name = "txtDogAccSalePrice";
            this.txtDogAccSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtDogAccSalePrice.TabIndex = 31;
            this.txtDogAccSalePrice.TextChanged += new System.EventHandler(this.txtDogAccSalePrice_TextChanged);
            // 
            // lblDogAccSalePrice
            // 
            this.lblDogAccSalePrice.AutoSize = true;
            this.lblDogAccSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSalePrice.Location = new System.Drawing.Point(35, 250);
            this.lblDogAccSalePrice.Name = "lblDogAccSalePrice";
            this.lblDogAccSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogAccSalePrice.TabIndex = 30;
            this.lblDogAccSalePrice.Text = "PRICE:";
            // 
            // txtDogAccSaleQuantity
            // 
            this.txtDogAccSaleQuantity.Location = new System.Drawing.Point(289, 347);
            this.txtDogAccSaleQuantity.Name = "txtDogAccSaleQuantity";
            this.txtDogAccSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtDogAccSaleQuantity.TabIndex = 29;
            this.txtDogAccSaleQuantity.TextChanged += new System.EventHandler(this.txtDogAccSaleQuantity_TextChanged);
            // 
            // lblDogAccSaleQuantity
            // 
            this.lblDogAccSaleQuantity.AutoSize = true;
            this.lblDogAccSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleQuantity.Location = new System.Drawing.Point(35, 337);
            this.lblDogAccSaleQuantity.Name = "lblDogAccSaleQuantity";
            this.lblDogAccSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogAccSaleQuantity.TabIndex = 28;
            this.lblDogAccSaleQuantity.Text = "QUANTITY:";
            // 
            // cboDogAccSaleItems
            // 
            this.cboDogAccSaleItems.FormattingEnabled = true;
            this.cboDogAccSaleItems.Items.AddRange(new object[] {
            "SMALL DOG BED ",
            "MEDIUM DOG BED",
            "LARGE DOG BED",
            "WOODEN KENNEL SMALL",
            "WOODEN KENNEL LARGE",
            "PLASTIC KENNEL SMALL",
            "PLASTIC KENNEL LARGE",
            "STAINLESS STEEL DOG BOWL",
            "PLASTIC DOG BOWL",
            "SMALL DOG BLANKET",
            "MEDIUM DOG BLANKET",
            "RED NECK COLLAR",
            "BLACK NECK COLLAR",
            "SMALL DOG CHAIN",
            "LARGE DOG CHAIN",
            "RAW HOOF",
            "RAW HIDE",
            "PACK OF 3 TENNIS BALLS"});
            this.cboDogAccSaleItems.Location = new System.Drawing.Point(289, 170);
            this.cboDogAccSaleItems.Name = "cboDogAccSaleItems";
            this.cboDogAccSaleItems.Size = new System.Drawing.Size(328, 21);
            this.cboDogAccSaleItems.TabIndex = 27;
            this.cboDogAccSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboDogAccSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(35, 77);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 26;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // lblDogAccSaleItem
            // 
            this.lblDogAccSaleItem.AutoSize = true;
            this.lblDogAccSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleItem.Location = new System.Drawing.Point(35, 161);
            this.lblDogAccSaleItem.Name = "lblDogAccSaleItem";
            this.lblDogAccSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogAccSaleItem.TabIndex = 24;
            this.lblDogAccSaleItem.Text = "SELECT ITEM:";
            // 
            // txtDogAccSaleTotal
            // 
            this.txtDogAccSaleTotal.Location = new System.Drawing.Point(289, 425);
            this.txtDogAccSaleTotal.Name = "txtDogAccSaleTotal";
            this.txtDogAccSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtDogAccSaleTotal.TabIndex = 33;
            this.txtDogAccSaleTotal.TextChanged += new System.EventHandler(this.txtDogAccSaleTotal_TextChanged);
            // 
            // lblDogAccSaleTotal
            // 
            this.lblDogAccSaleTotal.AutoSize = true;
            this.lblDogAccSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleTotal.Location = new System.Drawing.Point(35, 415);
            this.lblDogAccSaleTotal.Name = "lblDogAccSaleTotal";
            this.lblDogAccSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogAccSaleTotal.TabIndex = 32;
            this.lblDogAccSaleTotal.Text = "TOTAL:";
            // 
            // txtDogAccSaleAmountDue
            // 
            this.txtDogAccSaleAmountDue.Location = new System.Drawing.Point(289, 591);
            this.txtDogAccSaleAmountDue.Name = "txtDogAccSaleAmountDue";
            this.txtDogAccSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtDogAccSaleAmountDue.TabIndex = 74;
            this.txtDogAccSaleAmountDue.TextChanged += new System.EventHandler(this.txtDogAccSaleAmountDue_TextChanged);
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(35, 580);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 73;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtDogAccSaleDiscount
            // 
            this.txtDogAccSaleDiscount.Location = new System.Drawing.Point(289, 509);
            this.txtDogAccSaleDiscount.Name = "txtDogAccSaleDiscount";
            this.txtDogAccSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtDogAccSaleDiscount.TabIndex = 72;
            this.txtDogAccSaleDiscount.TextChanged += new System.EventHandler(this.txtDogAccSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(35, 498);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 71;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtDogAccSaleChangeDue
            // 
            this.txtDogAccSaleChangeDue.Location = new System.Drawing.Point(1083, 591);
            this.txtDogAccSaleChangeDue.Name = "txtDogAccSaleChangeDue";
            this.txtDogAccSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtDogAccSaleChangeDue.TabIndex = 80;
            this.txtDogAccSaleChangeDue.TextChanged += new System.EventHandler(this.txtDogAccSaleChangeDue_TextChanged);
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(858, 465);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 79;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(860, 580);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 78;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtDogAccSaleAmountPaid
            // 
            this.txtDogAccSaleAmountPaid.Location = new System.Drawing.Point(1083, 535);
            this.txtDogAccSaleAmountPaid.Name = "txtDogAccSaleAmountPaid";
            this.txtDogAccSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtDogAccSaleAmountPaid.TabIndex = 77;
            this.txtDogAccSaleAmountPaid.TextChanged += new System.EventHandler(this.txtDogAccSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(860, 524);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 76;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // txtDogAccSaleFinalTotal
            // 
            this.txtDogAccSaleFinalTotal.Location = new System.Drawing.Point(1083, 480);
            this.txtDogAccSaleFinalTotal.Name = "txtDogAccSaleFinalTotal";
            this.txtDogAccSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtDogAccSaleFinalTotal.TabIndex = 75;
            this.txtDogAccSaleFinalTotal.TextChanged += new System.EventHandler(this.txtDogAccSaleFinalTotal_TextChanged);
            // 
            // dgvDogAccSale
            // 
            this.dgvDogAccSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogAccSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvDogAccSale.Location = new System.Drawing.Point(858, 69);
            this.dgvDogAccSale.Name = "dgvDogAccSale";
            this.dgvDogAccSale.Size = new System.Drawing.Size(491, 381);
            this.dgvDogAccSale.TabIndex = 81;
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
            this.btnClearGrid.Location = new System.Drawing.Point(689, 124);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 83;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(689, 77);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 82;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(555, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 86;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(555, 521);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 67);
            this.btnClearFields.TabIndex = 85;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(708, 466);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 84;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(708, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 67);
            this.button1.TabIndex = 87;
            this.button1.Text = "CLEAR BOXES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dog_Acc_Sale
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
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.dgvDogAccSale);
            this.Controls.Add(this.txtDogAccSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtDogAccSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.txtDogAccSaleFinalTotal);
            this.Controls.Add(this.txtDogAccSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtDogAccSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtDogAccSaleTotal);
            this.Controls.Add(this.lblDogAccSaleTotal);
            this.Controls.Add(this.txtDogAccSalePrice);
            this.Controls.Add(this.lblDogAccSalePrice);
            this.Controls.Add(this.txtDogAccSaleQuantity);
            this.Controls.Add(this.lblDogAccSaleQuantity);
            this.Controls.Add(this.cboDogAccSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogAccSaleItem);
            this.Name = "Dog_Acc_Sale";
            this.Text = "Dog_Acc_Sale";
            this.Load += new System.EventHandler(this.Dog_Acc_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogAccSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDogAccSalePrice;
        private System.Windows.Forms.Label lblDogAccSalePrice;
        private System.Windows.Forms.TextBox txtDogAccSaleQuantity;
        private System.Windows.Forms.Label lblDogAccSaleQuantity;
        private System.Windows.Forms.ComboBox cboDogAccSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogAccSaleItem;
        private System.Windows.Forms.TextBox txtDogAccSaleTotal;
        private System.Windows.Forms.Label lblDogAccSaleTotal;
        private System.Windows.Forms.TextBox txtDogAccSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtDogAccSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtDogAccSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtDogAccSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.TextBox txtDogAccSaleFinalTotal;
        private System.Windows.Forms.DataGridView dgvDogAccSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button button1;
    }
}