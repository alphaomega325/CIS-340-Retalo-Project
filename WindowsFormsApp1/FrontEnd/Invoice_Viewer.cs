using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retalo.FrontEnd
{
    public partial class Invoice_Viewer : Form
    {
        public Invoice_Viewer()
        {
            InitializeComponent();
        }

        private void Invoice_Viewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'retalo_DBDataSet.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.retalo_DBDataSet.Invoice);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.invoiceTableAdapter.FillBy(this.retalo_DBDataSet.Invoice);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
