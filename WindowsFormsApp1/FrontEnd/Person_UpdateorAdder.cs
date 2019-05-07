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

	private Boolean PersonObjectFill()
	{
            
            if (Int32.TryParse(Rewardptstxt.Text, out int reward))
            {
                person = new Person();


                if(Int32.TryParse(IDtxt.Text, out int id))
                {
                    person.ID = id;
                }
                person.FName = FNametxt.Text;
                person.LName = LNametxt.Text;
                person.Email = Emailtxt.Text;
                person.Phone_Number = Phonetxt.Text;
                person.Set_Reward_Points(reward);
                person.Password = Passwordtxt.Text;
                person.IsTeacher = Isteacherchkbx.Checked;
                person.IsSenior = Isseniorchkbx.Checked;
                person.IsVeteran = Isveteranchkbx.Checked;
                person.IsAdmin = Isadminchkbx.Checked;
                return true;
            }
            else
            {
                return false;
            }
	}
	
        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if (PersonObjectFill()){
               // if (PersonOperations.AddorUpdatePerson(person))
                if(DatabaseOperation.AddorUpdateItem(person))
                {
                    MessageBox.Show("Addition or modification is a success");
                }
                else
                {
                    MessageBox.Show("Addition or modification wasn't a success");
                }
            }

        }

        private void Getcustomerbtn_Click(object sender, EventArgs e)
        {
            int perid = 0;
            if (Int32.TryParse(IDtxt.Text, out perid))
            {
                person = new Person();
                person.ID = perid;
                person = DatabaseOperation.ReturnItem(person);
                if (person != null)
                {
                    IDtxt.Text = person.ID.ToString();
                    FNametxt.Text = person.FName;
                    LNametxt.Text = person.LName;
                    Phonetxt.Text = person.Phone_Number;
                    Emailtxt.Text = person.Email;
                    Rewardptstxt.Text = person.Reward_Points.ToString();
                    Passwordtxt.Text = person.Password;
                    Isteacherchkbx.Checked = person.IsTeacher;
                    Isseniorchkbx.Checked = person.IsSenior;
                    Isveteranchkbx.Checked = person.IsVeteran;
                    Isadminchkbx.Checked = person.IsAdmin;
                }
                else
                {
                    MessageBox.Show("You have selected a empty id, you can now fill it.");
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

            if (DatabaseOperation.DeleteItem(id, "Person") == false)
            {
                MessageBox.Show("ID doesn't exist, can't delete");
            }
        }

        private void Person_UpdateorAdder_Load(object sender, EventArgs e)
        {

        }
    }
}
