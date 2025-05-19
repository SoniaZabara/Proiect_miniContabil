using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostulProductieProfitDDL
{
    public class ImpozitProfit
    {
        public decimal CalculeazaImpozitProfit(decimal profit, bool buttonRadioCk)
        {
            if (buttonRadioCk)
                return 10 * profit / 100;
            else
                return 16 * profit / 100;
        }

        public string CalculeazaImpozitProfit(string profitText, bool buttonRadioCk)
        {
            if (decimal.TryParse(profitText, out decimal profit))
            {
                decimal rezultat = CalculeazaImpozitProfit(profit, buttonRadioCk);
                return rezultat.ToString("F2");
            }
            throw new ArgumentException("Valorile introduse trebuie să fie numere valide");
        }
    }
}
