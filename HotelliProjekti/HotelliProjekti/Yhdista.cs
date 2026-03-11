using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using MySql.Data.MySqlClient;

namespace HotelliProjekti
{
     class Yhdista
    {
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=hotelli");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        public void avaaYhteys()
        {
            if(yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }


        public void suljeYhteys()
        {
            if(yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
