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
    public partial class frmNoordermarktVendorSelection : Form
    {
        public frmNoordermarktVendorSelection()
        {
            InitializeComponent();
        }

        private void btnMrPotatoe_Click(object sender, EventArgs e)
        {
            frmMrPotatoe frmMP = new frmMrPotatoe();
            frmMP.ShowDialog();
            this.Close();
        }

        private void btnFruityFruits_Click(object sender, EventArgs e)
        {
            frmFruityFruits frmFF = new frmFruityFruits();
            frmFF.ShowDialog();
            this.Close();
        }

        private void btnTheGreenMachine_Click(object sender, EventArgs e)
        {
            frmTheGreenMachine frmTGM = new frmTheGreenMachine();
            frmTGM.ShowDialog();
            this.Close();
        }
    }
}
