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
    public partial class Dog_Pet_Stock : Form
    {
        public Dog_Pet_Stock()
        {
            InitializeComponent();
        }

        

        private void Dog_Pet_Stock_Load(object sender, EventArgs e)
        {

        }
        string connectionstring = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True";
        private void btnDogPetSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand command = con.CreateCommand();
            var image = new ImageConverter().ConvertTo(pbDogPetStock.Image, typeof(Byte[]));
            command.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@Name", txtDogPetName.Text);
            command.Parameters.AddWithValue("@Age", txtDogPetAge.Text);
            command.Parameters.AddWithValue("@Gender", cboDogPetGender.Text);
            command.Parameters.AddWithValue("@Colour", txtDogPetColour.Text);
            command.Parameters.AddWithValue("@Weight", txtDogPetWeight.Text);
            command.Parameters.AddWithValue("@Breed", txtDogPetBreed.Text);
            command.Parameters.AddWithValue("@Price", txtDogPrice.Text);
            command.Parameters.AddWithValue("@Photo", image);
            command.CommandText = ("insert into Dog_Pet_Stock(Date,Name,Age,Gender,Colour,Weight,Breed,Price,Photo) values(@Date,@Name,@Age,@Gender,@Colour,@Weight,@Breed,@Price,@Photo)");
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Data Was Inserted Successfully.", "Operation Successful");
            else
                MessageBox.Show("Incorrect Details Inserted");
            con.Close();
            
            



             
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Dogs_Menu dm = new Dogs_Menu();
            dm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDogPetName.Text = "";
            txtDogPetAge.Text = "";
            cboDogPetGender.Text = "";
            txtDogPetColour.Text = "";
            txtDogPetWeight.Text = "";
            txtDogPetBreed.Text = "";
            txtDogPrice.Text = "";
            pbDogPetStock.Image = null;

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pbDogPetStock.Load(OD.FileName);
        }

        private void pbDogPetStock_Click(object sender, EventArgs e)
        {

        }

    }
}
