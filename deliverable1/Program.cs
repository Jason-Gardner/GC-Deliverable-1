using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code to allow printing of currency symbols
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Input for amounts to calculate with
            string dollar1, dollar2, dollar3;
            Console.WriteLine("Please enter three dollar amounts in dollars and cents.");
            dollar1 = Console.ReadLine();
            dollar2 = Console.ReadLine();
            dollar3 = Console.ReadLine();

            // Initial conversion to decimal and calculations of average, max and min amounts
            float amount1 = float.Parse(dollar1);
            float amount2 = float.Parse(dollar2);
            float amount3 = float.Parse(dollar3);
            float dollarTotal = (amount1 + amount2 + amount3);
            decimal dollarAvg = Average(dollarTotal);
            Console.WriteLine("The average of your amounts equals $" + Math.Round(dollarAvg, 2));
            Console.WriteLine("The highest amount was $" + MaxValue(amount1, amount2, amount3));
            Console.WriteLine("The lowest amount was $" + MinValue(amount1, amount2, amount3));
            Console.WriteLine();

            // The conversion portion utilizing cultureinfo and currency symbols
            decimal newTotal = (decimal)dollarTotal;
            Console.WriteLine("If you wanted to travel, you would have this much money in...");
            Console.WriteLine("The United States: " + "{0:c}", newTotal);
            Console.WriteLine(string.Format(new CultureInfo("th"), "Thailand " + "{0:c2}", newTotal));
            Console.WriteLine(string.Format(new CultureInfo("ja-JP"), "Japan " + "{0:c}", (Decimal.ToInt32(newTotal * 100))));
            Console.WriteLine(string.Format(new CultureInfo("sv-SE"), "Sweden " + "{0:c2}", (Convert.ToDecimal(newTotal))));

        }
        
        // Methods called in program to calculate average, min and max
        static decimal Average(float dollarTotal)
        {
            decimal tAverage = (decimal)dollarTotal;
            decimal average = (tAverage / 3);
            return average;
        }

        static decimal MaxValue(float dollarA, float dollarB, float dollarC)
        {
            decimal maxAmount;
            if (dollarA > dollarB && dollarA > dollarC)
            {
                maxAmount = (decimal)dollarA;
                return maxAmount;
            }
            else if (dollarB > dollarA && dollarB > dollarC)
            {
                maxAmount = (decimal)dollarB;
                return maxAmount;
            }
            else maxAmount = (decimal)dollarC;
            return maxAmount;
        }

        static decimal MinValue(float dollarA, float dollarB, float dollarC)
        {
            decimal minAmount;
            if (dollarA < dollarB && dollarA < dollarC)
            {
                minAmount = (decimal)dollarA;
                return minAmount;
            }
            else if (dollarB < dollarC && dollarB < dollarA)
            {
                minAmount = (decimal)dollarB;
                return minAmount;
            }
            else minAmount = (decimal)dollarC;
            return minAmount;
        }
    }
}
