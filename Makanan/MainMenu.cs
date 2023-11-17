using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makanan
{
    public partial class MainMenu : Form
    { 
        public MainMenu()
        {
            this.Font = new Font("Times New Roman", 14, FontStyle.Regular);

            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
           btnCustomer_Click(sender, e);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.ControlPanel.Controls.Clear();
            CustomerControl customerControl = new CustomerControl();
            ControlPanel.Controls.Add(customerControl);
        }


        private void btnFoods_Click(object sender, EventArgs e)
        {
            this.ControlPanel.Controls.Clear();
            FoodsControl foodsControl = new FoodsControl();
            ControlPanel.Controls.Add(foodsControl);
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            this.ControlPanel.Controls.Clear();
            TableControl tableControl = new TableControl();
            ControlPanel.Controls.Add(tableControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ControlPanel.Controls.Clear();
            OrdersControl ordersControl = new OrdersControl();
            ControlPanel.Controls.Add(ordersControl);
        }
    }
};