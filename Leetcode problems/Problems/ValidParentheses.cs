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
            string s1 = "()";
            if (s1 == "{()}")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
