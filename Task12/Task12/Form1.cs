namespace Task12
{
    public partial class KysymysLomakeFM : Form
    {
        string[] vastaukset = new string[10];
        string[] oikeat = new string[] { "", "B", "D", "A", "A", "C", "A", "B", "A", "C", "D"};
        int laskuri = 0;
        int oikein = 0;
        public KysymysLomakeFM()
        {
            InitializeComponent();
            ARB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            BRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            CRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            DRB.CheckedChanged += new EventHandler(radiobutton_CheckedChanged);
            //B.CheckedChanged += EventHandler(radiobutton_CheckedChanged);
        }

        private void KysymysLomakeFM_Load(object sender, EventArgs e){ }

        private void radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton && laskuri < 10){
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                KysymysLB.Text = "Vastaus " + (laskuri) + ". kysymykseen:";
                laskuri++;
            }
            else
            {
                VastausLB.Text = "";
                ARB.Enabled = false;
                BRB.Enabled = false;
                CRB.Enabled = false;
                DRB.Enabled = false;
                for(int j = 0; j <10; j++)
                {
                    if (vastaukset[j] == oikeat[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }

        private void TyhjaaVastaus()
        {
            if(ARB.Checked == true)
            {
                ARB.Checked = false;
                laskuri--;
            }
            if(BRB.Checked == true)
            {
                BRB.Checked = false;
                laskuri--;
            }
            if(CRB.Checked == true)
            {
                CRB.Checked = false; 
                laskuri--;
            }
            if(DRB.Checked == true)
            {
                DRB.Checked = false;
                laskuri--;
            }
        }

        //Missoin complete
    }


}
