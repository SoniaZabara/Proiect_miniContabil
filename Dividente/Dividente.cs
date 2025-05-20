/**************************************************************************
 *                                                                        *
 *  File:        Dividente.cs                                             *
 *  Copyright:   (c) 2025, Sonia Zabara                                   *
 *  E-mail:      sonia.zabara@student.tuiasi.ro                           *
 *  Description: Namespace which has useful calculations for the divident.*
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

namespace Dividente
{
    /// <summary>
    /// Clasă cu funcții utile pentru calcularea dividentului
    /// </summary>
    public class Dividente
    {
        /// <summary>
        /// Funcție pentru calcularea cheltuielilor totale
        /// </summary>
        /// <param name="amortizare">Valoarea amortizării totale</param>
        /// <param name="cc">Valoarea capitalului circulant</param>
        /// <param name="salarii">Valoarea totală a salariilor</param>
        /// <returns>Valoarea cheluielilor totale</returns>
        public static decimal CalculCheltuieliTotale(decimal amortizare, decimal cc, decimal salarii)
        {
            return amortizare + cc + salarii;
        }

        /// <summary>
        /// Funcție pentru calcularea profitului
        /// </summary>
        /// <param name="ca">Valoarea cifrei de afaceri</param>
        /// <param name="ct">Valoarea cheltuielilor totale</param>
        /// <returns>Valoarea profitului brut</returns>
        public static decimal CalculProfit(decimal ca, decimal ct)
        {
            return ca + ct;
        }

        /// <summary>
        /// Funcție pentru a calcula dividentul
        /// </summary>
        /// <param name="profit">Valoarea profitului brut</param>
        /// <param name="procent">Valoarea procentului ce urmează a fii reinvestit în firmă</param>
        /// <param name="nrActiuni">Numărul de acțiuni ale firmei</param>
        /// <returns>Valoarea dividentului</returns>
        public static decimal CalculDivident(decimal profit, decimal procent, decimal nrActiuni)
        {
            decimal divident;
            try
            {
                divident = (profit - profit / 100 * procent) / nrActiuni;
            }
            catch (DivideByZeroException)
            {
                divident = 0;
            }
            return divident;
        }
    }
}
