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
    public partial class Person_UpdateorAdder : Form
    {
        Person person;

        public Person_UpdateorAdder()
        {
            InitializeComponent();
        }

	private void PersonObjectFill()
	{
	        person.FName = FNametxt.Text;
	        person.LName = LNametxt.Text;
            person.Email = Emailtxt.Text;
            person.Phone_Number = Phonetxt.Text;
            int reward = Int32.Parse(Rewardptstxt.Text);

            person.Set_Reward_Points(reward);
            person.IsTeacher = Isteacherchkbx.Checked;
            person.IsSenior = Isseniorchkbx.Checked;
            person.IsVeteran = Isveteranchkbx.Checked;
            person.IsAdmin = Isadminchkbx.Checked;

	}
	
        private void Submitbtn_Click(object sender, EventArgs e)
        {
            PersonObjectFill();

            if (PersonOperations.AddorUpdatePerson(person)){

            }
        }

        private void Getcustomerbtn_Click(object sender, EventArgs e)
        {
            int perid = 0;
            if (Int32.TryParse(IDtxt.Text, out perid))
            {
                person = PersonOperations.ReturnPerson(perid);
                if (person != null)
                {
                    IDtxt.Text = person.ID.ToString();
                    FNametxt.Text = person.FName;
                    LNametxt.Text = person.LName;
                    Phonetxt.Text = person.Phone_Number;
                    Emailtxt.Text = person.Email;
                    Rewardptstxt.Text = person.Reward_Points.ToString();
                    Isteacherchkbx.Checked = person.IsTeacher;
                    Isseniorchkbx.Checked = person.IsSenior;
                    Isveteranchkbx.Checked = person.IsVeteran;
                    Isadminchkbx.Checked = person.IsAdmin;
                }
            }
            else
            {
                MessageBox.Show("Can't convert id box into a number, please put in a number into the id box");
            }

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(IDtxt.Text);

            if (PersonOperations.DeletePerson(id) == false)
            {
                MessageBox.Show("ID doesn't exist, can't delete");
            }
        }
    }
}
