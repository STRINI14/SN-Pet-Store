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
    public partial class Bird_Food_Sale : Form
    {
        public Bird_Food_Sale()
        {
            InitializeComponent();
        }

        private void cboBirdFoodSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBirdFoodSaleItems.SelectedItem.ToString() == "MARLTONS BUDGIE SEED MIX")
            {
                txtBirdFoodSalePrice.Text = "35";

            }
            else
                if (cboBirdFoodSaleItems.SelectedItem.ToString() == "MARLTONS GARDEN BIRD SEED MIX")
                {
                    txtBirdFoodSalePrice.Text = "50";

                }
            else
                if (cboBirdFoodSaleItems.SelectedItem.ToString() == "MARLTONS WILD BIRD SEED MIX")
                {
                    txtBirdFoodSalePrice.Text = "65";

                }
            else
                if (cboBirdFoodSaleItems.SelectedItem.ToString() == "MARLTONS WILD BIRD SEED 10KG")
                {
                    txtBirdFoodSalePrice.Text = "250";

                }
             else
                if (cboBirdFoodSaleItems.SelectedItem.ToString() == "MARLTONS PARROT FOOD")
                {
                    txtBirdFoodSalePrice.Text = "48";

                }
                else
                    if (cboBirdFoodSaleItems.SelectedItem.ToString() == "TROPICAL PARROT FOOD")
                    {
                        txtBirdFoodSalePrice.Text = "25";
                    }
                    else
                        if (cboBirdFoodSaleItems.SelectedItem.ToString() == "PARROT FOOD PLUMAGE ENHANCER")
                        {
                            txtBirdFoodSalePrice.Text = "55";
                        }
                        else
                            if (cboBirdFoodSaleItems.SelectedItem.ToString() == "PARROT FOOD FRUIT AND NUT")
                            {
                                txtBirdFoodSalePrice.Text = "55";
                            }
                            else
                                if (cboBirdFoodSaleItems.SelectedItem.ToString() == "PARROT FOOD CHILLI")
                                {
                                    txtBirdFoodSalePrice.Text = "35";
                                }
                                else
                                    if (cboBirdFoodSaleItems.SelectedItem.ToString() == "COCKATIEL MIX")
                                    {
                                        txtBirdFoodSalePrice.Text = "16";
                                    }
                                    else
                                        if (cboBirdFoodSaleItems.SelectedItem.ToString() == "CANARY MIXED BIRD SEED")
                                        {
                                            txtBirdFoodSalePrice.Text = "230";
                                        }
                                        else
                                            if (cboBirdFoodSaleItems.SelectedItem.ToString() == "COCKATIEL SEED")
                                            {
                                                txtBirdFoodSalePrice.Text = "150";
                                            }
                                            else
                                                if (cboBirdFoodSaleItems.SelectedItem.ToString() == "BUDGIE SEED TUB")
                                                {
                                                    txtBirdFoodSalePrice.Text = "240";
                                                }
                                                else
                                                    if (cboBirdFoodSaleItems.SelectedItem.ToString() == "PARROT FOOD TUB")
                                                    {
                                                        txtBirdFoodSalePrice.Text = "150";
                                                    }
                                                    else
                                                        if (cboBirdFoodSaleItems.SelectedItem.ToString() == "PARROT FOOD SMALL PELLETS")
                                                        {
                                                            txtBirdFoodSalePrice.Text = "450";
                                                        }
                                                       else
                                                        if (cboBirdFoodSaleItems.SelectedItem.ToString() == "COCKATIEL MIX LARGE")
                                                        {
                                                            txtBirdFoodSalePrice.Text = "350";
                                                        }
                                                        else
                                                        if (cboBirdFoodSaleItems.SelectedItem.ToString() == "PARROT FRUIT CHUNKS")
                                                        {
                                                            txtBirdFoodSalePrice.Text = "650";
                                                        }
                                                        else
                                                        if (cboBirdFoodSaleItems.SelectedItem.ToString() == "GRANULATED FOOD FOR COCKATIELS")
                                                        {
                                                            txtBirdFoodSalePrice.Text = "125";
                                                        }

        }

        private void txtBirdFoodSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdFoodSaleQuantity.Text.Length > 0)
            {
                txtBirdFoodSaleTotal.Text = (Convert.ToInt16(txtBirdFoodSalePrice.Text) * Convert.ToInt16(txtBirdFoodSaleQuantity.Text)).ToString();
            }
        }

        private void txtBirdFoodSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdFoodSaleDiscount.Text.Length > 0)
            {
                txtBirdFoodSaleAmountDue.Text = (Convert.ToInt16(txtBirdFoodSaleTotal.Text) - Convert.ToInt16(txtBirdFoodSaleDiscount.Text)).ToString();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Birds_Menu bm = new Birds_Menu();
            bm.Show();
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvBirdFoodSale.Rows.Clear();
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtBirdFoodSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvBirdFoodSale.Rows.Count - 1; i++)
            {
                txtBirdFoodSaleFinalTotal.Text = Convert.ToString(int.Parse(txtBirdFoodSaleFinalTotal.Text) + int.Parse(dgvBirdFoodSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtBirdFoodSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdFoodSaleAmountPaid.Text.Length > 0)
            {
                txtBirdFoodSaleChangeDue.Text = (Convert.ToInt16(txtBirdFoodSaleAmountPaid.Text) - Convert.ToInt16(txtBirdFoodSaleFinalTotal.Text)).ToString();
            }
        
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            cboBirdFoodSaleItems.Text = "";
            txtBirdFoodSalePrice.Text = "";
            txtBirdFoodSaleQuantity.Text = "";
            txtBirdFoodSaleTotal.Text = "";
            txtBirdFoodSaleDiscount.Text = "";
            txtBirdFoodSaleAmountDue.Text = "";
            txtBirdFoodSaleAmountPaid.Text = "";
            txtBirdFoodSaleChangeDue.Text = "";
        }

        private void btnClearBoxes_Click(object sender, EventArgs e)
        {

            txtBirdFoodSaleFinalTotal.Text = "";
            txtBirdFoodSaleAmountPaid.Text = "";
            txtBirdFoodSaleChangeDue.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvBirdFoodSale.Rows.Add();
            row = dgvBirdFoodSale.Rows.Count - 2;
            dgvBirdFoodSale["Item", row].Value = cboBirdFoodSaleItems.Text;
            dgvBirdFoodSale["Quantity", row].Value = txtBirdFoodSaleQuantity.Text;
            dgvBirdFoodSale["Price", row].Value = txtBirdFoodSalePrice.Text;
            dgvBirdFoodSale["Total", row].Value = txtBirdFoodSaleAmountDue.Text;
        }

        private void Bird_Food_Sale_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Bird_Food_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboBirdFoodSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtBirdFoodSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtBirdFoodSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtBirdFoodSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtBirdFoodSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtBirdFoodSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }

        private void txtBirdFoodSalePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBirdFoodSaleTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBirdFoodSaleAmountDue_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

