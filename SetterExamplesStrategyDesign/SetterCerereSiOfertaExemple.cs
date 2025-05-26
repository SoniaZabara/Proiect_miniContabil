/**************************************************************************
 *                                                                        *
 *  File:        SetterCerereSiOfertaExemple.cs                           *
 *  Copyright:   (c) 2025, Negoiță Petru                                  *
 *  E-mail:      petru.negoita@student.tuiasi.ro                          *
 *  Description: Namespace ce folosește design pattern-ul Strategy pentru *
 *  a genera exemple și informații despre fiecare tip de cerere și        *
 *  ofertă                                                                *
 *  Project: miniContabil                                                 *
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

namespace CerereStrategy
{
    /// <summary>
    /// Obiectul prelucrat și afișat ce conține informațiile.
    /// </summary>
    public struct CerereValori
    {
        public string qc0;
        public string qc1;
        public string p0;
        public string p1;
        public string typeOfElasticity;
        public string explanation;

    }
    /// <summary>
    /// Interfața prin care se construiesc obiectele
    /// </summary>
    public interface ICerereStrategy
    {
        CerereValori generateExample();
    }
    /// <summary>
    /// Clase cu elasticitatea cererii dupa pret...
    /// </summary>
    public class CerereUElastica : ICerereStrategy
    {
        public CerereValori generateExample()
        {
            CerereValori e = new CerereValori();
            e.typeOfElasticity = "Cerere unitar elastică";
            e.explanation = "Procentul de modificare al cantității cerute este egal " +
                "(ca valoare absolută) cu procentul de modificare al prețului.\n" +
                "Dar semnele sunt opuse: când prețul scade cu 10%, cererea crește cu 10%.\n" +
                "După formula Ecp = ((Qc1 – Qc0)/Qc0) / ((P1 – P0)/P0) rezultă Ecp = 0.10 / (-0.10) = -1.";
            e.qc0 = "100";
            e.qc1 = "110";
            e.p0 = "10";
            e.p1 = "9";
            return e;

        }
    }
    public class CerereRigida : ICerereStrategy
    {
        public CerereValori generateExample()
        {
            CerereValori e = new CerereValori();
            e.typeOfElasticity = "Cerere rigidă";
            e.explanation = "Indiferent de modificarea prețului, cantitatea cerută rămâne aceeași.\n" +
                "Consumatorii nu pot renunța deloc la produs.\n" +
                "După formula Ecp = ((Qc1 – Qc0)/Qc0) / ((P1 – P0)/P0) rezultă Ecp = 0.0 / (-0.2) = 0.";
            e.qc0 = "100";
            e.qc1 = "100";
            e.p0 = "10";
            e.p1 = "8";
            return e;
        }
    }
    public class CerereElastica : ICerereStrategy
    {
        public CerereValori generateExample()
        {
            CerereValori e = new CerereValori();
            e.typeOfElasticity = "Cerere elastică";
            e.explanation = "Cantitatea cerută variază mai mult procentual decât prețul.\n" +
                "Consumatorii reacționează puternic la schimbările de preț.\n" +
                "După formula Ecp = ((Qc1 – Qc0)/Qc0) / ((P1 – P0)/P0) rezultă Ecp = 0.4 / (-0.1) = -4.";
            e.qc0 = "100";
            e.qc1 = "140";
            e.p0 = "10";
            e.p1 = "9";
            return e;
        }
    }
    public class CerereInelastica : ICerereStrategy
    {
        public CerereValori generateExample()
        {
            CerereValori e = new CerereValori();
            e.typeOfElasticity = "Cerere inelastică";
            e.explanation = "Cantitatea cerută variază mai puțin procentual decât prețul.\n" +
                "onsumatorii nu reacționează foarte puternic la schimbări de preț.\n" +
                "După formula Ecp = ((Qc1 – Qc0)/Qc0) / ((P1 – P0)/P0) rezultă Ecp = 0.05 / (-0.1) = -0.5.";
            e.qc0 = "100";
            e.qc1 = "105";
            e.p0 = "10";
            e.p1 = "9";
            return e;
        }
    }
    /// <summary>
    /// Clase cu elasticitatea cererii dupa venit...
    /// </summary>
    public class BunInferior : ICerereStrategy
    {
        public CerereValori generateExample()
        {
            CerereValori e = new CerereValori();
            e.typeOfElasticity = "Bun inferior";
            e.explanation = "Când venitul crește, oamenii renunță la acest bun și preferă alternative mai bune.\n" +
                "După formula Ecp = ((Qc1 – Qc0)/Qc0) / ((V1 – V0)/V0) rezultă Ecp = (-0.2) / 0.2 = -1.";
            e.qc0 = "100";
            e.qc1 = "80";
            e.p0 = "1000";
            e.p1 = "1200";
            return e;
        }
    }
    public class BunNecesar : ICerereStrategy
    {
        public CerereValori generateExample()
        {
            CerereValori e = new CerereValori();
            e.typeOfElasticity = "Bun necesar";
            e.explanation = "Odată cu creșterea venitului, cererea crește, dar nu în același ritm.\n" +
                "Sunt bunuri care nu se consumă nelimitat de individ, indiferent de cât câștigă.\n" +
                "După formula Ecp = ((Qc1 – Qc0)/Qc0) / ((V1 – V0)/V0) rezultă Ecp = 0.1 / 0.2 = 0.5.";
            e.qc0 = "100";
            e.qc1 = "110";
            e.p0 = "1000";
            e.p1 = "1200";
            return e;
        }
    }
    public class BunSuperior : ICerereStrategy
    {
        public CerereValori generateExample()
        {
            CerereValori e = new CerereValori();
            e.typeOfElasticity = "Bun superior";
            e.explanation = "Oamenii cumpără mult mai mult când au venituri mai mari.\n" +
                "Cererea e foarte sensibilă la schimbările în venit.\n" +
                "După formula Ecp = ((Qc1 – Qc0)/Qc0) / ((V1 – V0)/V0) rezultă Ecp = 0.5 / 0.2 = 2.5";
            e.qc0 = "100";
            e.qc1 = "150";
            e.p0 = "1000";
            e.p1 = "1200";
            return e;
        }
    }
    /// <summary>
    /// Clase cu elasticitatea ofertei...
    /// </summary>
    public class OfertaElastica : ICerereStrategy
    {
        public CerereValori generateExample()
        {
            CerereValori e = new CerereValori();
            e.typeOfElasticity = "Ofertă elastică";
            e.explanation = "Cantitatea oferită crește mai mult procentual decât crește prețul.\n" +
                "După formula Eop = ((Qo1 – Qo0)/Qo0) / ((P1 – P0)/P0) rezultă Eop = 0.40 / 0.10 = 4.";
            e.qc0 = "100";
            e.qc1 = "140";
            e.p0 = "10";
            e.p1 = "11";
            return e;
        }
    }
    public class OfertaInelastica : ICerereStrategy
    {
        public CerereValori generateExample()
        {
            CerereValori e = new CerereValori();
            e.typeOfElasticity = "Ofertă inelastică";
            e.explanation = "Cantitatea oferită crește, dar mai puțin proporțional decât crește prețul.\n" +
                "După formula Eop = ((Qo1 – Qo0)/Qo0) / ((P1 – P0)/P0) rezultă Eop = 0.1 / 0.2 = 5.";
            e.qc0 = "100";
            e.qc1 = "110";
            e.p0 = "10";
            e.p1 = "12";
            return e;
        }
    }
    public class OfertaPInelastica : ICerereStrategy
    {
        public CerereValori generateExample()
        {
            CerereValori e = new CerereValori();
            e.typeOfElasticity = "Ofertă perfect inelastică";
            e.explanation = "Cantitatea oferită rămâne constantă indiferent de modificările prețului.\n" +
                "După formula Eop = ((Qo1 – Qo0)/Qo0) / ((P1 – P0)/P0) rezultă Eop = 0.";
            e.qc0 = "100";
            e.qc1 = "100";
            e.p0 = "10";
            e.p1 = "15";
            return e;
        }
    }
    public class OfertaUElastica : ICerereStrategy
    {
        public CerereValori generateExample()
        {
            CerereValori e = new CerereValori();
            e.typeOfElasticity = "Ofertă unitar elastică";
            e.explanation = "Procentul de modificare a ofertei este egal (ca valoare absolută) cu procentul de modificare al prețului.\n" +
                "După formula Eop = ((Qo1 – Qo0)/Qo0) / ((P1 – P0)/P0) rezultă Eop = 0.1 / 0.1 = 1.";
            e.qc0 = "100";
            e.qc1 = "100";
            e.p0 = "10";
            e.p1 = "11";
            return e;
        }
    }
}