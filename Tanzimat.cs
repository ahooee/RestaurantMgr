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
    public partial class Tanzimat : Form
    {
        

        FormAfzoodanGhaza formAfzoodanGhaza;
        public Tanzimat()
        {
            InitializeComponent();

            formAfzoodanGhaza = new FormAfzoodanGhaza();

           


        }

        private void buttonAfzoodanGhaza_Click(object sender, EventArgs e)
        {
            formAfzoodanGhaza.Show();
            
        }

        private void Tanzimat_FormClosing(object sender, FormClosingEventArgs e)
        {


            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();


            }
        }
    }
}
