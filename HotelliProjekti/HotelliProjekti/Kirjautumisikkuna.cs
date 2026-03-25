namespace HotelliProjekti
{


    public partial class KirjautumisikkunaFM : Form
    {
        Paaikkuna MainPage = new Paaikkuna();
        KirjautumisikkunaFM SignIn = new KirjautumisikkunaFM();

        public KirjautumisikkunaFM()
        {
            InitializeComponent();
        }





        private void KirjauduSisäänBT_Click(object sender, EventArgs e)
        {
            if (KaytajaNTB.Text == "Ahmed Mamdo" && SalasanaTB.Text == "150806")
            {
                VirheViestiLB.Visible = false;
                VirheViesti2LB.Visible = false;
                MainPage.Show();
                //SignIn.Visible = false;
            }
            else if (KaytajaNTB.Text == "Jyri Lindroos" && SalasanaTB.Text == "Keudan Opettäjä")
            {
                VirheViestiLB.Visible = false;
                VirheViesti2LB.Visible = false;
                MainPage.Visible = true;
                //SignIn.Visible = false;

            }
            else
            {
                VirheViestiLB.Visible = true;
                VirheViesti2LB.Visible = true;
                MainPage.Show();
                //SignIn.Visible = true;
            }
        }
    }
}
