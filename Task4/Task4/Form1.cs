namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = BirthDateDT.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            YearLB.Text = Math.Floor(erotus / 365.25) + " vuotta";
            MonthLB.Text = Math.Floor(erotus * 12 / 365.25) + " kuukautta";
            DayLB.Text = (erotus + " päivää");
            HourLB.Text = (erotus * 24 + " tuntia ");
            MinuteLB.Text = (erotus * 24 * 60 + "minuuttia");
            SecondLB.Text = (erotus * 24 * 3600 + "sekuntia");
            YearLB.Visible = true;
            MonthLB.Visible = true;
            DayLB.Visible = true;
            HourLB.Visible = true;
            MinuteLB.Visible = true;
            SecondLB.Visible = true;
            // Iän laskaminen toimi :)
        }
    }
}
