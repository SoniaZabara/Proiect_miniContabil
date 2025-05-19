using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostulProductieProfitDDL
{
    public class PretFinal
    {    
        public decimal CalculeazaCostTotal(decimal amortizare, decimal materiiPrime, decimal salarii, decimal materilaeAuxiliare, decimal chiria)
        {
            return amortizare + materiiPrime + salarii + materilaeAuxiliare + chiria;
        }

        public string CalculeazaCostTotal(string amortizareText, string materiiPrimeText, string salariiText, string materilaeAuxiliareText, string chiriaText)
        {
            if (decimal.TryParse(amortizareText, out decimal amortizare) &&
                decimal.TryParse(materiiPrimeText, out decimal materiiPrime) &&
                decimal.TryParse(salariiText, out decimal salarii) &&
                decimal.TryParse(materilaeAuxiliareText, out decimal materilaeAuxiliare) &&
                decimal.TryParse(chiriaText, out decimal chiria))
            {
                decimal rezultat = CalculeazaCostTotal(amortizare, materiiPrime, salarii, materilaeAuxiliare, chiria);
                return rezultat.ToString("F2");
            }
            throw new ArgumentException("Valorile introduse trebuie să fie numere valide");
        }


        public decimal CalculeazaCostMediu(decimal costTotal, decimal nrUnitatiProduse)
        {
            return costTotal / nrUnitatiProduse;
        }

        public string CalculeazaCostMediu(string costTotalText, string nrUnitatiProduseText)
        {
            if (decimal.TryParse(costTotalText, out decimal costTotal) &&
                decimal.TryParse(nrUnitatiProduseText, out decimal nrUnitatiProduse))
            {
                decimal rezultat = CalculeazaCostMediu(costTotal, nrUnitatiProduse);
                return rezultat.ToString("F2");
            }
            throw new ArgumentException("Valorile introduse trebuie să fie numere valide");
        }

        public decimal CalculeazaPretFinal(decimal costMediu, decimal profitMediu)
        {
            return costMediu + profitMediu;
        }

        public string CalculeazaPretFinal(string costMediuText, string profitMediuText)
        {
            if (decimal.TryParse(costMediuText, out decimal costMediu) &&
                decimal.TryParse(profitMediuText, out decimal profitMediu))
            {
                profitMediu = profitMediu * costMediu / 100;
                decimal rezultat = CalculeazaPretFinal(costMediu, profitMediu);
                return rezultat.ToString("F2");
            }
            throw new ArgumentException("Valorile introduse trebuie să fie numere valide");
        }

        public double CalculeazaProcentePie(double val, double pretFinal, double numarUnitatiProd)
        {
           
            double procentVal = (val / (pretFinal * numarUnitatiProd)) * 100;
            return procentVal;
                 
        }
    }
}
