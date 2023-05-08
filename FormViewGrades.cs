using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7_1140119
{
    public partial class FormViewGrades : Form
    {
        public FormViewGrades()
        {
            InitializeComponent();
            setGrades();
        }

        public string Grades { get { return gradesDataGridView.Text; } }


        private void setGrades()
        {
            string sql = "select * from Departments";
            DataTable dt = UBDBDataAccess.GetManyRowsCols(sql);
            foreach (DataRow dr in dt.Rows)
            {
                gradesDataGridView.Rows.Add(dr.ItemArray[0] + "," + dr.ItemArray[1].ToString());

            }
        }

        private void FormViewStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
