using CrystalDecisions.CrystalReports.Engine;
using Makanan.NewOrderControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace Makanan
{
    public partial class FoodsControl : UserControl
    {
        private DataTable orderTable = new DataTable();

        string orderPrice, foodChoice, Order;
        public static decimal total = 0;
        decimal price, amountLalapan, amountGeprek, amountNasiGoreng, amountMieKuah, amountMieCakalang, amountAir, amountNutri;

        public static List<string> OrderList = new List<string>();
        public static string combinedString;
        public FoodsControl()
        {
            this.Font = new Font("Times New Roman", 14, FontStyle.Regular);
            InitializeComponent();
        }

        private void FoodsControl_Load(object sender, EventArgs e)
        { 
            timer1.Start();
            InitializeDataGridView();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Customer_Lbl.Text = NewCusControl.cusName + "'s Orders :";
        }

        private void InitializeDataGridView()
        {
            orderTable.Reset();
            // Create a orderTable with columns
            orderTable.Columns.Add("Item", typeof(string));
            orderTable.Columns.Add("Price", typeof(string));

            // Set the DataGridView's DataSource to the orderTable
            OrderDisplay.DataSource = orderTable;
        }

        //------Buttons------\\
        private void btnFoodFilter_Click(object sender, EventArgs e)
        {
            //Food Filter Click
            this.btnFoodFilter.BackColor = Color.Silver;
            this.btnDrinkFilter.BackColor = Color.White;
            Searchbox.Text = "";

            this.mieCakalang.Show();
            this.mieKuah.Show();
            this.ayamGeprek.Show();
            this.ayamLalapan.Show();
            this.nasiGoreng.Show();

            this.airMineral.Hide();
            this.nutrisari.Hide();
        }

        private void btnDrinkFilter_Click(object sender, EventArgs e)
        {
            //Drink Filter Click
            this.btnDrinkFilter.BackColor = Color.Silver;
            this.btnFoodFilter.BackColor = Color.White;
            Searchbox.Text = "";

            this.mieCakalang.Hide();
            this.mieKuah.Hide();
            this.ayamGeprek.Hide();
            this.ayamLalapan.Hide();
            this.nasiGoreng.Hide();

            this.airMineral.Show();
            this.nutrisari.Show();
            
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            PicRefreshFood();
        }

        private void Searchbox_TextChanged(object sender, EventArgs e)
        {
            btnFoodFilter.BackColor = Color.White;
            btnDrinkFilter.BackColor = Color.White;
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

        private void ListInsert()
        {
            //Foods
            if (amountLalapan > 0)
            {
                price = 18000 * amountLalapan;
                orderPrice = "Rp." + price;
                foodChoice = "Ayam Lalapan x" + amountLalapan;
                orderTable.Rows.Add(foodChoice, orderPrice);
                CheckoutControl.receiptTable.Rows.Add(foodChoice, orderPrice);

                total += price;
                Order = string.Format("{0} {1}", foodChoice, orderPrice);
                OrderList.Add(Order);
            }
            if (amountGeprek > 0)
            {
                price = 15000 * amountGeprek;
                orderPrice = "Rp." + price;
                foodChoice = "Ayam Geprek x" + amountGeprek;
                orderTable.Rows.Add(foodChoice, orderPrice);
                CheckoutControl.receiptTable.Rows.Add(foodChoice, orderPrice);

                total += price;
                Order = string.Format("{0} {1}", foodChoice, orderPrice);
                OrderList.Add(Order);
            }
            if (amountNasiGoreng > 0)
            {
                price = 15000 * amountNasiGoreng;
                orderPrice = "Rp." + price;
                foodChoice = "Nasi Goreng x" + amountNasiGoreng;
                orderTable.Rows.Add(foodChoice, orderPrice);
                CheckoutControl.receiptTable.Rows.Add(foodChoice, orderPrice);

                total += price;
                Order = string.Format("{0} {1}", foodChoice, orderPrice);
                OrderList.Add(Order);
            }
            if (amountMieKuah > 0)
            {
                price = 10000 * amountMieKuah;
                orderPrice = "Rp." + price;
                foodChoice = "Mie Kuah x" + amountMieKuah;
                orderTable.Rows.Add(foodChoice, orderPrice);
                CheckoutControl.receiptTable.Rows.Add(foodChoice, orderPrice);

                total += price;
                Order = string.Format("{0} {1}", foodChoice, orderPrice);
                OrderList.Add(Order);
            }
            if (amountMieCakalang > 0)
            {
                price = 12000 * amountMieCakalang;
                orderPrice = "Rp." + price;
                foodChoice = "Mie Cakalang x" + amountMieCakalang;
                orderTable.Rows.Add(foodChoice, orderPrice);
                CheckoutControl.receiptTable.Rows.Add(foodChoice, orderPrice);

                total += price;
                Order = string.Format("{0} {1}", foodChoice, orderPrice);
                OrderList.Add(Order);
            }

            //Drinks
            if (amountAir > 0)
            {
                price = 5000 * amountAir;
                orderPrice = "Rp." + price;
                foodChoice = "Air Mineral x" + amountAir;
                orderTable.Rows.Add(foodChoice, orderPrice);
                CheckoutControl.receiptTable.Rows.Add(foodChoice, orderPrice);

                total += price;
                Order = string.Format("{0} {1}", foodChoice, orderPrice);
                OrderList.Add(Order);
            }
            if (amountNutri > 0)
            {
                price = 5000 * amountNutri;
                orderPrice = "Rp." + price;
                foodChoice = "Nutri Sari x" + amountNutri;
                orderTable.Rows.Add(foodChoice, orderPrice);
                CheckoutControl.receiptTable.Rows.Add(foodChoice, orderPrice);

                total += price;
                Order = string.Format("{0} {1}", foodChoice, orderPrice);
                OrderList.Add(Order);
            }
        }

        private void ClearTable_Click(object sender, EventArgs e)
        {
            orderTable.Clear();
            CheckoutControl.receiptTable.Clear();
            OrderList.Clear();
            total = 0;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            ListInsert();
            combinedString = string.Join(" + ", OrderList);
            PicRefreshFood();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            AddOrderControl.movetoCheckout = true;
        }

        //------NumBox------\\
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
