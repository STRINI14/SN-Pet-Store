namespace SN_Pet_Store
{
    partial class Bird_Acc_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bird_Acc_Sale));
            this.txtBirdAccSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogAccSalePrice = new System.Windows.Forms.Label();
            this.txtBirdAccSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogAccSaleQuantity = new System.Windows.Forms.Label();
            this.cboBirdAccSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogAccSaleItem = new System.Windows.Forms.Label();
            this.txtBirdAccSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtBirdAccSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtBirdAccSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogAccSaleTotal = new System.Windows.Forms.Label();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.dgvFishAccSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtBirdAccSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtBirdAccSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.txtBirdAccSaleFinalTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishAccSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBirdAccSalePrice
            // 
            this.txtBirdAccSalePrice.Location = new System.Drawing.Point(301, 261);
            this.txtBirdAccSalePrice.Name = "txtBirdAccSalePrice";
            this.txtBirdAccSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtBirdAccSalePrice.TabIndex = 90;
            this.txtBirdAccSalePrice.TextChanged += new System.EventHandler(this.txtBirdAccSalePrice_TextChanged);
            // 
            // lblDogAccSalePrice
            // 
            this.lblDogAccSalePrice.AutoSize = true;
            this.lblDogAccSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSalePrice.Location = new System.Drawing.Point(47, 251);
            this.lblDogAccSalePrice.Name = "lblDogAccSalePrice";
            this.lblDogAccSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogAccSalePrice.TabIndex = 89;
            this.lblDogAccSalePrice.Text = "PRICE:";
            // 
            // txtBirdAccSaleQuantity
            // 
            this.txtBirdAccSaleQuantity.Location = new System.Drawing.Point(301, 348);
            this.txtBirdAccSaleQuantity.Name = "txtBirdAccSaleQuantity";
            this.txtBirdAccSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtBirdAccSaleQuantity.TabIndex = 88;
            this.txtBirdAccSaleQuantity.TextChanged += new System.EventHandler(this.txtBirdAccSaleQuantity_TextChanged);
            // 
            // lblDogAccSaleQuantity
            // 
            this.lblDogAccSaleQuantity.AutoSize = true;
            this.lblDogAccSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleQuantity.Location = new System.Drawing.Point(47, 338);
            this.lblDogAccSaleQuantity.Name = "lblDogAccSaleQuantity";
            this.lblDogAccSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogAccSaleQuantity.TabIndex = 87;
            this.lblDogAccSaleQuantity.Text = "QUANTITY:";
            // 
            // cboBirdAccSaleItems
            // 
            this.cboBirdAccSaleItems.FormattingEnabled = true;
            this.cboBirdAccSaleItems.Items.AddRange(new object[] {
            "PARROT WOODEN PLAYGROUND",
            "COCONUT SHELL BIRD HOUSE",
            "WINTER WARM BIRD NEST",
            "LARGE HARNESS WITH LEASH",
            "PARROT CARRIER TRAVEL BAG",
            "PARROT/BUDGIE CHEW BITE ROD",
            "INTERACTIVE GYM",
            "WOODEN SWING CLIMB LADDER",
            "PARROT PLAYGROUND",
            "PARROT CHEW ROPE HAMMOCK",
            "PARROT PERCH ROPE",
            "PARROT BATHTUB",
            "PARROT DRINKING FEEDER",
            "BIRD CAGE COVER",
            "SMALL BIRD CAGE",
            "LARGE METAL BIRD CAGE",
            "ROUND METAL BIRD CAGE",
            "BIRD LAMP "});
            this.cboBirdAccSaleItems.Location = new System.Drawing.Point(301, 171);
            this.cboBirdAccSaleItems.Name = "cboBirdAccSaleItems";
            this.cboBirdAccSaleItems.Size = new System.Drawing.Size(200, 21);
            this.cboBirdAccSaleItems.TabIndex = 86;
            this.cboBirdAccSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboBirdAccSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(47, 78);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 85;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(301, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // lblDogAccSaleItem
            // 
            this.lblDogAccSaleItem.AutoSize = true;
            this.lblDogAccSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleItem.Location = new System.Drawing.Point(47, 162);
            this.lblDogAccSaleItem.Name = "lblDogAccSaleItem";
            this.lblDogAccSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogAccSaleItem.TabIndex = 83;
            this.lblDogAccSaleItem.Text = "SELECT ITEM:";
            // 
            // txtBirdAccSaleAmountDue
            // 
            this.txtBirdAccSaleAmountDue.Location = new System.Drawing.Point(301, 606);
            this.txtBirdAccSaleAmountDue.Name = "txtBirdAccSaleAmountDue";
            this.txtBirdAccSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtBirdAccSaleAmountDue.TabIndex = 96;
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(47, 595);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 95;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtBirdAccSaleDiscount
            // 
            this.txtBirdAccSaleDiscount.Location = new System.Drawing.Point(301, 524);
            this.txtBirdAccSaleDiscount.Name = "txtBirdAccSaleDiscount";
            this.txtBirdAccSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtBirdAccSaleDiscount.TabIndex = 94;
            this.txtBirdAccSaleDiscount.TextChanged += new System.EventHandler(this.txtBirdAccSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(47, 513);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 93;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtBirdAccSaleTotal
            // 
            this.txtBirdAccSaleTotal.Location = new System.Drawing.Point(301, 440);
            this.txtBirdAccSaleTotal.Name = "txtBirdAccSaleTotal";
            this.txtBirdAccSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtBirdAccSaleTotal.TabIndex = 92;
            // 
            // lblDogAccSaleTotal
            // 
            this.lblDogAccSaleTotal.AutoSize = true;
            this.lblDogAccSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleTotal.Location = new System.Drawing.Point(47, 430);
            this.lblDogAccSaleTotal.Name = "lblDogAccSaleTotal";
            this.lblDogAccSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogAccSaleTotal.TabIndex = 91;
            this.lblDogAccSaleTotal.Text = "TOTAL:";
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(660, 136);
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
            this.btnBackToLogin.Location = new System.Drawing.Point(660, 89);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 103;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // dgvFishAccSale
            // 
            this.dgvFishAccSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFishAccSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvFishAccSale.Location = new System.Drawing.Point(849, 89);
            this.dgvFishAccSale.Name = "dgvFishAccSale";
            this.dgvFishAccSale.Size = new System.Drawing.Size(491, 381);
            this.dgvFishAccSale.TabIndex = 102;
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
            this.button1.Location = new System.Drawing.Point(697, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 67);
            this.button1.TabIndex = 114;
            this.button1.Text = "CLEAR BOXES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(541, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 113;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(541, 542);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 67);
            this.btnClearFields.TabIndex = 112;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(697, 490);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 111;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtBirdAccSaleChangeDue
            // 
            this.txtBirdAccSaleChangeDue.Location = new System.Drawing.Point(1072, 615);
            this.txtBirdAccSaleChangeDue.Name = "txtBirdAccSaleChangeDue";
            this.txtBirdAccSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtBirdAccSaleChangeDue.TabIndex = 110;
            this.txtBirdAccSaleChangeDue.TextChanged += new System.EventHandler(this.txtBirdAccSaleChangeDue_TextChanged);
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(847, 489);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 109;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(849, 604);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 108;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtBirdAccSaleAmountPaid
            // 
            this.txtBirdAccSaleAmountPaid.Location = new System.Drawing.Point(1072, 559);
            this.txtBirdAccSaleAmountPaid.Name = "txtBirdAccSaleAmountPaid";
            this.txtBirdAccSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtBirdAccSaleAmountPaid.TabIndex = 107;
            this.txtBirdAccSaleAmountPaid.TextChanged += new System.EventHandler(this.txtBirdAccSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(849, 548);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 106;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // txtBirdAccSaleFinalTotal
            // 
            this.txtBirdAccSaleFinalTotal.Location = new System.Drawing.Point(1072, 504);
            this.txtBirdAccSaleFinalTotal.Name = "txtBirdAccSaleFinalTotal";
            this.txtBirdAccSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtBirdAccSaleFinalTotal.TabIndex = 105;
            // 
            // Bird_Acc_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtBirdAccSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtBirdAccSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.txtBirdAccSaleFinalTotal);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.dgvFishAccSale);
            this.Controls.Add(this.txtBirdAccSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtBirdAccSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtBirdAccSaleTotal);
            this.Controls.Add(this.lblDogAccSaleTotal);
            this.Controls.Add(this.txtBirdAccSalePrice);
            this.Controls.Add(this.lblDogAccSalePrice);
            this.Controls.Add(this.txtBirdAccSaleQuantity);
            this.Controls.Add(this.lblDogAccSaleQuantity);
            this.Controls.Add(this.cboBirdAccSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogAccSaleItem);
            this.Name = "Bird_Acc_Sale";
            this.Text = "Bird_Acc_Sale";
            this.Load += new System.EventHandler(this.Bird_Acc_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishAccSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirdAccSalePrice;
        private System.Windows.Forms.Label lblDogAccSalePrice;
        private System.Windows.Forms.TextBox txtBirdAccSaleQuantity;
        private System.Windows.Forms.Label lblDogAccSaleQuantity;
        private System.Windows.Forms.ComboBox cboBirdAccSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogAccSaleItem;
        private System.Windows.Forms.TextBox txtBirdAccSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtBirdAccSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtBirdAccSaleTotal;
        private System.Windows.Forms.Label lblDogAccSaleTotal;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.DataGridView dgvFishAccSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtBirdAccSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtBirdAccSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.TextBox txtBirdAccSaleFinalTotal;
    }
}