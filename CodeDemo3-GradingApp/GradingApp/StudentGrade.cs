using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingApp
{
    public class StudentGrade
    {
        //fields
        private string studentname;
        private int studentID;
        private string course;
        private string section; 
        private int academic_year;
        private string subject;
        private double quiz1;
        private double quiz2;
        private double quiz3;
        private double majorexam;
        private double project;
        private double recitation;
        private double attendance;
       

        //property method
        public string StudentName
        {
            get //readlonly
            {
                return studentname;
            }
            set //read-write
            {
                this.studentname = value;
            }
        }
        public int StudentID
        {
            get //readlonly
            {
                return studentID;
            }
            set //read-write
            {
                this.studentID = value;
            }
        }
        public string Course
        {
            get //readlonly
            {
                return course;
            }
            set //read-write
            {
                this.course = value;
            }
        }
        public string Section
        {
            get //readlonly
            {
                return section;
            }
            set //read-write
            {
                this.section = value;
            }
        }
        public int AcademicYear
        {
            get //readlonly
            {
                return academic_year;
            }
            set //read-write
            {
                this.academic_year = value;
            }
        }
        public string Subject
        {
            get //readlonly
            {
                return subject;
            }
            set //read-write
            {
                this.subject = value;
            }
        }

        public double Quiz1
        {
            get //readlonly
            {
                return quiz1;
            }
            set //read-write
            {
                this.quiz1 = value;
            }
        }
        public double Quiz2
        {
            get //readlonly
            {
                return quiz2;
            }
            set //read-write
            {
                this.quiz2 = value;
            }
        }
        public double Quiz3
        {
            get //readlonly
            {
                return quiz3;
            }
            set //read-write
            {
                this.quiz3 = value;
            }
        }

        public double MajorExam
        {
            get //readlonly
            {
                return majorexam;
            }
            set //read-write
            {
                this.majorexam = value;
            }
        }
        public double Project
        {
            get //readlonly
            {
                return project;
            }
            set //read-write
            {
                this.project = value;
            }
        }
        public double Recitation
        {
            get //readlonly
            {
                return recitation;
            }
            set //read-write
            {
                this.recitation = value;
            }
        }
        public double Attendance
        {
            get //readlonly
            {
                return attendance;
            }
            set //read-write
            {
                this.attendance = value;
            }
        }

        public double ComputeQuiz()
        {   
            return (Quiz1 + Quiz2 + Quiz3) / 3 * .25;
        }
        public double ComputeMajorExam()
        {
            return MajorExam * .30;
        }
        public double ComputeProject()
        {
            return Project * .20;
        }
        public double ComputeRecitation()
        {
            return Recitation * .15;
        }
        public double ComputeAttendance()
        {
            return Attendance * .10;
        }

        public double ComputeMidterGrade() //40%
        {
            return (ComputeAttendance() + ComputeMajorExam() + ComputeProject() + ComputeQuiz() + ComputeRecitation()) * .40;
        }
        public double ComputeFinalGrade() //60%
        {
            return (ComputeAttendance() + ComputeMajorExam() + ComputeProject() + ComputeQuiz() + ComputeRecitation()) * .60;
        }
        public double ComputeFinalRating(double midterm, double final)
        {
            return midterm + final;
        }
        public double EvaluateGrade()
        {
            return ComputeFinalRating(ComputeFinalGrade(),ComputeMidterGrade());
        }

        public void Evaluate()
        {
            if (EvaluateGrade() < 75)
            {
                MessageBox.Show("Failed");
            }
            else
            {
                MessageBox.Show("Passed");
            }
        }
        
        }


    
}
