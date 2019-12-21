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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
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
                mySqlCommand.CommandText = "Select * from login where uname='" + textBox1.Text + "' and upass='" + textBox2.Text + "'";
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                if (mySqlDataReader.HasRows)
                {
                    //FAGHAT BARAYE TEST

                    MessageBox.Show("نام کاربری و گذرواژه صحیح است!","ورود موفق");

                }
                else{


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
    }
}

