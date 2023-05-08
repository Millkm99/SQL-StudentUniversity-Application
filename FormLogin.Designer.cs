namespace Assignment7_1140119
{
    partial class FormLogin
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
            label2 = new Label();
            txtUsernamer = new TextBox();
            txtPassword = new TextBox();
            btnCancel = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 54);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 131);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUsernamer
            // 
            txtUsernamer.Location = new Point(285, 54);
            txtUsernamer.Name = "txtUsernamer";
            txtUsernamer.Size = new Size(204, 31);
            txtUsernamer.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(285, 131);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(204, 31);
            txtPassword.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(106, 205);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(161, 61);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(355, 205);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 65);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 292);
            Controls.Add(btnLogin);
            Controls.Add(btnCancel);
            Controls.Add(txtPassword);
            Controls.Add(txtUsernamer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsernamer;
        private TextBox txtPassword;
        private Button btnCancel;
        private Button btnLogin;
    }
}