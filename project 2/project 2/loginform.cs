using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text=="user" && txt_password.Text == "password")
            {
                Form1 form1 = new Form1(this);
                form1.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("incorrect username or password");
            }
            txt_username.Text = "";
            txt_password.Text = "";

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

        }
    }
}
