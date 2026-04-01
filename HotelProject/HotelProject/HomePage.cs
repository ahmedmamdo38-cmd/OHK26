using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomers customers = new ManageCustomers();
            customers.ShowDialog();
            this.Hide();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomManagement rooms = new RoomManagement();
            rooms.ShowDialog();
            this.Hide();
        }

        private void manageReseversationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReseversation reseversation = new ManageReseversation();
            reseversation.ShowDialog();
            this.Hide();
        }
    }
}
