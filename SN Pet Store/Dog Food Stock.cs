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
    
    public partial class Dog_Food_Stock : Form
    {
        public Dog_Food_Stock()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDogFoodSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Dog_Food_Stock(Date_Entered,Item,Quantity,Weight,Price,Date_Expiring) values(@Date_Entered,@Item,@Quantity,@Weight,@Price,@Date_Expiring)", con);
            cmd.Parameters.AddWithValue("@Date_Entered", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", txtDogFoodStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtDogFoodQuantity.Text);
            cmd.Parameters.AddWithValue("@Weight", txtDogFoodWeight.Text);
            cmd.Parameters.AddWithValue("@Price", txtDogFoodPrice.Text);
            cmd.Parameters.AddWithValue("@Date_Expiring", dateTimePickerdfs.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }

        private void txtDogFoodPrice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDogFoodStockItems.Text = "";
            txtDogFoodQuantity.Text = "";
            txtDogFoodWeight.Text = "";
            txtDogFoodPrice.Text = "";
            dateTimePickerdfs.Text = "";





        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Dogs_Menu dm = new Dogs_Menu();
            dm.Show();
        }

        private void Dog_Food_Stock_Load(object sender, EventArgs e)
        {

        }
    }
}
