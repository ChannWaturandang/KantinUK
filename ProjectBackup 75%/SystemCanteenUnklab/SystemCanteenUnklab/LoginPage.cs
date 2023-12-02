using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SystemCanteenUnklab
{
    public partial class LoginPage : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public LoginPage()
        {
            alamat = "server=localhost; database=kantin; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtRegis_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp SU = new SignUp();
            SU.Show();
        }

        private void ChShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChShowPassword.Checked == true)
            {
                TxtTempPass.Text = TxtPass.Text;
                TxtTempPass.Visible = true;
                TxtPass.Visible = false;

            }
            else
            {
                TxtTempPass.Visible = false;
                TxtPass.Visible = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text == "Alex" && (TxtPass.Text == "12345" || TxtTempPass.Text == "12345"))
            {
                Form1 Form1 = new Form1();
                Form1.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or wrong Password!");
            }
        }
    }
}
