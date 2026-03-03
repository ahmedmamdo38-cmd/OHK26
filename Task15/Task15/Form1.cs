using System.Diagnostics;

namespace Task15
{
    public partial class SekkariFM : Form
    {
        private Stopwatch sekkari = new Stopwatch();

        public SekkariFM()
        {
            InitializeComponent();
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            sekkari.Start();
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            sekkari.Stop();

        }

        private void ResetBT_Click(object sender, EventArgs e)
        {
            sekkari.Reset();
        }

        private void ajastimTM_Tick(object sender, EventArgs e)
        {
            AikaLB.Text = String.Format("{0:hh\\:mm\\:ss\\:fff}", sekkari.Elapsed);
        }
    }
}
