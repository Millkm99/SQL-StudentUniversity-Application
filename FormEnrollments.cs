using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7_1140119
{
    public partial class FormEnrollments : Form
    {
        public string Semester { get { return cbSemesters.Text; } }
        public string Course { get { return cbCourses.Text; } }
        public FormEnrollments()
        {
            InitializeComponent();
            setSemesters();
        }

        private void setSemesters()
        {
            throw new NotImplementedException();
        }

        private void FormEnrollments_Load(object sender, EventArgs e)
        {

        }

        private void cbSemesters_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from CoursesOffered where Semester='" + cbSemesters.Text + "';";
            DataTable dt = UBDBDataAccess.GetManyRowsCols(sql);
            foreach (DataRow dr in dt.Rows)
            {
                cbCourses.Items.Add(dr.ItemArray[0]);
            }
            cbCourses.Enabled = true;
        }

        private void cbCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

