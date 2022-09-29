using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

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
            try
            {
                SqlConnection con = new SqlConnection("data source = .;inital catalog=prjectdb;integrated security=true;");
                con.Open();
                int y;
                if (this.isavailable == true)
                {
                    y=0;
                }
                else
                {
                    y = 1;
                }
                SqlCommand cmd = new SqlCommand($" insert into item values({this.number},'{this.date}',{this.inventorynumber},'{this.objectname}',{this.price},'{this.count}',{y})", con);
                cmd.ExecuteReader();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           // modList.Add(this);
           //MessageBox.Show(" added succesfully");
        }
        public  static List<mod> getallproduct() { 
           List<mod> modlist = new List<mod>();
            try
            {
                SqlConnection con = new SqlConnection("data source = .;inital catalog=prjectdb;integrated security=true;");
                con.Open();
                SqlCommand cmd = new SqlCommand($" select * from mod ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    modlist.Add(new mod()
                    {
                        number = dr["number"].ToString(),
                        date = dr["date"].ToString(),
                        inventorynumber = dr["inventorynum"].ToString(),
                        objectname = dr["objname"].ToString(),
                        price = dr["price"].ToString(),
                        count = dr["count"].ToString(),
                        isavailable = (bool)dr["isavail"]
                    }
                    );
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
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
