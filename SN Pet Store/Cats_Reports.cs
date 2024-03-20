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
    public partial class Cats_Reports : Form
    {
        public Cats_Reports()
        {
            InitializeComponent();
        }

        private void Cats_Reports_Load(object sender, EventArgs e)
        {

        }

        private void btnCatFoodData_Click(object sender, EventArgs e)
        {
            Cat_Food_Stock_Data cfs = new Cat_Food_Stock_Data();
            cfs.Show();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Reports_Menu rm = new Reports_Menu();
            rm.Show();
        }

        private void btnFoodSale_Click(object sender, EventArgs e)
        {
            Cat_Food_Sale_Data cfs = new Cat_Food_Sale_Data();
            cfs.Show();
        }

        private void btnCatAccStockTable_Click(object sender, EventArgs e)
        {
            Cat_Acc_Stock_Data cas = new Cat_Acc_Stock_Data();
            cas.Show();
        }

        private void btnAccSale_Click(object sender, EventArgs e)
        {
            Cat_Acc_Sale_Data cas = new Cat_Acc_Sale_Data();
            cas.Show();
        }

        private void btnCatPetCareStockTable_Click(object sender, EventArgs e)
        {
            Cat_Pet_Care_Stock_Data cpc = new Cat_Pet_Care_Stock_Data();
            cpc.Show();
        }

        private void btnPetCareSale_Click(object sender, EventArgs e)
        {
            Cat_Pet_Care_Sale_Data cp = new Cat_Pet_Care_Sale_Data();
            cp.Show();
        }

        private void btnCatPetStockTable_Click(object sender, EventArgs e)
        {
            Cat_Pet_Stock_Data cps = new Cat_Pet_Stock_Data();
            cps.Show();
        }

        private void btnPetSale_Click(object sender, EventArgs e)
        {
            Cat_Pet_Sale_Data cps = new Cat_Pet_Sale_Data();
            cps.Show();
        }
    }
}
