using Makanan.NewOrderControls;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Makanan
{
    public partial class CheckoutControl : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        public static DataTable receiptTable = new DataTable();
        private string alamat, query;

        private DateTime today = DateTime.Today;

        public CheckoutControl()
        {
            alamat = "server=localhost; database=kantin; username=root; password=12345;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }

        private void OrdersControl_Load(object sender, EventArgs e)
        {
            timer1.Start();
            TotalPrice.Text = "Rp. -";
            txtPayment.Text = "Rp. -";
            txtReturn.Text = "-";

            InitializeDataGridView();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayName.Text = NewCusControl.cusName + "'s Reciept :";
            displayTable.Text = "Table : " + NewCusControl.tableNum;
            TotalPrice.Text = "Rp." + FoodsControl.total;
        }

        private void InitializeDataGridView()
        {
            receiptTable.Reset();
            // Create a DataTable with columns
            receiptTable.Columns.Add("Item", typeof(string));
            receiptTable.Columns.Add("Price", typeof(string));

            // Set the DataGridView's DataSource to the DataTable
            ReceiptDisplay.DataSource = receiptTable;
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            int payment = Convert.ToInt32(paymentBox.Text);
            txtPayment.Text = "Rp." + paymentBox.Text;

            int payReturn = payment - Convert.ToInt32(FoodsControl.total);
            txtReturn.Text = "Rp." + payReturn.ToString();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            insertSQL();
            AddOrderControl.done = true;
        }

        private void insertSQL()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("insert into `order` (ID, Nama, PhoneNum, TableNum, Items, Total, Payment, Kembalian, Date) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", NewCusControl.id, NewCusControl.cusName, NewCusControl.phoneNum, NewCusControl.tableNum, FoodsControl.combinedString, TotalPrice.Text, txtPayment.Text, txtReturn.Text, today);

                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Successfully checked-out customer's orders");
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
    }
}
