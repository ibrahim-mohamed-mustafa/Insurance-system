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
using System.Data.SqlClient;

namespace LoginRegistrationForm
{
    
    public partial class Login_Form : Form
    {
SqlConnection con = new SqlConnection("Data Source=DESKTOP-IKURU06\\SQLEXPRESS;Initial Catalog=LoginDatabase;Integrated Security=True");
        SqlCommand cmd; //= new SqlCommand("select Auto_id, Username from Login1");
        int newid;
        string newuser;
        public Login_Form()
        {
            InitializeComponent();
        }


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
                    newuser = username;
                    break;
                }


            }


            con.Close();
        }


        private void Login_Form_Load(object sender, EventArgs e)
        {
            usenametextBox3.Select();
        }



        private void cancelbutton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openregisterformlinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_Form register = new Registration_Form();
            register.ShowDialog();
        }

        private void showpassowrdcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassowrdcheckBox.Checked == true)
            {
                passwordtextBox1.UseSystemPasswordChar = false;
            }
            else
            {
                passwordtextBox1.UseSystemPasswordChar = true;
            }
        }


        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void loginbutton1_Click(object sender, EventArgs e)
        {
            readid();

            if (!string.IsNullOrEmpty(usenametextBox3.Text) &&
               !string.IsNullOrEmpty(passwordtextBox1.Text))
            {

                string mySQL = string.Empty;

                mySQL += "SELECT * FROM Login1 ";
                mySQL += "WHERE Username = '" + usenametextBox3.Text + "' ";
                mySQL += "AND Password = '" + passwordtextBox1.Text + "'";
                mySQL += "AND Type_User = '" + TypeUsercomboBox.Text + "'";
                mySQL += "AND Insured = '" + InsuredBox.Text + "'";
                DataTable userData = ServerConnection.executeSQL(mySQL);

                if (userData.Rows.Count > 0)
                {

                    usenametextBox3.Clear();
                    passwordtextBox1.Clear();

                    showpassowrdcheckBox.Checked = false;
                    if (TypeUsercomboBox.Text == "Admin")

                    {
                        //this.Hide();

                        MainForm formMain = new MainForm();
                        formMain.ShowDialog();
                        formMain = null;

                        this.Show();
                        this.usenametextBox3.Select();
                    }

                    else if(TypeUsercomboBox.Text == "User") {

                        if (InsuredBox.Text == "Life")
                        {
                            //this.Hide();

                            MainFormuser user = new MainFormuser();
                            user.ShowDialog();
                          

                            /*this.Show();
                            this.usenametextBox3.Select();*/
                        }

                        else if (InsuredBox.Text == "Car")
                        {
                            //this.Hide();

                            Carmain car = new Carmain();
                            car.getid(newid, newuser);
                            car.ShowDialog();
                           

                            /*this.Show();
                            this.usenametextBox3.Select();*/
                        }

                        else if (InsuredBox.Text == "Jewelries")
                        {
                            //this.Hide();

                            JewelriesForm jewelriesr = new JewelriesForm();
                            jewelriesr.ShowDialog();
                            

                            /*this.Show();
                            this.usenametextBox3.Select();*/
                        }

                        else if (InsuredBox.Text == "Real Estates")
                        {
                            //this.Hide();

                            RealEstatesForm realEstates = new RealEstatesForm();
                            realEstates.ShowDialog();
                           

                            /*this.Show();
                            this.usenametextBox3.Select();*/
                        }








                    }
                }
                else
                {
                    MessageBox.Show("The username or password or type of user or insured items is incorrect. Try again.",
                        "Login System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    usenametextBox3.Focus();
                    usenametextBox3.SelectAll();
                }

            }
            else
            {
                MessageBox.Show("Please enter username and password and type of user and insured items.", "Login :Insurance System",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                usenametextBox3.Select();
            }

        }



       

       
    }
}
