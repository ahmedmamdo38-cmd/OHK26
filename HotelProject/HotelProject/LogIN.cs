using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class LogIN : Form
    {
        HomePage MainPage = new HomePage();
        public LogIN()
        {
            InitializeComponent();
        }

        private void LogInBT_Click(object sender, EventArgs e)
        {
            ConnectWithMySQL tietokantaan = new ConnectWithMySQL();
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();


            String kysely = "SELECT Username, Password FROM customers WHERE Username = @us AND Password = @pp";
            komento.CommandText = kysely;
            komento.Connection = tietokantaan.otaYhteys();

            komento.Parameters.Add("@us", MySqlDbType.VarChar).Value = UserNameTB.Text;
            komento.Parameters.Add("@pp", MySqlDbType.VarChar).Value = PasswordTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);


            if(taulu.Rows.Count > 0)
            {
                this.Hide();
                HomePage mainpage = new HomePage();
                mainpage.Show();
            }
            else
            {
                if(UserNameTB.Text == "")
                {
                    ErrorMessage0LB.Visible = true;
                    ErrorMessage1LB.Visible = true;
                }
                else if(PasswordTB.Text == "")
                {
                    ErrorMessage0LB.Visible = true;
                    ErrorMessage1LB.Visible = true;
                }
                else
                {
                    MessageBox.Show("Username or Password not found", "Data not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
