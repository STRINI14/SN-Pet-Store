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
    public partial class Fish_Pet_Sale : Form
    {
        public Fish_Pet_Sale()
        {
            InitializeComponent();
        }
        string connectionstring = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=SN Pets;Integrated Security=True";
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            Fish_Menu fm = new Fish_Menu();
            fm.Show();
        }

        private void txtFishPetSaleQuantity_TextChanged(object sender, EventArgs e)
        {

            if (txtFishPetSaleQuantity.Text.Length > 0)
            {
                txtFishPetSaleTotal.Text = (Convert.ToInt16(txtFishPetSalePrice.Text) * Convert.ToInt16(txtFishPetSaleQuantity.Text)).ToString();
            }
        
        }

        private void txtFishPetSaleDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtFishPetSaleDiscount.Text.Length > 0)
            {
                txtFishPetSaleAmountDue.Text = (Convert.ToInt16(txtFishPetSaleTotal.Text) - Convert.ToInt16(txtFishPetSaleDiscount.Text)).ToString();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            OpenFileDialog OD = new OpenFileDialog();
            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";
            if (OD.ShowDialog() == DialogResult.OK)
                pbFishPetSale.Load(OD.FileName);
        
        }

        private void btnFinalTotal_Click(object sender, EventArgs e)
        {
            txtFishPetSaleFinalTotal.Text = "0";
            for (int i = 0; i < dgvFishPetSale.Rows.Count - 1; i++)
            {
                txtFishPetSaleFinalTotal.Text = Convert.ToString(int.Parse(txtFishPetSaleFinalTotal.Text) + int.Parse(dgvFishPetSale.Rows[i].Cells[3].Value.ToString()));
            }
        }

        private void txtFishPetSaleAmountPaid_TextChanged(object sender, EventArgs e)
        {
            if (txtFishPetSaleAmountPaid.Text.Length > 0)
            {
                txtFishPetSaleChangeDue.Text = (Convert.ToInt16(txtFishPetSaleAmountPaid.Text) - Convert.ToInt16(txtFishPetSaleFinalTotal.Text)).ToString();
            }
        }

        private void btnClearBoxes_Click(object sender, EventArgs e)
        {
            txtFishPetSaleFinalTotal.Text = "";
            txtFishPetSaleAmountPaid.Text = "";
            txtFishPetSaleChangeDue.Text = "";
        
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {

            cboFishPetSaleItems.Text = "";
            txtFishPetSalePrice.Text = "";
            txtFishPetSaleQuantity.Text = "";
            txtFishPetSaleTotal.Text = "";
            txtFishPetSaleDiscount.Text = "";
            txtFishPetSaleAmountDue.Text = "";
            txtFishPetSaleAmountPaid.Text = "";
            txtFishPetSaleChangeDue.Text = "";
            pbFishPetSale.Image = null;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            int row = 0;
            dgvFishPetSale.Rows.Add();
            row = dgvFishPetSale.Rows.Count - 2;
            dgvFishPetSale["Item", row].Value = cboFishPetSaleItems.Text;
            dgvFishPetSale["Quantity", row].Value = txtFishPetSaleQuantity.Text;
            dgvFishPetSale["Price", row].Value = txtFishPetSalePrice.Text;
            dgvFishPetSale["Total", row].Value = txtFishPetSaleAmountDue.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand command = con.CreateCommand();
            var image = new ImageConverter().ConvertTo(pbFishPetSale.Image, typeof(Byte[]));
            command.Parameters.AddWithValue("@Date", dateTimePicker1.Text);
            command.Parameters.AddWithValue("@Item", cboFishPetSaleItems.Text);
            command.Parameters.AddWithValue("@Price", txtFishPetSalePrice.Text);
            command.Parameters.AddWithValue("@Quantity", txtFishPetSaleQuantity.Text);
            command.Parameters.AddWithValue("@Total", txtFishPetSaleTotal.Text);
            command.Parameters.AddWithValue("@Discount", txtFishPetSaleDiscount.Text);
            command.Parameters.AddWithValue("@Amount_Due", txtFishPetSaleAmountDue.Text);
            command.Parameters.AddWithValue("@Photo", image);
            command.CommandText = ("insert into Fish_Pet_Sale(Date,Item,Price,Quantity,Total,Discount,Amount_Due,Photo) values(@Date,@Item,@Price,@Quantity,@Total,@Discount,@Amount_Due,@Photo)");
            if (command.ExecuteNonQuery() > 0)
                MessageBox.Show("Data Was Inserted Successfully.", "Operation Successful.");
            else
                MessageBox.Show("Incorrect Details Inserted.");
            con.Close();
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            dgvFishPetSale.Rows.Clear();
        }

        private void cboFishPetSaleItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFishPetSaleItems.SelectedItem.ToString() == "NEMO")
            {
                txtFishPetSalePrice.Text = "350";


            }

            else
                if (cboFishPetSaleItems.SelectedItem.ToString() == "DORY")
                {
                    txtFishPetSalePrice.Text = "400";
                }
                else
                    if (cboFishPetSaleItems.SelectedItem.ToString() == "BUBBLES")
                    {
                        txtFishPetSalePrice.Text = "650";
                    }
                    else
                        if (cboFishPetSaleItems.SelectedItem.ToString() == "JEWEL")
                        {
                            txtFishPetSalePrice.Text = "800";
                        }
                        else
                            if (cboFishPetSaleItems.SelectedItem.ToString() == "CAPTAIN")
                            {
                                txtFishPetSalePrice.Text = "900";
                            }
                            else
                                if (cboFishPetSaleItems.SelectedItem.ToString() == "ANGEL")
                                {
                                    txtFishPetSalePrice.Text = "600";
                                }
        }
    }
}
