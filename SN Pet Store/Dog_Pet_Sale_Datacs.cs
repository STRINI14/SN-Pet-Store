using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SN_Pet_Store
{
    public partial class Dog_Pet_Sale_Data : Form
    {
        public Dog_Pet_Sale_Data()
        {
            InitializeComponent();
        }

        private void Dog_Pet_Sale_Datacs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sN_PetsDataSet7.Dog_Pet_Stock' table. You can move, or remove it, as needed.
            this.dog_Pet_StockTableAdapter.Fill(this.sN_PetsDataSet7.Dog_Pet_Stock);
            // TODO: This line of code loads data into the 'sN_Pets_Dog_Pet_Sale_DataSet.Dog_Pet_Sale' table. You can move, or remove it, as needed.
            this.dog_Pet_SaleTableAdapter2.Fill(this.sN_Pets_Dog_Pet_Sale_DataSet.Dog_Pet_Sale);
            // TODO: This line of code loads data into the 'sN_PetsDataSet6.Dog_Pet_Sale' table. You can move, or remove it, as needed.
            this.dog_Pet_SaleTableAdapter1.Fill(this.sN_PetsDataSet6.Dog_Pet_Sale);
            // TODO: This line of code loads data into the 'sN_PetsDataSet5.Dog_Pet_Sale' table. You can move, or remove it, as needed.
            this.dog_Pet_SaleTableAdapter.Fill(this.SN_Pets_Dog_Pet_Sale_Data.Dog_Pet_Sale);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

    
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }





}
