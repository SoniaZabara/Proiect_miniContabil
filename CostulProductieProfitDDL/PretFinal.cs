/**************************************************************************
 *                                                                        *
 *  File:        PragRentabilitate.cs                                     *
 *  Copyright:   (c) 2025, Chiuariu Vasile Silviu                         *
 *  E-mail:      vasile-silviu.chiuariu@student.tuiasi.ro                 *
 *  Description: Namespace which has useful calculations for the break    *
 *               even point                                               *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostulProductieProfitDDL
{
    public class PretFinal
    {
        /// <summary>
        /// Calculeaza costul total de productie.
        /// </summary>
        /// <param name="amortizare">Costul amortizarii echipamentelor si utilajelor</param>
        /// <param name="materiiPrime">Costul materiilor prime utilizate in productie</param>
        /// <param name="salarii">Costurile cu salariile personalului</param>
        /// <param name="materilaeAuxiliare">Costurile cu materialele auxiliare</param>
        /// <param name="chiria">Costurile cu chiria spatiilor de productie</param>
        /// <returns>Suma totala a costurilor de productie</returns>
        public decimal CalculeazaCostTotal(decimal amortizare, decimal materiiPrime, decimal salarii, decimal materilaeAuxiliare, decimal chiria)
        {
            return amortizare + materiiPrime + salarii + materilaeAuxiliare + chiria;
        }

        /// <summary>
        /// Supraincarcare a metodei de calcul pentru costul total care accepta valori sub forma de text.
        /// </summary>
        /// <param name="amortizareText">Textul reprezentand costul amortizarii</param>
        /// <param name="materiiPrimeText">Textul reprezentand costul materiilor prime</param>
        /// <param name="salariiText">Textul reprezentand costul salariilor</param>
        /// <param name="materilaeAuxiliareText">Textul reprezentand costul materialelor auxiliare</param>
        /// <param name="chiriaText">Textul reprezentand costul chiriei</param>
        /// <returns>Costul total formatat cu doua zecimale</returns>
        /// <exception cref="ArgumentException">Exceptie aruncata cand valorile introduse nu pot fi convertite in numere</exception>
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


        /// <summary>
        /// Calculeaza costul mediu pe unitate de produs prin impartirea costului total
        /// </summary>
        /// <param name="costTotal">Costul total de productie</param>
        /// <param name="nrUnitatiProduse">Numarul de unitati produse</param>
        public decimal CalculeazaCostMediu(decimal costTotal, decimal nrUnitatiProduse)
        {
            return costTotal / nrUnitatiProduse;
        }

        /// <summary>
        /// Supraincarcare a metodei de calcul pentru costul mediu care accepta valori sub forma de text.
        /// </summary>
        /// <param name="costTotalText">Textul reprezentand costul total</param>
        /// <param name="nrUnitatiProduseText">Textul reprezentand numarul de unitati produse</param>
        /// <exception cref="ArgumentException">Exceptie aruncata cand valorile introduse nu pot fi convertite in numere</exception>
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

        /// <summary>
        /// Supraincarcare a metodei de calcul pentru pretul final care accepta valori sub forma de text.
        /// </summary>
        /// <param name="costMediuText">Textul reprezentand costul mediu</param>
        /// <param name="profitMediuText">Textul reprezentand procentul de profit dorit</param>
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

        /// <summary>
        /// Calculeaza ponderea procentuala a unei componente de cost in pretul final total.
        /// </summary>
        /// <param name="val">Valoarea componentei de cost individuale</param>
        /// <param name="pretFinal">Pretul final per unitate de produs</param>
        /// <param name="numarUnitatiProd">Numarul total de unitati produse</param>
        public double CalculeazaProcentePie(double val, double pretFinal, double numarUnitatiProd)
        {
           
            double procentVal = (val / (pretFinal * numarUnitatiProd)) * 100;
            return procentVal;
                 
        }
    }
}
