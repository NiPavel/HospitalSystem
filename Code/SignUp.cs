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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            HidePass.Hide();
        }

        //function that check if the doctor that want to sign up entered correct data and if he entered
        //correct data then program will create new user for doctor
        private void button2_Click_1(object sender, EventArgs e)
        {
            int size_digits = 0;
            int size_chars = 0;
            int size_specials = 0;

            if ((PasswUser.Text.Length < 8 || PasswUser.Text.Length > 10) && (DoctUser.Text.Length < 6 || DoctUser.Text.Length > 8))
            {
                MessageBox.Show("The size of Username and Password is incorrect!");
                return;
            }

            if (DoctUser.Text.Length >= 6 && DoctUser.Text.Length <= 8)
            {
                for (int i = 0; i < DoctUser.Text.Length; ++i)
                    if (DoctUser.Text[i] >= '0' && DoctUser.Text[i] <= '9')
                    {
                        ++size_digits;
                        if (size_digits > 2)
                        {
                            MessageBox.Show("The number of digits in username more then 2");
                            return;
                        }

                    }

            }
            else
            {
                MessageBox.Show("The size of Username is incorrect!");
                return;
            }
            size_digits = 0;
            if (PasswUser.Text.Length >= 8 && PasswUser.Text.Length <= 10)
            {

                for (int i = 0; i < PasswUser.Text.Length; ++i)
                {
                    if (PasswUser.Text[i] >= 'A' && PasswUser.Text[i] <= 'Z' || PasswUser.Text[i] >= 'a' && PasswUser.Text[i] <= 'z')
                        ++size_chars;
                    if (PasswUser.Text[i] >= '0' && PasswUser.Text[i] <= '9')
                        ++size_digits;
                    if (PasswUser.Text[i] >= 32 && PasswUser.Text[i] <= 47 || PasswUser.Text[i] >= 58 && PasswUser.Text[i] <= 64 ||
                        PasswUser.Text[i] >= 91 && PasswUser.Text[i] <= 96 || PasswUser.Text[i] >= 123 && PasswUser.Text[i] <= 126)
                        ++size_specials;
                }
                if (size_chars < 1 && size_digits < 1)
                {
                    MessageBox.Show(" Number of digits and chars in the password less then 1");
                    return;
                }
                if (size_chars < 1 && size_specials < 1)
                {
                    MessageBox.Show(" Number of special chars and chars in the password less then 1");
                    return;
                }
                if (size_specials < 1 && size_digits < 1)
                {
                    MessageBox.Show(" Number of special chars and digits in the password less then 1");
                    return;
                }
                if (size_chars < 1)
                {
                    MessageBox.Show(" Number of chars in the password less then 1");
                    return;
                }
                if (size_digits < 1)
                {
                    MessageBox.Show(" Number of digits in the password less then 1");
                    return;
                }
                if (size_specials < 1)
                {
                    MessageBox.Show(" Number of special chars in the password less then 1");
                    return;
                }

            }
            else
            {
                MessageBox.Show("The size of Password is incorrect!");
                return;
            }

            if (Id.Text.Count() == 0)
            {
                MessageBox.Show("Enter the ID please!");
                return;
            }

            if (checkId())
            {
                MessageBox.Show("The user is excist!");
                return;
            }

            if (checkUsername())
            {
                MessageBox.Show("The username is excist!");
                return;
            }

            addDoc();

            this.Hide();
            var area = new PArea();
            area.Closed += (s, args) => this.Close();
            area.Show();
        }

        public void addDoc()
        {   
            string path = @"C:\Users\Павел\Desktop\HospitalSystem\Doctors.xlsx";
            Excel excel = new Excel(path, 1, this);
            excel.add();
            excel.getWb().Close();
            excel.getExcel().Quit();

        }

        public String getUsername()
        {
            return DoctUser.Text;
        }

        public String getPassword()
        {
            return PasswUser.Text;
        }

        public String getId()
        {
            return Id.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Form1();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        //Chekicking Id of doctor in the Excel file
        public Boolean checkId()
        {
            Boolean flag = false;
            string path = @"C:\Users\Павел\Desktop\HospitalSystem\Doctors.xlsx";
            if (File.Exists(path))
            {
                Excel excel = new Excel(path, 1, this);
                flag = excel.CheckID(Convert.ToString(Id.Text));
                excel.getWb().Close();
                excel.getExcel().Quit();
            }

            return flag;
        }

        //Checking Username of doctor in the Excel file
        public Boolean checkUsername()
        {
            Boolean flag = false;
            string path = @"C:\Users\Павел\Desktop\HospitalSystem\Doctors.xlsx";
            if (File.Exists(path))
            {
                Excel excel = new Excel(path, 1, this);
                flag = excel.CheckUsername(Convert.ToString(DoctUser.Text));
                excel.getWb().Close();
                excel.getExcel().Quit();
            }
            return flag;
        }

        //Show password
        private void ShowPass_Click(object sender, EventArgs e)
        {
            PasswUser.UseSystemPasswordChar = false;
            ShowPass.Hide();
            HidePass.Show();
        }
        //Unshow password
        private void HidePass_Click(object sender, EventArgs e)
        {
            PasswUser.UseSystemPasswordChar = true;
            HidePass.Hide();
            ShowPass.Show();
        }
    }
}
