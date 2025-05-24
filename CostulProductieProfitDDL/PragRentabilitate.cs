/**************************************************************************
 *                                                                        *
 *  File:        PragRentabilitate.cs                                     *
 *  Copyright:   (c) 2025, Chiuariu Vasile Silviu                         *
 *  E-mail:      vasile-silviu.chiuariu@student.tuiasi.ro                 *
 *  Description: Namespace which has useful calculations for the prag     *
 *               rentabilitate                                            *
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
    public class PragRentabilitate
    {
        /// <summary>
        /// Determina numarul minim de unitati ce trebuie produse pentru a atinge punctul de rentabilitate
        /// sau pragul de profit dorit, in functie de modelul economic ales.
        /// </summary>
        /// <param name="pretUnitateProdus">Pretul de vanzare per unitate de produs</param>
        /// <param name="costFixTotal">Costurile fixe totale care trebuie acoperite indiferent de nivelul productiei</param>
        /// <param name="profit">Suma tinta de profit pentru modelul cu profit specificat</param>
        /// <param name="costVarMedii">Costurile variabile medii per unitate de produs</param>
        /// <param name="buttonRadioCk">Indicator pentru tipul de calcul:
        /// true - calcul pentru pragul de rentabilitate simplu (break-even point)
        /// false - calcul pentru pragul de rentabilitate cu profit tinta</param>

        public decimal CalculeazaPragRentabilitate(decimal pretUnitateProdus, decimal costFixTotal, decimal profit, decimal costVarMedii, bool buttonRadioCk)
        {
            if (buttonRadioCk)
                return costFixTotal / (pretUnitateProdus - costVarMedii);
            else
                return (costFixTotal + profit) / (pretUnitateProdus - costVarMedii);
        }

        /// <summary>
        /// Permite calculul pragului de rentabilitate direct din valorile introduse de utilizator,
        /// oferind validarea datelor si gestionarea erorilor pentru un calcul economic corect.
        /// </summary>
        /// <param name="pretUnitateProdusText">Reprezentarea textuala a pretului unitar</param>
        /// <param name="costFixTotalText">Reprezentarea textuala a costurilor fixe totale</param>
        /// <param name="profitText">Reprezentarea textuala a profitului dorit</param>
        /// <param name="costVarMediiText">Reprezentarea textuala a costurilor variabile medii</param>
        /// <param name="buttonRadioCk">Indicator pentru metodologia de calcul aleasa</param>
        /// <exception cref="ArgumentException">Semnaleaza date invalide sau conditii economice imposibile</exception>

        public string CalculeazaPragRentabilitate(string pretUnitateProdusText, string costFixTotalText, string profitText, string costVarMediiText, bool buttonRadioCk)
        {
            if (!decimal.TryParse(pretUnitateProdusText, out decimal pretUnitateProdus) ||
                !decimal.TryParse(costFixTotalText, out decimal costFixTotal) ||
                !decimal.TryParse(costVarMediiText, out decimal costVarMedii))
                throw new ArgumentException("Preț unitate, cost fix și cost variabil mediu trebuie să fie numere valide");
            
            if (!decimal.TryParse(profitText, out decimal profit) && buttonRadioCk == false)
                throw new ArgumentException("Profitul trebuie să fie numere valide");
     
            if (pretUnitateProdus <= costVarMedii)
                throw new ArgumentException("Pretul produsului trebuie sa fie mai mare decat costul variabilelor medii");

            decimal rezultat = CalculeazaPragRentabilitate(pretUnitateProdus, costFixTotal, profit, costVarMedii, buttonRadioCk);
            return rezultat.ToString("F2");
        }
    }
}
