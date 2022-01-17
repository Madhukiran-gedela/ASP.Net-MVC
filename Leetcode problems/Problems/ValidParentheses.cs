using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class ValidParentheses
    {
        public void Sol()
        {
          //  string[] s = new string[4];
          //s[0] = "Madhu";
          //s[1] = "kiran";
          //s[2] = "yugi";
          //s[3] = "jagadeesh";
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
