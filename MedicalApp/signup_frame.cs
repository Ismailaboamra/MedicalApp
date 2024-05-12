using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using IronXL;

namespace MedicalApp
{
    public partial class SignUp_frm : Form
    {
        public SignUp_frm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            
            if (Username_txt.Text == "" || Password_txt.Text == "" || ConfirmPassword_txt.Text == "" || UsserID_txt.Text == "")
            {
                MessageBox.Show("Some of Text Box is Empty.", "Registration Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Username_txt.Text.Length < 6 || Username_txt.Text.Length > 8)
            {

                MessageBox.Show("The Username have to be between 6 - 8. ", "Registration Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Username_txt.Text.Count(c => Char.IsDigit(c)) > 2)
            {

                MessageBox.Show("The number Of Digits in Username have to be less than 2. ", "Registration Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Password_txt.Text.Length < 8 || Password_txt.Text.Length > 10)
            {

                MessageBox.Show("The Password have to be between 8 - 10. ", "Registration Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Password_txt.Text.Count(c => Char.IsDigit(c)) == 0 || Password_txt.Text.Count(c => Char.IsLetter(c)) == 0 || Password_txt.Text.Any(c => !Char.IsLetterOrDigit(c)) == false)
            {

                MessageBox.Show("The Password have to be Contains at least one Digits,Lettrs,Symbol", "Registration Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (UsserID_txt.Text.Length != 9 || UsserID_txt.Text.Count(c => Char.IsLetter(c)) != 0)
            {

                MessageBox.Show("The ID Have to be number wiht 9 digits. ", "Registration Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Password_txt.Text != ConfirmPassword_txt.Text)
            {

                MessageBox.Show("Passwords dosen't mathc.", "Registration Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                WriteToExcel_Signup(Username_txt.Text, Password_txt.Text, UsserID_txt.Text);
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Username_txt.Text = "";
            Password_txt.Text = "";
            ConfirmPassword_txt.Text = "";
            UsserID_txt.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Login_frm().Show();
            this.Hide();
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
            {
                Password_txt.PasswordChar = '\0';
                ConfirmPassword_txt.PasswordChar = '\0';
            }
            else
            {
                Password_txt.PasswordChar = '*';
                ConfirmPassword_txt.PasswordChar = '*';
            }
        }

        private void Password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_frm_Load(object sender, EventArgs e)
        {

        }

        private void WriteToExcel_Signup(string username, string password, string ID)
        {
            bool exist_ID = false,exist_username=false;
            WorkBook wb = WorkBook.Load("Data.xlsx");
            WorkSheet ws = wb.GetWorkSheet("Sheet1");
            int last_row = 2;
            while (ws["A" + last_row].StringValue != "")
            {
                last_row++;
            }

            var RangeID = ws.GetRange("C2:C"+last_row );
            var RangeUsername = ws.GetRange("A2:A" + last_row);
            foreach (var cell in RangeID)
            {
                if (ws[cell.AddressString].StringValue == ID)
                {
                    exist_ID = true;
                    break;
                }
            }

            foreach (var cell in RangeUsername)
            {
                if (ws[cell.AddressString].StringValue == username)
                {
                    exist_username = true;
                    break;
                }
            }
            if (exist_ID == false && exist_username == false)
            {
                ws["A" + last_row].Value = username;
                ws["B" + last_row].Value = password;
                ws["C" + last_row].Value = ID;

                wb.SaveAs("Data.xlsx");
                MessageBox.Show("successfullt Registration .", "successfullt Registration ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Username_txt.Text = "";
                Password_txt.Text = "";
                ConfirmPassword_txt.Text = "";
                UsserID_txt.Text = "";
            }
            else 
            {
                MessageBox.Show("This person is Alredy have Account.", "Field Registration ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
