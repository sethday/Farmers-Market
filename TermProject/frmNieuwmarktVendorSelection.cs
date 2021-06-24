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
    public partial class frmNieuwmarktVendorSelection : Form
    {
        public frmNieuwmarktVendorSelection()
        {
            InitializeComponent();
        }

        private void btnSallysSalsa_Click(object sender, EventArgs e)
        {
            frmSallysSalsa frmSS = new frmSallysSalsa();
            frmSS.ShowDialog();
            this.Close();
        }

        private void btnFruitGiant_Click(object sender, EventArgs e)
        {
            frmFruitGiant frmFG = new frmFruitGiant();
            frmFG.ShowDialog();
            this.Close();
        }

        private void btnFresherThanFresh_Click(object sender, EventArgs e)
        {
            frmFresherThanFresh frmFTF = new frmFresherThanFresh();
            frmFTF.ShowDialog();
            this.Close();
        }
    }
}
