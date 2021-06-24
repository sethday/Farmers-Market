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
    public partial class frmShoppingCart : Form
    {
        // The shopping cart should take the items that the customer selects and show them. When the customer confirms the order it is sent the the driver and market owners view.
        public frmShoppingCart()
        {
            InitializeComponent();
        }

        private void btnConfirmYourOrder_Click(object sender, EventArgs e)
        {
            // send the confirmed order to the order table for the driver and market owner to see.
            MessageBox.Show("We're working on your order!!");
            this.Close();
        }

        private void frmShoppingCart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ShoppingCartTable' table. You can move, or remove it, as needed.
            this.shoppingCartTableTableAdapter.Fill(this.dataSet1.ShoppingCartTable);

        }
    }
}
