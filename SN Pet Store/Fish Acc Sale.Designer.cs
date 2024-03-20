namespace SN_Pet_Store
{
    partial class Fish_Acc_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fish_Acc_Sale));
            this.txtFishAccSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogAccSalePrice = new System.Windows.Forms.Label();
            this.txtFishAccSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogAccSaleQuantity = new System.Windows.Forms.Label();
            this.cboFishAccSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogAccSaleItem = new System.Windows.Forms.Label();
            this.txtFishAccSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtFishAccSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtFishAccSaleTotal = new System.Windows.Forms.TextBox();
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
            this.txtFishAccSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtFishAccSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.txtFishAccSaleFinalTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishAccSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFishAccSalePrice
            // 
            this.txtFishAccSalePrice.Location = new System.Drawing.Point(292, 262);
            this.txtFishAccSalePrice.Name = "txtFishAccSalePrice";
            this.txtFishAccSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtFishAccSalePrice.TabIndex = 98;
            // 
            // lblDogAccSalePrice
            // 
            this.lblDogAccSalePrice.AutoSize = true;
            this.lblDogAccSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSalePrice.Location = new System.Drawing.Point(38, 252);
            this.lblDogAccSalePrice.Name = "lblDogAccSalePrice";
            this.lblDogAccSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogAccSalePrice.TabIndex = 97;
            this.lblDogAccSalePrice.Text = "PRICE:";
            // 
            // txtFishAccSaleQuantity
            // 
            this.txtFishAccSaleQuantity.Location = new System.Drawing.Point(292, 349);
            this.txtFishAccSaleQuantity.Name = "txtFishAccSaleQuantity";
            this.txtFishAccSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtFishAccSaleQuantity.TabIndex = 96;
            this.txtFishAccSaleQuantity.TextChanged += new System.EventHandler(this.txtFishAccSaleQuantity_TextChanged);
            // 
            // lblDogAccSaleQuantity
            // 
            this.lblDogAccSaleQuantity.AutoSize = true;
            this.lblDogAccSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleQuantity.Location = new System.Drawing.Point(38, 339);
            this.lblDogAccSaleQuantity.Name = "lblDogAccSaleQuantity";
            this.lblDogAccSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogAccSaleQuantity.TabIndex = 95;
            this.lblDogAccSaleQuantity.Text = "QUANTITY:";
            // 
            // cboFishAccSaleItems
            // 
            this.cboFishAccSaleItems.FormattingEnabled = true;
            this.cboFishAccSaleItems.Items.AddRange(new object[] {
            "STANDARD GLASS AQUARIUM",
            "VARIETY COLORED GRAVEL",
            "AQUARIUM PINEAPPLE",
            "6 IN 1 AQUARIUM WATER TEST",
            "AQUARIUM AIR STONE OXYGEN PUMP",
            "SOBO INTERNAL FILTER",
            "AQUARIUM LIGHT DECORATION",
            "AQUARIUM DECOR ROCK FORMATION",
            "SPONGEBOB AQUARIUM DECORATION",
            "AQUARIUM WALL AIR BUBBLE STONE TUBE",
            "AQUARIUM LED TANK LIGHT",
            "AQUARIUM GRASS SEEDS",
            "CUBUS GLASS BETTA TANK",
            "30 LITRE EXPLORER FISH TANK",
            "FISH BOWL STARTER KIT",
            "MOSS BALL AQUARIUM PLANT"});
            this.cboFishAccSaleItems.Location = new System.Drawing.Point(292, 172);
            this.cboFishAccSaleItems.Name = "cboFishAccSaleItems";
            this.cboFishAccSaleItems.Size = new System.Drawing.Size(328, 21);
            this.cboFishAccSaleItems.TabIndex = 94;
            this.cboFishAccSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboFishAccSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(38, 79);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 93;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(292, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 92;
            // 
            // lblDogAccSaleItem
            // 
            this.lblDogAccSaleItem.AutoSize = true;
            this.lblDogAccSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleItem.Location = new System.Drawing.Point(38, 163);
            this.lblDogAccSaleItem.Name = "lblDogAccSaleItem";
            this.lblDogAccSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogAccSaleItem.TabIndex = 91;
            this.lblDogAccSaleItem.Text = "SELECT ITEM:";
            // 
            // txtFishAccSaleAmountDue
            // 
            this.txtFishAccSaleAmountDue.Location = new System.Drawing.Point(292, 619);
            this.txtFishAccSaleAmountDue.Name = "txtFishAccSaleAmountDue";
            this.txtFishAccSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtFishAccSaleAmountDue.TabIndex = 104;
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(38, 608);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 103;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtFishAccSaleDiscount
            // 
            this.txtFishAccSaleDiscount.Location = new System.Drawing.Point(292, 537);
            this.txtFishAccSaleDiscount.Name = "txtFishAccSaleDiscount";
            this.txtFishAccSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtFishAccSaleDiscount.TabIndex = 102;
            this.txtFishAccSaleDiscount.TextChanged += new System.EventHandler(this.txtFishAccSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(38, 526);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 101;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtFishAccSaleTotal
            // 
            this.txtFishAccSaleTotal.Location = new System.Drawing.Point(292, 453);
            this.txtFishAccSaleTotal.Name = "txtFishAccSaleTotal";
            this.txtFishAccSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtFishAccSaleTotal.TabIndex = 100;
            // 
            // lblDogAccSaleTotal
            // 
            this.lblDogAccSaleTotal.AutoSize = true;
            this.lblDogAccSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogAccSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogAccSaleTotal.Location = new System.Drawing.Point(38, 443);
            this.lblDogAccSaleTotal.Name = "lblDogAccSaleTotal";
            this.lblDogAccSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogAccSaleTotal.TabIndex = 99;
            this.lblDogAccSaleTotal.Text = "TOTAL:";
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(660, 137);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 107;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(660, 90);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 106;
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
            this.dgvFishAccSale.Location = new System.Drawing.Point(849, 90);
            this.dgvFishAccSale.Name = "dgvFishAccSale";
            this.dgvFishAccSale.Size = new System.Drawing.Size(491, 381);
            this.dgvFishAccSale.TabIndex = 105;
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
            this.button1.Location = new System.Drawing.Point(702, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 67);
            this.button1.TabIndex = 124;
            this.button1.Text = "CLEAR BOXES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(546, 500);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 123;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(546, 552);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 67);
            this.btnClearFields.TabIndex = 122;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(702, 500);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 121;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtFishAccSaleChangeDue
            // 
            this.txtFishAccSaleChangeDue.Location = new System.Drawing.Point(1077, 625);
            this.txtFishAccSaleChangeDue.Name = "txtFishAccSaleChangeDue";
            this.txtFishAccSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtFishAccSaleChangeDue.TabIndex = 120;
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(852, 499);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 119;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(854, 614);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 118;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtFishAccSaleAmountPaid
            // 
            this.txtFishAccSaleAmountPaid.Location = new System.Drawing.Point(1077, 569);
            this.txtFishAccSaleAmountPaid.Name = "txtFishAccSaleAmountPaid";
            this.txtFishAccSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtFishAccSaleAmountPaid.TabIndex = 117;
            this.txtFishAccSaleAmountPaid.TextChanged += new System.EventHandler(this.txtFishAccSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(854, 558);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 116;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // txtFishAccSaleFinalTotal
            // 
            this.txtFishAccSaleFinalTotal.Location = new System.Drawing.Point(1077, 514);
            this.txtFishAccSaleFinalTotal.Name = "txtFishAccSaleFinalTotal";
            this.txtFishAccSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtFishAccSaleFinalTotal.TabIndex = 115;
            // 
            // Fish_Acc_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtFishAccSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtFishAccSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.txtFishAccSaleFinalTotal);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.dgvFishAccSale);
            this.Controls.Add(this.txtFishAccSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtFishAccSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtFishAccSaleTotal);
            this.Controls.Add(this.lblDogAccSaleTotal);
            this.Controls.Add(this.txtFishAccSalePrice);
            this.Controls.Add(this.lblDogAccSalePrice);
            this.Controls.Add(this.txtFishAccSaleQuantity);
            this.Controls.Add(this.lblDogAccSaleQuantity);
            this.Controls.Add(this.cboFishAccSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogAccSaleItem);
            this.Name = "Fish_Acc_Sale";
            this.Text = "Fish_Acc_Sale";
            this.Load += new System.EventHandler(this.Fish_Acc_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishAccSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFishAccSalePrice;
        private System.Windows.Forms.Label lblDogAccSalePrice;
        private System.Windows.Forms.TextBox txtFishAccSaleQuantity;
        private System.Windows.Forms.Label lblDogAccSaleQuantity;
        private System.Windows.Forms.ComboBox cboFishAccSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogAccSaleItem;
        private System.Windows.Forms.TextBox txtFishAccSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtFishAccSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtFishAccSaleTotal;
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
        private System.Windows.Forms.TextBox txtFishAccSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtFishAccSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.TextBox txtFishAccSaleFinalTotal;
    }
}