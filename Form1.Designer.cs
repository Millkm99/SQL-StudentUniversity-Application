namespace Assignment7_1140119
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgUsers = new DataGridView();
            btnShowUsers = new Button();
            btnLogin = new Button();
            menuStrip1 = new MenuStrip();
            initializeDBToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            departmentsToolStripMenuItem = new ToolStripMenuItem();
            professorsToolStripMenuItem = new ToolStripMenuItem();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            coursePrerequisitesToolStripMenuItem = new ToolStripMenuItem();
            coursesOfferedToolStripMenuItem = new ToolStripMenuItem();
            coursesTakenToolStripMenuItem = new ToolStripMenuItem();
            studentCoursesToolStripMenuItem = new ToolStripMenuItem();
            studentMajorsToolStripMenuItem = new ToolStripMenuItem();
            professorsDepartmentsToolStripMenuItem = new ToolStripMenuItem();
            studentManagementToolStripMenuItem = new ToolStripMenuItem();
            viewStudentsToolStripMenuItem = new ToolStripMenuItem();
            viewStudentGradesToolStripMenuItem = new ToolStripMenuItem();
            courseManagementToolStripMenuItem = new ToolStripMenuItem();
            viewCoursesOfferedToolStripMenuItem = new ToolStripMenuItem();
            viewEnrollmentsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgUsers).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgUsers
            // 
            dgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsers.Location = new Point(282, 111);
            dgUsers.Name = "dgUsers";
            dgUsers.RowHeadersWidth = 62;
            dgUsers.RowTemplate.Height = 33;
            dgUsers.Size = new Size(765, 352);
            dgUsers.TabIndex = 0;
            // 
            // btnShowUsers
            // 
            btnShowUsers.Location = new Point(44, 146);
            btnShowUsers.Name = "btnShowUsers";
            btnShowUsers.Size = new Size(147, 53);
            btnShowUsers.TabIndex = 1;
            btnShowUsers.Text = "Show Users";
            btnShowUsers.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(44, 256);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 64);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { initializeDBToolStripMenuItem, studentManagementToolStripMenuItem, courseManagementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1068, 33);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // initializeDBToolStripMenuItem
            // 
            initializeDBToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, departmentsToolStripMenuItem, professorsToolStripMenuItem, coursesToolStripMenuItem, coursePrerequisitesToolStripMenuItem, coursesOfferedToolStripMenuItem, coursesTakenToolStripMenuItem, studentCoursesToolStripMenuItem, studentMajorsToolStripMenuItem, professorsDepartmentsToolStripMenuItem });
            initializeDBToolStripMenuItem.Name = "initializeDBToolStripMenuItem";
            initializeDBToolStripMenuItem.Size = new Size(114, 29);
            initializeDBToolStripMenuItem.Text = "InitializeDB";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(305, 34);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // departmentsToolStripMenuItem
            // 
            departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            departmentsToolStripMenuItem.Size = new Size(305, 34);
            departmentsToolStripMenuItem.Text = "Departments";
            // 
            // professorsToolStripMenuItem
            // 
            professorsToolStripMenuItem.Name = "professorsToolStripMenuItem";
            professorsToolStripMenuItem.Size = new Size(305, 34);
            professorsToolStripMenuItem.Text = "Professors";
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(305, 34);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // coursePrerequisitesToolStripMenuItem
            // 
            coursePrerequisitesToolStripMenuItem.Name = "coursePrerequisitesToolStripMenuItem";
            coursePrerequisitesToolStripMenuItem.Size = new Size(305, 34);
            coursePrerequisitesToolStripMenuItem.Text = "Course Prerequisites";
            // 
            // coursesOfferedToolStripMenuItem
            // 
            coursesOfferedToolStripMenuItem.Name = "coursesOfferedToolStripMenuItem";
            coursesOfferedToolStripMenuItem.Size = new Size(305, 34);
            coursesOfferedToolStripMenuItem.Text = "Courses Offered";
            // 
            // coursesTakenToolStripMenuItem
            // 
            coursesTakenToolStripMenuItem.Name = "coursesTakenToolStripMenuItem";
            coursesTakenToolStripMenuItem.Size = new Size(305, 34);
            coursesTakenToolStripMenuItem.Text = "Courses Taken";
            // 
            // studentCoursesToolStripMenuItem
            // 
            studentCoursesToolStripMenuItem.Name = "studentCoursesToolStripMenuItem";
            studentCoursesToolStripMenuItem.Size = new Size(305, 34);
            studentCoursesToolStripMenuItem.Text = "Student Courses";
            // 
            // studentMajorsToolStripMenuItem
            // 
            studentMajorsToolStripMenuItem.Name = "studentMajorsToolStripMenuItem";
            studentMajorsToolStripMenuItem.Size = new Size(305, 34);
            studentMajorsToolStripMenuItem.Text = "Student Majors";
            // 
            // professorsDepartmentsToolStripMenuItem
            // 
            professorsDepartmentsToolStripMenuItem.Name = "professorsDepartmentsToolStripMenuItem";
            professorsDepartmentsToolStripMenuItem.Size = new Size(305, 34);
            professorsDepartmentsToolStripMenuItem.Text = "Professors Departments";
            // 
            // studentManagementToolStripMenuItem
            // 
            studentManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewStudentsToolStripMenuItem, viewStudentGradesToolStripMenuItem });
            studentManagementToolStripMenuItem.Name = "studentManagementToolStripMenuItem";
            studentManagementToolStripMenuItem.Size = new Size(199, 29);
            studentManagementToolStripMenuItem.Text = "Student Management";
            // 
            // viewStudentsToolStripMenuItem
            // 
            viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            viewStudentsToolStripMenuItem.Size = new Size(277, 34);
            viewStudentsToolStripMenuItem.Text = "View Students";
            // 
            // viewStudentGradesToolStripMenuItem
            // 
            viewStudentGradesToolStripMenuItem.Name = "viewStudentGradesToolStripMenuItem";
            viewStudentGradesToolStripMenuItem.Size = new Size(277, 34);
            viewStudentGradesToolStripMenuItem.Text = "View Student Grades";
            // 
            // courseManagementToolStripMenuItem
            // 
            courseManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewCoursesOfferedToolStripMenuItem, viewEnrollmentsToolStripMenuItem });
            courseManagementToolStripMenuItem.Name = "courseManagementToolStripMenuItem";
            courseManagementToolStripMenuItem.Size = new Size(193, 29);
            courseManagementToolStripMenuItem.Text = "Course Management";
            courseManagementToolStripMenuItem.Click += courseManagementToolStripMenuItem_Click;
            // 
            // viewCoursesOfferedToolStripMenuItem
            // 
            viewCoursesOfferedToolStripMenuItem.Name = "viewCoursesOfferedToolStripMenuItem";
            viewCoursesOfferedToolStripMenuItem.Size = new Size(285, 34);
            viewCoursesOfferedToolStripMenuItem.Text = "View Courses Offered";
            // 
            // viewEnrollmentsToolStripMenuItem
            // 
            viewEnrollmentsToolStripMenuItem.Name = "viewEnrollmentsToolStripMenuItem";
            viewEnrollmentsToolStripMenuItem.Size = new Size(285, 34);
            viewEnrollmentsToolStripMenuItem.Text = "View Enrollments";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 475);
            Controls.Add(btnLogin);
            Controls.Add(btnShowUsers);
            Controls.Add(dgUsers);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgUsers).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgUsers;
        private Button btnShowUsers;
        private Button btnLogin;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem initializeDBToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem departmentsToolStripMenuItem;
        private ToolStripMenuItem professorsToolStripMenuItem;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem coursePrerequisitesToolStripMenuItem;
        private ToolStripMenuItem coursesOfferedToolStripMenuItem;
        private ToolStripMenuItem coursesTakenToolStripMenuItem;
        private ToolStripMenuItem studentCoursesToolStripMenuItem;
        private ToolStripMenuItem studentMajorsToolStripMenuItem;
        private ToolStripMenuItem professorsDepartmentsToolStripMenuItem;
        private ToolStripMenuItem studentManagementToolStripMenuItem;
        private ToolStripMenuItem viewStudentsToolStripMenuItem;
        private ToolStripMenuItem viewStudentGradesToolStripMenuItem;
        private ToolStripMenuItem courseManagementToolStripMenuItem;
        private ToolStripMenuItem viewCoursesOfferedToolStripMenuItem;
        private ToolStripMenuItem viewEnrollmentsToolStripMenuItem;
    }
}