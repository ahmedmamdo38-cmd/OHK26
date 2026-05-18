using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopProject
{
    public partial class Basket : Form
    {
        public Basket()
        {
            InitializeComponent();
        }

        public class BasketItem
        {
            public string ProductType { get; set; }
            public string Variation { get; set; }
            public string Category { get; set;  }

        }
    }
}
