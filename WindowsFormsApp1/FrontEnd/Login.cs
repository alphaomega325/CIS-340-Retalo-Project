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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            loginverification login = new loginverification();
            if(login.Verify(passwordtxt.Text, emailtxt.Text))
            {
                if (login.CheckAdmin())
                {
                    Admin_main_menu menu = new Admin_main_menu();
                    menu.ShowDialog();
                    this.Exit();
                }

            }
            else
            {

            }


        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
