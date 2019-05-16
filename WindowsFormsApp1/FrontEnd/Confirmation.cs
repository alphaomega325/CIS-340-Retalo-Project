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
    public partial class Confirmation : Form
    {
        


 

        public Confirmation()
        {
            InitializeComponent();
  
        }

        public Confirmation(String message)
        {
            InitializeComponent();
            confirmationlbl.Text = message;
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Delete_Confirmation_Load(object sender, EventArgs e)
        {

        }
    }
}
