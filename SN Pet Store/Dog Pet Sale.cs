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
    public partial class Dog_Pet_Sale : Form
    {
        public Dog_Pet_Sale()
        {
            InitializeComponent();
        }
        string connectionstring = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True";
        private void Dog_Pet_Sale_Load(object sender, EventArgs e)
        {

        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Dogs_Menu dm = new Dogs_Menu();
            dm.Show();
        }

        private void txtDogPetSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtDogPetSaleQuantity.Text.Length > 0)
            {
                txtDogPetSaleTotal.Text = (Convert.ToInt16(txtDogPetSalePrice.Text) * Convert.ToInt16(txtDogPetSaleQuantity.Text)).ToString();
            }
        }

        private void txtDogPetSalePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogPetSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDogPetSaleDiscount.Text.Length > 0)
            {
                txtDogPetSaleAmountDue.Text = (Convert.ToInt16(txtDogPetSaleTotal.Text) - Convert.ToInt16(txtDogPetSaleDiscount.Text)).ToString();
            }
        
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {

            cboDogPetSaleItems.Text = "";
            txtDogPetSalePrice.Text = "";
            txtDogPetSaleQuantity.Text = "";
            txtDogPetSaleTotal.Text = "";
            txtDogPetSaleDiscount.Text = "";
            txtDogPetSaleAmountDue.Text = "";
            txtDogPetSaleAmountPaid.Text = "";
            txtDogPetSaleChangeDue.Text = "";
            pbDogPetSale.Image = null;
        }

        private void btnClearBoxes_Click(object sender, EventArgs e)
        {
            txtDogPetSaleFinalTotal.Text = "";
            txtDogPetSaleAmountPaid.Text = "";
            txtDogPetSaleChangeDue.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvDogPetSale.Rows.Add();
            row = dgvDogPetSale.Rows.Count - 2;
            dgvDogPetSale["Item", row].Value = cboDogPetSaleItems.Text;
            dgvDogPetSale["Quantity", row].Value = txtDogPetSaleQuantity.Text;
            dgvDogPetSale["Price", row].Value = txtDogPetSalePrice.Text;
            dgvDogPetSale["Total", row].Value = txtDogPetSaleAmountDue.Text;
        }

        private void cboDogPetSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDogPetSaleItems.SelectedItem.ToString() == "JOJO")
            {
                txtDogPetSalePrice.Text = "130";  
                

            }

            else
                if (cboDogPetSaleItems.SelectedItem.ToString() == "RASCAL")
                {
                    txtDogPetSalePrice.Text = "850";
                }
                else
                    if (cboDogPetSaleItems.SelectedItem.ToString() == "ROCKY")
                    {
                        txtDogPetSalePrice.Text = "145";

                    }
                    else
                        if (cboDogPetSaleItems.SelectedItem.ToString() == "MILO")
                        {
                            txtDogPetSalePrice.Text = "1000";
                        }

                




        }








        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand command = con.CreateCommand();
            var image = new ImageConverter().ConvertTo(pbDogPetSale.Image, typeof(Byte[]));
            command.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@Item", cboDogPetSaleItems.Text);
            command.Parameters.AddWithValue("@Price", txtDogPetSalePrice.Text);
            command.Parameters.AddWithValue("@Quantity", txtDogPetSaleQuantity .Text);
            command.Parameters.AddWithValue("@Total", txtDogPetSaleTotal.Text);
            command.Parameters.AddWithValue("@Discount", txtDogPetSaleDiscount.Text);
            command.Parameters.AddWithValue("@Amount_Due", txtDogPetSaleAmountDue.Text);
            command.Parameters.AddWithValue("@Photo", image);
            command.CommandText = ("insert into Dog_Pet_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due,Photo) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due,@Photo)");
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Data Was Inserted Successfully.", "Operation Successful.");
            else
                MessageBox.Show("Incorrect Details Inserted.");
            con.Close();
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pbDogPetSale.Load(OD.FileName);
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvDogPetSale.Rows.Clear();
        
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtDogPetSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvDogPetSale.Rows.Count - 1; i++)
            {
                txtDogPetSaleFinalTotal.Text = Convert.ToString(int.Parse(txtDogPetSaleFinalTotal.Text) + int.Parse(dgvDogPetSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtDogPetSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtDogPetSaleAmountPaid.Text.Length > 0)
            {
                txtDogPetSaleChangeDue.Text = (Convert.ToInt16(txtDogPetSaleAmountPaid.Text) - Convert.ToInt16(txtDogPetSaleFinalTotal.Text)).ToString();
            }
        
        }

        private void txtDogPetSaleTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogPetSaleAmountDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogPetSaleChangeDue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
