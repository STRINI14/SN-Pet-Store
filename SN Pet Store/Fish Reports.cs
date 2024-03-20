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
    public partial class Fish_Reports : Form
    {
        public Fish_Reports()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Reports_Menu rm = new Reports_Menu();
            rm.Show();
        }

        private void btnCatFoodData_Click(object sender, EventArgs e)
        {
            Fish_Food_Stock_Data ffsd = new Fish_Food_Stock_Data();
            ffsd.Show();
        }

        private void btnFoodSale_Click(object sender, EventArgs e)
        {
            Fish_Food_Sale_Data ffsd = new Fish_Food_Sale_Data();
            ffsd.Show();
        }

        private void btnCatAccStockTable_Click(object sender, EventArgs e)
        {
            Fish_Acc_Stock_Data fasd = new Fish_Acc_Stock_Data();
            fasd.Show();
        }

        private void btnAccSale_Click(object sender, EventArgs e)
        {
            Fish_Acc_Sale_Data fasd = new Fish_Acc_Sale_Data();
            fasd.Show();
        }

        private void btnCatPetCareStockTable_Click(object sender, EventArgs e)
        {
            Fish_Pet_Care_Stock_Data fpcs = new Fish_Pet_Care_Stock_Data();
            fpcs.Show();
        }

        private void btnCatPetStockTable_Click(object sender, EventArgs e)
        {
            Fish_Pet_Stock_Data fpsd = new Fish_Pet_Stock_Data();
            fpsd.Show();
        }

        private void btnPetCareSale_Click(object sender, EventArgs e)
        {
            Fish_Pet_Care_Sale_Data fpcsd = new Fish_Pet_Care_Sale_Data();
            fpcsd.Show();
        }

        private void btnPetSale_Click(object sender, EventArgs e)
        {
            Fish_Pet_Sale_Data fpsd = new Fish_Pet_Sale_Data();
            fpsd.Show(); 
        }
    }
}
