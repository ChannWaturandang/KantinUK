namespace SystemCanteenUnklab
{
    partial class Form1
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnPayment = new System.Windows.Forms.Button();
            this.BtnLabour = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.BtnBack);
            this.panel2.Controls.Add(this.BtnPayment);
            this.panel2.Controls.Add(this.BtnLabour);
            this.panel2.Controls.Add(this.BtnOrder);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-6, -6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 716);
            this.panel2.TabIndex = 9;
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.Teal;
            this.BtnBack.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBack.ForeColor = System.Drawing.Color.White;
            this.BtnBack.Location = new System.Drawing.Point(23, 574);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(127, 43);
            this.BtnBack.TabIndex = 24;
            this.BtnBack.Text = "Log Out";
            this.BtnBack.UseVisualStyleBackColor = false;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnPayment
            // 
            this.BtnPayment.BackColor = System.Drawing.Color.Teal;
            this.BtnPayment.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayment.ForeColor = System.Drawing.Color.White;
            this.BtnPayment.Location = new System.Drawing.Point(23, 416);
            this.BtnPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPayment.Name = "BtnPayment";
            this.BtnPayment.Size = new System.Drawing.Size(280, 68);
            this.BtnPayment.TabIndex = 9;
            this.BtnPayment.Text = "Payment";
            this.BtnPayment.UseVisualStyleBackColor = false;
            // 
            // BtnLabour
            // 
            this.BtnLabour.BackColor = System.Drawing.Color.Teal;
            this.BtnLabour.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLabour.ForeColor = System.Drawing.Color.White;
            this.BtnLabour.Location = new System.Drawing.Point(23, 308);
            this.BtnLabour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnLabour.Name = "BtnLabour";
            this.BtnLabour.Size = new System.Drawing.Size(280, 68);
            this.BtnLabour.TabIndex = 8;
            this.BtnLabour.Text = "Student Labour";
            this.BtnLabour.UseVisualStyleBackColor = false;
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.Teal;
            this.BtnOrder.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.ForeColor = System.Drawing.Color.White;
            this.BtnOrder.Location = new System.Drawing.Point(23, 195);
            this.BtnOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(280, 68);
            this.BtnOrder.TabIndex = 7;
            this.BtnOrder.Text = "Order Menu";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(324, 56);
            this.label2.TabIndex = 6;
            this.label2.Text = "____________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 16F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(51, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin Canteen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(915, 641);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Canteen";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPayment;
        private System.Windows.Forms.Button BtnLabour;
        private System.Windows.Forms.Button BtnBack;
    }
}

