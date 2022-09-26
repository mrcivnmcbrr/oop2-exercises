using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabDemo
{
    public partial class frmTicket : Form
    {
        public frmTicket()
        {
            InitializeComponent();
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int getRand = r.Next();
            lblID.Text = getRand.ToString();
        }
    }
}
