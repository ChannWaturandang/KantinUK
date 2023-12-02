using Makanan.Controls;
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
        private object btnOrder;

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
            if (true)
            {
                btnCustomer.ForeColor = Color.LightYellow;
                this.ControlPanel.Controls.Clear();
                CustomerControl customerControl = new CustomerControl();
                ControlPanel.Controls.Add(customerControl);

                btnFoods.ForeColor = Color.White;
                btnTables.ForeColor = Color.White;
                Order.ForeColor = Color.White;
                btnAbout.ForeColor = Color.White;
            }
        }


        private void btnFoods_Click(object sender, EventArgs e)
        {
            if (true)
            {
                this.btnFoods.ForeColor = Color.LightYellow;
                this.ControlPanel.Controls.Clear();
                FoodsControl foodsControl = new FoodsControl();
                ControlPanel.Controls.Add(foodsControl);

                btnCustomer.ForeColor = Color.White;
                btnTables.ForeColor = Color.White;
                Order.ForeColor = Color.White;
                btnAbout.ForeColor = Color.White;
            }


        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            if (true)
            {
                btnTables.ForeColor = Color.LightYellow;
                this.ControlPanel.Controls.Clear();
                TableControl tableControl = new TableControl();
                ControlPanel.Controls.Add(tableControl);

                btnCustomer.ForeColor = Color.White;
                btnFoods.ForeColor = Color.White;
                Order.ForeColor = Color.White;
                btnAbout.ForeColor = Color.White;
            }
        }

        private void Order_Click(object sender, EventArgs e)
        {
            if (true)
            {
                Order.ForeColor = Color.LightYellow;
                this.ControlPanel.Controls.Clear();
                OrdersControl ordersControl = new OrdersControl();
                ControlPanel.Controls.Add(ordersControl);

                btnCustomer.ForeColor = Color.White;
                btnFoods.ForeColor = Color.White;
                btnTables.ForeColor = Color.White;
                btnAbout.ForeColor = Color.White;
            }
        }

        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (true)
            {
                btnAbout.ForeColor = Color.LightYellow;
                this.ControlPanel.Controls.Clear();
                AboutControl aboutControl = new AboutControl();
                ControlPanel.Controls.Add(aboutControl);
                btnCustomer.ForeColor = Color.White;
                btnFoods.ForeColor = Color.White;
                btnTables.ForeColor = Color.White;
                Order.ForeColor = Color.White;
            }
        }
    }
};