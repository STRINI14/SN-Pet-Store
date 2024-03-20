namespace SN_Pet_Store
{
    partial class Bird_Acc_Stock_Data
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
            this.sN_Pets_Bird_Acc_Stock_DataSet = new SN_Pet_Store.SN_Pets_Bird_Acc_Stock_DataSet();
            this.birdAccStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bird_Acc_StockTableAdapter = new SN_Pet_Store.SN_Pets_Bird_Acc_Stock_DataSetTableAdapters.Bird_Acc_StockTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_Pets_Bird_Acc_Stock_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdAccStockBindingSource)).BeginInit();
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
            this.quantityDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.birdAccStockBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(876, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // sN_Pets_Bird_Acc_Stock_DataSet
            // 
            this.sN_Pets_Bird_Acc_Stock_DataSet.DataSetName = "SN_Pets_Bird_Acc_Stock_DataSet";
            this.sN_Pets_Bird_Acc_Stock_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birdAccStockBindingSource
            // 
            this.birdAccStockBindingSource.DataMember = "Bird_Acc_Stock";
            this.birdAccStockBindingSource.DataSource = this.sN_Pets_Bird_Acc_Stock_DataSet;
            // 
            // bird_Acc_StockTableAdapter
            // 
            this.bird_Acc_StockTableAdapter.ClearBeforeFill = true;
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
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // Bird_Acc_Stock_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 320);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bird_Acc_Stock_Data";
            this.Text = "Bird_Acc_Stock_Data";
            this.Load += new System.EventHandler(this.Bird_Acc_Stock_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_Pets_Bird_Acc_Stock_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdAccStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SN_Pets_Bird_Acc_Stock_DataSet sN_Pets_Bird_Acc_Stock_DataSet;
        private System.Windows.Forms.BindingSource birdAccStockBindingSource;
        private SN_Pets_Bird_Acc_Stock_DataSetTableAdapters.Bird_Acc_StockTableAdapter bird_Acc_StockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}