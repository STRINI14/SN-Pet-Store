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
    public partial class Reports_Menu : Form
    {
        public Reports_Menu()
        {
            InitializeComponent();
        }

        private void btnDogs_Click(object sender, EventArgs e)
        {
            Reports re = new Reports();
            re.Show();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Records_Login rl = new Records_Login();
            rl.Show();

        }

        private void btnCats_Click(object sender, EventArgs e)
        {
            Cats_Reports cr = new Cats_Reports();
            cr.Show();
        }

        private void btnBirds_Click(object sender, EventArgs e)
        {
            Birds_Reports br = new Birds_Reports();
            br.Show();
        }

        private void btnFish_Click(object sender, EventArgs e)
        {
            Fish_Reports fr = new Fish_Reports();
            fr.Show();
        }

        private void Reports_Menu_Load(object sender, EventArgs e)
        {
            lblUsername.Text = ClassUser.uname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are You Sure You Want To Exit The SN Pets Inventory System?",
    "Exit The Application?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPetStoreLogin psl = new frmPetStoreLogin();
            psl.Show();
        }
    }
}
