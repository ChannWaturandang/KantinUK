using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemCanteenUnklab
{
    public partial class OrderMenu : Form
    {
        private bool isClicked = false;
        public OrderMenu()
        {
            InitializeComponent();
        }
        private void BtnA1_Click(object sender, EventArgs e)
        {
            if (isClicked)
            {
                // Button has been clicked, change colors to yellow and black
                BtnA1.ForeColor = System.Drawing.Color.Yellow;
                BtnA1.BackColor = System.Drawing.Color.Black;
            }
            else
            {
                // Button has not been clicked, change colors to gray and white
                BtnA1.ForeColor = System.Drawing.Color.Gray;
                BtnA1.BackColor = System.Drawing.Color.White;
            }

            // Toggle the button state
            isClicked = !isClicked;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }
    }
}
