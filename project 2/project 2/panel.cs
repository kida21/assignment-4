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
    public partial class panel : Form
    {
        public panel()
        {
            InitializeComponent();
        }

        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel_Load(object sender, EventArgs e)
        {
            foreach(var mod in model.mod.getallproduct())
            {
                productcard w = new productcard(mod.objectname, (float)Double.Parse(mod.price), mod.number, mod.available);
                w.Click += (object o, EventArgs rd) => { new detailpage(mod); };
                w.Dock= DockStyle.Top;
                w.Width = 674;
                flowLayoutPanel1.Controls.Add(w);
;            }
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            pnl_highlight.Top = 78;
            flowLayoutPanel1.BackColor = Color.Green;
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            pnl_highlight.Top = 187;
            flowLayoutPanel1.BackColor = Color.Yellow;
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            pnl_highlight.Top = 250;
            flowLayoutPanel1.BackColor = Color.Red;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
