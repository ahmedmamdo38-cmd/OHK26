namespace Task6
{
    public partial class SalasanaTarkustusFM : Form
    {
        public SalasanaTarkustusFM()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if (KayttajaTB.Text == "Ahmed Mamdo" && SalasanaTB.Text == "Mamdo")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeanPanel.Visible = true;
            }
            else if (KayttajaTB.Text == "Jyri Lindroos" && SalasanaTB.Text == "KeudaOpe")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeanPanel.Visible = true;
            }
            else if (KayttajaTB.Text == "Haben Tsegu" && SalasanaTB.Text == "Tsegu")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeanPanel.Visible = true;
            }
            else if (KayttajaTB.Text == "Liverpool FC" && SalasanaTB.Text == "The Reds")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeanPanel.Visible = true;
            }
            else
            {
                VirheViestiLB.Text = "Käyttäjänimi tai salasana virheellinen!!";
                VirheViestiLB.Visible = true;
            }
        }
    }
}
