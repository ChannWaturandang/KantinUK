namespace Makanan
{
    partial class OrdersControl
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
            this.adminLogo = new System.Windows.Forms.Label();
            this.paymentButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReturn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.displayName = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
            this.customerName = new System.Windows.Forms.Label();
            this.customerBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminLogo
            // 
            this.adminLogo.AutoSize = true;
            this.adminLogo.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogo.ForeColor = System.Drawing.Color.Teal;
            this.adminLogo.Location = new System.Drawing.Point(60, 56);
            this.adminLogo.Name = "adminLogo";
            this.adminLogo.Size = new System.Drawing.Size(111, 46);
            this.adminLogo.TabIndex = 40;
            this.adminLogo.Text = "Order";
            // 
            // paymentButton
            // 
            this.paymentButton.Location = new System.Drawing.Point(329, 534);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(115, 24);
            this.paymentButton.TabIndex = 39;
            this.paymentButton.Text = "Add Payment";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 522);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Input Payment :";
            // 
            // paymentBox
            // 
            this.paymentBox.Location = new System.Drawing.Point(98, 538);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new System.Drawing.Size(163, 20);
            this.paymentBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Return :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(598, 564);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Payment :";
            // 
            // txtReturn
            // 
            this.txtReturn.AutoSize = true;
            this.txtReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturn.Location = new System.Drawing.Point(695, 605);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(160, 20);
            this.txtReturn.TabIndex = 34;
            this.txtReturn.Text = "Temporary(Return)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(692, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "----------------------------";
            // 
            // txtPayment
            // 
            this.txtPayment.AutoSize = true;
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(692, 564);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(174, 20);
            this.txtPayment.TabIndex = 32;
            this.txtPayment.Text = "Temporary(Payment)";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(692, 538);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(171, 20);
            this.TotalPrice.TabIndex = 31;
            this.TotalPrice.Text = "Temorary(totalPrice)";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(627, 538);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(59, 20);
            this.TotalLabel.TabIndex = 30;
            this.TotalLabel.Text = "Total :";
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayName.Location = new System.Drawing.Point(94, 167);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(225, 20);
            this.displayName.TabIndex = 29;
            this.displayName.Text = "Temporary(customerName)";
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(329, 130);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(115, 24);
            this.checkButton.TabIndex = 28;
            this.checkButton.Text = "Check Orders";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(98, 115);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(53, 13);
            this.customerName.TabIndex = 27;
            this.customerName.Text = "Order ID :";
            // 
            // customerBox
            // 
            this.customerBox.Location = new System.Drawing.Point(98, 134);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(163, 20);
            this.customerBox.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 314);
            this.dataGridView1.TabIndex = 25;
            // 
            // OrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminLogo);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.paymentBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.displayName);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrdersControl";
            this.Size = new System.Drawing.Size(929, 681);
            this.Load += new System.EventHandler(this.OrdersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminLogo;
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox paymentBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtPayment;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label displayName;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
