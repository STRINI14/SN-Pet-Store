namespace SN_Pet_Store
{
    partial class Cat_Food_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cat_Food_Sale));
            this.txtCatFoodSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogFoodSalePrice = new System.Windows.Forms.Label();
            this.txtCatFoodSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleQuantity = new System.Windows.Forms.Label();
            this.cboCatFoodSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogFoodSaleItem = new System.Windows.Forms.Label();
            this.txtCatFoodSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtCatFoodSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtCatFoodSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleTotal = new System.Windows.Forms.Label();
            this.dgvCatFoodSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearBoxes = new System.Windows.Forms.Button();
            this.txtCatFoodSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtCatFoodSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtCatFoodSaleFinalTotal = new System.Windows.Forms.TextBox();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatFoodSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCatFoodSalePrice
            // 
            this.txtCatFoodSalePrice.Location = new System.Drawing.Point(296, 273);
            this.txtCatFoodSalePrice.Name = "txtCatFoodSalePrice";
            this.txtCatFoodSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtCatFoodSalePrice.TabIndex = 31;
            this.txtCatFoodSalePrice.TextChanged += new System.EventHandler(this.txtCatFoodSalePrice_TextChanged);
            // 
            // lblDogFoodSalePrice
            // 
            this.lblDogFoodSalePrice.AutoSize = true;
            this.lblDogFoodSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSalePrice.Location = new System.Drawing.Point(42, 262);
            this.lblDogFoodSalePrice.Name = "lblDogFoodSalePrice";
            this.lblDogFoodSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogFoodSalePrice.TabIndex = 30;
            this.lblDogFoodSalePrice.Text = "PRICE:";
            // 
            // txtCatFoodSaleQuantity
            // 
            this.txtCatFoodSaleQuantity.Location = new System.Drawing.Point(296, 360);
            this.txtCatFoodSaleQuantity.Name = "txtCatFoodSaleQuantity";
            this.txtCatFoodSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtCatFoodSaleQuantity.TabIndex = 29;
            this.txtCatFoodSaleQuantity.TextChanged += new System.EventHandler(this.txtCatFoodSaleQuantity_TextChanged);
            // 
            // lblDogFoodSaleQuantity
            // 
            this.lblDogFoodSaleQuantity.AutoSize = true;
            this.lblDogFoodSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleQuantity.Location = new System.Drawing.Point(42, 350);
            this.lblDogFoodSaleQuantity.Name = "lblDogFoodSaleQuantity";
            this.lblDogFoodSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleQuantity.TabIndex = 28;
            this.lblDogFoodSaleQuantity.Text = "QUANTITY:";
            // 
            // cboCatFoodSaleItems
            // 
            this.cboCatFoodSaleItems.FormattingEnabled = true;
            this.cboCatFoodSaleItems.Items.AddRange(new object[] {
            "FELINE CUISINE ADULT SALMON AND RICE",
            "CATMOR ADULT FOOD TUNA",
            "CATMOR ADULT FOOD CHICKEN 2KG",
            "CATMOR ADULT FOOD CHICKEN 4KG",
            "CATMOR ADULT FOOD SALMON",
            "WHISKAS CHICKEN FLAVOURED GRAVY",
            "CATMOR GRAVY CHUNKS BEEF",
            "WHISKAS ONE YEAR FOOD MEAT PLATTER",
            "WHISKAS GRAVY POUCH",
            "WHISKAS CHICKEN AND TURKEY",
            "PAMPER CIG TURKEY",
            "KITTEN CHICKEN FOR SENIORS",
            "PAMPER CIG BEEF AND LIVER",
            "PAMPER MINCE AND STEAK",
            "CATMOR ADULT CHICKEN POUCH"});
            this.cboCatFoodSaleItems.Location = new System.Drawing.Point(296, 179);
            this.cboCatFoodSaleItems.Name = "cboCatFoodSaleItems";
            this.cboCatFoodSaleItems.Size = new System.Drawing.Size(354, 21);
            this.cboCatFoodSaleItems.TabIndex = 27;
            this.cboCatFoodSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboCatFoodSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(42, 86);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 26;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(296, 97);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // lblDogFoodSaleItem
            // 
            this.lblDogFoodSaleItem.AutoSize = true;
            this.lblDogFoodSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleItem.Location = new System.Drawing.Point(42, 170);
            this.lblDogFoodSaleItem.Name = "lblDogFoodSaleItem";
            this.lblDogFoodSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleItem.TabIndex = 24;
            this.lblDogFoodSaleItem.Text = "SELECT ITEM:";
            // 
            // txtCatFoodSaleAmountDue
            // 
            this.txtCatFoodSaleAmountDue.Location = new System.Drawing.Point(296, 629);
            this.txtCatFoodSaleAmountDue.Name = "txtCatFoodSaleAmountDue";
            this.txtCatFoodSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtCatFoodSaleAmountDue.TabIndex = 76;
            this.txtCatFoodSaleAmountDue.TextChanged += new System.EventHandler(this.txtCatFoodSaleAmountDue_TextChanged);
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(42, 618);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 75;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtCatFoodSaleDiscount
            // 
            this.txtCatFoodSaleDiscount.Location = new System.Drawing.Point(296, 547);
            this.txtCatFoodSaleDiscount.Name = "txtCatFoodSaleDiscount";
            this.txtCatFoodSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtCatFoodSaleDiscount.TabIndex = 74;
            this.txtCatFoodSaleDiscount.TextChanged += new System.EventHandler(this.txtCatFoodSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(42, 536);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 73;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtCatFoodSaleTotal
            // 
            this.txtCatFoodSaleTotal.Location = new System.Drawing.Point(296, 460);
            this.txtCatFoodSaleTotal.Name = "txtCatFoodSaleTotal";
            this.txtCatFoodSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtCatFoodSaleTotal.TabIndex = 72;
            this.txtCatFoodSaleTotal.TextChanged += new System.EventHandler(this.txtCatFoodSaleTotal_TextChanged);
            // 
            // lblDogFoodSaleTotal
            // 
            this.lblDogFoodSaleTotal.AutoSize = true;
            this.lblDogFoodSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleTotal.Location = new System.Drawing.Point(42, 450);
            this.lblDogFoodSaleTotal.Name = "lblDogFoodSaleTotal";
            this.lblDogFoodSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogFoodSaleTotal.TabIndex = 71;
            this.lblDogFoodSaleTotal.Text = "TOTAL:";
            // 
            // dgvCatFoodSale
            // 
            this.dgvCatFoodSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatFoodSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvCatFoodSale.Location = new System.Drawing.Point(859, 97);
            this.dgvCatFoodSale.Name = "dgvCatFoodSale";
            this.dgvCatFoodSale.Size = new System.Drawing.Size(491, 381);
            this.dgvCatFoodSale.TabIndex = 77;
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
            this.btnClearBoxes.Location = new System.Drawing.Point(711, 555);
            this.btnClearBoxes.Name = "btnClearBoxes";
            this.btnClearBoxes.Size = new System.Drawing.Size(134, 59);
            this.btnClearBoxes.TabIndex = 87;
            this.btnClearBoxes.Text = "CLEAR BOXES";
            this.btnClearBoxes.UseVisualStyleBackColor = false;
            this.btnClearBoxes.Click += new System.EventHandler(this.btnClearBoxes_Click);
            // 
            // txtCatFoodSaleChangeDue
            // 
            this.txtCatFoodSaleChangeDue.Location = new System.Drawing.Point(1084, 622);
            this.txtCatFoodSaleChangeDue.Name = "txtCatFoodSaleChangeDue";
            this.txtCatFoodSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtCatFoodSaleChangeDue.TabIndex = 86;
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(859, 496);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 85;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(861, 611);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 84;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtCatFoodSaleAmountPaid
            // 
            this.txtCatFoodSaleAmountPaid.Location = new System.Drawing.Point(1084, 566);
            this.txtCatFoodSaleAmountPaid.Name = "txtCatFoodSaleAmountPaid";
            this.txtCatFoodSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtCatFoodSaleAmountPaid.TabIndex = 83;
            this.txtCatFoodSaleAmountPaid.TextChanged += new System.EventHandler(this.txtCatFoodSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(861, 555);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 82;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(554, 497);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 81;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(554, 555);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 59);
            this.btnClearFields.TabIndex = 80;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(711, 497);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 79;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtCatFoodSaleFinalTotal
            // 
            this.txtCatFoodSaleFinalTotal.Location = new System.Drawing.Point(1084, 511);
            this.txtCatFoodSaleFinalTotal.Name = "txtCatFoodSaleFinalTotal";
            this.txtCatFoodSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtCatFoodSaleFinalTotal.TabIndex = 78;
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(692, 144);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 89;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(692, 97);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 88;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // Cat_Food_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnClearBoxes);
            this.Controls.Add(this.txtCatFoodSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtCatFoodSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtCatFoodSaleFinalTotal);
            this.Controls.Add(this.dgvCatFoodSale);
            this.Controls.Add(this.txtCatFoodSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtCatFoodSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtCatFoodSaleTotal);
            this.Controls.Add(this.lblDogFoodSaleTotal);
            this.Controls.Add(this.txtCatFoodSalePrice);
            this.Controls.Add(this.lblDogFoodSalePrice);
            this.Controls.Add(this.txtCatFoodSaleQuantity);
            this.Controls.Add(this.lblDogFoodSaleQuantity);
            this.Controls.Add(this.cboCatFoodSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogFoodSaleItem);
            this.Name = "Cat_Food_Sale";
            this.Text = "Cat_Food_Sale";
            this.Load += new System.EventHandler(this.Cat_Food_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatFoodSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCatFoodSalePrice;
        private System.Windows.Forms.Label lblDogFoodSalePrice;
        private System.Windows.Forms.TextBox txtCatFoodSaleQuantity;
        private System.Windows.Forms.Label lblDogFoodSaleQuantity;
        private System.Windows.Forms.ComboBox cboCatFoodSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogFoodSaleItem;
        private System.Windows.Forms.TextBox txtCatFoodSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtCatFoodSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtCatFoodSaleTotal;
        private System.Windows.Forms.Label lblDogFoodSaleTotal;
        private System.Windows.Forms.DataGridView dgvCatFoodSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnClearBoxes;
        private System.Windows.Forms.TextBox txtCatFoodSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtCatFoodSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtCatFoodSaleFinalTotal;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnBackToLogin;
    }
}