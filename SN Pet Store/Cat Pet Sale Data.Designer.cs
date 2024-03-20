namespace SN_Pet_Store
{
    partial class Cat_Pet_Sale_Data
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catPetSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sN_PetsDataSet15 = new SN_Pet_Store.SN_PetsDataSet15();
            this.cat_Pet_SaleTableAdapter = new SN_Pet_Store.SN_PetsDataSet15TableAdapters.Cat_Pet_SaleTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPetSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_PetsDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.amountDueDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.catPetSaleBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(909, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // catPetSaleBindingSource
            // 
            this.catPetSaleBindingSource.DataMember = "Cat_Pet_Sale";
            this.catPetSaleBindingSource.DataSource = this.sN_PetsDataSet15;
            // 
            // sN_PetsDataSet15
            // 
            this.sN_PetsDataSet15.DataSetName = "SN_PetsDataSet15";
            this.sN_PetsDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cat_Pet_SaleTableAdapter
            // 
            this.cat_Pet_SaleTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // amountDueDataGridViewTextBoxColumn
            // 
            this.amountDueDataGridViewTextBoxColumn.DataPropertyName = "Amount_Due";
            this.amountDueDataGridViewTextBoxColumn.HeaderText = "Amount_Due";
            this.amountDueDataGridViewTextBoxColumn.Name = "amountDueDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            this.photoDataGridViewImageColumn.Width = 300;
            // 
            // Cat_Pet_Sale_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 332);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cat_Pet_Sale_Data";
            this.Text = "Cat_Pet_Sale_Data";
            this.Load += new System.EventHandler(this.Cat_Pet_Sale_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPetSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_PetsDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SN_PetsDataSet15 sN_PetsDataSet15;
        private System.Windows.Forms.BindingSource catPetSaleBindingSource;
        private SN_PetsDataSet15TableAdapters.Cat_Pet_SaleTableAdapter cat_Pet_SaleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
    }
}