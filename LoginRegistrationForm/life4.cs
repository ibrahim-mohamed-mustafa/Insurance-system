using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSLoginRegisterForm.Connection;

namespace LoginRegistrationForm
{
    public partial class life4 : Form
    {
        public life4()
        {
            InitializeComponent();
        }

        private void loginbutton1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Insurance System :";
            MessageBox.Show("The Transfer is done!" +
                "  Thank You.", caption, btn, ico);



            this.Close();
        }

        private void cancelbutton2_Click(object sender, EventArgs e)
        {
            

            this.Close();
        }
    }
}
