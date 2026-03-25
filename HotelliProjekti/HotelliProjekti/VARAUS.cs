using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelliProjekti
{
    internal class VARAUS
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

        public DataTable haeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("Select * From huoneet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu; 
        }
        
        public bool lisaaVaraus(int hnro, int anro, DateTime sisaan, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaksely = "INSERT INTO `varaukset`" +
                "(HuoneenNro, AsiakasId, Sisaan, Ulos)" +
                "VALUES (@hno, @ano, @sis, @ulo);";

            komento.CommandText = lisaksely;
            komento.Connection = yhteys.otaYhteys();

            komento.Parameters.Add("@hno", MySqlDbType.VarChar).Value = hnro;
            komento.Parameters.Add("@ano", MySqlDbType.VarChar).Value = anro;
            komento.Parameters.Add("@sis", MySqlDbType.Date).Value = sisaan;
            komento.Parameters.Add("@ulo", MySqlDbType.Date).Value = ulos;
            yhteys.avaaYhteys();



            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Virhe; " + ex);
                return true;
            }
        }
    }
}
