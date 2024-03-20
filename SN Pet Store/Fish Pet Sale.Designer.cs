namespace SN_Pet_Store
{
    partial class Fish_Pet_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fish_Pet_Sale));
            this.txtFishPetSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogPetCareSaleQuantity = new System.Windows.Forms.Label();
            this.txtFishPetSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogPetSalePrice = new System.Windows.Forms.Label();
            this.cboFishPetSaleItems = new System.Windows.Forms.ComboBox();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDogPetSaleItem = new System.Windows.Forms.Label();
            this.txtFishPetSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtFishPetSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtFishPetSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogPetSaleTotal = new System.Windows.Forms.Label();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.dgvFishPetSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbFishPetSale = new System.Windows.Forms.PictureBox();
            this.btnClearBoxes = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtFishPetSaleChangeDue = new System.Windows.Forms.TextBox();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtFishPetSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.txtFishPetSaleFinalTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishPetSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFishPetSale)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFishPetSaleQuantity
            // 
            this.txtFishPetSaleQuantity.Location = new System.Drawing.Point(288, 348);
            this.txtFishPetSaleQuantity.Name = "txtFishPetSaleQuantity";
            this.txtFishPetSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtFishPetSaleQuantity.TabIndex = 146;
            this.txtFishPetSaleQuantity.TextChanged += new System.EventHandler(this.txtFishPetSaleQuantity_TextChanged);
            // 
            // lblDogPetCareSaleQuantity
            // 
            this.lblDogPetCareSaleQuantity.AutoSize = true;
            this.lblDogPetCareSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetCareSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetCareSaleQuantity.Location = new System.Drawing.Point(34, 338);
            this.lblDogPetCareSaleQuantity.Name = "lblDogPetCareSaleQuantity";
            this.lblDogPetCareSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogPetCareSaleQuantity.TabIndex = 145;
            this.lblDogPetCareSaleQuantity.Text = "QUANTITY:";
            // 
            // txtFishPetSalePrice
            // 
            this.txtFishPetSalePrice.Location = new System.Drawing.Point(288, 267);
            this.txtFishPetSalePrice.Name = "txtFishPetSalePrice";
            this.txtFishPetSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtFishPetSalePrice.TabIndex = 144;
            // 
            // lblDogPetSalePrice
            // 
            this.lblDogPetSalePrice.AutoSize = true;
            this.lblDogPetSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetSalePrice.Location = new System.Drawing.Point(34, 256);
            this.lblDogPetSalePrice.Name = "lblDogPetSalePrice";
            this.lblDogPetSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetSalePrice.TabIndex = 143;
            this.lblDogPetSalePrice.Text = "PRICE:";
            // 
            // cboFishPetSaleItems
            // 
            this.cboFishPetSaleItems.FormattingEnabled = true;
            this.cboFishPetSaleItems.Items.AddRange(new object[] {
            "NEMO",
            "DORY",
            "BUBBLES",
            "JEWEL",
            "CAPTAIN",
            "ANGELA"});
            this.cboFishPetSaleItems.Location = new System.Drawing.Point(288, 175);
            this.cboFishPetSaleItems.Name = "cboFishPetSaleItems";
            this.cboFishPetSaleItems.Size = new System.Drawing.Size(200, 21);
            this.cboFishPetSaleItems.TabIndex = 142;
            this.cboFishPetSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboFishPetSaleItems_SelectedIndexChanged);
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(34, 82);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 141;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 140;
            // 
            // lblDogPetSaleItem
            // 
            this.lblDogPetSaleItem.AutoSize = true;
            this.lblDogPetSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetSaleItem.Location = new System.Drawing.Point(34, 166);
            this.lblDogPetSaleItem.Name = "lblDogPetSaleItem";
            this.lblDogPetSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogPetSaleItem.TabIndex = 139;
            this.lblDogPetSaleItem.Text = "SELECT ITEM:";
            // 
            // txtFishPetSaleAmountDue
            // 
            this.txtFishPetSaleAmountDue.AllowDrop = true;
            this.txtFishPetSaleAmountDue.Location = new System.Drawing.Point(288, 608);
            this.txtFishPetSaleAmountDue.Name = "txtFishPetSaleAmountDue";
            this.txtFishPetSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtFishPetSaleAmountDue.TabIndex = 152;
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(34, 597);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 151;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtFishPetSaleDiscount
            // 
            this.txtFishPetSaleDiscount.Location = new System.Drawing.Point(288, 526);
            this.txtFishPetSaleDiscount.Name = "txtFishPetSaleDiscount";
            this.txtFishPetSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtFishPetSaleDiscount.TabIndex = 150;
            this.txtFishPetSaleDiscount.TextChanged += new System.EventHandler(this.txtFishPetSaleDiscount_TextChanged);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(34, 515);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 149;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtFishPetSaleTotal
            // 
            this.txtFishPetSaleTotal.Location = new System.Drawing.Point(288, 437);
            this.txtFishPetSaleTotal.Name = "txtFishPetSaleTotal";
            this.txtFishPetSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtFishPetSaleTotal.TabIndex = 148;
            // 
            // lblDogPetSaleTotal
            // 
            this.lblDogPetSaleTotal.AutoSize = true;
            this.lblDogPetSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogPetSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogPetSaleTotal.Location = new System.Drawing.Point(34, 427);
            this.lblDogPetSaleTotal.Name = "lblDogPetSaleTotal";
            this.lblDogPetSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogPetSaleTotal.TabIndex = 147;
            this.lblDogPetSaleTotal.Text = "TOTAL:";
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(690, 140);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 155;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.btnClearGrid_Click);
            // 
            // dgvFishPetSale
            // 
            this.dgvFishPetSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFishPetSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvFishPetSale.Location = new System.Drawing.Point(849, 93);
            this.dgvFishPetSale.Name = "dgvFishPetSale";
            this.dgvFishPetSale.Size = new System.Drawing.Size(491, 365);
            this.dgvFishPetSale.TabIndex = 154;
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
            this.btnBackToLogin.Location = new System.Drawing.Point(690, 93);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 153;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.IndianRed;
            this.btnBrowse.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(772, 472);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(109, 42);
            this.btnBrowse.TabIndex = 165;
            this.btnBrowse.Text = "BROWSE";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbFishPetSale
            // 
            this.pbFishPetSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pbFishPetSale.Location = new System.Drawing.Point(534, 473);
            this.pbFishPetSale.Name = "pbFishPetSale";
            this.pbFishPetSale.Size = new System.Drawing.Size(232, 156);
            this.pbFishPetSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFishPetSale.TabIndex = 164;
            this.pbFishPetSale.TabStop = false;
            // 
            // btnClearBoxes
            // 
            this.btnClearBoxes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClearBoxes.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBoxes.Location = new System.Drawing.Point(690, 391);
            this.btnClearBoxes.Name = "btnClearBoxes";
            this.btnClearBoxes.Size = new System.Drawing.Size(134, 67);
            this.btnClearBoxes.TabIndex = 163;
            this.btnClearBoxes.Text = "CLEAR BOXES";
            this.btnClearBoxes.UseVisualStyleBackColor = false;
            this.btnClearBoxes.Click += new System.EventHandler(this.btnClearBoxes_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(534, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 162;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(534, 391);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 67);
            this.btnClearFields.TabIndex = 161;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(690, 345);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 160;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtFishPetSaleChangeDue
            // 
            this.txtFishPetSaleChangeDue.Location = new System.Drawing.Point(1219, 608);
            this.txtFishPetSaleChangeDue.Name = "txtFishPetSaleChangeDue";
            this.txtFishPetSaleChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtFishPetSaleChangeDue.TabIndex = 171;
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(994, 482);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 170;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.btnFinalTotal_Click);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(996, 597);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 169;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtFishPetSaleAmountPaid
            // 
            this.txtFishPetSaleAmountPaid.Location = new System.Drawing.Point(1219, 552);
            this.txtFishPetSaleAmountPaid.Name = "txtFishPetSaleAmountPaid";
            this.txtFishPetSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtFishPetSaleAmountPaid.TabIndex = 168;
            this.txtFishPetSaleAmountPaid.TextChanged += new System.EventHandler(this.txtFishPetSaleAmountPaid_TextChanged);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(996, 541);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 167;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            // 
            // txtFishPetSaleFinalTotal
            // 
            this.txtFishPetSaleFinalTotal.Location = new System.Drawing.Point(1219, 497);
            this.txtFishPetSaleFinalTotal.Name = "txtFishPetSaleFinalTotal";
            this.txtFishPetSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtFishPetSaleFinalTotal.TabIndex = 166;
            // 
            // Fish_Pet_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.txtFishPetSaleChangeDue);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtFishPetSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.txtFishPetSaleFinalTotal);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pbFishPetSale);
            this.Controls.Add(this.btnClearBoxes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.dgvFishPetSale);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.txtFishPetSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtFishPetSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtFishPetSaleTotal);
            this.Controls.Add(this.lblDogPetSaleTotal);
            this.Controls.Add(this.txtFishPetSaleQuantity);
            this.Controls.Add(this.lblDogPetCareSaleQuantity);
            this.Controls.Add(this.txtFishPetSalePrice);
            this.Controls.Add(this.lblDogPetSalePrice);
            this.Controls.Add(this.cboFishPetSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogPetSaleItem);
            this.Name = "Fish_Pet_Sale";
            this.Text = "Fish_Pet_Sale";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFishPetSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFishPetSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFishPetSaleQuantity;
        private System.Windows.Forms.Label lblDogPetCareSaleQuantity;
        private System.Windows.Forms.TextBox txtFishPetSalePrice;
        private System.Windows.Forms.Label lblDogPetSalePrice;
        private System.Windows.Forms.ComboBox cboFishPetSaleItems;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDogPetSaleItem;
        private System.Windows.Forms.TextBox txtFishPetSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtFishPetSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtFishPetSaleTotal;
        private System.Windows.Forms.Label lblDogPetSaleTotal;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.DataGridView dgvFishPetSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbFishPetSale;
        private System.Windows.Forms.Button btnClearBoxes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtFishPetSaleChangeDue;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtFishPetSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.TextBox txtFishPetSaleFinalTotal;
    }
}