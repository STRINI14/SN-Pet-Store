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
    public partial class Fish_Pet_Care_Sale : Form
    {
        public Fish_Pet_Care_Sale()
        {
            InitializeComponent();
        }

        private void txtFishPetCareSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtFishPetCareSaleQuantity.Text.Length > 0)
            {
                txtFishPetCareSaleTotal.Text = (Convert.ToInt16(txtFishPetCareSalePrice.Text) * Convert.ToInt16(txtFishPetCareSaleQuantity.Text)).ToString();
            }
        }

        private void cboFishPetCareSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFishPetCareSaleItems.SelectedItem.ToString() == "TETRA AQUASAFE")
            {
                txtFishPetCareSalePrice.Text = "45";

            }

            else
                if (cboFishPetCareSaleItems.SelectedItem.ToString() == "TETRA GOLDFISH MEDICINE")
                {
                    txtFishPetCareSalePrice.Text = "115";

                }
                else
                    if (cboFishPetCareSaleItems.SelectedItem.ToString() == "DARO AQUARIUM SALT")
                    {
                        txtFishPetCareSalePrice.Text = "45";

                    }
                    else
                        if (cboFishPetCareSaleItems.SelectedItem.ToString() == "TETRA ALGUMIN")
                        {
                            txtFishPetCareSalePrice.Text = "125";

                        }
                        else
                            if (cboFishPetCareSaleItems.SelectedItem.ToString() == "AQUASAFE WATER NEUTRALIZER")
                            {
                                txtFishPetCareSalePrice.Text = "55";

                            }
                            else
                                if (cboFishPetCareSaleItems.SelectedItem.ToString() == "ORGANIC ALGAE KIT")
                                {
                                    txtFishPetCareSalePrice.Text = "65";

                                }
                                else
                                    if (cboFishPetCareSaleItems.SelectedItem.ToString() == "TETRA AQUA EASY BALANCE")
                                    {
                                        txtFishPetCareSalePrice.Text = "200";

                                    }
                                    else
                                        if (cboFishPetCareSaleItems.SelectedItem.ToString() == "TROPICAL GUPPY LIVEBEARERS")
                                        {
                                            txtFishPetCareSalePrice.Text = "75";

                                        }
                                        else
                                            if (cboFishPetCareSaleItems.SelectedItem.ToString() == "TETRA CRYSTALWATER")
                                            {
                                                txtFishPetCareSalePrice.Text = "315";

                                            }
                                            else
                                                if (cboFishPetCareSaleItems.SelectedItem.ToString() == "TETRA MEDICA FUNGISTOP")
                                                {
                                                    txtFishPetCareSalePrice.Text = "350";

                                                }
                                                else
                                                    if (cboFishPetCareSaleItems.SelectedItem.ToString() == "QUICK START NITRIFYING BACTERIA")
                                                    {
                                                        txtFishPetCareSalePrice.Text = "250";

                                                    }
                                                    else
                                                        if (cboFishPetCareSaleItems.SelectedItem.ToString() == "SMALL PRIME GRAVEL CLEANER")
                                                        {
                                                            txtFishPetCareSalePrice.Text = "240";

                                                        }
                                                        else
                                                            if (cboFishPetCareSaleItems.SelectedItem.ToString() == "ORGANIC WATER QUALITY KIT")
                                                            {
                                                                txtFishPetCareSalePrice.Text = "75";

                                                            }
                                                            else
                                                                if (cboFishPetCareSaleItems.SelectedItem.ToString() == "ACTIVATED BONE CHARCOAL")
                                                                {
                                                                    txtFishPetCareSalePrice.Text = "25";

                                                                }
                                                                else
                                                                    if (cboFishPetCareSaleItems.SelectedItem.ToString() == "BULK ACTIVATED BONE CHARCOAL")
                                                                    {
                                                                        txtFishPetCareSalePrice.Text = "55";

                                                                    }
        }

        private void txtFishPetCareSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtFishPetCareSaleDiscount.Text.Length > 0)
            {
                txtFishPetCareSaleAmountDue.Text = (Convert.ToInt16(txtFishPetCareSaleTotal.Text) - Convert.ToInt16(txtFishPetCareSaleDiscount.Text)).ToString();
            }
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtFishPetCareSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvFishPetCareSale.Rows.Count - 1; i++)
            {
                txtFishPetCareSaleFinalTotal.Text = Convert.ToString(int.Parse(txtFishPetCareSaleFinalTotal.Text) + int.Parse(dgvFishPetCareSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtFishPetCareSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtFishPetCareSaleAmountPaid.Text.Length > 0)
            {
                txtFishPetCareSaleChangeDue.Text = (Convert.ToInt16(txtFishPetCareSaleAmountPaid.Text) - Convert.ToInt16(txtFishPetCareSaleFinalTotal.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFishPetCareSaleFinalTotal.Text = "";
            txtFishPetCareSaleAmountPaid.Text = "";
            txtFishPetCareSaleChangeDue.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvFishPetCareSale.Rows.Add();
            row = dgvFishPetCareSale.Rows.Count - 2;
            dgvFishPetCareSale["Item", row].Value = cboFishPetCareSaleItems.Text;
            dgvFishPetCareSale["Quantity", row].Value = txtFishPetCareSaleQuantity.Text;
            dgvFishPetCareSale["Price", row].Value = txtFishPetCareSalePrice.Text;
            dgvFishPetCareSale["Total", row].Value = txtFishPetCareSaleAmountDue.Text;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {

            cboFishPetCareSaleItems.Text = "";
            txtFishPetCareSalePrice.Text = "";
            txtFishPetCareSaleQuantity.Text = "";
            txtFishPetCareSaleTotal.Text = "";
            txtFishPetCareSaleDiscount.Text = "";
            txtFishPetCareSaleAmountDue.Text = "";
            txtFishPetCareSaleAmountPaid.Text = "";
            txtFishPetCareSaleChangeDue.Text = "";
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvFishPetCareSale.Rows.Clear();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Fish_Menu fm = new Fish_Menu();
            fm.Show();
        }

        private void Fish_Pet_Care_Sale_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Fish_Pet_Care_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboFishPetCareSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtFishPetCareSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtFishPetCareSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtFishPetCareSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtFishPetCareSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtFishPetCareSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }
    }
}
