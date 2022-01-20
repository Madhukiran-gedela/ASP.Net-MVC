using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class C_to_F
    {
       public  double convertToFahrenheit(double celTemp)
        {
            double fTemp = 0;

            fTemp = (celTemp * 9) / 5 + 32;

            return fTemp;
        }
        public void Temp()
        {
            double celTemp = 0;
            double ferTemp = 0;

            Console.Write("Enter the value of temperature in Celsius(°C): ");
            celTemp = double.Parse(Console.ReadLine());

            ferTemp = convertToFahrenheit(celTemp);
            Console.WriteLine("Fahrenheit temperature is(°F) : " + ferTemp);
        }
    }
}
