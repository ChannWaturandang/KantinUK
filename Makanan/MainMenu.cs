using Makanan.Controls;
using Makanan.NewOrderControls;
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
        private UserControl addOrderControl = new AddOrderControl();
        private UserControl historyControl = new HistoryControl();
        private UserControl tableControl = new TableControl();
        private UserControl aboutControl = new AboutControl();

        public MainMenu()
        {
            this.Font = new Font("Times New Roman", 14, FontStyle.Regular);

            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            btnCustomer_Click(null, null);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            btnNewOrder.ForeColor = Color.LightYellow;

            this.ControlPanel.Controls.Clear();
            ControlPanel.Controls.Add(addOrderControl);

            btnHistory.ForeColor = Color.White;
            btnTables.ForeColor = Color.White;
            btnAbout.ForeColor = Color.White;
        }


        private void btnHistory_Click(object sender, EventArgs e)
        {

            this.btnHistory.ForeColor = Color.LightYellow;
            this.ControlPanel.Controls.Clear();
            ControlPanel.Controls.Add(historyControl);

            btnNewOrder.ForeColor = Color.White;
            btnTables.ForeColor = Color.White;
            btnAbout.ForeColor = Color.White;
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            btnTables.ForeColor = Color.LightYellow;
            this.ControlPanel.Controls.Clear();
            ControlPanel.Controls.Add(tableControl);

            btnNewOrder.ForeColor = Color.White;
            btnHistory.ForeColor = Color.White;
            btnAbout.ForeColor = Color.White;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            btnAbout.ForeColor = Color.LightYellow;
            this.ControlPanel.Controls.Clear();
            ControlPanel.Controls.Add(aboutControl);

            btnNewOrder.ForeColor = Color.White;
            btnHistory.ForeColor = Color.White;
            btnTables.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
};