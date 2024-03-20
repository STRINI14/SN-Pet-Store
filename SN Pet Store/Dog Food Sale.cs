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
    public partial class Dog_Food_Sale : Form
    {
        public Dog_Food_Sale()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void cboDogFoodSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDogFoodSaleItems.SelectedItem.ToString() == "OL ROY LAMB CHUNKS 8KG")
            {
                txtDogFoodSalePrice.Text = "150";

            }
            else
                if (cboDogFoodSaleItems.SelectedItem.ToString() == "HUSKY EXTRA LARGE BISCUITS")
                {
                    txtDogFoodSalePrice.Text = "35";

                }
             else
                 if (cboDogFoodSaleItems.SelectedItem.ToString() == "MARLTONS BACON FLAVOURED STRIPS 120G")
                    {
                     txtDogFoodSalePrice.Text = "20";

                    }
              else
                     if (cboDogFoodSaleItems.SelectedItem.ToString() == "MARLTONS BACON FLAVOURED ROLLS 120G")
                        {
                           txtDogFoodSalePrice.Text = "20";

                        }
                     else
                         if (cboDogFoodSaleItems.SelectedItem.ToString() == "BEENO XL BISCUIT IN GRAVY")
                         {
                             txtDogFoodSalePrice.Text = "45";

                         }
                             else
            
            if (cboDogFoodSaleItems.SelectedItem.ToString() == "BOBTAIL MULTI FLAVOURED MULTIPACK")
            {
                txtDogFoodSalePrice.Text = "35";


            }
            else
                if (cboDogFoodSaleItems.SelectedItem.ToString() == "BOBTAIL CHICKEN & RICE 8KG FOOD ")
                {
                    txtDogFoodSalePrice.Text = "145";

                }
                else
                    if (cboDogFoodSaleItems.SelectedItem.ToString() == "BOSS HUNGER BUSTER CAN BEEF 820G")
                    {
                        txtDogFoodSalePrice.Text = "25";

                    }
                    else
                        if (cboDogFoodSaleItems.SelectedItem.ToString() == "BOBTAIL CHICKEN FLAVOUR 8KG FOOD")
                        {
                            txtDogFoodSalePrice.Text = "145";

                        }
                        else
                            if (cboDogFoodSaleItems.SelectedItem.ToString() == "BOBTAIL LAMB FLAVOUR 8KG FOOD")
                            {
                                txtDogFoodSalePrice.Text = "145";


                            }
                            else
                                if (cboDogFoodSaleItems.SelectedItem.ToString() == "BOBTAIL GRAVY WITH CHUNKS CHICKEN 85G")
                                {
                                    txtDogFoodSalePrice.Text = "5";

                                }
                                else
                                    if (cboDogFoodSaleItems.SelectedItem.ToString() == "BOBTAIL GRAVY WITH CHUNKS LAMB 85G")
                                    {
                                        txtDogFoodSalePrice.Text = "5";

                                    }

                                    else
                                        if (cboDogFoodSaleItems.SelectedItem.ToString() == "PEDIGREE GRAVY WITH CHUNKS STEAK 85G")
                                        {
                                            txtDogFoodSalePrice.Text = "5";

                                        }
                                        else
                                            if (cboDogFoodSaleItems.SelectedItem.ToString() == "PEDIGREE GRAVY WITH CHUNKS LAMB 85G")
                                            {
                                                txtDogFoodSalePrice.Text = "5";

                                            }
                                            else
                                                if (cboDogFoodSaleItems.SelectedItem.ToString() == "THE HILLS LAMB 10KG DOG FOOD")
                                                {
                                                    txtDogFoodSalePrice.Text = "150";

                                                }
                                                else
                                                    if (cboDogFoodSaleItems.SelectedItem.ToString() == "HUSKY CAN STEAK 775G")
                                                    {
                                                        txtDogFoodSalePrice.Text = "25";

                                                    }
                                                    else
                                                        if (cboDogFoodSaleItems.SelectedItem.ToString() == "HUSKY CAN LAMB 775G")
                                                        {
                                                            txtDogFoodSalePrice.Text = "25";

                                                        }
            
            





            txtDogFoodSaleTotal.Text = "";
            txtDogFoodSaleQuantity.Text = "";
            txtDogFoodSaleDiscount.Text = "";
            txtDogFoodSaleAmountDue.Text = ""; 

        }

        private void txtDogFoodSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtDogFoodSaleQuantity.Text.Length > 0)
            {
                txtDogFoodSaleTotal.Text = (Convert.ToInt16(txtDogFoodSalePrice.Text) * Convert.ToInt16(txtDogFoodSaleQuantity.Text)).ToString();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dog_Food_Sale_Load(object sender, EventArgs e)
        {
            


        }

        private void txtDogFoodSaleST_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogFoodSaleST_TextChanged_1(object sender, EventArgs e)
        {





        }

        private void txtDogFoodSaleTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogFoodSalePrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogFoodSaleDiscount_TextChanged(object sender, EventArgs e)
        {


         
        }

       

        private void txtDogFoodSaleChangeDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDogFoodSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDisplayReceipt_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvDogFoodSale.Rows.Add();
            row = dgvDogFoodSale.Rows.Count - 2;
            dgvDogFoodSale["Item", row].Value = cboDogFoodSaleItems.Text;
            dgvDogFoodSale["Quantity", row].Value = txtDogFoodSaleQuantity.Text;
            dgvDogFoodSale["Price", row].Value = txtDogFoodSalePrice.Text;
            dgvDogFoodSale["Total", row].Value = txtDogFoodSaleAmountDue.Text;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cboDogFoodSaleItems.Text = "";
            txtDogFoodSalePrice.Text = "";
            txtDogFoodSaleQuantity.Text = "";
            txtDogFoodSaleTotal.Text = "";
            txtDogFoodSaleDiscount.Text = "";
            txtDogFoodSaleAmountDue.Text = "";
            txtDogFoodSaleAmountPaid.Text = "";
            txtDogFoodSaleChangeDue.Text = "";


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Dog_Food_Sale(Date_Entered,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date_Entered,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date_Entered", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboDogFoodSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtDogFoodSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtDogFoodSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtDogFoodSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtDogFoodSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtDogFoodSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();

           
            
        }

        private void txtFinalTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblDogFoodSaleAmountPaid_Click(object sender, EventArgs e)
        {
            
        
        }

        private void txtDogFoodSaleChangeDue_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void txtDogFoodSaleAmountPaid_TextChanged_1(object sender, EventArgs e)
        {
            if (txtDogFoodSaleAmountPaid.Text.Length > 0)
            {
                txtDogFoodSailChangeDue.Text = (Convert.ToInt16(txtDogFoodSaleAmountPaid.Text) - Convert.ToInt16(txtDogFoodSaleFinalTotal.Text)).ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDogFoodSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvDogFoodSale.Rows.Count - 1; i++)
            {
                txtDogFoodSaleFinalTotal.Text = Convert.ToString(int.Parse(txtDogFoodSaleFinalTotal.Text) + int.Parse(dgvDogFoodSale.Rows[i].Cells[3].Value.ToString()));
            }
           
        }

        private void txtDogFoodSaleAmountDue_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void txtDogFoodSaleDiscount_TextChanged_1(object sender, EventArgs e)
        {
            if (txtDogFoodSaleDiscount.Text.Length > 0)
            {
                txtDogFoodSaleAmountDue.Text = (Convert.ToInt16(txtDogFoodSaleTotal.Text) - Convert.ToInt16(txtDogFoodSaleDiscount.Text)).ToString();
            }
        }

        private void txtDogFoolSaleChangeDue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Dogs_Menu dm = new Dogs_Menu();
            dm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dgvDogFoodSale.Rows.Clear(); 
        }

        private void txtDogFoodSaleTotal_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnClearBoxes_Click(object sender, EventArgs e)
        {
            txtDogFoodSaleFinalTotal.Text = "";
            txtDogFoodSaleAmountPaid.Text = "";
            txtDogFoodSailChangeDue.Text = "";
        }


      

    

    }
}
