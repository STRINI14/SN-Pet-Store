namespace SN_Pet_Store
{
    partial class Bird_Pet_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bird_Pet_Sale));
            this.txtBirdPetSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSaleQuantity = new System.Windows.Forms.Label();
            this.txtBirdPetSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogPetSalePrice = new System.Windows.Forms.Label();
            this.cboBirdPetSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogPetSaleItem = new System.Windows.Forms.Label();
            this.txtBirdPetSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtBirdPetSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtBirdPetSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogPetSaleTotal = new System.Windows.Forms.Label();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.dgvBirdPetSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.txtBirdPetSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtBirdPetSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.txtBirdPetSaleFinalTotal = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbBirdPetSale = new System.Windows.Forms.PictureBox();
            this.btnClearBoxes = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirdPetSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBirdPetSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBirdPetSaleQuantity
            // 
            this.txtBirdPetSaleQuantity.Location = new System.Drawing.Point(304, 349);
            this.txtBirdPetSaleQuantity.Name = "txtBirdPetSaleQuantity";
            this.txtBirdPetSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtBirdPetSaleQuantity.TabIndex = 138;
            this.txtBirdPetSaleQuantity.TextChanged += new System.EventHandler(this.txtBirdPetSaleQuantity_TextChanged);
            // 
            // lblDogPetCareSaleQuantity
            // 
            this.lblDogPetCareSaleQuantity.AutoSize = true;
            this.lblDogPetCareSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleQuantity.Location = new System.Drawing.Point(50, 339);
            this.lblDogPetCareSaleQuantity.Name = "lblDogPetCareSaleQuantity";
            this.lblDogPetCareSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogPetCareSaleQuantity.TabIndex = 137;
            this.lblDogPetCareSaleQuantity.Text = "QUANTITY:";
            // 
            // txtBirdPetSalePrice
            // 
            this.txtBirdPetSalePrice.Location = new System.Drawing.Point(304, 268);
            this.txtBirdPetSalePrice.Name = "txtBirdPetSalePrice";
            this.txtBirdPetSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtBirdPetSalePrice.TabIndex = 136;
            // 
            // lblDogPetSalePrice
            // 
            this.lblDogPetSalePrice.AutoSize = true;
            this.lblDogPetSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetSalePrice.Location = new System.Drawing.Point(50, 257);
            this.lblDogPetSalePrice.Name = "lblDogPetSalePrice";
            this.lblDogPetSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetSalePrice.TabIndex = 135;
            this.lblDogPetSalePrice.Text = "PRICE:";
            // 
            // cboBirdPetSaleItems
            // 
            this.cboBirdPetSaleItems.FormattingEnabled = true;
            this.cboBirdPetSaleItems.Items.AddRange(new object[] {
            "CHARLIE",
            "COCO",
            "BUDDY",
            "DAISY",
            "PEPPER",
            "TWEETY"});
            this.cboBirdPetSaleItems.Location = new System.Drawing.Point(304, 176);
            this.cboBirdPetSaleItems.Name = "cboBirdPetSaleItems";
            this.cboBirdPetSaleItems.Size = new System.Drawing.Size(200, 21);
            this.cboBirdPetSaleItems.TabIndex = 134;
            this.cboBirdPetSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboBirdPetSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(50, 83);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 133;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(304, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 132;
            // 
            // lblDogPetSaleItem
            // 
            this.lblDogPetSaleItem.AutoSize = true;
            this.lblDogPetSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetSaleItem.Location = new System.Drawing.Point(50, 167);
            this.lblDogPetSaleItem.Name = "lblDogPetSaleItem";
            this.lblDogPetSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogPetSaleItem.TabIndex = 131;
            this.lblDogPetSaleItem.Text = "SELECT ITEM:";
            // 
            // txtBirdPetSaleAmountDue
            // 
            this.txtBirdPetSaleAmountDue.AllowDrop = true;
            this.txtBirdPetSaleAmountDue.Location = new System.Drawing.Point(304, 615);
            this.txtBirdPetSaleAmountDue.Name = "txtBirdPetSaleAmountDue";
            this.txtBirdPetSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtBirdPetSaleAmountDue.TabIndex = 144;
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(50, 604);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 143;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtBirdPetSaleDiscount
            // 
            this.txtBirdPetSaleDiscount.Location = new System.Drawing.Point(304, 533);
            this.txtBirdPetSaleDiscount.Name = "txtBirdPetSaleDiscount";
            this.txtBirdPetSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtBirdPetSaleDiscount.TabIndex = 142;
            this.txtBirdPetSaleDiscount.TextChanged += new System.EventHandler(this.txtBirdPetSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(50, 522);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 141;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtBirdPetSaleTotal
            // 
            this.txtBirdPetSaleTotal.Location = new System.Drawing.Point(304, 444);
            this.txtBirdPetSaleTotal.Name = "txtBirdPetSaleTotal";
            this.txtBirdPetSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtBirdPetSaleTotal.TabIndex = 140;
            this.txtBirdPetSaleTotal.TextChanged += new System.EventHandler(this.txtBirdPetSaleTotal_TextChanged);
            // 
            // lblDogPetSaleTotal
            // 
            this.lblDogPetSaleTotal.AutoSize = true;
            this.lblDogPetSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetSaleTotal.Location = new System.Drawing.Point(50, 434);
            this.lblDogPetSaleTotal.Name = "lblDogPetSaleTotal";
            this.lblDogPetSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetSaleTotal.TabIndex = 139;
            this.lblDogPetSaleTotal.Text = "TOTAL:";
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(690, 141);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 147;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // dgvBirdPetSale
            // 
            this.dgvBirdPetSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBirdPetSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvBirdPetSale.Location = new System.Drawing.Point(849, 94);
            this.dgvBirdPetSale.Name = "dgvBirdPetSale";
            this.dgvBirdPetSale.Size = new System.Drawing.Size(491, 365);
            this.dgvBirdPetSale.TabIndex = 146;
            this.dgvBirdPetSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatPetSale_CellContentClick);
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
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(690, 94);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 145;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // txtBirdPetSaleChangeDue
            // 
            this.txtBirdPetSaleChangeDue.Location = new System.Drawing.Point(1219, 600);
            this.txtBirdPetSaleChangeDue.Name = "txtBirdPetSaleChangeDue";
            this.txtBirdPetSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtBirdPetSaleChangeDue.TabIndex = 153;
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(994, 474);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 152;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(996, 589);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 151;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtBirdPetSaleAmountPaid
            // 
            this.txtBirdPetSaleAmountPaid.Location = new System.Drawing.Point(1219, 544);
            this.txtBirdPetSaleAmountPaid.Name = "txtBirdPetSaleAmountPaid";
            this.txtBirdPetSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtBirdPetSaleAmountPaid.TabIndex = 150;
            this.txtBirdPetSaleAmountPaid.TextChanged += new System.EventHandler(this.txtBirdPetSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(996, 533);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 149;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // txtBirdPetSaleFinalTotal
            // 
            this.txtBirdPetSaleFinalTotal.Location = new System.Drawing.Point(1219, 489);
            this.txtBirdPetSaleFinalTotal.Name = "txtBirdPetSaleFinalTotal";
            this.txtBirdPetSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtBirdPetSaleFinalTotal.TabIndex = 148;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.IndianRed;
            this.btnBrowse.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(779, 473);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(109, 42);
            this.btnBrowse.TabIndex = 159;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbBirdPetSale
            // 
            this.pbBirdPetSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pbBirdPetSale.Location = new System.Drawing.Point(541, 474);
            this.pbBirdPetSale.Name = "pbBirdPetSale";
            this.pbBirdPetSale.Size = new System.Drawing.Size(232, 156);
            this.pbBirdPetSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBirdPetSale.TabIndex = 158;
            this.pbBirdPetSale.TabStop = false;
            // 
            // btnClearBoxes
            // 
            this.btnClearBoxes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClearBoxes.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBoxes.Location = new System.Drawing.Point(697, 392);
            this.btnClearBoxes.Name = "btnClearBoxes";
            this.btnClearBoxes.Size = new System.Drawing.Size(134, 67);
            this.btnClearBoxes.TabIndex = 157;
            this.btnClearBoxes.Text = "CLEAR BOXES";
            this.btnClearBoxes.UseVisualStyleBackColor = false;
            this.btnClearBoxes.Click += new System.EventHandler(this.btnClearBoxes_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(541, 346);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 156;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(541, 392);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 67);
            this.btnClearFields.TabIndex = 155;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(697, 346);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 154;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Bird_Pet_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbBirdPetSale);
            this.Controls.Add(this.btnClearBoxes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtBirdPetSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtBirdPetSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.txtBirdPetSaleFinalTotal);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.dgvBirdPetSale);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.txtBirdPetSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtBirdPetSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtBirdPetSaleTotal);
            this.Controls.Add(this.lblDogPetSaleTotal);
            this.Controls.Add(this.txtBirdPetSaleQuantity);
            this.Controls.Add(this.lblDogPetCareSaleQuantity);
            this.Controls.Add(this.txtBirdPetSalePrice);
            this.Controls.Add(this.lblDogPetSalePrice);
            this.Controls.Add(this.cboBirdPetSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogPetSaleItem);
            this.Name = "Bird_Pet_Sale";
            this.Text = "Bird_Pet_Sale";
            this.Load += new System.EventHandler(this.Bird_Pet_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirdPetSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBirdPetSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirdPetSaleQuantity;
        private System.Windows.Forms.Label lblDogPetCareSaleQuantity;
        private System.Windows.Forms.TextBox txtBirdPetSalePrice;
        private System.Windows.Forms.Label lblDogPetSalePrice;
        private System.Windows.Forms.ComboBox cboBirdPetSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogPetSaleItem;
        private System.Windows.Forms.TextBox txtBirdPetSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtBirdPetSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtBirdPetSaleTotal;
        private System.Windows.Forms.Label lblDogPetSaleTotal;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.DataGridView dgvBirdPetSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.TextBox txtBirdPetSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtBirdPetSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.TextBox txtBirdPetSaleFinalTotal;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbBirdPetSale;
        private System.Windows.Forms.Button btnClearBoxes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
    }
}