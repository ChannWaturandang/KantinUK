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

namespace Makanan
{
    public partial class CustomerControl : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public CustomerControl()
        {
            alamat = "server=localhost; database=kantin; username=root; password=12345;";
            koneksi = new MySqlConnection(alamat);
            this.Font = new Font("Times New Roman", 14, FontStyle.Regular);

            InitializeComponent();
        }

        private void CustomerControl_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from customer");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                customerGridView.DataSource = ds.Tables[0];
                customerGridView.Columns[0].Width = 25;
                customerGridView.Columns[0].HeaderText = "ID";
                customerGridView.Columns[1].Width = 75;
                customerGridView.Columns[1].HeaderText = "Username";
                customerGridView.Columns[2].Width = 75;
                customerGridView.Columns[2].HeaderText = "Phone Number";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }

            // Check if the ID already exists
            query = string.Format("SELECT COUNT(*) FROM customer WHERE id = '{0}'", txtID.Text);
            perintah = new MySqlCommand(query, koneksi);
            int existingIDCount = Convert.ToInt32(perintah.ExecuteScalar());

            if (existingIDCount > 0)
            {
                MessageBox.Show("ID already exists.");
                koneksi.Close();
                return;
            }

            try
            {
                query = string.Format("insert into customer (id, username, phone_number) values ('{0}','{1}', '{2}')", txtID.Text, txtUsernameCustomer.Text, txtPhoneCustomer.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    CustomerControl_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }

            try
            {
                query = string.Format("insert into menu (id, username) values ('{0}', '{1}')", txtID.Text, txtUsernameCustomer.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data berhasil");
                    CustomerControl_Load(null, null);
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


        private void updateCustomer_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("update customer set username='{0}', phone_number='{1}' where id='{2}'", txtUsernameCustomer.Text, txtPhoneCustomer.Text, txtID.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data berhasil");
                    CustomerControl_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from customer where id = '{0}' ", txtID.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                CustomerControl_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from menu where id = '{0}' ", txtID.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                CustomerControl_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void clearCustomer_Click(object sender, EventArgs e)
        {
            txtUsernameCustomer.Text = "";
            txtPhoneCustomer.Text = "";

            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from customer");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                CustomerControl_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from menu", txtUsernameCustomer.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                CustomerControl_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
