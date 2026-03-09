using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelliProjekti
{
    public partial class Paaikkuna : Form
    {


        public Paaikkuna()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hallitseAsiakkaitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Asiakkaiden_hallintaFM Costumers = new Asiakkaiden_hallintaFM();
            Costumers.Show();
            this.Hide();
        }

        private void Paaikkuna_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void hallitseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VaraustenHallintaFM Reservation = new VaraustenHallintaFM();
            Reservation.Show();
            this.Hide();
        }

        private void hallitseHuoneitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Huoneiden_Hallinta  Rooms = new Huoneiden_Hallinta();
            Rooms.Show();
            this.Hide();
        }
    }
}
