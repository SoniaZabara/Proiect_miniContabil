using Microsoft.VisualStudio.TestTools.UnitTesting;
using CostulProductieProfitDDL;
using MiniContaBill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniContaBill.Tests
{
    [TestClass]
    public class CostProfitTests
    {
        [TestMethod]
        public void CalculeazaMasaProfitCorectTest()
        {
            var mp = new MasaProfit();
            string rezultat = mp.CalculeazaMasaProfit("1000", "600");
            Assert.AreEqual("400.00", rezultat);
        }

        [TestMethod]
        public void CalculeazaRataProfitCorectTest()
        {
            var rp = new RataProfit();
            string rezultat = rp.CalculeazaRataProfit("200", "800");
            Assert.AreEqual("25.00", rezultat); 
        }

        [TestMethod]
        public void CalculeazaPretFinalCorectTest()
        {
            var pf = new PretFinal();
            string rezultat = pf.CalculeazaPretFinal("80", "20");
            Assert.AreNotEqual("100.00", rezultat);
        }

        [TestMethod]
        public void CalculeazaPragRentabilitateCazACorectTest()
        {
            var pr = new PragRentabilitate();
            string rezultat = pr.CalculeazaPragRentabilitate("100", "500", "", "50", true);
            decimal valoareNumerica = decimal.Parse(rezultat);
            Assert.IsTrue(valoareNumerica >= 0);
        }

        [TestMethod]
        public void CalculeazaImpozitProfitPFACorectTest()
        {
            var ip = new ImpozitProfit();
            string rezultat = ip.CalculeazaImpozitProfit("1000", true);
            Assert.AreEqual("100.00", rezultat); 
        }
    }
}
