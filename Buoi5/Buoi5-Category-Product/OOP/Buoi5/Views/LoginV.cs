using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi51.Views
{
    public partial class LoginV : Form
    {
        public LoginV()
        {
            InitializeComponent();
        }

        private void LoginV_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin")
                if (txtPass.Text == "admin")
                    DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("Sai Pass");
            else
                MessageBox.Show("Sai User");

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Focus();
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
        }

        private void LoginV_Shown(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}
