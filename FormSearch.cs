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
    public partial class FormSearch : Form
    {
        public string Firstname { get { return txtSearch.Text; } }
        public FormSearch()
        {
            InitializeComponent();
        }


        private void FormSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
