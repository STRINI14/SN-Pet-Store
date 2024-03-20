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
    public partial class Fish_Acc_Sale : Form
    {
        public Fish_Acc_Sale()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Fish_Menu fm = new Fish_Menu();
            fm.Show();
        }

        private void cboFishAccSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFishAccSaleItems.SelectedItem.ToString() == "STANDARD GLASS AQUARIUM")
            {
                txtFishAccSalePrice.Text = "120";

            }

            else
                if (cboFishAccSaleItems.SelectedItem.ToString() == "VARIETY COLORED GRAVEL")
                {
                    txtFishAccSalePrice.Text = "40";

                }
                else
                    if (cboFishAccSaleItems.SelectedItem.ToString() == "AQUARIUM PINEAPPLE")
                    {
                        txtFishAccSalePrice.Text = "165";

                    }
                    else
                        if (cboFishAccSaleItems.SelectedItem.ToString() == "6 IN 1 AQUARIUM WATER TEST")
                        {
                            txtFishAccSalePrice.Text = "470";

                        }
                        else
                            if (cboFishAccSaleItems.SelectedItem.ToString() == "AQUARIUM AIR STONE OXYGEN PUMP")
                            {
                                txtFishAccSalePrice.Text = "260";

                            }
                            else
                                if (cboFishAccSaleItems.SelectedItem.ToString() == "SOBO INTERNAL FILTER")
                                {
                                    txtFishAccSalePrice.Text = "95";

                                }
                                else
                                    if (cboFishAccSaleItems.SelectedItem.ToString() == "AQUARIUM LIGHT DECORATION")
                                    {
                                        txtFishAccSalePrice.Text = "210";

                                    }
                                    else
                                        if (cboFishAccSaleItems.SelectedItem.ToString() == "AQUARIUM DECOR ROCK FORMATION")
                                        {
                                            txtFishAccSalePrice.Text = "165";

                                        }
                                        else
                                            if (cboFishAccSaleItems.SelectedItem.ToString() == "SPONGEBOB AQUARIUM DECORATION")
                                            {
                                                txtFishAccSalePrice.Text = "98";

                                            }
                                            else
                                                if (cboFishAccSaleItems.SelectedItem.ToString() == "AQUARIUM WALL AIR BUBBLE STONE TUBE")
                                                {
                                                    txtFishAccSalePrice.Text = "210";

                                                }
                                                else
                                                    if (cboFishAccSaleItems.SelectedItem.ToString() == "AQUARIUM LED TANK LIGHT")
                                                    {
                                                        txtFishAccSalePrice.Text = "175";

                                                    }
                                                    else
                                                        if (cboFishAccSaleItems.SelectedItem.ToString() == "AQUARIUM GRASS SEEDS")
                                                        {
                                                            txtFishAccSalePrice.Text = "160";

                                                        }
                                                        else
                                                            if (cboFishAccSaleItems.SelectedItem.ToString() == "CUBUS GLASS BETTA TANK")
                                                            {
                                                                txtFishAccSalePrice.Text = "440";

                                                            }
                                                            else
                                                                if (cboFishAccSaleItems.SelectedItem.ToString() == "30 LITRE EXPLORER FISH TANK")
                                                                {
                                                                    txtFishAccSalePrice.Text = "1300";

                                                                }
                                                                else
                                                                    if (cboFishAccSaleItems.SelectedItem.ToString() == "FISH BOWL STARTER KIT")
                                                                    {
                                                                        txtFishAccSalePrice.Text = "230";

                                                                    }
                                                                    else
                                                                        if (cboFishAccSaleItems.SelectedItem.ToString() == "MOSS BALL AQUARIUM PLANT")
                                                                        {
                                                                            txtFishAccSalePrice.Text = "65";

                                                                        }
                                                                        
        }

        private void txtFishAccSaleQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtFishAccSaleQuantity.Text.Length > 0)
            {
                txtFishAccSaleTotal.Text = (Convert.ToInt16(txtFishAccSalePrice.Text) * Convert.ToInt16(txtFishAccSaleQuantity.Text)).ToString();
            }
        }

        private void txtFishAccSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtFishAccSaleDiscount.Text.Length > 0)
            {
                txtFishAccSaleAmountDue.Text = (Convert.ToInt16(txtFishAccSaleTotal.Text) - Convert.ToInt16(txtFishAccSaleDiscount.Text)).ToString();
            }
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtFishAccSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvFishAccSale.Rows.Count - 1; i++)
            {
                txtFishAccSaleFinalTotal.Text = Convert.ToString(int.Parse(txtFishAccSaleFinalTotal.Text) + int.Parse(dgvFishAccSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtFishAccSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtFishAccSaleAmountPaid.Text.Length > 0)
            {
                txtFishAccSaleChangeDue.Text = (Convert.ToInt16(txtFishAccSaleAmountPaid.Text) - Convert.ToInt16(txtFishAccSaleFinalTotal.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFishAccSaleFinalTotal.Text = "";
            txtFishAccSaleAmountPaid.Text = "";
            txtFishAccSaleChangeDue.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvFishAccSale.Rows.Add();
            row = dgvFishAccSale.Rows.Count - 2;
            dgvFishAccSale["Item", row].Value = cboFishAccSaleItems.Text;
            dgvFishAccSale["Quantity", row].Value = txtFishAccSaleQuantity.Text;
            dgvFishAccSale["Price", row].Value = txtFishAccSalePrice.Text;
            dgvFishAccSale["Total", row].Value = txtFishAccSaleAmountDue.Text;
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            cboFishAccSaleItems.Text = "";
            txtFishAccSalePrice.Text = "";
            txtFishAccSaleQuantity.Text = "";
            txtFishAccSaleTotal.Text = "";
            txtFishAccSaleDiscount.Text = "";
            txtFishAccSaleAmountDue.Text = "";
            txtFishAccSaleAmountPaid.Text = "";
            txtFishAccSaleChangeDue.Text = "";
        
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Fish_Acc_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due)", con);
            cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@Item", cboFishAccSaleItems.Text);
            cmd.Parameters.AddWithValue("@Quantity", txtFishAccSaleQuantity.Text);
            cmd.Parameters.AddWithValue("@Price", txtFishAccSalePrice.Text);
            cmd.Parameters.AddWithValue("@Total", txtFishAccSaleTotal.Text);
            cmd.Parameters.AddWithValue("@Discount", txtFishAccSaleDiscount.Text);
            cmd.Parameters.AddWithValue("@Amount_Due", txtFishAccSaleAmountDue.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Has Been Inserted Successfully.", "Operation Successful.");
            con.Close();
        }

        private void Fish_Acc_Sale_Load(object sender, EventArgs e)
        {

        }
    }
}
