namespace LoginRegistrationForm
{
    partial class life1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(life1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelbutton2 = new System.Windows.Forms.Button();
            this.loginbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 79);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home Insurance ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 21.75F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(31, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(546, 111);
            this.label2.TabIndex = 2;
            this.label2.Text = "This Insurance cost 150 Dollars/Month,\r\nand finally get 50000 Dollars for this\r\nI" +
    "nsurance. ";
            // 
            // cancelbutton2
            // 
            this.cancelbutton2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cancelbutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelbutton2.BackgroundImage")));
            this.cancelbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelbutton2.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelbutton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelbutton2.Location = new System.Drawing.Point(351, 432);
            this.cancelbutton2.Name = "cancelbutton2";
            this.cancelbutton2.Size = new System.Drawing.Size(133, 47);
            this.cancelbutton2.TabIndex = 11;
            this.cancelbutton2.Text = "Cancel";
            this.cancelbutton2.UseVisualStyleBackColor = false;
            this.cancelbutton2.Click += new System.EventHandler(this.cancelbutton2_Click);
            // 
            // loginbutton1
            // 
            this.loginbutton1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.loginbutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbutton1.BackgroundImage")));
            this.loginbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginbutton1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginbutton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginbutton1.Location = new System.Drawing.Point(128, 432);
            this.loginbutton1.Name = "loginbutton1";
            this.loginbutton1.Size = new System.Drawing.Size(134, 47);
            this.loginbutton1.TabIndex = 10;
            this.loginbutton1.Text = "Confirm";
            this.loginbutton1.UseVisualStyleBackColor = false;
            this.loginbutton1.Click += new System.EventHandler(this.loginbutton1_Click);
            // 
            // life1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::LoginRegistrationForm.Properties.Resources.More_Ways_to_Simplify_Your_Life;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 511);
            this.Controls.Add(this.cancelbutton2);
            this.Controls.Add(this.loginbutton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "life1";
            this.Text = "System Insurance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cancelbutton2;
        private System.Windows.Forms.Button loginbutton1;
    }
}