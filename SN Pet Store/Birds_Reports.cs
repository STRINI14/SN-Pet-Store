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
    public partial class Birds_Reports : Form
    {
        public Birds_Reports()
        {
            InitializeComponent();
        }

        private void btnCatFoodData_Click(object sender, EventArgs e)
        {
            Bird_Food_Stock_Data bfs = new Bird_Food_Stock_Data();
            bfs.Show();

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Reports_Menu rm = new Reports_Menu();
            rm.Show();
        }

        private void btnFoodSale_Click(object sender, EventArgs e)
        {
            Bird_Food_Sale_Data bfs = new Bird_Food_Sale_Data();
            bfs.Show();
        }

        private void btnCatAccStockTable_Click(object sender, EventArgs e)
        {
            Bird_Acc_Stock_Data bas = new Bird_Acc_Stock_Data();
            bas.Show();
        }

        private void btnAccSale_Click(object sender, EventArgs e)
        {
            Bird_Acc_Sale_Data basd = new Bird_Acc_Sale_Data();
            basd.Show();
        }

        private void btnCatPetCareStockTable_Click(object sender, EventArgs e)
        {
            Bird_Pet_Care_Stock_Data bpcsd = new Bird_Pet_Care_Stock_Data();
            bpcsd.Show();
        }

        private void btnPetSale_Click(object sender, EventArgs e)
        {
            Bird_Pet_Sale_Data bpsd = new Bird_Pet_Sale_Data();
            bpsd.Show();
        }

        private void btnPetCareSale_Click(object sender, EventArgs e)
        {
            Bird_Pet_Care_Sale_Data bpcs = new Bird_Pet_Care_Sale_Data();
            bpcs.Show();
    
        }

        private void btnCatPetStockTable_Click(object sender, EventArgs e)
        {
            Bird_Pet_Stock_Data bpsd = new Bird_Pet_Stock_Data();
            bpsd.Show();
        }
    }
}
