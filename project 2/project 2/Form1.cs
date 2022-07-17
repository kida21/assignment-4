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
using System.Text.RegularExpressions;
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
            Regex numbercheck = new Regex(@"^ [0-9]{3}-[0-9]{3}-[0-9]{4}$");
            Regex inventorycheck = new Regex(@"^ [0-9]{3}-[0-9]{3}$");
            if (string.IsNullOrEmpty(txt_count.Text) || string.IsNullOrEmpty(txt_inventorynumber.Text) || string.IsNullOrEmpty(txt_nummber.Text) || string.IsNullOrEmpty(txt_objectname.Text) || string.IsNullOrEmpty(txt_price.Text))
            {
                if (!numbercheck.IsMatch(txt_nummber.Text))
                {
                    errorProvider1.SetError(txt_nummber, " wrong format should be in the form of (***-***_****");

                }
                else

                {
                    errorProvider1.SetError(txt_nummber, "");
                }
                if (!inventorycheck.IsMatch(txt_inventorynumber.Text))
                {
                    errorProvider1.SetError(txt_inventorynumber, " wrong format should be in the form of (***-***_****");
                }
                else
                {
                    errorProvider1.SetError(txt_inventorynumber, "");
                }
                if (string.IsNullOrEmpty(txt_count.Text))
                {
                    errorProvider1.SetError(txt_count, " count is required");
                }
                else
                {
                    errorProvider1.SetError(txt_count, "");
                }
                if (string.IsNullOrEmpty(txt_price.Text))
                {
                    errorProvider1.SetError(txt_price, " price is required");
                }
                else
                {
                    errorProvider1.SetError(txt_price, "");
                }
                if (string.IsNullOrEmpty(txt_objectname.Text))
                {
                    errorProvider1.SetError(txt_objectname, " this field is required");
                }
                else
                {
                    errorProvider1.SetError(txt_objectname, "");
                }

            }
            else
            {



                errorProvider1.Clear();


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
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = mod.getallproduct();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
