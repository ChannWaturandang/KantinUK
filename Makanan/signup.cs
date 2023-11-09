using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Makanan
{
    public partial class signup : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;
        public signup()
        {
            alamat = "server=localhost; database=kantin; username=root; password=12345;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void signin_Load(object sender, EventArgs e)
        {

        }


        private void sBack_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                sPass.UseSystemPasswordChar = false;
                sConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                sPass.UseSystemPasswordChar = true;
                sConfirm.UseSystemPasswordChar = true;
            }
        }

        private void sBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login Login = new Login();
            Login.Show();
        }

        private void sSignIn_Click(object sender, EventArgs e)
        {
            if (sConfirm.Text == sPass.Text)
            {
                if (koneksi.State != ConnectionState.Open)
                {
                    koneksi.Open();
                }
                try
                {
                    query = string.Format("insert into signup (username, first_name, last_name, phone_number, Date_of_Birth, Age, Email, Password) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", sUsername.Text, sFirst.Text, sLast.Text, sPhone.Text, sDate.Text, sAge.Text, sEmail.Text, sPass.Text);
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Insert data berhasil");
                        signin_Load(null, null);

                        signup signin = new signup();
                        signin.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Insert data gagal");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please confirm your Password");
            }

        }
    }
}
