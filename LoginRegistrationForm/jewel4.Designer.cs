namespace LoginRegistrationForm
{
    partial class jewel4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jewel4));
            this.cancelbutton2 = new System.Windows.Forms.Button();
            this.loginbutton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelbutton2
            // 
            this.cancelbutton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelbutton2.BackgroundImage = global::LoginRegistrationForm.Properties.Resources.Cyber002_960x540;
            this.cancelbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelbutton2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelbutton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelbutton2.Location = new System.Drawing.Point(344, 439);
            this.cancelbutton2.Name = "cancelbutton2";
            this.cancelbutton2.Size = new System.Drawing.Size(133, 47);
            this.cancelbutton2.TabIndex = 22;
            this.cancelbutton2.Text = "Cancel";
            this.cancelbutton2.UseVisualStyleBackColor = false;
            this.cancelbutton2.Click += new System.EventHandler(this.cancelbutton2_Click);
            // 
            // loginbutton1
            // 
            this.loginbutton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loginbutton1.BackgroundImage = global::LoginRegistrationForm.Properties.Resources.Cyber002_960x540;
            this.loginbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbutton1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginbutton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginbutton1.Location = new System.Drawing.Point(117, 439);
            this.loginbutton1.Name = "loginbutton1";
            this.loginbutton1.Size = new System.Drawing.Size(134, 47);
            this.loginbutton1.TabIndex = 21;
            this.loginbutton1.Text = "Confirm";
            this.loginbutton1.UseVisualStyleBackColor = false;
            this.loginbutton1.Click += new System.EventHandler(this.loginbutton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(26, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 111);
            this.label2.TabIndex = 20;
            this.label2.Text = "This Insurance cost 2500 Dollars/Month.\r\nand finally get 300000 Dollars for this " +
    "\r\nInsurance. \r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 79);
            this.label1.TabIndex = 19;
            this.label1.Text = "Home Insurance ";
            // 
            // jewel4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::LoginRegistrationForm.Properties.Resources.color8;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 511);
            this.Controls.Add(this.cancelbutton2);
            this.Controls.Add(this.loginbutton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "jewel4";
            this.Text = "System Insurance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelbutton2;
        private System.Windows.Forms.Button loginbutton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}