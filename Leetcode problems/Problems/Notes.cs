using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Notes
    {
        public void Rupees()
        {
            int numb = Convert.ToInt32(Console.ReadLine());
            List<int> rand = new List<int>();
            for (int i = 0; i < numb; i++)
            {
                var x = Console.ReadLine();
                int a = Convert.ToInt32(x[0].ToString());
                int b = Convert.ToInt32(x[x.Length - 1].ToString());

                //  Console.WriteLine(a + b);
                rand.Add(a + b);
            }
            foreach (int item in rand)
            {
                Console.WriteLine(item);
            }
        }
    }

}
