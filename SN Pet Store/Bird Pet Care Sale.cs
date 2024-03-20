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
    public partial class Bird_Pet_Care_Sale : Form
    {
        public Bird_Pet_Care_Sale()
        {
            InitializeComponent();
        }

        private void cboBirdPetCareSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "MEDIMUNE TABLETS")
            {
                txtBirdPetCareSalePrice.Text = "140";

            }

            else
                if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "MEDIVITAL PLUS")
                {
                    txtBirdPetCareSalePrice.Text = "130";

                }
                else
                    if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "BIRD SPIKE")
                    {
                        txtBirdPetCareSalePrice.Text = "120";

                    }
                    else
                        if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "BATH SOLAR FOUNTAIN KIT")
                        {
                            txtBirdPetCareSalePrice.Text = "300";

                        }
                        else
                            if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "MEDPET PARROT TONIC")
                            {
                                txtBirdPetCareSalePrice.Text = "65";

                            }
                            else
                                if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "MEDPET PREMOLT TABLETS")
                                {
                                    txtBirdPetCareSalePrice.Text = "310";

                                }
                                else
                                    if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "MILLET SPRAY")
                                    {
                                        txtBirdPetCareSalePrice.Text = "20";

                                    }
                                    else
                                        if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "MEDPET VITATON")
                                        {
                                            txtBirdPetCareSalePrice.Text = "160";

                                        }
                                        else
                                            if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "BEAPHAR PARROT CARE")
                                            {
                                                txtBirdPetCareSalePrice.Text = "165";

                                            }
                                            else
                                                if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "VITAKRAFT EARS OF MILLET")
                                                {
                                                    txtBirdPetCareSalePrice.Text = "50";

                                                }
                                                else
                                                    if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "AFRICAN GREY SHAMPOO")
                                                    {
                                                        txtBirdPetCareSalePrice.Text = "550";

                                                    }
                                                    else
                                                        if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "COCKATOO SHAMPOO")
                                                        {
                                                            txtBirdPetCareSalePrice.Text = "540";

                                                        }
                                                        else
                                                            if (cboBirdPetCareSaleItems.SelectedItem.ToString() == "COCKATIEL BATH")
                                                            {
                                                                txtBirdPetCareSalePrice.Text = "560";

                                                            }

        }

        private void txtBirdPetCareSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdPetCareSaleQuantity.Text.Length > 0)
            {
                txtBirdPetCareSaleTotal.Text = (Convert.ToInt16(txtBirdPetCareSalePrice.Text) * Convert.ToInt16(txtBirdPetCareSaleQuantity.Text)).ToString();
            }
        }

        private void txtBirdPetCareSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdPetCareSaleDiscount.Text.Length > 0)
            {
                txtBirdPetCareSaleAmountDue.Text = (Convert.ToInt16(txtBirdPetCareSaleTotal.Text) - Convert.ToInt16(txtBirdPetCareSaleDiscount.Text)).ToString();
            }
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtBirdPetCareSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvBirdPetCareSale.Rows.Count - 1; i++)
            {
                txtBirdPetCareSaleFinalTotal.Text = Convert.ToString(int.Parse(txtBirdPetCareSaleFinalTotal.Text) + int.Parse(dgvBirdPetCareSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtBirdPetCareSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtBirdPetCareSaleAmountPaid.Text.Length > 0)
            {
                txtBirdPetCareSaleChangeDue.Text = (Convert.ToInt16(txtBirdPetCareSaleAmountPaid.Text) - Convert.ToInt16(txtBirdPetCareSaleFinalTotal.Text)).ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvBirdPetCareSale.Rows.Add();
            row = dgvBirdPetCareSale.Rows.Count - 2;
            dgvBirdPetCareSale["Item", row].Value = cboBirdPetCareSaleItems.Text;
            dgvBirdPetCareSale["Quantity", row].Value = txtBirdPetCareSaleQuantity.Text;
            dgvBirdPetCareSale["Price", row].Value = txtBirdPetCareSalePrice.Text;
            dgvBirdPetCareSale["Total", row].Value = txtBirdPetCareSaleAmountDue.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBirdPetCareSaleFinalTotal.Text = "";
            txtBirdPetCareSaleAmountPaid.Text = "";
            txtBirdPetCareSaleChangeDue.Text = "";
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {

            cboBirdPetCareSaleItems.Text = "";
            txtBirdPetCareSalePrice.Text = "";
            txtBirdPetCareSaleQuantity.Text = "";
            txtBirdPetCareSaleTotal.Text = "";
            txtBirdPetCareSaleDiscount.Text = "";
            txtBirdPetCareSaleAmountDue.Text = "";
            txtBirdPetCareSaleAmountPaid.Text = "";
            txtBirdPetCareSaleChangeDue.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Bird_Pet_Care_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboBirdPetCareSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtBirdPetCareSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtBirdPetCareSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtBirdPetCareSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtBirdPetCareSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtBirdPetCareSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvBirdPetCareSale.Rows.Clear();
        
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Birds_Menu bm = new Birds_Menu();
            bm.Show();
        }
    }
}
