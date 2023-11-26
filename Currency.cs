using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    public static class Currency
    {
        private const double DollarRate = 277.81;
        private const double PoundRate = 103.51;
        private const double DirhamRate = 20.44;

        public static double ConvertToRupees(double amount, string currency)
        {
            switch (currency.ToUpper())
            {
                case "USD":
                    return amount * DollarRate;
                case "GBP":
                    return amount * PoundRate;
                case "AED":
                    return amount * DirhamRate;
                default:
                    throw new ArgumentException("Invalid currency code");
            }
        }

        public static double ConvertFromRupees(double amount, string currency)
        {
            switch (currency.ToUpper())
            {
                case "USD":
                    return amount / DollarRate;
                case "GBP":
                    return amount / PoundRate;
                case "AED":
                    return amount / DirhamRate;
                default:
                    throw new ArgumentException("Invalid currency code");
            }
        }
    }
}
