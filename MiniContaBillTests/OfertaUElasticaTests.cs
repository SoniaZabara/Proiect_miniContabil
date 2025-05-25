/**************************************************************************
 *                                                                        *
 *  File:        OfertaUElasticaTests.cs                                  *
 *  Copyright:   (c) 2025, Negoiță Petru                                  *
 *  E-mail:      petru.negoita@student.tuiasi.ro                          *
 *  Description: Clasă ce testează funcționalitatea exemplelor de cereri  *
 *  și oferte.                                                            *
 *  Project: miniContabil                                                 *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiniContaBill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CerereStrategy;

namespace MiniContaBill.Tests
{
    [TestClass()]
    public class OfertaUElasticaTests
    {
        /// <summary>
        /// Test pentru cerere elastică
        /// </summary>
        [TestMethod()]
        public void CerereElasticaTest()
        {
            CerereElastica cerereElastica = new CerereElastica();
            Assert.AreEqual("Cerere elastică", cerereElastica.generateExample().typeOfElasticity);
        }
        /// <summary>
        /// Test pentru cerere inelastică
        /// </summary>
        [TestMethod()]
        public void CerereInelasticaTest()
        {
            CerereInelastica cerereInelastica = new CerereInelastica();
            Assert.AreEqual("Cerere inelastică", cerereInelastica.generateExample().typeOfElasticity);
        }
        /// <summary>
        /// Test pentru bun inferior
        /// </summary>
        [TestMethod()]
        public void BunInferiorTest()
        {
            BunInferior bunInferior = new BunInferior();
            Assert.AreEqual("Bun inferior", bunInferior.generateExample().typeOfElasticity);
        }
        [TestMethod()]
        /// <summary>
        /// Test pentru bun necesar
        /// </summary>
        public void BunNecesarTest()
        {
            BunNecesar bunNecesar = new BunNecesar();
            Assert.AreEqual("Bun necesar", bunNecesar.generateExample().typeOfElasticity);
        }
        /// <summary>
        /// Test pentru bun superior
        /// </summary>
        [TestMethod()]
        public void BunSuperiorTest()
        {
            BunSuperior bunSuperior = new BunSuperior();
            Assert.AreEqual("Bun superior",bunSuperior.generateExample().typeOfElasticity);
        }

        }
}