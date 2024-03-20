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
    public partial class Bird_Pet_Sale : Form
    {
        public Bird_Pet_Sale()
        {
            InitializeComponent();
        }
        string connectionstring = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True";
        private void dgvCatPetSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvBirdPetSale.Rows.Clear();
        
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Birds_Menu bm = new Birds_Menu();
            bm.Show();
        }

        private void cboBirdPetSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboBirdPetSaleItems.SelectedItem.ToString() == "CHARLIE")
            {
                txtBirdPetSalePrice.Text = "450";


            }

            else
                if (cboBirdPetSaleItems.SelectedItem.ToString() == "COCO")
                {
                    txtBirdPetSalePrice.Text = "600";
                }
                else
                    if (cboBirdPetSaleItems.SelectedItem.ToString() == "BUDDY")
                    {
                        txtBirdPetSalePrice.Text = "650";
                    }
                    else
                        if (cboBirdPetSaleItems.SelectedItem.ToString() == "DAISY")
                        {
                            txtBirdPetSalePrice.Text = "3000";
                        }
                        else
                            if (cboBirdPetSaleItems.SelectedItem.ToString() == "PEPPER")
                            {
                                txtBirdPetSalePrice.Text = "1000";
                            }
                            else
                                if (cboBirdPetSaleItems.SelectedItem.ToString() == "TWEETY")
                                {
                                    txtBirdPetSalePrice.Text = "750";
                                }

        }

        private void txtBirdPetSaleQuantity_TextChanged(object sender, EventArgs e)
        {

            if (txtBirdPetSaleQuantity.Text.Length > 0)
            {
                txtBirdPetSaleTotal.Text = (Convert.ToInt16(txtBirdPetSalePrice.Text) * Convert.ToInt16(txtBirdPetSaleQuantity.Text)).ToString();
            }
        }

        private void txtBirdPetSaleTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBirdPetSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdPetSaleDiscount.Text.Length > 0)
            {
                txtBirdPetSaleAmountDue.Text = (Convert.ToInt16(txtBirdPetSaleTotal.Text) - Convert.ToInt16(txtBirdPetSaleDiscount.Text)).ToString();
            }
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtBirdPetSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvBirdPetSale.Rows.Count - 1; i++)
            {
                txtBirdPetSaleFinalTotal.Text = Convert.ToString(int.Parse(txtBirdPetSaleFinalTotal.Text) + int.Parse(dgvBirdPetSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtBirdPetSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdPetSaleAmountPaid.Text.Length > 0)
            {
                txtBirdPetSaleChangeDue.Text = (Convert.ToInt16(txtBirdPetSaleAmountPaid.Text) - Convert.ToInt16(txtBirdPetSaleFinalTotal.Text)).ToString();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pbBirdPetSale.Load(OD.FileName);
        }

        private void btnClearBoxes_Click(object sender, EventArgs e)
        {
            txtBirdPetSaleFinalTotal.Text = "";
            txtBirdPetSaleAmountPaid.Text = "";
            txtBirdPetSaleChangeDue.Text = "";
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {

            cboBirdPetSaleItems.Text = "";
            txtBirdPetSalePrice.Text = "";
            txtBirdPetSaleQuantity.Text = "";
            txtBirdPetSaleTotal.Text = "";
            txtBirdPetSaleDiscount.Text = "";
            txtBirdPetSaleAmountDue.Text = "";
            txtBirdPetSaleAmountPaid.Text = "";
            txtBirdPetSaleChangeDue.Text = "";
            pbBirdPetSale.Image = null;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvBirdPetSale.Rows.Add();
            row = dgvBirdPetSale.Rows.Count - 2;
            dgvBirdPetSale["Item", row].Value = cboBirdPetSaleItems.Text;
            dgvBirdPetSale["Quantity", row].Value = txtBirdPetSaleQuantity.Text;
            dgvBirdPetSale["Price", row].Value = txtBirdPetSalePrice.Text;
            dgvBirdPetSale["Total", row].Value = txtBirdPetSaleAmountDue.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand command = con.CreateCommand();
            var image = new ImageConverter().ConvertTo(pbBirdPetSale.Image, typeof(Byte[]));
            command.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@Item", cboBirdPetSaleItems.Text);
            command.Parameters.AddWithValue("@Price", txtBirdPetSalePrice.Text);
            command.Parameters.AddWithValue("@Quantity", txtBirdPetSaleQuantity.Text);
            command.Parameters.AddWithValue("@Total", txtBirdPetSaleTotal.Text);
            command.Parameters.AddWithValue("@Discount", txtBirdPetSaleDiscount.Text);
            command.Parameters.AddWithValue("@Amount_Due", txtBirdPetSaleAmountDue.Text);
            command.Parameters.AddWithValue("@Photo", image);
            command.CommandText = ("insert into Bird_Pet_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due,Photo) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due,@Photo)");
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Data Was Inserted Successfully.", "Operation Successful.");
            else
                MessageBox.Show("Incorrect Details Inserted.");
            con.Close();
        }

        private void Bird_Pet_Sale_Load(object sender, EventArgs e)
        {

        }
    }
}
