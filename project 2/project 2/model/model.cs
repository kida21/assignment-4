using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace project_2.model
{
    public class mod
    {  
        private static List<mod> modList = new List<mod>();
        public string number { get; set; }
        public string date { get; set; }
        public string inventorynumber { get; set; }

        public string objectname{ get; set; }
        public  string count { get; set; }

        public string price{ get; set; }
        public bool available { get; set; }
        public bool delivery { get; set; }
        public string payment { get; set; }
        public bool isavailable { get; set; }

        
        public void save()
        {
           modList.Add(this);
           MessageBox.Show(" added succesfully");
        }
        public  static List<mod> getallproduct() { 
        
            return modList;
        
         }
        public static mod searchbyname(string m)
        {
            return getallproduct().Find(mod => mod.objectname == m);
        }
        public static mod searchbynumber (string n)
        {
            return getallproduct().Find(mod => mod.inventorynumber == n);
        }
    }
}
