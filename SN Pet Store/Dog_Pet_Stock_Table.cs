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
    public partial class Dog_Pet_Stock_Table : Form
    {
        public Dog_Pet_Stock_Table()
        {
            InitializeComponent();
        }

        private void Dog_Pet_Stock_Table_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sN_Pets_Dog_Pet_Stock_DataSet.Dog_Pet_Stock' table. You can move, or remove it, as needed.
            this.dog_Pet_StockTableAdapter.Fill(this.SN_Pets_Dog_Pet_Stock_DataSet.Dog_Pet_Stock);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
