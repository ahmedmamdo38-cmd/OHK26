namespace HotelliProjekti
{
    public partial class Huoneiden_Hallinta : Form
    {
        public Huoneiden_Hallinta()
        {
            InitializeComponent();
        }

        Huone huone = new Huone();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Huoneiden_Hallinta_Load(object sender, EventArgs e)
        {
            HHuonetyyppiCB.DataSource = huone.huonetyyppilista();
            HHuonetyyppiCB.DisplayMember = "Huonetyyppi";
            HHuonetyyppiCB.ValueMember = "KategoriaId";

            HuoneidenHallintaDG.DataSource = huone.haeHuoneet();
        }

        private void HHuoneNroTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void HLisääUusiHuoneBT_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(HHuoneNroTB.Text);
            int tyyppi = Convert.ToInt32(HHuonetyyppiCB.SelectedValue.ToString());
            String puhelin = HPuhelinTB.Text;

            if (huone.lisaaHuone(numero, tyyppi, puhelin, "Kyllä"))
            {
                MessageBox.Show("Huone lisätty onnituneesti", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huonetta ei pystytty lisäämään", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            HuoneidenHallintaDG.DataSource = huone.haeHuoneet();
        }

        private void HTyhjennaKentatBT_Click(object sender, EventArgs e)
        {
            HHuoneNroTB.Text = "";
            HHuonetyyppiCB.SelectedIndex = 0;
            HPuhelinTB.Text = "";
        }

        private void HHuonetyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HuoneidenHallintaDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HHuoneNroTB.Text = HuoneidenHallintaDG.CurrentRow.Cells[0].Value.ToString();
            HHuonetyyppiCB.SelectedValue = HuoneidenHallintaDG.CurrentRow.Cells[1].Value.ToString();
            HPuhelinTB.Text = HuoneidenHallintaDG.CurrentRow.Cells[2].Value.ToString();

        }

        private void HMuokkaBt_Click(object sender, EventArgs e)
        {
            int tyyppi = Convert.ToInt32(HHuonetyyppiCB.SelectedValue.ToString());
            String puhelin = HPuhelinTB.Text;
            String vapaa = "";
            try
            {
                int numero = Convert.ToInt32(HHuoneNroTB.Text);
                if (HKyllaRB.Checked)
                {
                    vapaa = "Kyllä";
                }
                else
                {
                    vapaa = "Ei";
                }
                if (huone.muokkaHuonetta(numero, tyyppi, puhelin, vapaa))
                {
                    MessageBox.Show("Huone muokattu onnituneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huonetta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: ", ex.Message);
            }

            HuoneidenHallintaDG.DataSource = huone.haeHuoneet();
        }

        private void HPoistaBT_Click(object sender, EventArgs e)
        {
            try
            {
                String huonenro = HHuoneNroTB.Text;
                if (huone.poistaHuone(huonenro))
                {
                    HuoneidenHallintaDG.DataSource = huone.haeHuoneet();
                    MessageBox.Show("Huone poistettu onnituneesti ", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Huoneitta ei pystytty poistamaan", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: ", ex.Message);
            }
        }
    }
}
