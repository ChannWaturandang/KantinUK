namespace Makanan
{
    partial class signin
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
            this.sEmail = new System.Windows.Forms.TextBox();
            this.sUser = new System.Windows.Forms.TextBox();
            this.sLabelEmail = new System.Windows.Forms.Label();
            this.sLabelUser = new System.Windows.Forms.Label();
            this.sPass = new System.Windows.Forms.TextBox();
            this.sLabelPass = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sEmail
            // 
            this.sEmail.Location = new System.Drawing.Point(206, 103);
            this.sEmail.Name = "sEmail";
            this.sEmail.Size = new System.Drawing.Size(145, 20);
            this.sEmail.TabIndex = 9;
            // 
            // sUser
            // 
            this.sUser.Location = new System.Drawing.Point(206, 54);
            this.sUser.Name = "sUser";
            this.sUser.Size = new System.Drawing.Size(145, 20);
            this.sUser.TabIndex = 8;
            // 
            // sLabelEmail
            // 
            this.sLabelEmail.AutoSize = true;
            this.sLabelEmail.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabelEmail.ForeColor = System.Drawing.Color.Teal;
            this.sLabelEmail.Location = new System.Drawing.Point(67, 104);
            this.sLabelEmail.Name = "sLabelEmail";
            this.sLabelEmail.Size = new System.Drawing.Size(50, 19);
            this.sLabelEmail.TabIndex = 7;
            this.sLabelEmail.Text = "Email";
            // 
            // sLabelUser
            // 
            this.sLabelUser.AutoSize = true;
            this.sLabelUser.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabelUser.ForeColor = System.Drawing.Color.Teal;
            this.sLabelUser.Location = new System.Drawing.Point(67, 56);
            this.sLabelUser.Name = "sLabelUser";
            this.sLabelUser.Size = new System.Drawing.Size(84, 19);
            this.sLabelUser.TabIndex = 6;
            this.sLabelUser.Text = "Username";
            // 
            // sPass
            // 
            this.sPass.Location = new System.Drawing.Point(206, 157);
            this.sPass.Name = "sPass";
            this.sPass.Size = new System.Drawing.Size(145, 20);
            this.sPass.TabIndex = 11;
            // 
            // sLabelPass
            // 
            this.sLabelPass.AutoSize = true;
            this.sLabelPass.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLabelPass.ForeColor = System.Drawing.Color.Teal;
            this.sLabelPass.Location = new System.Drawing.Point(67, 158);
            this.sLabelPass.Name = "sLabelPass";
            this.sLabelPass.Size = new System.Drawing.Size(79, 19);
            this.sLabelPass.TabIndex = 10;
            this.sLabelPass.Text = "Password";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "SignIn";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.sPass);
            this.Controls.Add(this.sLabelPass);
            this.Controls.Add(this.sEmail);
            this.Controls.Add(this.sUser);
            this.Controls.Add(this.sLabelEmail);
            this.Controls.Add(this.sLabelUser);
            this.Name = "signin";
            this.Text = "signin";
            this.Load += new System.EventHandler(this.signin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sEmail;
        private System.Windows.Forms.TextBox sUser;
        private System.Windows.Forms.Label sLabelEmail;
        private System.Windows.Forms.Label sLabelUser;
        private System.Windows.Forms.TextBox sPass;
        private System.Windows.Forms.Label sLabelPass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}