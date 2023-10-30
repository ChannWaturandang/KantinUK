namespace Makanan
{
    partial class Foods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Foods));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTables = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnFoods = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.ID_Lbl = new System.Windows.Forms.Label();
            this.NoodlePic = new System.Windows.Forms.PictureBox();
            this.FoodDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.BurgerPic = new System.Windows.Forms.PictureBox();
            this.Searchbox = new System.Windows.Forms.TextBox();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Customer_Lbl = new System.Windows.Forms.Label();
            this.CustomerTxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoodlePic)).BeginInit();
            this.FoodDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BurgerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnDrinks.Click += new System.EventHandler(this.btnDrinks_Click);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Foods";
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(304, 78);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(97, 36);
            this.Addbtn.TabIndex = 8;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(407, 78);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(97, 36);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(510, 78);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(97, 36);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(652, 84);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(122, 20);
            this.IdTxt.TabIndex = 12;
            this.IdTxt.TextChanged += new System.EventHandler(this.IdTxt_TextChanged);
            // 
            // ID_Lbl
            // 
            this.ID_Lbl.AutoSize = true;
            this.ID_Lbl.Location = new System.Drawing.Point(649, 68);
            this.ID_Lbl.Name = "ID_Lbl";
            this.ID_Lbl.Size = new System.Drawing.Size(51, 13);
            this.ID_Lbl.TabIndex = 13;
            this.ID_Lbl.Text = "Food ID :";
            // 
            // NoodlePic
            // 
            this.NoodlePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoodlePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoodlePic.Image = ((System.Drawing.Image)(resources.GetObject("NoodlePic.Image")));
            this.NoodlePic.Location = new System.Drawing.Point(3, 3);
            this.NoodlePic.Name = "NoodlePic";
            this.NoodlePic.Size = new System.Drawing.Size(120, 120);
            this.NoodlePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NoodlePic.TabIndex = 14;
            this.NoodlePic.TabStop = false;
            this.NoodlePic.Tag = "noodle";
            this.NoodlePic.Click += new System.EventHandler(this.NoodlePic_Click);
            // 
            // FoodDisplay
            // 
            this.FoodDisplay.Controls.Add(this.NoodlePic);
            this.FoodDisplay.Controls.Add(this.BurgerPic);
            this.FoodDisplay.Location = new System.Drawing.Point(280, 173);
            this.FoodDisplay.Name = "FoodDisplay";
            this.FoodDisplay.Size = new System.Drawing.Size(540, 409);
            this.FoodDisplay.TabIndex = 15;
            this.FoodDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // BurgerPic
            // 
            this.BurgerPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BurgerPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BurgerPic.Image = ((System.Drawing.Image)(resources.GetObject("BurgerPic.Image")));
            this.BurgerPic.Location = new System.Drawing.Point(129, 3);
            this.BurgerPic.Name = "BurgerPic";
            this.BurgerPic.Size = new System.Drawing.Size(120, 120);
            this.BurgerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BurgerPic.TabIndex = 18;
            this.BurgerPic.TabStop = false;
            this.BurgerPic.Tag = "burger";
            this.BurgerPic.Click += new System.EventHandler(this.BurgerPic_Click);
            // 
            // Searchbox
            // 
            this.Searchbox.Location = new System.Drawing.Point(304, 147);
            this.Searchbox.Name = "Searchbox";
            this.Searchbox.Size = new System.Drawing.Size(100, 20);
            this.Searchbox.TabIndex = 16;
            this.Searchbox.TextChanged += new System.EventHandler(this.Searchbox_TextChanged);
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.Location = new System.Drawing.Point(301, 131);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(47, 13);
            this.Searchlabel.TabIndex = 17;
            this.Searchlabel.Text = "Search :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(826, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Customer_Lbl
            // 
            this.Customer_Lbl.AutoSize = true;
            this.Customer_Lbl.Location = new System.Drawing.Point(650, 112);
            this.Customer_Lbl.Name = "Customer_Lbl";
            this.Customer_Lbl.Size = new System.Drawing.Size(71, 13);
            this.Customer_Lbl.TabIndex = 19;
            this.Customer_Lbl.Text = "Customer ID :";
            // 
            // CustomerTxt
            // 
            this.CustomerTxt.Location = new System.Drawing.Point(652, 129);
            this.CustomerTxt.Name = "CustomerTxt";
            this.CustomerTxt.Size = new System.Drawing.Size(122, 20);
            this.CustomerTxt.TabIndex = 20;
            // 
            // Foods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 594);
            this.Controls.Add(this.CustomerTxt);
            this.Controls.Add(this.Customer_Lbl);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.Searchbox);
            this.Controls.Add(this.FoodDisplay);
            this.Controls.Add(this.ID_Lbl);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Foods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoodlePic)).EndInit();
            this.FoodDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BurgerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnFoods;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label ID_Lbl;
        private System.Windows.Forms.PictureBox NoodlePic;
        private System.Windows.Forms.FlowLayoutPanel FoodDisplay;
        private System.Windows.Forms.TextBox Searchbox;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.PictureBox BurgerPic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Customer_Lbl;
        private System.Windows.Forms.TextBox CustomerTxt;
    }
}

