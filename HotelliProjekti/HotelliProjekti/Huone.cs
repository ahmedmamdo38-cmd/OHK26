using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace HotelliProjekti
{
    internal class Huone
    {
        Yhdista yhteys = new Yhdista();

        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM huonekategoria", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool lisaaHuone(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisakysely = "INSERT INTO huoneet " +
                "(HuoneenNro, Huonetyyppi, Puhelin, Vapaa) " +
                "VALUES (@hno, @hty, @puh, @vap)";

            komento.CommandText = lisakysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.Int32).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vap", MySqlDbType.VarChar).Value = vapaa;

            yhteys.avaaYhteys();



            try
            {
                if(komento.ExecuteNonQuery() == 1)
                {
                    yhteys.suljeYhteys();
                    return true;
                }
                else
                {
                    yhteys.suljeYhteys();
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Virhe; " + ex);
                return true;
            }
        }


        public DataTable haeHuoneet()
        {
            MySqlCommand komento = new MySqlCommand("Select * From huoneet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            //try
            //{
            //    yhteys.avaaYhteys();
            //    adapteri.Fill(taulu);
            //}
            //finally
            //{
            //    yhteys.suljeYhteys();
            //}

            return taulu;
        }


        public bool muokkaHuonet(int hnro, int htyyppi, String puh, String vapaa)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `huoneet` SET `Huonetyyppi`= @hty," +
                "`Puhelin`= @puh, `Vapaa`= @vap " +
                "WHERE HuoneenNro = @hno";

            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();


            komento.Parameters.Add("@hno", MySqlDbType.VarChar).Value = hnro;
            komento.Parameters.Add("@hty", MySqlDbType.VarChar).Value = htyyppi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@vapaa", MySqlDbType.VarChar).Value = vapaa;


            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }


        public bool poistaHuone(String hnro)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM huoneet WHERE HuoneenNro = @hno";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("hno", MySqlDbType.VarChar).Value = hnro;

            yhteys.avaaYhteys();

            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public DataTable tyypillisetHuoneet(int htype)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisakysely = "SELECT * from huoneet WHERE Huonetyyppi = @hty";
            komento.CommandText = lisakysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hty", MySqlDbType.Int32).Value = htype;
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;

        }
    }
}
