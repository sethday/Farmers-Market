using System;
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
    public partial class frmSallysSalsa : Form
    {
        public frmSallysSalsa()
        {
            InitializeComponent();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            frmShoppingCart frmSC = new frmShoppingCart();
            frmSC.ShowDialog();
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
