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
    public partial class Cats_Menu : Form
    {
        public Cats_Menu()
        {
            InitializeComponent();
        }

        private void btnAddDogFood_Click(object sender, EventArgs e)
        {
            Cat_Food_Stock cfs = new Cat_Food_Stock();
            cfs.Show();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            frmMain fr = new frmMain();
            fr.Show();

        }

        private void btnCatFoodSale_Click(object sender, EventArgs e)
        {
            Cat_Food_Sale cfs = new Cat_Food_Sale();
            cfs.Show();
        }

        private void btnAddCatAcc_Click(object sender, EventArgs e)
        {
            Cat_Accessories_Stock cas = new Cat_Accessories_Stock();
            cas.Show();
        }

        private void btnCatAccSale_Click(object sender, EventArgs e)
        {
            Cat_Acc_Sale cas = new Cat_Acc_Sale();
            cas.Show();
        }

        private void btnCatPetCareSale_Click(object sender, EventArgs e)
        {
            Cat_Pet_Care_Sale cps = new Cat_Pet_Care_Sale();
            cps.Show();
        }

        private void btnCatPetCare_Click(object sender, EventArgs e)
        {
            Cat_Pet_Care_Stock cps = new Cat_Pet_Care_Stock();
            cps.Show();
        }

        private void btnCatPet_Click(object sender, EventArgs e)
        {
            Cat_Pet_Stock cps = new Cat_Pet_Stock();
            cps.Show();

        }

        private void btnCatPetSale_Click(object sender, EventArgs e)
        {
            Cat_Pet_Sale cps = new Cat_Pet_Sale();
            cps.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPetStoreLogin fr = new frmPetStoreLogin();
            fr.Show();
        }
    }
}
