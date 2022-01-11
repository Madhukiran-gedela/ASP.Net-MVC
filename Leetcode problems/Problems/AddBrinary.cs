using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class AddBrinary
    {
        public string Sol(string a, string b)
        {
            var y = Convert.ToInt32(a, 2);
            var z =Convert.ToInt32(b,2);
            //Console.WriteLine (y + z);
            return Convert.ToString(y+z,2);

        }
    }
}
