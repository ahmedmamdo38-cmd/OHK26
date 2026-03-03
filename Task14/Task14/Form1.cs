using System.IO;
namespace Task14
{
    public partial class DiaryFM : Form
    {
        public DiaryFM()
        {
            InitializeComponent();
            string teksti = File.ReadAllText("C://Temp//demo.txt");
            SyottoTB.Text = teksti;
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = "";
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            TextWriter text = new StreamWriter("C://Temp//demo.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
