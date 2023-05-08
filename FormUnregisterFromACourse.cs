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
    public partial class FormUnregisterFromACourse : Form
    {
        public FormUnregisterFromACourse()
        {
            InitializeComponent();
        }

        private void btnUnregister_Click(object sender, EventArgs e)
        {
            // Get the student ID entered by the user
            string Id = txtId.Text;

            // Validate the student ID
            if (string.IsNullOrEmpty(Id))
            {
                MessageBox.Show("Please enter a student ID.");
                return;
            }

            // Check if the student is registered in the database
            if (!UBDBDataAccess.FormEnrollments(Id))
            {
                MessageBox.Show("The student with ID " + Id + " is not currently registered.");
                return;
            }

            // Unregister the student from the database
            if (UBDBDataAccess.FormUnregisterAStudent(Id))
            {
                MessageBox.Show("The student with ID " + Id + " has been unregistered.");
            }
            else
            {
                MessageBox.Show("An error occurred while attempting to unregister the student.");
            }
        }

        private void FormUnregisterFromACourse_Load(object sender, EventArgs e)
        {

        }
    }
}