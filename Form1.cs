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

        Tanzimat tanzimat;
        Form resetForm;
        FormTarifMoshtari formTarifMoshtari;

        amaliatEpayagahEdadae amaliat;


        public FormAsli()
        {

            InitializeComponent();
            resetForm = new Form2();
            tableMenuAsli.Hide();
            this.tablePishkhan.Hide();
            this.tableAshpaz.Hide();
            this.tableSandogh.Hide();
            this.tablePishkhan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
             formTarifMoshtari = new FormTarifMoshtari(this);

            tanzimat = new Tanzimat();

            this.numericUpDownEshterak.Maximum = decimal.MaxValue;
            this.numericUpDownMablagh.Maximum = decimal.MaxValue;
            amaliat = new amaliatEpayagahEdadae();


            PishGhazaLoad();

            PishMoshtarihaLoad();

            AshGhazaLoad();
            AshMoshtarihaLoad();

            SandoghMoshtarihaLoad();
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
             
                if (amaliat.ayaSatr("login", "where uname='" + textBoxNameKarbari.Text + "' and upass='" + textBoxGozarVazhe.Text + "'"))
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


            tanzimat.Show();



            
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

            //Tarif E Moshtari E jadid

            formTarifMoshtari.Show();
        }

        private void listViewMoshtariPishkhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonEshterak_Click(object sender, EventArgs e)
        {
            //eshterak E Ghabli




        }

        public void PishGhazaLoad()
        {

            this.listViewListGhazaPishkhan.Items.Clear();


            this.listViewListGhazaPishkhan.FullRowSelect = true;

            this.listViewListGhazaPishkhan.View = View.Details;

            ListViewItem listViewItem;


            List<GhazaModel> lists = new List<GhazaModel>();



            lists = amaliat.selectGhaza("");

            for (int i = 0; i < lists.Count; i++) { 


            listViewItem = new ListViewItem(new String[] {  lists[i].id.ToString(),lists[i].naam.ToString(), lists[i].gheymat.ToString(), lists[i].vaziat.ToString() });


            this.listViewListGhazaPishkhan.Items.Add(listViewItem);
        }

        }

        public void pishSefareshLoad(long id)
        {

            this.listViewSefareshPishkhan.Items.Clear();


            this.listViewSefareshPishkhan.FullRowSelect = true;

            this.listViewSefareshPishkhan.View = View.Details;

            ListViewItem listViewItem,listViewItem1;

            List<GhazaModel> lists1 = new List<GhazaModel>();



            List<SefareshatModel> lists = new List<SefareshatModel>();


            lists = amaliat.selectSefareshat("where Mid="+id);


          

            for (int i = 0; i < lists.Count; i++)
            {


                lists1 = amaliat.selectGhaza("where id="+lists[i].Kghaza);

                ListViewItem item = listViewSefareshPishkhan.FindItemWithText(lists1[0].naam.ToString());

                if (item==null)
                {

                    listViewItem = new ListViewItem(new String[] { lists[i].Kghaza.ToString(), lists1[0].naam.ToString(), lists[i].tedad.ToString() });


                    this.listViewSefareshPishkhan.Items.Add(listViewItem);

                }
            }





        }


        public void PishMoshtarihaLoad()
        {
            this.listViewMoshtariPishkhan.Items.Clear();

            this.listViewMoshtariPishkhan.FullRowSelect = true;

            this.listViewMoshtariPishkhan.View = View.Details;

            ListViewItem listViewItem;


            List<MoshtarihaModel> lists = new List<MoshtarihaModel>();



            lists = amaliat.selectMoshtariha("");

            for (int i = 0; i < lists.Count; i++)
            {


                listViewItem = new ListViewItem(new String[] { lists[i].id.ToString(), lists[i].bedehkar.ToString() , lists[i].halateM.ToString() });


                this.listViewMoshtariPishkhan.Items.Add(listViewItem);
            }

        }



        public void AshMoshtarihaLoad()
        {

            this.listViewMoshtariAshpaz.Items.Clear();

            this.listViewMoshtariAshpaz.FullRowSelect = true;

            this.listViewMoshtariAshpaz.View = View.Details;

            ListViewItem listViewItem;


            List<MoshtarihaModel> lists = new List<MoshtarihaModel>();



            lists = amaliat.selectMoshtariha("");

            for (int i = 0; i < lists.Count; i++)
            {


                listViewItem = new ListViewItem(new String[] { lists[i].id.ToString() });


                this.listViewMoshtariAshpaz.Items.Add(listViewItem);
            }

        }


        public void AshGhazaLoad()
        {

            this.listViewGhazaAshpaz.Items.Clear();


            this.listViewGhazaAshpaz.FullRowSelect = true;

            this.listViewGhazaAshpaz.View = View.Details;

            ListViewItem listViewItem;


            List<GhazaModel> lists = new List<GhazaModel>();



            lists = amaliat.selectGhaza("");

            for (int i = 0; i < lists.Count; i++)
            {


                listViewItem = new ListViewItem(new String[] { lists[i].naam.ToString(), lists[i].vaziat.ToString() });


                this.listViewGhazaAshpaz.Items.Add(listViewItem);
            }

        }



        public void SandoghMoshtarihaLoad()
        {


            this.listViewMoshtariSandogh.Items.Clear();

            this.listViewMoshtariSandogh.FullRowSelect = true;

            this.listViewMoshtariSandogh.View = View.Details;

            ListViewItem listViewItem;


            List<MoshtarihaModel> lists = new List<MoshtarihaModel>();



            lists = amaliat.selectMoshtariha("");

            for (int i = 0; i < lists.Count; i++)
            {


                listViewItem = new ListViewItem(new String[] { lists[i].id.ToString(),lists[i].bedehkar.ToString() });


                this.listViewMoshtariSandogh.Items.Add(listViewItem);
            }

        }

        private void labelHazfGHazSefaresh_Click(object sender, EventArgs e)
        {

        }

        private void buttonHazfeMoshtari_Click(object sender, EventArgs e)
        {

            //hazf E moshtari e Entekhaab shode dar list




        }

        private void buttonTaeedSoratHesab_Click(object sender, EventArgs e)
        {
            //teyeed E sorat Hesaab


        }

        private void buttonEzafeGHbeSefaresh_Click(object sender, EventArgs e)
        {





            

            //Afzoodan be list E sefaresh E Moshatari

            int KodEGhaza, eshteraakEMoshtari;
            long ShomareS;


            //2 shart e if ke select shodan e satr ha dar jadavel ra chek mikonad
            if (this.listViewMoshtariPishkhan.SelectedItems.Count>0){
                if (this.listViewListGhazaPishkhan.SelectedItems.Count > 0)
                {


                    ListViewItem listViewItemMoshtari = this.listViewMoshtariPishkhan.SelectedItems[0];

                    eshteraakEMoshtari = int.Parse(listViewItemMoshtari.SubItems[0].Text);

                    ListViewItem listViewItemGhaza = this.listViewListGhazaPishkhan.SelectedItems[0];

                    KodEGhaza = int.Parse(listViewItemGhaza.SubItems[0].Text);

                    ShomareS = amaliat.selectMoshtariha("WHERE id = " + eshteraakEMoshtari)[0].shomareS;

                    if (amaliat.ayaSatr("Sefareshat","WHERE (Kghaza="+KodEGhaza+" and "+"Mid="+eshteraakEMoshtari+" and "+"shomareS="+ShomareS+" )"))
                    {
                        amaliat.stringBeroozEjadval("Sefareshat", "tedaad", "(tedaad+"+ this.numericUpDownTedad.Value + ")", "WHERE (Kghaza=" + KodEGhaza + " and " + "Mid=" + eshteraakEMoshtari + " and " + "shomareS=" + ShomareS + " )");

                    }
                    else
                    {

                        amaliat.vorrodEsotoonha("Sefareshat","id,Mid,Kghaza,tedaad,shomareS","0,"+eshteraakEMoshtari+","+KodEGhaza+","+this.numericUpDownTedad.Value+","+ShomareS);

                    }

                    pishSefareshLoad(eshteraakEMoshtari);











                }

            }else
            {

                MessageBox.Show("لطفا یک مشتری را انتخاب کنید");


            }


        }

        private void listViewListGhazaPishkhan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void listViewMoshtariPishkhan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.listViewMoshtariPishkhan.SelectedItems.Count == 0)
                return;
                pishSefareshLoad(int.Parse(this.listViewMoshtariPishkhan.SelectedItems[0].Text));


        }

        private void buttonHazfGHazSefaresh_Click(object sender, EventArgs e)
        {


            int Kghaza;
            long Mid, ShomareS;

            List<MoshtarihaModel> lists = new List<MoshtarihaModel>();


            if (listViewSefareshPishkhan.SelectedItems.Count == 0)
                return;


                Kghaza = int.Parse(this.listViewSefareshPishkhan.SelectedItems[0].Text);
        
            Mid = long.Parse(this.listViewMoshtariPishkhan.SelectedItems[0].Text);

            ShomareS = amaliat.selectMoshtariha("WHERE id = " + Mid)[0].shomareS;

            if (amaliat.selectSefareshat(" WHERE (Mid=" + Mid + " and shomareS=" + ShomareS + " and Kghaza=" + Kghaza + ")")[0].tedad == 0)
            {
                amaliat.HazfYekSatr("Sefareshat", " WHERE (Mid=" + Mid + " and shomareS=" + ShomareS + " and Kghaza=" + Kghaza + ")");

            }
            else
            {
                amaliat.stringBeroozEjadval("Sefareshat", "tedaad", "(tedaad-1)", " WHERE (Mid=" + Mid + " and shomareS=" + ShomareS + " and Kghaza=" + Kghaza + ")");

            }

            pishSefareshLoad(Mid);

        }

        private void listViewSefareshPishkhan_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}

