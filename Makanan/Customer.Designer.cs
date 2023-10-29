namespace Makanan
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTables = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnFoods = new System.Windows.Forms.Button();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.adminLogo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.addCustomer = new System.Windows.Forms.Button();
            this.customerID = new System.Windows.Forms.TextBox();
            this.customerFirst = new System.Windows.Forms.TextBox();
            this.customerNum = new System.Windows.Forms.TextBox();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.CustomerLast = new System.Windows.Forms.TextBox();
            this.LastLabel = new System.Windows.Forms.Label();
            this.TableBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTables);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnDrinks);
            this.panel1.Controls.Add(this.btnFoods);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 594);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(34, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "___________";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(85, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin";
            // 
            // btnTables
            // 
            this.btnTables.BackColor = System.Drawing.Color.Teal;
            this.btnTables.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTables.ForeColor = System.Drawing.Color.White;
            this.btnTables.Location = new System.Drawing.Point(34, 360);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(187, 44);
            this.btnTables.TabIndex = 3;
            this.btnTables.Text = "Tables";
            this.btnTables.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnCustomer.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(34, 165);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(187, 44);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.BackColor = System.Drawing.Color.Teal;
            this.btnDrinks.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrinks.ForeColor = System.Drawing.Color.White;
            this.btnDrinks.Location = new System.Drawing.Point(34, 295);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(187, 44);
            this.btnDrinks.TabIndex = 1;
            this.btnDrinks.Text = "Drinks";
            this.btnDrinks.UseVisualStyleBackColor = false;
            // 
            // btnFoods
            // 
            this.btnFoods.BackColor = System.Drawing.Color.Teal;
            this.btnFoods.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoods.ForeColor = System.Drawing.Color.White;
            this.btnFoods.Location = new System.Drawing.Point(34, 230);
            this.btnFoods.Name = "btnFoods";
            this.btnFoods.Size = new System.Drawing.Size(187, 44);
            this.btnFoods.TabIndex = 0;
            this.btnFoods.Text = "Foods";
            this.btnFoods.UseVisualStyleBackColor = false;
            this.btnFoods.Click += new System.EventHandler(this.btnFoods_Click);
            // 
            // customerGridView
            // 
            this.customerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(681, 125);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.Size = new System.Drawing.Size(419, 191);
            this.customerGridView.TabIndex = 7;
            this.customerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(286, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // adminLogo
            // 
            this.adminLogo.AutoSize = true;
            this.adminLogo.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogo.ForeColor = System.Drawing.Color.Teal;
            this.adminLogo.Location = new System.Drawing.Point(282, 27);
            this.adminLogo.Name = "adminLogo";
            this.adminLogo.Size = new System.Drawing.Size(137, 46);
            this.adminLogo.TabIndex = 7;
            this.adminLogo.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(286, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(286, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Nunber";
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.BackColor = System.Drawing.Color.Transparent;
            this.FirstLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstLabel.ForeColor = System.Drawing.Color.Black;
            this.FirstLabel.Location = new System.Drawing.Point(286, 170);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(105, 21);
            this.FirstLabel.TabIndex = 13;
            this.FirstLabel.Text = "First Name";
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(368, 427);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(97, 36);
            this.addCustomer.TabIndex = 16;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // customerID
            // 
            this.customerID.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.Location = new System.Drawing.Point(463, 125);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(148, 26);
            this.customerID.TabIndex = 17;
            this.customerID.TextChanged += new System.EventHandler(this.customerID_TextChanged);
            // 
            // customerFirst
            // 
            this.customerFirst.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFirst.Location = new System.Drawing.Point(463, 165);
            this.customerFirst.Name = "customerFirst";
            this.customerFirst.Size = new System.Drawing.Size(148, 26);
            this.customerFirst.TabIndex = 18;
            // 
            // customerNum
            // 
            this.customerNum.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNum.Location = new System.Drawing.Point(463, 244);
            this.customerNum.Name = "customerNum";
            this.customerNum.Size = new System.Drawing.Size(148, 26);
            this.customerNum.TabIndex = 19;
            // 
            // customerAddress
            // 
            this.customerAddress.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddress.Location = new System.Drawing.Point(463, 280);
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(148, 26);
            this.customerAddress.TabIndex = 20;
            // 
            // updateCustomer
            // 
            this.updateCustomer.Location = new System.Drawing.Point(496, 427);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(97, 36);
            this.updateCustomer.TabIndex = 21;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.Location = new System.Drawing.Point(630, 427);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(97, 36);
            this.deleteCustomer.TabIndex = 22;
            this.deleteCustomer.Text = "Delete";
            this.deleteCustomer.UseVisualStyleBackColor = true;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // CustomerLast
            // 
            this.CustomerLast.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLast.Location = new System.Drawing.Point(463, 205);
            this.CustomerLast.Name = "CustomerLast";
            this.CustomerLast.Size = new System.Drawing.Size(148, 26);
            this.CustomerLast.TabIndex = 24;
            // 
            // LastLabel
            // 
            this.LastLabel.AutoSize = true;
            this.LastLabel.BackColor = System.Drawing.Color.Transparent;
            this.LastLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastLabel.ForeColor = System.Drawing.Color.Black;
            this.LastLabel.Location = new System.Drawing.Point(286, 210);
            this.LastLabel.Name = "LastLabel";
            this.LastLabel.Size = new System.Drawing.Size(101, 21);
            this.LastLabel.TabIndex = 23;
            this.LastLabel.Text = "Last Name";
            // 
            // TableBox
            // 
            this.TableBox.ForeColor = System.Drawing.Color.Black;
            this.TableBox.FormattingEnabled = true;
            this.TableBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.TableBox.Location = new System.Drawing.Point(463, 319);
            this.TableBox.Name = "TableBox";
            this.TableBox.Size = new System.Drawing.Size(148, 21);
            this.TableBox.TabIndex = 25;
            this.TableBox.Text = "--Choose Table Number--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(286, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Table";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 594);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TableBox);
            this.Controls.Add(this.CustomerLast);
            this.Controls.Add(this.LastLabel);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.customerNum);
            this.Controls.Add(this.customerFirst);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.FirstLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adminLogo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Customer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnFoods;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Label adminLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.TextBox customerFirst;
        private System.Windows.Forms.TextBox customerNum;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.TextBox CustomerLast;
        private System.Windows.Forms.Label LastLabel;
        private System.Windows.Forms.ComboBox TableBox;
        private System.Windows.Forms.Label label4;
    }
}