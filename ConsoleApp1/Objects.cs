using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Objects
    {


        public class Oll
        {
            public int id { get; set; }
            public string name { get; set; }
            public DateTime datebirth { get; set; }
            public string gend { get; set; }
            public string email { get; set; }
            public string country { get; set; }
            public string city { get; set; }
            public override string ToString()
            {
                return ($"{this.id} | {this.name} | {this.gend} | {this.email} | {this.country} | {this.city}");
            }
        }


        public class Section
        {
            public int id { get; set; }
            public string section { get; set; }
            public override string ToString()
            {
                return ($"{this.id} | {this.section} ");
            }

        }


        public class Action
        {
            public int id { get; set; }
            public string good { get; set; }
            public DateTime startdate { get; set; }
            public DateTime enddate { get; set; }
            public string country { get; set; }
            public override string ToString()
            {
                return ($"{this.id} | {this.good} | {this.startdate} | {this.enddate} | {this.country}");
            }

        }

    }
}
