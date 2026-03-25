using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelliProjekti

{

    public partial class VaraustenHallintaFM : Form
    {
        VARAUS varaus = new VARAUS();
        Huone huone = new Huone();
        Asiakas asiakas = new Asiakas();
        public VaraustenHallintaFM()
        {
            InitializeComponent();
        }

        private void VLisääUusiVarausBT_Click(object sender, EventArgs e)
        {
            String asiakas = VAsiakasNroCB.Text;
            String huone = VHuoneNroCB.Text;
            DateTime sisaankirjautuminen = Convert.ToDateTime(VSisäänDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(VUlosDTP.Value);

            if (varaus.lisaaVaraus(huone, asiakas, sisaankirjautuminen, uloskirjautuminen)
            {
                MessageBox.Show("Varaus lisätty onnistuneesti", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Varausta ei pystytty lisämään", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            VaraustenHallintaDG.DataSource = varaus.haeVaraukset();
        }

        private void VaraustenHallintaFM_Load(object sender, EventArgs e)
        {
            VHuoneTyyppiCB.DataSource = huone.huonetyyppilista();
            VHuoneTyyppiCB.DisplayMember = "Huoneentyyppi";
            VHuoneTyyppiCB.ValueMember = "KategoriaId";

            VAsiakasNroCB.DataSource = asiakas.asiakaslista();
            VAsiakasNroCB.DisplayMember = "Kokonimi";
            VAsiakasNroCB.ValueMember = "AsiakasId";
            VAsiakasNroCB.DataSource = varaus.haeVaraukset();
        }

        private void VHuoneTyyppiCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int huonetype = VHuoneTyyppiCB.SelectedIndex + 1;
            VHuoneNroCB.DataSource = huone.tyypillisetHuoneet(huonetype);
            VHuoneNroCB.DisplayMember = "HuoneenNro";
            VHuoneNroCB.ValueMember = "HuoneenNro";
        }

        private void VMuokkaBt_Click(object sender, EventArgs e)
        {
            String asiakas = VAsiakasNroCB.Text;
            String huone = VHuoneNroCB.Text;
            DateTime sisaankirjautuminen = Convert.ToDateTime(VSisäänDTP.Value);
            DateTime uloskirjautuminen = Convert.ToDateTime(VUlosDTP.Value);
            try

        }
    }
}
