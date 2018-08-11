using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_steck
{
    class Zavdannya
    {
        public string Zd { get; set; }
        public bool Done { get; set; }

        public Zavdannya(string z, bool d)
        {
            Zd = z;
            Done = d;
        }
    }
}
