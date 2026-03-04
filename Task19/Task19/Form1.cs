namespace Task19
{
    public partial class RuokalistaFM : Form
    {
        public RuokalistaFM()
        {
            InitializeComponent();
            MeistaPanel.Visible = true;
        }

        private void RuoatBT_Click(object sender, EventArgs e)
        {
            RuoatPanel.Visible = true;
            MeistaPanel.Visible = false;
            JuomatPanel.Visible = false;
            HerkutPanel.Visible = false;
            KoriPanel.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RuokalistaFM_Load(object sender, EventArgs e)
        {

        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {
            MeistaPanel.Visible = true;
            RuoatPanel.Visible = false;
            JuomatPanel.Visible = false;
            HerkutPanel.Visible = false;
            KoriPanel.Visible = false;
        }

        private void ExitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void JuomatBT_Click(object sender, EventArgs e)
        {
            JuomatPanel.Visible = true;
            RuoatPanel.Visible = false;
            HerkutPanel.Visible = false;
            KoriPanel.Visible = false;
            MeistaPanel.Visible = false;
        }

        private void HerkutBT_Click(object sender, EventArgs e)
        {
            HerkutPanel.Visible = true;
            MeistaPanel.Visible = false;
            JuomatPanel.Visible = false;
            RuoatPanel.Visible = false;
            KoriPanel.Visible = false;
        }

        private void KoriBT_Click(object sender, EventArgs e)
        {
            KoriPanel.Visible = true;
            MeistaPanel.Visible = false;
            JuomatPanel.Visible = false;
            RuoatPanel.Visible = false;
            KoriPanel.Visible = false;
        }
    }
}
