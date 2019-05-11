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
    public partial class Product_Updator_or_Adder : Form
    {
        public Product_Updator_or_Adder()
        {
            InitializeComponent();
        }

        private void Product_Updator_or_Adder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'retalo_DBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.retalo_DBDataSet.Products);

        }

        private void submitbtn_Click(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }
    }
}
