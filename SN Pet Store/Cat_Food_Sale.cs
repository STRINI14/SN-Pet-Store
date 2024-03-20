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
    public partial class Cat_Food_Sale : Form
    {
        public Cat_Food_Sale()
        {
            InitializeComponent();
        }

        private void cboCatFoodSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCatFoodSaleItems.SelectedItem.ToString() == "FELINE CUISINE ADULT SALMON AND RICE")
            {
                txtCatFoodSalePrice.Text = "110";

            }
            else
                if (cboCatFoodSaleItems.SelectedItem.ToString() == "CATMOR ADULT FOOD TUNA")
                {
                    txtCatFoodSalePrice.Text = "115";

                }
                else
                    if (cboCatFoodSaleItems.SelectedItem.ToString() == "CATMOR FOOD ADULT CHICKEN 2KG")
                    {
                        txtCatFoodSalePrice.Text = "115";
                    }
                    else
                        if (cboCatFoodSaleItems.SelectedItem.ToString() == "CATMOR FOOD ADULT CHICKEN 4KG")
                        {
                            txtCatFoodSalePrice.Text = "115";
                        }
                        else
                            if (cboCatFoodSaleItems.SelectedItem.ToString() == "CATMOR ADULT FOOD SALMON")
                            {
                                txtCatFoodSalePrice.Text = "54";
                            }
                            else
                                if (cboCatFoodSaleItems.SelectedItem.ToString() == "WHISKAS CHICKEN FLAVOURED GRAVY")
                                {
                                    txtCatFoodSalePrice.Text = "9";
                                }
                                else
                                    if (cboCatFoodSaleItems.SelectedItem.ToString() == "CATMOR GRAVY CHUNKS BEEF")
                                    {
                                        txtCatFoodSalePrice.Text = "7";
                                    }
                                    else
                                        if (cboCatFoodSaleItems.SelectedItem.ToString() == "WHISKAS ONE YEAR FOOD MEAT PLATTER")
                                        {
                                            txtCatFoodSalePrice.Text = "150";
                                        }
                                        else
                                            if (cboCatFoodSaleItems.SelectedItem.ToString() == "WHISKAS GRAVY POUCH")
                                            {
                                                txtCatFoodSalePrice.Text = "8";
                                            }
                                            else
                                                if (cboCatFoodSaleItems.SelectedItem.ToString() == "WHISKAS CHICKEN AND TURKEY")
                                                {
                                                    txtCatFoodSalePrice.Text = "150";
                                                }
                                                else
                                                    if (cboCatFoodSaleItems.SelectedItem.ToString() == "PAMPER CIG TURKEY")
                                                    {
                                                        txtCatFoodSalePrice.Text = "15";
                                                    }
                                                    else
                                                        if (cboCatFoodSaleItems.SelectedItem.ToString() == "PAMPER CIG TURKEY")
                                                        {
                                                            txtCatFoodSalePrice.Text = "15";
                                                        }

                                                        else
                                                            if (cboCatFoodSaleItems.SelectedItem.ToString() == "PAMPER CIG BEEF AND LIVER")
                                                            {
                                                                txtCatFoodSalePrice.Text = "16";
                                                            }
                                                            else
                                                                if (cboCatFoodSaleItems.SelectedItem.ToString() == "PAMPER MINCE AND STEAK")
                                                                {
                                                                    txtCatFoodSalePrice.Text = "15";

                                                                }
                                                                else
                                                                    if (cboCatFoodSaleItems.SelectedItem.ToString() == "CATMOR ADULT CHICKEN POUCH")
                                                                    {
                                                                        txtCatFoodSalePrice.Text = "7";

                                                                    }

        
        
        }

        private void txtCatFoodSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtCatFoodSaleQuantity.Text.Length > 0)
            {
                txtCatFoodSaleTotal.Text = (Convert.ToInt16(txtCatFoodSalePrice.Text) * Convert.ToInt16(txtCatFoodSaleQuantity.Text)).ToString();
            }
        }

        private void txtCatFoodSaleTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatFoodSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtCatFoodSaleDiscount.Text.Length > 0)
            {
                txtCatFoodSaleAmountDue.Text = (Convert.ToInt16(txtCatFoodSaleTotal.Text) - Convert.ToInt16(txtCatFoodSaleDiscount.Text)).ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvCatFoodSale.Rows.Add();
            row = dgvCatFoodSale.Rows.Count - 2;
            dgvCatFoodSale["Item", row].Value = cboCatFoodSaleItems.Text;
            dgvCatFoodSale["Quantity", row].Value = txtCatFoodSaleQuantity.Text;
            dgvCatFoodSale["Price", row].Value = txtCatFoodSalePrice.Text;
            dgvCatFoodSale["Total", row].Value = txtCatFoodSaleAmountDue.Text;
        }

        private void btnClearBoxes_Click(object sender, EventArgs e)
        {

            txtCatFoodSaleFinalTotal.Text = "";
            txtCatFoodSaleAmountPaid.Text = "";
            txtCatFoodSaleChangeDue.Text = "";
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtCatFoodSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvCatFoodSale.Rows.Count - 1; i++)
            {
                txtCatFoodSaleFinalTotal.Text = Convert.ToString(int.Parse(txtCatFoodSaleFinalTotal.Text) + int.Parse(dgvCatFoodSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            cboCatFoodSaleItems.Text = "";
            txtCatFoodSalePrice.Text = "";
            txtCatFoodSaleQuantity.Text = "";
            txtCatFoodSaleTotal.Text = "";
            txtCatFoodSaleDiscount.Text = "";
            txtCatFoodSaleAmountDue.Text = "";
            txtCatFoodSaleAmountPaid.Text = "";
            txtCatFoodSaleChangeDue.Text = "";


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Cat_Food_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboCatFoodSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtCatFoodSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtCatFoodSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtCatFoodSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtCatFoodSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtCatFoodSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }

        private void Cat_Food_Sale_Load(object sender, EventArgs e)
        {
        
        }

        private void txtCatFoodSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtCatFoodSaleAmountPaid.Text.Length > 0)
            {
                txtCatFoodSaleChangeDue.Text = (Convert.ToInt16(txtCatFoodSaleAmountPaid.Text) - Convert.ToInt16(txtCatFoodSaleFinalTotal.Text)).ToString();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Cats_Menu cm = new Cats_Menu();
            cm.Show();
        }

        private void txtCatFoodSalePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatFoodSaleAmountDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvCatFoodSale.Rows.Clear();


        }
    }
}
