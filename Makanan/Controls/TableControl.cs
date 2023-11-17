using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makanan
{
    public partial class TableControl : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        string n;

        public TableControl()
        {
            alamat = "server=localhost; database=Kantin; username=root; password=12345;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void TableControl_Load(object sender, EventArgs e)
        {

        }

        private void A1_Click(object sender, EventArgs e)
        {
            Reset();
            this.A1.BackColor = Color.DarkGreen;
            n = "A1";
        }

        private void A2_Click(object sender, EventArgs e)
        {
            Reset();
            this.A2.BackColor = Color.DarkGreen;
            n = "A2";
        }

        private void A3_Click(object sender, EventArgs e)
        {
            Reset();
            this.A3.BackColor = Color.DarkGreen;
            n = "A3";

        }

        private void B1_Click(object sender, EventArgs e)
        {
            Reset();
            this.B1.BackColor = Color.DarkGreen;
            n = "B1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            Reset();
            this.B2.BackColor = Color.DarkGreen;
            n = "B2";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            Reset();
            this.B3.BackColor = Color.DarkGreen;
            n = "B3";
        }

        private void C1_Click(object sender, EventArgs e)
        {
            Reset();
            this.C1.BackColor = Color.DarkGreen;
            n = "C1";
        }

        private void C2_Click(object sender, EventArgs e)
        {
            Reset();
            this.C2.BackColor = Color.DarkGreen;
            n = "C2";
        }

        private void C3_Click(object sender, EventArgs e)
        {
            Reset();
            this.C3.BackColor = Color.DarkGreen;
            n = "C3";
        }

        private void D1_Click(object sender, EventArgs e)
        {
            Reset();
            this.D1.BackColor = Color.DarkGreen;
            n = "D1";
        }

        private void D2_Click(object sender, EventArgs e)
        {
            Reset();
            this.D2.BackColor = Color.DarkGreen;
            n = "D2";
        }

        private void D3_Click(object sender, EventArgs e)
        {
            Reset();
            this.D3.BackColor = Color.DarkGreen;
            n = "D3";
        }

        private void E1_Click(object sender, EventArgs e)
        {
            Reset();
            this.E1.BackColor = Color.DarkGreen;
            n = "E1";
        }

        private void E2_Click(object sender, EventArgs e)
        {
            Reset();
            this.E2.BackColor = Color.DarkGreen;
            n = "E2";
        }

        private void E3_Click(object sender, EventArgs e)
        {
            Reset();
            this.E3.BackColor = Color.DarkGreen;
            n = "E3";
        }

        private void E4_Click(object sender, EventArgs e)
        {
            Reset();
            this.E4.BackColor = Color.DarkGreen;
            n = "E4";
        }

        private void E5_Click(object sender, EventArgs e)
        {
            Reset();
            this.E5.BackColor = Color.DarkGray;
            n = "E5";
        }

        private void input(string TableNum)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("update menu set Table_Num = '{0}' where username='{1}'", TableNum, nameBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();

                if (res == 1)
                {
                    MessageBox.Show("Insert data success");
                    TableControl_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Customer ID doesn't exist, please check the customer table");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            input(n);
        }

        private void Reset()
        {
            this.A1.BackColor = Color.DarkGray;
            this.A2.BackColor = Color.DarkGray;
            this.A3.BackColor = Color.DarkGray;
            this.B1.BackColor = Color.DarkGray;
            this.B2.BackColor = Color.DarkGray;
            this.B3.BackColor = Color.DarkGray;
            this.C1.BackColor = Color.DarkGray;
            this.C2.BackColor = Color.DarkGray;
            this.C3.BackColor = Color.DarkGray;
            this.D1.BackColor = Color.DarkGray;
            this.D2.BackColor = Color.DarkGray;
            this.D3.BackColor = Color.DarkGray;
            this.E1.BackColor = Color.DarkGray;
            this.E2.BackColor = Color.DarkGray;
            this.E3.BackColor = Color.DarkGray;
            this.E4.BackColor = Color.DarkGray;
            this.E5.BackColor = Color.DarkGray;
        }
    }
}
