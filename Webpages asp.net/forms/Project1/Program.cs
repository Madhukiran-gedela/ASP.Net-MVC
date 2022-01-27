using System;
using System.Collections.Generic;
using System.Linq;
using Project1;
namespace Project1
{
    public class Program
    {
        public List<Statefee> ServiceAreaStateFees = new List<Statefee>();
        public decimal OutOfAreaFee { get; private set; }
        public Program()
        {
            ServiceAreaStateFees.Add(new Statefee("Washington", "WA", 8.99m));
            ServiceAreaStateFees.Add(new Statefee("Oregon", "OR", 2.99m));
            ServiceAreaStateFees.Add(new Statefee("California", "CA", 16.99m));
            ServiceAreaStateFees.Add(new Statefee("Idaho", "ID", 3.99m));
            ServiceAreaStateFees.Add(new Statefee("Nevada", "NV", 5.99m));
            ServiceAreaStateFees.Add(new Statefee("Utah", "UT", 2.99m));
            ServiceAreaStateFees.Add(new Statefee("Colorado", "CO", 8.99m));
            ServiceAreaStateFees.Add(new Statefee("Arizona", "AZ", 7.99m));
            OutOfAreaFee = 49.99m;
        }
        public decimal GetFeeForState(string twoLetterCode)
        {
            var state = ServiceAreaStateFees.FirstOrDefault(f => f.TwoLetterCode.Equals(twoLetterCode.ToUpper()));
            return state != null ? state.Fee : OutOfAreaFee;
        }
    }
}
