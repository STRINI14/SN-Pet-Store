namespace SN_Pet_Store
{
    partial class Dog_Pet_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dog_Pet_Sale));
            this.cboDogPetSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogPetSaleItem = new System.Windows.Forms.Label();
            this.txtDogPetSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogPetSaleTotal = new System.Windows.Forms.Label();
            this.txtDogPetSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogPetSalePrice = new System.Windows.Forms.Label();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.txtDogPetSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtDogPetSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.btnClearBoxes = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtDogPetSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtDogPetSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.txtDogPetSaleFinalTotal = new System.Windows.Forms.TextBox();
            this.dgvDogPetSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.pbDogPetSale = new System.Windows.Forms.PictureBox();
            this.txtDogPetSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSaleQuantity = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogPetSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogPetSale)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDogPetSaleItems
            // 
            this.cboDogPetSaleItems.FormattingEnabled = true;
            this.cboDogPetSaleItems.Items.AddRange(new object[] {
            "JOJO",
            "RASCAL",
            "ROCKY",
            "MILO"});
            this.cboDogPetSaleItems.Location = new System.Drawing.Point(289, 169);
            this.cboDogPetSaleItems.Name = "cboDogPetSaleItems";
            this.cboDogPetSaleItems.Size = new System.Drawing.Size(200, 21);
            this.cboDogPetSaleItems.TabIndex = 41;
            this.cboDogPetSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboDogPetSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(35, 76);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 40;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(289, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // lblDogPetSaleItem
            // 
            this.lblDogPetSaleItem.AutoSize = true;
            this.lblDogPetSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetSaleItem.Location = new System.Drawing.Point(35, 160);
            this.lblDogPetSaleItem.Name = "lblDogPetSaleItem";
            this.lblDogPetSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogPetSaleItem.TabIndex = 38;
            this.lblDogPetSaleItem.Text = "SELECT ITEM:";
            // 
            // txtDogPetSaleTotal
            // 
            this.txtDogPetSaleTotal.Location = new System.Drawing.Point(289, 431);
            this.txtDogPetSaleTotal.Name = "txtDogPetSaleTotal";
            this.txtDogPetSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtDogPetSaleTotal.TabIndex = 49;
            this.txtDogPetSaleTotal.TextChanged += new System.EventHandler(this.txtDogPetSaleTotal_TextChanged);
            // 
            // lblDogPetSaleTotal
            // 
            this.lblDogPetSaleTotal.AutoSize = true;
            this.lblDogPetSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetSaleTotal.Location = new System.Drawing.Point(35, 421);
            this.lblDogPetSaleTotal.Name = "lblDogPetSaleTotal";
            this.lblDogPetSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetSaleTotal.TabIndex = 48;
            this.lblDogPetSaleTotal.Text = "TOTAL:";
            // 
            // txtDogPetSalePrice
            // 
            this.txtDogPetSalePrice.Location = new System.Drawing.Point(289, 261);
            this.txtDogPetSalePrice.Name = "txtDogPetSalePrice";
            this.txtDogPetSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtDogPetSalePrice.TabIndex = 47;
            this.txtDogPetSalePrice.TextChanged += new System.EventHandler(this.txtDogPetSalePrice_TextChanged);
            // 
            // lblDogPetSalePrice
            // 
            this.lblDogPetSalePrice.AutoSize = true;
            this.lblDogPetSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetSalePrice.Location = new System.Drawing.Point(35, 250);
            this.lblDogPetSalePrice.Name = "lblDogPetSalePrice";
            this.lblDogPetSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetSalePrice.TabIndex = 46;
            this.lblDogPetSalePrice.Text = "PRICE:";
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(702, 76);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 60;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // txtDogPetSaleAmountDue
            // 
            this.txtDogPetSaleAmountDue.Location = new System.Drawing.Point(289, 605);
            this.txtDogPetSaleAmountDue.Name = "txtDogPetSaleAmountDue";
            this.txtDogPetSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtDogPetSaleAmountDue.TabIndex = 105;
            this.txtDogPetSaleAmountDue.TextChanged += new System.EventHandler(this.txtDogPetSaleAmountDue_TextChanged);
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(35, 594);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 104;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtDogPetSaleDiscount
            // 
            this.txtDogPetSaleDiscount.Location = new System.Drawing.Point(289, 523);
            this.txtDogPetSaleDiscount.Name = "txtDogPetSaleDiscount";
            this.txtDogPetSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtDogPetSaleDiscount.TabIndex = 103;
            this.txtDogPetSaleDiscount.TextChanged += new System.EventHandler(this.txtDogPetSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(35, 512);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 102;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // btnClearBoxes
            // 
            this.btnClearBoxes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClearBoxes.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBoxes.Location = new System.Drawing.Point(677, 385);
            this.btnClearBoxes.Name = "btnClearBoxes";
            this.btnClearBoxes.Size = new System.Drawing.Size(134, 67);
            this.btnClearBoxes.TabIndex = 115;
            this.btnClearBoxes.Text = "CLEAR BOXES";
            this.btnClearBoxes.UseVisualStyleBackColor = false;
            this.btnClearBoxes.Click += new System.EventHandler(this.btnClearBoxes_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(519, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 114;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(519, 385);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 67);
            this.btnClearFields.TabIndex = 113;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(677, 332);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 112;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtDogPetSaleChangeDue
            // 
            this.txtDogPetSaleChangeDue.Location = new System.Drawing.Point(1122, 597);
            this.txtDogPetSaleChangeDue.Name = "txtDogPetSaleChangeDue";
            this.txtDogPetSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtDogPetSaleChangeDue.TabIndex = 111;
            this.txtDogPetSaleChangeDue.TextChanged += new System.EventHandler(this.txtDogPetSaleChangeDue_TextChanged);
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(897, 471);
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
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(899, 586);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 109;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtDogPetSaleAmountPaid
            // 
            this.txtDogPetSaleAmountPaid.Location = new System.Drawing.Point(1122, 541);
            this.txtDogPetSaleAmountPaid.Name = "txtDogPetSaleAmountPaid";
            this.txtDogPetSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtDogPetSaleAmountPaid.TabIndex = 108;
            this.txtDogPetSaleAmountPaid.TextChanged += new System.EventHandler(this.txtDogPetSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(899, 530);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 107;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // txtDogPetSaleFinalTotal
            // 
            this.txtDogPetSaleFinalTotal.Location = new System.Drawing.Point(1122, 486);
            this.txtDogPetSaleFinalTotal.Name = "txtDogPetSaleFinalTotal";
            this.txtDogPetSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtDogPetSaleFinalTotal.TabIndex = 106;
            // 
            // dgvDogPetSale
            // 
            this.dgvDogPetSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogPetSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvDogPetSale.Location = new System.Drawing.Point(861, 76);
            this.dgvDogPetSale.Name = "dgvDogPetSale";
            this.dgvDogPetSale.Size = new System.Drawing.Size(491, 365);
            this.dgvDogPetSale.TabIndex = 116;
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
            this.btnClearGrid.Location = new System.Drawing.Point(702, 123);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 117;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // pbDogPetSale
            // 
            this.pbDogPetSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pbDogPetSale.Location = new System.Drawing.Point(519, 471);
            this.pbDogPetSale.Name = "pbDogPetSale";
            this.pbDogPetSale.Size = new System.Drawing.Size(232, 156);
            this.pbDogPetSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDogPetSale.TabIndex = 118;
            this.pbDogPetSale.TabStop = false;
            // 
            // txtDogPetSaleQuantity
            // 
            this.txtDogPetSaleQuantity.Location = new System.Drawing.Point(289, 342);
            this.txtDogPetSaleQuantity.Name = "txtDogPetSaleQuantity";
            this.txtDogPetSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtDogPetSaleQuantity.TabIndex = 120;
            this.txtDogPetSaleQuantity.TextChanged += new System.EventHandler(this.txtDogPetSaleQuantity_TextChanged);
            // 
            // lblDogPetCareSaleQuantity
            // 
            this.lblDogPetCareSaleQuantity.AutoSize = true;
            this.lblDogPetCareSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleQuantity.Location = new System.Drawing.Point(35, 332);
            this.lblDogPetCareSaleQuantity.Name = "lblDogPetCareSaleQuantity";
            this.lblDogPetCareSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogPetCareSaleQuantity.TabIndex = 119;
            this.lblDogPetCareSaleQuantity.Text = "QUANTITY:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.IndianRed;
            this.btnBrowse.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(757, 471);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(109, 42);
            this.btnBrowse.TabIndex = 121;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // Dog_Pet_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDogPetSaleQuantity);
            this.Controls.Add(this.lblDogPetCareSaleQuantity);
            this.Controls.Add(this.pbDogPetSale);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.dgvDogPetSale);
            this.Controls.Add(this.btnClearBoxes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtDogPetSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtDogPetSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.txtDogPetSaleFinalTotal);
            this.Controls.Add(this.txtDogPetSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtDogPetSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.txtDogPetSaleTotal);
            this.Controls.Add(this.lblDogPetSaleTotal);
            this.Controls.Add(this.txtDogPetSalePrice);
            this.Controls.Add(this.lblDogPetSalePrice);
            this.Controls.Add(this.cboDogPetSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogPetSaleItem);
            this.Name = "Dog_Pet_Sale";
            this.Text = "Dog_Pet_Sale";
            this.Load += new System.EventHandler(this.Dog_Pet_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogPetSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogPetSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDogPetSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogPetSaleItem;
        private System.Windows.Forms.TextBox txtDogPetSaleTotal;
        private System.Windows.Forms.Label lblDogPetSaleTotal;
        private System.Windows.Forms.TextBox txtDogPetSalePrice;
        private System.Windows.Forms.Label lblDogPetSalePrice;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.TextBox txtDogPetSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtDogPetSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.Button btnClearBoxes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtDogPetSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtDogPetSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.TextBox txtDogPetSaleFinalTotal;
        private System.Windows.Forms.DataGridView dgvDogPetSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.PictureBox pbDogPetSale;
        private System.Windows.Forms.TextBox txtDogPetSaleQuantity;
        private System.Windows.Forms.Label lblDogPetCareSaleQuantity;
        private System.Windows.Forms.Button btnBrowse;

    }
}