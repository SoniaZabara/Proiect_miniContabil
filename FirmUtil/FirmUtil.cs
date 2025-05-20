/**************************************************************************
 *                                                                        *
 *  File:        FirmUtil.cs                                              *
 *  Copyright:   (c) 2025, Sonia Zabara                                   *
 *  E-mail:      sonia.zabara@student.tuiasi.ro                           *
 *  Description: Namespace which has useful classes, interfaces and       *
 *               enums for building and managing an object with the       *
 *               atributes a firm should have.                            *
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace FirmUtil
{
    /// <summary>
    /// Enum pentru tipurile de firmă ce pot fii alese
    /// </summary>
    public enum FirmType
    {
        SRL,
        PFA,
        SA
    }

    /// <summary>
    /// Clasă pentru construirea unui obiect ce are atributele unei firme
    /// </summary>
    public class Firm
    {
        public string name = "";
        public FirmType type;
        public uint ca = 0;
        public uint cf = 0;
        public uint cc = 0;
        public uint nrActiuni = 0;
        public uint pretActiune = 0;
        public uint datorii = 0;

        /// <summary>
        /// Metodă ce returnează numele firmei
        /// </summary>
        /// <returns>Numele firmei</returns>
        public string GetName() { return name; }

        /// <summary>
        /// Metodă ce returnează tipul firmei
        /// </summary>
        /// <returns>Tipul firmei</returns>
        public FirmType GetFirmType() { return type; }

        /// <summary>
        /// Metodă ce returnează cifra de afaceri
        /// </summary>
        /// <returns>valoarea cifrei de afaceri</returns>
        public uint GetCA() { return ca; }

        /// <summary>
        /// Metodă ce returnează capitaluilui fix
        /// </summary>
        /// <returns>Valoarea capitalului fix</returns>
        public uint GetCF() { return cf; }

        /// <summary>
        /// Metodă ce returnează capitalul circulant
        /// </summary>
        /// <returns>Valoarea capitalului circulant</returns>
        public uint GetCC() { return cc; }

        /// <summary>
        /// Metodă ce returnează numărul de acțiuni
        /// </summary>
        /// <returns>Numărul de acțiuni</returns>
        public uint GetNrAct() { return nrActiuni; }

        /// <summary>
        /// Metodă ce returnează o acțiune
        /// </summary>
        /// <returns>Valoarea unei acțiuni</returns>
        public uint GetValAct() { return pretActiune; }

        /// <summary>
        /// Metodă ce returnează datoriile
        /// </summary>
        /// <returns>Valoarea datoriilor</returns>
        public uint GetDatorii() { return datorii; }
    }

    /// <summary>
    /// Interfață pentru un builder al unui obiect tip Firm
    /// </summary>
    public interface IFirmBuilder
    {
        /// <summary>
        /// Metodă ce setează numele firmei
        /// </summary>
        /// <param name="name">Numele firmei</param>
        void SetName(string name);

        /// <summary>
        /// Metodă ce setează cifra de afaceri
        /// </summary>
        /// <param name="ca">valoarea cifrei de afaceri</param>
        void SetCA(uint ca);

        /// <summary>
        /// Metodă ce setează capitalul fix
        /// </summary>
        /// <param name="cf">Valoarea capitalului fix</param>
        void SetCF(uint cf);

        /// <summary>
        /// Medotă ce setează capitalul circulant
        /// </summary>
        /// <param name="cc">Valoarea capitalului circulant</param>
        void SetCC(uint cc);

        /// <summary>
        /// Metodă ce setează număr de acțiuni din care e compus firma
        /// </summary>
        /// <param name="nrActiuni">Numărul de acțiuni</param>
        void SetNrActiuni(uint nrActiuni);

        /// <summary>
        /// Metodă ce setează prețul unei acțiuni
        /// </summary>
        /// <param name="pretActiune">Valoarea unei acțiuni</param>
        void SetPretActiune(uint pretActiune);

        /// <summary>
        /// Metodă ce setează datoriile firmei
        /// </summary>
        /// <param name="datorii">Valoarea pe care firma o datorează</param>
        void SetDatorii(uint datorii);

        /// <summary>
        /// Metodă ce returnează obiectul Firm construit 
        /// </summary>
        /// <returns>Obiectul Firm</returns>
        Firm GetResult();
    }

    /// <summary>
    /// Builder pentru un obiect Firm de tip SRL
    /// </summary>
    public class SRLBuilder : IFirmBuilder
    {
        public Firm firm = new Firm();

        /// <inheritdoc/>
        public void SetName(string name) => firm.name = name;

        /// <inheritdoc/>
        public void SetCA(uint ca) => firm.ca = ca;

        /// <inheritdoc/>
        public void SetCF(uint cf) => firm.cf = cf;

        /// <inheritdoc/>
        public void SetCC(uint cc) => firm.cc = cc;

        /// <summary>
        /// Metodă ce setează cu 0 numărul de acțiuni
        /// </summary>
        /// <param name="nrActiuni">Numărul de acțiuni</param>
        public void SetNrActiuni(uint nrActiuni) => firm.nrActiuni = 0;

        /// <summary>
        /// Metodă ce setează cu 0 prețul unei acțiuni
        /// </summary>
        /// <param name="nrActiuni">Valoarea unei acțiuni</param>
        public void SetPretActiune(uint pretActiune) => firm.pretActiune = 0;

        /// <inheritdoc/>
        public void SetDatorii(uint datorii) => firm.datorii = datorii;

        /// <inheritdoc/>
        public Firm GetResult()
        {
            firm.type = FirmType.SRL;
            return firm;
        }
    }

    /// <summary>
    /// Builder pentru un obiect Firm de tip SA
    /// </summary>
    public class SABuilder : IFirmBuilder
    {
        public Firm firm = new Firm();

        /// <inheritdoc/>
        public void SetName(string name) => firm.name = name;

        /// <inheritdoc/>
        public void SetCA(uint ca) => firm.ca = ca;

        /// <inheritdoc/>
        public void SetCF(uint cf) => firm.cf = cf;

        /// <inheritdoc/>
        public void SetCC(uint cc) => firm.cc = cc;

        /// <inheritdoc/>
        public void SetNrActiuni(uint nrActiuni) => firm.nrActiuni = nrActiuni;

        /// <inheritdoc/>
        public void SetPretActiune(uint pretActiune) => firm.pretActiune = pretActiune;

        /// <inheritdoc/>
        public void SetDatorii(uint datorii) => firm.datorii = datorii;

        /// <inheritdoc/>
        public Firm GetResult()
        {
            firm.type = FirmType.SA;
            return firm;
        }
    }

    /// <summary>
    /// Builder pentru un obiect Firm de tip PFA
    /// </summary>
    public class PFABuilder : IFirmBuilder
    {
        public Firm firm = new Firm();

        /// <inheritdoc/>
        public void SetName(string name) => firm.name = name;

        /// <inheritdoc/>
        public void SetCA(uint ca) => firm.ca = ca;

        /// <inheritdoc/>
        public void SetCF(uint cf) => firm.cf = cf;

        /// <inheritdoc/>
        public void SetCC(uint cc) => firm.cc = cc;

        /// <summary>
        /// Metodă ce setează cu 0 numărul de acțiuni
        /// </summary>
        /// <param name="nrActiuni">Numărul de acțiuni</param>
        public void SetNrActiuni(uint nrActiuni) => firm.nrActiuni = 0;

        /// <summary>
        /// Metodă ce setează cu 0 prețul unei acțiuni
        /// </summary>
        /// <param name="nrActiuni">Valoarea unei acțiuni</param>
        public void SetPretActiune(uint pretActiune) => firm.pretActiune = 0;

        /// <inheritdoc/>
        public void SetDatorii(uint datorii) => firm.datorii = datorii;

        /// <inheritdoc/>
        public Firm GetResult()
        {
            firm.type = FirmType.PFA;
            return firm;
        }

    }
}
