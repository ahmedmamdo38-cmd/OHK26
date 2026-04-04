using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    internal class Rooms
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

        public bool lisaaHuoneet(int roomId, int roomtype, String phone, String free)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisakysely = "INSERT INTO rooms" +
                "(RoomId, RoomType, Phone, Free)" + 
                "VALUES (@rid, @rty, @ph, @fre)";

            komento.CommandText = lisakysely;
            komento.Connection = connect.otaYhteys();

            komento.Parameters.Add("@rid", MySqlDbType.Int32).Value = roomId;
            komento.Parameters.Add("@rty", MySqlDbType.Int32).Value = roomtype;
            komento.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            komento.Parameters.Add("@fre", MySqlDbType.VarChar).Value = free;

            connect.avaaYhteys();

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

        public DataTable haeHuoneet()
        {
            MySqlCommand komento = new MySqlCommand();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool muokkaHuonetta(int roomId, int roomtype, String phone, String free)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `rooms` SET `RoomType`= @rty" +
                "`Phone`= @pho, `Free`= @fre" +
                "WHERE `RoomId`= @rid";

            komento.CommandText = paivityskysely;
            komento.Connection = connect.otaYhteys();

            komento.Parameters.Add("@rid", MySqlDbType.Int32).Value = roomId;
            komento.Parameters.Add("@rty", MySqlDbType.Int32).Value = roomtype;
            komento.Parameters.Add("@pho", MySqlDbType.VarChar).Value = phone;
            komento.Parameters.Add("@fre", MySqlDbType.VarChar).Value = free;

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

        public bool poistaHuone(String roomId)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM rooms WHERE RoomId = @rid";
            komento.CommandText = poistokysely;
            komento.Connection = connect.otaYhteys();

            komento.Parameters.Add("@rid", MySqlDbType.Int32).Value = roomId;

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

        public DataTable tyypillisetHuoneet(int roomtype)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisakysely = "SELECT * from rooms WHERE RoomType = @rty";
            komento.CommandText = lisakysely;
            komento.Connection = connect.otaYhteys();

            komento.Parameters.Add("@rty", MySqlDbType.Int32).Value = roomtype;
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }
    }
}
