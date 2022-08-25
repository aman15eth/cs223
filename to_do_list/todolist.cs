using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace to_do_list
{
    internal class todolist
    {
        public static List<todolist> amna = new List<todolist>();
        public string date { get; set; }
        public string name { get; set; }
        public string priority { get; set; }

        public bool done { get; set; }
        public void save()
        {
            amna.Add(this);
        }
        public List<todolist> getallitems()
        {
            return amna;


        }
    }




    }

