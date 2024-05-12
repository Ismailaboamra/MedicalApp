using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using IronXL;



namespace MedicalApp
{
    public partial class Login_frm : Form
    {
        public Login_frm()
        {
            InitializeComponent();
        }

        private void Login_frm_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (Username_txt.Text == "" || Password_txt.Text == "")
            {
                MessageBox.Show("Some of Text Box is Empty.", "Registration Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                WorkBook wb = new WorkBook("Data.xlsx");
                WorkSheet ws = wb.GetWorkSheet("Sheet1");
                int last_row = 2;
                while (ws["A" + last_row].Value != "")
                {
                    last_row++;
                }
                var username = ws.GetRange("A2:A"+ last_row);
                bool userflag = false;

                foreach (var cell in username)
                {
                    if (ws[cell.AddressString].StringValue == Username_txt.Text)
                    {
                        userflag = true;
                        if (ws["B"+ (cell.RowIndex+1)].StringValue == Password_txt.Text)
                        {
                            new Main().Show();
                            this.Hide();
                            break;
                        }
                        else
                        {

                            MessageBox.Show("The password/Username is wrong, Try again.", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }

                    }
                }
                if (userflag == false)
                    MessageBox.Show("This is Username is not found , you can creat Account.", "Wrong Username", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new SignUp_frm().Show();
            this.Hide();
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
            {
                Password_txt.PasswordChar = '\0';
            }
            else
            {
                Password_txt.PasswordChar = '*';
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Username_txt.Text = "";
            Password_txt.Text = "";
        }
    }
}
