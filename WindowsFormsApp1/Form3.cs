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
    public partial class frm3Packages : Form
    {
        public frm3Packages()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm4Report PersonalReport = new frm4Report();
            PersonalReport.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
