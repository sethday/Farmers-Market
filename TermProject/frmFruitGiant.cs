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
    public partial class frmFruitGiant : Form
    {
        public frmFruitGiant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmShoppingCart frmSC = new frmShoppingCart();
            frmSC.ShowDialog();
        }
    }
}
