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
    public partial class Dog_Food_Sale_Data : Form
    {
        public Dog_Food_Sale_Data()
        {
            InitializeComponent();
        }

        private void Dog_Food_Sale_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sN_PetsDataSet2.Dog_Food_Sale' table. You can move, or remove it, as needed.
            this.dog_Food_SaleTableAdapter.Fill(this.SN_Pets_Dog_Food_Sale_DataSet.Dog_Food_Sale);

        }
    }
}
