using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Solution
    {
        public void main()
        {
            int n1, n2, sum;
            Console.WriteLine("Enter n1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter n2");
            n2 = Convert.ToInt32(Console.ReadLine());
            sum = n1 + n2;
            Console.WriteLine("There sum");
            Console.WriteLine(sum);
        }
    }
}
