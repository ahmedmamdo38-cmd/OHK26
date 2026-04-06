using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HotelProject
{
    internal class Reseversetion
    {
        ConnectWithMySQL connect = new ConnectWithMySQL();
        public DataTable huonetyyppilista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM roomcategory", connect.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }


        public DataTable haeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("Select * From rooms", connect.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            connect.avaaYhteys();
            adapteri.Fill(taulu);
            connect.suljeYhteys();

            return taulu;
        }

        public bool muokkaVarausta(int roomNumber, int customerId, DateTime checkIn, DateTime checkOut, int varaus)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivitysksely = "UPDATE `resevertion` SET `RoomNro`= @rno" +
                "`CustomerId`= @cid" + "`ResevertionStart`= @ent" + "`ResevertionFinish`= @out" +
                "WHERE `ResevertionId`= @rid";

            komento.CommandText = paivitysksely;
            komento.Connection = connect.otaYhteys();

            komento.Parameters.Add("@rno", MySqlDbType.Int32).Value = roomNumber;
            komento.Parameters.Add("@cid", MySqlDbType.VarChar).Value = customerId;
            komento.Parameters.Add("@ent", MySqlDbType.Date).Value = checkIn;
            komento.Parameters.Add("@out", MySqlDbType.Date).Value = checkOut;

            connect.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                connect.suljeYhteys();
                return true;
            }
            else
            {
                connect.suljeYhteys();
                return false;
            }
        }


        public bool lisaaVaraus(int roomNumber, int customerId, DateTime enter, DateTime ulos)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaksely = "INSERT INTO `resevertion`" +
                "(RoomNro, CustomerId, ResevertionStart, ResevertionFinish)" +
                "VALUES (@rno, @cid, @ent, @out);";

            komento.CommandText = lisaksely;
            komento.Connection = connect.otaYhteys();

            komento.Parameters.Add("@rno", MySqlDbType.VarChar).Value = roomNumber;
            komento.Parameters.Add("@cid", MySqlDbType.VarChar).Value = customerId;
            komento.Parameters.Add("@ent", MySqlDbType.Date).Value = enter;
            komento.Parameters.Add("@out", MySqlDbType.Date).Value = ulos;
            connect.avaaYhteys();



            try
            {
                if (komento.ExecuteNonQuery() == 1)
                {
                    connect.suljeYhteys();
                    return true;
                }
                else
                {
                    connect.suljeYhteys();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error; " + ex);
                return true;
            }
        }


        public bool poistaVaraus(String reseversetionId)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM resevertion WHERE ResevertionId= @rid";
            komento.CommandText = poistokysely;
            komento.Connection = connect.otaYhteys();

            komento.Parameters.Add("@rid", MySqlDbType.Int32).Value = reseversetionId;

            connect.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                connect.suljeYhteys();
                return true;
            }
            else
            {
                connect.suljeYhteys();
                return false;
            }
        }

       
    }
}
