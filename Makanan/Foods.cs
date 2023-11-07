using System;
using System.CodeDom;
using System.Collections;
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


namespace Makanan
{
    public partial class Foods : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        string choiceDrink, choiceFood;
        string orderPrice;
        List<string> Orders = new List<string>();

        public Foods()
        {
            alamat = "server=localhost; database=Kantin; username=root; password=12345;";
            koneksi = new MySqlConnection(alamat);
            this.Font = new Font("Times New Roman", 14, FontStyle.Regular);

            InitializeComponent();
        }


        protected void Searchbox_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in FoodDisplay.Controls)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void PicRefreshFood()
        {
            this.mieCakalang.BackColor = Color.Transparent;
            this.nasiGoreng.BackColor = Color.Transparent;
            this.ayamGeprek.BackColor = Color.Transparent;
            this.mieKuah.BackColor = Color.Transparent;
            this.ayamLalapan.BackColor = Color.Transparent;
            this.nutrisari.BackColor = Color.Transparent;
            this.airMineral.BackColor = Color.Transparent;
        }

        //Form Customer
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer Customer = new Customer();
            Customer.Show();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            this.Hide();
            table table = new table();
            table.Show();
        }

        private void btnFoods_Click(object sender, EventArgs e)
        {

        }

        //Update (Add)
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                string combinedString = string.Join(" + ", Orders.ToArray());

                query = string.Format("update menu set Orders='{1}' where username='{0}'", CustomerTxt.Text, combinedString);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();

                if (res == 1)
                {
                    MessageBox.Show("Added :" + combinedString);
                    Form1_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Customer doesn't exist, please check again!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Delete (Clear Orders)
        private void DeleteBtn_Click(object sender, EventArgs e)
        {;
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("update menu set Orders='' where username='{0}'", CustomerTxt.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();

                PicRefreshFood();
                Orders.Clear();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                if (res == 1)
                {
                    Form1_Load(null, null);
                    MessageBox.Show("Insert data success");
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
            
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void CustomerTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            PicRefreshFood();
            Orders.Clear();
        }

        //Foods
        //ayam lalapan
        private void ayamLalapan_Click(object sender, EventArgs e)
        {
            this.ayamLalapan.BackColor = Color.LightGray;
            orderPrice = "Rp.18000";
            choiceFood = "Ayam Lalapan " + orderPrice;
            Orders.Add(choiceFood);
        }

        //Nasi Goreng
        private void nasiGoreng_Click(object sender, EventArgs e)
        {
            
            this.nasiGoreng.BackColor = Color.LightGray;
            orderPrice = "Rp.15000";
            choiceFood = "Nasi Goreng " + orderPrice;
            Orders.Add(choiceFood);
        }

        //Ayam Geprek
        private void ayamGeprek_Click(object sender, EventArgs e)
        {
            
            this.ayamGeprek.BackColor = Color.LightGray;
            orderPrice = "Rp.18000";
            choiceFood = "Ayam Geprek " + orderPrice;
            Orders.Add(choiceFood);
        }

        //Mie kuah
        private void mieKuah_Click(object sender, EventArgs e)
        {
            this.mieKuah.BackColor = Color.LightGray;
            orderPrice = "Rp.10000";
            choiceFood = "Mie kuah " + orderPrice;
            Orders.Add(choiceFood);
        }

        //Mie Cakalang
        private void NoodlePic_Click(object sender, EventArgs e)
        {
            this.mieCakalang.BackColor = Color.LightGray;
            orderPrice = "Rp.12000";
            choiceFood = "Mie Cakalang " + orderPrice;
            Orders.Add(choiceFood);
        }
        
        //Drinks
        //air mineral
        private void airMineral_Click(object sender, EventArgs e)
        {
            this.airMineral.BackColor = Color.LightGray;
            orderPrice = "Rp.5000";
            choiceDrink = "Air Mineral " + orderPrice;
            Orders.Add(choiceDrink);
        }

        //Nutri Sari
        private void nutrisari_Click(object sender, EventArgs e)
        {
            this.nutrisari.BackColor = Color.LightGray;
            orderPrice = "Rp.7000";
            choiceDrink = "Nutri Sari " + orderPrice;
            Orders.Add(choiceDrink);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select username, Orders, Table_Num from menu");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[0].HeaderText = "Customer name";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Orders";
                dataGridView1.Columns[2].Width = 30;
                dataGridView1.Columns[2].HeaderText = "Table Num";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}