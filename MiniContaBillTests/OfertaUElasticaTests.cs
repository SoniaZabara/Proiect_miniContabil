using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniContaBill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniContaBill.Tests
{
    [TestClass()]
    public class OfertaUElasticaTests
    {
        [TestMethod()]
        public void CerereElasticaTest()
        {
            CerereElastica cerereElastica = new CerereElastica();
            Assert.AreEqual("Cerere elastică", cerereElastica.generateExample().typeOfElasticity);
        }
        [TestMethod()]
        public void CerereInelasticaTest()
        {
            CerereInelastica cerereInelastica = new CerereInelastica();
            Assert.AreEqual("Cerere inelastică", cerereInelastica.generateExample().typeOfElasticity);
        }
        [TestMethod()]
        public void BunInferiorTest()
        {
            BunInferior bunInferior = new BunInferior();
            Assert.AreEqual("Bun inferior", bunInferior.generateExample().typeOfElasticity);
        }
        [TestMethod()]
        public void BunNecesarTest()
        {
            BunNecesar bunNecesar = new BunNecesar();
            Assert.AreEqual("Bun necesar", bunNecesar.generateExample().typeOfElasticity);
        }
        [TestMethod()]
        public void BunSuperiorTest()
        {
            BunSuperior bunSuperior = new BunSuperior();
            Assert.AreEqual("Bun superior",bunSuperior.generateExample().typeOfElasticity);
        }

        }
}