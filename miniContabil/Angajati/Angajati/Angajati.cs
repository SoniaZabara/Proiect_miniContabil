/******************************************************************************
 *                                                                            *
 *  File:        Angajati.cs                                                  *
 *  Author:      Bran Ioana-Andreea                                           *
 *  E-mail:      ioana-andreea.bran@student.tuiasi.ro                         *
 *  Description: This module defines the employee model and provides salary   *
 *               calculation utilities used in the miniContaBill application. *
 *               It includes functions for calculating net salary, total      *
 *               salary, average salary, and employer cost for employees.     *
 *                                                                            *
 *  Project:     miniContaBill                                                *
 *                                                                            *
 *  This code and information are provided "as is" without warranty of any    *
 *  kind, either expressed or implied, including but not limited to the       *
 *  implied warranties of merchantability or fitness for a particular purpose.*
 *  You are free to use this source code in your applications as long as the  *
 *  original copyright notice is included.                                    *
 *                                                                            *
 ******************************************************************************/

using System.Collections.Generic;
using System.Linq;

namespace SalariiAngajati
{
    /// <summary>
    /// Clasa ce reprezinta un obiect de tipul Angajat
    /// </summary>
    public class Angajat
    {
        public int Id { get; set; }
        public string NumeAngajat { get; set; }
        public string Functie { get; set; }
        public double SalariuBrut { get; set; }
        public string Departament { get; set; }

        public Angajat(int id, string numeAngajat, string functie, double salariuBrut, string departament)
        {
            Id = id;
            NumeAngajat = numeAngajat;
            Functie = functie;
            SalariuBrut = salariuBrut;
            Departament = departament;
        }
    }

    /// <summary>
    /// Clasă statică pentru calculul salariilor și costurilor aferente
    /// </summary>
    public static class SalaryCalculator
    {
        // Calculează salariul mediu brut pentru o listă de angajați
        public static double CalculateAverageSalary(IEnumerable<Angajat> angajati)
        {
            if (angajati == null || !angajati.Any())
                return 0;
            return angajati.Average(a => a.SalariuBrut);
        }

        // Calculează suma totală a salariilor brute
        public static double CalculateTotalSalary(IEnumerable<Angajat> angajati)
        {
            if (angajati == null)
                return 0;
            return angajati.Sum(a => a.SalariuBrut);
        }

        // Calculează salariul net pentru un angajat
        public static double CalculateNetSalary(Angajat angajat)
        {
            if (angajat == null)
                return 0;

            // CAS - contribuția la asigurări sociale (25%)
            double asigurareSociala = 0.25 * angajat.SalariuBrut;

            // CASS - contribuția la asigurări de sănătate (10%)
            double asigurareSanatate = 0.10 * angajat.SalariuBrut;

            // Impozit pe venit (10% din venitul rămas după CAS și CASS)
            double impozit = 0.10 * (angajat.SalariuBrut - asigurareSociala - asigurareSanatate);

            //Salariu Net rezultat
            return angajat.SalariuBrut - asigurareSociala - asigurareSanatate - impozit;
        }

        // Calculează costul total suportat de angajator pentru un angajat
        public static double CalculateTotalEmployerCost(Angajat angajat)
        {
            if (angajat == null)
                return 0;

            // Costul angajatorului = salariu brut + contribuție angajator (2.25%)
            return angajat.SalariuBrut + 0.0225 * angajat.SalariuBrut;
        }
    }
}
