using System;
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
    public partial class Info : Form
    {
        DataTable table = new DataTable();
        PArea area;
        public Info(PArea area)
        {
            InitializeComponent();
            TableSetup();
            this.area = area;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void TableSetup()
        {
            table.Columns.Add("טיפול מומלץ", typeof(string));
            table.Columns.Add("מחלה", typeof(string));

            dataGridView1.DataSource = table;
        }
        public void setDisease(string d1,string d2)
        {
            table.Rows.Add(d2,d1)  ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var area = new PArea();
            area.Closed += (s, args) => this.Close();
            area.Show();
        }

        //order for patient after his visit
        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Павел\Desktop\HospitalSystem\" + area.getName() + area.getLastName() + ".xlsx";
            Excel excel = new Excel(path, 1, this, this.area);
            excel.addInfo();
            excel.getWb().Close();
            excel.getExcel().Quit();
            MessageBox.Show("The order saved succefull");
        }

        public DataGridView getGrid()
        {
            return dataGridView1;
        }
    }
}
