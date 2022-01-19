using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_LAB05_CSDL_NC
{
    public class WorksOn
    {
        // attribute
        public float Hours { get; set; }
        //owner attributes
        public Employee Employee { get; set; }
        public Project Project { get; set; }
        //override string
        public override string ToString()
        {
            return $"{Hours} hr";
        }
    }
}
