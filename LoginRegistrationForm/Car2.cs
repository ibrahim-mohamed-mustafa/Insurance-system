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
using CSLoginRegisterForm.Connection;

namespace LoginRegistrationForm
{

    public partial class Car2 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IKURU06\\SQLEXPRESS;Initial Catalog=LoginDatabase;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        DataTable dt;
        int newid;
        string newuser;
    
       
        public Car2()
        {
            InitializeComponent();
            //displaybyvalue(  );
          
        }
        public void SearchData(string search)
        {
            con.Open();
            //string query = "select * from  Login1 wehre  Username like '%" + search + "%'";
            string query = "select Username , Type_of_Car, Car_Number,Car_Color,Numer_of_Accident from  Login1,car where Login1.Auto_id=car.Auto_id and Username like '%" + search + "%'";
            adapt = new SqlDataAdapter(query, con);

            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }
        public void getid(int newidd , string newuserr)
        {

            newid = newidd;
            newuser = newuserr;
        }

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("id user  " + newid.ToString() , "user   " + newuser );

            if (txtSearchName.Text == newuser)
            {
                SearchData(txtSearchName.Text);
            }
            else 
            {
                MessageBox.Show("Please Enter Your Username correctly");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(num.Text))
            {
                MessageBox.Show("Please Enter Your Car's Number.");
                
                return;
            }
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from car where Car_Number ='" +num.Text+ "'  " ;

            cmd.ExecuteNonQuery();

           
            con.Close();
            MessageBox.Show("Car has been deleted");

        }

       
    }
}
