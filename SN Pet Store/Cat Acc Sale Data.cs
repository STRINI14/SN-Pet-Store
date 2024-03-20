using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SN_Pet_Store
{
    public partial class Cat_Acc_Sale_Data : Form
    {
        public Cat_Acc_Sale_Data()
        {
            InitializeComponent();
        }

        private void Cat_Acc_Sale_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sN_Pets_Cat_Acc_Sale_DataSet.Cat_Acc_Sale' table. You can move, or remove it, as needed.
            this.cat_Acc_SaleTableAdapter.Fill(this.sN_Pets_Cat_Acc_Sale_DataSet.Cat_Acc_Sale);

        }
    }
}
