namespace Task5
{
    public partial class Form1 : Form
    {

        List<int> jono = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

       private void UusiLukuTB_KeyUp(object sender, KeyEventArgs e){ }

        private void UusiLukuTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                if(UusiLukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] taulukko = jono.ToArray();
                    Array.Sort(taulukko);
                    foreach(var jasen in taulukko)
                    {
                        VastausLB.Text += jasen + " ";
                    }
                    VastausLB.Visible = true;
                }
                else
                {
                    jono.Add(Int32.Parse(UusiLukuTB.Text));
                    UusiLukuTB.Text = "";
                }
            }
            if(e.KeyChar == (char)Keys.Escape)
            {
                TyhjaaLomake();
            }
        }


        private void TyhjaaLomake()
        {
            UusiLukuTB.Text = "";
        }

        //Koodissa ei ole mitään virheita, mutta mää en tiedä mitä koodi toimi ?
    }
}
