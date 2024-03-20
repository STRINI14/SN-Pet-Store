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
    public partial class Cat_Acc_Sale : Form
    {
        public Cat_Acc_Sale()
        {
            InitializeComponent();
        }

        private void Cat_Acc_Sale_Load(object sender, EventArgs e)
        {

        }

        private void cboCatAccSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCatAccSaleItems.SelectedItem.ToString() == "PET FUR REMOVER")
            {
                txtCatAccSalePrice.Text = "179";

            }

            else
                if (cboCatAccSaleItems.SelectedItem.ToString() == "ANTI-TRACKING MAT")
                {
                    txtCatAccSalePrice.Text = "135";

                }
                else
                    if (cboCatAccSaleItems.SelectedItem.ToString() == "REX TRAVEL CASE")
                    {
                        txtCatAccSalePrice.Text = "275";

                    }
                    else
                        if (cboCatAccSaleItems.SelectedItem.ToString() == "WOODEN CAT SCRATCHER")
                        {
                            txtCatAccSalePrice.Text = "80";

                        }
                        else
                            if (cboCatAccSaleItems.SelectedItem.ToString() == "CAT SCRATCH AND LOUNGE")
                            {
                                txtCatAccSalePrice.Text = "300";

                            }
                            else
                                if (cboCatAccSaleItems.SelectedItem.ToString() == "ROUND CAT CAVE")
                                {
                                    txtCatAccSalePrice.Text = "680";

                                }
                                else
                                    if (cboCatAccSaleItems.SelectedItem.ToString() == "CAT PAN")
                                    {
                                        txtCatAccSalePrice.Text = "165";

                                    }
                                    else
                                        if (cboCatAccSaleItems.SelectedItem.ToString() == "KITTY CUDDLE PAL")
                                        {
                                            txtCatAccSalePrice.Text = "120";

                                        }
                                        else
                                            if (cboCatAccSaleItems.SelectedItem.ToString() == "SCRATCHING BLOCK")
                                            {
                                                txtCatAccSalePrice.Text = "50";

                                            }
                                            else
                                                if (cboCatAccSaleItems.SelectedItem.ToString() == "KITTY CAT BRUSH")
                                                {
                                                    txtCatAccSalePrice.Text = "40";

                                                }
                                                else
                                                    if (cboCatAccSaleItems.SelectedItem.ToString() == "CAT LITTER TRAY")
                                                    {
                                                        txtCatAccSalePrice.Text = "340";

                                                    }
                                                    else
                                                        if (cboCatAccSaleItems.SelectedItem.ToString() == "LITTER SCOOP")
                                                        {
                                                            txtCatAccSalePrice.Text = "52";

                                                        }
                                                        else
                                                            if (cboCatAccSaleItems.SelectedItem.ToString() == "KNIT PET HOME")
                                                            {
                                                                txtCatAccSalePrice.Text = "1250";

                                                            }
                                                            else
                                                                if (cboCatAccSaleItems.SelectedItem.ToString() == "CAT TUNNEL")
                                                                {
                                                                    txtCatAccSalePrice.Text = "180";

                                                                }
                                                                else
                                                                    if (cboCatAccSaleItems.SelectedItem.ToString() == "MEDIUM COLLAR")
                                                                    {
                                                                        txtCatAccSalePrice.Text = "53";

                                                                    }
                                                                    else
                                                                        if (cboCatAccSaleItems.SelectedItem.ToString() == "SOFT HARNESS WITH LEASH")
                                                                        {
                                                                            txtCatAccSalePrice.Text = "220";

                                                                        }


        }

        private void txtCatAccSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtCatAccSaleQuantity.Text.Length > 0)
            {
                txtCatAccSaleTotal.Text = (Convert.ToInt16(txtCatAccSalePrice.Text) * Convert.ToInt16(txtCatAccSaleQuantity.Text)).ToString();
            }
        }

        private void txCatAccSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtCatAccSaleDiscount.Text.Length > 0)
            {
                txtCatAccSaleAmountDue.Text = (Convert.ToInt16(txtCatAccSaleTotal.Text) - Convert.ToInt16(txtCatAccSaleDiscount.Text)).ToString();
            }
        }

        private void txtCatAccSaleAmountDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtCatAccSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvCatAccSale.Rows.Count - 1; i++)
            {
                txtCatAccSaleFinalTotal.Text = Convert.ToString(int.Parse(txtCatAccSaleFinalTotal.Text) + int.Parse(dgvCatAccSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtCatAccSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtCatAccSaleAmountPaid.Text.Length > 0)
            {
                txtCatAccSaleChangeDue.Text = (Convert.ToInt16(txtCatAccSaleAmountPaid.Text) - Convert.ToInt16(txtCatAccSaleFinalTotal.Text)).ToString();
            }
        
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvCatAccSale.Rows.Add();
            row = dgvCatAccSale.Rows.Count - 2;
            dgvCatAccSale["Item", row].Value = cboCatAccSaleItems.Text;
            dgvCatAccSale["Quantity", row].Value = txtCatAccSaleQuantity.Text;
            dgvCatAccSale["Price", row].Value = txtCatAccSalePrice.Text;
            dgvCatAccSale["Total", row].Value = txtCatAccSaleAmountDue.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCatAccSaleFinalTotal.Text = "";
            txtCatAccSaleAmountPaid.Text = "";
            txtCatAccSaleChangeDue.Text = "";

        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            cboCatAccSaleItems.Text = "";
            txtCatAccSalePrice.Text = "";
            txtCatAccSaleQuantity.Text = "";
            txtCatAccSaleTotal.Text = "";
            txtCatAccSaleDiscount.Text = "";
            txtCatAccSaleAmountDue.Text = "";
            txtCatAccSaleAmountPaid.Text = "";
            txtCatAccSaleChangeDue.Text = "";
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Cat_Acc_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboCatAccSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtCatAccSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtCatAccSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtCatAccSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtCatAccSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtCatAccSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Cats_Menu cm = new Cats_Menu();
            cm.Show();
        
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvCatAccSale.Rows.Clear();
        }

        private void txtCatAccSalePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatAccSaleTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
