using System;
using System.Collections.Generic;
namespace converting_roman_to_integer
{
    public class Solution
    {
        public static void Main()
        {
            Console.WriteLine(Romantoint("IX"));
        }
        public static int Romantoint(string s)
        {
            // LVII
            // XVIII
            // IX
            Dictionary<string, int> Dict = new Dictionary<string, int>();
            Dict["I"] = 1;
            Dict["V"] = 5;
            Dict["X"] = 10;             
            Dict["L"] = 50;
            Dict["D"] = 100;
            Dict["M"] = 1000;
            int a = 0;
            foreach (char item in s)
            {
                a += Dict[Convert.ToString(item)];
                // Console.WriteLine("Enter a value",s. )
            }
            return a;
        }

    }
}
