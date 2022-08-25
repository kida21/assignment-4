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
    public partial class detailpage : Form
    {
        public detailpage(model.mod m)
        {
            InitializeComponent();
           lbl_count.Text=m.count.ToString();
            lbl_date.Text=m.date.ToString();
            lbl_inventorynumber.Text=m.inventorynumber.ToString();
            lbl_number.Text=m.number.ToString();
            lbl_objectname.Text=m.objectname.ToString();
            lbl_price.Text=m.price.ToString();
            Show();
        }
        

        private void detailpage_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
