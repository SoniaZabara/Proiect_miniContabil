using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostulProductieProfitDDL
{
    public class PragRentabilitate
    {
        public decimal CalculeazaPragRentabilitate(decimal pretUnitateProdus, decimal costFixTotal, decimal profit, decimal costVarMedii, bool buttonRadioCk)
        {
            if (buttonRadioCk)
                return costFixTotal / (pretUnitateProdus - costVarMedii);
            else
                return (costFixTotal + profit) / (pretUnitateProdus - costVarMedii);
        }


        public string CalculeazaPragRentabilitate(string pretUnitateProdusText, string costFixTotalText, string profitText, string costVarMediiText, bool buttonRadioCk)
        {
            if (!decimal.TryParse(pretUnitateProdusText, out decimal pretUnitateProdus) ||
                !decimal.TryParse(costFixTotalText, out decimal costFixTotal) ||
                !decimal.TryParse(costVarMediiText, out decimal costVarMedii))
            {
                throw new ArgumentException("Preț unitate, cost fix și cost variabil mediu trebuie să fie numere valide");
            }
            if (!decimal.TryParse(profitText, out decimal profit) && buttonRadioCk == false)
            {
                throw new ArgumentException("Profitul trebuie să fie numere valide");
            }
            decimal rezultat = CalculeazaPragRentabilitate(pretUnitateProdus, costFixTotal, profit, costVarMedii, buttonRadioCk);
            return rezultat.ToString("F2");
        }
    }
}
