/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSLoginRegisterForm.Connection;
using System.Data.SqlClient;

namespace LoginRegistrationForm.Getid
{

    class Class1
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IKURU06\\SQLEXPRESS;Initial Catalog=LoginDatabase;Integrated Security=True");
        SqlCommand cmd; //= new SqlCommand("select Auto_id, Username from Login1");
        int newid;
        Login_Form login;

        public void readid()
        {

            
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("select * from Login1");
            SqlDataReader rdr = cmd.ExecuteReader();


            while (rdr.Read())
            {
               

                int userid = (int)rdr["Auto_id"];
                string username = (string)rdr["Username"];
                string firstname = (string)rdr["First_Name"];
                string password = (string)rdr["Password"];
                if (username == usenametextBox3.Text && password == passwordtextBox1.Text)
                {
                    newid = userid;



                    MessageBox.Show("id user  " + userid.ToString() + "   user name    " + username + "   Name   " + firstname);

                    break;
                }


            }


            con.Close();
        }
    }
}
*/