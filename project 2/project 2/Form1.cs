using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_2.model;
namespace project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            mod mod = new mod()
            {
                number = txt_nummber.Text,
                date = dt_registereddate.Text,
                inventorynumber = txt_inventorynumber.Text,
                objectname = txt_objectname.Text,
                count = txt_count.Text,
                price = txt_price.Text,

            };
            mod.save();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
