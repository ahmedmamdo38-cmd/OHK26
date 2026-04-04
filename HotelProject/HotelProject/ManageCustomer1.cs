namespace HotelProject
{

    public partial class ManageCustomer1 : Form
    {
        ConnectWithMySQL connect = new ConnectWithMySQL();
        Customers customer = new Customers();
        public ManageCustomer1()
        {
            InitializeComponent();
        }

        private void ManageCustomer1_Load(object sender, EventArgs e)
        {

        }

        private void CustomerAddBT_Click(object sender, EventArgs e)
        {
            String firstname = CustomerFirstnameTB.Text;
            String surname = CustomerSurnameTB.Text;
            String address = CustomerAddressTB.Text;
            String postalcode = CustomerPostalCodeTB.Text;
            String postoffice = CustomerPostOfficeTB.Text;
            String username = CustomerUsernameTB.Text;
            String password = CustomerPasswordTB.Text;


            if (firstname.Equals("") || surname.Equals("") || address.Equals("") || postalcode.Equals("") || postoffice.Equals("") || username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Error-required fields-first name and family name, gift address, postal code and city", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean lisaAsiakas = customer.lisaaAsiakas(firstname, surname, address, postalcode, postoffice, username, password);
                if (lisaAsiakas)
                {
                    MessageBox.Show("New client added", "Client add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("New client unable to add", "Client add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        // private void CustomerManagementDG_Load(object sender, EventArgs e)
        //{ }

        private void CustomerClearFieldsBT_Click(object sender, EventArgs e)
        {
            CustomerFirstnameTB.Text = "";
            CustomerSurnameTB.Text = "";
            CustomerAddressTB.Text = "";
            CustomerPostalCodeTB.Text = "";
            CustomerPostOfficeTB.Text = "";
            CustomerUsernameTB.Text = "";
            CustomerPasswordTB.Text = "";
        }

        private void CustomerManagementDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerFirstnameTB.Text = CustomerManagementDG.CurrentRow.Cells[0].Value.ToString();
            CustomerSurnameTB.Text = CustomerManagementDG.CurrentRow.Cells[1].Value.ToString();
            CustomerAddressTB.Text = CustomerManagementDG.CurrentRow.Cells[2].Value.ToString();
            CustomerPostalCodeTB.Text = CustomerManagementDG.CurrentRow.Cells[3].Value.ToString();
            CustomerPostOfficeTB.Text = CustomerManagementDG.CurrentRow.Cells[4].Value.ToString();
            CustomerUsernameTB.Text = CustomerManagementDG.CurrentRow.Cells[5].Value.ToString();
            CustomerPasswordTB.Text = CustomerManagementDG.CurrentRow.Cells[6].Value.ToString();
        }

        private void CustomerRemoveBT_Click(object sender, EventArgs e)
        {
            String customerid = CustomerUsernameTB.Text;


            if (customer.poistaAsiakas(customerid))
            {
                CustomerManagementDG.DataSource = customer.haeAsiakkaat();
                MessageBox.Show("Client deleted successfully", "Client removal", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Client could not be removed", "Client removal", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            CustomerClearFieldsBT.PerformClick();
        }

        private void CustomerEditBT_Click(object sender, EventArgs e)
        {
            String firstname = CustomerFirstnameTB.Text;
            String surname = CustomerSurnameTB.Text;
            String address = CustomerAddressTB.Text;
            String postalcode = CustomerPostalCodeTB.Text;
            String postoffice = CustomerPostOfficeTB.Text;
            String username = CustomerUsernameTB.Text;
            String password = CustomerPasswordTB.Text;

            if (firstname.Equals("") || surname.Equals("") || address.Equals("") || postalcode.Equals("") || postoffice.Equals("") || username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Error!!! Required fields-Firstname, Surname, Street address, postalcode, postoffice, username and password");
            }
            else
            {
                Boolean lisaaAsiakas = customer.muokkaAsiakkaat(firstname, surname, address, postalcode, postoffice, username, password);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Client updated successfully ", "Client update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unable to update client", "Client update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CustomerManagementDG.DataSource = customer.haeAsiakkaat();
            }
        }

        private void CustomerAddBT_Click_1(object sender, EventArgs e)
        {
            //By misstake i press this function 
        }
    }
}
