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
    public partial class Fish_Pet_Stock : Form
    {
        public Fish_Pet_Stock()
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
            txtFishPetName.Text = "";
            txtFishPetAge.Text = "";
            cboFishPetGender.Text = "";
            txtFishPetColour.Text = "";
            txtFishPetWeight.Text = "";
            txtFishPetBreed.Text = "";
            txtFishPetPrice.Text = "";
            pbFishPetStock.Image = null;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pbFishPetStock.Load(OD.FileName);
        }
        string connectionstring = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True";
        private void btnDogPetSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand command = con.CreateCommand();
            var image = new ImageConverter().ConvertTo(pbFishPetStock.Image, typeof(Byte[]));
            command.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@Name", txtFishPetName.Text);
            command.Parameters.AddWithValue("@Age", txtFishPetAge.Text);
            command.Parameters.AddWithValue("@Gender", cboFishPetGender.Text);
            command.Parameters.AddWithValue("@Colour", txtFishPetColour.Text);
            command.Parameters.AddWithValue("@Weight", txtFishPetWeight.Text);
            command.Parameters.AddWithValue("@Breed", txtFishPetBreed.Text);
            command.Parameters.AddWithValue("@Price", txtFishPetPrice.Text);
            command.Parameters.AddWithValue("@Photo", image);
            command.CommandText = ("insert into Fish_Pet_Stock(Date,Name,Age,Gender,Colour,Weight,Breed,Price,Photo) values(@Date,@Name,@Age,@Gender,@Colour,@Weight,@Breed,@Price,@Photo)");
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Data Was Inserted Successfully.", "Operation Successful");
            else
                MessageBox.Show("Incorrect Details Inserted");
            con.Close();
        }
    }
}
