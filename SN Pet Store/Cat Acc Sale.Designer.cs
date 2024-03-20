namespace SN_Pet_Store
{
    partial class Cat_Acc_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cat_Acc_Sale));
            this.txtCatAccSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtCatAccSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtCatAccSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogAccSaleTotal = new System.Windows.Forms.Label();
            this.txtCatAccSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogAccSalePrice = new System.Windows.Forms.Label();
            this.txtCatAccSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogAccSaleQuantity = new System.Windows.Forms.Label();
            this.cboCatAccSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogAccSaleItem = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtCatAccSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtCatAccSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.txtCatAccSaleFinalTotal = new System.Windows.Forms.TextBox();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.dgvCatAccSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatAccSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCatAccSaleAmountDue
            // 
            this.txtCatAccSaleAmountDue.Location = new System.Drawing.Point(289, 596);
            this.txtCatAccSaleAmountDue.Name = "txtCatAccSaleAmountDue";
            this.txtCatAccSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtCatAccSaleAmountDue.TabIndex = 88;
            this.txtCatAccSaleAmountDue.TextChanged += new System.EventHandler(this.txtCatAccSaleAmountDue_TextChanged);
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(35, 585);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 87;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtCatAccSaleDiscount
            // 
            this.txtCatAccSaleDiscount.Location = new System.Drawing.Point(289, 514);
            this.txtCatAccSaleDiscount.Name = "txtCatAccSaleDiscount";
            this.txtCatAccSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtCatAccSaleDiscount.TabIndex = 86;
            this.txtCatAccSaleDiscount.TextChanged += new System.EventHandler(this.txCatAccSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(35, 503);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 85;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtCatAccSaleTotal
            // 
            this.txtCatAccSaleTotal.Location = new System.Drawing.Point(289, 430);
            this.txtCatAccSaleTotal.Name = "txtCatAccSaleTotal";
            this.txtCatAccSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtCatAccSaleTotal.TabIndex = 84;
            this.txtCatAccSaleTotal.TextChanged += new System.EventHandler(this.txtCatAccSaleTotal_TextChanged);
            // 
            // lblDogAccSaleTotal
            // 
            this.lblDogAccSaleTotal.AutoSize = true;
            this.lblDogAccSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleTotal.Location = new System.Drawing.Point(35, 420);
            this.lblDogAccSaleTotal.Name = "lblDogAccSaleTotal";
            this.lblDogAccSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogAccSaleTotal.TabIndex = 83;
            this.lblDogAccSaleTotal.Text = "TOTAL:";
            // 
            // txtCatAccSalePrice
            // 
            this.txtCatAccSalePrice.Location = new System.Drawing.Point(289, 265);
            this.txtCatAccSalePrice.Name = "txtCatAccSalePrice";
            this.txtCatAccSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtCatAccSalePrice.TabIndex = 82;
            this.txtCatAccSalePrice.TextChanged += new System.EventHandler(this.txtCatAccSalePrice_TextChanged);
            // 
            // lblDogAccSalePrice
            // 
            this.lblDogAccSalePrice.AutoSize = true;
            this.lblDogAccSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSalePrice.Location = new System.Drawing.Point(35, 255);
            this.lblDogAccSalePrice.Name = "lblDogAccSalePrice";
            this.lblDogAccSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogAccSalePrice.TabIndex = 81;
            this.lblDogAccSalePrice.Text = "PRICE:";
            // 
            // txtCatAccSaleQuantity
            // 
            this.txtCatAccSaleQuantity.Location = new System.Drawing.Point(289, 352);
            this.txtCatAccSaleQuantity.Name = "txtCatAccSaleQuantity";
            this.txtCatAccSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtCatAccSaleQuantity.TabIndex = 80;
            this.txtCatAccSaleQuantity.TextChanged += new System.EventHandler(this.txtCatAccSaleQuantity_TextChanged);
            // 
            // lblDogAccSaleQuantity
            // 
            this.lblDogAccSaleQuantity.AutoSize = true;
            this.lblDogAccSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleQuantity.Location = new System.Drawing.Point(35, 342);
            this.lblDogAccSaleQuantity.Name = "lblDogAccSaleQuantity";
            this.lblDogAccSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogAccSaleQuantity.TabIndex = 79;
            this.lblDogAccSaleQuantity.Text = "QUANTITY:";
            // 
            // cboCatAccSaleItems
            // 
            this.cboCatAccSaleItems.FormattingEnabled = true;
            this.cboCatAccSaleItems.Items.AddRange(new object[] {
            "PET FUR REMOVER",
            "ANTI-TRACKING MAT",
            "REX TRAVEL CASE",
            "WOODEN CAT SCRATCHER",
            "CAT SCRATCH AND LOUNGE",
            "ROUND CAT CAVE",
            "CAT PAN",
            "KITTY CUDDLE PAL",
            "SCRATCHING BLOCK",
            "KITTY CAT BRUSH",
            "CAT LITTER TRAY",
            "LITTER SCOOP",
            "KNIT PET HOME",
            "CAT TUNNEL",
            "MEDIUM COLLAR",
            "SOFT HARNESS WITH LEASH"});
            this.cboCatAccSaleItems.Location = new System.Drawing.Point(289, 175);
            this.cboCatAccSaleItems.Name = "cboCatAccSaleItems";
            this.cboCatAccSaleItems.Size = new System.Drawing.Size(328, 21);
            this.cboCatAccSaleItems.TabIndex = 78;
            this.cboCatAccSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboCatAccSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(35, 82);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 77;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // lblDogAccSaleItem
            // 
            this.lblDogAccSaleItem.AutoSize = true;
            this.lblDogAccSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleItem.Location = new System.Drawing.Point(35, 166);
            this.lblDogAccSaleItem.Name = "lblDogAccSaleItem";
            this.lblDogAccSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogAccSaleItem.TabIndex = 75;
            this.lblDogAccSaleItem.Text = "SELECT ITEM:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(699, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 67);
            this.button1.TabIndex = 98;
            this.button1.Text = "CLEAR BOXES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(543, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 97;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(543, 522);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 67);
            this.btnClearFields.TabIndex = 96;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(699, 470);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 95;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtCatAccSaleChangeDue
            // 
            this.txtCatAccSaleChangeDue.Location = new System.Drawing.Point(1074, 595);
            this.txtCatAccSaleChangeDue.Name = "txtCatAccSaleChangeDue";
            this.txtCatAccSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtCatAccSaleChangeDue.TabIndex = 94;
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(849, 469);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 93;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(851, 584);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 92;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtCatAccSaleAmountPaid
            // 
            this.txtCatAccSaleAmountPaid.Location = new System.Drawing.Point(1074, 539);
            this.txtCatAccSaleAmountPaid.Name = "txtCatAccSaleAmountPaid";
            this.txtCatAccSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtCatAccSaleAmountPaid.TabIndex = 91;
            this.txtCatAccSaleAmountPaid.TextChanged += new System.EventHandler(this.txtCatAccSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(851, 528);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 90;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // txtCatAccSaleFinalTotal
            // 
            this.txtCatAccSaleFinalTotal.Location = new System.Drawing.Point(1074, 484);
            this.txtCatAccSaleFinalTotal.Name = "txtCatAccSaleFinalTotal";
            this.txtCatAccSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtCatAccSaleFinalTotal.TabIndex = 89;
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(660, 116);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 101;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(660, 69);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 100;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // dgvCatAccSale
            // 
            this.dgvCatAccSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatAccSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvCatAccSale.Location = new System.Drawing.Point(849, 69);
            this.dgvCatAccSale.Name = "dgvCatAccSale";
            this.dgvCatAccSale.Size = new System.Drawing.Size(491, 381);
            this.dgvCatAccSale.TabIndex = 99;
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
            // Cat_Acc_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.dgvCatAccSale);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtCatAccSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtCatAccSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.txtCatAccSaleFinalTotal);
            this.Controls.Add(this.txtCatAccSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtCatAccSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtCatAccSaleTotal);
            this.Controls.Add(this.lblDogAccSaleTotal);
            this.Controls.Add(this.txtCatAccSalePrice);
            this.Controls.Add(this.lblDogAccSalePrice);
            this.Controls.Add(this.txtCatAccSaleQuantity);
            this.Controls.Add(this.lblDogAccSaleQuantity);
            this.Controls.Add(this.cboCatAccSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogAccSaleItem);
            this.Name = "Cat_Acc_Sale";
            this.Text = "Cat_Acc_Sale";
            this.Load += new System.EventHandler(this.Cat_Acc_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatAccSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCatAccSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtCatAccSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtCatAccSaleTotal;
        private System.Windows.Forms.Label lblDogAccSaleTotal;
        private System.Windows.Forms.TextBox txtCatAccSalePrice;
        private System.Windows.Forms.Label lblDogAccSalePrice;
        private System.Windows.Forms.TextBox txtCatAccSaleQuantity;
        private System.Windows.Forms.Label lblDogAccSaleQuantity;
        private System.Windows.Forms.ComboBox cboCatAccSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogAccSaleItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtCatAccSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtCatAccSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.TextBox txtCatAccSaleFinalTotal;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.DataGridView dgvCatAccSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}