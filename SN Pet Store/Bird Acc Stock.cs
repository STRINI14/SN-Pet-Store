using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace SN_Pet_Store
{
    public partial class Bird_Acc_Stock : Form
    {
        public Bird_Acc_Stock()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Birds_Menu bm = new Birds_Menu();
            bm.Show();
        }

        private void Bird_Acc_Stock_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBirdAccStockItems.Text = "";
            txtBirdAccQuantity.Text = "";
            txtBirdAccColour.Text = "";
            txtBirdAccPrice.Text = "";
        }

        private void btnDogFoodSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Bird_Acc_Stock(Date,Item,Quantity,Colour,Price) values(@Date,@Item,@Quantity,@Colour,@Price)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", txtBirdAccStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtBirdAccQuantity.Text);
            cmd.Parameters.AddWithValue("@Colour", txtBirdAccColour.Text);
            cmd.Parameters.AddWithValue("@Price", txtBirdAccPrice.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }
    }
}
