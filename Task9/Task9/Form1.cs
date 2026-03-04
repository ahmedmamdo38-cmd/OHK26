namespace Task9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuunnaBT_Click(object sender, EventArgs e)
        {
            double vastaus;
            double asteet = Convert.ToDouble(AsteetTB.Text);

            if (CelsiusRB.Checked)
            {
                vastaus = asteet * 1.8 + 32;
                VastausLB.Text = asteet + " Celsius on " + vastaus + " Fahrenheit astetta";
                VastausLB.Visible = true;
            }
            else if (FahrenheitRB.Checked)
            {
                vastaus = (asteet -32) / 1.8;
                VastausLB.Text = asteet + " Fahrenheita on " + vastaus + " Celsius astetta";
                VastausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Et valinnut muunnettavaa astetta tai antanut oikea lukua !";
                VastausLB.Visible = true;
            }
        }
    }
}
