using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronXL;

namespace MedicalApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Add_Patient().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           // string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P" };
            
            WorkBook wb = new WorkBook("add_patient.xlsx");
            WorkSheet ws = wb.GetWorkSheet("Sheet1");
            string[] data = { ws["A2"].StringValue,ws["B2"].StringValue,ws["C2"].StringValue,ws["D2"].StringValue,ws["E2"].StringValue,ws["F2"].StringValue,ws["G2"].StringValue,
                        ws["H2"].StringValue,
                        ws["I2"].StringValue,
                        ws["J2"].StringValue,
                        ws["K2"].StringValue,
                        ws["L2"].StringValue,
                        ws["M2"].StringValue,
                        ws["N2"].StringValue,
                        ws["O2"].StringValue,
                        ws["P2"].StringValue,
                        ws["Q2"].StringValue,
                        ws["R2"].StringValue,
                        ws["S2"].StringValue,
            };
            Add_Patient ap = new Add_Patient();
            ap.Show();
            this.Hide();
            ap.Add_Patient_from_excel(data);
            this.Hide();
           
        }
    }
}
