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
    public partial class Person_Viewer : Form
    {
        public Person_Viewer()
        {
            InitializeComponent();
        }

        private void Person_Viewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'retalo_DBDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.retalo_DBDataSet.Person);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
