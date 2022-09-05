using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginRegistrationForm
{
    public partial class Car1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IKURU06\\SQLEXPRESS;Initial Catalog=LoginDatabase;Integrated Security=True");
        SqlCommand cmd;
        
        int newid;
        
        public Car1()
        {
            InitializeComponent();
        }

        public void getidd(int newidd)
        {

           newid =newidd  ;
        }

        private void clearControls()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = string.Empty;
            }
        }


        private void loginbutton1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            
            //MessageBox.Show("id user  " + newid.ToString());
            con.Open();
            cmd = new SqlCommand("INSERT INTO car(Car_Number,Car_Color,Numer_of_Accident,Auto_id,Type_of_Car) VALUES('" + carnum.Text + "','" + carcol.Text + "'," + acc.Text + "," + newid + ",'" + type.Text + "') ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("The record has been saved successfully.","Add Data : Insurance System",btn,ico);

            clearControls();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;

            int numberodacc = int.Parse(acc.Text);

            if (numberodacc <0)
            {
                MessageBox.Show("Please write a postive number.", "Request Data : Insurance System", btn, ico);
            }

            else if (numberodacc <= 2 && numberodacc>=0)
            {
                MessageBox.Show("This Insurance cost 150 Dollars/Month and finally get 70000 Dollars for this Insurance.", "Request Data : Insurance System", btn, ico);
            }


            else if (numberodacc > 2 && numberodacc <= 10)
            {
                MessageBox.Show("This Insurance cost 300 Dollars/Month and finally get 75000 Dollars for this Insurance.", "Request Data : Insurance System", btn, ico);
            }

            else if (numberodacc > 10 && numberodacc <= 20)
            {
                MessageBox.Show("This Insurance cost 450 Dollars/Month and finally get 80000 Dollars for this Insurance.", "Request Data : Insurance System", btn, ico);
            }

            else if (numberodacc > 20 && numberodacc <= 30)
            {
                MessageBox.Show("This Insurance cost 600 Dollars/Month and finally get 85000 Dollars for this Insurance.", "Request Data : Insurance System", btn, ico);
            }

            else if (numberodacc > 30 && numberodacc <= 45)
            {
                MessageBox.Show("This Insurance cost 750 Dollars/Month and finally get 90000 Dollars for this Insurance.", "Request Data : Insurance System", btn, ico);
            }

            else if (numberodacc > 45 && numberodacc <= 75)
            {
                MessageBox.Show("This Insurance cost 900 Dollars/Month and finally get 95000 Dollars for this Insurance.", "Request Data : Insurance System", btn, ico);
            }

            else 
            {
                MessageBox.Show("Insurance System can't add this car because your car made alot of accident.", "Request Data : Insurance System", btn, ico);
            }
           


        }
    }
}
