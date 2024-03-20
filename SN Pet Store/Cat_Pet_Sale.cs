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
    public partial class Cat_Pet_Sale : Form
    {
        public Cat_Pet_Sale()
        {
            InitializeComponent();
        }
        string connectionstring = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True";

        private void cboCatPetSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboCatPetSaleItems.SelectedItem.ToString() == "BELLA")
            {
                txtCatPetSalePrice.Text = "500";


            }

            else
                if (cboCatPetSaleItems.SelectedItem.ToString() == "MAX")
                {
                    txtCatPetSalePrice.Text = "450";
                }
                else
                    if (cboCatPetSaleItems.SelectedItem.ToString() == "LUCY")
                    {
                        txtCatPetSalePrice.Text = "560";
                    }

        }

        private void Cat_Pet_Sale_Load(object sender, EventArgs e)
        {

        }

        private void txtCatPetSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtCatPetSaleQuantity.Text.Length > 0)
            {
                txtCatPetSaleTotal.Text = (Convert.ToInt16(txtCatPetSalePrice.Text) * Convert.ToInt16(txtCatPetSaleQuantity.Text)).ToString();
            }
        }

        private void txtCatPetSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtCatPetSaleDiscount.Text.Length > 0)
            {
                txtCatPetSaleAmountDue.Text = (Convert.ToInt16(txtCatPetSaleTotal.Text) - Convert.ToInt16(txtCatPetSaleDiscount.Text)).ToString();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Cats_Menu cm = new Cats_Menu();
            cm.Show();
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvCatPetSale.Rows.Clear();
        
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtCatPetSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvCatPetSale.Rows.Count - 1; i++)
            {
                txtCatPetSaleFinalTotal.Text = Convert.ToString(int.Parse(txtCatPetSaleFinalTotal.Text) + int.Parse(dgvCatPetSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtCatPetSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtCatPetSaleAmountPaid.Text.Length > 0)
            {
                txtCatPetSaleChangeDue.Text = (Convert.ToInt16(txtCatPetSaleAmountPaid.Text) - Convert.ToInt16(txtCatPetSaleFinalTotal.Text)).ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvCatPetSale.Rows.Add();
            row = dgvCatPetSale.Rows.Count - 2;
            dgvCatPetSale["Item", row].Value = cboCatPetSaleItems.Text;
            dgvCatPetSale["Quantity", row].Value = txtCatPetSaleQuantity.Text;
            dgvCatPetSale["Price", row].Value = txtCatPetSalePrice.Text;
            dgvCatPetSale["Total", row].Value = txtCatPetSaleAmountDue.Text;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {

            cboCatPetSaleItems.Text = "";
            txtCatPetSalePrice.Text = "";
            txtCatPetSaleQuantity.Text = "";
            txtCatPetSaleTotal.Text = "";
            txtCatPetSaleDiscount.Text = "";
            txtCatPetSaleAmountDue.Text = "";
            txtCatPetSaleAmountPaid.Text = "";
            txtCatPetSaleChangeDue.Text = "";
            pbCatPetSale.Image = null;
        }

        private void btnClearBoxes_Click(object sender, EventArgs e)
        {
            txtCatPetSaleFinalTotal.Text = "";
            txtCatPetSaleAmountPaid.Text = "";
            txtCatPetSaleChangeDue.Text = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pbCatPetSale.Load(OD.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand command = con.CreateCommand();
            var image = new ImageConverter().ConvertTo(pbCatPetSale.Image, typeof(Byte[]));
            command.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@Item", cboCatPetSaleItems.Text);
            command.Parameters.AddWithValue("@Price", txtCatPetSalePrice.Text);
            command.Parameters.AddWithValue("@Quantity", txtCatPetSaleQuantity.Text);
            command.Parameters.AddWithValue("@Total", txtCatPetSaleTotal.Text);
            command.Parameters.AddWithValue("@Discount", txtCatPetSaleDiscount.Text);
            command.Parameters.AddWithValue("@Amount_Due", txtCatPetSaleAmountDue.Text);
            command.Parameters.AddWithValue("@Photo", image);
            command.CommandText = ("insert into Cat_Pet_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due,Photo) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due,@Photo)");
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Data Was Inserted Successfully.", "Operation Successful.");
            else
                MessageBox.Show("Incorrect Details Inserted.");
            con.Close();
        }

        private void txtCatPetSalePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatPetSaleTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatPetSaleAmountDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatPetSaleChangeDue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
