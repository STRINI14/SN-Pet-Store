using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SN_Pet_Store
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            frmPetStoreLogin pr = new frmPetStoreLogin();
            pr.Show();

        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            Dogs_Menu dm = new Dogs_Menu();
            dm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dog_Pet_Stock_Table dps = new Dog_Pet_Stock_Table();
            dps.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Records_Login rl = new Records_Login();
            rl.Show();
        }

        private void btnCats_Click(object sender, EventArgs e)
        {
            Cats_Menu cm = new Cats_Menu();
            cm.Show();

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = ClassUser.uname;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBirds_Click(object sender, EventArgs e)
        {
            Birds_Menu bm = new Birds_Menu();
            bm.Show();
        }

        private void btnFish_Click(object sender, EventArgs e)
        {
            Fish_Menu fm = new Fish_Menu();
            fm.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You Sure You Want To Exit The SN Pets Inventory System?",
    "Exit The Application?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
