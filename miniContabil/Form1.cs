using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniContabil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormManager.mainForm = this;
        }

        public void loadForm(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
                mainpanel.Controls.Clear();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            loadForm(new selectForm());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("miniContabilHelp.chm");
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public static class FormManager
    {
        public static Form1 mainForm { get; set; }
        public static IFirmBuilder builder;
    }

    public enum FirmType
    {
        SRL,
        PFA,
        SA
    }

    public class Firm
    {
        public string name;
        public FirmType type;
        uint ca;
        uint cf;
        uint cc;
        uint nrActiuni;
        uint pretActiune;
        uint datorii;

        public string GetName(){return name;}
    }

    public interface IFirmBuilder
    {
        void SetName(string name);
        Firm GetResult();
    }

    public class SRLBuilder : IFirmBuilder
    {
        public Firm firm = new Firm();
        public void SetName(string name) => firm.name = name;

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
        FirmType type = FirmType.PFA;
        public Firm GetResult()
        {
            firm.type = FirmType.PFA;
            return firm;
        }

    }
}
