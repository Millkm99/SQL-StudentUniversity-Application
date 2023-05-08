namespace Assignment7_1140119
{
    partial class FormEnrollments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbSemesters = new ComboBox();
            cbCourses = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // cbSemesters
            // 
            cbSemesters.FormattingEnabled = true;
            cbSemesters.Location = new Point(293, 126);
            cbSemesters.Name = "cbSemesters";
            cbSemesters.Size = new Size(241, 33);
            cbSemesters.TabIndex = 0;
            cbSemesters.SelectedIndexChanged += cbSemesters_SelectedIndexChanged;
            // 
            // cbCourses
            // 
            cbCourses.FormattingEnabled = true;
            cbCourses.Location = new Point(293, 188);
            cbCourses.Name = "cbCourses";
            cbCourses.Size = new Size(241, 33);
            cbCourses.TabIndex = 1;
            cbCourses.SelectedIndexChanged += cbCourses_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 126);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 2;
            label1.Text = "Semesters";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 196);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 3;
            label2.Text = "Courses";
            // 
            // button1
            // 
            button1.Location = new Point(164, 306);
            button1.Name = "button1";
            button1.Size = new Size(160, 60);
            button1.TabIndex = 4;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(367, 306);
            button2.Name = "button2";
            button2.Size = new Size(149, 60);
            button2.TabIndex = 5;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormEnrollments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbCourses);
            Controls.Add(cbSemesters);
            Name = "FormEnrollments";
            Text = "FormEnrollments";
            Load += FormEnrollments_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSemesters;
        private ComboBox cbCourses;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}