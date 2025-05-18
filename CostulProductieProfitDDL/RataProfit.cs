using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostulProductieProfitDDL
{
    public class RataProfit
    {
        public decimal CalculeazaRataProfit(decimal masaProfit, decimal costuri)
        {
            return masaProfit / costuri * 100;
        }

        public string CalculeazaRataProfit(string masaProfitText, string costuriText)
        {
            if (decimal.TryParse(masaProfitText, out decimal masaProfit) && 
                decimal.TryParse(costuriText, out decimal costuri))
            {
                decimal rezultat = CalculeazaRataProfit(masaProfit, costuri);
                return rezultat.ToString("F2");
            }
            throw new ArgumentException("Valorile introduse trebuie să fie numere valide");
        }
    }
}
