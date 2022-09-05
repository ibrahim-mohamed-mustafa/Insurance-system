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
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        
        private void ClearButton_Click_1(object sender, EventArgs e)
        {
            clearControls();
            FirstNameTextBox.Select();
        }
       


        private void clearControls()
        {
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Text = string.Empty;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            
            FirstNameTextBox.Select();
        }

       
       

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "Save Data : Insurance System";

            if (string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                MessageBox.Show("Please enter First Name.", caption, btn, ico);
                FirstNameTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                MessageBox.Show("Please enter Last Name.", caption, btn, ico);
                LastNameTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(UsernameTextBox.Text))
            {
                MessageBox.Show("Please enter Username.", caption, btn, ico);
                UsernameTextBox.Select();
                return;
            }
           
            if (string.IsNullOrEmpty(EmailTextBox.Text))
            {
                MessageBox.Show("Please enter Email.", caption, btn, ico);
                UsernameTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(TelephoneTextBox.Text))
            {
                MessageBox.Show("Please enter Telephone.", caption, btn, ico);
                TelephoneTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(TypeBox.Text))
            {
                MessageBox.Show("Please enter Type of User.", caption, btn, ico);
                TypeBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                MessageBox.Show("Please enter Password.", caption, btn, ico);
                PasswordTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(ConfirmPasswordTextBox.Text))
            {
                MessageBox.Show("Please enter Confirmation Password.", caption, btn, ico);
                ConfirmPasswordTextBox.Select();
                return;
            }

            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Your password and confirmation password do not match.", caption, btn, ico);
                ConfirmPasswordTextBox.SelectAll();
                return;
            }

            

            if (string.IsNullOrEmpty(PaymentMethodTextBox.Text))
            {
                MessageBox.Show("Please enter Payment Method.", caption, btn, ico);
                PaymentMethodTextBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(Paymentnum.Text))
            {
                MessageBox.Show("Please enter Payment Number.", caption, btn, ico);
                InsurancedealBox.Select();
                return;
            }

            if (string.IsNullOrEmpty(InsuredBox.Text))
            {
                MessageBox.Show("Please enter Insured Items.", caption, btn, ico);
                InsuredBox.Select();
                return;
            }
            
          

            if (string.IsNullOrEmpty(InsurancedealBox.Text))
            {
                MessageBox.Show("Please enter Insurance deal.", caption, btn, ico);
                InsurancedealBox.Select();
                return;
            }
            


            string yourSQL = "SELECT Username FROM Login1 WHERE Username = '" + UsernameTextBox.Text + "'";
            DataTable checkDuplicates = CSLoginRegisterForm.Connection.ServerConnection.executeSQL(yourSQL);

            if (checkDuplicates.Rows.Count > 0)
            {
                MessageBox.Show("The username already exists. Please try another username.",
                    " Registration Form : Insurance System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UsernameTextBox.SelectAll();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Do you want to save the record?", "Save Data : Insurance System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string mySQL = string.Empty;

                mySQL += "INSERT INTO Login1 (First_Name, Last_Name, Email_Address, Username, Password, Telephone, Pyment_Method,Insured , Type_User,Insurance_deal,Pymentn) ";
                mySQL += "VALUES ('" + FirstNameTextBox.Text + "','" + LastNameTextBox.Text + "','" + EmailTextBox.Text + "',";
                mySQL += "'" + UsernameTextBox.Text + "','" + PasswordTextBox.Text + "','" + TelephoneTextBox.Text + "','"+ PaymentMethodTextBox.Text + "','"+ InsuredBox.Text+"','" + TypeBox.Text +"','"+ InsurancedealBox.Text + "','" + Paymentnum.Text + "'    )";

                CSLoginRegisterForm.Connection.ServerConnection.executeSQL(mySQL);

                MessageBox.Show("The record has been saved successfully.",
                                "Save Data : Insurance System", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                clearControls();

            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        
    }
}
