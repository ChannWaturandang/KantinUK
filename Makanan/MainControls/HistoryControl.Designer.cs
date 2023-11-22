namespace Makanan.Controls
{
    partial class HistoryControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminLogo
            // 
            this.adminLogo.AutoSize = true;
            this.adminLogo.BackColor = System.Drawing.Color.Transparent;
            this.adminLogo.Font = new System.Drawing.Font("Harlow Solid Italic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogo.ForeColor = System.Drawing.Color.Teal;
            this.adminLogo.Location = new System.Drawing.Point(40, 20);
            this.adminLogo.Name = "adminLogo";
            this.adminLogo.Size = new System.Drawing.Size(145, 46);
            this.adminLogo.TabIndex = 77;
            this.adminLogo.Text = "History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 425);
            this.dataGridView1.TabIndex = 78;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(48, 117);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(120, 20);
            this.IDBox.TabIndex = 79;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(48, 98);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(24, 13);
            this.txtID.TabIndex = 80;
            this.txtID.Text = "ID :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(191, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 20);
            this.btnDelete.TabIndex = 81;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HistoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adminLogo);
            this.Name = "HistoryControl";
            this.Size = new System.Drawing.Size(930, 615);
            this.Load += new System.EventHandler(this.HistoryControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminLogo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Timer timer1;
    }
}
