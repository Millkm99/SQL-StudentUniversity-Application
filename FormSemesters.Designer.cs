namespace Assignment7_1140119
{
    partial class FormSemesters
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
            button1 = new Button();
            button2 = new Button();
            cbSemesters = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 103);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 0;
            label1.Text = "Semesters";
            // 
            // button1
            // 
            button1.Location = new Point(175, 205);
            button1.Name = "button1";
            button1.Size = new Size(152, 58);
            button1.TabIndex = 2;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(409, 205);
            button2.Name = "button2";
            button2.Size = new Size(168, 58);
            button2.TabIndex = 3;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            // 
            // cbSemesters
            // 
            cbSemesters.FormattingEnabled = true;
            cbSemesters.Location = new Point(395, 103);
            cbSemesters.Name = "cbSemesters";
            cbSemesters.Size = new Size(211, 33);
            cbSemesters.TabIndex = 4;
            // 
            // FormSemesters
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 341);
            Controls.Add(cbSemesters);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "FormSemesters";
            Text = "FormSemesters";
            Load += FormSemesters_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private ComboBox cbSemesters;
    }
}