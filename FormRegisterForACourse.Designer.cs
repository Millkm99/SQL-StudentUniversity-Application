namespace Assignment7_1140119
{
    partial class FormRegisterForACourse
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
            txtName = new TextBox();
            txtId = new TextBox();
            cmbCourse = new ComboBox();
            lblName = new Label();
            label2 = new Label();
            lblCourse = new Label();
            btnCancel = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(448, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 31);
            txtName.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(448, 158);
            txtId.Name = "txtId";
            txtId.Size = new Size(166, 31);
            txtId.TabIndex = 1;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(448, 230);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(166, 33);
            cmbCourse.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(321, 88);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 158);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 4;
            label2.Text = "Id";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(321, 230);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(67, 25);
            lblCourse.TabIndex = 5;
            lblCourse.Text = "Course";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(321, 312);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(124, 59);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(503, 312);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(123, 59);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // FormRegisterForACourse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 398);
            Controls.Add(btnRegister);
            Controls.Add(btnCancel);
            Controls.Add(lblCourse);
            Controls.Add(label2);
            Controls.Add(lblName);
            Controls.Add(cmbCourse);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Name = "FormRegisterForACourse";
            Text = "FormRegisterForACourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtId;
        private ComboBox cmbCourse;
        private Label lblName;
        private Label label2;
        private Label lblCourse;
        private Button btnCancel;
        private Button btnRegister;
    }
}