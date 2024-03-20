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
    public partial class Dog_Pet_Care_Stock : Form
    {
        public Dog_Pet_Care_Stock()
        {
            InitializeComponent();
        }

        private void btnDogPetCareSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Dog_Care_Stock(Date_Entered,Item,Quantity,Weight,Price,Date_Expiring) values(@Date_Entered,@Item,@Quantity,@Weight,@Price,@Date_Expiring)", con);
            cmd.Parameters.AddWithValue("@Date_Entered", dateTimePicker4.Text);
            cmd.Parameters.AddWithValue("@Item", txtDogPetCareStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtDogPetCareQuantity.Text);
            cmd.Parameters.AddWithValue("@Weight", txtDogPetCareWeight.Text);
            cmd.Parameters.AddWithValue("@Price", txtDogPetCarePrice.Text);
            cmd.Parameters.AddWithValue("@Date_Expiring", dateTimePickerPCS.Text);
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
            txtDogPetCareStockItems.Text = "";
            txtDogPetCareQuantity.Text = "";
            txtDogPetCareWeight.Text = "";
            txtDogPetCarePrice.Text = "";
            dateTimePickerPCS.Text = "";

        }

        private void Dog_Pet_Care_Stock_Load(object sender, EventArgs e)
        {

        }
    }
}
