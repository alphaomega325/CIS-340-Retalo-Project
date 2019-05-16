using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retalo
{
    public partial class Customer_Shopping : Form
    {
        Person customer;
        Invoice invoice;
        public Customer_Shopping(Person customer)
        {
            InitializeComponent();
            this.customer = customer;
            invoice = new Invoice();
        }

        private void Customer_Shopping_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'retalo_DBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.retalo_DBDataSet.Products);

        }

        private void Purchasebtn_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }

        private void userewardschkbx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void productaddbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
