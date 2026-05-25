using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (checkBox15.Checked && string.IsNullOrWhiteSpace(textBox1.Text)) { MessageBox.Show("Please enter quantity for Coke.", "Missing Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (checkBox16.Checked && string.IsNullOrWhiteSpace(textBox2.Text)) { MessageBox.Show("Please enter quantity for Diet Coke.", "Missing Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (checkBox17.Checked && string.IsNullOrWhiteSpace(textBox3.Text)) { MessageBox.Show("Please enter quantity for Iced Tea.", "Missing Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (checkBox18.Checked && string.IsNullOrWhiteSpace(textBox4.Text)) { MessageBox.Show("Please enter quantity for Ginger Ale.", "Missing Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (checkBox19.Checked && string.IsNullOrWhiteSpace(textBox5.Text)) { MessageBox.Show("Please enter quantity for Sprite.", "Missing Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (checkBox20.Checked && string.IsNullOrWhiteSpace(textBox6.Text)) { MessageBox.Show("Please enter quantity for Root Beer.", "Missing Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (checkBox21.Checked && string.IsNullOrWhiteSpace(textBox7.Text)) { MessageBox.Show("Please enter quantity for Water.", "Missing Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

           
            if (radioButton1.Checked)
                AddPizzaItem(GetCrustName() + " Small Pizza", "4.00");
            else if (radioButton2.Checked)
                AddPizzaItem(GetCrustName() + " Medium Pizza", "7.00");
            else if (radioButton3.Checked)
                AddPizzaItem(GetCrustName() + " Large Pizza", "10.00");
            else if (radioButton4.Checked)
                AddPizzaItem(GetCrustName() + " Extra Large Pizza", "13.00");

            if (checkBox1.Checked) AddToppingItem("Pepperoni Toppings");
            if (checkBox2.Checked) AddToppingItem("Extra Cheese Toppings");
            if (checkBox3.Checked) AddToppingItem("Mushroom Toppings");
            if (checkBox4.Checked) AddToppingItem("Ham Toppings");
            if (checkBox5.Checked) AddToppingItem("Bacon Toppings");
            if (checkBox6.Checked) AddToppingItem("Ground Beef Toppings");
            if (checkBox7.Checked) AddToppingItem("Jalapeno Toppings");
            if (checkBox8.Checked) AddToppingItem("Pineapple Toppings");
            if (checkBox9.Checked) AddToppingItem("Dried Shrimps Toppings");
            if (checkBox10.Checked) AddToppingItem("Anchovies Toppings");
            if (checkBox11.Checked) AddToppingItem("Sun Dried Tomatoes Toppings");
            if (checkBox12.Checked) AddToppingItem("Spinach Toppings");
            if (checkBox13.Checked) AddToppingItem("Roasted Garlic Toppings");
            if (checkBox14.Checked) AddToppingItem("Shredded Chicken Toppings");

            if (checkBox15.Checked) AddDrinkItem("Coke - Can", textBox1.Text, 1.45);
            else textBox1.Text = "";

            if (checkBox16.Checked) AddDrinkItem("Diet Coke - Can", textBox2.Text, 1.45);
            else textBox2.Text = "";

            if (checkBox17.Checked) AddDrinkItem("Iced Tea - Can", textBox3.Text, 1.45);
            else textBox3.Text = "";

            if (checkBox18.Checked) AddDrinkItem("Ginger Ale - Can", textBox4.Text, 1.45);
            else textBox4.Text = "";

            if (checkBox19.Checked) AddDrinkItem("Sprite - Can", textBox5.Text, 1.45);
            else textBox5.Text = "";

            if (checkBox20.Checked) AddDrinkItem("Root Beer - Can", textBox6.Text, 1.45);
            else textBox6.Text = "";

            if (checkBox21.Checked) AddDrinkItem("Bottled Water", textBox7.Text, 1.25);
            else textBox7.Text = "";

            if (checkBox22.Checked) AddOtherItem("Chicken Wings", "3.00");
            if (checkBox23.Checked) AddOtherItem("Poutine", "3.00");
            if (checkBox24.Checked) AddOtherItem("Onion Rings", "3.00");
            if (checkBox25.Checked) AddOtherItem("Cheesy Garlic Bread", "3.00");
            if (checkBox26.Checked) AddOtherItem("Garlic Dip", "0.00");
            if (checkBox27.Checked) AddOtherItem("BBQ Dip", "0.00");
            if (checkBox28.Checked) AddOtherItem("Sour Cream Dip", "0.00");

            double total = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                double.TryParse(
                    item.SubItems[2].Text.Replace(",", "."),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out double val);
                total += val;
            }

            double hst = total * 0.13;
            double totaldue = total + hst;

            textBox8.Text = total.ToString("c2");
            textBox9.Text = hst.ToString("c2");
            textBox10.Text = totaldue.ToString("c2");

            tabControl1.SelectTab("tabPage2");
        }

        private string GetCrustName()
        {
            if (radioButton6.Checked) return "Cheesy Crust";
            if (radioButton7.Checked) return "Sausage Crust";
            return "Normal Crust";
        }

        private void AddPizzaItem(string name, string price)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add("1");
            item.SubItems.Add(price);
            listView1.Items.Add(item);
        }

        private void AddToppingItem(string name)
        {
            ListViewItem item = new ListViewItem("  " + name);
            item.SubItems.Add("");
            item.SubItems.Add("0.75");
            listView1.Items.Add(item);
        }

        private void AddDrinkItem(string name, string qtyText, double unitPrice)
        {
            int.TryParse(qtyText, out int qty);
            double cost = qty * unitPrice;
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(qtyText);
            item.SubItems.Add(cost.ToString(CultureInfo.InvariantCulture));
            listView1.Items.Add(item);
        }

        private void AddOtherItem(string name, string price)
        {
            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add("");
            item.SubItems.Add(price);
            listView1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage1");
        }


        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Your order is empty. Please add items before checking out.",
                                "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tabControl1.SelectTab("tabPage3");
            textBox19.Text = textBox10.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "" || textBox12.Text == "" ||
                textBox13.Text == "" || textBox15.Text == "" ||
                textBox20.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please fill in all required fields.",
                                "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double paymentDue = (double)ParseCurrency(textBox19.Text);

            string amountText = textBox20.Text.Replace(",", ".");
            if (!double.TryParse(amountText,
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out double amountPaid))
            {
                MessageBox.Show("Please enter a valid amount paid.",
                                "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double change = amountPaid - paymentDue;
            textBox21.Text = change.ToString("c2");

            if (change < 0)
            {
                MessageBox.Show("Insufficient payment. Please pay the full balance.",
                                "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button8.Enabled = false;
            }
            else
            {
                button8.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            var order = new OrderData
            {

                FirstName = textBox11.Text.Trim(),
                LastName = textBox12.Text.Trim(),
                Address = textBox13.Text.Trim(),
                Province = comboBox1.Text.Trim(),
                City = textBox14.Text.Trim(),
                PostalCode = textBox15.Text.Trim(),
                ContactNo = textBox16.Text.Trim(),
                Email = textBox17.Text.Trim(),

                PaymentMethod = comboBox2.Text,
                CardNo = string.IsNullOrWhiteSpace(textBox18.Text)
                                    ? null
                                    : textBox18.Text.Trim(),

                Subtotal = ParseCurrency(textBox8.Text),
                Hst = ParseCurrency(textBox9.Text),
                TotalDue = ParseCurrency(textBox10.Text),
                AmountPaid = ParseCurrency(textBox20.Text),
                ChangeAmount = ParseCurrency(textBox21.Text),
            };

            foreach (ListViewItem lvi in listView1.Items)
            {
                string itemName = lvi.Text;
                string qtyText = lvi.SubItems[1].Text;
                string priceText = lvi.SubItems[2].Text;

                int.TryParse(qtyText, out int qty);

                decimal.TryParse(
                    priceText.Replace(",", "."),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out decimal price);

                order.Items.Add(new OrderItem
                {
                    ItemName = itemName,
                    Quantity = qty == 0 ? 1 : qty,
                    Price = price
                });
            }

            int newOrderId = DatabaseHelper.SaveOrder(order);

            if (newOrderId == -1)
            {
                return;
            }

            DialogResult dialog = MessageBox.Show(
                $"Order #{newOrderId} saved!\n\n" +
                "Thanks for ordering at Pizza Express.\n" +
                "Your order will be ready and delivered in 30 minutes.\n\n" +
                "Do you want to order again?",
                "Order Submitted",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
                ResetForm();
            else
                this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton5.Checked = true;

            textBox8.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox19.Enabled = false;
            textBox21.Enabled = false;

            button8.Enabled = false;

            comboBox1.Items.AddRange(new string[]
            {
                "Alberta", "British Columbia", "Manitoba",
                "New Brunswick", "Newfoundland and Labrador",
                "Ontario", "Prince Edward Island",
                "Quebec", "Saskatchewan"
            });

            comboBox2.Items.AddRange(new string[]
            {
                "Cash", "Credit Card", "Debit Card", "Promo Card"
            });
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Cash")
            {
                textBox18.Enabled = false;
                textBox18.Text = "";
            }
            else
            {
                textBox18.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
                this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        { if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        { if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        { if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        { if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        { if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        { if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        { if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8) e.Handled = true; }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8
                                         && e.KeyChar != 46
                                         && e.KeyChar != 44)
            {
                e.Handled = true;
            }

            TextBox tb = (TextBox)sender;
            if ((e.KeyChar == 46 || e.KeyChar == 44) &&
                (tb.Text.Contains(".") || tb.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        private decimal ParseCurrency(string text)
        {
            string clean = text.Replace("$", "")
                               .Replace(",", ".")
                               .Replace(" ", "")
                               .Trim();

            return decimal.TryParse(
                clean,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out decimal result) ? result : 0;
        }


        private void ResetForm()
        {
  
            for (int i = 1; i <= 28; i++)
            {
                var found = Controls.Find("checkBox" + i, true);
                if (found.Length > 0 && found[0] is CheckBox cb)
                    cb.Checked = false;
            }

            for (int i = 1; i <= 7; i++)
            {
                var found = Controls.Find("textBox" + i, true);
                if (found.Length > 0 && found[0] is TextBox tb)
                    tb.Text = "";
            }

            listView1.Items.Clear();
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

 
            textBox11.Text = ""; textBox12.Text = ""; textBox13.Text = "";
            textBox14.Text = ""; textBox15.Text = ""; textBox16.Text = "";
            textBox17.Text = ""; textBox18.Text = ""; textBox19.Text = "";
            textBox20.Text = ""; textBox21.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";

            textBox18.Enabled = true;
            button8.Enabled = false;

       
            tabControl1.SelectTab("tabPage1");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void tabPage3_Click(object sender, EventArgs e) { }
        private void tabPage2_Click(object sender, EventArgs e) { }
    }
}