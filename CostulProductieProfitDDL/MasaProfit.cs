/**************************************************************************
 *                                                                        *
 *  File:        MasaProfit.cs                                            *
 *  Copyright:   (c) 2025, Chiuariu Vasile Silviu                         *
 *  E-mail:      vasile-silviu.chiuariu@student.tuiasi.ro                 *
 *  Description: Namespace which has useful calculations for the masa     *
 *               profit                                                   *
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
    public class MasaProfit
    {
        /// <summary>
        /// Calculeaza masa profitului 
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
