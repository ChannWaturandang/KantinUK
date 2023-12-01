using Makanan.NewOrderControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;

namespace Makanan
{
    public partial class AddOrderControl : UserControl
    {
        UserControl newCusControl;
        UserControl foodsControl;
        UserControl checkoutControl;

        public static bool movetoMenu = false, movetoCheckout = false, done = false;

        public AddOrderControl()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (movetoMenu == true)
            {
                btnMenu_Click(null, null);
                movetoMenu = false;
            }
            if (movetoCheckout == true)
            {
                btnCheckout_Click(null, null);
                movetoCheckout = false;
            }
            if (done == true)
            {
                newCusControl.Dispose();
                foodsControl.Dispose();
                checkoutControl.Dispose();
                done = false;
                AddOrderControl_Load(null, null);
            }
        }

        private void AddOrderControl_Load(object sender, EventArgs e)
        {
            newCusControl = new NewCusControl();
            foodsControl = new FoodsControl();
            checkoutControl = new CheckoutControl();

            ContentPanel.Controls.Add(newCusControl);
            ContentPanel.Controls.Add(foodsControl);
            ContentPanel.Controls.Add(checkoutControl);

            btnCustomer_Click(null, null); ;
            timer1.Start();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            foreach(Control item in ContentPanel.Controls)
            {
                item.Hide();
            }
            newCusControl.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            foreach (Control item in ContentPanel.Controls)
            {
                item.Hide();
            }
            foodsControl.Show();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            foreach (Control item in ContentPanel.Controls)
            {
                item.Hide();
            }
            checkoutControl.Show();
        }
    }
}
