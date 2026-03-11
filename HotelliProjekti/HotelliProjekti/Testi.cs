using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace HotelliProjekti
{
    public partial class Testi : Form
    {

        Paaikkuna MainPage = new Paaikkuna();
        
        public Testi()
        {
            InitializeComponent();
        }

        private void KirjauduSisään1BT_Click(object sender, EventArgs e)
        {

            Yhdista tietokantaan = new Yhdista();
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();

            String kysely = "SELECT Ktunnus, Salasana FROM asiakkaat WHERE Ktunnus = @kn AND Salasana = @ss";
            komento.CommandText = kysely;
            komento.Connection = tietokantaan.otaYhteys();

            komento.Parameters.Add("@kn", MySqlDbType.VarChar).Value = Kaytaja1NTB.Text;
            komento.Parameters.Add("@ss", MySqlDbType.VarChar).Value = Salasana1TB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            
            
            if(taulu.Rows.Count > 0)
            {
                this.Hide();
                Paaikkuna pikkuna = new Paaikkuna();
                pikkuna.Show();
            }
            else
            {
                if(Kaytaja1NTB.Text == "")
                {
                    VirheViesti0LB.Visible = true;
                    VirheViesti1LB.Visible = true;
                }
                else if(Salasana1TB.Text == "")
                {
                    VirheViesti0LB.Visible = true;
                    VirheViesti1LB.Visible = true;
                }
                else
                {
                    MessageBox.Show("Käyttäjänimi tai salasana ei löydy", "Tietoja ei löydy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            if (Kaytaja1NTB.Text == "Ahmed Mamdo" && Salasana1TB.Text == "150806")
            {
                VirheViesti0LB.Visible = false;
                VirheViesti1LB.Visible = false;
                MainPage.Show();
                this.Hide();
                
            }
            else if (Kaytaja1NTB.Text == "Jyri Lindroos" && Salasana1TB.Text == "Keudan Opettäjä")
            {
                VirheViesti0LB.Visible = false;
                VirheViesti1LB.Visible = false;
                MainPage.Show();
                this.Hide();
                

            }
            else
            {
                VirheViesti0LB.Visible = true;
                VirheViesti1LB.Visible = true;
                //MainPage.Show();
                
            }
        }
    }
}
