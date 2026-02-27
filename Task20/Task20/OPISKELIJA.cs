using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;
using System.Text;


namespace Task20
{
    internal class OPISKELIJA
    {
        Yhdistaa yhteys = new Yhdistaa();


        public bool lisaaOpiskelija(string enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisayskysely = "INSERT INTO yhteystiedot " +
                "(etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero) " +
                "VALUES (@enm, @snm, @puh, @eml, @ono); ";
            komento.CommandText = lisayskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;

            yhteys.avaaYhteys();
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

        public DataTable haeOpiskelijat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT oid, etunimi, sukunimi, puhelin, sahkoposti, opiskelijanumero FROM yhteystiedot", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }


        public bool muokkaaOpiskelijaa(int oid, String enimi, String snimi, String puh, String email, int onro)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `yhteystiedot` SET `Etunimi`= @enm," +
                "`Sukunimi`= @snm, `puhelin`= @puh, `sahkoposti`= @eml, `opiskelijanumero`= @ono " +
                "WHERE oid = @oid";

            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puh;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ono", MySqlDbType.UInt32).Value = onro;
            komento.Parameters.Add("@oid", MySqlDbType.UInt32).Value = oid;

            yhteys.avaaYhteys();
            if(komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public bool poistaOpiskelija(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM yhteystiedot WHERE oid = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@ktu", MySqlDbType.UInt32).Value = ktunnus;

            yhteys.avaaYhteys();
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


    }
}
