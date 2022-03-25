using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighSchoolGroupProject
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDatabase();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.CloseDisposeDatabase();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (clsValidation.Password(tbxPassword.Text))
            {
                ProgOps.Login(tbxUsername.Text, tbxPassword.Text);
            }
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {

        }
    }
}
