﻿namespace Makanan
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnTables = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnFoods = new System.Windows.Forms.Button();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.adminLogo = new System.Windows.Forms.Label();
            this.pn = new System.Windows.Forms.Label();
            this.addCustomer = new System.Windows.Forms.Button();
            this.txtPhoneCustomer = new System.Windows.Forms.TextBox();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.clearCustomer = new System.Windows.Forms.Button();
            this.txtUsernameCustomer = new System.Windows.Forms.TextBox();
            this.un = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnTables);
            this.panel1.Controls.Add(this.btnCustomer);
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
            this.button1.Location = new System.Drawing.Point(34, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(78, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kantin";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnTables
            // 
            this.btnTables.BackColor = System.Drawing.Color.Teal;
            this.btnTables.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTables.ForeColor = System.Drawing.Color.White;
            this.btnTables.Location = new System.Drawing.Point(34, 294);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(187, 44);
            this.btnTables.TabIndex = 3;
            this.btnTables.Text = "Tables";
            this.btnTables.UseVisualStyleBackColor = false;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.Teal;
            this.btnCustomer.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.LightYellow;
            this.btnCustomer.Location = new System.Drawing.Point(34, 165);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(187, 44);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
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
            this.btnFoods.Text = "Menu";
            this.btnFoods.UseVisualStyleBackColor = false;
            this.btnFoods.Click += new System.EventHandler(this.btnFoods_Click);
            // 
            // customerGridView
            // 
            this.customerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(285, 230);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.Size = new System.Drawing.Size(815, 330);
            this.customerGridView.TabIndex = 7;
            this.customerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adminLogo
            // 
            this.adminLogo.AutoSize = true;
            this.adminLogo.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogo.ForeColor = System.Drawing.Color.Teal;
            this.adminLogo.Location = new System.Drawing.Point(277, 37);
            this.adminLogo.Name = "adminLogo";
            this.adminLogo.Size = new System.Drawing.Size(163, 46);
            this.adminLogo.TabIndex = 7;
            this.adminLogo.Text = "Customer";
            // 
            // pn
            // 
            this.pn.AutoSize = true;
            this.pn.BackColor = System.Drawing.Color.Transparent;
            this.pn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn.ForeColor = System.Drawing.Color.Black;
            this.pn.Location = new System.Drawing.Point(281, 186);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(142, 21);
            this.pn.TabIndex = 12;
            this.pn.Text = "Phone Number";
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(683, 116);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(97, 36);
            this.addCustomer.TabIndex = 16;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneCustomer.Location = new System.Drawing.Point(458, 179);
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(148, 30);
            this.txtPhoneCustomer.TabIndex = 19;
            // 
            // updateCustomer
            // 
            this.updateCustomer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomer.Location = new System.Drawing.Point(683, 163);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(97, 36);
            this.updateCustomer.TabIndex = 21;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteCustomer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomer.ForeColor = System.Drawing.Color.White;
            this.deleteCustomer.Location = new System.Drawing.Point(804, 116);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(97, 36);
            this.deleteCustomer.TabIndex = 22;
            this.deleteCustomer.Text = "Delete";
            this.deleteCustomer.UseVisualStyleBackColor = false;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // clearCustomer
            // 
            this.clearCustomer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCustomer.Location = new System.Drawing.Point(804, 163);
            this.clearCustomer.Name = "clearCustomer";
            this.clearCustomer.Size = new System.Drawing.Size(97, 36);
            this.clearCustomer.TabIndex = 27;
            this.clearCustomer.Text = "Clear";
            this.clearCustomer.UseVisualStyleBackColor = true;
            this.clearCustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtUsernameCustomer
            // 
            this.txtUsernameCustomer.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameCustomer.Location = new System.Drawing.Point(458, 143);
            this.txtUsernameCustomer.Name = "txtUsernameCustomer";
            this.txtUsernameCustomer.Size = new System.Drawing.Size(148, 30);
            this.txtUsernameCustomer.TabIndex = 29;
            // 
            // un
            // 
            this.un.AutoSize = true;
            this.un.BackColor = System.Drawing.Color.Transparent;
            this.un.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un.ForeColor = System.Drawing.Color.Black;
            this.un.Location = new System.Drawing.Point(281, 150);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(99, 21);
            this.un.TabIndex = 28;
            this.un.Text = "Username";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(458, 107);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 30);
            this.txtID.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(281, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 594);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtUsernameCustomer);
            this.Controls.Add(this.un);
            this.Controls.Add(this.clearCustomer);
            this.Controls.Add(this.deleteCustomer);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.txtPhoneCustomer);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.adminLogo);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnFoods;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Label adminLogo;
        private System.Windows.Forms.Label pn;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.TextBox txtPhoneCustomer;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button clearCustomer;
        private System.Windows.Forms.TextBox txtUsernameCustomer;
        private System.Windows.Forms.Label un;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}