using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2.model
{
    internal class mod
    {
        public string number { get; set; }
        public string date { get; set; }
        public string inventorynumber { get; set; }

        public string objectname{ get; set; }
        public  string count { get; set; }

        public string price{ get; set; }

        public void save()
        {

            MessageBox.Show(" succesfully added");
        }


    }
}
