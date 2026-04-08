using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace HotelProject
{
    internal class Customers
    {
        ConnectWithMySQL connect = new ConnectWithMySQL();


        public DataTable asiakasLista()
        {
            MySqlCommand komento = new MySqlCommand("SELECT CustomerId, Concat(FirstName, ' ', Surname) AS kokonimi FROM customers", connect.otaYhteys() );
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        
        }

        public bool lisaaAsiakas(String firstname, String surname, String address, String postalcode, String postoffice, String username, String password)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisakysely = "INSERT INTO customers" +
                "(Firstname, Surname, Address, PostOffice, PostalCode, Username, Password)" +
                "VALUES (@fir, @sur, @add, @pof, @pcd, @usr, @pwd)";


            komento.CommandText = lisakysely;
            komento.Connection = connect.otaYhteys();

            komento.Parameters.Add("@fir", MySqlDbType.VarChar).Value = firstname;
            komento.Parameters.Add("@sur", MySqlDbType.VarChar).Value = surname;
            komento.Parameters.Add("@add", MySqlDbType.VarChar).Value = address;
            komento.Parameters.Add("@pof", MySqlDbType.VarChar).Value = postoffice;
            komento.Parameters.Add("@pcd", MySqlDbType.VarChar).Value = postalcode;
            komento.Parameters.Add("@usr", MySqlDbType.VarChar).Value = username;
            komento.Parameters.Add("pwd", MySqlDbType.VarChar).Value = password;



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


        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT Firstname, Surname, Address, Postoffice, PostalCode, Username, Password, CustomerId FROM customers", connect.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            connect.avaaYhteys();
            adapteri.Fill(taulu);
            connect.suljeYhteys();

            return taulu;
        }

        public bool muokkaAsiakkaat(int CustomerID, String firstname, String surname, String address, String postoffice, String postalcode, String username, String password)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivityskysely = "UPDATE `customers` SET `Firstname`= @fir, " +
                "`Surname`= @sur," + " `Address`= @add," + " `PostOffice`= @pof," +
                " `PostalCode`= @pcd," + " `Username`= @usr," + " `Password`= @pwd " +
                "WHERE CustomerId = @cui";

            komento.CommandText = paivityskysely;
            komento.Connection = connect.otaYhteys();

            komento.Parameters.Add("@fir", MySqlDbType.VarChar).Value = firstname;
            komento.Parameters.Add("@sur", MySqlDbType.VarChar).Value = surname;
            komento.Parameters.Add("@add", MySqlDbType.VarChar).Value = address;
            komento.Parameters.Add("@pof", MySqlDbType.VarChar).Value = postoffice;
            komento.Parameters.Add("@pcd", MySqlDbType.VarChar).Value = postalcode;
            komento.Parameters.Add("@usr", MySqlDbType.VarChar).Value = username;
            komento.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = password;
            komento.Parameters.Add("@cui", MySqlDbType.Int32).Value = CustomerID;


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

        public String luoSalasana()
        {
            char[] alpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXTZ!@#€?0123456789".ToArray();
            Random satunnaisluku = new Random();
            String salasana = "";
            for (int i = 0; i < 12; i++)
            {
                int indeksi = satunnaisluku.Next(alpha.Length);
                salasana += alpha[indeksi];
            }
            return salasana;
        }

        public bool poistaAsiakas(String customerid)
        {
            MySqlCommand komento = new MySqlCommand();
            String poistokysely = "DELETE FROM customers WHERE CustomerId = @cui";
            komento.CommandText = poistokysely;
            komento.Connection = connect.otaYhteys();

            komento.Parameters.Add("@cui", MySqlDbType.Int32).Value = customerid;

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
