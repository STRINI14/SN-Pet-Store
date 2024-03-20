namespace SN_Pet_Store
{
    partial class Dog_Food_Sale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dog_Food_Sale));
            this.lblDogFoodSaleItem = new System.Windows.Forms.Label();
            this.lblDogFoodSaleDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboDogFoodSaleItems = new System.Windows.Forms.ComboBox();
            this.txtDogFoodSaleQuantity = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleQuantity = new System.Windows.Forms.Label();
            this.txtDogFoodSalePrice = new System.Windows.Forms.TextBox();
            this.lblDogFoodSalePrice = new System.Windows.Forms.Label();
            this.txtDogFoodSaleFinalTotal = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDogFoodSaleChangeDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleChangeDue = new System.Windows.Forms.Label();
            this.txtDogFoodSaleAmountPaid = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountPaid = new System.Windows.Forms.Label();
            this.btnFinalTotal = new System.Windows.Forms.Button();
            this.dgvDogFoodSale = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDogFoodSaleAmountDue = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleAmountDue = new System.Windows.Forms.Label();
            this.txtDogFoodSaleDiscount = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleDiscount = new System.Windows.Forms.Label();
            this.txtDogFoodSaleTotal = new System.Windows.Forms.TextBox();
            this.lblDogFoodSaleTotal = new System.Windows.Forms.Label();
            this.txtDogFoodSailChangeDue = new System.Windows.Forms.TextBox();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnClearGrid = new System.Windows.Forms.Button();
            this.btnClearBoxes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogFoodSale)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDogFoodSaleItem
            // 
            this.lblDogFoodSaleItem.AutoSize = true;
            this.lblDogFoodSaleItem.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleItem.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleItem.Location = new System.Drawing.Point(12, 156);
            this.lblDogFoodSaleItem.Name = "lblDogFoodSaleItem";
            this.lblDogFoodSaleItem.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleItem.TabIndex = 13;
            this.lblDogFoodSaleItem.Text = "SELECT ITEM:";
            // 
            // lblDogFoodSaleDate
            // 
            this.lblDogFoodSaleDate.AutoSize = true;
            this.lblDogFoodSaleDate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDate.Location = new System.Drawing.Point(12, 72);
            this.lblDogFoodSaleDate.Name = "lblDogFoodSaleDate";
            this.lblDogFoodSaleDate.Size = new System.Drawing.Size(222, 31);
            this.lblDogFoodSaleDate.TabIndex = 18;
            this.lblDogFoodSaleDate.Text = "DATE ENTERED:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(266, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // cboDogFoodSaleItems
            // 
            this.cboDogFoodSaleItems.FormattingEnabled = true;
            this.cboDogFoodSaleItems.Items.AddRange(new object[] {
            "OL ROY LAMB CHUNKS 8KG",
            "HUSKY BISCUITS",
            "MARLTONS BACON FLAVOURED STRIPS 120G",
            "MARLTONS BACON FLAVOURED ROLLS 120G",
            "BEENO XL BISCUIT IN GRAVY",
            "BOBTAIL MULTI FLAVOURED MULTIPACK",
            "BOBTAIL CHICKEN & RICE FLAVOUR 8KG FOOD",
            "BOSS HUNGER BUSTER CAN BEEF 820G",
            "BOBTAIL CHICKEN FLAVOUR 8KG FOOD",
            "BOBTAIL LAMB FLAVOUR 8KG FOOD",
            "BOBTAIL GRAVY WITH CHUNKS CHICKEN 85G",
            "BOBTAIL GRAVY WITH CHUNKS LAMB 85G",
            "HUSKY CAN STEAK 775G",
            "HUSKY CAN CHICKEN 775G",
            "PEDIGREE GRAVY WITH CHUNKS STEAK 85G",
            "PEDIGREE GRAVY WITH CHUNKS CHICKEN 85G",
            "THE HILLS LAMB 10KG DOG FOOD"});
            this.cboDogFoodSaleItems.Location = new System.Drawing.Point(266, 165);
            this.cboDogFoodSaleItems.Name = "cboDogFoodSaleItems";
            this.cboDogFoodSaleItems.Size = new System.Drawing.Size(354, 21);
            this.cboDogFoodSaleItems.TabIndex = 19;
            this.cboDogFoodSaleItems.SelectedIndexChanged += new System.EventHandler(this.cboDogFoodSaleItems_SelectedIndexChanged);
            // 
            // txtDogFoodSaleQuantity
            // 
            this.txtDogFoodSaleQuantity.Location = new System.Drawing.Point(266, 346);
            this.txtDogFoodSaleQuantity.Name = "txtDogFoodSaleQuantity";
            this.txtDogFoodSaleQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtDogFoodSaleQuantity.TabIndex = 21;
            this.txtDogFoodSaleQuantity.TextChanged += new System.EventHandler(this.txtDogFoodSaleQuantity_TextChanged);
            // 
            // lblDogFoodSaleQuantity
            // 
            this.lblDogFoodSaleQuantity.AutoSize = true;
            this.lblDogFoodSaleQuantity.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleQuantity.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleQuantity.Location = new System.Drawing.Point(12, 336);
            this.lblDogFoodSaleQuantity.Name = "lblDogFoodSaleQuantity";
            this.lblDogFoodSaleQuantity.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleQuantity.TabIndex = 20;
            this.lblDogFoodSaleQuantity.Text = "QUANTITY:";
            // 
            // txtDogFoodSalePrice
            // 
            this.txtDogFoodSalePrice.Location = new System.Drawing.Point(266, 259);
            this.txtDogFoodSalePrice.Name = "txtDogFoodSalePrice";
            this.txtDogFoodSalePrice.Size = new System.Drawing.Size(200, 20);
            this.txtDogFoodSalePrice.TabIndex = 23;
            this.txtDogFoodSalePrice.TextChanged += new System.EventHandler(this.txtDogFoodSalePrice_TextChanged);
            // 
            // lblDogFoodSalePrice
            // 
            this.lblDogFoodSalePrice.AutoSize = true;
            this.lblDogFoodSalePrice.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSalePrice.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSalePrice.Location = new System.Drawing.Point(12, 248);
            this.lblDogFoodSalePrice.Name = "lblDogFoodSalePrice";
            this.lblDogFoodSalePrice.Size = new System.Drawing.Size(110, 31);
            this.lblDogFoodSalePrice.TabIndex = 22;
            this.lblDogFoodSalePrice.Text = "PRICE:";
            // 
            // txtDogFoodSaleFinalTotal
            // 
            this.txtDogFoodSaleFinalTotal.Location = new System.Drawing.Point(1096, 484);
            this.txtDogFoodSaleFinalTotal.Name = "txtDogFoodSaleFinalTotal";
            this.txtDogFoodSaleFinalTotal.Size = new System.Drawing.Size(117, 20);
            this.txtDogFoodSaleFinalTotal.TabIndex = 31;
            this.txtDogFoodSaleFinalTotal.TextChanged += new System.EventHandler(this.txtFinalTotal_TextChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDisplay.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(712, 470);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(134, 40);
            this.btnDisplay.TabIndex = 55;
            this.btnDisplay.Text = "DISPLAY";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplayReceipt_Click);
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClearFields.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(555, 530);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(134, 59);
            this.btnClearFields.TabIndex = 56;
            this.btnClearFields.Text = "CLEAR FIELDS";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(555, 469);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(134, 40);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDogFoodSaleChangeDue
            // 
            this.txtDogFoodSaleChangeDue.Location = new System.Drawing.Point(1063, 750);
            this.txtDogFoodSaleChangeDue.Name = "txtDogFoodSaleChangeDue";
            this.txtDogFoodSaleChangeDue.Size = new System.Drawing.Size(117, 20);
            this.txtDogFoodSaleChangeDue.TabIndex = 62;
            this.txtDogFoodSaleChangeDue.TextChanged += new System.EventHandler(this.txtDogFoodSaleChangeDue_TextChanged_1);
            // 
            // lblDogFoodSaleChangeDue
            // 
            this.lblDogFoodSaleChangeDue.AutoSize = true;
            this.lblDogFoodSaleChangeDue.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleChangeDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleChangeDue.Location = new System.Drawing.Point(873, 584);
            this.lblDogFoodSaleChangeDue.Name = "lblDogFoodSaleChangeDue";
            this.lblDogFoodSaleChangeDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleChangeDue.TabIndex = 61;
            this.lblDogFoodSaleChangeDue.Text = "CHANGE DUE:";
            // 
            // txtDogFoodSaleAmountPaid
            // 
            this.txtDogFoodSaleAmountPaid.Location = new System.Drawing.Point(1096, 539);
            this.txtDogFoodSaleAmountPaid.Name = "txtDogFoodSaleAmountPaid";
            this.txtDogFoodSaleAmountPaid.Size = new System.Drawing.Size(117, 20);
            this.txtDogFoodSaleAmountPaid.TabIndex = 60;
            this.txtDogFoodSaleAmountPaid.TextChanged += new System.EventHandler(this.txtDogFoodSaleAmountPaid_TextChanged_1);
            // 
            // lblDogFoodSaleAmountPaid
            // 
            this.lblDogFoodSaleAmountPaid.AutoSize = true;
            this.lblDogFoodSaleAmountPaid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblDogFoodSaleAmountPaid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountPaid.Location = new System.Drawing.Point(873, 528);
            this.lblDogFoodSaleAmountPaid.Name = "lblDogFoodSaleAmountPaid";
            this.lblDogFoodSaleAmountPaid.Size = new System.Drawing.Size(206, 31);
            this.lblDogFoodSaleAmountPaid.TabIndex = 59;
            this.lblDogFoodSaleAmountPaid.Text = "AMOUNT PAID:";
            this.lblDogFoodSaleAmountPaid.Click += new System.EventHandler(this.lblDogFoodSaleAmountPaid_Click);
            // 
            // btnFinalTotal
            // 
            this.btnFinalTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalTotal.Location = new System.Drawing.Point(871, 469);
            this.btnFinalTotal.Name = "btnFinalTotal";
            this.btnFinalTotal.Size = new System.Drawing.Size(208, 38);
            this.btnFinalTotal.TabIndex = 63;
            this.btnFinalTotal.Text = "FINAL TOTAL";
            this.btnFinalTotal.UseVisualStyleBackColor = false;
            this.btnFinalTotal.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvDogFoodSale
            // 
            this.dgvDogFoodSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogFoodSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvDogFoodSale.Location = new System.Drawing.Point(871, 72);
            this.dgvDogFoodSale.Name = "dgvDogFoodSale";
            this.dgvDogFoodSale.Size = new System.Drawing.Size(491, 381);
            this.dgvDogFoodSale.TabIndex = 64;
            this.dgvDogFoodSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // txtDogFoodSaleAmountDue
            // 
            this.txtDogFoodSaleAmountDue.Location = new System.Drawing.Point(266, 601);
            this.txtDogFoodSaleAmountDue.Name = "txtDogFoodSaleAmountDue";
            this.txtDogFoodSaleAmountDue.Size = new System.Drawing.Size(200, 20);
            this.txtDogFoodSaleAmountDue.TabIndex = 70;
            this.txtDogFoodSaleAmountDue.TextChanged += new System.EventHandler(this.txtDogFoodSaleAmountDue_TextChanged_1);
            // 
            // lblDogFoodSaleAmountDue
            // 
            this.lblDogFoodSaleAmountDue.AutoSize = true;
            this.lblDogFoodSaleAmountDue.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleAmountDue.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleAmountDue.Location = new System.Drawing.Point(12, 590);
            this.lblDogFoodSaleAmountDue.Name = "lblDogFoodSaleAmountDue";
            this.lblDogFoodSaleAmountDue.Size = new System.Drawing.Size(190, 31);
            this.lblDogFoodSaleAmountDue.TabIndex = 69;
            this.lblDogFoodSaleAmountDue.Text = "AMOUNT DUE:";
            // 
            // txtDogFoodSaleDiscount
            // 
            this.txtDogFoodSaleDiscount.Location = new System.Drawing.Point(266, 519);
            this.txtDogFoodSaleDiscount.Name = "txtDogFoodSaleDiscount";
            this.txtDogFoodSaleDiscount.Size = new System.Drawing.Size(200, 20);
            this.txtDogFoodSaleDiscount.TabIndex = 68;
            this.txtDogFoodSaleDiscount.TextChanged += new System.EventHandler(this.txtDogFoodSaleDiscount_TextChanged_1);
            // 
            // lblDogFoodSaleDiscount
            // 
            this.lblDogFoodSaleDiscount.AutoSize = true;
            this.lblDogFoodSaleDiscount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleDiscount.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleDiscount.Location = new System.Drawing.Point(12, 508);
            this.lblDogFoodSaleDiscount.Name = "lblDogFoodSaleDiscount";
            this.lblDogFoodSaleDiscount.Size = new System.Drawing.Size(158, 31);
            this.lblDogFoodSaleDiscount.TabIndex = 67;
            this.lblDogFoodSaleDiscount.Text = "DISCOUNT:";
            // 
            // txtDogFoodSaleTotal
            // 
            this.txtDogFoodSaleTotal.Location = new System.Drawing.Point(266, 432);
            this.txtDogFoodSaleTotal.Name = "txtDogFoodSaleTotal";
            this.txtDogFoodSaleTotal.Size = new System.Drawing.Size(200, 20);
            this.txtDogFoodSaleTotal.TabIndex = 66;
            this.txtDogFoodSaleTotal.TextChanged += new System.EventHandler(this.txtDogFoodSaleTotal_TextChanged_1);
            // 
            // lblDogFoodSaleTotal
            // 
            this.lblDogFoodSaleTotal.AutoSize = true;
            this.lblDogFoodSaleTotal.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblDogFoodSaleTotal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDogFoodSaleTotal.Location = new System.Drawing.Point(12, 422);
            this.lblDogFoodSaleTotal.Name = "lblDogFoodSaleTotal";
            this.lblDogFoodSaleTotal.Size = new System.Drawing.Size(110, 31);
            this.lblDogFoodSaleTotal.TabIndex = 65;
            this.lblDogFoodSaleTotal.Text = "TOTAL:";
            // 
            // txtDogFoodSailChangeDue
            // 
            this.txtDogFoodSailChangeDue.Location = new System.Drawing.Point(1096, 595);
            this.txtDogFoodSailChangeDue.Name = "txtDogFoodSailChangeDue";
            this.txtDogFoodSailChangeDue.Size = new System.Drawing.Size(114, 20);
            this.txtDogFoodSailChangeDue.TabIndex = 71;
            this.txtDogFoodSailChangeDue.TextChanged += new System.EventHandler(this.txtDogFoolSaleChangeDue_TextChanged);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.Location = new System.Drawing.Point(712, 69);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(153, 41);
            this.btnBackToLogin.TabIndex = 72;
            this.btnBackToLogin.Text = "BACK";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnClearGrid
            // 
            this.btnClearGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClearGrid.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGrid.Location = new System.Drawing.Point(712, 116);
            this.btnClearGrid.Name = "btnClearGrid";
            this.btnClearGrid.Size = new System.Drawing.Size(153, 41);
            this.btnClearGrid.TabIndex = 73;
            this.btnClearGrid.Text = "CLEAR LIST";
            this.btnClearGrid.UseVisualStyleBackColor = false;
            this.btnClearGrid.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnClearBoxes
            // 
            this.btnClearBoxes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClearBoxes.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBoxes.Location = new System.Drawing.Point(712, 531);
            this.btnClearBoxes.Name = "btnClearBoxes";
            this.btnClearBoxes.Size = new System.Drawing.Size(134, 59);
            this.btnClearBoxes.TabIndex = 74;
            this.btnClearBoxes.Text = "CLEAR BOXES";
            this.btnClearBoxes.UseVisualStyleBackColor = false;
            this.btnClearBoxes.Click += new System.EventHandler(this.btnClearBoxes_Click);
            // 
            // Dog_Food_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 750);
            this.Controls.Add(this.btnClearBoxes);
            this.Controls.Add(this.btnClearGrid);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.txtDogFoodSailChangeDue);
            this.Controls.Add(this.txtDogFoodSaleAmountDue);
            this.Controls.Add(this.lblDogFoodSaleAmountDue);
            this.Controls.Add(this.txtDogFoodSaleDiscount);
            this.Controls.Add(this.lblDogFoodSaleDiscount);
            this.Controls.Add(this.txtDogFoodSaleTotal);
            this.Controls.Add(this.lblDogFoodSaleTotal);
            this.Controls.Add(this.dgvDogFoodSale);
            this.Controls.Add(this.btnFinalTotal);
            this.Controls.Add(this.txtDogFoodSaleChangeDue);
            this.Controls.Add(this.lblDogFoodSaleChangeDue);
            this.Controls.Add(this.txtDogFoodSaleAmountPaid);
            this.Controls.Add(this.lblDogFoodSaleAmountPaid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtDogFoodSaleFinalTotal);
            this.Controls.Add(this.txtDogFoodSalePrice);
            this.Controls.Add(this.lblDogFoodSalePrice);
            this.Controls.Add(this.txtDogFoodSaleQuantity);
            this.Controls.Add(this.lblDogFoodSaleQuantity);
            this.Controls.Add(this.cboDogFoodSaleItems);
            this.Controls.Add(this.lblDogFoodSaleDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDogFoodSaleItem);
            this.Name = "Dog_Food_Sale";
            this.Text = "Dog_Food_Sale";
            this.Load += new System.EventHandler(this.Dog_Food_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogFoodSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDogFoodSaleItem;
        private System.Windows.Forms.Label lblDogFoodSaleDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboDogFoodSaleItems;
        private System.Windows.Forms.TextBox txtDogFoodSaleQuantity;
        private System.Windows.Forms.Label lblDogFoodSaleQuantity;
        private System.Windows.Forms.TextBox txtDogFoodSalePrice;
        private System.Windows.Forms.Label lblDogFoodSalePrice;
        private System.Windows.Forms.TextBox txtDogFoodSaleFinalTotal;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDogFoodSaleChangeDue;
        private System.Windows.Forms.Label lblDogFoodSaleChangeDue;
        private System.Windows.Forms.TextBox txtDogFoodSaleAmountPaid;
        private System.Windows.Forms.Label lblDogFoodSaleAmountPaid;
        private System.Windows.Forms.Button btnFinalTotal;
        private System.Windows.Forms.DataGridView dgvDogFoodSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox txtDogFoodSaleAmountDue;
        private System.Windows.Forms.Label lblDogFoodSaleAmountDue;
        private System.Windows.Forms.TextBox txtDogFoodSaleDiscount;
        private System.Windows.Forms.Label lblDogFoodSaleDiscount;
        private System.Windows.Forms.TextBox txtDogFoodSaleTotal;
        private System.Windows.Forms.Label lblDogFoodSaleTotal;
        private System.Windows.Forms.TextBox txtDogFoodSailChangeDue;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Button btnClearGrid;
        private System.Windows.Forms.Button btnClearBoxes;
    }
}