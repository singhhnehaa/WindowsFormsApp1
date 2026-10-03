using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmRegistration : Form
    {
        private bool informationSaved = false;
        string firstName, lastName, eMail, cellNum, idNum, dOB, passWord, userName, eName, eCellNum; 
        public frmRegistration()
        {
            InitializeComponent();
        }
        // All If Statements below allow the user to use the enter button to navigate forward to other textboxes to add information
        // These statements check if the user pressed the enter button and then moves to the next textbox

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            txtFirstname.Focus();
        }

        private void txtFirstname_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                txtLastname.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtLastname_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtxtCell.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void mtxtCell_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mtxtID.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void mtxtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpDob.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void dtpDob_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtUsername.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();

            }
        }


        // The below if statement allows the user to show or hide their password using the checkbox 
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            bool allInfo = !string.IsNullOrWhiteSpace(txtFirstname.Text)
                && !string.IsNullOrWhiteSpace(txtLastname.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text)
                && !string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtEmail.Text)
                && !string.IsNullOrWhiteSpace(txtUsername.Text) && mtxtCell.MaskCompleted
                && mtxtNumber.MaskCompleted && mtxtID.MaskCompleted; 

            if(!allInfo)
            {
                MessageBox.Show("Please enter all the required information.");
                return;
            }
                
            firstName = txtFirstname.Text;
            lastName = txtLastname.Text;
            eMail = txtEmail.Text;
            cellNum = mtxtCell.Text;
            idNum = mtxtID.Text;
            dOB = dtpDob.Value.ToString("yy/MM/dd");
            userName = txtUsername.Text;
            eCellNum = mtxtNumber.Text;
            eName = txtName.Text;
            passWord = txtPassword.Text;



            MessageBox.Show("Information Successfully Captured.");

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                MessageBox.Show("Please enter your name.", "Incomplete field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstname.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtLastname.Text))
            {
                MessageBox.Show("Please enter your lastname.", "Incomplete field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastname.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid email address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;

            }
            if(!mtxtCell.MaskCompleted || !mtxtCell.Text.StartsWith("0"))
            {
                MessageBox.Show("Please enter a valid 10 digit cell number that starts with a 0.", "Incorrect cell number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtCell.Focus();
                return;
            }
            string idDate = mtxtID.Text.Substring(0, 6);
            string bDateForId = dtpDob.Value.ToString("yyMMdd");

            if(idDate !=  bDateForId)
            {
                MessageBox.Show("The ID number does not match your date of birth.", "Incorrect ID number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtID.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please create a password.");
                txtPassword.Focus();
                return;
            }
            if(!mtxtNumber.MaskCompleted || !mtxtNumber.Text.StartsWith("0"))
            {
                MessageBox.Show("Please enter an emergency contact number.");
                mtxtNumber.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Enter a username you will use for future logins.");
                txtUsername.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please Enter the name of the person that we will reach in any circumstance.");
                txtName.Focus();
                return;
            }
        }
    }
}
