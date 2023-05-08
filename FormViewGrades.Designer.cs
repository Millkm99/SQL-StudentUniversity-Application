namespace Assignment7_1140119
{
    partial class FormViewGrades
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
            lblName = new Label();
            lblId = new Label();
            txtName = new TextBox();
            txtId = new TextBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            gradesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gradesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(81, 47);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(81, 142);
            lblId.Name = "lblId";
            lblId.Size = new Size(27, 25);
            lblId.TabIndex = 1;
            lblId.Text = "ld";
            // 
            // txtName
            // 
            txtName.Location = new Point(265, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(265, 136);
            txtId.Name = "txtId";
            txtId.Size = new Size(135, 31);
            txtId.TabIndex = 3;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(281, 252);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(134, 48);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(45, 252);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(137, 51);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // gradesDataGridView
            // 
            gradesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gradesDataGridView.Location = new Point(478, 46);
            gradesDataGridView.Name = "gradesDataGridView";
            gradesDataGridView.RowHeadersWidth = 62;
            gradesDataGridView.RowTemplate.Height = 33;
            gradesDataGridView.Size = new Size(408, 300);
            gradesDataGridView.TabIndex = 6;
            // 
            // FormViewGrades
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 385);
            Controls.Add(gradesDataGridView);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Name = "FormViewGrades";
            Text = "FormViewGrades";
            ((System.ComponentModel.ISupportInitialize)gradesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblId;
        private TextBox txtName;
        private TextBox txtId;
        private Button btnSubmit;
        private Button btnCancel;
        private DataGridView gradesDataGridView;
    }
}