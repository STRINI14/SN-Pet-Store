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
    public partial class Dog_Accessories_Stock : Form
    {
        public Dog_Accessories_Stock()
        {
            InitializeComponent();
        }

        private void btnDogFoodSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Dog_Acc_Stock(Date_Entered,Item,Quantity,Colour,Price) values(@Date_Entered,@Item,@Quantity,@Colour,@Price)", con);
            cmd.Parameters.AddWithValue("@Date_Entered", dateTimePicker3.Text);
            cmd.Parameters.AddWithValue("@Item", txtDogAccStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtDogAccQuantity.Text);
            cmd.Parameters.AddWithValue("@Colour", txtDogAccColour.Text);
            cmd.Parameters.AddWithValue("@Price", txtDogAccPrice.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
             
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Dogs_Menu dm = new Dogs_Menu();
            dm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDogAccStockItems.Text = "";
            txtDogAccQuantity.Text = "";
            txtDogAccColour.Text = "";
            txtDogAccPrice.Text = "";

        }

        private void Dog_Accessories_Stock_Load(object sender, EventArgs e)
        {

        }
    }
}
