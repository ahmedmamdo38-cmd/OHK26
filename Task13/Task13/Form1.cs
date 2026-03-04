namespace Task13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:/Users/ahmed/source2/OHK26/pojat.txt");
            string[] tytot = File.ReadAllLines("C:/Users/ahmed/source2/OHK26/tytot.txt");
            string nimi = NimiTB.Text;
            int laskurip = 1;
            int laskurit = 1;

            foreach (string poika in pojat)
            {
                if(nimi == poika)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin poikien nimi 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach(string tytto in pojat)
            {
                if(nimi == tytto)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin poikien nimi 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }

            if(VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei ole löytynyt suosituimpien nimien joukosta ! :-(";
                VastausLB.Visible = true;
            }
        }

        // Missoin complete
    }
}
