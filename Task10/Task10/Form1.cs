namespace Task10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(PainoTB.Text);
            pituus = Convert.ToDouble(PituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus), 2);

            if(bmi < 18.5)
            {
                VastausLB.Text = "Painoindeksi on " + bmi + " \n Alipaino";
                VastausLB.Visible = true;
                VastausLB.ForeColor = Color.SkyBlue;
            }
            else if(bmi < 25)
            {
                VastausLB.Text = "Painoindeksi on " + bmi + "\n Normaalipaino";
                VastausLB.Visible = true;
                VastausLB.ForeColor = Color.Green;
            }
            else if(bmi < 40)
            {
                VastausLB.Text = "Painoindeksi on " + bmi + "\n Ylipaino";
                VastausLB.Visible = true;
                VastausLB.ForeColor = Color.Yellow;
            }
            else if(bmi > 40)
            {
                VastausLB.Text = "Painoindeksi on " + bmi + "\n Huomettava ylipaino";
                VastausLB.Visible = true;
                VastausLB.ForeColor = Color.Red;
            }
            else
            {
                VastausLB.Text = "Virhee!!Pidää kirjoita paino tai pituus";
                VastausLB.Visible = true;
            }

            //Missoin complete
        }
    }
}
