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
    public partial class productcard : UserControl
    {
        public productcard()
        {
            InitializeComponent();
        }
        private string _pname;

        public string pname
        {
            get { return _pname;
                lbl_title.Text = _pname;
                    }
            set { _pname = value; }
        }
        private string _price;

        public string price
        {
            get { return _price; 
                  lbl_price.Text=_price;
                   }
            set { _price = value; }
        }
        private string _description;

        public string description
        {
            get { return _description; 
                 lbl_desc.Text = _description;
                 }
            set { _description = value; }
        }

        public productcard(string name,float price,string description,bool availabilty)
        {
            InitializeComponent();
            this . Name=name;
            this.price=price.ToString();
            this.description =description;
            this.pname= name;
            if(!availabilty){
                this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
        }

    }
}
