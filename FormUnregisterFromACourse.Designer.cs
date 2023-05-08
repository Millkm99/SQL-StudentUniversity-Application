namespace Assignment7_1140119
{
    partial class FormUnregisterFromACourse
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
            btnUnregister = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            cmbCourse = new ComboBox();
            txtName = new TextBox();
            lblId = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // btnUnregister
            // 
            btnUnregister.Location = new Point(455, 246);
            btnUnregister.Name = "btnUnregister";
            btnUnregister.Size = new Size(162, 73);
            btnUnregister.TabIndex = 0;
            btnUnregister.Text = "Unregister";
            btnUnregister.UseVisualStyleBackColor = true;
            btnUnregister.Click += btnUnregister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(176, 246);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(154, 73);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 41);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 2;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 139);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 3;
            label2.Text = "Course";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(404, 139);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(132, 33);
            cmbCourse.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(404, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(132, 31);
            txtName.TabIndex = 5;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(193, 94);
            lblId.Name = "lblId";
            lblId.Size = new Size(28, 25);
            lblId.TabIndex = 6;
            lblId.Text = "Id";
            // 
            // txtId
            // 
            txtId.Location = new Point(404, 94);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 31);
            txtId.TabIndex = 7;
            // 
            // FormUnregisterFromACourse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 367);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Controls.Add(txtName);
            Controls.Add(cmbCourse);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnUnregister);
            Name = "FormUnregisterFromACourse";
            Text = "FormUnregisterFromACourse";
            Load += FormUnregisterFromACourse_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUnregister;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private ComboBox cmbCourse;
        private TextBox txtName;
        private Label lblId;
        private TextBox txtId;
    }
}