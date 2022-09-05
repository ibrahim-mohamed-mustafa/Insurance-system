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
  
    public partial class CarAdmin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IKURU06\\SQLEXPRESS;Initial Catalog=LoginDatabase;Integrated Security=True");
        
        SqlDataAdapter adapt;
        DataTable dt;


        public CarAdmin()
        {
            InitializeComponent();
            displaybyvalue();
        }

        public void displaybyvalue()
        {

            con.Open();
            adapt = new SqlDataAdapter("select First_Name,Last_Name,Type_of_Car,Car_Number,Car_Color,Numer_of_Accident from Login1, car where Login1.Auto_id = car.Auto_id", con);
            // adapt = new SqlDataAdapter("select First_Name,carnumber,carcolor,numacc from Login1, car where car.Auto_id '%" + newid + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


    }
}
