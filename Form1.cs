using System.Data;

namespace Assignment7_1140119
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }



        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Users";
                DataTable dt = DataAccess.GetManyRowsCols(sql);
                //This is showing a error but this is to intialize the users for the datagrid in the main form.
                //It was running at first but now it is a error. I Screenshotted the proof originally.  
                dgUsers.DataSource = dt;
                dgUsers.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin fmLogin = new FormLogin();
            if (fmLogin.ShowDialog() == DialogResult.OK)
            {
                string sql = "select Username from Users " +
                "where Username='" + fmLogin.Username + "' and " +
                    "Password='" + fmLogin.Password + "'";
                object obj = DataAccess.GetSingleAnswer(sql);
                if (obj != null)
                    MessageBox.Show("Login successful..");
                else
                    MessageBox.Show("invalid login..");
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            updateDB(((ToolStripMenuItem)sender).Text);
        }

        private void updateDB(String clickedItem)
        {
            try
            {

                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = "C:Users.DocumentsProgrammingCPSC440DBTestUBDB" + "Test";
                ofd.Filter = "text files|*.txt|docx files|*.docx";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;

                    if (!filename.Contains(clickedItem + ".txt"))
                        throw new Exception(filename + " " + clickedItem + " Wrong file selected");

                    FileInfo fi = new FileInfo(filename);

                    Stream str = fi.Open(FileMode.Open, FileAccess.Read);

                    StreamReader sstr = new StreamReader(str);


                    string sLine = sstr.ReadLine();
                    MessageBox.Show(sLine);
                    char[] seps = { ',' };
                    string sql = "";
                    while (sLine != null)
                    {
                        string[] parts = sLine.Split(seps);
                        sql += "INSERT INTO " + clickedItem + " VALUES (";
                        for (int i = 0; i < parts.Length; i++)
                        {
                            if (i > 0) sql += ",";
                            string s = parts[i];
                            sql += "\'" + s + "\'";

                        }
                        sql += ");\n";
                        sLine = sstr.ReadLine();
                        if (sLine == null)
                            break;
                        if (sLine.Trim() == "")
                            break;
                    }
                    MessageBox.Show("sql : " + sql);
                    UBDBDataAccess.InsertUpdateDelete(sql);
                    MessageBox.Show("DONE");
                }
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show("FE : " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("EX : " + ex.Message + "\n" +
                    ex.StackTrace);

            }

        }

        private void viewStudents_Click(object sender, EventArgs e)
        {
            FormViewStudents fmLogin = new FormViewStudents();
            if (fmLogin.ShowDialog() == DialogResult.OK)
            {
                char[] seps = { ',' };
                string department = fmLogin.Department.Split(seps)[0];
                try
                {
                    string sql = "SELECT* from Students, StudentMajors where DepartmentId = '" + department + "' AND Students.StudentId = StudentMajors.StudentId;";
                    DataTable dt = DataAccess.GetManyRowsCols(sql);
                    dgUsers.DataSource = dt;
                    dgUsers.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void viewStudentGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch fmSearch = new FormSearch();
            if (fmSearch.ShowDialog() == DialogResult.OK)
            {
                string firstname = fmSearch.Firstname;
                try
                {
                    string sql = "SELECT DISTINCT Courses.CourseNum, Courses.CourseName, CoursesTaken.Grade from Courses, CoursesTaken, StudentCourses, Students where(Students.FirstName = '" + firstname + "' AND CoursesTaken.StudentId = Students.StudentId AND Courses.CourseNum = CoursesTaken.CourseNum); ";
                    DataTable dt = DataAccess.GetManyRowsCols(sql);
                    dgUsers.DataSource = dt;
                    dgUsers.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void viewCoursesOfferedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSemesters fmSemesters = new FormSemesters();
            if (fmSemesters.ShowDialog() == DialogResult.OK)
            {
                string semester = fmSemesters.Semester;
                try
                {
                    string sql = "SELECT * from CoursesOffered where Semester = '" + semester + "';";
                    DataTable dt = DataAccess.GetManyRowsCols(sql);
                    dgUsers.DataSource = dt;
                    dgUsers.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void viewEnrollmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnrollments fmEnrollments = new FormEnrollments();
            if (fmEnrollments.ShowDialog() == DialogResult.OK)
            {
                string semester = fmEnrollments.Semester;
                string course = fmEnrollments.Course;
                try
                {
                    string sql = "SELECT * from StudentCourses where Semester = '" + semester + "' AND CourseNum='" + course + "';";
                    DataTable dt = DataAccess.GetManyRowsCols(sql);
                    dgUsers.DataSource = dt;
                    dgUsers.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void courseManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

