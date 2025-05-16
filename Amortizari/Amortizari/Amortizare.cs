using System;
using System.Collections.Generic;

namespace Amortizari
{
    public class Amortizare
    {
        public int An { get; set; }
        public double AmortizareAnuala { get; set; }
        public double ValoareRamasa { get; set; }
    }

    public static class AmortizareCalculator
    {
        public static List<Amortizare> Liniara(double initialValue, int lifeTime, double rezidualValue)
        {
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

        public static List<Amortizare> Progresiva(double initialValue, int lifeTime, double rezidualValue)
        {
            var amortizari = new List<Amortizare>();
            double bazaAmortizabila = initialValue - rezidualValue;
            int sumaPonderi = (lifeTime * (lifeTime + 1)) / 2;
            double valoareRamasa = initialValue;
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

        public static List<Amortizare> Degresiva(double initialValue, int lifeTime, double rezidualValue)
        {
            var amortizari = new List<Amortizare>();
            double rataDegresiva = 2.0 / lifeTime;
            double valoareRamasa = initialValue;
            for (int an = 1; an <= lifeTime; an++)
            {
                double amortizareAnuala = valoareRamasa * rataDegresiva;
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
