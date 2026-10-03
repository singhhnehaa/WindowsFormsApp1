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
    public partial class FrmLegacyFitness : Form
    {
        public FrmLegacyFitness()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

       
            frmRegistration Register = new frmRegistration();
            Register.Show();
            this.Hide();

            MessageBox.Show("Please enter all the required information and press the save button to capture" +
            " your information into the system.", " Information Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmHomePage homepage = new frmHomePage();
            homepage.Show();
            this.Hide();
        }
    }
}
