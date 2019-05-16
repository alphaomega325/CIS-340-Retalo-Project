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
    public partial class Outstanding_Invoices : Form
    {
        public Outstanding_Invoices()
        {
            InitializeComponent();
        }

        private void Outstanding_Invoices_Load(object sender, EventArgs e)
        {
           
            
            this.invoiceTableAdapter.FillBy3(this.retalo_DBDataSet.Invoice);

        }

      

    }
}
