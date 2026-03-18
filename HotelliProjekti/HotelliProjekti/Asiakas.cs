using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Eramake;
namespace HotelliProjekti
{
    internal class Asiakas
    {
        Yhdista yhteys = new Yhdista();


        public bool lisaaAsiakas(String enimi, String snimi, String osoite, String pnro, String ppaikka, String kayttaja, String ssana)
        {   
            MySqlCommand komento = new MySqlCommand();
            String lisakysely = "INSERT INTO asiakkaat " +
                "(Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, Salasana)" +
                "VALUES (@enm, @snm, @oso, @pno, @ptp, @ssa) ";

            komento.CommandText = lisakysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;
            
            if(kayttaja != "")
            {
                komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = kayttaja.ToLower();
            }
            else
            {
                komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi.Substring(0, 3).ToLower() + snimi.Substring(0, 5).ToLower();
            }
            if(ssana != null)
            {
                komento.Parameters.Add("@ssa", MySqlDbType.Int32).Value = eCryptography.Encrypt(ssana);
            }
            else
            {
                komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = eCryptography.Encrypt(luoSalasana());
                MessageBox.Show(luoSalasana());
            }



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

        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Ktunnus, Etunimi, Sukunimi, Lahiosoite, Postinumero, Postitoimipaikka, Salasana FROM asiakkaat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool muokkaAsiakkaat(String enimi, String snimi, String osoite, String pnro, String ppaikka, String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `asiakkaat` SET `Etunimi`= @enm," +
                "`Sukunimi`= @snm, `Lahiosoite`= @oso, `Postinumero`= @pno, `Postitoimipaikka`= @ptp" +
                "WHERE Ktunnus = @ktu";

            komento.CommandText = paivityskysely;
            komento.Connection = yhteys.otaYhteys();


            komento.Parameters.Add("@enm", MySqlDbType.VarChar).Value = enimi;
            komento.Parameters.Add("@snm", MySqlDbType.VarChar).Value = snimi;
            komento.Parameters.Add("@oso", MySqlDbType.VarChar).Value = osoite;
            komento.Parameters.Add("@pno", MySqlDbType.VarChar).Value = pnro;
            komento.Parameters.Add("@ptp", MySqlDbType.VarChar).Value = ppaikka;


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


        public String luoSalasana()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXTZ!@#€?0123456789".ToArray();
            Random satunnaisluku = new Random();
            String salasana = "";
            for(int i = 0; i < 12; i++)
            {
                int indeksi = satunnaisluku.Next(alpha.Length);
                salasana += alpha[indeksi];
            }
            return salasana;
        }

        public bool poistaAsiakas(String ktunnus)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM asiakkaat WHERE Ktunnus = @ktu";
            komento.CommandText = poistokysely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@ktu", MySqlDbType.VarChar).Value = ktunnus;

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
