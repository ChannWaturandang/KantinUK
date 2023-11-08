using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Makanan
{
    public partial class order : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        string Orders;
        int sum;

        List<string> Items = new List<string>();
        List<int> Prices = new List<int>();
        public order()
        {
            alamat = "server=localhost; database=kantin; username=root; password=12345;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void order_Load(object sender, EventArgs e)
        {
            displayName.Text = "";
            TotalPrice.Text = "Rp. -";

            loadGrid();
            Reset();
        }

        private void loadGrid()
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from Checkout");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[0].HeaderText = "Items";
                dataGridView1.Columns[1].Width = 50;
                dataGridView1.Columns[1].HeaderText = "Prices";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            Reset();        //Clear Table
            getCusName();   //Get Customer's Name
            getCusOrder();  //Get Customer's  Order
            Inserting();    //Insert into table, data : Items and Price of Orders
            Total();
        }

        //Clear Table
        private void Reset()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from Checkout");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                loadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Get customer's name
        private void getCusName()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("SELECT username FROM menu WHERE id='{0}'", customerBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                MySqlDataReader reader = perintah.ExecuteReader();
                {
                    // Jika ada data yang dapat dibaca
                    if (reader.Read())
                    {
                        displayName.Text = reader["username"].ToString() + "'s Reciept";
                    }
                    else
                    {
                        displayName.Text = "";
                    }
                }
                reader.Dispose();
                perintah.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                koneksi.Close();
            }
        }

        //Get Customer's Orders
        private void getCusOrder()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("SELECT Orders FROM menu WHERE id='{0}'", customerBox.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);

                MySqlDataReader reader = perintah.ExecuteReader();
                {
                    // Jika ada data yang dapat dibaca
                    if (reader.Read())
                    {
                        Orders = reader["Orders"].ToString();
                    }
                    else
                    {
                        Orders = "";
                    }
                }
                splitting();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                koneksi.Close();
            }
        }

        private void splitting()
        {
            //patern Regex untuk mengambil sebelum "Rp."
            string itemPattern = @"([^Rp.+]+)(?=\s*Rp\.)";

            //pattern Regex untuk mengambil hanya angka rupiah dalam Order
            string pricePattern = @"Rp\.(\d+)";

            //match Regex pattern untuk dimasukkan di list item
            MatchCollection itemMatches = Regex.Matches(Orders, itemPattern);

            foreach (Match match in itemMatches)
            {
                string value = match.Groups[1].Value;
                Items.Add(value.Trim());
            }

            //match Regex pattern untuk dimasukkan di list price
            MatchCollection priceMatches = Regex.Matches(Orders, pricePattern);

            foreach (Match match in priceMatches)
            {
                if (match.Groups.Count > 1)
                {
                    string value = match.Groups[1].Value;
                    if (int.TryParse(value, out int intValue))
                    {
                        Prices.Add(intValue);
                    }
                }
            }
        }

        private void Inserting()
        {
            for(int i = 0; i < Items.Count; i++)
            {
                if (koneksi.State != ConnectionState.Open)
                {
                    koneksi.Open();
                }
                try
                {
                    query = string.Format("insert into checkout (Items, Price) values ('{0}', '+{1}')", Items[i], Prices[i]);
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        loadGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer Customer = new Customer();
            Customer.Show();
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            Foods Foods = new Foods();
            Foods.Show();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            this.Hide();
            table table = new table();
            table.Show();
        }

        private void Total()
        {
            sum = Prices.Sum();
            TotalPrice.Text = "Rp." + sum; 
        }
    }
}
