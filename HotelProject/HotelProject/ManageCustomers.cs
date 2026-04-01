using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelProject
{

    public partial class ManageCustomers : Form
    {
        Customers customer = new Customers();
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void CustomerAddBT_Click(object sender, EventArgs e)
        {
            String firstname = CustomerNameTB.Text;
            String surname = CustomerSurnameTB.Text;
            String address = CustomerAddressTB.Text;
            String postalcode = CustomerPostalcodeTB.Text;
            String postoffice = CustomerPostOfficeTB.Text;
            String username = CustomerUserNameTB.Text;
            String password = CustomerPasswordTB.Text;


            if (firstname.Equals("") || surname.Equals("") || address.Equals("") || postalcode.Equals("") || postoffice.Equals("") || username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Error-required fields-first name and family name, gift address, postal code and city", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("New customer unable to add", "Sustomer add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CustomerManagementDG_Load(object sender, EventArgs e)
        {
            CustomerManagementDG.DataSource = customer.haeAsiakkaat();
        }

        private void CustomerClearFieldsBT_Click(object sender, EventArgs e)
        {
            CustomerNameTB.Text = "";
            CustomerSurnameTB.Text = "";
            CustomerAddressTB.Text = "";
            CustomerPostalcodeTB.Text = "";
            CustomerPostOfficeTB.Text = "";
            CustomerUserNameTB.Text = "";
            CustomerPasswordTB.Text = "";
        }

        private void CustomerManagementDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerUserNameTB.Text = CustomerManagementDG.CurrentRow.Cells[0].Value.ToString();
            CustomerSurnameTB.Text = CustomerManagementDG.CurrentRow.Cells[1].Value.ToString();
            CustomerAddressTB.Text = CustomerManagementDG.CurrentRow.Cells[2].Value.ToString();
            CustomerPostalcodeTB.Text = CustomerManagementDG.CurrentRow.Cells[3].Value.ToString();
            CustomerPostOfficeTB.Text = CustomerManagementDG.CurrentRow.Cells[4].Value.ToString();
            CustomerUserNameTB.Text = CustomerManagementDG.CurrentRow.Cells[5].Value.ToString();
            CustomerPasswordTB.Text = CustomerManagementDG.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
