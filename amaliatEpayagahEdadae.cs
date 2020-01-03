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


        //berooz avari jadval baraye dadeye reshte'ee
        public bool stringBeroozEjadval(String jadval , String sotoon , String dadeyeJadid , String shart )
        {
            shart = "WHERE"+" "+shart;
            String dastoor = "UPDATE"+" "+jadval+" "+"SET"+" "+sotoon+"="+"'"+dadeyeJadid+"'"+" "+shart;


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





    }
}
