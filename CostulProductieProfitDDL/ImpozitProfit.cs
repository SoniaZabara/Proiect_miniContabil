/**************************************************************************
 *                                                                        *
 *  File:        ImpozitProfit.cs                                         *
 *  Copyright:   (c) 2025, Chiuariu Vasile Silviu                         *
 *  E-mail:      vasile-silviu.chiuariu@student.tuiasi.ro                 *
 *  Description: Namespace which has useful calculations for the impozit  *
 *               profit./.././././././                                    *
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
    public class ImpozitProfit
    {
        /// <summary>
        /// Determina suma ce trebuie platita catre stat din profitul realizat,
        /// aplicand cota corecta in functie de tipul firmei.
        /// </summary>
        /// <param name="profit">Suma din care se extrage impozitul datorat</param>
        /// <param name="buttonRadioCk">Indicator pentru tipul de firma</param>param> 
        
        public decimal CalculeazaImpozitProfit(decimal profit, bool buttonRadioCk)
        {
            if (buttonRadioCk)
                return 10 * profit / 100;
            else
                return 16 * profit / 100;
        }

        /// <summary>
        /// Ofera posibilitatea prelucrarii directe a datelor introduse de utilizator,
        /// evitand necesitatea conversiei separate inainte de calcul.
        /// </summary>
        /// <param name="profitText">Reprezentarea textuala a profitului pentru procesare directa</param>
        /// <param name="buttonRadioCk">Indicator pentru tipul de firma - 
        /// permite aplicarea cotei corecte conform regimului fiscal ales</param>
        /// <exception cref="ArgumentException">Semnaleaza probleme de validare pentru prevenirea calculelor eronate</exception>

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
