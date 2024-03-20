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
    public partial class Records_Login : Form
    {
        public Records_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;

            if ((username == "STRINI" && password == "MILO1402"))
            {
                MessageBox.Show("Access Granted!", "Welcome.");
                this.Hide();
                 Reports_Menu rp = new Reports_Menu();
                rp.Show();

            }
            else MessageBox.Show("Access Denied!", "Incorrect Details.");
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
             frmMain fr = new frmMain();
            fr.Show();
        }
    }
}
