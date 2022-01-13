using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class ValidParentheses
    {
        public bool Sol(string s)
        {
            if (s.Length % 2 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
