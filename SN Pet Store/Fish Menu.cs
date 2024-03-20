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
    public partial class Fish_Menu : Form
    {
        public Fish_Menu()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            frmMain fr = new frmMain();
            fr.Show();
        }

        private void btnAddCatFood_Click(object sender, EventArgs e)
        {
            Fish_Food_Stock ffs = new Fish_Food_Stock();
            ffs.Show();
        }

        private void btnCatFoodSale_Click(object sender, EventArgs e)
        {
            Fish_Food_Sale ffs = new Fish_Food_Sale();
            ffs.Show();
        }

        private void btnAddCatAcc_Click(object sender, EventArgs e)
        {
            Fish_Acc_Stock fas = new Fish_Acc_Stock();
            fas.Show();
        }

        private void btnCatAccSale_Click(object sender, EventArgs e)
        {
            Fish_Acc_Sale fas = new Fish_Acc_Sale();
            fas.Show();
        }

        private void btnCatPetCare_Click(object sender, EventArgs e)
        {
            Fish_Pet_Care_Stock fps = new Fish_Pet_Care_Stock();
            fps.Show();
        }

        private void btnCatPetCareSale_Click(object sender, EventArgs e)
        {
            Fish_Pet_Care_Sale fpc = new Fish_Pet_Care_Sale();
            fpc.Show();

        }

        private void btnCatPet_Click(object sender, EventArgs e)
        {
            Fish_Pet_Stock fps = new Fish_Pet_Stock();
            fps.Show();
        }

        private void btnCatPetSale_Click(object sender, EventArgs e)
        {
            Fish_Pet_Sale fps = new Fish_Pet_Sale();
            fps.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPetStoreLogin fr = new frmPetStoreLogin();
            fr.Show();
        }
    }
}
