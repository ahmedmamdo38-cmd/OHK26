namespace Task20
{
    public partial class Form1 : Form
    {
        OPISKELIJA opiskelija = new OPISKELIJA();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }

        private void TyhennaTB_Click(object sender, EventArgs e)
        {
            IdTB.Text = "";
            EnimiTB.Text = "";
            SnimiTB.Text = "";
            PuhTB.Text = "";
            EmailTB.Text = "";
            ONroTB.Text = "";
        }

        private void TallennaTB_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puhelin = PuhTB.Text;
            String email = EmailTB.Text;
            int oNro = Int32.Parse(ONroTB.Text);

            if (enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaaditut kentät - Etu- ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.lisaaOpiskelija(enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi opisklija lisätty onnistuneesti", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Uutta opiskelijaa ei pystytty lisämään", "Opiskelijan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
        }


        private void paivitaBT_Click(object sender, EventArgs e)
        {
           
        }

        private void TietotauluDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void poistaBT_Click(object sender, EventArgs e)
        {

        }

        private void TietotauluDG_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            IdTB.Text = TietotauluDG.CurrentRow.Cells[0].Value.ToString();
            EnimiTB.Text = TietotauluDG.CurrentRow.Cells[1].Value.ToString();
            SnimiTB.Text = TietotauluDG.CurrentRow.Cells[2].Value.ToString();
            PuhTB.Text = TietotauluDG.CurrentRow.Cells[3].Value.ToString();
            EmailTB.Text = TietotauluDG.CurrentRow.Cells[4].Value.ToString();
            ONroTB.Text = TietotauluDG.CurrentRow.Cells[5].Value.ToString();
        }

        private void PoistaBT_Click_1(object sender, EventArgs e)
        {
            String ktunnus = IdTB.Text;
            if (opiskelija.poistaOpiskelija(ktunnus))
            {
                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
                MessageBox.Show("Opiskelija poistettu onnistuneesti ", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Opiskelija ei pystytty poistamaan", "Opiskelijan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TyhennaTB.PerformClick();
        }

        private void PaivitaTB_Click(object sender, EventArgs e)
        {
            String enimi = EnimiTB.Text;
            String snimi = SnimiTB.Text;
            String puhelin = PuhTB.Text;
            String email = EmailTB.Text;
            int oNro = Int32.Parse(ONroTB.Text);
            int oid = Int32.Parse(IdTB.Text);

            if (oid.Equals("") || enimi.Trim().Equals("") || snimi.Trim().Equals("") || puhelin.Trim().Equals("") || email.Trim().Equals("") || oNro.Equals(""))
            {
                MessageBox.Show("VIRHE - Vaadittut kentät - Etu - ja sukunimi, puhelin, sähköposti ja opiskelijanumero", "Tyhjä kenttä", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Boolean lisaaAsiakas = opiskelija.muokkaaOpiskelijaa(oid, enimi, snimi, puhelin, email, oNro);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Opiskelija päivitetty onnistuneesti ", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Opiskelijaa ei pystytty päivittäämään ", "Opiskelijan päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                TietotauluDG.DataSource = opiskelija.haeOpiskelijat();
            }
        }
    }
}
