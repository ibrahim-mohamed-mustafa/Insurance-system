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
    public partial class MainForm : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-IKURU06\\SQLEXPRESS;Initial Catalog=LoginDatabase;Integrated Security=True");
        SqlDataAdapter adapt;
        DataTable dt;
        SqlCommand cmd;
        int logid;
        public MainForm()
        {
            InitializeComponent();
            displaybyvalue();
        }

        public void displaybyvalue()
        {

            con.Open();
            adapt = new SqlDataAdapter("select * from Login1 ", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

            SearchData(txtSearchName.Text);
            
        }

        public void SearchData(string search)
        {
            con.Open();
            string query = "select * from Login1 where First_Name like '%" + search + "%'";
           
            adapt = new SqlDataAdapter(query, con);
       
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

        private void DeleteButton_Click_2_Click(object sender, EventArgs e)
        {
           
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Login1 where First_Name ='" + FirstNameTextBox.Text + "'  ";
            cmd.ExecuteNonQuery();
    

            con.Close();
            disp_data();
            MessageBox.Show("Data has been deleted");

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            logid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            FirstNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            LastNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            EmailTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            UserNameTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TelephoneTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            PaymentTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            InsuredBox.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            TypeBox.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            InsurancedealBox.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
        }

    

        public void disp_data()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Login1";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Login1 set First_Name ='" + FirstNameTextBox.Text + "',Last_Name='" + LastNameTextBox.Text + "',Username='" + UserNameTextBox.Text + "',Telephone='" + TelephoneTextBox.Text + "',Pyment_Method='" + PaymentTextBox.Text + "',Insured='" + InsuredBox.Text + "',Type_User='" + TypeBox.Text + "', Insurance_deal='" + InsurancedealBox.Text + "' where Auto_id=" + logid + "      ";
            cmd.ExecuteNonQuery();

            con.Close();
            disp_data();
            MessageBox.Show("Data has been Update");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarAdmin car11 = new CarAdmin();
            
            car11.ShowDialog();
        }

        

    }
}
