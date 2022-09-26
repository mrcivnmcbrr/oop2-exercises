using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingApp
{
    public partial class frmGrade : Form
    {
        public frmGrade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                StudentGrade nard = new StudentGrade();

                double q1, q2, q3, exam, project;
                double recitation, attendance;
                string studentname;
                double midterm, final;
                int studentid;
                q1 = Convert.ToDouble(txtQ1.Text);
                q2 = Convert.ToDouble(txtQ2.Text);
                q3 = Convert.ToDouble(txtQ3.Text);
                exam = Convert.ToDouble(txtexam.Text);
                project = Convert.ToDouble(txtproject.Text);
                recitation = Convert.ToDouble(txtrecite.Text);
                attendance = Convert.ToDouble(txtattendance.Text);
                studentname = txtStudentName.Text;
                studentid = Convert.ToInt32(txtID.Text);
                midterm = Convert.ToDouble(lblMidterm.Text);
                final = Convert.ToDouble(lblfinal.Text);




                //set
                nard.Quiz1 = q1;
                nard.Quiz2 = q2;
                nard.Quiz3 = q3;
                nard.MajorExam = exam;
                nard.Recitation = recitation;
                nard.Project = project;
                nard.Attendance = attendance;
                nard.StudentName = studentname;
                nard.StudentID = studentid;


                //get
                if (rbMidterm.Checked == true)
                {
                    dtMidterm.Rows.Add(nard.StudentName, nard.StudentID, nard.ComputeQuiz(), nard.ComputeMajorExam(), nard.ComputeProject(), nard.ComputeRecitation(), nard.ComputeAttendance(), nard.ComputeMidterGrade());
                    lblMidterm.Text = nard.ComputeMidterGrade().ToString();

                }
                else if (rbFinals.Checked == true)
                {
                    dtFinal.Rows.Add(nard.StudentName, nard.StudentID, nard.ComputeQuiz(), nard.ComputeMajorExam(), nard.ComputeProject(), nard.ComputeRecitation(), nard.ComputeAttendance(), nard.ComputeFinalGrade());
                    lblfinal.Text = nard.ComputeFinalGrade().ToString();

                }
                else
                {
                    MessageBox.Show("Please select period!");
                    return;
                }


                MessageBox.Show("Your Final rating is " + nard.ComputeFinalRating(Convert.ToDouble(lblMidterm.Text), Convert.ToDouble(lblfinal.Text)).ToString());
                nard.Evaluate();
            }
            
            catch (Exception er)
           {
               MessageBox.Show(er.Message);
               txtStudentName.Focus();
           }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtQ3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void frmGrade_Load(object sender, EventArgs e)
        {

        }
    }
}
