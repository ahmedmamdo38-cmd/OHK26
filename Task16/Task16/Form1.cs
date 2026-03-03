namespace Task16
{

    public partial class LaskuriFM : Form
    {
        private int kokonaisaika;
        public LaskuriFM()
        {
            InitializeComponent();
        }

        private void LaskuriFM_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for (int i = 0; i < 60; i++)
            {
                MinuuttiCB.Items.Add(i.ToString());
                SekunniCB.Items.Add(i.ToString());
            }
            MinuuttiCB.SelectedIndex = 30;
            SekunniCB.SelectedIndex = 0;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;
            int minuutit = int.Parse(MinuuttiCB.SelectedItem.ToString());
            int sekunnit = int.Parse(SekunniCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            AjastinTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            AjastinTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void AjastinTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekuntit = kokonaisaika - (minuutit * 60);
                AikaLB.Text = minuutit.ToString() + ":" + sekuntit.ToString();

            }
            else
            {
                AjastinTM.Stop();
                MessageBox.Show("Aikasi loppui!!");
            }
        }
    }
}
