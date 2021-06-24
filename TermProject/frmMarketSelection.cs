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
    public partial class frmMarketSelection : Form
    {
        public frmMarketSelection()
        {
            InitializeComponent();
        }

        private void btnNieuwmarkt_Click(object sender, EventArgs e)
        {
            frmNieuwmarktVendorSelection frmNiVS = new frmNieuwmarktVendorSelection();
            frmNiVS.ShowDialog();
            this.Close();
        }

        private void btnNoordermarkt_Click(object sender, EventArgs e)
        {
            frmNoordermarktVendorSelection frmNoVS = new frmNoordermarktVendorSelection();
            frmNoVS.ShowDialog();
            this.Close();
        }
    }
}
