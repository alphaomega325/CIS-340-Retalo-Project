﻿using System;
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
    public partial class Admin_Main_Menu : Form
    {
        public Admin_Main_Menu()
        {
            InitializeComponent();
        }

        private void PersonViewerbtn_Click(object sender, EventArgs e)
        {
            Person_Viewer person_viewer = new Person_Viewer();
            person_viewer.Show();
        }

        private void Product_viewerbtn_Click(object sender, EventArgs e)
        {
            Product_Viewer product_viewer = new Product_Viewer();
            product_viewer.Show();
        }

        private void Invoice_Viewerbtn_Click(object sender, EventArgs e)
        {
            Invoice_Viewer invoice_Viewer = new Invoice_Viewer();
            invoice_Viewer.Show();

        }

        private void Personupdatorbtn_Click(object sender, EventArgs e)
        {
            Person_UpdateorAdder person_updator = new Person_UpdateorAdder();
            person_updator.Show();
        }
    }
}
