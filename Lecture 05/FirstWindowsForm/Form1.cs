using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChangeBackgroundColor_Click(object sender, EventArgs e)
        {
            txtEmail.BackColor = Color.Blue;
            txtPassword.BackColor = Color.Purple;
        }

        private void btnFillText_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "This is the Email field";
            txtPassword.Text = "This is the Password field";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
