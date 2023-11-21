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
    public partial class FoodsControl : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        string orderPrice, choiceFood, choiceDrink;
        decimal price;
        decimal amountLalapan, amountGeprek, amountNasiGoreng, amountMieKuah, amountMieCakalang, amountAir, amountNutri;
        List<string> Orders = new List<string>();
        public FoodsControl()
        {
            alamat = "server=localhost; database=Kantin; username=root; password=12345;";
            koneksi = new MySqlConnection(alamat);
            this.Font = new Font("Times New Roman", 14, FontStyle.Regular);

            InitializeComponent();
        }

        private void FoodsControl_Load(object sender, EventArgs e)
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
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[2].HeaderText = "Table Num";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Food Click
            this.button2.BackColor = Color.Silver;
            this.button3.BackColor = Color.White;
            Searchbox.Text = "";

            this.mieCakalang.Show();
            this.mieKuah.Show();
            this.ayamGeprek.Show();
            this.ayamLalapan.Show();
            this.nasiGoreng.Show();
            this.airMineral.Hide();
            this.nutrisari.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Drink Click
            this.button3.BackColor = Color.Silver;
            this.button2.BackColor = Color.White;
            Searchbox.Text = "";

            this.mieCakalang.Hide();
            this.mieKuah.Hide();
            this.ayamGeprek.Hide();
            this.ayamLalapan.Hide();
            this.nasiGoreng.Hide();
            this.airMineral.Show();
            this.nutrisari.Show();
            
        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            foreach (Control item in FoodDisplay.Controls)
            {
                item.Show();
                string search = Searchbox.Text.Replace(" ", "");
                string itemName = Convert.ToString(TypeDescriptor.GetProperties(item)["Name"].GetValue(item)).ToLower();

                bool found = itemName.Contains(search);

                if (found == false)
                {
                    item.Hide();
                }
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            PicRefreshFood();
            Orders.Clear();
        }

        public void PicRefreshFood()
        {
            Searchbox.Text = "";
            foreach (Control item in FoodDisplay.Controls)
            {
                item.Show();
                foreach (Control innerControl in item.Controls)
                {
                    if (innerControl is NumericUpDown numericUpDown)
                    {
                        numericUpDown.Value = 0;
                    }
                }
            }
        }

        private void sqlUpdate()
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
                    FoodsControl_Load(null, null);
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

        private void ListInsert()
        {
            //Foods
            if (amountLalapan > 0)
            {
                price = 18000 * amountLalapan;
                orderPrice = "Rp." + price;
                choiceFood = string.Format("Ayam Lalapan x{0}, {1}", amountLalapan, orderPrice);
                Orders.Add(choiceFood);
            }
            if (amountGeprek > 0)
            {
                price = 15000 * amountGeprek;
                orderPrice = "Rp." + price;
                choiceFood = string.Format("Ayam Geprek x{0}, {1}", amountGeprek, orderPrice);
                Orders.Add(choiceFood);
            }
            if (amountNasiGoreng > 0)
            {
                price = 15000 * amountNasiGoreng;
                orderPrice = "Rp." + price;
                choiceFood = string.Format("Nasi Goreng x{0}, {1}", amountNasiGoreng, orderPrice);
                Orders.Add(choiceFood);
            }
            if (amountMieKuah > 0)
            {
                price = 10000 * amountMieKuah;
                orderPrice = "Rp." + price;
                choiceFood = string.Format("Mie Kuah x{0}, {1}", amountMieKuah, orderPrice);
                Orders.Add(choiceFood);
            }
            if (amountMieCakalang > 0)
            {
                price = 12000 * amountMieCakalang;
                orderPrice = "Rp." + price;
                choiceFood = string.Format("Mie Cakalang x{0}, {1}", amountMieCakalang, orderPrice);
                Orders.Add(choiceFood);
            }

            //Drinks
            if (amountAir > 0)
            {
                price = 5000 * amountAir;
                orderPrice = "Rp." + price;
                choiceFood = string.Format("Air Mineral x{0}, {1}", amountAir, orderPrice);
                Orders.Add(choiceFood);
            }
            if (amountNutri > 0)
            {
                price = 5000 * amountNutri;
                orderPrice = "Rp." + price;
                choiceFood = string.Format("Nutri Sari x{0}, {1}", amountNutri, orderPrice);
                Orders.Add(choiceFood);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ListInsert();
            sqlUpdate();

            PicRefreshFood();
            Orders.Clear();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
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
                    FoodsControl_Load(null, null);
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

        private void ayamlalapanNum_ValueChanged(object sender, EventArgs e)
        {
            amountLalapan = ayamlalapanNum.Value;
            if (amountLalapan == 0)
            {
                this.ayamLalapan.BackColor = Color.Transparent;
            }
            else if (amountLalapan > 0)
            {
                this.ayamLalapan.BackColor = Color.LightYellow;
            }
        }

        private void ayamgeprekNum_ValueChanged(object sender, EventArgs e)
        {
            amountGeprek = ayamgeprekNum.Value;
            if (amountGeprek == 0)
            {
                this.ayamGeprek.BackColor = Color.Transparent;
            }
            else if (amountGeprek > 0)
            {
                this.ayamGeprek.BackColor = Color.LightYellow;
            }
        }

        private void miecakalangNum_ValueChanged(object sender, EventArgs e)
        {
            amountMieCakalang = miecakalangNum.Value;
            if (amountMieCakalang == 0)
            {
                this.mieCakalang.BackColor = Color.Transparent;
            }
            else if (amountMieCakalang > 0)
            {
                this.mieCakalang.BackColor = Color.LightYellow;
            }
        }

        private void miekuahNum_ValueChanged(object sender, EventArgs e)
        {
            amountMieKuah = miekuahNum.Value;
            if (amountMieKuah == 0)
            {
                this.mieKuah.BackColor = Color.Transparent;
            }
            else if (amountMieKuah > 0)
            {
                this.mieKuah.BackColor = Color.LightYellow;
            }
        }

        private void nasigorengNum_ValueChanged(object sender, EventArgs e)
        {
            amountNasiGoreng = nasigorengNum.Value;
            if (amountNasiGoreng == 0)
            {
                this.nasiGoreng.BackColor = Color.Transparent;
            }
            else if (amountNasiGoreng > 0)
            {
                this.nasiGoreng.BackColor = Color.LightYellow;
            }
        }

        private void airNum_ValueChanged(object sender, EventArgs e)
        {
            amountAir = airNum.Value;
            if (amountAir == 0)
            {
                this.airMineral.BackColor = Color.Transparent;
            }
            else if (amountAir > 0)
            {
                this.airMineral.BackColor = Color.LightYellow;
            }
        }

        private void nutriNum_ValueChanged(object sender, EventArgs e)
        {
            amountNutri = nutriNum.Value;
            if (amountNutri == 0)
            {
                this.nutrisari.BackColor = Color.Transparent;
            }
            else if (amountNutri > 0)
            {
                this.nutrisari.BackColor = Color.LightYellow;
            }
        }
    }
}
