﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class frmTheGreenMachine : Form
    {
        public frmTheGreenMachine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmShoppingCart frmSC = new frmShoppingCart();
            frmSC.ShowDialog();
            this.Close();
        }

        private void productTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
