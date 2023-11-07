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
            this.BtnOrder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.Teal;
            this.BtnOrder.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.ForeColor = System.Drawing.Color.White;
            this.BtnOrder.Location = new System.Drawing.Point(21, 28);
            this.BtnOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(280, 68);
            this.BtnOrder.TabIndex = 7;
            this.BtnOrder.Text = "Order Menu";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.BtnOrder);
            this.panel2.Location = new System.Drawing.Point(25, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 129);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(377, 163);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Canteen";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Panel panel2;
    }
}

