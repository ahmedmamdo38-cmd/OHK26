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
            String enimi = AEtunimiTB.Text;
            String snimi = ASukunimiTB.Text;
            String osoite = ALahiosoiteTB.Text;
            String pnro = APostinumeroTB.Text;
            String ppaikka = APostitoimipaikkaTB.Text;
            String kayttaja = AkäyttäjätunnusTb.Text;
            String ssana = ASalasanaTB.Text;

            if (enimi.Equals("") || snimi.Equals("") || osoite.Equals("") || pnro.Equals("") || ppaikka.Equals("") || kayttaja.Equals("") || ssana.Equals(""))
            {
                MessageBox.Show("VIRHE- Vaaditut kentät - Etunimi ja sukuinimi, lahiosoite, postinumero ja postitoimipaikka", "Tyhjä kentät", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Boolean lisaaAsiakas = asiakas.lisaaAsiakas(enimi, snimi, osoite, pnro, ppaikka, kayttaja, ssana);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty onnituneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Uutta asiakas ei pysty lisämään", "Asiakas lisäys", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ATyhjennaKentatBT_Click(object sender, EventArgs e)
        {
            AEtunimiTB.Text = "";
            ASukunimiTB.Text = "";
            ALahiosoiteTB.Text = "";
            APostinumeroTB.Text = "";
            APostitoimipaikkaTB.Text = "";
            ASalasanaTB.Text = "";
            AkäyttäjätunnusTb.Text = "";
        }

        private void AsiakaidenHallintaDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AEtunimiTB.Text = AsiakaidenHallintaDG.CurrentRow.Cells[0].Value.ToString();
            ASukunimiTB.Text = AsiakaidenHallintaDG.CurrentRow.Cells[1].Value.ToString();
            ALahiosoiteTB.Text = AsiakaidenHallintaDG.CurrentRow.Cells[2].Value.ToString();
            APostinumeroTB.Text = AsiakaidenHallintaDG.CurrentRow.Cells[3].Value.ToString();
            APostitoimipaikkaTB.Text = AsiakaidenHallintaDG.CurrentRow.Cells[4].Value.ToString();
            AKäyttäjätunnusLB.Text = AsiakaidenHallintaDG.CurrentRow.Cells[5].Value.ToString();
            ASalasanaTB.Text = AsiakaidenHallintaDG.CurrentRow.Cells[6].Value.ToString();
        }

        private void APoistaBT_Click(object sender, EventArgs e)
        {
            String ktunnus = AKäyttäjätunnusLB.Text;

            if (asiakas.poistaAsiakas(ktunnus))
            {
                AsiakaidenHallintaDG.DataSource = asiakas.haeAsiakkaat();
                MessageBox.Show("Asiakas poistettu onnistuneesti ", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Asiakas ei pystytty poistamaan", "Asiakas poisto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            ATyhjennaKentatBT.PerformClick();
        }

        private void AMuokkaBt_Click(object sender, EventArgs e)
        {
            String enimi =  AEtunimiTB.Text;
            String snimi =  ASukunimiTB.Text;
            String osoite = ALahiosoiteTB.Text;
            String pnro =   APostinumeroTB.Text;
            String ppaikka = APostitoimipaikkaTB.Text;
            String kayttaja = AkäyttäjätunnusTb.Text;
            String ssana = ASalasanaTB.Text;


            if (kayttaja.Equals("") || enimi.Equals("") || snimi.Equals("") || osoite.Equals("") || pnro.Equals("") || ppaikka.Equals("") || ssana.Equals(""))
            {
                MessageBox.Show("VIRHE!!! Vadittut kentät - Etunimi, sukunimi, lähiosoite, postinumero, postitoimipaikka, käyttäjätunnus ja salassana", "Tyhjä kentät", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Boolean lisaaAsiakas = asiakas.muokkaAsiakkaat(kayttaja, enimi, snimi, osoite, pnro, ppaikka, ssana);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Asiakas päivitetty onnistuuneesti ", "Asiakas päivitys", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Asiakas ei pystytty päivittäämään", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                AsiakaidenHallintaDG.DataSource = asiakas.haeAsiakkaat();
            }
        }
    }
}
