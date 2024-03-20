namespace SN_Pet_Store
{
    partial class Bird_Pet_Stock_Data
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
            this.sN_Pets_Bird_Pet_Stock_DataSet = new SN_Pet_Store.SN_Pets_Bird_Pet_Stock_DataSet();
            this.birdPetStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bird_Pet_StockTableAdapter = new SN_Pet_Store.SN_Pets_Bird_Pet_Stock_DataSetTableAdapters.Bird_Pet_StockTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_Pets_Bird_Pet_Stock_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPetStockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.colourDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.breedDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.photoDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.birdPetStockBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(912, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // sN_Pets_Bird_Pet_Stock_DataSet
            // 
            this.sN_Pets_Bird_Pet_Stock_DataSet.DataSetName = "SN_Pets_Bird_Pet_Stock_DataSet";
            this.sN_Pets_Bird_Pet_Stock_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // birdPetStockBindingSource
            // 
            this.birdPetStockBindingSource.DataMember = "Bird_Pet_Stock";
            this.birdPetStockBindingSource.DataSource = this.sN_Pets_Bird_Pet_Stock_DataSet;
            // 
            // bird_Pet_StockTableAdapter
            // 
            this.bird_Pet_StockTableAdapter.ClearBeforeFill = true;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // colourDataGridViewTextBoxColumn
            // 
            this.colourDataGridViewTextBoxColumn.DataPropertyName = "Colour";
            this.colourDataGridViewTextBoxColumn.HeaderText = "Colour";
            this.colourDataGridViewTextBoxColumn.Name = "colourDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // breedDataGridViewTextBoxColumn
            // 
            this.breedDataGridViewTextBoxColumn.DataPropertyName = "Breed";
            this.breedDataGridViewTextBoxColumn.HeaderText = "Breed";
            this.breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewImageColumn
            // 
            this.photoDataGridViewImageColumn.DataPropertyName = "Photo";
            this.photoDataGridViewImageColumn.HeaderText = "Photo";
            this.photoDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.photoDataGridViewImageColumn.Name = "photoDataGridViewImageColumn";
            // 
            // Bird_Pet_Stock_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 326);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Bird_Pet_Stock_Data";
            this.Text = "Bird_Pet_Stock_Data";
            this.Load += new System.EventHandler(this.Bird_Pet_Stock_Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sN_Pets_Bird_Pet_Stock_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birdPetStockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SN_Pets_Bird_Pet_Stock_DataSet sN_Pets_Bird_Pet_Stock_DataSet;
        private System.Windows.Forms.BindingSource birdPetStockBindingSource;
        private SN_Pets_Bird_Pet_Stock_DataSetTableAdapters.Bird_Pet_StockTableAdapter bird_Pet_StockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoDataGridViewImageColumn;
    }
}