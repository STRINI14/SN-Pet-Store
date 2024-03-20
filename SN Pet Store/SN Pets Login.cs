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
    

    public partial class frmPetStoreLogin : Form
        
    {
        


        public frmPetStoreLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            frmNew fr = new frmNew();
            fr.Show();
            
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtLoginUsername.Text;
            string password = txtLoginPassword.Text;
           
            if ((username == "STRINI" && password == "1402"))
            {
                ClassUser.uname = txtLoginUsername.Text;
                MessageBox.Show("Access Granted!", "Welcome.");
                this.Hide();
                frmMain dr = new frmMain();
                dr.Show();

            }
            else MessageBox.Show("Access Denied!","Incorrect Details.");
         
        }
    }
}
