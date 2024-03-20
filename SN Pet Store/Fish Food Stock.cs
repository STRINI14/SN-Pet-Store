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
    public partial class Fish_Food_Stock : Form
    {
        public Fish_Food_Stock()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Fish_Menu fm = new Fish_Menu();
            fm.Show();
        }

        private void Fish_Food_Stock_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFishFoodStockItems.Text = "";
            txtFishFoodQuantity.Text = "";
            txtFishFoodWeight.Text = "";
            txtFishFoodPrice.Text = "";
            dateTimePicker1.Text = "";
            dateTimePickerffs.Text = "";
        }

        private void btnDogFoodSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Fish_Food_Stock(Date,Item,Quantity,Weight,Price,Date_Expiring) values(@Date,@Item,@Quantity,@Weight,@Price,@Date_Expiring)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", txtFishFoodStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtFishFoodQuantity.Text);
            cmd.Parameters.AddWithValue("@Weight", txtFishFoodWeight.Text);
            cmd.Parameters.AddWithValue("@Price", txtFishFoodPrice.Text);
            cmd.Parameters.AddWithValue("@Date_Expiring", dateTimePickerffs.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }
    }
}
