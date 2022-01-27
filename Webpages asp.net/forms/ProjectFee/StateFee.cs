using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProjectFee
{
    public class Statefee
    {
        public string Name
        {
            get;
            private set;
        }
        public string TwoLetterCode
        {
            get;
            private set;
        }
        public decimal Fee
        {
            get;
            private set;
        }
        public Statefee(string name, string twoLetterCode, decimal fee)
        {
            Name = name;
            TwoLetterCode = twoLetterCode;
            Fee = fee;
        }
    }
}
