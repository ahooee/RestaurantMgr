using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantMgr_pnuProj
{
    public partial class FormAfzoodanGhaza : Form
    {

        amaliatEpayagahEdadae amaliat;
        public FormAfzoodanGhaza()
        {
            InitializeComponent();

            this.numericUpDown1.Maximum = decimal.MaxValue;

            amaliat = new amaliatEpayagahEdadae();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAfzoodan_Click(object sender, EventArgs e)
        {

            

            amaliat.vorrodEsatr("Ghazaha","0"+",'"+this.textBoxnaam.Text+"',"+this.numericUpDown1.Value+","+1);


            this.Hide();
        }

        private void FormAfzoodanGhaza_Load(object sender, EventArgs e)
        {

        }

        private void FormAfzoodanGhaza_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();


            }
        }
    }
}
