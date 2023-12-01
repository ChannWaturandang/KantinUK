namespace Makanan.NewOrderControls
{
    partial class NewCusControl
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
            this.Card = new System.Windows.Forms.Panel();
            this.TableBox = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tn = new System.Windows.Forms.Label();
            this.addCustomer = new System.Windows.Forms.Button();
            this.pn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneCustomer = new System.Windows.Forms.TextBox();
            this.un = new System.Windows.Forms.Label();
            this.txtUsernameCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Card.SuspendLayout();
            this.SuspendLayout();
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.White;
            this.Card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card.Controls.Add(this.TableBox);
            this.Card.Controls.Add(this.txtID);
            this.Card.Controls.Add(this.tn);
            this.Card.Controls.Add(this.addCustomer);
            this.Card.Controls.Add(this.pn);
            this.Card.Controls.Add(this.label1);
            this.Card.Controls.Add(this.txtPhoneCustomer);
            this.Card.Controls.Add(this.un);
            this.Card.Controls.Add(this.txtUsernameCustomer);
            this.Card.Location = new System.Drawing.Point(288, 150);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(356, 353);
            this.Card.TabIndex = 47;
            // 
            // TableBox
            // 
            this.TableBox.BackColor = System.Drawing.Color.LightGray;
            this.TableBox.FormattingEnabled = true;
            this.TableBox.Items.AddRange(new object[] {
            "A1",
            "A2",
            "A3",
            "B1",
            "B2",
            "B3",
            "C1",
            "C2",
            "C3",
            "D1",
            "D2",
            "D3",
            "E1",
            "E2",
            "E3",
            "E4",
            "E5"});
            this.TableBox.Location = new System.Drawing.Point(192, 188);
            this.TableBox.Name = "TableBox";
            this.TableBox.Size = new System.Drawing.Size(148, 21);
            this.TableBox.TabIndex = 44;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.LightGray;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(192, 76);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(148, 24);
            this.txtID.TabIndex = 41;
            // 
            // tn
            // 
            this.tn.AutoSize = true;
            this.tn.BackColor = System.Drawing.Color.Transparent;
            this.tn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn.ForeColor = System.Drawing.Color.Black;
            this.tn.Location = new System.Drawing.Point(15, 187);
            this.tn.Name = "tn";
            this.tn.Size = new System.Drawing.Size(113, 18);
            this.tn.TabIndex = 43;
            this.tn.Text = "Table Number";
            // 
            // addCustomer
            // 
            this.addCustomer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(243, 298);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(97, 36);
            this.addCustomer.TabIndex = 34;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = false;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // pn
            // 
            this.pn.AutoSize = true;
            this.pn.BackColor = System.Drawing.Color.Transparent;
            this.pn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn.ForeColor = System.Drawing.Color.Black;
            this.pn.Location = new System.Drawing.Point(15, 155);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(120, 18);
            this.pn.TabIndex = 33;
            this.pn.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID";
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.BackColor = System.Drawing.Color.LightGray;
            this.txtPhoneCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneCustomer.Location = new System.Drawing.Point(192, 149);
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(148, 24);
            this.txtPhoneCustomer.TabIndex = 35;
            // 
            // un
            // 
            this.un.AutoSize = true;
            this.un.BackColor = System.Drawing.Color.Transparent;
            this.un.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un.ForeColor = System.Drawing.Color.Black;
            this.un.Location = new System.Drawing.Point(15, 119);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(85, 18);
            this.un.TabIndex = 39;
            this.un.Text = "Username";
            // 
            // txtUsernameCustomer
            // 
            this.txtUsernameCustomer.BackColor = System.Drawing.Color.LightGray;
            this.txtUsernameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameCustomer.Location = new System.Drawing.Point(192, 112);
            this.txtUsernameCustomer.Name = "txtUsernameCustomer";
            this.txtUsernameCustomer.Size = new System.Drawing.Size(148, 24);
            this.txtUsernameCustomer.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(930, 66);
            this.label2.TabIndex = 48;
            this.label2.Text = "Customer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewCusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Card);
            this.Name = "NewCusControl";
            this.Size = new System.Drawing.Size(930, 670);
            this.Load += new System.EventHandler(this.NewCusControl_Load);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Card;
        private System.Windows.Forms.ComboBox TableBox;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label tn;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Label pn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhoneCustomer;
        private System.Windows.Forms.Label un;
        private System.Windows.Forms.TextBox txtUsernameCustomer;
        private System.Windows.Forms.Label label2;
    }
}
