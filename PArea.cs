using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystem
{
    public partial class PArea : Form
    {
        Boolean flag = true;
        public PArea()
        {
            InitializeComponent();
        }

        //import of excel file
        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            string file = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            Excel excel = null;
            if (result == DialogResult.OK) // Test result.
            {
                file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    excel = new Excel(file, 1, this);
                    excel.setInfo();
                    
                }
                catch (IOException)
                {
                }
            }
            else
            {
                return;
            }
            excel.getWb().Close();
            excel.getExcel().Quit();
        }

        public void setWBC(string wbc)
        {
            WBC.Text = wbc;
        }
        public void setNeut(string neut)
        {
            Neut.Text = neut;
        }
        public void setLymph(string lymph)
        {
            Lymph.Text = lymph;
        }
        public void setRBC(string rbc)
        {
            RBC.Text = rbc;
        }
        public void setHCT(string hct)
        {
            HCT.Text = hct;
        }
        public void setUrea(string urea)
        {
            Urea.Text = urea;
        }
        public void setHb(string hb)
        {
            Hb.Text = hb;
        }
        public void setCrtn(string crtn)
        {
            Crtn.Text = crtn;
        }
        public void setIron(string iron)
        {
            Iron.Text = iron;
        }
        public void setHDL(string hdl)
        {
            HDL.Text = hdl;
        }
        public void setAP(string ap)
        {
            AP.Text = ap;
        }

        public String getName()
        {
            return Convert.ToString(firstname.Text);
        }
        public String getLastName()
        {
            return Convert.ToString(lastname.Text);
        }
        public String getId()
        {
            return Convert.ToString(id.Text);
        }
        public String getGender()
        {
            return Convert.ToString(gender.Text);
        }
        public String getAge()
        {
            return Convert.ToString(age.Text);
        }
        public String getPregnant()
        {
            if (pregnant.Checked)
                return "Yes";
            return "No";
        }
        public String getEthiopi()
        {
            if (etiopia.Checked)
                return "Yes";
            return "No";
        }
        public String getEast()
        {
            if (east.Checked)
                return "Yes";
            return "No";
        }
        public String getWbc()
        {
            return Convert.ToString(WBC.Text);
        }
        public String getNeut()
        {
            return Convert.ToString(Neut.Text);
        }
        public String getLymph()
        {
            return Convert.ToString(Lymph.Text);
        }
        public String getRbc()
        {
            return Convert.ToString(RBC.Text);
        }
        public String getHct()
        {
            return Convert.ToString(HCT.Text);
        }
        public String getUrea()
        {
            return Convert.ToString(Urea.Text);
        }
        public String getHb()
        {
            return Convert.ToString(Hb.Text);
        }
        public String getCrtn()
        {
            return Convert.ToString(Crtn.Text);
        }
        public String getIron()
        {
            return Convert.ToString(Iron.Text);
        }
        public String getHdl()
        {
            return Convert.ToString(HDL.Text);
        }
        public String getAp()
        {
            return Convert.ToString(AP.Text);
        }


        //test that user entered something to fields
        private void button2_Click(object sender, EventArgs e)
        {
            //PatientFName
            if (firstname.Text == "")
            {
                MessageBox.Show("Eneter a name of the patient.");
                return;
            }
            //PatientLName
            if (lastname.Text == "")
            {
                MessageBox.Show("Enter a last name of the patient.");
                return;
            }
            //Patient ID
            if (id.Text == "")
            {
                MessageBox.Show("Enter an Id of the patient.");
                return;
            }
            //Patient gender
            if (gender.Text == "")
            {
                MessageBox.Show("Enter an gender of the patient.");
                return;
            }
            //Patient age
            if (age.Text == "")
            {
                MessageBox.Show("Enter an age of the patient.");
                return;
            }
            //Patient wbc
            if (WBC.Text == "")
            {
                MessageBox.Show("Enter an WBC of the patient.");
                return;
            }
            //Patient Neut
            if (Neut.Text == "")
            {
                MessageBox.Show("Enter an Neut of the patient.");
                return;
            }
            //Patient Lymph
            if (Lymph.Text == "")
            {
                MessageBox.Show("Enter an Lymph of the patient.");
                return;
            }
            //Patient RBC
            if (RBC.Text == "")
            {
                MessageBox.Show("Enter an RBC of the patient.");
                return;
            }
            //Patient HCT
            if (HCT.Text == "")
            {
                MessageBox.Show("Enter an HCT of the patient.");
                return;
            }
            //Patient Urea
            if (Urea.Text == "")
            {
                MessageBox.Show("Enter an Urea of the patient.");
                return;
            }
            //Patient Hb
            if (Hb.Text == "")
            {
                MessageBox.Show("Enter an Hb of the patient.");
                return;
            }
            //Patient Ctrn
            if (Crtn.Text == "")
            {
                MessageBox.Show("Enter an Crtn of the patient.");
                return;
            }
            //Patient Iron
            if (Iron.Text == "")
            {
                MessageBox.Show("Enter an Iron of the patient.");
                return;
            }
            //Patient HDL
            if (HDL.Text == "")
            {
                MessageBox.Show("Enter an HDL of the patient.");
                return;
            }
            //Patient age
            if (age.Text == "")
            {
                MessageBox.Show("Enter an age of the patient.");
                return;
            }
            //Patient AP
            if (AP.Text == "")
            {
                MessageBox.Show("Enter an AP of the patient.");
                return;
            }
            // Check correction of the parametres
            if (!this.flag)
            {
                MessageBox.Show("One of the parametres is Incorrect!");
                return;
            }

            //here we check diseases

            Boolean flag = false;
            var info = new Info(this);
            //sartan
            if (Convert.ToInt32(Neut.Text) < 28 || Convert.ToInt32(Neut.Text) > 54)
            {
                if (Convert.ToInt32(Lymph.Text) > 52)
                {
                    if (Convert.ToInt32(age.Text) >= 0 && Convert.ToInt32(age.Text) <= 3)
                    {
                        if (Convert.ToInt32(WBC.Text) > 17500 || Convert.ToInt32(WBC.Text) < 6000)
                        {
                            flag = true;
                            info.setDisease("סרטן", "אנטרקטיניב - Entrectinib");
                        }

                    }
                    if (Convert.ToInt32(age.Text) >= 4 && Convert.ToInt32(age.Text) <= 17)
                    {
                        if (Convert.ToInt32(WBC.Text) > 15500 || Convert.ToInt32(WBC.Text) < 5500)
                        {
                            flag = true;
                            info.setDisease("סרטן", "אנטרקטיניב - Entrectinib");
                        }
                    }
                    if (Convert.ToInt32(age.Text) >= 18)
                    {
                        if (Convert.ToInt32(WBC.Text) > 11000 || (Convert.ToInt32(WBC.Text) < 4500))
                        {
                            flag = true;
                            info.setDisease("סרטן", "אנטרקטיניב - Entrectinib");
                        }
                    }
                    //zihum
                    if (Convert.ToInt32(Neut.Text) > 54)
                    {
                        flag = true;
                        info.setDisease("זיהום", "אנטיביוטיקה ייעודית");
                        
                    }
                }
            }
            if (Convert.ToString(gender.Text) == "זכר")
            {
                if (Convert.ToDouble(RBC.Text) < 4.5)
                {
                    if (Convert.ToInt32(HCT.Text) < 37)
                    {
                        if (Convert.ToInt32(age.Text) > 17)
                        {
                            //dimum
                            if (Convert.ToInt32(Iron.Text) < 60)
                            {
                                flag = true;
                                info.setDisease("דימום", "להתפנות בדחיפות לבית החולים");
                            }
                            //anemia
                            if (Convert.ToDouble(Hb.Text) < 12)
                            {
                                flag = true;
                                info.setDisease("אנמיה", "שני כדורי 10 מ''ג של ב12 ביום למשך חודש");
                            }

                        }
                        if (Convert.ToInt32(age.Text) >= 0 && Convert.ToInt32(age.Text) <= 17)
                        {
                            //dimum
                            if (Convert.ToInt32(Iron.Text) < 60)
                            {
                                flag = true;
                                info.setDisease("דימום", "להתפנות בדחיפות לבית החולים");
                            }
                            //anemia
                            if (Convert.ToDouble(Hb.Text) < 11.5)
                            {
                                flag = true;
                                info.setDisease("אנמיה", "שני כדורי 10 מ''ג של ב12 ביום למשך חודש");
                            }

                        }
                    }
                }
                if (Convert.ToDouble(RBC.Text) > 6)
                {
                    //meashnim
                    if (Convert.ToInt32(HCT.Text) > 54)
                    {
                        flag = true;
                        info.setDisease("מעשנים", "להפסיק לעשן");
                    }
                }
                if (Convert.ToInt32(age.Text) > 17 && Convert.ToInt32(Hb.Text) < 12)
                {
                    //mahsor barzel
                    if (Convert.ToDouble(Iron.Text) < 60)
                    {
                        flag = true;
                        info.setDisease("מחסור בברזל", "שני כדורי 10 מ''ג ב12 ביום למשך חודש");
                    }
                }

                if (Convert.ToInt32(age.Text) >= 0 && Convert.ToInt32(age.Text) <= 17 && Convert.ToDouble(Hb.Text) < 11.5)
                {
                    //mahsor barzel
                    if (Convert.ToDouble(Iron.Text) < 60)
                    {
                        flag = true;
                        info.setDisease("מחסור בברזל", "שני כדורי 10 מ''ג ב12 ביום למשך חודש");
                    }
                }

            }
            if (Convert.ToString(gender.Text) == "נקבה")
            {
                if (Convert.ToDouble(RBC.Text) < 4.5)
                {
                    if (Convert.ToInt32(HCT.Text) < 33)
                    {
                        if (Convert.ToInt32(age.Text) > 17)
                        {
                            //dimum
                            if (Convert.ToInt32(Iron.Text) < 48)
                            {
                                flag = true;
                                info.setDisease("דימום", "להתפנות בדחיפות לבית החולים");
                            }
                            //anemia
                            if (Convert.ToInt32(Hb.Text) < 12)
                            {
                                flag = true;
                                info.setDisease("אנמיה", "שני כדורי 10 מ''ג של ב12 ביום למשך חודש");
                            }

                        }
                        if (Convert.ToInt32(age.Text) >= 0 && Convert.ToInt32(age.Text) <= 17)
                        {
                            //dimum
                            if (Convert.ToInt32(Iron.Text) < 48)
                            {
                                flag = true;
                                info.setDisease("דימום", "להתפנות בדחיפות לבית החולים");
                            }
                            //anemia
                            if (Convert.ToInt32(Hb.Text) < 11.5)
                            {
                                flag = true;
                                info.setDisease("אנמיה", "שני כדורי 10 מ''ג של ב12 ביום למשך חודש");
                            }
                        }
                    }
                }

                if (Convert.ToInt32(age.Text) > 17 && Convert.ToInt32(Hb.Text) < 12)
                {
                    //mahsor barzel
                    if (Convert.ToDouble(Iron.Text) < 48)
                    {
                        flag = true;
                        info.setDisease("מחסור בברזל", "שני כדורי 10 מ''ג ב12 ביום למשך חודש");
                    }
                }

                if (Convert.ToInt32(age.Text) >= 0 && Convert.ToInt32(age.Text) <= 17 && Convert.ToDouble(Hb.Text) < 11.5)
                {
                    //mahsor barzel
                    if (Convert.ToDouble(Iron.Text) < 48)
                    {
                        flag = true;
                        info.setDisease("מחסור בברזל", "שני כדורי 10 מ''ג ב12 ביום למשך חודש");
                    }
                }
                

            }

            //tat tzuna
            if (Convert.ToDouble(age.Text) >= 0 && Convert.ToDouble(age.Text) <= 2)
            {
                if (!east.Checked)
                {
                    if (Convert.ToDouble(Crtn.Text) < 0.2 && Convert.ToDouble(Urea.Text) < 17 && !pregnant.Checked)
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                    }
                }
                else
                {
                    if (Convert.ToDouble(Crtn.Text) < 0.2 && Convert.ToDouble(Urea.Text) < 18.7 && !pregnant.Checked)
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                    }
                }
            }
            if (Convert.ToDouble(age.Text) >= 3 && Convert.ToDouble(age.Text) <= 17)
            {
                if (!east.Checked)
                {
                    if (Convert.ToDouble(Crtn.Text) < 0.5 && Convert.ToDouble(Urea.Text) < 17 && !pregnant.Checked)
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                    }
                }
                else
                {
                    if (Convert.ToDouble(Crtn.Text) < 0.5 && Convert.ToDouble(Urea.Text) < 18.7 && !pregnant.Checked)
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                    }
                }
            }
            if (Convert.ToDouble(age.Text) >= 18)
            {
                if (!east.Checked)
                {
                    if (Convert.ToDouble(Crtn.Text) < 0.6 && Convert.ToDouble(Urea.Text) < 17 && !pregnant.Checked)
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                    }
                }
                else
                {
                    if (Convert.ToDouble(Crtn.Text) < 0.6 && Convert.ToDouble(Urea.Text) < 18.7 && !pregnant.Checked)
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                    }
                }
            }
         

            if (!flag)
            {   
                //RBC
                if (Convert.ToDouble(RBC.Text) < 4.5 && !flag)
                {
                    flag = true;
                    info.setDisease("אנמיה", "שני כדורי 10 מ''ג של ב12 ביום למשך חודש");
                    info.setDisease("דימום", "להתפנות בדחיפות לבית החולים");
                    
                }
                if (Convert.ToDouble(RBC.Text) > 6 && !flag)
                {
                    flag = true;
                    info.setDisease("מעשנים", "להפסיק לעשן");
                    info.setDisease("הפרעה ביצירת הדם / תאי דם", "כדור 5 מ''ג של חומצה פולית ביום למשך חודש כדור 10 מ''ג של ב12 ביום למשך חודש\n");
                    info.setDisease("מחלת ריאות", "להפסיק לעשן / הפנייה לצילום רנטגן של הריאות");
                }
                //Neut incorrect
                if (Convert.ToDouble(Neut.Text) < 28 && !flag)
                {
                    flag = true;
                    info.setDisease("הפרעה ביצירת הדם / תאי דם", "כדור 5 מ''ג של חומצה פולית ביום למשך חודש כדור 10 מ''ג של ב12 ביום למשך חודש\n");
                    info.setDisease("זיהום", "אנטיביוטיקה ייעודית");
                    info.setDisease("סרטן(מקרה נדיר)", "אנטרקטיניב - Entrectinib");
                }
                if (Convert.ToDouble(Neut.Text) > 54 && !flag)
                {
                    flag = true;
                    info.setDisease("זיהום", "אנטיביוטיקה ייעודית");
                }
                //Lymph incorrect
                if (Convert.ToDouble(Lymph.Text) < 36 && !flag)
                {
                    flag = true;
                    info.setDisease("הפרעה ביצירת הדם / תאי דם", "כדור 5 מ''ג של חומצה פולית ביום למשך חודש כדור 10 מ''ג של ב12 ביום למשך חודש\n");
                }
                if (Convert.ToDouble(Lymph.Text) > 52 && !flag)
                {
                    flag = true;
                    info.setDisease("זיהום", "אנטיביוטיקה ייעודית");
                    info.setDisease("סרטן(מקרה נדיר) לימפומה", "אנטרקטיניב - Entrectinib");
                }
                //Urea incorrect
                if (!east.Checked)
                {
                    if (Convert.ToDouble(Urea.Text) < 17 && !flag)
                    {
                        if (Convert.ToString(gender.Text) == "נקבה" && pregnant.Checked)
                        {
                            info.setDisease("הריון", "UREA בהריון צריכה להיות נמוכה");
                        }
                        else
                        {
                            flag = true;
                            info.setDisease("דיאטה", "לתאם פגישה עם תזונאי");
                            info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                            info.setDisease("מחלת כבד", "הפנייה לאבחנה ספציפית לצורך קביעת טיפול");
                        }
                    }
                    if (Convert.ToDouble(Urea.Text) > 43 && !flag)
                    {
                        flag = true;
                        info.setDisease("התייבשות", "מנוחה מוחלטת בשכיבה, החזרת נוזלים בשתייה");
                        info.setDisease("מחלת כליה", "איזון את רמות הסוכר בדם");
                        info.setDisease("דיאטה", "לתאם פגישה עם תזונאי");
                    }
                }
                else
                {
                    if (Convert.ToDouble(Urea.Text) < 18.7 && !flag)
                    {
                        if (Convert.ToString(gender.Text) == "נקבה" && pregnant.Checked)
                        {
                            info.setDisease("הריון", "UREA בהריון צריכה להיות נמוכה");
                        }
                        else
                        {
                            flag = true;
                            info.setDisease("דיאטה", "לתאם פגישה עם תזונאי");
                            info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                            info.setDisease("מחלת כבד", "הפנייה לאבחנה ספציפית לצורך קביעת טיפול");
                        }
                    }
                    if (Convert.ToDouble(Urea.Text) > 47.3 && !flag)
                    {
                        flag = true;
                        info.setDisease("התייבשות", "מנוחה מוחלטת בשכיבה, החזרת נוזלים בשתייה");
                        info.setDisease("מחלת כליה", "איזון את רמות הסוכר בדם");
                        info.setDisease("דיאטה", "לתאם פגישה עם תזונאי");
                    }
                }
                //AP incorrect
                if (!east.Checked)
                {
                    if (Convert.ToDouble(AP.Text) < 30 && !flag)
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                        info.setDisease("חוסר בוויטמינים", "הפנייה לבדיקת דם לזיהוי הוויטמינים החסרים");
                    }
                    if (Convert.ToDouble(AP.Text) > 90 && !flag)
                    {
                        flag = true;
                        info.setDisease("מחלת כבד", "הפנייה לאבחנה ספציפית לצורך קביעת טיפול");
                        info.setDisease("מחלות בדרכי המרה", "הפנייה לטיפול כירורגי");
                        info.setDisease("פעילות יתר של בלוטת התריס", "Propylthiouracil להקטנת פעילות בלוטת התריס");
                        info.setDisease("שימוש בתרופות שונות", "הפנייה לרופא המשפחה לצורך בדיקת התאמה בין התרופות");
                    }
                }
                else
                {
                    if (Convert.ToDouble(AP.Text) < 60 && !flag)
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                        info.setDisease("חוסר בוויטמינים", "הפנייה לבדיקת דם לזיהוי הוויטמינים החסרים");
                    }
                    if (Convert.ToDouble(AP.Text) > 120 && !flag)
                    {
                        flag = true;
                        info.setDisease("מחלת כבד", "הפנייה לאבחנה ספציפית לצורך קביעת טיפול");
                        info.setDisease("מחלות בדרכי המרה", "הפנייה לטיפול כירורגי");
                        info.setDisease("פעילות יתר של בלוטת התריס", "Propylthiouracil להקטנת פעילות בלוטת התריס");
                        info.setDisease("שימוש בתרופות שונות", "הפנייה לרופא המשפחה לצורך בדיקת התאמה בין התרופות");
                    }
                }
                //WBC incorrect
                if (Convert.ToDouble(age.Text) >= 0 && Convert.ToDouble(age.Text) <= 3)
                {
                    if (Convert.ToDouble(WBC.Text) < 6000 && !flag)
                    {
                        flag = true;
                        info.setDisease("מחלה ויראלית", "לנוח בבית");
                        info.setDisease("סרטן(מקרה נדיר) ", "אנטרקטיניב - Entrectinib");
                    }
                    if (Convert.ToDouble(WBC.Text) > 17500 && !flag)
                    {
                        flag = true;
                        info.setDisease("זיהום", "אנטיביוטיקה ייעודית");
                        info.setDisease("מחלת דם", "שילוב של ציקלופוספאמיד וקורטיקוסרואידים");
                        info.setDisease("סרטן", "אנטרקטיניב - Entrectinib");
                    }
                    //Crtn
                    if (Convert.ToDouble(age.Text) < 3)
                    {
                        if (Convert.ToDouble(Crtn.Text) < 0.2 && !flag)
                        {
                            flag = true;
                            info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                            info.setDisease("מחלות שריר", "שני כדורי 5 מג של כורכום c3 של אלטמן ביום למשך חודש");
                        }
                        if(Convert.ToDouble(Crtn.Text) > 0.5 && !flag)
                        {
                            flag = true;
                            info.setDisease("מחלת כליה", "איזון את רמות הסוכר בדם");
                            info.setDisease("צריכה מוגברת של בשר", "לתאם פגישה עם תזונאי");
                            info.setDisease("מחלות שריר", "שני כדורי 5 מג של כורכום c3 של אלטמן ביום למשך חודש");
                        }
                    }
                }
                //Crtn
                if (Convert.ToDouble(age.Text) >= 3 && Convert.ToDouble(age.Text) <= 17)
                {
                    if (Convert.ToDouble(Crtn.Text) < 0.5 && !flag) 
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                        info.setDisease("מחלות שריר", "שני כדורי 5 מג של כורכום c3 של אלטמן ביום למשך חודש");
                    }
                    if (Convert.ToDouble(Crtn.Text) > 1 && !flag)
                    {
                        flag = true;
                        info.setDisease("מחלת כליה", "איזון את רמות הסוכר בדם");
                        info.setDisease("צריכה מוגברת של בשר", "לתאם פגישה עם תזונאי");
                        info.setDisease("מחלות שריר", "שני כדורי 5 מג של כורכום c3 של אלטמן ביום למשך חודש");
                    }
                }
                if (Convert.ToDouble(age.Text) >= 4 && Convert.ToDouble(age.Text) <= 17)
                {
                    if (Convert.ToDouble(WBC.Text) < 5500 && !flag)
                    {
                        flag = true;
                        info.setDisease("מחלה ויראלית", "לנוח בבית");
                        info.setDisease("סרטן(מקרה נדיר) ", "אנטרקטיניב - Entrectinib");
                    }
                    if (Convert.ToDouble(WBC.Text) > 15500 && !flag)
                    {
                        flag = true;
                        info.setDisease("זיהום", "אנטיביוטיקה ייעודית");
                        info.setDisease("מחלת דם", "שילוב של ציקלופוספאמיד וקורטיקוסרואידים");
                        info.setDisease("סרטן", "אנטרקטיניב - Entrectinib");
                    }
                }
                //Crtn
                if (Convert.ToDouble(age.Text) >= 18 && Convert.ToDouble(age.Text) <= 59)
                {
                    if (Convert.ToDouble(Crtn.Text) > 1 && !flag)
                    {
                        flag = true;
                        info.setDisease("מחלת כליה", "איזון את רמות הסוכר בדם");
                        info.setDisease("צריכה מוגברת של בשר", "לתאם פגישה עם תזונאי");
                        info.setDisease("מחלות שריר", "שני כדורי 5 מג של כורכום c3 של אלטמן ביום למשך חודש");
                    }
                }
                if (Convert.ToDouble(age.Text) >= 60)
                {
                    if (Convert.ToDouble(Crtn.Text) > 1.2 && !flag)
                    {
                        flag = true;
                        info.setDisease("מחלת כליה", "איזון את רמות הסוכר בדם");
                        info.setDisease("צריכה מוגברת של בשר", "לתאם פגישה עם תזונאי");
                        info.setDisease("מחלות שריר", "שני כדורי 5 מג של כורכום c3 של אלטמן ביום למשך חודש");
                    }
                }
                if (Convert.ToDouble(age.Text) >= 18)
                {
                    if (Convert.ToDouble(WBC.Text) < 4500 && !flag)
                    {
                        flag = true;
                        info.setDisease("מחלה ויראלית", "לנוח בבית");
                        info.setDisease("סרטן(מקרה נדיר) ", "אנטרקטיניב - Entrectinib");
                    }
                    if (Convert.ToDouble(WBC.Text) > 11000 && !flag)
                    {
                        flag = true;
                        info.setDisease("זיהום", "אנטיביוטיקה ייעודית");
                        info.setDisease("מחלת דם", "שילוב של ציקלופוספאמיד וקורטיקוסרואידים");
                        info.setDisease("סרטן", "אנטרקטיניב - Entrectinib");
                    }
                    //Crtn
                    if (Convert.ToDouble(Crtn.Text) < 0.6 && !flag)
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                        info.setDisease("מחלות שריר", "שני כדורי 5 מג של כורכום c3 של אלטמן ביום למשך חודש");
                    }
                }
                
                //HB incorrect
                if (Convert.ToDouble(age.Text) > 17)
                {
                    if (Convert.ToDouble(HCT.Text) < 12 && !flag)
                    {
                        flag = true;
                        info.setDisease("אנמיה", "שני כדורי 10 מ''ג של ב12 ביום למשך חודש");
                        info.setDisease("הפרעה המטולוגית", "זריקה של הורמון לעידוד ייצור תאי הדם האדומים");
                        info.setDisease("מחסור בברזל", "שני כדורי 10 מ''ג ב12 ביום למשך חודש");
                        info.setDisease("דימום", "להתפנות בדחיפות לבית החולים");
                    } 
                }
                else
                {
                    if (Convert.ToDouble(HCT.Text) < 11.5 && !flag)
                    {
                        flag = true;
                        info.setDisease("אנמיה", "שני כדורי 10 מ''ג של ב12 ביום למשך חודש");
                        info.setDisease("הפרעה המטולוגית", "זריקה של הורמון לעידוד ייצור תאי הדם האדומים");
                        info.setDisease("מחסור בברזל", "שני כדורי 10 מ''ג ב12 ביום למשך חודש");
                        info.setDisease("דימום", "להתפנות בדחיפות לבית החולים");
                    }
                }
                //HCT incorrect
                if (Convert.ToString(gender.Text) == "זכר")
                {
                    if (Convert.ToDouble(HCT.Text) < 37 && !flag)
                    {
                        flag = true;
                        info.setDisease("אנמיה", "שני כדורי 10 מ''ג של ב12 ביום למשך חודש");
                        info.setDisease("דימום", "להתפנות בדחיפות לבית החולים");
                    }
                    if (Convert.ToDouble(HCT.Text) > 54 && !flag)
                    {
                        flag = true;
                        info.setDisease("מחלת ריאות", "להפסיק לעשן / הפנייה לצילום רנטגן של הריאות");
                    }
                    //Barzel incorrect
                    if (Convert.ToDouble(Iron.Text) < 60 && !flag)
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                        info.setDisease("מחסור בברזל", "שני כדורי 10 מג של B12 ביום למשך חודש");
                    }
                    if (Convert.ToDouble(Iron.Text) > 160 && !flag)
                    {
                        flag = true;
                        info.setDisease("הרעלת ברזל", "להתפנות לבית החולים");
                    }
                    //HDL Incorrect
                    if (!etiopia.Checked)
                    {
                        if (Convert.ToDouble(HDL.Text) < 29 && !flag)
                        {
                            flag = true;
                            info.setDisease("מחלות לב", "לתאם פגישה עם תזונאי");
                            info.setDisease("סוכרת מבוגרים", "התאמת אינסולין למטופל");
                            info.setDisease("היפרליפידמיה )שומנים בדם(", "לתאם פגישה עם תזונאי, כדור 5 מג של סימוביל ביום למשך שבוע");
                        }
                        if (Convert.ToDouble(HDL.Text) > 62 && !flag)
                        {
                            flag = true;
                            info.setDisease("לא מזיק", "פעולות גופניות");
                        }
                    }
                    else
                    {
                        if (Convert.ToDouble(HDL.Text) < 34.8 && !flag)
                        {
                            flag = true;
                            info.setDisease("מחלות לב", "לתאם פגישה עם תזונאי");
                            info.setDisease("סוכרת מבוגרים", "התאמת אינסולין למטופל");
                            info.setDisease("היפרליפידמיה )שומנים בדם(", "לתאם פגישה עם תזונאי, כדור 5 מג של סימוביל ביום למשך שבוע");
                        }
                        if (Convert.ToDouble(HDL.Text) > 74.4 && !flag)
                        {
                            flag = true;
                            info.setDisease("לא מזיק", "פעולות גופניות");
                        }
                    }
                }
                if (Convert.ToString(gender.Text) == "נקבה")
                {
                    if (Convert.ToDouble(HCT.Text) < 33 && !flag)
                    {
                        flag = true;
                        info.setDisease("אנמיה", "שני כדורי 10 מ''ג של ב12 ביום למשך חודש");
                        info.setDisease("דימום", "להתפנות בדחיפות לבית החולים");
                    }
                    if (Convert.ToDouble(HCT.Text) > 47 && !flag)
                    {
                        flag = true;
                        info.setDisease("מחלת ריאות", "להפסיק לעשן / הפנייה לצילום רנטגן של הריאות");
                    }
                    //Barzel incorrect
                    if (Convert.ToDouble(Iron.Text) < 48 && !flag)
                    {
                        flag = true;
                        info.setDisease("תת תזונה", "לתאם פגישה עם תזונאי");
                        info.setDisease("מחסור בברזל", "שני כדורי 10 מג של B12 ביום למשך חודש");
                    }
                    if (Convert.ToDouble(Iron.Text) > 128 && !flag)
                    {
                        flag = true;
                        info.setDisease("הרעלת ברזל", "להתפנות לבית החולים");
                    }
                    //HDL Incorrect
                    if (!etiopia.Checked)
                    {
                        if (Convert.ToDouble(HDL.Text) < 34 && !flag)
                        {
                            flag = true;
                            info.setDisease("מחלות לב", "לתאם פגישה עם תזונאי");
                            info.setDisease("סוכרת מבוגרים", "התאמת אינסולין למטופל");
                            info.setDisease("היפרליפידמיה )שומנים בדם(", "לתאם פגישה עם תזונאי, כדור 5 מג של סימוביל ביום למשך שבוע");
                        }
                        if (Convert.ToDouble(HDL.Text) > 82 && !flag)
                        {
                            flag = true;
                            info.setDisease("לא מזיק", "פעולות גופניות");
                        }
                    }
                    else
                    {
                        if (Convert.ToDouble(HDL.Text) < 40.8 && !flag)
                        {
                            flag = true;
                            info.setDisease("מחלות לב", "לתאם פגישה עם תזונאי");
                            info.setDisease("סוכרת מבוגרים", "התאמת אינסולין למטופל");
                            info.setDisease("היפרליפידמיה )שומנים בדם(", "לתאם פגישה עם תזונאי, כדור 5 מג של סימוביל ביום למשך שבוע");
                        }
                        if (Convert.ToDouble(HDL.Text) > 98.4 && !flag)
                        {
                            flag = true;
                            info.setDisease("לא מזיק", "פעולות גופניות");
                        }
                    }
                }

                //bari
                if (!flag)
                    info.setDisease("בריא", "לשתות מים");
                
            }
            
            this.Hide();
            info.Closed += (s, args) => this.Close();
            info.Show();
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            for(int i = 0; i< firstname.Text.Length; i++)
            {
                if (firstname.Text[i] >= '0' && firstname.Text[i] <= '9')
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectName.Show();
                IncorrectName.ForeColor = Color.Red;
                IncorrectName.Text = "Incorrect Name";
            }
            else
            {
                IncorrectName.Hide();
                this.flag = true;
            }
                
        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            for (int i = 0; i < lastname.Text.Length; i++)
            {
                if (lastname.Text[i] >= '0' && lastname.Text[i] <= '9')
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectLastName.Show();
                IncorrectLastName.ForeColor = Color.Red;
                IncorrectLastName.Text = "Incorrect Last Name";
            }
            else
            {
                IncorrectLastName.Hide();
                this.flag = true;
            }
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            for (int i = 0; i < id.Text.Length; i++)
            {
                if (id.Text[i] < '0' || id.Text[i] > '9')
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (id.Text.Length < 9)
            {
                flag = false;
                this.flag = false;
            }
            if (!flag)
            {
                IncorrectId.Show();
                IncorrectId.ForeColor = Color.Red;
                IncorrectId.Text = "Incorrect ID";
            }
            else
            {
                IncorrectId.Hide();
                this.flag = true;
            }
        }

        private void gender_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = false;
            this.flag = false;
            if (gender.Text == "זכר" || gender.Text == "נקבה")
            {
                flag = true;
                this.flag = true;
            }
            if (!flag)
            {
                IncorrectGender.Show();
                IncorrectGender.ForeColor = Color.Red;
                IncorrectGender.Text = "Incorrect Gender";
            }
            else
            {
                IncorrectGender.Hide();
                this.flag = true;
            }
            if (gender.Text == "זכר")
            {
                pregnant.Checked = false;
                pregnant.Enabled = false;
            }
            else
            {
                pregnant.Enabled = true;
            }
            
        }

        private void age_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            for (int i = 0; i < age.Text.Length; i++)
            {
                if (age.Text[i] < '0' || age.Text[i] > '9')
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (flag && age.Text != "")
            {
                if(Convert.ToInt32(age.Text) < 0 || Convert.ToInt32(age.Text) > 120)
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectAge.Show();
                IncorrectAge.ForeColor = Color.Red;
                IncorrectAge.Text = "Incorrect Age";
            }
            else
            {
                IncorrectAge.Hide();
                this.flag = true;
            }
        }

        private void WBC_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            int countComma = 0;
            for (int i = 0; i < WBC.Text.Length; i++)
            {
                if ((WBC.Text[i] < '0' || WBC.Text[i] > '9') && WBC.Text[i] != ',')
                {
                    flag = false;
                    this.flag = false;
                }
                if (WBC.Text[i] == ',')
                    countComma++;
                if (WBC.Text[0] == ',' || countComma > 1)
                { 
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectWBC.Show();
                IncorrectWBC.ForeColor = Color.Red;
                IncorrectWBC.Text = "Incorrect WBC";
            }
            else
            {
                IncorrectWBC.Hide();
                this.flag = true;
            }
        }

        private void Neut_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            int countComma = 0;
            for (int i = 0; i < Neut.Text.Length; i++)
            {
                if ((Neut.Text[i] < '0' || Neut.Text[i] > '9') && Neut.Text[i] != ',')
                {
                    flag = false;
                    this.flag = false;
                }
                if (Neut.Text[i] == ',')
                    countComma++;
                if (Neut.Text[0] == ',' || countComma > 1)
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectNeut.Show();
                IncorrectNeut.ForeColor = Color.Red;
                IncorrectNeut.Text = "Incorrect Neut";
            }
            else
            {
                IncorrectNeut.Hide();
                this.flag = true;
            }
        }

        private void Lymph_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            int countComma = 0;
            for (int i = 0; i < Lymph.Text.Length; i++)
            {
                if ((Lymph.Text[i] < '0' || Lymph.Text[i] > '9') && Lymph.Text[i] != ',')
                {
                    flag = false;
                    this.flag = false;
                }
                if (Lymph.Text[i] == ',')
                    countComma++;
                if (Lymph.Text[0] == ',' || countComma > 1)
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectLymph.Show();
                IncorrectLymph.ForeColor = Color.Red;
                IncorrectLymph.Text = "Incorrect Lymph";
            }
            else
            {
                IncorrectLymph.Hide();
                this.flag = true;
            }
        }

        private void RBC_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            int countComma = 0;
            for (int i = 0; i < RBC.Text.Length; i++)
            {
                if ((RBC.Text[i] < '0' || RBC.Text[i] > '9') && RBC.Text[i] != ',')
                {
                    flag = false;
                    this.flag = false;
                }
                if (RBC.Text[i] == ',')
                    countComma++;
                if (RBC.Text[0] == ',' || countComma > 1)
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectRBC.Show();
                IncorrectRBC.ForeColor = Color.Red;
                IncorrectRBC.Text = "Incorrect RBC";
            }
            else
            {
                IncorrectRBC.Hide();
                this.flag = true;
            }
        }

        private void HCT_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            int countComma = 0;
            for (int i = 0; i < HCT.Text.Length; i++)
            {
                if ((HCT.Text[i] < '0' || HCT.Text[i] > '9') && HCT.Text[i] != ',')
                {
                    flag = false;
                    this.flag = false;
                }
                if (HCT.Text[i] == ',')
                    countComma++;
                if (HCT.Text[0] == ',' || countComma > 1)
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectHCT.Show();
                IncorrectHCT.ForeColor = Color.Red;
                IncorrectHCT.Text = "Incorrect HCT";
            }
            else
            {
                IncorrectHCT.Hide();
                this.flag = true;
            }
        }

        private void Urea_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            int countComma = 0;
            for (int i = 0; i < Urea.Text.Length; i++)
            {
                if ((Urea.Text[i] < '0' || Urea.Text[i] > '9') && Urea.Text[i] != ',')
                {
                    flag = false;
                    this.flag = false;
                }
                if (Urea.Text[i] == ',')
                    countComma++;
                if (Urea.Text[0] == ',' || countComma > 1)
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectUrea.Show();
                IncorrectUrea.ForeColor = Color.Red;
                IncorrectUrea.Text = "Incorrect Urea";
            }
            else
            {
                IncorrectUrea.Hide();
                this.flag = true;
            }
        }

        private void Hb_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            int countComma = 0;
            for (int i = 0; i < Hb.Text.Length; i++)
            {
                if ((Hb.Text[i] < '0' || Hb.Text[i] > '9') && Hb.Text[i] != ',')
                {
                    flag = false;
                    this.flag = false;
                }
                if (Hb.Text[i] == ',')
                    countComma++;
                if (Hb.Text[0] == ',' || countComma > 1)
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectHB.Show();
                IncorrectHB.ForeColor = Color.Red;
                IncorrectHB.Text = "Incorrect Hb";
            }
            else
            {
                IncorrectHB.Hide();
                this.flag = true;
            }
        }

        private void Crtn_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            int countComma = 0;
            for (int i = 0; i < Crtn.Text.Length; i++)
            {
                if ((Crtn.Text[i] < '0' || Crtn.Text[i] > '9') && Crtn.Text[i] != ',')
                {
                    flag = false;
                    this.flag = false;
                }
                if (Crtn.Text[i] == ',')
                    countComma++;
                if (Crtn.Text[0] == ',' || countComma > 1)
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectCrtn.Show();
                IncorrectCrtn.ForeColor = Color.Red;
                IncorrectCrtn.Text = "Incorrect Crtn";
            }
            else
            {
                IncorrectCrtn.Hide();
                this.flag = true;
            }
        }

        private void Iron_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            int countComma = 0;
            for (int i = 0; i < Iron.Text.Length; i++)
            {
                if ((Iron.Text[i] < '0' || Iron.Text[i] > '9') && Iron.Text[i] != ',')
                {
                    flag = false;
                    this.flag = false;
                }
                if (Iron.Text[i] == ',')
                    countComma++;
                if (Iron.Text[0] == ',' || countComma > 1)
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectIron.Show();
                IncorrectIron.ForeColor = Color.Red;
                IncorrectIron.Text = "Incorrect Iron";
            }
            else
            {
                IncorrectIron.Hide();
                this.flag = true;
            }
        }

        private void HDL_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            int countComma = 0;
            for (int i = 0; i < HDL.Text.Length; i++)
            {
                if ((HDL.Text[i] < '0' || HDL.Text[i] > '9') && HDL.Text[i] != ',')
                {
                    flag = false;
                    this.flag = false;
                }
                if (HDL.Text[i] == ',')
                    countComma++;
                if (HDL.Text[0] == ',' || countComma > 1)
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectHDL.Show();
                IncorrectHDL.ForeColor = Color.Red;
                IncorrectHDL.Text = "Incorrect HDL";
            }
            else
            {
                IncorrectHDL.Hide();
                this.flag = true;
            }
        }

        private void AP_TextChanged(object sender, EventArgs e)
        {
            Boolean flag = true;
            int countComma = 0;
            for (int i = 0; i < AP.Text.Length; i++)
            {
                if ((AP.Text[i] < '0' || AP.Text[i] > '9') && AP.Text[i] != ',')
                {
                    flag = false;
                    this.flag = false;
                }
                if (AP.Text[i] == ',')
                    countComma++;
                if (AP.Text[0] == ',' || countComma > 1)
                {
                    flag = false;
                    this.flag = false;
                }
            }
            if (!flag)
            {
                IncorrectAP.Show();
                IncorrectAP.ForeColor = Color.Red;
                IncorrectAP.Text = "Incorrect AP";
            }
            else
            {
                IncorrectAP.Hide();
                this.flag = true;
            }
        }
    }
     
}

