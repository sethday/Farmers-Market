using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TermProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
           // SqlConnection con = new SqlConnection(@"Data Source=USER;Initial Catalog=admin;Integrated Security=True"); // making connection   
           // check if the username matches on of the customer username in the table. 

            frmMarketSelection frmMS = new frmMarketSelection();
            frmMS.ShowDialog();
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.dataSet1.UserTable);

        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            // checks if the market owner username is in the table 
            frmMarketView frmMS = new frmMarketView();
            frmMS.ShowDialog();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            //checks if the driver username is in the table 
            frmDeliveryView frmMS = new frmDeliveryView();
            frmMS.ShowDialog();
        }
    }
}
