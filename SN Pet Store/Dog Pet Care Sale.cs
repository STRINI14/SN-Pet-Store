﻿using System;
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
    public partial class Dog_Pet_Care_Sale : Form
    {
        public Dog_Pet_Care_Sale()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Dogs_Menu dm = new Dogs_Menu();
            dm.Show();
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvDogPetCareSale.Rows.Clear();
        }

        private void cboDogPetCareSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDogPetCareSaleItems.SelectedItem.ToString() == "PUPPY SHAMPOO")
            {
                txtDogPetCareSalePrice.Text = "24";

            }

            else
                if (cboDogPetCareSaleItems.SelectedItem.ToString() == "TICK POWDER")
                {
                    txtDogPetCareSalePrice.Text = "19";

                }
                else
                    if (cboDogPetCareSaleItems.SelectedItem.ToString() == "MARLTONS GET OFF SPRAY")
                    {
                        txtDogPetCareSalePrice.Text = "115";

                    }
                    else
                        if (cboDogPetCareSaleItems.SelectedItem.ToString() == "DOG FIRST AID KIT")
                        {
                            txtDogPetCareSalePrice.Text = "375";

                        }
                        else
                            if (cboDogPetCareSaleItems.SelectedItem.ToString() == "3 IN 1 ODOUR NEUTRALIZER")
                            {
                                txtDogPetCareSalePrice.Text = "85";

                            }
                            else
                                if (cboDogPetCareSaleItems.SelectedItem.ToString() == "PET NAIL TRIMMER")
                                {
                                    txtDogPetCareSalePrice.Text = "190";

                                }
                                else
                                    if (cboDogPetCareSaleItems.SelectedItem.ToString() == "MEDICATED SHAMPOO")
                                    {
                                        txtDogPetCareSalePrice.Text = "230";

                                    }
                                    else
                                        if (cboDogPetCareSaleItems.SelectedItem.ToString() == "INSECT REPELLENT TEA TREE OIL")
                                        {
                                            txtDogPetCareSalePrice.Text = "80";

                                        }
                                        else
                                            if (cboDogPetCareSaleItems.SelectedItem.ToString() == "SINGLE PET RAMP")
                                            {
                                                txtDogPetCareSalePrice.Text = "750";

                                            }
                                            else
                                                if (cboDogPetCareSaleItems.SelectedItem.ToString() == "PET E MED INJECTION")
                                                {
                                                    txtDogPetCareSalePrice.Text = "200";

                                                }
                                                else
                                                    if (cboDogPetCareSaleItems.SelectedItem.ToString() == "BOB MARTIN SPOT ON LARGE")
                                                    {
                                                        txtDogPetCareSalePrice.Text = "75";

                                                    }
                                                    else
                                                        if (cboDogPetCareSaleItems.SelectedItem.ToString() == "SKIN CARE REMEDY")
                                                        {
                                                            txtDogPetCareSalePrice.Text = "160";

                                                        }
                                                        else
                                                            if (cboDogPetCareSaleItems.SelectedItem.ToString() == "CANI-VIT TABLETS")
                                                            {
                                                                txtDogPetCareSalePrice.Text = "135";

                                                            }
                                                            else
                                                                if (cboDogPetCareSaleItems.SelectedItem.ToString() == "PET HAIR REMOVER")
                                                                {
                                                                    txtDogPetCareSalePrice.Text = "145";

                                                                }
                                                                else
                                                                    if (cboDogPetCareSaleItems.SelectedItem.ToString() == "PEE POST")
                                                                    {
                                                                        txtDogPetCareSalePrice.Text = "150";


                                                                    }
                                                                    else
                                                                        if (cboDogPetCareSaleItems.SelectedItem.ToString() == "FLEA AND TICK SHAMPOO")
                                                                        {
                                                                            txtDogPetCareSalePrice.Text = "65";

                                                                        }
                                                                        else
                                                                            if (cboDogPetCareSaleItems.SelectedItem.ToString() == "DOG SKIN SUPPLEMENT")
                                                                            {
                                                                                txtDogPetCareSalePrice.Text = "140";

                                                                            }
                                                                            else
                                                                                if (cboDogPetCareSaleItems.SelectedItem.ToString() == "WOUND GEL")
                                                                                {
                                                                                    txtDogPetCareSalePrice.Text = "52";

                                                                                }
                                                                                else
                                                                                    if (cboDogPetCareSaleItems.SelectedItem.ToString() == "DESHEDDING BRUSH")
                                                                                    {
                                                                                        txtDogPetCareSalePrice.Text = "170";

                                                                                    }
                                                                                    else
                                                                                        if (cboDogPetCareSaleItems.SelectedItem.ToString() == "POTTY TRAINER")
                                                                                        {
                                                                                            txtDogPetCareSalePrice.Text = "160";

                                                                                        }
                                                                                        else
                                                                                            if (cboDogPetCareSaleItems.SelectedItem.ToString() == "PARASITICIDE PACK")
                                                                                            {
                                                                                                txtDogPetCareSalePrice.Text = "235";

                                                                                            }

        }

        private void txtDogPetCareSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtDogPetCareSaleQuantity.Text.Length > 0)
            {
                txtDogPetCareSaleTotal.Text = (Convert.ToInt16(txtDogPetCareSalePrice.Text) * Convert.ToInt16(txtDogPetCareSaleQuantity.Text)).ToString();
            }
        
        }

        private void txtDogPetSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDogPetCareSaleDiscount.Text.Length > 0)
            {
                txtDogPetCareSaleAmountDue.Text = (Convert.ToInt16(txtDogPetCareSaleTotal.Text) - Convert.ToInt16(txtDogPetCareSaleDiscount.Text)).ToString();
            }
        
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtDogPetCareSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvDogPetCareSale.Rows.Count - 1; i++)
            {
                txtDogPetCareSaleFinalTotal.Text = Convert.ToString(int.Parse(txtDogPetCareSaleFinalTotal.Text) + int.Parse(dgvDogPetCareSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtDogAccSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtDogPetCareSaleAmountPaid.Text.Length > 0)
            {
                txtDogPetCareSaleChangeDue.Text = (Convert.ToInt16(txtDogPetCareSaleAmountPaid.Text) - Convert.ToInt16(txtDogPetCareSaleFinalTotal.Text)).ToString();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvDogPetCareSale.Rows.Add();
            row = dgvDogPetCareSale.Rows.Count - 2;
            dgvDogPetCareSale["Item", row].Value = cboDogPetCareSaleItems.Text;
            dgvDogPetCareSale["Quantity", row].Value = txtDogPetCareSaleQuantity.Text;
            dgvDogPetCareSale["Price", row].Value = txtDogPetCareSalePrice.Text;
            dgvDogPetCareSale["Total", row].Value = txtDogPetCareSaleAmountDue.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDogPetCareSaleFinalTotal.Text = "";
            txtDogPetCareSaleAmountPaid.Text = "";
            txtDogPetCareSaleChangeDue.Text = "";
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {

            cboDogPetCareSaleItems.Text = "";
            txtDogPetCareSalePrice.Text = "";
            txtDogPetCareSaleQuantity.Text = "";
            txtDogPetCareSaleTotal.Text = "";
            txtDogPetCareSaleDiscount.Text = "";
            txtDogPetCareSaleAmountDue.Text = "";
            txtDogPetCareSaleAmountPaid.Text = "";
            txtDogPetCareSaleChangeDue.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Dog_Pet_Care_Sale(Date_Entered,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date_Entered,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date_Entered", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboDogPetCareSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtDogPetCareSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtDogPetCareSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtDogPetCareSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtDogPetCareSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtDogPetCareSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }

        private void Dog_Pet_Care_Sale_Load(object sender, EventArgs e)
        {

        }

        private void txtDogPetCareSalePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogPetCareSaleTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogPetCareSaleAmountDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDogPetCareSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDogPetCareSaleFinalTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogPetCareSaleChangeDue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
