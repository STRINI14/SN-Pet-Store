﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SN_Pet_Store
{
    public partial class Fish_Pet_Care_Stock_Data : Form
    {
        public Fish_Pet_Care_Stock_Data()
        {
            InitializeComponent();
        }

        private void Fish_Pet_Care_Stock_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sN_Pets_Fish_Pet_Care_DataSet.Fish_Pet_Care_Stock' table. You can move, or remove it, as needed.
            this.fish_Pet_Care_StockTableAdapter.Fill(this.sN_Pets_Fish_Pet_Care_DataSet.Fish_Pet_Care_Stock);

        }
    }
}