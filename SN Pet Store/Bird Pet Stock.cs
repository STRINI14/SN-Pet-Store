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
    public partial class Bird_Pet_Stock : Form
    {
        public Bird_Pet_Stock()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Birds_Menu bm = new Birds_Menu();
            bm.Show();
        }

        private void pbBirdPetStock_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pbBirdPetStock.Load(OD.FileName);
        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBirdPetName.Text = "";
            txtBirdPetAge.Text = "";
            cboBirdPetGender.Text = "";
            txtBirdPetColour.Text = "";
            txtBirdPetWeight.Text = "";
            txtBirdPetBreed.Text = "";
            txtBirdPetPrice.Text = "";
            pbBirdPetStock.Image = null;
        }
        string connectionstring = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True";
        private void btnDogPetSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand command = con.CreateCommand();
            var image = new ImageConverter().ConvertTo(pbBirdPetStock.Image, typeof(Byte[]));
            command.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@Name", txtBirdPetName.Text);
            command.Parameters.AddWithValue("@Age", txtBirdPetAge.Text);
            command.Parameters.AddWithValue("@Gender", cboBirdPetGender.Text);
            command.Parameters.AddWithValue("@Colour", txtBirdPetColour.Text);
            command.Parameters.AddWithValue("@Weight", txtBirdPetWeight.Text);
            command.Parameters.AddWithValue("@Breed", txtBirdPetBreed.Text);
            command.Parameters.AddWithValue("@Price", txtBirdPetPrice.Text);
            command.Parameters.AddWithValue("@Photo", image);
            command.CommandText = ("insert into Bird_Pet_Stock(Date,Name,Age,Gender,Colour,Weight,Breed,Price,Photo) values(@Date,@Name,@Age,@Gender,@Colour,@Weight,@Breed,@Price,@Photo)");
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Data Was Inserted Successfully.", "Operation Successful");
            else
                MessageBox.Show("Incorrect Details Inserted");
            con.Close();
        }
    }
}
