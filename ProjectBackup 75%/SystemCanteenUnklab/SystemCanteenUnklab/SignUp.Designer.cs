namespace SystemCanteenUnklab
{
    partial class SignUp
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.SPass = new System.Windows.Forms.TextBox();
            this.SLabelPass = new System.Windows.Forms.Label();
            this.SEmail = new System.Windows.Forms.TextBox();
            this.SUser = new System.Windows.Forms.TextBox();
            this.SLabelEmail = new System.Windows.Forms.Label();
            this.SLabelUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(348, 258);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(112, 35);
            this.BtnBack.TabIndex = 21;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Location = new System.Drawing.Point(209, 258);
            this.BtnSignUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(112, 35);
            this.BtnSignUp.TabIndex = 20;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            // 
            // SPass
            // 
            this.SPass.Location = new System.Drawing.Point(222, 165);
            this.SPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SPass.Name = "SPass";
            this.SPass.Size = new System.Drawing.Size(216, 26);
            this.SPass.TabIndex = 19;
            // 
            // SLabelPass
            // 
            this.SLabelPass.AutoSize = true;
            this.SLabelPass.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLabelPass.ForeColor = System.Drawing.Color.Teal;
            this.SLabelPass.Location = new System.Drawing.Point(13, 166);
            this.SLabelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SLabelPass.Name = "SLabelPass";
            this.SLabelPass.Size = new System.Drawing.Size(119, 27);
            this.SLabelPass.TabIndex = 18;
            this.SLabelPass.Text = "Password";
            // 
            // SEmail
            // 
            this.SEmail.Location = new System.Drawing.Point(222, 81);
            this.SEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SEmail.Name = "SEmail";
            this.SEmail.Size = new System.Drawing.Size(216, 26);
            this.SEmail.TabIndex = 17;
            // 
            // SUser
            // 
            this.SUser.Location = new System.Drawing.Point(222, 6);
            this.SUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SUser.Name = "SUser";
            this.SUser.Size = new System.Drawing.Size(216, 26);
            this.SUser.TabIndex = 16;
            // 
            // SLabelEmail
            // 
            this.SLabelEmail.AutoSize = true;
            this.SLabelEmail.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLabelEmail.ForeColor = System.Drawing.Color.Teal;
            this.SLabelEmail.Location = new System.Drawing.Point(13, 83);
            this.SLabelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SLabelEmail.Name = "SLabelEmail";
            this.SLabelEmail.Size = new System.Drawing.Size(75, 27);
            this.SLabelEmail.TabIndex = 15;
            this.SLabelEmail.Text = "Email";
            // 
            // SLabelUser
            // 
            this.SLabelUser.AutoSize = true;
            this.SLabelUser.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLabelUser.ForeColor = System.Drawing.Color.Teal;
            this.SLabelUser.Location = new System.Drawing.Point(13, 9);
            this.SLabelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SLabelUser.Name = "SLabelUser";
            this.SLabelUser.Size = new System.Drawing.Size(125, 27);
            this.SLabelUser.TabIndex = 14;
            this.SLabelUser.Text = "Username";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 308);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.SPass);
            this.Controls.Add(this.SLabelPass);
            this.Controls.Add(this.SEmail);
            this.Controls.Add(this.SUser);
            this.Controls.Add(this.SLabelEmail);
            this.Controls.Add(this.SLabelUser);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.TextBox SPass;
        private System.Windows.Forms.Label SLabelPass;
        private System.Windows.Forms.TextBox SEmail;
        private System.Windows.Forms.TextBox SUser;
        private System.Windows.Forms.Label SLabelEmail;
        private System.Windows.Forms.Label SLabelUser;
    }
}