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
    public partial class Fish_Acc_Stock_Data : Form
    {
        public Fish_Acc_Stock_Data()
        {
            InitializeComponent();
        }

        private void Fish_Acc_Stock_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sN_Pets_Fish_Acc_Stock_DataSet.Fish_Acc_Stock' table. You can move, or remove it, as needed.
            this.fish_Acc_StockTableAdapter.Fill(this.sN_Pets_Fish_Acc_Stock_DataSet.Fish_Acc_Stock);

        }
    }
}