namespace LoginRegistrationForm
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.showpassowrdcheckBox = new System.Windows.Forms.CheckBox();
            this.loginbutton1 = new System.Windows.Forms.Button();
            this.openregisterformlinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.usenametextBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelbutton2 = new System.Windows.Forms.Button();
            this.passwordtextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeUsercomboBox = new System.Windows.Forms.ComboBox();
            this.InsuredBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(38, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 0;
            // 
            // showpassowrdcheckBox
            // 
            this.showpassowrdcheckBox.AutoSize = true;
            this.showpassowrdcheckBox.BackColor = System.Drawing.Color.Transparent;
            this.showpassowrdcheckBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.showpassowrdcheckBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showpassowrdcheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.showpassowrdcheckBox.Location = new System.Drawing.Point(397, 179);
            this.showpassowrdcheckBox.Name = "showpassowrdcheckBox";
            this.showpassowrdcheckBox.Size = new System.Drawing.Size(133, 25);
            this.showpassowrdcheckBox.TabIndex = 1;
            this.showpassowrdcheckBox.Text = "Show Passsord";
            this.showpassowrdcheckBox.UseVisualStyleBackColor = false;
            this.showpassowrdcheckBox.CheckedChanged += new System.EventHandler(this.showpassowrdcheckBox_CheckedChanged);
            // 
            // loginbutton1
            // 
            this.loginbutton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loginbutton1.BackgroundImage = global::LoginRegistrationForm.Properties.Resources.cyber_security;
            this.loginbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbutton1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbutton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginbutton1.Location = new System.Drawing.Point(103, 405);
            this.loginbutton1.Name = "loginbutton1";
            this.loginbutton1.Size = new System.Drawing.Size(134, 47);
            this.loginbutton1.TabIndex = 2;
            this.loginbutton1.Text = "Log-in";
            this.loginbutton1.UseVisualStyleBackColor = false;
            this.loginbutton1.Click += new System.EventHandler(this.loginbutton1_Click);
            // 
            // openregisterformlinkLabel1
            // 
            this.openregisterformlinkLabel1.AutoSize = true;
            this.openregisterformlinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.openregisterformlinkLabel1.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openregisterformlinkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.openregisterformlinkLabel1.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openregisterformlinkLabel1.Location = new System.Drawing.Point(73, 486);
            this.openregisterformlinkLabel1.Name = "openregisterformlinkLabel1";
            this.openregisterformlinkLabel1.Size = new System.Drawing.Size(437, 32);
            this.openregisterformlinkLabel1.TabIndex = 3;
            this.openregisterformlinkLabel1.TabStop = true;
            this.openregisterformlinkLabel1.Text = "Don\'t have an account yet? Sign up.\r\n";
            this.openregisterformlinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.openregisterformlinkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(33, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password   :";
            // 
            // usenametextBox3
            // 
            this.usenametextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.usenametextBox3.Location = new System.Drawing.Point(204, 76);
            this.usenametextBox3.Multiline = true;
            this.usenametextBox3.Name = "usenametextBox3";
            this.usenametextBox3.Size = new System.Drawing.Size(326, 33);
            this.usenametextBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(33, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "User Name :";
            // 
            // cancelbutton2
            // 
            this.cancelbutton2.BackColor = System.Drawing.Color.Transparent;
            this.cancelbutton2.BackgroundImage = global::LoginRegistrationForm.Properties.Resources.cyber_security;
            this.cancelbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelbutton2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbutton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelbutton2.Location = new System.Drawing.Point(323, 405);
            this.cancelbutton2.Name = "cancelbutton2";
            this.cancelbutton2.Size = new System.Drawing.Size(133, 47);
            this.cancelbutton2.TabIndex = 9;
            this.cancelbutton2.Text = "Cancel";
            this.cancelbutton2.UseVisualStyleBackColor = false;
            this.cancelbutton2.Click += new System.EventHandler(this.cancelbutton2_Click);
            // 
            // passwordtextBox1
            // 
            this.passwordtextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.passwordtextBox1.Location = new System.Drawing.Point(204, 140);
            this.passwordtextBox1.Name = "passwordtextBox1";
            this.passwordtextBox1.Size = new System.Drawing.Size(326, 31);
            this.passwordtextBox1.TabIndex = 10;
            this.passwordtextBox1.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Location = new System.Drawing.Point(34, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select User Type :";
            // 
            // TypeUsercomboBox
            // 
            this.TypeUsercomboBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeUsercomboBox.FormattingEnabled = true;
            this.TypeUsercomboBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.TypeUsercomboBox.Location = new System.Drawing.Point(252, 226);
            this.TypeUsercomboBox.Name = "TypeUsercomboBox";
            this.TypeUsercomboBox.Size = new System.Drawing.Size(278, 38);
            this.TypeUsercomboBox.TabIndex = 12;
            // 
            // InsuredBox
            // 
            this.InsuredBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsuredBox.FormattingEnabled = true;
            this.InsuredBox.ItemHeight = 30;
            this.InsuredBox.Items.AddRange(new object[] {
            "Real Estates",
            "Car",
            "Life",
            "Jewelries"});
            this.InsuredBox.Location = new System.Drawing.Point(252, 286);
            this.InsuredBox.Name = "InsuredBox";
            this.InsuredBox.Size = new System.Drawing.Size(278, 38);
            this.InsuredBox.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label9.Location = new System.Drawing.Point(33, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 37);
            this.label9.TabIndex = 24;
            this.label9.Text = "Insured Items  :";
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::LoginRegistrationForm.Properties.Resources._1307265;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(559, 561);
            this.Controls.Add(this.InsuredBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TypeUsercomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordtextBox1);
            this.Controls.Add(this.cancelbutton2);
            this.Controls.Add(this.usenametextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.openregisterformlinkLabel1);
            this.Controls.Add(this.loginbutton1);
            this.Controls.Add(this.showpassowrdcheckBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Insurance Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox showpassowrdcheckBox;
        private System.Windows.Forms.Button loginbutton1;
        private System.Windows.Forms.LinkLabel openregisterformlinkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelbutton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeUsercomboBox;
        private System.Windows.Forms.ComboBox InsuredBox;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox usenametextBox3;
        public System.Windows.Forms.TextBox passwordtextBox1;
    }
}