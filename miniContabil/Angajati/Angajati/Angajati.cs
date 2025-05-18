using System.Collections.Generic;
using System.Linq;

namespace SalariiAngajati
{
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

    public static class SalaryCalculator
    {
        public static double CalculateAverageSalary(IEnumerable<Angajat> angajati)
        {
            if (angajati == null || !angajati.Any())
                return 0;
            return angajati.Average(a => a.SalariuBrut);
        }

        public static double CalculateTotalSalary(IEnumerable<Angajat> angajati)
        {
            if (angajati == null)
                return 0;
            return angajati.Sum(a => a.SalariuBrut);
        }

        public static double CalculateNetSalary(Angajat angajat)
        {
            if (angajat == null)
                return 0;
            double asigurareSociala = 0.25 * angajat.SalariuBrut;
            double asigurareSanatate = 0.10 * angajat.SalariuBrut;
            double impozit = 0.10 * (angajat.SalariuBrut - asigurareSociala - asigurareSanatate);
            return angajat.SalariuBrut - asigurareSociala - asigurareSanatate - impozit;
        }

        public static double CalculateTotalEmployerCost(Angajat angajat)
        {
            if (angajat == null)
                return 0;
            return angajat.SalariuBrut + 0.0225 * angajat.SalariuBrut;
        }
    }
}
