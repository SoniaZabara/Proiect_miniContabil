using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace FirmUtil
{
    public enum FirmType
    {
        SRL,
        PFA,
        SA
    }

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

        public string GetName() { return name; }
        public FirmType GetFirmType() { return type; }
        public uint GetCA() { return ca; }
        public uint GetCF() { return cf; }
        public uint GetCC() { return cc; }
        public uint GetNrAct() { return nrActiuni; }
        public uint GetValAct() { return pretActiune; }
        public uint GetDatorii() { return datorii; }
    }

    public interface IFirmBuilder
    {
        void SetName(string name);
        void SetCA(uint ca);
        void SetCF(uint cf);
        void SetCC(uint cc);
        void SetNrActiuni(uint nrActiuni);
        void SetPretActiune(uint pretActiune);
        void SetDatorii(uint datorii);
        Firm GetResult();
    }

    public class SRLBuilder : IFirmBuilder
    {
        public Firm firm = new Firm();
        public void SetName(string name) => firm.name = name;
        public void SetCA(uint ca) => firm.ca = ca;
        public void SetCF(uint cf) => firm.cf = cf;
        public void SetCC(uint cc) => firm.cc = cc;
        public void SetNrActiuni(uint nrActiuni) => firm.nrActiuni = nrActiuni;
        public void SetPretActiune(uint pretActiune) => firm.pretActiune = pretActiune;
        public void SetDatorii(uint datorii) => firm.datorii = datorii;

        public Firm GetResult()
        {
            firm.type = FirmType.SRL;
            return firm;
        }
    }

    public class SABuilder : IFirmBuilder
    {
        public Firm firm = new Firm();
        public void SetName(string name) => firm.name = name;
        public void SetCA(uint ca) => firm.ca = ca;
        public void SetCF(uint cf) => firm.cf = cf;
        public void SetCC(uint cc) => firm.cc = cc;
        public void SetNrActiuni(uint nrActiuni) => firm.nrActiuni = nrActiuni;
        public void SetPretActiune(uint pretActiune) => firm.pretActiune = pretActiune;
        public void SetDatorii(uint datorii) => firm.datorii = datorii;

        public Firm GetResult()
        {
            firm.type = FirmType.SA;
            return firm;
        }
    }

    public class PFABuilder : IFirmBuilder
    {
        public Firm firm = new Firm();
        public void SetName(string name) => firm.name = name;
        public void SetCA(uint ca) => firm.ca = ca;
        public void SetCF(uint cf) => firm.cf = cf;
        public void SetCC(uint cc) => firm.cc = cc;
        public void SetNrActiuni(uint nrActiuni) => firm.nrActiuni = 0;
        public void SetPretActiune(uint pretActiune) => firm.pretActiune = 0;
        public void SetDatorii(uint datorii) => firm.datorii = datorii;
        public Firm GetResult()
        {
            firm.type = FirmType.PFA;
            return firm;
        }

    }
}
