using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject
{
    public partial class RoomManagement : Form
    {
        Rooms room = new Rooms();
        public RoomManagement()
        {
            InitializeComponent();
        }

        private void RoomAddBT_Click(object sender, EventArgs e)
        {
            int roomNumber = Convert.ToInt32(RoomNumberTB.Text);
            int roomType = Convert.ToInt32(RoomTypeCB.SelectedValue.ToString());
            String phone = PhoneNumberTB.Text;

            if (room.lisaaHuoneet(roomNumber, roomType, phone, "Yes"))
            {
                MessageBox.Show("Room added with congratulations", "Room addition", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The room could not be added", "Room addition", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RoomManagementDG.DataSource = room.haeHuoneet();

        }

        private void RoomManagement_Load(object sender, EventArgs e)
        {
            RoomTypeCB.DataSource = room.huonetyyppilista();
            RoomTypeCB.DisplayMember = "RoomType";
            RoomTypeCB.ValueMember = "CategoryId";
            RoomManagementDG.DataSource = room.haeHuoneet();
        }

        private void RoomClearFieldsBT_Click(object sender, EventArgs e)
        {
            RoomNumberTB.Text = "";
            RoomTypeCB.SelectedIndex = 0;
            PhoneNumberTB.Text = "";
        }

        private void RoomManagementDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RoomNumberTB.Text = RoomManagementDG.CurrentRow.Cells[0].Value.ToString();
            RoomTypeCB.SelectedValue = RoomManagementDG.CurrentRow.Cells[1].Value;
            PhoneNumberTB.Text = RoomManagementDG.CurrentRow.Cells[2].ToString();
        }

        private void RoomEditBT_Click(object sender, EventArgs e)
        {
            int roomType = Convert.ToInt32(RoomTypeCB.SelectedValue.ToString());
            String phone = PhoneNumberTB.Text;
            String free = "";

            try
            {
                int number = Convert.ToInt32(RoomNumberTB.Text);
                if (VariantsYesRB.Checked)
                {
                    free = "Yes";
                }
                else
                {
                    free = "No";
                }
                if (room.muokkaHuonetta(number, roomType, phone, free))
                {
                    MessageBox.Show("Room modified with congratulations", "Room Editing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The room could not be modified", "Room Editing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }

            RoomManagementDG.DataSource = room.haeHuoneet();
        }

        private void RoomRemoveBT_Click(object sender, EventArgs e)
        {
            try
            {
                String roomNumber = RoomNumberTB.Text;
                if (room.poistaHuone(roomNumber))
                {
                    RoomManagementDG.DataSource = room.haeHuoneet();
                    MessageBox.Show("Room deleted with good luck", "Room deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to remove rooms", "Room deleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }
    }
}
