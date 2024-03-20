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
    public partial class Fish_Pet_Sale_Data : Form
    {
        public Fish_Pet_Sale_Data()
        {
            InitializeComponent();
        }

        private void Fish_Pet_Sale_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sN_Pets_Fish_Pet_Sale_DataSet.Fish_Pet_Sale' table. You can move, or remove it, as needed.
            this.fish_Pet_SaleTableAdapter.Fill(this.sN_Pets_Fish_Pet_Sale_DataSet.Fish_Pet_Sale);

        }
    }
}
