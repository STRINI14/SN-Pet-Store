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
    public partial class Bird_Food_Stock : Form
    {
        public Bird_Food_Stock()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Birds_Menu bm = new Birds_Menu();
            bm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtBirdFoodStockItems.Text = "";
            txtBirdFoodQuantity.Text = "";
            txtBirdFoodWeight.Text = "";
            txtBirdFoodPrice.Text = "";
            dateTimePickerbfs.Text = "";
        }

        private void btnDogFoodSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Bird_Food_Stock(Date,Item,Quantity,Weight,Price,Date_Expiring) values(@Date,@Item,@Quantity,@Weight,@Price,@Date_Expiring)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", txtBirdFoodStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtBirdFoodQuantity.Text);
            cmd.Parameters.AddWithValue("@Weight", txtBirdFoodWeight.Text);
            cmd.Parameters.AddWithValue("@Price", txtBirdFoodPrice.Text);
            cmd.Parameters.AddWithValue("@Date_Expiring", dateTimePickerbfs.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }
    }
}
