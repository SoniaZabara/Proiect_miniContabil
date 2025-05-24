/**************************************************************************
 *                                                                        *
 *  File:        PretTva.cs                                               *
 *  Copyright:   (c) 2025, Chiuariu Vasile Silviu                         *
 *  E-mail:      vasile-silviu.chiuariu@student.tuiasi.ro                 *
 *  Description: Clasa pentru calcularea pretului final cu TVA inclus     *
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
    public class PretTva
    {

        /// <summary>
        /// Calculeaza pretul final al unui produs inclusiv TVA.
        /// </summary>
        /// <param name="pretBrut">Pretul initial al produsului, fara TVA</param>
        /// <param name="cotaTva">Procentul de TVA exprimat in format zecimal</param>
        public decimal CalculeazaPretCuTva(decimal pretBrut, decimal cotaTva)
        {
            return pretBrut + cotaTva * pretBrut;
        }

        /// <summary>
        /// Supraincarcare a metodei de calcul pentru TVA care accepta valori sub forma de text.
        /// </summary>
        /// <param name="pretBrutText">Textul reprezentand pretul brut</param>
        /// <param name="cotaTvaText">Textul reprezentand cota TVA</param>
        /// <returns>Pretul final cu TVA formatat cu doua zecimale</returns>
        /// <exception cref="ArgumentException">Exceptie aruncata cand valorile introduse nu pot fi convertite in numere</exception>

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
