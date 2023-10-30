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
            this.sSignIn = new System.Windows.Forms.Button();
            this.sBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sUsername = new System.Windows.Forms.TextBox();
            this.sFirst = new System.Windows.Forms.TextBox();
            this.sLast = new System.Windows.Forms.TextBox();
            this.sEmail = new System.Windows.Forms.TextBox();
            this.sPass = new System.Windows.Forms.TextBox();
            this.sConfirm = new System.Windows.Forms.TextBox();
            this.sDate = new System.Windows.Forms.DateTimePicker();
            this.sAge = new System.Windows.Forms.TextBox();
            this.sGender = new System.Windows.Forms.ComboBox();
            this.sPhone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // sSignIn
            // 
            this.sSignIn.Location = new System.Drawing.Point(409, 403);
            this.sSignIn.Name = "sSignIn";
            this.sSignIn.Size = new System.Drawing.Size(75, 23);
            this.sSignIn.TabIndex = 12;
            this.sSignIn.Text = "SignIn";
            this.sSignIn.UseVisualStyleBackColor = true;
            this.sSignIn.Click += new System.EventHandler(this.sSignIn_Click);
            // 
            // sBack
            // 
            this.sBack.Location = new System.Drawing.Point(519, 403);
            this.sBack.Name = "sBack";
            this.sBack.Size = new System.Drawing.Size(75, 23);
            this.sBack.TabIndex = 13;
            this.sBack.Text = "Back";
            this.sBack.UseVisualStyleBackColor = true;
            this.sBack.Click += new System.EventHandler(this.sBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sign Up";
            // 
            // sUsername
            // 
            this.sUsername.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sUsername.Location = new System.Drawing.Point(293, 137);
            this.sUsername.Name = "sUsername";
            this.sUsername.Size = new System.Drawing.Size(191, 23);
            this.sUsername.TabIndex = 23;
            this.sUsername.Text = "Username";
            // 
            // sFirst
            // 
            this.sFirst.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sFirst.Location = new System.Drawing.Point(293, 175);
            this.sFirst.Name = "sFirst";
            this.sFirst.Size = new System.Drawing.Size(191, 23);
            this.sFirst.TabIndex = 24;
            this.sFirst.Text = "First Name";
            // 
            // sLast
            // 
            this.sLast.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLast.Location = new System.Drawing.Point(519, 175);
            this.sLast.Name = "sLast";
            this.sLast.Size = new System.Drawing.Size(191, 23);
            this.sLast.TabIndex = 25;
            this.sLast.Text = "Last Name";
            // 
            // sEmail
            // 
            this.sEmail.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sEmail.Location = new System.Drawing.Point(293, 220);
            this.sEmail.Name = "sEmail";
            this.sEmail.Size = new System.Drawing.Size(191, 23);
            this.sEmail.TabIndex = 26;
            this.sEmail.Text = "Email";
            this.sEmail.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // sPass
            // 
            this.sPass.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPass.Location = new System.Drawing.Point(293, 296);
            this.sPass.Name = "sPass";
            this.sPass.Size = new System.Drawing.Size(191, 23);
            this.sPass.TabIndex = 27;
            this.sPass.Text = "Password";
            // 
            // sConfirm
            // 
            this.sConfirm.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sConfirm.Location = new System.Drawing.Point(519, 294);
            this.sConfirm.Name = "sConfirm";
            this.sConfirm.Size = new System.Drawing.Size(191, 23);
            this.sConfirm.TabIndex = 28;
            this.sConfirm.Text = "Confirm Password";
            // 
            // sDate
            // 
            this.sDate.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sDate.Location = new System.Drawing.Point(519, 220);
            this.sDate.Name = "sDate";
            this.sDate.Size = new System.Drawing.Size(191, 23);
            this.sDate.TabIndex = 29;
            // 
            // sAge
            // 
            this.sAge.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sAge.Location = new System.Drawing.Point(293, 258);
            this.sAge.Name = "sAge";
            this.sAge.Size = new System.Drawing.Size(191, 23);
            this.sAge.TabIndex = 30;
            this.sAge.Text = "Age";
            // 
            // sGender
            // 
            this.sGender.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sGender.FormattingEnabled = true;
            this.sGender.IntegralHeight = false;
            this.sGender.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan",
            "Others"});
            this.sGender.Location = new System.Drawing.Point(519, 257);
            this.sGender.Name = "sGender";
            this.sGender.Size = new System.Drawing.Size(191, 24);
            this.sGender.TabIndex = 31;
            this.sGender.Text = "Gender";
            // 
            // sPhone
            // 
            this.sPhone.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sPhone.Location = new System.Drawing.Point(519, 137);
            this.sPhone.Name = "sPhone";
            this.sPhone.Size = new System.Drawing.Size(191, 23);
            this.sPhone.TabIndex = 32;
            this.sPhone.Text = "Phone Number";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 498);
            this.panel1.TabIndex = 34;
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sPhone);
            this.Controls.Add(this.sGender);
            this.Controls.Add(this.sAge);
            this.Controls.Add(this.sDate);
            this.Controls.Add(this.sConfirm);
            this.Controls.Add(this.sPass);
            this.Controls.Add(this.sEmail);
            this.Controls.Add(this.sLast);
            this.Controls.Add(this.sFirst);
            this.Controls.Add(this.sUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sBack);
            this.Controls.Add(this.sSignIn);
            this.Name = "signin";
            this.Text = "signin";
            this.Load += new System.EventHandler(this.signin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sSignIn;
        private System.Windows.Forms.Button sBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sUsername;
        private System.Windows.Forms.TextBox sFirst;
        private System.Windows.Forms.TextBox sLast;
        private System.Windows.Forms.TextBox sEmail;
        private System.Windows.Forms.TextBox sPass;
        private System.Windows.Forms.TextBox sConfirm;
        private System.Windows.Forms.DateTimePicker sDate;
        private System.Windows.Forms.TextBox sAge;
        private System.Windows.Forms.ComboBox sGender;
        private System.Windows.Forms.TextBox sPhone;
        private System.Windows.Forms.Panel panel1;
    }
}