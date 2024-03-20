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
    public partial class Cat_Food_Stock : Form
    {
        public Cat_Food_Stock()
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
            txtCatFoodStockItems.Text = "";
            txtCatFoodQuantity.Text = "";
            txtCatFoodWeight.Text = "";
            txtCatFoodPrice.Text = "";
            dateTimePickercfs.Text = "";
        }

        private void btnDogFoodSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Cat_Food_Stock(Date,Item,Quantity,Weight,Price,Date_Expiring) values(@Date,@Item,@Quantity,@Weight,@Price,@Date_Expiring)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", txtCatFoodStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtCatFoodQuantity.Text);
            cmd.Parameters.AddWithValue("@Weight", txtCatFoodWeight.Text);
            cmd.Parameters.AddWithValue("@Price", txtCatFoodPrice.Text);
            cmd.Parameters.AddWithValue("@Date_Expiring", dateTimePickercfs.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }
    }
}
