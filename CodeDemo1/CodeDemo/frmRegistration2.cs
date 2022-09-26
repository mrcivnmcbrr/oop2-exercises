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
    public partial class frmRegistration2 : Form
    {
        public frmRegistration2()
        {
            InitializeComponent();
        }

        private void frmRegistration2_Load(object sender, EventArgs e)
        {

        }

        public void CallHomeValues()
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome nard = new frmHome();
            nard.ShowDialog();
            this.Close();

        {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult diaglogresult = MessageBox.Show("Are you sure you want to submit?", "Submission", MessageBoxButtons.YesNo);
            if (diaglogresult == DialogResult.Yes)
            {
                MessageBox.Show("Sucessfully submitted!");
            }
            else
            {
                MessageBox.Show("Aborted", "Aborted!!",MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
