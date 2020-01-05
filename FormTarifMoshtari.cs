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
    public partial class FormTarifMoshtari : Form
    {
        FormAsli formAsli;

        public FormTarifMoshtari(FormAsli form)
        {
            InitializeComponent();
            this.textBoxAddress.Multiline = true;

            formAsli = form;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormTarifMoshtari_Load(object sender, EventArgs e)
        {

        }

        private void buttonAfzoodanMoshtari_Click(object sender, EventArgs e)
        {
            amaliatEpayagahEdadae amaliat = new amaliatEpayagahEdadae();

            amaliat.vorrodEsatr("Moshtariha","0,"+"'"+this.textBoxName.Text+"',"+ "'" + this.textBoxNameKhanevadegi.Text + "'," + "'" + this.textBoxTel.Text + "'," + "'" + this.textBoxMob.Text + "'," + "'" + this.textBoxAddress.Text + "',"+0+","+0+","+0);


            formAsli.PishMoshtarihaLoad();
            

            this.Hide();






        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormTarifMoshtari_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();


            }

        }
    }
}
