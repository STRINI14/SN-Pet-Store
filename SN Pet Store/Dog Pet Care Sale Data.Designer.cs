namespace SN_Pet_Store
{
    partial class Dog_Pet_Care_Sale_Data
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
            this.sN_PetsDataSet4 = new SN_Pet_Store.SN_PetsDataSet4();
            this.dogPetCareSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dog_Pet_Care_SaleTableAdapter = new SN_Pet_Store.SN_PetsDataSet4TableAdapters.Dog_Pet_Care_SaleTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEnteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_PetsDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPetCareSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateEnteredDataGridViewTextBoxColumn,
            this.itemDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.amountDueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dogPetCareSaleBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // sN_PetsDataSet4
            // 
            this.sN_PetsDataSet4.DataSetName = "SN_PetsDataSet4";
            this.sN_PetsDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dogPetCareSaleBindingSource
            // 
            this.dogPetCareSaleBindingSource.DataMember = "Dog_Pet_Care_Sale";
            this.dogPetCareSaleBindingSource.DataSource = this.sN_PetsDataSet4;
            // 
            // dog_Pet_Care_SaleTableAdapter
            // 
            this.dog_Pet_Care_SaleTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEnteredDataGridViewTextBoxColumn
            // 
            this.dateEnteredDataGridViewTextBoxColumn.DataPropertyName = "Date_Entered";
            this.dateEnteredDataGridViewTextBoxColumn.HeaderText = "Date_Entered";
            this.dateEnteredDataGridViewTextBoxColumn.Name = "dateEnteredDataGridViewTextBoxColumn";
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
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
            // Dog_Pet_Care_Sale_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 244);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Dog_Pet_Care_Sale_Data";
            this.Text = "Dog_Pet_Care_Sale_Data";
            this.Load += new System.EventHandler(this.Dog_Pet_Care_Sale_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_PetsDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPetCareSaleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SN_PetsDataSet4 sN_PetsDataSet4;
        private System.Windows.Forms.BindingSource dogPetCareSaleBindingSource;
        private SN_PetsDataSet4TableAdapters.Dog_Pet_Care_SaleTableAdapter dog_Pet_Care_SaleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEnteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDueDataGridViewTextBoxColumn;
    }
}