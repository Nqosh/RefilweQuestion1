using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StringBuilder sb = new StringBuilder();
        int incrementedNum = 0;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtSurname.Text == string.Empty)
            {
                MessageBox.Show("Please enter Surname", "Error", MessageBoxButtons.OK);
                return;
            }

            if (txtFullName.Text == string.Empty)
            {
                MessageBox.Show("Please enter Full Name", "Error", MessageBoxButtons.OK);
                return;
            }

            if (txtContact.Text.Length < 10)
            {
                MessageBox.Show("Please enter Correct Contact Number", "Error", MessageBoxButtons.OK);
                return;
            }
            string surName = txtSurname.Text;
            string fullName = txtFullName.Text;
            string contact = txtContact.Text;
            int gender = 0;
            string startingStudentNum = "00";
            if (cmbGender.SelectedIndex == 0)
            {
                gender = 2;
            }
            else
            {
                gender = 3;
            }
            incrementedNum++;
            DateTime dt = DateTime.Today;
            string buidingStudentNum = string.Empty;
            buidingStudentNum = startingStudentNum + incrementedNum;
            string studentNum = Convert.ToString(dt.Year) + Convert.ToString(gender) + buidingStudentNum;
            string lastSequenceNum = incrementedNum.ToString(); ;
            string lineDiveder = "===========================";
            string result = "Student Number:" + ' ' + studentNum + Environment.NewLine +
                surName + "," + fullName + Environment.NewLine +
                "Contacts:" + ' ' + contact + Environment.NewLine +
                lineDiveder;

            sb.Append(result);

            txtResult.Text = sb.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSurname.Text = "";
            txtFullName.Text = "";
            txtContact.Text = "";
        }
    }
}
