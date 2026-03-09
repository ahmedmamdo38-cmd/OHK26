using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelliProjekti
{
    public partial class Testi : Form
    {

        Paaikkuna MainPage = new Paaikkuna();
        
        public Testi()
        {
            InitializeComponent();
        }

        private void KirjauduSisään1BT_Click(object sender, EventArgs e)
        {
            if (Kaytaja1NTB.Text == "Ahmed Mamdo" && Salasana1TB.Text == "150806")
            {
                VirheViesti0LB.Visible = false;
                VirheViesti1LB.Visible = false;
                MainPage.Show();
                this.Hide();
                
            }
            else if (Kaytaja1NTB.Text == "Jyri Lindroos" && Salasana1TB.Text == "Keudan Opettäjä")
            {
                VirheViesti0LB.Visible = false;
                VirheViesti1LB.Visible = false;
                MainPage.Show();
                this.Hide();
                

            }
            else
            {
                VirheViesti0LB.Visible = true;
                VirheViesti1LB.Visible = true;
                //MainPage.Show();
                
            }
        }
    }
}
