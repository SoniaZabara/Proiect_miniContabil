/**************************************************************************
 *                                                                        *
 *  File:        Amortizari.cs                                            *
 *  Copyright:   (c) 2025, Bran Ioana-Andreea                             *
 *  E-mail:      ioana-andreea.bran@student.tuiasi.ro                     *
 *  Description:  The asset depreciation calculation module in the        *
 *                miniContaBill application. Includes methods for         *
 * calculating linear,progressive, and declining balance depreciation,    *
 * returning a list of annual values ​​and the remaining value. It is used  * 
 * within the accounting application to estimate the loss of value of     *
 * assets over time.                                                      *
 *                                                                        *
 *  Project:     miniContaBill                                            *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;

namespace Amortizari
{
    /// <summary>
    /// Clasa ce descrie un obiect de tipul Amortizare
    /// </summary>
    public class Amortizare
    {
        // Anul curent al amortizării.
        public int An { get; set; }

        // Valoarea amortizării anuale.
        public double AmortizareAnuala { get; set; }

        // Valoarea rămasă a activului după amortizare.
        public double ValoareRamasa { get; set; }
    }

    /// <summary>
    /// Clasă statică ce conține metode pentru calculul amortizării liniare, progresive și degresive.
    /// </summary>
    public static class AmortizareCalculator
    {
        /// <summary>
        /// Calculează amortizarea liniară.
        /// </summary>
        /// <param name="initialValue">Valoarea inițială a activului.</param>
        /// <param name="lifeTime">Durata de viață a activului (în ani).</param>
        /// <param name="rezidualValue">Valoarea reziduală estimată.</param>
        /// <returns>Lista amortizărilor anuale.</returns>
        public static List<Amortizare> Liniara(double initialValue, int lifeTime, double rezidualValue)
        {
            if (initialValue <= 0)
                throw new ArgumentException("Valoarea inițială trebuie să fie un număr pozitiv.");

            if (lifeTime <= 0)
                throw new ArgumentException("Durata de viață trebuie să fie un număr întreg pozitiv.");

            if (rezidualValue < 0)
                throw new ArgumentException("Valoarea reziduală nu poate fi negativă.");

            if (rezidualValue >= initialValue)
                throw new ArgumentException("Valoarea reziduală trebuie să fie mai mică decât valoarea inițială.");

            var amortizari = new List<Amortizare>();
            double amortizareAnuala = (initialValue - rezidualValue) / lifeTime;
            double valoareRamasa = initialValue;

            for (int an = 1; an <= lifeTime; an++)
            {
                valoareRamasa -= amortizareAnuala;
                amortizari.Add(new Amortizare
                {
                    An = an,
                    AmortizareAnuala = amortizareAnuala,
                    ValoareRamasa = valoareRamasa
                });
            }
            return amortizari;
        }

        /// <summary>
        /// Calculează amortizarea progresivă (crește în timp).
        /// </summary>
        /// <param name="initialValue">Valoarea inițială a activului.</param>
        /// <param name="lifeTime">Durata de viață a activului.</param>
        /// <param name="rezidualValue">Valoarea reziduală estimată.</param>
        /// <returns>Lista amortizărilor anuale.</returns>
        public static List<Amortizare> Progresiva(double initialValue, int lifeTime, double rezidualValue)
        {
            if (initialValue <= 0)
                throw new ArgumentException("Valoarea inițială trebuie să fie un număr pozitiv.");

            if (lifeTime <= 0)
                throw new ArgumentException("Durata de viață trebuie să fie un număr întreg pozitiv.");

            if (rezidualValue < 0)
                throw new ArgumentException("Valoarea reziduală nu poate fi negativă.");

            if (rezidualValue >= initialValue)
                throw new ArgumentException("Valoarea reziduală trebuie să fie mai mică decât valoarea inițială.");

            var amortizari = new List<Amortizare>();
            double bazaAmortizabila = initialValue - rezidualValue;
            int sumaPonderi = (lifeTime * (lifeTime + 1)) / 2;
            double valoareRamasa = initialValue;

            // Parcurgem fiecare an și calculăm amortizarea progresivă
            for (int an = 1; an <= lifeTime; an++)
            {
                double amortizareAnuala = bazaAmortizabila * an / sumaPonderi;
                valoareRamasa -= amortizareAnuala;
                amortizari.Add(new Amortizare
                {
                    An = an,
                    AmortizareAnuala = Math.Round(amortizareAnuala, 2),
                    ValoareRamasa = Math.Round(valoareRamasa, 2)
                });
            }
            return amortizari;
        }

        /// <summary>
        /// Calculează amortizarea degresivă (scade în timp).
        /// </summary>
        /// <param name="initialValue">Valoarea inițială a activului.</param>
        /// <param name="lifeTime">Durata de viață a activului.</param>
        /// <param name="rezidualValue">Valoarea reziduală estimată.</param>
        /// <returns>Lista amortizărilor anuale.</returns>
        public static List<Amortizare> Degresiva(double initialValue, int lifeTime, double rezidualValue)
        {
            if (initialValue <= 0)
                throw new ArgumentException("Valoarea inițială trebuie să fie un număr pozitiv.");

            if (lifeTime <= 0)
                throw new ArgumentException("Durata de viață trebuie să fie un număr întreg pozitiv.");

            if (rezidualValue < 0)
                throw new ArgumentException("Valoarea reziduală nu poate fi negativă.");

            if (rezidualValue >= initialValue)
                throw new ArgumentException("Valoarea reziduală trebuie să fie mai mică decât valoarea inițială.");

            var amortizari = new List<Amortizare>();
            double rataDegresiva = 2.0 / lifeTime;
            double valoareRamasa = initialValue;

            // Parcurgem fiecare an și calculăm amortizarea degresivă
            for (int an = 1; an <= lifeTime; an++)
            {
                double amortizareAnuala = valoareRamasa * rataDegresiva;

                // Verificăm dacă scădem sub valoarea reziduală
                if (valoareRamasa - amortizareAnuala < rezidualValue)
                {
                    amortizareAnuala = valoareRamasa - rezidualValue;
                }

                valoareRamasa -= amortizareAnuala;
                amortizari.Add(new Amortizare
                {
                    An = an,
                    AmortizareAnuala = Math.Round(amortizareAnuala, 2),
                    ValoareRamasa = Math.Round(valoareRamasa, 2)
                });

                if (valoareRamasa <= rezidualValue)
                    break;
            }

            return amortizari;
        }
    }
}
