using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelliProjekti
{
    public partial class Asiakkaiden_hallintaFM : Form
    {
        Asiakas asiakas = new Asiakas();
        public Asiakkaiden_hallintaFM()
        {
            InitializeComponent();
        }

        private void AlaPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Asiakkaiden_hallintaFM_Load(object sender, EventArgs e)
        {
            AsiakaidenHallintaDG.DataSource = asiakas.haeAsiakkaat();
        }

        private void ALisääUusiAsiakasBT_Click(object sender, EventArgs e)
        {

        }
    }
}
