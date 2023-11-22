using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makanan.NewOrderControls
{
    public partial class NewCusControl : UserControl
    {
        public static string id, cusName, phoneNum, tableNum;
        public NewCusControl()
        {
            InitializeComponent();
        }

        private void NewCusControl_Load(object sender, EventArgs e)
        {

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            id = txtID.Text;
            cusName = txtUsernameCustomer.Text;
            phoneNum = txtPhoneCustomer.Text;
            tableNum = TableBox.Text;

            AddOrderControl.movetoMenu = true;
        }
    }
}
