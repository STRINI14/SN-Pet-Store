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
    public partial class frmNew : Form
    {
        public frmNew()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into User_Details(Username,Password) values(@Username,@Password)", con);
            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.");
            con.Close();
        }

     
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPetStoreLogin pl = new frmPetStoreLogin();
            pl.Show();
        }

        private void frmNew_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
