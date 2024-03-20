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
    public partial class Cat_Accessories_Stock : Form
    {
        public Cat_Accessories_Stock()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Cats_Menu cm = new Cats_Menu();
            cm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCatAccStockItems.Text = "";
            txtCatAccQuantity.Text = "";
            txtCatAccColour.Text = "";
            txtCatAccPrice.Text = "";

        }

        private void Cat_Accessories_Stock_Load(object sender, EventArgs e)
        {

        }

        private void btnDogFoodSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Cat_Acc_Stock(Date,Item,Quantity,Colour,Price) values(@Date,@Item,@Quantity,@Colour,@Price)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker3.Text);
            cmd.Parameters.AddWithValue("@Item", txtCatAccStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtCatAccQuantity.Text);
            cmd.Parameters.AddWithValue("@Colour", txtCatAccColour.Text);
            cmd.Parameters.AddWithValue("@Price", txtCatAccPrice.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }
    }
}
