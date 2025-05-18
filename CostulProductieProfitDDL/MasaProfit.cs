using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostulProductieProfitDDL
{
    public class MasaProfit
    {
        /// <summary>
        /// Calculeaza masa profitului folosind formula: PretVanzare - Costuri
        /// </summary>
        /// <param name="pretVanzare">Pret de vanzare sau Veniturile</param>
        /// <param name="costuri">Costurile totale</param>
        /// <returns>Masa profitului calculat</returns>
        public decimal CalculeazaMasaProfit(decimal pretVanzare, decimal costuri)
        {
            return pretVanzare - costuri;
        }

        /// <summary>
        /// Versiune care primeste valori ca string si face conversia
        /// </summary>
        public string CalculeazaMasaProfit(string pretVanzareText, string costuriText)
        {
            if (decimal.TryParse(pretVanzareText, out decimal pretVanzare) &&
                decimal.TryParse(costuriText, out decimal costuri))
            {
                decimal rezultat = CalculeazaMasaProfit(pretVanzare, costuri);
                return rezultat.ToString("F2"); 
            }
            throw new ArgumentException("Valorile introduse trebuie să fie numere valide");
        }
    }
}
