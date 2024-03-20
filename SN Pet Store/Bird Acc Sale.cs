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
    public partial class Bird_Acc_Sale : Form
    {
        public Bird_Acc_Sale()
        {
            InitializeComponent();
        }

        private void cboBirdAccSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBirdAccSaleItems.SelectedItem.ToString() == "PARROT WOODEN PLAYGROUND")
            {
                txtBirdAccSalePrice.Text = "400";

            }

            else
                if (cboBirdAccSaleItems.SelectedItem.ToString() == "COCONUT SHELL BIRD HOUSE")
                {
                    txtBirdAccSalePrice.Text = "170";

                }
                else
                    if (cboBirdAccSaleItems.SelectedItem.ToString() == "WINTER WARM BIRD NEST")
                    {
                        txtBirdAccSalePrice.Text = "165";

                    }
                    else
                        if (cboBirdAccSaleItems.SelectedItem.ToString() == "LARGE HARNESS WITH LEASH")
                        {
                            txtBirdAccSalePrice.Text = "430";

                        }
                        else
                            if (cboBirdAccSaleItems.SelectedItem.ToString() == "PARROT CARRIER TRAVEL BAG")
                            {
                                txtBirdAccSalePrice.Text = "1460";

                            }
                            else
                                if (cboBirdAccSaleItems.SelectedItem.ToString() == "PARROT/BUDGIE CHEW BITE ROD")
                                {
                                    txtBirdAccSalePrice.Text = "15";

                                }
                                else
                                    if (cboBirdAccSaleItems.SelectedItem.ToString() == "INTERACTIVE GYM")
                                    {
                                        txtBirdAccSalePrice.Text = "400";

                                    }
                                    else
                                        if (cboBirdAccSaleItems.SelectedItem.ToString() == "WOODEN SWING CLIMB LADDER")
                                        {
                                            txtBirdAccSalePrice.Text = "320";

                                        }
                                        else
                                            if (cboBirdAccSaleItems.SelectedItem.ToString() == "PARROT PLAYGROUND")
                                            {
                                                txtBirdAccSalePrice.Text = "2800";

                                            }
                                            else
                                                if (cboBirdAccSaleItems.SelectedItem.ToString() == "PARROT CHEW ROPE HAMMOCK")
                                                {
                                                    txtBirdAccSalePrice.Text = "210";

                                                }
                                                else
                                                    if (cboBirdAccSaleItems.SelectedItem.ToString() == "PARROT PERCH ROPE")
                                                    {
                                                        txtBirdAccSalePrice.Text = "180";

                                                    }
                                                    else
                                                        if (cboBirdAccSaleItems.SelectedItem.ToString() == "PARROT BATHTUB")
                                                        {
                                                            txtBirdAccSalePrice.Text = "210";

                                                        }
                                                        else
                                                            if (cboBirdAccSaleItems.SelectedItem.ToString() == "PARROT DRINKING FEEDER")
                                                            {
                                                                txtBirdAccSalePrice.Text = "120";

                                                            }
                                                            else
                                                                if (cboBirdAccSaleItems.SelectedItem.ToString() == "BIRD CAGE COVER")
                                                                {
                                                                    txtBirdAccSalePrice.Text = "700";

                                                                }
                                                                else
                                                                    if (cboBirdAccSaleItems.SelectedItem.ToString() == "SMALL BIRD CAGE")
                                                                    {
                                                                        txtBirdAccSalePrice.Text = "300";

                                                                    }
                                                                    else
                                                                        if (cboBirdAccSaleItems.SelectedItem.ToString() == "LARGE METAL BIRD CAGE")
                                                                        {
                                                                            txtBirdAccSalePrice.Text = "4500";

                                                                        }
                                                                        else
                                                                            if (cboBirdAccSaleItems.SelectedItem.ToString() == "ROUND METAL BIRD CAGE")
                                                                            {
                                                                                txtBirdAccSalePrice.Text = "350";

                                                                            }
                                                                            else
                                                                                if (cboBirdAccSaleItems.SelectedItem.ToString() == "BIRD LAMP")
                                                                                {
                                                                                    txtBirdAccSalePrice.Text = "370";

                                                                                }

        }

        private void txtBirdAccSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdAccSaleQuantity.Text.Length > 0)
            {
                txtBirdAccSaleTotal.Text = (Convert.ToInt16(txtBirdAccSalePrice.Text) * Convert.ToInt16(txtBirdAccSaleQuantity.Text)).ToString();
            }
        }

        private void txtBirdAccSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdAccSaleDiscount.Text.Length > 0)
            {
                txtBirdAccSaleAmountDue.Text = (Convert.ToInt16(txtBirdAccSaleTotal.Text) - Convert.ToInt16(txtBirdAccSaleDiscount.Text)).ToString();
            }
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtBirdAccSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvFishAccSale.Rows.Count - 1; i++)
            {
                txtBirdAccSaleFinalTotal.Text = Convert.ToString(int.Parse(txtBirdAccSaleFinalTotal.Text) + int.Parse(dgvFishAccSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtBirdAccSaleChangeDue_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdAccSaleAmountPaid.Text.Length > 0)
            {
                txtBirdAccSaleChangeDue.Text = (Convert.ToInt16(txtBirdAccSaleAmountPaid.Text) - Convert.ToInt16(txtBirdAccSaleFinalTotal.Text)).ToString();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Birds_Menu bm = new Birds_Menu();
            bm.Show();
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvFishAccSale.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBirdAccSaleFinalTotal.Text = "";
            txtBirdAccSaleAmountPaid.Text = "";
            txtBirdAccSaleChangeDue.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvFishAccSale.Rows.Add();
            row = dgvFishAccSale.Rows.Count - 2;
            dgvFishAccSale["Item", row].Value = cboBirdAccSaleItems.Text;
            dgvFishAccSale["Quantity", row].Value = txtBirdAccSaleQuantity.Text;
            dgvFishAccSale["Price", row].Value = txtBirdAccSalePrice.Text;
            dgvFishAccSale["Total", row].Value = txtBirdAccSaleAmountDue.Text;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            cboBirdAccSaleItems.Text = "";
            txtBirdAccSalePrice.Text = "";
            txtBirdAccSaleQuantity.Text = "";
            txtBirdAccSaleTotal.Text = "";
            txtBirdAccSaleDiscount.Text = "";
            txtBirdAccSaleAmountDue.Text = "";
            txtBirdAccSaleAmountPaid.Text = "";
            txtBirdAccSaleChangeDue.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Bird_Acc_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboBirdAccSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtBirdAccSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtBirdAccSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtBirdAccSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtBirdAccSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtBirdAccSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }

        private void txtBirdAccSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdAccSaleAmountPaid.Text.Length > 0)
            {
                txtBirdAccSaleChangeDue.Text = (Convert.ToInt16(txtBirdAccSaleAmountPaid.Text) - Convert.ToInt16(txtBirdAccSaleFinalTotal.Text)).ToString();
            }
        }

        private void txtBirdAccSalePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bird_Acc_Sale_Load(object sender, EventArgs e)
        {

        }
    }
}
