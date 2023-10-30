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
using MySql.Data;
using MySql.Data.MySqlClient;
using static Guna.UI2.Native.WinApi;

namespace Makanan
{
    public partial class Customer : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        public Customer()
        {
            alamat = "server=localhost; database=kantin; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            this.Font = new Font("Times New Roman", 14, FontStyle.Regular);

            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
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
                customerGridView.Columns[0].Width = 100;
                customerGridView.Columns[0].HeaderText = "Customer ID";
                customerGridView.Columns[1].Width = 150;
                customerGridView.Columns[1].HeaderText = "First Name";
                customerGridView.Columns[2].Width = 150;
                customerGridView.Columns[2].HeaderText = "Last Name";
                customerGridView.Columns[3].Width = 150;
                customerGridView.Columns[3].HeaderText = "Email";
                customerGridView.Columns[4].Width = 150;
                customerGridView.Columns[4].HeaderText = "Phone Number";
                customerGridView.Columns[5].Width = 100;
                customerGridView.Columns[5].HeaderText = "Table Num";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("insert into customer (customer_id, first_name, last_name, email, phone_number, table_num) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", customerID.Text, customerFirst.Text, CustomerLast.Text, customerNum.Text, customerAddress.Text, customerTable.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data berhasil");
                    Customer_Load(null, null);
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
                query = string.Format("update customer set customer_id = '{0}', first_name = '{1}', last_name = '{2}', email='{3}', phone_number='{4}', table_num='{5}' where customer_id='{0}'", customerID.Text, customerFirst.Text, CustomerLast.Text, customerNum.Text, customerAddress.Text, customerTable.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();

                if (res == 1)
                {
                    MessageBox.Show("Insert data success");
                    Customer_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Insert data failed!");
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
                query = string.Format("delete from customer where customer_id = '{0}' ", customerID.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                Customer_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customerID.Text = "";
            customerFirst.Text = "";
            CustomerLast.Text = "";
            customerAddress.Text = "";
            customerNum.Text = "";
            customerTable.Text = "";
        }

        private void customerAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drinks Drinks = new Drinks();
            Drinks.Show();
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            Foods Foods = new Foods();
            Foods.Show();
        }
    }
};