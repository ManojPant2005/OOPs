using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_ADO
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void login_signup_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void show_pass_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = show_pass.Checked ? '\0' : '*';

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
