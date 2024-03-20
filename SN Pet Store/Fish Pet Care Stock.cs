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
    public partial class Fish_Pet_Care_Stock : Form
    {
        public Fish_Pet_Care_Stock()
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
            txtFishPetCareStockItems.Text = "";
            txtFishPetCareQuantity.Text = "";
            txtFishPetCareWeight.Text = "";
            txtFishPetCarePrice.Text = "";
            dateTimePickerFPCS.Text = "";
        }

        private void Fish_Pet_Care_Stock_Load(object sender, EventArgs e)
        {

        }

        private void btnFishPetCareSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Fish_Pet_Care_Stock(Date,Item,Quantity,Weight,Price,Date_Expiring) values(@Date,@Item,@Quantity,@Weight,@Price,@Date_Expiring)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker4.Text);
            cmd.Parameters.AddWithValue("@Item", txtFishPetCareStockItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtFishPetCareQuantity.Text);
            cmd.Parameters.AddWithValue("@Weight", txtFishPetCareWeight.Text);
            cmd.Parameters.AddWithValue("@Price", txtFishPetCarePrice.Text);
            cmd.Parameters.AddWithValue("@Date_Expiring", dateTimePickerFPCS.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }
    }
}
