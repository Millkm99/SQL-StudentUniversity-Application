namespace Assignment7_1140119
{
    partial class FormSearch
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
            txtSearch = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(315, 144);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(256, 31);
            txtSearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(315, 88);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 1;
            label1.Text = "Search by First Name";
            // 
            // button1
            // 
            button1.Location = new Point(200, 212);
            button1.Name = "button1";
            button1.Size = new Size(174, 35);
            button1.TabIndex = 2;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(445, 212);
            button2.Name = "button2";
            button2.Size = new Size(185, 35);
            button2.TabIndex = 3;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 290);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Name = "FormSearch";
            Text = "FormSearch";
            Load += FormSearch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}