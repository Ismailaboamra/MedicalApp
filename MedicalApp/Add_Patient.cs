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
    public partial class Add_Patient : Form
    {

        public Add_Patient()
        {
            InitializeComponent();
        }



        public void Add_Patient_from_excel(string[] details)
        {


            FS_txt.Text = details[0];
            LS_txt.Text = details[1];
            ID_txt.Text = details[2];
            Age_txt.Text = details[3];
            Gender_cmb.Text = details[4];
            Smke_cmb.Text = details[5];
            bleed_cmb.Text = details[6];
            pregant_cmb.Text = details[7];
            WBC_txt.Text = details[8];
            NEUT_txt.Text = details[9];
            Lymph_txt.Text = details[10];
            RBC_txt.Text = details[11];
            HCT_txt.Text = details[12];
            Urea_txt.Text = details[13];
            HB_txt.Text = details[14];
            Crtn_txt.Text = details[15];
            Iron_txt.Text = details[16];
            HDL_txt.Text = details[17];
            AP_txt.Text = details[18];

            Gender_cmb.SelectedItem = details[4];
            Smke_cmb.SelectedItem = details[5];
            bleed_cmb.SelectedItem = details[6];
            pregant_cmb.SelectedItem = details[7];

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            LS_txt.Text = "";
            FS_txt.Text = "";
            ID_txt.Text = "";
            Age_txt.Text = "";
            AP_txt.Text = "";
            HDL_txt.Text = "";
            Iron_txt.Text = "";
            Crtn_txt.Text = "";
            HB_txt.Text = "";
            WBC_txt.Text = "";
            Urea_txt.Text = "";
            HCT_txt.Text = "";
            RBC_txt.Text = "";
            Lymph_txt.Text = "";
            NEUT_txt.Text = "";
            Rcmnd_txt.Text = "";
            Diagnosis_txt.Text = "";
            Gender_cmb.SelectedItem = null;
            Smke_cmb.SelectedItem = null;
            pregant_cmb.SelectedItem = null;
            bleed_cmb.SelectedItem = null;




        }

        private void FS_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Age_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        public void SaveAll(string[] details)
        {
            bool exist_ID = false;
            WorkBook wb = WorkBook.Load("patient.xlsx");
            WorkSheet ws = wb.GetWorkSheet("Sheet1");
            int last_row = 2;
            while (ws["U" + last_row].Value != "" || ws["T" + last_row].Value != "")
            {
                last_row++;
            }

            var RangeID = ws.GetRange("C2:C" + last_row);
            foreach (var cell in RangeID)
            {
                if (ws[cell.AddressString].StringValue == details[2])
                {
                    exist_ID = true;
                    break;
                }
            }




            string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P","Q","R","S"};

            if (exist_ID == false)
            {

                int row_recomnd = last_row, row_Diagnosis=last_row;
                List<String> Recomnd = new List<string>();
                List<String> Diagnosis = new List<string>(DiagnosisAndRecommendation_Alogrithm(Recomnd));



                for (int i = 0; i < letters.Length; i++)
                    ws[letters[i] + last_row].StringValue = details[i];

                for (int i = 0; i < Diagnosis.Count; i++)
                {
                    ws["T" + row_Diagnosis].Value = Diagnosis[i];
                    row_Diagnosis++;
                    Console.WriteLine(Diagnosis[i]);
                    
                }

                for (int i = 0; i < Recomnd.Count; i++)
                {
                    ws["U" + row_recomnd].StringValue = Recomnd[i];
                    row_recomnd++;
                    Console.WriteLine(Recomnd[i]);

                }

                wb.SaveAs("patient.xlsx");
                MessageBox.Show("successfullt Save .", "Save All. ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LS_txt.Text = "";
                FS_txt.Text = "";
                ID_txt.Text = "";
                Age_txt.Text = "";
                AP_txt.Text = "";
                HDL_txt.Text = "";
                Iron_txt.Text = "";
                Crtn_txt.Text = "";
                HB_txt.Text = "";
                WBC_txt.Text = "";
                Urea_txt.Text = "";
                HCT_txt.Text = "";
                RBC_txt.Text = "";
                Lymph_txt.Text = "";
                NEUT_txt.Text = "";
                Rcmnd_txt.Text = "";
                Diagnosis_txt.Text = "";
                Gender_cmb.SelectedItem = null;
                Smke_cmb.SelectedItem = null;
                pregant_cmb.SelectedItem = null;
                bleed_cmb.SelectedItem = null;



            }
            else
            {
                MessageBox.Show("This patient is Alredy have data on the system .", "Field Save ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool isHigh_WBC(int age,int wbc)
        {
            if (age >= 18) {
                if (wbc > 11000)
                    return true;
                return false;
            }
            else if (age > 3 && age < 18)
            {
                if (wbc > 15500)
                    return true;
                return false;
            }
            else if (age >= 0 && age < 4)
            {
                if( wbc > 17500)
                    return true;
                return false;
            }  
            else {
                return false;
            }
        }
        public bool isLow_WBC(int age, int wbc)
        {
            if (age >= 18)
            {
                if (wbc < 4500)
                    return true;
                return false;
            }
            else if (age > 3 && age < 18)
            {
                if (wbc < 5500)
                    return true;
                return false;
            }
            else if (age >= 0 && age < 4)
            {
                if (wbc < 6000)
                    return true;
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool isHigh_NEUT(int neut)
        {
            if (neut > 54)
                return true;
            return false;
          
        }
        public bool isLow_NEUT(int neut)
        {
            if (neut < 28)
                return true;
            return false;

        }
        public bool isHigh_Lymph(int lym)
        {
            if (lym > 52)
                return true;
            return false;

        }
        public bool isLow_Lymph(int lym)
        {
            if (lym < 36)
                return true;
            return false;

        }

        public bool isHigh_RBC(float rbc)
        {
            if (rbc > 6.0)
                return true;
            return false;

        }
        public bool isLow_RBC(float rbc)
        {
            if (rbc < 4.5)
                return true;
            return false;

        }

        public bool isHigh_HCT(int hct, string gender)
        {
            if (gender == "Male")
            {
                if (hct > 54)
                    return true;
                return false;
            }
            else if(gender == "Female")
            {
                if (hct > 47)
                    return true;
                return false;
            }
            else
            {
                return false;
            }
        }
        public bool isLow_HCT(int hct, string gender)
        {
            if (gender == "Male")
            {
                if (hct < 37)
                    return true;
                return false;
            }
            else if (gender == "Female")
            {
                if (hct < 33)
                    return true;
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool isHigh_UREA(int urea)
        {
            if (urea > 43)
                return true;
            return false;

        }
        public bool isLow_UREA(int urea)
        {
            if (urea < 17 )
                return true;
            return false;

        }

        public bool isHigh_HB(float hb,string gender,int age)
        {
            if(age >= 18)
            {
                if(gender == "Male")
                {
                    if (hb > 18)
                        return true;
                    return false;
                }
                else
                {
                    if (hb > 16)
                        return true;
                    return false;
                }
            }
            else
            {
                if (hb > 15.5)
                    return true;
                return false;
            }
      
        }
        public bool isLow_HB(float hb, string gender, int age)
        {
            if (age >= 18)
            {
                if (hb < 12)
                    return true;    
                return false;
                
            }
            else
            {
                if (hb < 11.5)
                    return true;
                return false;
            }

        }

        public bool isHigh_CRTN(int age,float crtn)
        {
            if(age >=0 && age <= 2)
            {
                if (crtn > 0.5)
                    return true;
                return false;
            }
            else if (age >= 3 && age <=59)
            {
                if (crtn > 1)
                    return true;
                return false;
            }
            else 
            {
                if (crtn > 1.2)
                    return true;
                return false;
            }
        }
        public bool isLow_CRTN(int age, float crtn)
        {
            if (age >= 0 && age <= 2)
            {
                if (crtn < 0.2)
                    return true;
                return false;
            }
            else if (age >= 3 && age <= 17)
            {
                if (crtn < 0.5)
                    return true;
                return false;
            }
            else
            {
                if (crtn < 0.6)
                    return true;
                return false;
            }
        }

        public bool isHigh_Iron(int iron)
        {
            if (iron > 160)
                return true;
            return false;
        }
        public bool isLow_Iron(int iron)
        {
            if (iron < 60)
                return true;
            return false;
        }
        public bool isLow_HDL(int HDL, string gender)
        {
            if (gender == "Male")
            {
                if (HDL < 29)
                    return true;
                return false;
            }
            else if (gender == "Female")
            {
                if (HDL < 34)
                    return true;
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool isHigh_HDL(int HDL, string gender)
        {
            if (gender == "Male")
            {
                if (HDL > 62)
                    return true;
                return false;
            }
            else if (gender == "Female")
            {
                if (HDL > 82)
                    return true;
                return false;
            }
            else
            {
                return false;
            }
        }

        public bool isHigh_AP(int ap)
        {
            if (ap > 90)
                return true;
            return false;
        }
        public bool isLow_AP(int ap)
        {
            if (ap < 30)
                return true;
            return false;
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            float f;
            if (FS_txt.Text == "" || LS_txt.Text == "" || ID_txt.Text == "" || Age_txt.Text == "" || Gender_cmb.SelectedItem.ToString() == "" || WBC_txt.Text == "" || NEUT_txt.Text == "" || Lymph_txt.Text == ""
                || RBC_txt.Text == "" || HCT_txt.Text == "" || Urea_txt.Text == "" || HB_txt.Text == "" || Crtn_txt.Text == "" || Iron_txt.Text == "" || HDL_txt.Text == "" || AP_txt.Text == ""
                || Smke_cmb.SelectedItem.ToString() == "" || bleed_cmb.SelectedItem.ToString() == "" || pregant_cmb.SelectedItem.ToString() == "")
            {

                MessageBox.Show("Some of The TextBox is Empty .", "Field Save. ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (ID_txt.Text.Count(c => char.IsLetter(c)) != 0 || Age_txt.Text.Count(c => char.IsLetter(c)) != 0)
            {
                MessageBox.Show("The ID / Age have to be digits", "Field Save. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ID_txt.Text.Length != 9)
            {

                MessageBox.Show("The ID Have to be number wiht 9 digits. ", "Registration Failled", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (WBC_txt.Text.Count(c => char.IsLetter(c)) != 0 || NEUT_txt.Text.Count(c => char.IsLetter(c)) != 0 || Lymph_txt.Text.Count(c => char.IsLetter(c)) != 0
                || RBC_txt.Text.Count(c => char.IsLetter(c)) != 0 || HCT_txt.Text.Count(c => char.IsLetter(c)) != 0 || Urea_txt.Text.Count(c => char.IsLetter(c)) != 0 || HB_txt.Text.Count(c => char.IsLetter(c)) != 0
                || Iron_txt.Text.Count(c => char.IsLetter(c)) != 0 || HDL_txt.Text.Count(c => char.IsLetter(c)) != 0 || AP_txt.Text.Count(c => char.IsLetter(c)) != 0 || Crtn_txt.Text.Count(c => char.IsLetter(c)) != 0)
            {
                MessageBox.Show("The WBC / NEUT / LYMPH /RBC/HCT/UREA/HB/IRON/HDL/AP have to be digits", "Field Save. ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[] details =
                    {
            FS_txt.Text ,
            LS_txt.Text ,
            ID_txt.Text ,
            Age_txt.Text ,
            Gender_cmb.SelectedItem.ToString(),
            Smke_cmb.SelectedItem.ToString(),
            bleed_cmb.SelectedItem.ToString(),
            pregant_cmb.SelectedItem.ToString(),
            WBC_txt.Text ,
            NEUT_txt.Text,
            Lymph_txt.Text ,
            RBC_txt.Text ,
            HCT_txt.Text ,
            Urea_txt.Text ,
            HB_txt.Text ,
            Crtn_txt.Text ,
            Iron_txt.Text ,
            HDL_txt.Text ,
            AP_txt.Text ,
        };

                SaveAll(details);
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<string> DiagnosisAndRecommendation_Alogrithm(List<String> rcmnd)
        {

            List <String>diagnosis_exsits= new List<string>();
            //rcmnd = new List<string>();
            if (Smke_cmb.Text == "Yes")
            {
                diagnosis_exsits.Add("מעשנים");
                rcmnd.Add("להפסיק לעשן");
            }
            else if (isHigh_WBC(Int16.Parse(Age_txt.Text), Int16.Parse(WBC_txt.Text)))
            {
                if (isHigh_CRTN(Int16.Parse(Age_txt.Text), float.Parse(Crtn_txt.Text)))
                {
                    diagnosis_exsits.Add("סרטן"); 
                    rcmnd.Add("אנטרקטיניב-Entrectinib");
                }
                else
                {
                    diagnosis_exsits.Add("זיהום");
                    rcmnd.Add("אנטיביוטיקה ייעודית");
                    diagnosis_exsits.Add("מחלת דם");
                    rcmnd.Add(" שילוב של ציקלופוספאמיד וקורטיקוסרואידים");
                }
            }
            else if (isLow_WBC(Int16.Parse(Age_txt.Text), Int16.Parse(WBC_txt.Text)))
            {
                if (isHigh_CRTN(Int16.Parse(Age_txt.Text), float.Parse(Crtn_txt.Text)))
                {
                    diagnosis_exsits.Add("סרטן");
                    rcmnd.Add("אנטרקטיניב-Entrectinib");
                }
                else
                {
                    diagnosis_exsits.Add("מחלה ויראלית");
                    rcmnd.Add("לנוח בבית");
                }
            }
            else if (isHigh_NEUT(Int16.Parse(NEUT_txt.Text)))
            {
                diagnosis_exsits.Add("זיהום");
                rcmnd.Add("אנטיביוטיקה ייעודית");
            }
            else if (isLow_NEUT(Int16.Parse(NEUT_txt.Text)))
            {
                if (isHigh_CRTN(Int16.Parse(Age_txt.Text), float.Parse(Crtn_txt.Text)))
                {
                    diagnosis_exsits.Add("סרטן");
                    rcmnd.Add("אנטרקטיניב-Entrectinib");
                }
                else
                {
                    diagnosis_exsits.Add("זיהום");
                    rcmnd.Add("אנטיביוטיקה ייעודית");
                    diagnosis_exsits.Add("הפרעה ביצירת הדם / תאי דם");
                    rcmnd.Add(" \nכדור 10 מג של B12 ביום למשך חודש"+ "כדור 5 מג של חומצה פולית ביום למשך חודש");
                }
            }
            else if (isHigh_Lymph(Int16.Parse(Lymph_txt.Text)))
            {

                if (isHigh_CRTN(Int16.Parse(Age_txt.Text), float.Parse(Crtn_txt.Text)))
                {
                    diagnosis_exsits.Add("סרטן");
                    rcmnd.Add("אנטרקטיניב-Entrectinib");
                }
                else
                {
                    diagnosis_exsits.Add("זיהום");
                    rcmnd.Add("אנטיביוטיקה ייעודית");
                }
            }
            else if (isHigh_Lymph(Int16.Parse(Lymph_txt.Text)))
            {
                diagnosis_exsits.Add("הפרעה ביצירת הדם / תאי דם");
                rcmnd.Add(" \nכדור 10 מג של B12 ביום למשך חודש" + "כדור 5 מג של חומצה פולית ביום למשך חודש");
            }
            else if (isHigh_RBC(Int16.Parse(RBC_txt.Text)))
            {

                if (Smke_cmb.Text == "No")
                {
                    diagnosis_exsits.Add("הפרעה ביצירת הדם / תאי דם");
                    rcmnd.Add(" \nכדור 10 מג של B12 ביום למשך חודש" + "כדור 5 מג של חומצה פולית ביום למשך חודש");
                }
            }
            else if (isLow_RBC(Int16.Parse(RBC_txt.Text)))
            {
                 if (bleed_cmb.Text == "Yes")
                {
                    diagnosis_exsits.Add("דימום");
                    rcmnd.Add("להתפנות בדחיפות לבית החולים ");
                }
                else
                {
                    diagnosis_exsits.Add("אנמיה");
                    rcmnd.Add("שני כדורי 10 מג של B12 ביום למשך חודש ");
                }
            }
            else if (isLow_HCT(Int16.Parse(RBC_txt.Text),Gender_cmb.SelectedItem.ToString()))
            {
                if (bleed_cmb.Text == "Yes")
                {
                    diagnosis_exsits.Add("דימום");
                    rcmnd.Add("להתפנות בדחיפות לבית החולים ");
                }
                else
                {
                    diagnosis_exsits.Add("אנמיה");
                    rcmnd.Add("שני כדורי 10 מג של B12 ביום למשך חודש ");
                }
            }
            else if (isHigh_UREA(Int16.Parse(Urea_txt.Text)))
            {
                diagnosis_exsits.Add("מחלת כליה");
                rcmnd.Add("איזון את רמות הסוכר בדם ");
                diagnosis_exsits.Add("מחלת כבד");
                rcmnd.Add("הפנייה לאבחנה ספציפית לצורך קביעת טיפול ");
                diagnosis_exsits.Add("התייבשות");
                rcmnd.Add("מנוחה מוחלטת בשכיבה, החזרת נוזלים בשתייה ");
                diagnosis_exsits.Add("מחלת דיאטה");
                rcmnd.Add("לתאם פגישה עם תזונאי ");
            }
            else if (isLow_UREA(Int16.Parse(Urea_txt.Text)))
            {
                diagnosis_exsits.Add("מחלת כבד");
                rcmnd.Add("הפנייה לאבחנה ספציפית לצורך קביעת טיפול ");
                diagnosis_exsits.Add("תת תזונה");
                diagnosis_exsits.Add("מחלת דיאטה");
                rcmnd.Add("לתאם פגישה עם תזונאי ");
            }
            else if (isLow_HB(float.Parse(HB_txt.Text), Gender_cmb.SelectedItem.ToString(), Int16.Parse(Age_txt.Text)))
            {
                if(bleed_cmb.Text == "No" && !isLow_Iron(Int16.Parse(Iron_txt.Text)))
                {
                    diagnosis_exsits.Add("אנמיה");
                    rcmnd.Add("שני כדורי 10 מג של B12 ביום למשך חודש ");
                }
            }
            else if (isHigh_CRTN(Int16.Parse(Age_txt.Text), float.Parse(Crtn_txt.Text)))
            {
                diagnosis_exsits.Add("מחלת כליה");
                rcmnd.Add("איזון את רמות הסוכר בדם ");
                diagnosis_exsits.Add("מחלות שריר");
                rcmnd.Add("שני כדורי 5 מג של כורכום c3 של אלטמן ביום למשך חודש ");

            }else if (isLow_CRTN(Int16.Parse(Age_txt.Text), float.Parse(Crtn_txt.Text)))
            {
                diagnosis_exsits.Add("תת תזונה");
                rcmnd.Add("לתאם פגישה עם תזונאי ");
            }
            else if (isLow_HDL(Int16.Parse(HDL_txt.Text), Gender_cmb.SelectedItem.ToString()))
            {
                diagnosis_exsits.Add("מחלות לב");
                rcmnd.Add("לתאם פגישה עם תזונאי ");
                diagnosis_exsits.Add("סוכרת מבוגרים");
                rcmnd.Add("התאמת אינסולין למטופל ");
                diagnosis_exsits.Add("היפרליפידמיה ");
                rcmnd.Add(" לתאם פגישה עם תזונאי, כדור 5 מג של סימוביל ביום למשך שבוע ");
            }
            else if (isHigh_AP(Int16.Parse(AP_txt.Text)))
            {
                diagnosis_exsits.Add("מחלת כבד");
                rcmnd.Add("הפנייה לאבחנה ספציפית לצורך קביעת טיפול ");
                diagnosis_exsits.Add("מחלות בדרכי המרה");
                rcmnd.Add("הפנייה לטיפול כירורגי ");
                diagnosis_exsits.Add("שימוש בתרופות שונות ");
                rcmnd.Add("הפנייה לרופא המשפחה לצורך בדיקת התאמה בין התרופות ");
            }
            else if (isLow_AP(Int16.Parse(AP_txt.Text)))
            {
                diagnosis_exsits.Add("חוסר בוויטמינים");
                rcmnd.Add("הפנייה לבדיקת דם לזיהוי הוויטמינים החסרים ");
            }



            return diagnosis_exsits;
        }

        private void ViewReport_Click(object sender, EventArgs e)
        {
            List<String> Recomnd = new List<string>();
            List<String> Diagnosis = new List<string>(DiagnosisAndRecommendation_Alogrithm(Recomnd));
            for (int i = 0; i < Recomnd.Count; i++)
                Rcmnd_txt.AppendText((i+1) + " - " + Recomnd[i]+"\n");
            for (int i = 0; i < Diagnosis.Count; i++)
                Diagnosis_txt.AppendText((i + 1)+" - " + Diagnosis[i]+ "\n");

           
        }
    }
}
    

