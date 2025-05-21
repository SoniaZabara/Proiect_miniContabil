/**************************************************************************
 *                                                                        *
 *  File:        RataProfit.cs                                            *
 *  Copyright:   (c) 2025, Chiuariu Vasile Silviu                         *
 *  E-mail:      vasile-silviu.chiuariu@student.tuiasi.ro                 *
 *  Description: Clasa pentru calculul ratei de profit a unei afaceri     *
 *                                                                        *
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
    public class RataProfit
    {
        /// <summary>
        /// Calculeaza rata de profit a unei activitati economice exprimata procentual.
        /// </summary>
        /// <param name="masaProfit">Valoarea absoluta a profitului obtinut</param>
        /// <param name="costuri">Totalul costurilor generate pentru obtinerea profitului</param>
        public decimal CalculeazaRataProfit(decimal masaProfit, decimal costuri)
        {
            return masaProfit / costuri * 100;
        }

        /// <summary>
        /// Supraincarcare a metodei de calcul pentru rata de profit care accepta valori sub forma de text.
        /// </summary>
        /// <param name="masaProfitText">Textul reprezentand valoarea masei de profit</param>
        /// <param name="costuriText">Textul reprezentand valoarea costurilor</param>
        /// <exception cref="ArgumentException">Exceptie aruncata cand valorile introduse nu pot fi convertite in numere</exception>
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
