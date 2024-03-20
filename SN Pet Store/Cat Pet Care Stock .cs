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
    public partial class Cat_Pet_Care_Stock : Form
    {
        public Cat_Pet_Care_Stock()
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
            txtCatPetCareStockItems.Text = "";
            txtCatPetCareQuantity.Text = "";
            txtCatPetCareWeight.Text = "";
            txtCatPetCarePrice.Text = "";
            dateTimePickerCPCS.Text = "";

        }

        private void Cat_Pet_Care_Stock_Load(object sender, EventArgs e)
        {

        }

        private void btnDogPetCareSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Cat_Pet_Care_Stock(Date,Item,Quantity,Weight,Price,Date_Expiring) values(@Date,@Item,@Quantity,@Weight,@Price,@Date_Expiring)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker4.Text);
            cmd.Parameters.AddWithValue("@Item", txtCatPetCareStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtCatPetCareQuantity.Text);
            cmd.Parameters.AddWithValue("@Weight", txtCatPetCareWeight.Text);
            cmd.Parameters.AddWithValue("@Price", txtCatPetCarePrice.Text);
            cmd.Parameters.AddWithValue("@Date_Expiring", dateTimePickerCPCS.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }
    }
}
