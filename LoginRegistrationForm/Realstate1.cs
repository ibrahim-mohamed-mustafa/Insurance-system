using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrationForm
{
    public partial class Realstate1 : Form
    {
        public Realstate1()
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

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Insurance System :";
            MessageBox.Show("The Transfer is done!" +
                "  Thank You.", caption, btn, ico);



            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Insurance System :";
            MessageBox.Show("The Transfer is done!" +
                "  Thank You.", caption, btn, ico);



            this.Close();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }

       
    }
}
