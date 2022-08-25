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
    public partial class newcontainer : Form
    {
        //loginform loginform;
        public newcontainer()
        {
            InitializeComponent();
            //this.loginform = loginform; 
        }

        private void addproductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();

            }
            Form1 q = new Form1(new loginform());
            q.MdiParent=this;
            q.Show();
            
        }

        private void newcontainer_Load(object sender, EventArgs e)
        {
            
        }

        private void viewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

           panel z = new panel();
           
            z.MdiParent = this;
            z.Show();
        }
    }
}
