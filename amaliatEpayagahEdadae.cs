using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace restaurantMgr_pnuProj
{
    class amaliatEpayagahEdadae
    {
        MySqlConnection mySqlConnection;


        const String myConnection = "datasource=194.5.177.118;port=3306;database=pnuPrj;username=ahooee;password=lin^^xpnu&&Prj@c#in15;CharSet=utf8";

        public amaliatEpayagahEdadae()
        {

             mySqlConnection = new MySqlConnection(myConnection);

        }




        //yek method baraye neveshtan satr da jadvali az paygah e dade
        public bool vorrodEsatr(String jadval , String dadeha)
        {

            String dastoor = "INSERT INTO"+" "+jadval +" "+"VALUES("+dadeha+")" ;

            MySqlCommand command = mySqlConnection.CreateCommand();

            command.CommandText = dastoor;

            mySqlConnection.Open();

            Console.WriteLine(dastoor);

            command.ExecuteNonQuery();

            mySqlConnection.Close();


            return false;
        }


        public bool vorrodEsotoonha(String jadval,String satrha ,String dadeha)
        {

            String dastoor = "INSERT INTO" + " " + jadval + "( "+ satrha + ") VALUES(" + dadeha + ")";

            MySqlCommand command = mySqlConnection.CreateCommand();

            command.CommandText = dastoor;

            mySqlConnection.Open();

            Console.WriteLine(dastoor);

            command.ExecuteNonQuery();

            mySqlConnection.Close();


            return false;
        }


        //berooz avari jadval baraye dadeye reshte'ee
        public bool stringBeroozEjadval(String jadval , String sotoon , String dadeyeJadid , String shart )
        {
            String dastoor = "UPDATE"+" "+jadval+" "+"SET"+" "+sotoon+"="+dadeyeJadid+" "+shart;


            MySqlCommand command = mySqlConnection.CreateCommand();

            command.CommandText = dastoor;

            mySqlConnection.Open();

            command.ExecuteNonQuery();

            mySqlConnection.Close();




            return false;
        }

        //berooz avari jadval baraye dadeye adadi e int
        public bool intBeroozEjadval(String jadval, String sotoon, int dadeyeJadid, String shart)
        {
            shart = "WHERE" + " " + shart;
            String dastoor = "UPDATE" + " " + jadval + " " + "SET" + " " + sotoon + "=" + "'" + dadeyeJadid + "'" + " " + shart;


            MySqlCommand command = mySqlConnection.CreateCommand();

            command.CommandText = dastoor;

            mySqlConnection.Open();

            command.ExecuteNonQuery();

            mySqlConnection.Close();




            return false;
        }



        //berooz avari jadval baraye dadeye adadi e bigint
        public bool bigintBeroozEjadval(String jadval, String sotoon, long dadeyeJadid, String shart)
        {
            shart = "WHERE" + " " + shart;
            String dastoor = "UPDATE" + " " + jadval + " " + "SET" + " " + sotoon + "=" + "'" + dadeyeJadid + "'" + " " + shart;


            MySqlCommand command = mySqlConnection.CreateCommand();

            command.CommandText = dastoor;

            mySqlConnection.Open();

            command.ExecuteNonQuery();

            mySqlConnection.Close();




            return false;
        }


        //berooz avari jadval baraye dadeye adadi e float
        public bool floatBeroozEjadval(String jadval, String sotoon, float dadeyeJadid, String shart)
        {
            shart = "WHERE" + " " + shart;
            String dastoor = "UPDATE" + " " + jadval + " " + "SET" + " " + sotoon + "=" + "'" + dadeyeJadid + "'" + " " + shart;


            MySqlCommand command = mySqlConnection.CreateCommand();

            command.CommandText = dastoor;

            mySqlConnection.Open();

            command.ExecuteNonQuery();

            mySqlConnection.Close();




            return false;
        }

        public List<GhazaModel> selectGhaza(String shart)
        {

            List<GhazaModel> lists =new List<GhazaModel>();


            String dastoor = "SELECT * from Ghazaha "+shart;

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = dastoor;

            mySqlConnection.Open();


            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            String sotoonMeghdar="";

            while (mySqlDataReader.Read())
            {

                GhazaModel ghazaModel = new GhazaModel();

                ghazaModel.id = (int)(mySqlDataReader["id"] == DBNull.Value ? 0 : mySqlDataReader["id"]);
                ghazaModel.naam= (String)(mySqlDataReader["naam"] == DBNull.Value ? String.Empty : mySqlDataReader["naam"]);
                ghazaModel.gheymat =(float)( mySqlDataReader["gheymat"] == DBNull.Value ? 0 : mySqlDataReader["gheymat"]);
                ghazaModel.vaziat = (int)(mySqlDataReader["vaziat"] == DBNull.Value ? 0 : mySqlDataReader["vaziat"]);

                lists.Add(ghazaModel);

            }


            mySqlConnection.Close();


            return  lists;
        }


        public List<MoshtarihaModel> selectMoshtariha(String shart)
        {

            List<MoshtarihaModel> lists = new List<MoshtarihaModel>();



            String dastoor = "SELECT * from Moshtariha "+shart;

            Console.WriteLine(dastoor);

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = dastoor;

            mySqlConnection.Open();


            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            String sotoonMeghdar = "";

            while (mySqlDataReader.Read())
            {

                MoshtarihaModel moshtarihaModal = new MoshtarihaModel();

                moshtarihaModal.id = (long)(mySqlDataReader["id"] == DBNull.Value ? 0 : mySqlDataReader["id"]);
                moshtarihaModal.naam = (String)(mySqlDataReader["naam"] == DBNull.Value ? String.Empty : mySqlDataReader["naam"]);
                moshtarihaModal.naamKH = (String)(mySqlDataReader["naamKH"] == DBNull.Value ? String.Empty : mySqlDataReader["naamKH"]);
                moshtarihaModal.tel = (String)(mySqlDataReader["tel"]==DBNull.Value?String.Empty: mySqlDataReader["tel"]);
                moshtarihaModal.Mob = (String)(mySqlDataReader["Mob"] == DBNull.Value ? String.Empty : mySqlDataReader["Mob"]);
                moshtarihaModal.address = (String)(mySqlDataReader["address"] == DBNull.Value ? String.Empty : mySqlDataReader["address"]);
                moshtarihaModal.halateM = (int)(mySqlDataReader["halateM"] == DBNull.Value ? 0 : mySqlDataReader["halateM"]);
                moshtarihaModal.bedehkar = (float)(mySqlDataReader["bedehkar"] == DBNull.Value ? 0 : mySqlDataReader["bedehkar"]);
                moshtarihaModal.shomareS = (long)(mySqlDataReader["shomareS"] == DBNull.Value ? 0 : mySqlDataReader["shomareS"]);


                lists.Add(moshtarihaModal);

            }


            mySqlConnection.Close();


            return lists;
        }



        public List<SefareshatModel> selectSefareshat(String shart)
        {

            List<SefareshatModel> lists = new List<SefareshatModel>();


            String dastoor = "SELECT * from Sefareshat "+shart;

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = dastoor;

            mySqlConnection.Open();


            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            String sotoonMeghdar = "";

            while (mySqlDataReader.Read())
            {

                SefareshatModel sefareshatModel = new SefareshatModel();

                sefareshatModel.id = (long)(mySqlDataReader["id"] == DBNull.Value ? 0 : mySqlDataReader["id"]);
                sefareshatModel.Mid = (long)(mySqlDataReader["Mid"] == DBNull.Value ? 0 : mySqlDataReader["Mid"]);
                sefareshatModel.Kghaza = (int)(mySqlDataReader["Kghaza"] == DBNull.Value ? 0 : mySqlDataReader["Kghaza"]);
                sefareshatModel.tedad = (int)(mySqlDataReader["tedaad"] == DBNull.Value ? 0 : mySqlDataReader["tedaad"]);
                sefareshatModel.tarikh = (DateTime)(mySqlDataReader["tarikh"] == DBNull.Value ? 0 : mySqlDataReader["tarikh"]);
                sefareshatModel.shomareS = (long)(mySqlDataReader["shomareS"] == DBNull.Value ? 0 : mySqlDataReader["shomareS"]);



                lists.Add(sefareshatModel);

            }


            mySqlConnection.Close();


            return lists;
        }





        public List<SandoghdarhaModael> selectSandoghdaha(String shart)
        {

            List<SandoghdarhaModael> lists = new List<SandoghdarhaModael>();


            String dastoor = "SELECT * from Sandoghdarha "+shart;

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = dastoor;

            mySqlConnection.Open();


            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            String sotoonMeghdar = "";

            while (mySqlDataReader.Read())
            {

                SandoghdarhaModael sandoghdarhaModel = new SandoghdarhaModael();

                sandoghdarhaModel.id = (int)(mySqlDataReader["id"] == DBNull.Value ? 0 : mySqlDataReader["id"]);
                sandoghdarhaModel.uid = (String)(mySqlDataReader["uid"] == DBNull.Value ? String.Empty : mySqlDataReader["uid"]);
                sandoghdarhaModel.Mid = (long)(mySqlDataReader["Mid"] == DBNull.Value ? 0 : mySqlDataReader["Mid"]);
                sandoghdarhaModel.bedehkar = (float)(mySqlDataReader["bedehkar"] == DBNull.Value ? 0 : mySqlDataReader["bedehkar"]);
                sandoghdarhaModel.tarikh = (DateTime)(mySqlDataReader["tarikh"] == DBNull.Value ? 0 : mySqlDataReader["tarikh"]);




                lists.Add(sandoghdarhaModel);

            }


            mySqlConnection.Close();


            return lists;
        }


        public bool HazfYekSatr(String jadval , String shart )
        {

            String dastoor = "DELETE FROM "+jadval+" "+shart;


            MySqlCommand command = mySqlConnection.CreateCommand();

            command.CommandText = dastoor;

            mySqlConnection.Open();

            Console.WriteLine(dastoor);

            command.ExecuteNonQuery();

            mySqlConnection.Close();

            return false;
        }








        public bool ayaSatr(String jadval , String shart)
        {

            String dastoor = "SELECT * FROM "+jadval+" "+shart;

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = dastoor;

            mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            if (mySqlDataReader.HasRows)
            {

                mySqlConnection.Close();

                return true;



            }
            else
            {

                mySqlConnection.Close();


                return false;


            }


           


        }

        public int loginVaziat(String uname)
        {
            int vaziat = 0;

            String dastoor = "SELECT * FROM login WHERE uname='"+uname+"'";

            MySqlCommand mySqlCommand = mySqlConnection.CreateCommand();

            mySqlCommand.CommandText = dastoor;

            mySqlConnection.Open();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();


            while (mySqlDataReader.Read())
            {

                vaziat = (int)(mySqlDataReader["Ndastresi"] == DBNull.Value ? 0 : mySqlDataReader["Ndastresi"]);



            }



            mySqlConnection.Close();


            return vaziat;
        }







    }
}
