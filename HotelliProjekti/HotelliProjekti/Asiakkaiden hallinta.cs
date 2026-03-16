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
            int ssana = Int32.Parse(ASalasanaTB.Text);

            if (enimi.Equals("") || snimi.Equals("") || osoite.Equals("") ||  pnro.Equals("") || ppaikka.Equals("") || kayttaja.Equals("") || ssana.Equals("") )
            {
                MessageBox.Show("VIRHE- Vaaditut kentät - Etunimi ja sukuinimi, lahiosoite, postinumero ja postitoimipaikka", "Tyhjä kentät", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Uutta asiakas ei pysty lisämään", "Asiakas lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
