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
    public partial class Carmain : Form
    {
        int newidd;
        string newuserr;
        public Carmain()
        {
            InitializeComponent();
            
        
        }

        public void getid(int newid , string newuser)
        {

           newidd= newid  ;
            newuserr = newuser;
        }


        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Car1 car11 = new Car1();
            car11.getidd(newidd);
            car11.ShowDialog();
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Car2 car22 = new Car2();
            car22.getid(newidd,newuserr);
            car22.ShowDialog();
        }

    
    }
}
