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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnDogPetStockTable_Click(object sender, EventArgs e)
        {
            Dog_Pet_Stock_Table dfs = new Dog_Pet_Stock_Table();
            dfs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dog_Food_Stock_Data dfs = new Dog_Food_Stock_Data();
            dfs.Show();

        }

        private void btnDocAccStockTable_Click(object sender, EventArgs e)
        {
            Dog_Acc_Stock_Data das = new Dog_Acc_Stock_Data();
            das.Show();
        }

        private void btnPetCareStockTable_Click(object sender, EventArgs e)
        {
            Dog_Pet_Care_Stock_Data dpc = new Dog_Pet_Care_Stock_Data();
            dpc.Show();
        }

        private void btnFoodSale_Click(object sender, EventArgs e)
        {
            Dog_Food_Sale_Data dfs = new Dog_Food_Sale_Data();
            dfs.Show();
        }

        private void btnAccSale_Click(object sender, EventArgs e)
        {
            Dog_Acc_Sale_Data das = new Dog_Acc_Sale_Data();
            das.Show();
        }

        private void btnPetCareSale_Click(object sender, EventArgs e)
        {
            Dog_Pet_Care_Sale_Data dpc = new Dog_Pet_Care_Sale_Data();
            dpc.Show();
        }

        private void btnPetSale_Click(object sender, EventArgs e)
        {
            Dog_Pet_Sale_Data dps = new Dog_Pet_Sale_Data();
            dps.Show();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Reports_Menu rm = new Reports_Menu();
            rm.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    } 
}
