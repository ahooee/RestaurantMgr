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
    public partial class SplashScr : Form
    {

        Timer timer;
        public SplashScr()
        {
            InitializeComponent();



             timer = new Timer();


            timer.Interval = 3000;


            timer.Start();

            timer.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer.Stop();


            Form vorood = new Form1();
            this.Hide();

            vorood.Show();


        }
    }
}
