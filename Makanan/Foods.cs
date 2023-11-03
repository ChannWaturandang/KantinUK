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
        float foodP;
        float drinkP;

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
        }

        public void PicRefreshDrink()
        {
            this.airMineral.BackColor = Color.Transparent;
            this.nutrisari.BackColor = Color.Transparent;
        }

        //Form Customer
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer Customer = new Customer();
            Customer.Show();
        }

        //Add
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("insert into menu (username, food, foodPrice, drink, drinkPrice) values ('{0}', '{1}', '{2}', '{3}', '{4}')", CustomerTxt.Text, choiceFood, foodP, choiceDrink, drinkP);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Insert data berhasil");
                    Form1_Load(null, null);
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

        //Update
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("update menu set username = '{0}', food = '{1}', foodPrice = '{2}', drink = '{3}' , drinkPrice = '{4}' where username='{0}'", CustomerTxt.Text, choiceFood, foodP, choiceDrink, drinkP);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();

                if (res == 1)
                {
                    MessageBox.Show("Insert data success");
                    Form1_Load(null, null);
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

        //Delete
        private void DeleteBtn_Click(object sender, EventArgs e)
        {;
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from menu where username='{0}'", CustomerTxt.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();

                


                if (res == 1)
                {
                    ds.Clear();
                    adapter.Fill(ds);
                    koneksi.Close();

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

        //Foods
        //ayam lalapan
        private void ayamLalapan_Click(object sender, EventArgs e)
        {
            PicRefreshFood();
            this.ayamLalapan.BackColor = Color.LightGray;
            choiceFood = "Ayam Lalapan";
            foodP = 18000;
        }

        //Nasi Goreng
        private void nasiGoreng_Click(object sender, EventArgs e)
        {
            PicRefreshFood();
            this.nasiGoreng.BackColor = Color.LightGray;
            choiceFood = "Nasi Goreng";
            foodP = 15000;
        }

        //Ayam Geprek
        private void ayamGeprek_Click(object sender, EventArgs e)
        {
            PicRefreshFood();
            this.ayamGeprek.BackColor = Color.LightGray;
            choiceFood = "Ayam Geprek";
            foodP = 18000;
        }

        //Mie kuah
        private void mieKuah_Click(object sender, EventArgs e)
        {
            PicRefreshFood();
            this.mieKuah.BackColor = Color.LightGray;
            choiceFood = "Mie kuah";
            foodP = 10000;
        }

        //Mie Cakalang
        private void NoodlePic_Click(object sender, EventArgs e)
        {
            PicRefreshFood();
            this.mieCakalang.BackColor = Color.LightGray;
            choiceFood = "Mie Cakalang";
            foodP = 12000;
        }
        
        //Drinks
        //air mineral
        private void airMineral_Click(object sender, EventArgs e)
        {
            PicRefreshDrink();
            this.airMineral.BackColor = Color.LightGray;
            choiceDrink = "Air Mineral";
            drinkP = 5000;
        }

        //Nutri Sari
        private void nutrisari_Click(object sender, EventArgs e)
        {
            PicRefreshDrink();
            this.nutrisari.BackColor = Color.LightGray;
            choiceDrink = "Nutri Sari";
            drinkP = 7000;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from menu");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "Customer name";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Food";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Drink";
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[3].HeaderText = "Food Price";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Drink Price";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}