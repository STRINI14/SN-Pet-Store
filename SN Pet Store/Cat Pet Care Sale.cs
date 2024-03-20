using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SN_Pet_Store
{
    public partial class Cat_Pet_Care_Sale : Form
    {
        public Cat_Pet_Care_Sale()
        {
            InitializeComponent();
        }

        private void cboCatPetCareSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCatPetCareSaleItems.SelectedItem.ToString() == "MARLTONS GET OFF SPRAY")
            {
                txtCatPetCareSalePrice.Text = "115";

            }

            else
                if (cboCatPetCareSaleItems.SelectedItem.ToString() == "FRONTLINE CAT BRUSH")
                {
                    txtCatPetCareSalePrice.Text = "90";

                }
                else
                    if (cboCatPetCareSaleItems.SelectedItem.ToString() == "FLEA DOCTOR FOR CATS")
                    {
                        txtCatPetCareSalePrice.Text = "125";

                    }
                    else
                        if (cboCatPetCareSaleItems.SelectedItem.ToString() == "INSECT REPELLENT SPRAY")
                        {
                            txtCatPetCareSalePrice.Text = "125";

                        }
                        else
                            if (cboCatPetCareSaleItems.SelectedItem.ToString() == "MARLTONS DEWORMER")
                            {
                                txtCatPetCareSalePrice.Text = "35";

                            }
                            else
                                if (cboCatPetCareSaleItems.SelectedItem.ToString() == "KITTEN NURSING KIT")
                                {
                                    txtCatPetCareSalePrice.Text = "75";

                                }
                                else
                                    if (cboCatPetCareSaleItems.SelectedItem.ToString() == "STRESSFREE VALERIAN POWDER")
                                    {
                                        txtCatPetCareSalePrice.Text = "55";

                                    }
                                    else
                                        if (cboCatPetCareSaleItems.SelectedItem.ToString() == "DENT TOOTHPASTE")
                                        {
                                            txtCatPetCareSalePrice.Text = "60";

                                        }
                                        else
                                            if (cboCatPetCareSaleItems.SelectedItem.ToString() == "CAT PET E-MED")
                                            {
                                                txtCatPetCareSalePrice.Text = "205";

                                            }
                                            else
                                                if (cboCatPetCareSaleItems.SelectedItem.ToString() == "ELECTRIC FLEA COMB")
                                                {
                                                    txtCatPetCareSalePrice.Text = "190";

                                                }
                                                else
                                                    if (cboCatPetCareSaleItems.SelectedItem.ToString() == "CAT GROOMING KIT")
                                                    {
                                                        txtCatPetCareSalePrice.Text = "485";

                                                    }
                                                    else
                                                        if (cboCatPetCareSaleItems.SelectedItem.ToString() == "REGAL HEALTH TONIC")
                                                        {
                                                            txtCatPetCareSalePrice.Text = "90";

                                                        }

        }

        private void txtCatPetCareSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtCatPetCareSaleQuantity.Text.Length > 0)
            {
                txtCatPetCareSaleTotal.Text = (Convert.ToInt16(txtCatPetCareSalePrice.Text) * Convert.ToInt16(txtCatPetCareSaleQuantity.Text)).ToString();
            }
        }

        private void txtCatPetCareSaleTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatPetCareSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtCatPetCareSaleDiscount.Text.Length > 0)
            {
                txtCatPetCareSaleAmountDue.Text = (Convert.ToInt16(txtCatPetCareSaleTotal.Text) - Convert.ToInt16(txtCatPetCareSaleDiscount.Text)).ToString();
            }
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtCatPetCareSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvCatPetCareSale.Rows.Count - 1; i++)
            {
                txtCatPetCareSaleFinalTotal.Text = Convert.ToString(int.Parse(txtCatPetCareSaleFinalTotal.Text) + int.Parse(dgvCatPetCareSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtCatPetCareSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtCatPetCareSaleAmountPaid.Text.Length > 0)
            {
                txtCatPetCareSaleChangeDue.Text = (Convert.ToInt16(txtCatPetCareSaleAmountPaid.Text) - Convert.ToInt16(txtCatPetCareSaleFinalTotal.Text)).ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvCatPetCareSale.Rows.Add();
            row = dgvCatPetCareSale.Rows.Count - 2;
            dgvCatPetCareSale["Item", row].Value = cboCatPetCareSaleItems.Text;
            dgvCatPetCareSale["Quantity", row].Value = txtCatPetCareSaleQuantity.Text;
            dgvCatPetCareSale["Price", row].Value = txtCatPetCareSalePrice.Text;
            dgvCatPetCareSale["Total", row].Value = txtCatPetCareSaleAmountDue.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCatPetCareSaleFinalTotal.Text = "";
            txtCatPetCareSaleAmountPaid.Text = "";
            txtCatPetCareSaleChangeDue.Text = "";
        
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {

            cboCatPetCareSaleItems.Text = "";
            txtCatPetCareSalePrice.Text = "";
            txtCatPetCareSaleQuantity.Text = "";
            txtCatPetCareSaleTotal.Text = "";
            txtCatPetCareSaleDiscount.Text = "";
            txtCatPetCareSaleAmountDue.Text = "";
            txtCatPetCareSaleAmountPaid.Text = "";
            txtCatPetCareSaleChangeDue.Text = "";
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvCatPetCareSale.Rows.Clear();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Cats_Menu cm = new Cats_Menu();
            cm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Cat_Pet_Care_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboCatPetCareSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtCatPetCareSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtCatPetCareSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtCatPetCareSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtCatPetCareSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtCatPetCareSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }

        private void Cat_Pet_Care_Sale_Load(object sender, EventArgs e)
        {

        }

        private void txtCatPetCareSalePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatPetCareSaleChangeDue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
