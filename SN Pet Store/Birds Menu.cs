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
    public partial class Birds_Menu : Form
    {
        public Birds_Menu()
        {
            InitializeComponent();
        }

        private void btnAddCatFood_Click(object sender, EventArgs e)
        {
            Bird_Food_Stock bfs = new Bird_Food_Stock();
            bfs.Show();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            frmMain FR = new frmMain();
            FR.Show();
        }

        private void btnCatFoodSale_Click(object sender, EventArgs e)
        {
            Bird_Food_Sale bfs = new Bird_Food_Sale();
            bfs.Show();
        }

        private void btnAddCatAcc_Click(object sender, EventArgs e)
        {
            Bird_Acc_Stock bas = new Bird_Acc_Stock();
            bas.Show();
        }

        private void btnCatAccSale_Click(object sender, EventArgs e)
        {
            Bird_Acc_Sale bas = new Bird_Acc_Sale();
            bas.Show();
        }

        private void btnCatPetCare_Click(object sender, EventArgs e)
        {
            Bird_Pet_Care_Stock bpc = new Bird_Pet_Care_Stock();
            bpc.Show();
        }

        private void btnCatPetCareSale_Click(object sender, EventArgs e)
        {
            Bird_Pet_Care_Sale bpc = new Bird_Pet_Care_Sale();
            bpc.Show();
        }

        private void btnCatPet_Click(object sender, EventArgs e)
        {
            Bird_Pet_Stock bps = new Bird_Pet_Stock();
            bps.Show();
        }

        private void btnCatPetSale_Click(object sender, EventArgs e)
        {
            Bird_Pet_Sale bps = new Bird_Pet_Sale();
            bps.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            frmPetStoreLogin fr = new frmPetStoreLogin();
            fr.Show();
        }
    }
}
