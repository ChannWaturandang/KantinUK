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

namespace Makanan.Controls
{
    public partial class HistoryControl : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public HistoryControl()
        {
            alamat = "server=localhost; database=kantin; username=root; password=12345;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void HistoryControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Datagrid()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("select * from `order`");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 75;
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Nama";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].HeaderText = "PhoneNum";
                dataGridView1.Columns[3].Width = 75;
                dataGridView1.Columns[3].HeaderText = "Table";
                dataGridView1.Columns[4].Width = 450;
                dataGridView1.Columns[4].HeaderText = "Order";
                dataGridView1.Columns[5].Width = 120;
                dataGridView1.Columns[5].HeaderText = "Total";
                dataGridView1.Columns[6].Width = 120;
                dataGridView1.Columns[6].HeaderText = "Payment";
                dataGridView1.Columns[7].Width = 120;
                dataGridView1.Columns[7].HeaderText = "Return";
                dataGridView1.Columns[8].Width = 120;
                dataGridView1.Columns[8].HeaderText = "Date";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Datagrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from `order` where id = '{0}' ", IDBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                HistoryControl_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
