using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;



namespace restaurantMgr_pnuProj
{
    public partial class FormAsli : Form
    {
        Form resetForm;
        FormTarifMoshtari formTarifMoshtari;

        public FormAsli()
        {
            InitializeComponent();
            resetForm = new Form2();
            tableMenuAsli.Hide();
            this.tablePishkhan.Hide();
            this.tableAshpaz.Hide();
            this.tableSandogh.Hide();
            this.tablePishkhan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
             formTarifMoshtari = new FormTarifMoshtari();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=194.5.177.118;port=3306;database=pnuPrj;username=ahooee;password=lin^^xpnu&&Prj@c#in15");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();
                mySqlCommand.CommandType = CommandType.Text;
                mySqlCommand.CommandText = "Select * from login where uname='" + textBoxNameKarbari.Text + "' and upass='" + textBoxGozarVazhe.Text + "'";
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    //FAGHAT BARAYE TEST

                    this.flowLayoutPanelVorood.Hide();
                    this.tableMenuAsli.Show();
                    this.Text = "صفحه مدیر";

                    this.FormBorderStyle = FormBorderStyle.Sizable;


                }
                else
                {


                    MessageBox.Show("نام کاربری یا گذرواژه اشتباه است!","ورود نا موفق");


                }
               

                Console.WriteLine(" ANJAM SHOD!");

            }
            catch (Exception exeption)
            {
                Console.WriteLine("vasl nashod ke : {0}",exeption);
            }



            }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



      

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            resetForm.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSandogh_Click(object sender, EventArgs e)
        {
            this.tablePishkhan.Hide();
            this.tableAshpaz.Hide();
            this.tableSandogh.Show();

            this.buttonSandogh.BackColor = Color.LimeGreen;
            this.buttonAshpazkhaneh.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);
            this.buttonPishkhan.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);
            this.buttonTanzimat.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);
            this.buttonMali.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);

        }

        private void buttonPishkhan_Click(object sender, EventArgs e)
        {
            this.tableAshpaz.Hide();
            this.tableSandogh.Hide();
            this.tablePishkhan.Show();
            this.buttonPishkhan.BackColor = Color.LimeGreen;
            this.buttonAshpazkhaneh.BackColor = Color.FromArgb(0x2f,0x9b,0xff);
            this.buttonSandogh.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);
            this.buttonTanzimat.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);
            this.buttonMali.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);


        }

        private void buttonAshpazkhaneh_Click(object sender, EventArgs e)
        {
            this.tablePishkhan.Hide();
            this.tableSandogh.Hide();
            this.tableAshpaz.Show();

            this.buttonAshpazkhaneh.BackColor = Color.LimeGreen;
            this.buttonPishkhan.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);
            this.buttonSandogh.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);
            this.buttonTanzimat.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);
            this.buttonMali.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);

        }

        private void buttonKhorooj_Click(object sender, EventArgs e)
        {
            this.tablePishkhan.Hide();
            this.tableAshpaz.Hide();
            this.tableSandogh.Hide();
            this.flowLayoutPanelVorood.Show();
            this.tableMenuAsli.Hide();
            this.Text = "صفحه ورود";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonTanzimat_Click(object sender, EventArgs e)
        {


            
        }

        private void buttonTasvieh_Click(object sender, EventArgs e)
        {

        }

        private void buttonAshpazkhaneh_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void tableSandogh_Paint(object sender, PaintEventArgs e)
        {

        }


        private void buttonMali_Click(object sender, EventArgs e)
        {
            this.tablePishkhan.Hide();
            this.tableAshpaz.Hide();
            this.tableSandogh.Hide();

            this.buttonMali.BackColor = Color.LimeGreen;
            this.buttonAshpazkhaneh.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);
            this.buttonPishkhan.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);
            this.buttonTanzimat.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);
            this.buttonSandogh.BackColor = Color.FromArgb(0x2f, 0x9b, 0xff);

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonTarifeMoshtari_Click(object sender, EventArgs e)
        {
            formTarifMoshtari.Show();
        }

        private void listViewMoshtariPishkhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

