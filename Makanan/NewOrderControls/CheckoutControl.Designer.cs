namespace Makanan
{
    partial class CheckoutControl
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
            this.components = new System.ComponentModel.Container();
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
            this.ReceiptDisplay = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCheckout = new System.Windows.Forms.Button();
            this.displayTable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // adminLogo
            // 
            this.adminLogo.AutoSize = true;
            this.adminLogo.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogo.ForeColor = System.Drawing.Color.Teal;
            this.adminLogo.Location = new System.Drawing.Point(15, 20);
            this.adminLogo.Name = "adminLogo";
            this.adminLogo.Size = new System.Drawing.Size(111, 46);
            this.adminLogo.TabIndex = 40;
            this.adminLogo.Text = "Order";
            // 
            // paymentButton
            // 
            this.paymentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.Location = new System.Drawing.Point(234, 453);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(125, 33);
            this.paymentButton.TabIndex = 39;
            this.paymentButton.Text = "Add Payment";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Input Payment :";
            // 
            // paymentBox
            // 
            this.paymentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentBox.Location = new System.Drawing.Point(56, 462);
            this.paymentBox.Name = "paymentBox";
            this.paymentBox.Size = new System.Drawing.Size(163, 24);
            this.paymentBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Return :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Payment :";
            // 
            // txtReturn
            // 
            this.txtReturn.AutoSize = true;
            this.txtReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturn.Location = new System.Drawing.Point(689, 509);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(70, 18);
            this.txtReturn.TabIndex = 34;
            this.txtReturn.Text = "(Return)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(686, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "----------------------------";
            // 
            // txtPayment
            // 
            this.txtPayment.AutoSize = true;
            this.txtPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(686, 468);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(85, 18);
            this.txtPayment.TabIndex = 32;
            this.txtPayment.Text = "(Payment)";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(686, 442);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(92, 18);
            this.TotalPrice.TabIndex = 31;
            this.TotalPrice.Text = "(totalPrice)";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(621, 442);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(56, 18);
            this.TotalLabel.TabIndex = 30;
            this.TotalLabel.Text = "Total :";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // displayName
            // 
            this.displayName.AutoSize = true;
            this.displayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayName.Location = new System.Drawing.Point(52, 79);
            this.displayName.Name = "displayName";
            this.displayName.Size = new System.Drawing.Size(137, 20);
            this.displayName.TabIndex = 29;
            this.displayName.Text = "Customer Name";
            // 
            // ReceiptDisplay
            // 
            this.ReceiptDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReceiptDisplay.BackgroundColor = System.Drawing.Color.White;
            this.ReceiptDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceiptDisplay.Location = new System.Drawing.Point(56, 113);
            this.ReceiptDisplay.Name = "ReceiptDisplay";
            this.ReceiptDisplay.Size = new System.Drawing.Size(806, 310);
            this.ReceiptDisplay.TabIndex = 25;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Turquoise;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(737, 570);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(125, 39);
            this.btnCheckout.TabIndex = 41;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // displayTable
            // 
            this.displayTable.AutoSize = true;
            this.displayTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTable.Location = new System.Drawing.Point(768, 79);
            this.displayTable.Name = "displayTable";
            this.displayTable.Size = new System.Drawing.Size(94, 20);
            this.displayTable.TabIndex = 42;
            this.displayTable.Text = "Table Num";
            // 
            // CheckoutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.displayTable);
            this.Controls.Add(this.btnCheckout);
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
            this.Controls.Add(this.ReceiptDisplay);
            this.Name = "CheckoutControl";
            this.Size = new System.Drawing.Size(930, 670);
            this.Load += new System.EventHandler(this.OrdersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReceiptDisplay)).EndInit();
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
        private System.Windows.Forms.DataGridView ReceiptDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label displayTable;
    }
}
