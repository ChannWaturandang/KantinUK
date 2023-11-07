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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int a = Screen.PrimaryScreen.Bounds.Width;

            int b = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point(0, 0);

            this.Size = new Size(a, b);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderMenu OM = new OrderMenu();
            OM.Show();
        }
    }
}
