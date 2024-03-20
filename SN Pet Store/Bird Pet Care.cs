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
    public partial class Bird_Pet_Care_Stock : Form
    {
        public Bird_Pet_Care_Stock()
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
            txtBirdPetCareStockItems.Text = "";
            txtBirdPetCareQuantity.Text = "";
            txtBirdPetCareWeight.Text = "";
            txtBirdPetCarePrice.Text = "";
            dateTimePickerBPCS.Text = "";
        }

        private void btnDogPetCareSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Bird_Pet_Care_Stock(Date,Item,Quantity,Weight,Price,Date_Expiring) values(@Date,@Item,@Quantity,@Weight,@Price,@Date_Expiring)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker4.Text);
            cmd.Parameters.AddWithValue("@Item", txtBirdPetCareStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtBirdPetCareQuantity.Text);
            cmd.Parameters.AddWithValue("@Weight", txtBirdPetCareWeight.Text);
            cmd.Parameters.AddWithValue("@Price", txtBirdPetCarePrice.Text);
            cmd.Parameters.AddWithValue("@Date_Expiring", dateTimePickerBPCS.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }
    }
}
