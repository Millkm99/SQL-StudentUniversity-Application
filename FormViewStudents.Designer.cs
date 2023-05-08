namespace Assignment7_1140119
{
    partial class FormViewStudents
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
            label1 = new Label();
            cbDepartments = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 132);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 0;
            label1.Text = "Departments";
            // 
            // cbDepartments
            // 
            cbDepartments.FormattingEnabled = true;
            cbDepartments.Location = new Point(317, 132);
            cbDepartments.Name = "cbDepartments";
            cbDepartments.Size = new Size(206, 33);
            cbDepartments.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(144, 232);
            button1.Name = "button1";
            button1.Size = new Size(199, 62);
            button1.TabIndex = 2;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(415, 232);
            button2.Name = "button2";
            button2.Size = new Size(201, 62);
            button2.TabIndex = 3;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormViewStudents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 349);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cbDepartments);
            Controls.Add(label1);
            Name = "FormViewStudents";
            Text = "FormViewStudents";
            Load += FormViewStudents_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbDepartments;
        private Button button1;
        private Button button2;
    }
}