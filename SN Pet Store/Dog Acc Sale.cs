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
    public partial class Dog_Acc_Sale : Form
    {
        public Dog_Acc_Sale()
        {
            InitializeComponent();
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvDogAccSale.Rows.Clear();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Dogs_Menu dm = new Dogs_Menu();
            dm.Show();
        }

        private void cboDogAccSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDogAccSaleItems.SelectedItem.ToString() == "SMALL DOG BED ")
            {
                txtDogAccSalePrice.Text = "50";

            }

            else
                if (cboDogAccSaleItems.SelectedItem.ToString() == "MEDIUM DOG BED")
                {
                    txtDogAccSalePrice.Text = "90";

                }

                else
                    if (cboDogAccSaleItems.SelectedItem.ToString() == "LARGE DOG BED")
                    {
                        txtDogAccSalePrice.Text = "110";

                    }
                    else
                        if (cboDogAccSaleItems.SelectedItem.ToString() == "WOODEN KENNEL SMALL")
                        {
                            txtDogAccSalePrice.Text = "80";

                        }
                        else
                            if (cboDogAccSaleItems.SelectedItem.ToString() == "WOODEN KENNEL LARGE")
                            {
                                txtDogAccSalePrice.Text = "120";

                            }
                            else
                                if (cboDogAccSaleItems.SelectedItem.ToString() == "PLASTIC KENNEL SMALL")
                                {
                                    txtDogAccSalePrice.Text = "60";

                                }
                                else
                                    if (cboDogAccSaleItems.SelectedItem.ToString() == "PLASTIC KENNEL LARGE")
                                    {
                                        txtDogAccSalePrice.Text = "100";


                                    }
                                    else
                                        if (cboDogAccSaleItems.SelectedItem.ToString() == "STAINLESS STEEL DOG BOWL")
                                        {
                                            txtDogAccSalePrice.Text = "70";


                                        }
                                        else
                                            if (cboDogAccSaleItems.SelectedItem.ToString() == "PLASTIC DOG BOWL")
                                            {
                                                txtDogAccSalePrice.Text = "40";


                                            }
                                            else
                                                if (cboDogAccSaleItems.SelectedItem.ToString() == "SMALL DOG BLANKET")
                                                {
                                                    txtDogAccSalePrice.Text = "25";

                                                }
                                                else
                                                    if (cboDogAccSaleItems.SelectedItem.ToString() == "MEDIUM DOG BLANKET")
                                                    {
                                                        txtDogAccSalePrice.Text = "35";

                                                    }
                                                    else
                                                        if (cboDogAccSaleItems.SelectedItem.ToString() == "RED NECK COLLAR")
                                                        {
                                                            txtDogAccSalePrice.Text = "20";

                                                        }
                                                        else
                                                            if (cboDogAccSaleItems.SelectedItem.ToString() == "BLACK NECK COLLAR")
                                                            {
                                                                txtDogAccSalePrice.Text = "20";

                                                            }
                                                            else
                                                                if (cboDogAccSaleItems.SelectedItem.ToString() == "SMALL DOG CHAIN")
                                                                {
                                                                    txtDogAccSalePrice.Text = "40";

                                                                }
                                                                else
                                                                    if (cboDogAccSaleItems.SelectedItem.ToString() == "LARGE DOG CHAIN")
                                                                    {
                                                                        txtDogAccSalePrice.Text = "60";

                                                                    }
                                                                    else
                                                                        if (cboDogAccSaleItems.SelectedItem.ToString() == "RAW HOOF")
                                                                        {
                                                                            txtDogAccSalePrice.Text = "25";

                                                                        }
                                                                        else
                                                                            if (cboDogAccSaleItems.SelectedItem.ToString() == "RAW HIDE")
                                                                            {
                                                                                txtDogAccSalePrice.Text = "30";

                                                                            }
                                                                            else
                                                                                if (cboDogAccSaleItems.SelectedItem.ToString() == "PACK OF 3 TENNIS BALLS")
                                                                                {
                                                                                    txtDogAccSalePrice.Text = "40";

                                                                                }

            txtDogAccSaleTotal.Text = "";
            txtDogAccSaleQuantity.Text = "";
            txtDogAccSaleDiscount.Text = "";
            txtDogAccSaleAmountDue.Text = ""; 

        }

        private void txtDogAccSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtDogAccSaleQuantity.Text.Length > 0)
            {
                txtDogAccSaleTotal.Text = (Convert.ToInt16(txtDogAccSalePrice.Text) * Convert.ToInt16(txtDogAccSaleQuantity.Text)).ToString();
            }
        }

        private void txtDogAccSalePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogAccSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDogAccSaleDiscount.Text.Length > 0)
            {
                txtDogAccSaleAmountDue.Text = (Convert.ToInt16(txtDogAccSaleTotal.Text) - Convert.ToInt16(txtDogAccSaleDiscount.Text)).ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboDogAccSaleItems.Text = "";
            txtDogAccSalePrice.Text = "";
            txtDogAccSaleQuantity.Text = "";
            txtDogAccSaleTotal.Text = "";
            txtDogAccSaleDiscount.Text = "";
            txtDogAccSaleAmountDue.Text = "";
            txtDogAccSaleAmountPaid.Text = "";
            txtDogAccSaleChangeDue.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvDogAccSale.Rows.Add();
            row = dgvDogAccSale.Rows.Count - 2;
            dgvDogAccSale["Item", row].Value = cboDogAccSaleItems.Text;
            dgvDogAccSale["Quantity", row].Value = txtDogAccSaleQuantity.Text;
            dgvDogAccSale["Price", row].Value = txtDogAccSalePrice.Text;
            dgvDogAccSale["Total", row].Value = txtDogAccSaleAmountDue.Text;
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtDogAccSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvDogAccSale.Rows.Count - 1; i++)
            {
                txtDogAccSaleFinalTotal.Text = Convert.ToString(int.Parse(txtDogAccSaleFinalTotal.Text) + int.Parse(dgvDogAccSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Dog_Acc_Sale(Date_Entered,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date_Entered,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date_Entered", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboDogAccSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtDogAccSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtDogAccSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtDogAccSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtDogAccSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtDogAccSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();

        }

        private void Dog_Acc_Sale_Load(object sender, EventArgs e)
        {

        }

        private void txtDogAccSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtDogAccSaleAmountPaid.Text.Length > 0)
            {
                txtDogAccSaleChangeDue.Text = (Convert.ToInt16(txtDogAccSaleAmountPaid.Text) - Convert.ToInt16(txtDogAccSaleFinalTotal.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDogAccSaleFinalTotal.Text = "";
            txtDogAccSaleAmountPaid.Text = "";
            txtDogAccSaleChangeDue.Text = "";

        }

        private void txtDogAccSaleTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogAccSaleAmountDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogAccSaleChangeDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogAccSaleFinalTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
