using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalariiAngajati;
using System.Collections.Generic;
namespace MiniContaBillTests
{
    [TestClass]
    public class SalaryCalculatorTests
    {
        private List<Angajat> _angajati;

        [TestInitialize]
        public void Setup()
        {
            _angajati = new List<Angajat>
            {
                new Angajat(1, "Ion Popescu", "Inginer", 5000, "Productie"),
                new Angajat(2, "Maria Ionescu", "Contabil", 4500, "Financiar"),
                new Angajat(3, "Ana Georgescu", "Manager", 7000, "Management")
            };
        }

        [TestMethod]
        public void Test_CalculateAverageSalary_ReturnsCorrectAverage()
        {
            double expected = (5000 + 4500 + 7000) / 3.0;
            double actual = SalaryCalculator.CalculateAverageSalary(_angajati);
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void Test_CalculateTotalSalary_ReturnsCorrectSum()
        {
            double expected = 5000 + 4500 + 7000;
            double actual = SalaryCalculator.CalculateTotalSalary(_angajati);
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void Test_CalculateNetSalary_ReturnsCorrectNet()
        {
            var angajat = new Angajat(1, "Ion Popescu", "Inginer", 5000, "Productie");

            // CAS = 25%, CASS = 10%, impozit = 10% din (5000 - CAS - CASS)
            double cas = 0.25 * 5000;
            double cass = 0.10 * 5000;
            double impozit = 0.10 * (5000 - cas - cass);
            double expected = 5000 - cas - cass - impozit;

            double actual = SalaryCalculator.CalculateNetSalary(angajat);
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void Test_CalculateTotalEmployerCost_ReturnsCorrectCost()
        {
            var angajat = new Angajat(1, "Ion Popescu", "Inginer", 5000, "Productie");

            double expected = 5000 + 0.0225 * 5000;
            double actual = SalaryCalculator.CalculateTotalEmployerCost(angajat);

            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void Test_CalculateAverageSalary_WithEmptyList_ReturnsZero()
        {
            var listaGoala = new List<Angajat>();
            double actual = SalaryCalculator.CalculateAverageSalary(listaGoala);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_CalculateNetSalary_WithNull_ReturnsZero()
        {
            double actual = SalaryCalculator.CalculateNetSalary(null);
            Assert.AreEqual(0, actual);
        }
    }
}
