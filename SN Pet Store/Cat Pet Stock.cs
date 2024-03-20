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
    public partial class Cat_Pet_Stock : Form
    {
        public Cat_Pet_Stock()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Cats_Menu cm = new Cats_Menu();
            cm.Show();
        }

        private void pbCatPetStock_Click(object sender, EventArgs e)
        {

           }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCatPetName.Text = "";
            txtCatPetAge.Text = "";
            cboCatPetGender.Text = "";
            txtCatPetColour.Text = "";
            txtCatPetWeight.Text = "";
            txtCatPetBreed.Text = "";
            txtCatPetPrice.Text = "";
            pbCatPetStock.Image = null;

        }
        string connectionstring = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True";
        private void btnDogPetSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand command = con.CreateCommand();
            var image = new ImageConverter().ConvertTo(pbCatPetStock.Image, typeof(Byte[]));
            command.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@Name", txtCatPetName.Text);
            command.Parameters.AddWithValue("@Age", txtCatPetAge.Text);
            command.Parameters.AddWithValue("@Gender", cboCatPetGender.Text);
            command.Parameters.AddWithValue("@Colour", txtCatPetColour.Text);
            command.Parameters.AddWithValue("@Weight", txtCatPetWeight.Text);
            command.Parameters.AddWithValue("@Breed", txtCatPetBreed.Text);
            command.Parameters.AddWithValue("@Price", txtCatPetPrice.Text);
            command.Parameters.AddWithValue("@Photo", image);
            command.CommandText = ("insert into Cat_Pet_Stock(Date,Name,Age,Gender,Colour,Weight,Breed,Price,Photo) values(@Date,@Name,@Age,@Gender,@Colour,@Weight,@Breed,@Price,@Photo)");
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Data Was Inserted Successfully.", "Operation Successful");
            else
                MessageBox.Show("Incorrect Details Inserted");
            con.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pbCatPetStock.Load(OD.FileName);
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cat_Pet_Stock_Load(object sender, EventArgs e)
        {

        }
    }
}
