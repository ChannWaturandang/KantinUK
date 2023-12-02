namespace Makanan
{
    partial class CustomerControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtUsernameCustomer = new System.Windows.Forms.TextBox();
            this.un = new System.Windows.Forms.Label();
            this.clearCustomer = new System.Windows.Forms.Button();
            this.deleteCustomer = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.txtPhoneCustomer = new System.Windows.Forms.TextBox();
            this.addCustomer = new System.Windows.Forms.Button();
            this.pn = new System.Windows.Forms.Label();
            this.adminLogo = new System.Windows.Forms.Label();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(207, 95);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 30);
            this.txtID.TabIndex = 41;
            // 
            // txtUsernameCustomer
            // 
            this.txtUsernameCustomer.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameCustomer.Location = new System.Drawing.Point(207, 131);
            this.txtUsernameCustomer.Name = "txtUsernameCustomer";
            this.txtUsernameCustomer.Size = new System.Drawing.Size(148, 30);
            this.txtUsernameCustomer.TabIndex = 40;
            // 
            // un
            // 
            this.un.AutoSize = true;
            this.un.BackColor = System.Drawing.Color.Transparent;
            this.un.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un.ForeColor = System.Drawing.Color.Black;
            this.un.Location = new System.Drawing.Point(30, 138);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(99, 21);
            this.un.TabIndex = 39;
            this.un.Text = "Username";
            // 
            // clearCustomer
            // 
            this.clearCustomer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearCustomer.Location = new System.Drawing.Point(553, 151);
            this.clearCustomer.Name = "clearCustomer";
            this.clearCustomer.Size = new System.Drawing.Size(97, 36);
            this.clearCustomer.TabIndex = 38;
            this.clearCustomer.Text = "Clear";
            this.clearCustomer.UseVisualStyleBackColor = true;
            this.clearCustomer.Click += new System.EventHandler(this.clearCustomer_Click);
            // 
            // deleteCustomer
            // 
            this.deleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteCustomer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustomer.ForeColor = System.Drawing.Color.White;
            this.deleteCustomer.Location = new System.Drawing.Point(553, 104);
            this.deleteCustomer.Name = "deleteCustomer";
            this.deleteCustomer.Size = new System.Drawing.Size(97, 36);
            this.deleteCustomer.TabIndex = 37;
            this.deleteCustomer.Text = "Delete";
            this.deleteCustomer.UseVisualStyleBackColor = false;
            this.deleteCustomer.Click += new System.EventHandler(this.deleteCustomer_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomer.Location = new System.Drawing.Point(432, 151);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(97, 36);
            this.updateCustomer.TabIndex = 36;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneCustomer.Location = new System.Drawing.Point(207, 167);
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(148, 30);
            this.txtPhoneCustomer.TabIndex = 35;
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(432, 104);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(97, 36);
            this.addCustomer.TabIndex = 34;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // pn
            // 
            this.pn.AutoSize = true;
            this.pn.BackColor = System.Drawing.Color.Transparent;
            this.pn.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn.ForeColor = System.Drawing.Color.Black;
            this.pn.Location = new System.Drawing.Point(30, 174);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(142, 21);
            this.pn.TabIndex = 33;
            this.pn.Text = "Phone Number";
            // 
            // adminLogo
            // 
            this.adminLogo.AutoSize = true;
            this.adminLogo.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogo.ForeColor = System.Drawing.Color.Teal;
            this.adminLogo.Location = new System.Drawing.Point(26, 25);
            this.adminLogo.Name = "adminLogo";
            this.adminLogo.Size = new System.Drawing.Size(163, 46);
            this.adminLogo.TabIndex = 31;
            this.adminLogo.Text = "Customer";
            // 
            // customerGridView
            // 
            this.customerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.customerGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(34, 218);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.Size = new System.Drawing.Size(854, 436);
            this.customerGridView.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID";
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(929, 681);
            this.Load += new System.EventHandler(this.CustomerControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUsernameCustomer;
        private System.Windows.Forms.Label un;
        private System.Windows.Forms.Button clearCustomer;
        private System.Windows.Forms.Button deleteCustomer;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.TextBox txtPhoneCustomer;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Label pn;
        private System.Windows.Forms.Label adminLogo;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Label label1;
    }
}
