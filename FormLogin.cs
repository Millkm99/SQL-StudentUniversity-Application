using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7_1140119
{
    public partial class FormLogin : Form
    {
        public string Username
        {
            get { return txtUsernamer.Text; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
        }
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
