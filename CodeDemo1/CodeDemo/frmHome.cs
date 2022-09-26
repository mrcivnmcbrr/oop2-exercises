using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeDemo
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
        }

        private void chkNone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNone.Checked == true)
            {
                chkBasketball.Enabled = false;
                chkMusic.Enabled = false;
                txtotherhobbies.Enabled = false;
            }
            else
            {
                chkBasketball.Enabled = true;
                chkMusic.Enabled = true;
                txtotherhobbies.Enabled = true;

            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string fullname;
            string course;
            string hobby;
            string gender;
            string subject;
            string address;
            //FullName
            fullname = txtfirstname.Text + " " + txtlastname.Text;
            //Course
            course = cbCourse.Text;
            //Address
            address = txtaddress.Text;
            //Subject
            subject = lstSubjects.Text;
            this.Hide();
            //Load values to frmRegistration2
            frmRegistration2 nard = new frmRegistration2();
            nard.lblname.Text = fullname;
            nard.lblcourse.Text = course;
            nard.lbladdress.Text = address;

            //Hobbies
            if (chkBasketball.Checked == true && chkMusic.Checked == true)
            {
                hobby = "Basketball, Music";
                nard.lblhobbies.Text = hobby;
            }
            else if (chkMusic.Checked == true)
            {
                hobby = "Music";
                nard.lblhobbies.Text = hobby;
            }
            else if (chkBasketball.Checked == true)
            {
                hobby = "Basketball";
                nard.lblhobbies.Text = hobby;
            }
            else if (chkNone.Checked == true)
            {
                hobby = "None";
                nard.lblhobbies.Text = hobby;
            }
            else
            {
                hobby = txtotherhobbies.Text;
                nard.lblhobbies.Text = hobby;
            }

            //Gender
            if (rbFemale.Checked == true)
            {
                gender = "Female";
                nard.lblgender.Text = gender;
            }
            else
            {
                gender = "Male";
                nard.lblgender.Text = gender;
            }
            //Subjects
            nard.lblsubject.Text = subject;

            nard.ShowDialog();
            this.Close();

           

        }

        
    }
}
