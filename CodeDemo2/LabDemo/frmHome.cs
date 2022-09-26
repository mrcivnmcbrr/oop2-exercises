using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LabDemo
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void lstsource_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Taft
            //Magallanes
            //Ayala
            //Buendia
            //Guadalupe
            //Boni
            //Shaw
            //Ortigas
            //Santolan
            //Cubao
            //GMA
            //Quezon Ave
            //North Ave
            switch (lstsource.SelectedIndex)
            {
                case 0: //Taft
                btntaft.Enabled = false;
                btnAyala.Enabled = true;
                btncubao.Enabled = true;
                btnGMA.Enabled = true;
                btnmagal.Enabled = true;
                btnnorth.Enabled = true;
                btnOrtigas.Enabled = true;
                btnsantolan.Enabled = true;
                btnGuada.Enabled = true;
                btnBuendia.Enabled = true;
                break;
                case 1://Magallanes
                    btntaft.Enabled = true;
                    btnAyala.Enabled = true;
                    btncubao.Enabled = true;
                    btnGMA.Enabled = true;
                    btnmagal.Enabled = false;
                    btnnorth.Enabled = true;
                    btnOrtigas.Enabled = true;
                    btnsantolan.Enabled = true;
                    btnGuada.Enabled = true;
                    btnBuendia.Enabled = true;
                    break;
                case 2: //Ayala
                    btntaft.Enabled = true;
                    btnAyala.Enabled = false;
                    btncubao.Enabled = true;
                    btnGMA.Enabled = true;
                    btnmagal.Enabled = true;
                    btnnorth.Enabled = true;
                    btnOrtigas.Enabled = true;
                    btnsantolan.Enabled = true;
                    btnGuada.Enabled = true;
                    btnBuendia.Enabled = true;
                    break;
                case 3: //Buendia
                    btntaft.Enabled = true;
                    btnAyala.Enabled = true;
                    btncubao.Enabled = true;
                    btnGMA.Enabled = true;
                    btnmagal.Enabled = true;
                    btnnorth.Enabled = true;
                    btnOrtigas.Enabled = true;
                    btnsantolan.Enabled = true;
                    btnGuada.Enabled = true;
                    btnBuendia.Enabled = false;
                    break;
                case 9: //Cubao
                    btntaft.Enabled = true;
                    btnAyala.Enabled = true;
                    btncubao.Enabled = false;
                    btnGMA.Enabled = true;
                    btnmagal.Enabled = true;
                    btnnorth.Enabled = true;
                    btnOrtigas.Enabled = true;
                    btnsantolan.Enabled = true;
                    btnGuada.Enabled = true;
                    btnBuendia.Enabled = true;
                    break;
            }



        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAyala_Click(object sender, EventArgs e)
        {
            lblPrice.Text = "15.00";
            txtcash.Focus();
        }

        private void txtcash_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                double price, change;
                int cash;
                if (txtcash.Text == "")
                {
                    txtcash.Text = "0";
                }
               
                price = Convert.ToDouble(lblPrice.Text);
                cash = Convert.ToInt32(txtcash.Text);
                change = cash - price;

                lbltotal.Text = change.ToString();
                txtchange.Text = change.ToString();
                
            }
            catch (Exception nard)
            {
                MessageBox.Show(nard.Message);
            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        public void ValidateValues(TextBox txt)
        {
            if(txt.Text == string.Empty || !Regex.IsMatch(txt.Text,@"^[0-9]+$"))
            {
                MessageBox.Show("Please enter number only or value should not be empty");
                txt.Clear();
                txt.Focus();
                return;
            }
;        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            ValidateValues(txtcash);
            MessageBox.Show("Payment has been made.");
            MessageBox.Show("Your ticket has been printed");
            frmTicket nard = new frmTicket();
            nard.ShowDialog();
            this.Close();
        }

        private void checkRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckRoutecs nard = new frmCheckRoutecs();
            nard.ShowDialog();
        }
    }
}
