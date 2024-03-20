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
    public partial class Fish_Food_Sale : Form
    {
        public Fish_Food_Sale()
        {
            InitializeComponent();
        }

        private void txtFishFoodSalePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFishFoodSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtFishFoodSaleQuantity.Text.Length > 0)
            {
                txtFishFoodSaleTotal.Text = (Convert.ToInt16(txtFishFoodSalePrice.Text) * Convert.ToInt16(txtFishFoodSaleQuantity.Text)).ToString();
            }
        }

        private void txtFishFoodSaleTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFishFoodSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtFishFoodSaleDiscount.Text.Length > 0)
            {
                txtFishFoodSaleAmountDue.Text = (Convert.ToInt16(txtFishFoodSaleTotal.Text) - Convert.ToInt16(txtFishFoodSaleDiscount.Text)).ToString();
            }
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtFishFoodSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvFishFoodSale.Rows.Count - 1; i++)
            {
                txtFishFoodSaleFinalTotal.Text = Convert.ToString(int.Parse(txtFishFoodSaleFinalTotal.Text) + int.Parse(dgvFishFoodSale.Rows[i].Cells[3].Value.ToString()));
            }
        
        }

        private void txtFishFoodSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtFishFoodSaleAmountPaid.Text.Length > 0)
            {
                txtFishFoodSaleChangeDue.Text = (Convert.ToInt16(txtFishFoodSaleAmountPaid.Text) - Convert.ToInt16(txtFishFoodSaleFinalTotal.Text)).ToString();
            }
        }

        private void btnClearBoxes_Click(object sender, EventArgs e)
        {

            txtFishFoodSaleFinalTotal.Text = "";
            txtFishFoodSaleAmountPaid.Text = "";
            txtFishFoodSaleChangeDue.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvFishFoodSale.Rows.Add();
            row = dgvFishFoodSale.Rows.Count - 2;
            dgvFishFoodSale["Item", row].Value = cboFishFoodSaleItems.Text;
            dgvFishFoodSale["Quantity", row].Value = txtFishFoodSaleQuantity.Text;
            dgvFishFoodSale["Price", row].Value = txtFishFoodSalePrice.Text;
            dgvFishFoodSale["Total", row].Value = txtFishFoodSaleAmountDue.Text;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            cboFishFoodSaleItems.Text = "";
            txtFishFoodSalePrice.Text = "";
            txtFishFoodSaleQuantity.Text = "";
            txtFishFoodSaleTotal.Text = "";
            txtFishFoodSaleDiscount.Text = "";
            txtFishFoodSaleAmountDue.Text = "";
            txtFishFoodSaleAmountPaid.Text = "";
            txtFishFoodSaleChangeDue.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Fish_Food_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboFishFoodSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtFishFoodSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtFishFoodSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtFishFoodSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtFishFoodSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtFishFoodSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        
        }

        private void Fish_Food_Sale_Load(object sender, EventArgs e)
        {

        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvFishFoodSale.Rows.Clear();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Fish_Menu fm = new Fish_Menu();
            fm.Show();
        }

        private void cboFishFoodSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFishFoodSaleItems.SelectedItem.ToString() == "MARLTONS GOLDFISH FLAKES FOOD")
            {
                txtFishFoodSalePrice.Text = "40";

            }
            else
                if (cboFishFoodSaleItems.SelectedItem.ToString() == "GRANTS TROPICAL FLAKE FOOD")
                {
                    txtFishFoodSalePrice.Text = "45";

                }
                else
                    if (cboFishFoodSaleItems.SelectedItem.ToString() == "TETRAMIN TROPICAL FLAKES")
                    {
                        txtFishFoodSalePrice.Text = "65";

                    }
                    else
                        if (cboFishFoodSaleItems.SelectedItem.ToString() == "GOLDFISH FLAKES")
                        {
                            txtFishFoodSalePrice.Text = "12";

                        }
                        else
                            if (cboFishFoodSaleItems.SelectedItem.ToString() == "GOLDFISH GRANULES")
                            {
                                txtFishFoodSalePrice.Text = "75";

                            }
                            else
                                if (cboFishFoodSaleItems.SelectedItem.ToString() == "BLOODWORM TREATS POND FOOD")
                                {
                                    txtFishFoodSalePrice.Text = "90";
                                }
                                else
                                    if (cboFishFoodSaleItems.SelectedItem.ToString() == "BOTTOM FEEDERS FISH FOOD")
                                    {
                                        txtFishFoodSalePrice.Text = "130";
                                    }
                                    else
                                        if (cboFishFoodSaleItems.SelectedItem.ToString() == "PRIMA GRANULES")
                                        {
                                            txtFishFoodSalePrice.Text = "60";
                                        }
                                        else
                                            if (cboFishFoodSaleItems.SelectedItem.ToString() == "BETTA BIO GOLD")
                                            {
                                                txtFishFoodSalePrice.Text = "40";
                                            }
                                            else
                                                if (cboFishFoodSaleItems.SelectedItem.ToString() == "TROPICAL FISH FLOATING PELLETS")
                                                {
                                                    txtFishFoodSalePrice.Text = "150";
                                                }
                                                else
                                                    if (cboFishFoodSaleItems.SelectedItem.ToString() == "HOLIDAY FOOD")
                                                    {
                                                        txtFishFoodSalePrice.Text = "110";
                                                    }
                                                    else
                                                        if (cboFishFoodSaleItems.SelectedItem.ToString() == "HOLIDAY BLOCK")
                                                        {
                                                            txtFishFoodSalePrice.Text = "110";
                                                        }
                                                        else
                                                            if (cboFishFoodSaleItems.SelectedItem.ToString() == "KOI FOOD PELLETS SMALL")
                                                            {
                                                                txtFishFoodSalePrice.Text = "75";
                                                            }
                                                            else
                                                                if (cboFishFoodSaleItems.SelectedItem.ToString() == "GOLDFISH WEEKEND STICKS")
                                                                {
                                                                    txtFishFoodSalePrice.Text = "90";
                                                                }
                                                                else
                                                                    if (cboFishFoodSaleItems.SelectedItem.ToString() == "HIKARI VIBRA BITES")
                                                                    {
                                                                        txtFishFoodSalePrice.Text = "120";
                                                                    }
                                                                    else
                                                                        if (cboFishFoodSaleItems.SelectedItem.ToString() == "GRANTS KOI MEDIUM POND PELLETS")
                                                                        {
                                                                            txtFishFoodSalePrice.Text = "140";
                                                                        }
                                                                      
        }
    }
}
