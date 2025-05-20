using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dividente
{
    public class Dividente
    {
        public static decimal CalculCheltuieliTotale(decimal amortizare, decimal cc, decimal salarii)
        {
            return amortizare + cc + salarii;
        }

        public static decimal CalculProfit(decimal ca, decimal ct)
        {
            return ca + ct;
        }

        public static decimal CalculDivident(decimal profit, decimal procent, decimal nrActiuni)
        {
            decimal divident;
            try
            {
                divident = (profit + profit / 100 * procent) / nrActiuni;
            }
            catch (DivideByZeroException)
            {
                divident = 0;
            }
            return divident;
        }
    }
}
