using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostulProductieProfitDDL
{
    public class PretTva
    {
        public decimal CalculeazaPretCuTva(decimal pretBrut, decimal cotaTva)
        {
            return pretBrut + cotaTva * pretBrut;
        }

        public string CalculeazaPretCuTva(string pretBrutText, string cotaTvaText)
        {
            if (decimal.TryParse(pretBrutText, out decimal pretBrut) &&
                decimal.TryParse(cotaTvaText, out decimal cotaTva))
            {
                decimal rezultat = CalculeazaPretCuTva(pretBrut, cotaTva);
                return rezultat.ToString("F2");
            }
            throw new ArgumentException("Valorile introduse trebuie să fie numere valide");
        }
    }
}
