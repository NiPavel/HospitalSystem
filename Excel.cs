using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Exel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace HospitalSystem
{
    class Excel
    {
        string path = "";
        _Application excel = new _Exel.Application();
        Workbook wb;
        Worksheet ws;
        Form1 doc;
        SignUp doc1;
        PArea area;
        Info info;

        //constructor for info
        public Excel(string path, int Sheet, Info info, PArea area)
        {
            this.path = path;
            this.info = info;
            this.area = area;  
            //if (excel != null)
            //{
            //    wb = excel.Workbooks.Open(path);
            //    ws = wb.Worksheets[Sheet];
            //}
        }

        // Constructor for form1
        public Excel(string path, int Sheet, Form1 doc)
        {
            this.path = path;
            this.doc = doc;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }

        //Constructor for SignUp
        public Excel(string path, int Sheet, SignUp doc)
        {
            this.path = path;
            this.doc1 = doc;
            if (wb != null)
            {
                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[Sheet];
            }
        }

        //Cosntructor for Parea
        public Excel(string path, int Sheet, PArea area)
        {
            this.path = path;
            this.area = area;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }

        // Check Username in Excel file
        public Boolean CheckUsername()
        {
            int i = 1, j = 1;
            Boolean flag = false, flag1 = false;
            while (ws.Cells[i, j].Value2 != "Username")
                j++;
            while (ws.Cells[i, j].Value2 != null)
            {
                i++;
                if (ws.Cells[i, j].Value2 == doc.getDoctorUsername())
                {
                    if (CheckPassword())
                        flag = true;
                    else
                        MessageBox.Show("Password is incorrect!");
                    flag1 = true;
                }
                
            }
            if (!flag1)
                MessageBox.Show("Username is incorrect!");
            this.getWb().Close();
            this.getExcel().Quit();
            return flag;
        }

        //Check password in Excel file
        public Boolean CheckPassword()
        {
            int i = 1, j = 1;
            Boolean flag = false;
            while (ws.Cells[i, j].Value2 != "Password")
                j++;
            while (ws.Cells[i, j].Value2 != null)
            {
                i++;
                if (Convert.ToString(ws.Cells[i, j].Value2) == doc.getPassword())
                {
                    flag = true;
                }
            }
            return flag;

        }

        //Check Id in Excel file
        public Boolean CheckID(String num)
        {
            Boolean flag = false;
            int i = 1, j = 1;

            while (ws.Cells[i, j].Value2 != "ID")
            {
                j++;
            }
            while (ws.Cells[i, j].Value2 != null)
            {
                i++;
                if (Convert.ToString(ws.Cells[i, j].Value2) == num)
                {
                    flag = true;
                }
            }
            return flag;
        }
        //Check UserName for Signup
        public Boolean CheckUsername(String name)
        {
            Boolean flag = false;
            int i = 1, j = 1;
            while (ws.Cells[i, j].Value2 != "Username")
            {
                j++;
            }
            while (ws.Cells[i, j].Value2 != null)
            {
                i++;
                if (Convert.ToString(ws.Cells[i, j].Value2) == name)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public void add()
        {
            if (!File.Exists(path))
            {
                wb = excel.Workbooks.Add("");
                ws = wb.ActiveSheet;
                ws.Cells[1, 1] = "Username";
                ws.Cells[1, 2] = "Password";
                ws.Cells[1, 3] = "ID";
            }
            else
            {
                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[1];
            }

            int size = ws.UsedRange.Rows.Count + 1;
            ws.Cells[size, 1].Value = this.doc1.getUsername();
            ws.Cells[size, 2].Value = this.doc1.getPassword();
            ws.Cells[size, 3].Value = this.doc1.getId();

            wb.SaveAs(path);

        }

        public Workbook getWb()
        {
            return wb;
        }

        public _Application getExcel()
        {
            return excel;
        }

        public void setInfo()
        {
            area.setWBC(Convert.ToString(ws.Cells[2, 1].Value2));
            area.setNeut(Convert.ToString(ws.Cells[2, 2].Value));
            area.setLymph(Convert.ToString(ws.Cells[2, 3].Value));
            area.setRBC(Convert.ToString(ws.Cells[2, 4].Value));
            area.setHCT(Convert.ToString(ws.Cells[2, 5].Value));
            area.setUrea(Convert.ToString(ws.Cells[2, 6].Value));
            area.setHb(Convert.ToString(ws.Cells[2, 7].Value));
            area.setCrtn(Convert.ToString(ws.Cells[2, 8].Value));
            area.setIron(Convert.ToString(ws.Cells[2, 9].Value));
            area.setHDL(Convert.ToString(ws.Cells[2, 10].Value));
            area.setAP(Convert.ToString(ws.Cells[2, 11].Value));
        }

        //add info to excel file patient
        public void addInfo()
        {
            if (!File.Exists(path))
            {
                wb = excel.Workbooks.Add("");
                ws = wb.ActiveSheet;
                ws.Cells[1, 1] = "First name";
                ws.Cells[1, 2] = "Last name";
                ws.Cells[1, 3] = "ID";
                ws.Cells[1, 4] = "Age";
                ws.Cells[1, 5] = "Gender";
                ws.Cells[1, 6] = "Pregnant";
                ws.Cells[1, 7] = "Easterner";
                ws.Cells[1, 8] = "Ethiophic";
                ws.Cells[1, 9] = "WBC";
                ws.Cells[1, 10] = "Neut";
                ws.Cells[1, 11] = "Lymph";
                ws.Cells[1, 12] = "RBC";
                ws.Cells[1, 13] = "HCT";
                ws.Cells[1, 14] = "Urea";
                ws.Cells[1, 15] = "Hb";
                ws.Cells[1, 16] = "Crtn";
                ws.Cells[1, 17] = "Iron";
                ws.Cells[1, 18] = "HDL";
                ws.Cells[1, 19] = "AP";
                ws.Cells[1, 20] = "Diagnosis";
                ws.Cells[1, 21] = "Recommendation";
            }
            else
            {
                wb = excel.Workbooks.Open(path);
                ws = wb.Worksheets[1];
            }

            int size = ws.UsedRange.Rows.Count + 1;
            ws.Cells[size, 1].Value = this.area.getName();
            ws.Cells[size, 2].Value = this.area.getLastName();
            ws.Cells[size, 3].Value = this.area.getId();
            ws.Cells[size, 4].Value = this.area.getAge();
            ws.Cells[size, 5].Value = this.area.getGender();
            ws.Cells[size, 6].Value = this.area.getPregnant();
            ws.Cells[size, 7].Value = this.area.getEthiopi();
            ws.Cells[size, 8].Value = this.area.getEast();
            ws.Cells[size, 9].Value = this.area.getWbc();
            ws.Cells[size, 10].Value = this.area.getNeut();
            ws.Cells[size, 11].Value = this.area.getLymph();
            ws.Cells[size, 12].Value = this.area.getRbc();
            ws.Cells[size, 13].Value = this.area.getHct();
            ws.Cells[size, 14].Value = this.area.getUrea();
            ws.Cells[size, 15].Value = this.area.getHb();
            ws.Cells[size, 16].Value = this.area.getCrtn();
            ws.Cells[size, 17].Value = this.area.getIron();
            ws.Cells[size, 18].Value = this.area.getHdl();
            ws.Cells[size, 19].Value = this.area.getAp();
            for (int rows = 0; rows < this.info.getGrid().Rows.Count; rows++)
            {
                ws.Cells[size + rows, 20].Value = this.info.getGrid().Rows[rows].Cells[1].Value;
                ws.Cells[size + rows, 20].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                ws.Cells[size + rows, 21].Value = this.info.getGrid().Rows[rows].Cells[0].Value;
                ws.Cells[size + rows, 21].HorizontalAlignment = XlHAlign.xlHAlignCenter;
            }

            ws.Rows.AutoFit();
            ws.Columns.AutoFit();
            wb.SaveAs(path);
        }
    }
}
