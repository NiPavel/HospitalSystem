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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CorrectUsername.Hide();
            CorrectPassword.Hide();
            //picture of eye for password
            HidePass.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Checking Gui


        // Working with Excel
        public Boolean OpenFile()
        {
            string path = @"C:\Users\Павел\Desktop\HospitalSystem\Doctors.xlsx";
            if (File.Exists(path))
            {
                Excel excel = new Excel(path, 1, this);
                return excel.CheckUsername();
            }
            MessageBox.Show("User is not excist!");
            return false;
        }

        // Input username
        public String getDoctorUsername()
        {
            return DoctorUsername.Text;
        }

        // Input password
        public String getPassword()
        {
            return Password.Text;
        }

        // SignIn
        private void button2_Click(object sender, EventArgs e)
        {
            if (OpenFile())
            {
                this.Hide();
                var area = new PArea();
                area.Closed += (s, args) => this.Close();
                area.Show();
                
            }
        }

        //Going to sign up
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var signup = new SignUp();
            signup.Closed += (s, args) => this.Close();
            signup.Show();
        }

        //Checking an username
        private void DoctorUsername_TextChanged(object sender, EventArgs e)
        {
            CorrectUsername.Hide();
            int size_digits = 0;
            for (int i = 0; i < this.getDoctorUsername().Length; ++i)
            {
                if (getDoctorUsername()[i] >= '0' && getDoctorUsername()[i] <= '9')
                    ++size_digits;
                
            }
            if (this.getDoctorUsername() == "" || this.getDoctorUsername().Length < 6 || this.getDoctorUsername().Length > 8 || size_digits > 2)
            {
                IncorrectUser.Show();
                IncorrectUser.ForeColor = Color.Red;
                IncorrectUser.Text = "Username must be 6 - 8 symbols, max 2 numbers";
            }
            else
            {
                IncorrectUser.Hide();
                CorrectUsername.Show();
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            CorrectPassword.Hide();
            int size_chars = 0, size_digits = 0, size_specials = 0;
            for (int i = 0; i < this.getPassword().Length; ++i)
            {
                if (this.getPassword()[i] >= 'A' && this.getPassword()[i] <= 'Z' || this.getPassword()[i] >= 'a' && this.getPassword()[i] <= 'z')
                    ++size_chars;
                if (this.getPassword()[i] >= '0' && this.getPassword()[i] <= '9')
                    ++size_digits;
                if (this.getPassword()[i] >= 32 && this.getPassword()[i] <= 47 || this.getPassword()[i] >= 58 && this.getPassword()[i] <= 64 ||
                    this.getPassword()[i] >= 91 && this.getPassword()[i] <= 96 || this.getPassword()[i] >= 123 && this.getPassword()[i] <= 126)
                    ++size_specials;
            }
            if (this.getPassword() == "" || this.getPassword().Length < 8 || this.getPassword().Length > 10 || size_chars < 1 || size_digits < 1 || size_specials < 1)
            {
                IncorrectPassword.Show();
                IncorrectPassword.ForeColor = Color.Red;
                IncorrectPassword.Text = "Password must be 8 - 10 symbols, at least 1 char, 1 number, 1 special char";
            }
            else
            {
                IncorrectPassword.Hide();
                CorrectPassword.Show();
            }
        }

        //Show password
        private void button3_Click(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = false;
            ShowPass.Hide();
            HidePass.Show();
        }

        //Unshow password
        private void button4_Click(object sender, EventArgs e)
        {
            Password.UseSystemPasswordChar = true;
            HidePass.Hide();
            ShowPass.Show();
        }

        

    }
}
