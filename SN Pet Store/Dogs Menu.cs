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
    public partial class Dogs_Menu : Form
    {
        public Dogs_Menu()
        {
            InitializeComponent();
        }

        private void btnAddDogFood_Click(object sender, EventArgs e)
        {
            Dog_Food_Stock df = new Dog_Food_Stock();
            df.Show();

        }

        private void btnAddDogAcc_Click(object sender, EventArgs e)
        {
            Dog_Accessories_Stock da = new Dog_Accessories_Stock();
            da.Show();

        }

        private void btnDogPetCare_Click(object sender, EventArgs e)
        {
            Dog_Pet_Care_Stock dp = new Dog_Pet_Care_Stock();
            dp.Show();
        }

        private void btnDogPet_Click(object sender, EventArgs e)
        {
            Dog_Pet_Stock ds = new Dog_Pet_Stock();
            ds.Show();
        }

        private void btnDogFoodSale_Click(object sender, EventArgs e)
        {
            Dog_Food_Sale df = new Dog_Food_Sale();
            df.Show();
        }

        private void btnDogAccSale_Click(object sender, EventArgs e)
        {
            Dog_Acc_Sale da = new Dog_Acc_Sale();
            da.Show();
        }

        private void btnDogPetCareSale_Click(object sender, EventArgs e)
        {
            Dog_Pet_Care_Sale dp = new Dog_Pet_Care_Sale();
            dp.Show();
        }

        private void btnPetSale_Click(object sender, EventArgs e)
        {
            Dog_Pet_Sale dp = new Dog_Pet_Sale();
            dp.Show();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            frmMain fr = new frmMain();
            fr.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPetStoreLogin fr = new frmPetStoreLogin();
            fr.Show();
        }

        private void Dogs_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
