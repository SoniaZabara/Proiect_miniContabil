/**************************************************************************
 *                                                                        *
 *  File:        FirmTests.cs                                             *
 *  Copyright:   (c) 2025, Sonia Zabara                                   *
 *  E-mail:      sonia.zabara@student.tuiasi.ro                           *
 *  Description: Tests for the FirmUtil DLL                               *
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
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FirmUtil;
using CerereStrategy;

namespace MiniContaBill.Tests
{
    [TestClass]
    public class FirmTests
    {
        /// <summary>
        /// Testează dacă firma returnează tipul societății potrivit
        /// </summary>
        [TestMethod]
        public void TestGetFirmType()
        {
            IFirmBuilder firm = new SRLBuilder();
            Assert.AreEqual(FirmType.SRL, firm.GetResult().GetFirmType());
        }

        /// <summary>
        /// Testează dacă firma returnează tipul societății potrivit contra unui alt tip de societate
        /// </summary>
        [TestMethod]
        public void TestGetFirmType2()
        {
            IFirmBuilder firm = new PFABuilder();
            Assert.AreNotEqual(FirmType.SRL, firm.GetResult().GetFirmType());
        }

        /// <summary>
        /// Testează dacă firma returnează aceeasi valoare a cifrei de afaceri cu cea setată
        /// </summary>
        [TestMethod]
        public void TestGetCA()
        {
            IFirmBuilder firm = new SRLBuilder();
            firm.SetCA(1000);
            Assert.AreEqual((uint)1000, firm.GetResult().GetCA());
        }

        /// <summary>
        /// Testează dacă firma returnează același nume cu cel setat
        /// </summary>
        [TestMethod]
        public void TestGetName()
        {
            IFirmBuilder firm = new SRLBuilder();
            firm.SetName("Bilibic");
            Assert.AreEqual("Bilibic", firm.GetResult().GetName());
        }

        /// <summary>
        /// Testează dacă o o firmă de tip PFA care nu poate să aibă acțiuni i se pot atribuii acțiuni
        /// </summary>
        [TestMethod]
        public void TestPFABuilder()
        {
            IFirmBuilder firm = new PFABuilder();
            firm.SetNrActiuni(100);
            Assert.AreEqual((uint)0, firm.GetResult().GetNrAct());
        }

    }
}
