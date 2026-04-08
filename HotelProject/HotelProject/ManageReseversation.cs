using MySql.Data.MySqlClient;
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

            RCustomerNumberCB.DataSource = customer.asiakasLista();
            RCustomerNumberCB.DisplayMember = "kokonimi";
            RCustomerNumberCB.ValueMember = "CustomerId";
            ResevertionManagementDG.DataSource = reseversetion.haeVaraukset();
        }

        public bool muokkaVarausta(int roomNumber, int customerId, DateTime checkIn, DateTime checkOut, int varaus)
        {
            MySqlCommand komento = new MySqlCommand();
            String paivitysksely = "UPDATE `resevertion` SET `RoomNro`= @rno, " +
                "`CustomerId`= @cid, " + "`ResevertionStart`= @ent, " + "`ResevertionFinish`= @out " +
                "WHERE `ResevertionId`= @rid";

            komento.CommandText = paivitysksely;
            komento.Connection = connect.otaYhteys();

            komento.Parameters.Add("@rno", MySqlDbType.Int32).Value = roomNumber;
            komento.Parameters.Add("@cid", MySqlDbType.VarChar).Value = customerId;
            komento.Parameters.Add("@ent", MySqlDbType.Date).Value = checkIn;
            komento.Parameters.Add("@out", MySqlDbType.Date).Value = checkOut;
            komento.Parameters.Add("@rid", MySqlDbType.Int32).Value = varaus;

            connect.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                connect.suljeYhteys();
                return true;
            }
            else
            {
                connect.suljeYhteys();
                return false;
            }
        }

        private void ResevertionAddBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(RCustomerNumberCB.SelectedValue?.ToString(), out int customer))
                {
                    MessageBox.Show("Please select a valid customer", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(RRooomNumberCB.SelectedValue?.ToString(), out int room))
                {
                    MessageBox.Show("Please select a valid room", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime checkIn = RCheckIntoHotelDTP.Value;
                DateTime checkOut = RCheckOutHotelDTP.Value;

                if (reseversetion.lisaaVaraus(room, customer, checkIn, checkOut))
                {
                    MessageBox.Show("Reservation successfully added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResevertionManagementDG.DataSource = reseversetion.haeVaraukset();
                }
                else
                {
                    MessageBox.Show("The reservation cannot be added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResevertionManagementDG.DataSource = reseversetion.haeVaraukset();
        }

        private void RRoomTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            int roomType = RRoomTypeCB.SelectedIndex + 1;
            RRooomNumberCB.DataSource = room.tyypillisetHuoneet(roomType);
            RRooomNumberCB.DisplayMember = "RoomId";
            RRooomNumberCB.ValueMember = "RoomId";
        }

        private void ResevertionManagementDG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResevertionNumberTB.Text = ResevertionManagementDG.CurrentRow.Cells[0].Value.ToString();
            RCustomerNumberCB.SelectedValue = Convert.ToInt32(ResevertionManagementDG.CurrentRow.Cells[2].Value.ToString());
            int hnro = Convert.ToInt32(ResevertionManagementDG.CurrentRow.Cells[1].Value.ToString());
            RRoomTypeCB.SelectedValue = Convert.ToInt32(room.haeHuoneenTyyppi(hnro));
            RCheckIntoHotelDTP.Value = Convert.ToDateTime(ResevertionManagementDG.CurrentRow.Cells[3].Value);
            RCheckOutHotelDTP.Value = Convert.ToDateTime(ResevertionManagementDG.CurrentRow.Cells[4].Value);
        }

        private void ResevertionRemoveBT_Click(object sender, EventArgs e)
        {
            try
            {
                String reseversetionNro = ResevertionNumberTB.Text;
                if (reseversetion.poistaVaraus(reseversetionNro))
                {
                    ResevertionManagementDG.DataSource = reseversetion.haeVaraukset();
                    MessageBox.Show("Reseversetion is removed", "Room removal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reseversetion can not be romove", "Room removal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void ResevertionEditBT_Click(object sender, EventArgs e)
        {
            int huonenro = Convert.ToInt32(RRooomNumberCB.SelectedValue.ToString());
            int asiakas = Convert.ToInt32(RCustomerNumberCB.SelectedValue.ToString());
            DateTime sisaan = Convert.ToDateTime(RCheckIntoHotelDTP.Value);
            DateTime ulos = Convert.ToDateTime(RCheckOutHotelDTP.Value);
            try
            {
                int vara = Convert.ToInt32(ResevertionNumberTB.Text);

                if (reseversetion.muokkaVarausta(huonenro, asiakas, sisaan, ulos, vara))
                {
                    MessageBox.Show("Varaus muokattu onnistuneesti", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Varausta ei pystytty muokkaamaan", "Huoneen muokkaus", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message, "Huoneen numero virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ResevertionManagementDG.DataSource = reseversetion.haeVaraukset();

        }

        private void ResevertionClearFieldBT_Click(object sender, EventArgs e)
        {
            ResevertionNumberTB.Text = "";
            RCustomerNumberCB.SelectedIndex = -1;
            RRoomTypeCB.SelectedIndex = -1;
            RRooomNumberCB.SelectedIndex = -1;
            RCheckIntoHotelDTP.Value = DateTime.Now;
            RCheckOutHotelDTP.Value = DateTime.Now;
        }
    }
}