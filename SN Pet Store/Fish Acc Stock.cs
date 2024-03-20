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
    public partial class Fish_Acc_Stock : Form
    {
        public Fish_Acc_Stock()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Fish_Menu fm = new Fish_Menu();
            fm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFishAccStockItems.Text = "";
            txtFishAccQuantity.Text = "";
            txtFishAccColour.Text = "";
            txtFishAccPrice.Text = "";
        }

        private void Fish_Acc_Stock_Load(object sender, EventArgs e)
        {

        }

        private void btnDogFoodSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Fish_Acc_Stock(Date,Item,Quantity,Colour,Price) values(@Date,@Item,@Quantity,@Colour,@Price)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", txtFishAccStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtFishAccQuantity.Text);
            cmd.Parameters.AddWithValue("@Colour", txtFishAccColour.Text);
            cmd.Parameters.AddWithValue("@Price", txtFishAccPrice.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }
    }
}
