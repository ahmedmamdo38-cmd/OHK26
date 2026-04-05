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
    public partial class ManageReseversation : Form
    {
        Rooms room = new Rooms();
        ConnectWithMySQL connect = new ConnectWithMySQL();
        Reseversetion reseversetion = new Reseversetion();
        Customers customer = new Customers();
        public ManageReseversation()
        {
            InitializeComponent();
        }

        private void ManageReseversation_Load(object sender, EventArgs e)
        {
            RRoomTypeCB.DataSource = room.huonetyyppilista();
            RRoomTypeCB.DisplayMember = "RoomType";
            RRoomTypeCB.ValueMember = "CategoryId";

            RCustomerNumberCB.DataSource = "";
            RCustomerNumberCB.DisplayMember = "FirstName";
            RCustomerNumberCB.ValueMember = "CustomerId";
            RCustomerNumberCB.DataSource = reseversetion.haeVaraukset();
        }

        private void VMuokkaBt_Click(object sender, EventArgs e)
        {
            int room = Convert.ToInt32(RRooomNumberCB.SelectedValue.ToString());
            int customer = Convert.ToInt32(RCustomerNumberCB.SelectedValue.ToString());
            DateTime checkInto = Convert.ToDateTime(RCheckIntoHotelDTP.Value);
            DateTime checkOut = Convert.ToDateTime(RCheckOutHotelDTP.Value);

            try
            {
                int resevertionNumber = Convert.ToInt32(ResevertionNumberTB.Text);
                
                if(reseversetion.muokkaVarausta(room, customer, checkInto, checkOut))
                {
                    MessageBox.Show("Room successfully modified", "Room editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The room cannot be modified", "Room editing", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch( Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Room number error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResevertionManagementDG.DataSource = reseversetion.haeVaraukset();
        }

        private void ResevertionAddBT_Click(object sender, EventArgs e)
        {
            int customer = Convert.ToInt32(RCustomerNumberCB.SelectedValue.ToString());
            int room = Convert.ToInt32(RRooomNumberCB.SelectedValue.ToString());
            DateTime checkIn = Convert.ToDateTime(RCheckIntoHotelDTP.Value);
            DateTime checkOut = Convert.ToDateTime(RCheckOutHotelDTP.Value);


            if (reseversetion.lisaaVaraus(customer, room, checkIn, checkOut))
            {
                MessageBox.Show("Reservation added successfully", "Reservation adding", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Unable to add reservetion", "Reservation adding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResevertionManagementDG.DataSource = reseversetion.haeVaraukset();
        }

        private void RRoomTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roomType = RRoomTypeCB.SelectedIndex + 1;
            RRoomTypeCB.DataSource = room.tyypillisetHuoneet(roomType);
            RRoomTypeCB.DisplayMember = "RoomId";
            RRoomTypeCB.ValueMember = "RoomId";
        }
    }
}
