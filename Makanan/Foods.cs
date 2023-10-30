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

        string Choice;
        float Harga;

        public Foods()
        {
            alamat = "server=localhost; database=Kantin; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            this.Font = new Font("Times New Roman", 14, FontStyle.Regular);

            InitializeComponent();
        }


        protected void Searchbox_TextChanged(object sender, EventArgs e)
        {
            foreach(var item in FoodDisplay.Controls)
            {

            }   
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void PicRefresh()
        {
            this.NoodlePic.BackColor = Color.Transparent;
            this.BurgerPic.BackColor = Color.Transparent;
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
                query = string.Format("insert into food (food_id, food_name, price,customer_id) values ('{0}', '{1}', '{2}', '{3}')", IdTxt.Text, Choice, Harga, CustomerTxt.Text );
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
                query = string.Format("update food set food_name = '{0}', price = '{1}', customer_id = '{2}' where food_id='{3}'",Choice, Harga, CustomerTxt.Text, IdTxt.Text);
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

        //Burger
        private void BurgerPic_Click(object sender, EventArgs e)
        {
            PicRefresh();
            this.BurgerPic.BackColor = Color.LightGray;
            Choice = "Burger";
            Harga = 15000;
        }

        //Noodles
        private void NoodlePic_Click(object sender, EventArgs e)
        {
            PicRefresh();
            this.NoodlePic.BackColor = Color.LightGray;
            Choice = "Noodle";
            Harga = 12000;
        }

        //Delete
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("delete from food where food_id={0}", IdTxt.Text);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                Form1_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drinks Drinks = new Drinks();
            Drinks.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = string.Format("Select * from food");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                // Mengatur gaya sel untuk sel-sel dalam DataGridView
                dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Teks di tengah
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Untuk wrap teks dalam sel
                dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 14, FontStyle.Regular);

                // Mengatur warna latar belakang baris genap dan ganjil
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray; // Baris genap
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White; // Baris ganjil

                // Mengatur warna header kolom
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                // Mengatur lebar kolom otomatis sesuai dengan konten
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // Atur tinggi baris agar terlihat lebih rapi
                dataGridView1.RowTemplate.Height = 30;


                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "Food ID";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Food Name";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Price";
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "customer ID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}