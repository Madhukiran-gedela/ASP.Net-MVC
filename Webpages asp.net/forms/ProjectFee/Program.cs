using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFee
{
    public class Program
    {
        public List<Statefee> ServiceAreaStateFees = new List<Statefee>();
        public decimal OutOfAreaFee { get; private set; }
        public Program()
        {
            ServiceAreaStateFees.Add(new Statefee("Washington", "IN", 8.99m));
            ServiceAreaStateFees.Add(new Statefee("Oregon", "ON", 2.99m));
            ServiceAreaStateFees.Add(new Statefee("California", "CA", 16.99m));
            ServiceAreaStateFees.Add(new Statefee("Idaho", "KY", 3.99m));
            ServiceAreaStateFees.Add(new Statefee("Nevada", "Ag", 5.99m));
            ServiceAreaStateFees.Add(new Statefee("Utah", "NZ", 2.99m));
            ServiceAreaStateFees.Add(new Statefee("Colorado", "CO", 8.99m));
            ServiceAreaStateFees.Add(new Statefee("Arizona", "SA", 7.99m));
            ServiceAreaStateFees.Add(new Statefee("Arizonaaa", "WI", 7.99m));
            OutOfAreaFee = 49.99m;
        }
        public decimal GetFeeForState(string twoLetterCode)
        {
            var state = ServiceAreaStateFees.FirstOrDefault(f => f.TwoLetterCode.Equals(twoLetterCode.ToUpper()));
            return state != null ? state.Fee : OutOfAreaFee;
        }
    }
}