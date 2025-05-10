using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace miniContabil
{
    public partial class dataForm : Form
    {
        public dataForm()
        {
            InitializeComponent();
        }

        private void dataForm_Load(object sender, EventArgs e)
        {
            Firm firm = FormManager.builder.GetResult();
            labelFirma.Text = firm.GetName() + " ." + firm.GetFirmType();

            textBoxCA.Text = "" + firm.GetCA();
            textBoxCF.Text = "" + firm.GetCF();
            textBoxCC.Text = "" + firm.GetCC();
            textBoxNrAct.Text = "" + firm.GetNrAct();
            textBoxValAct.Text = "" + firm.GetValAct();
            textBoxDatorii.Text = "" + firm.GetDatorii();
        }

        private void buttonPrev2_Click(object sender, EventArgs e)
        {
            FormManager.mainForm.loadForm(new selectForm());
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            FormManager.mainForm.loadForm(new dashboardForm());
        }

        private void textBoxCA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetCA(Convert.ToUInt32(textBoxCA.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }

        private void textBoxCF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetCF(Convert.ToUInt32(textBoxCF.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }

        private void textBoxCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetCC(Convert.ToUInt32(textBoxCC.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }

        private void textBoxNrAct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetNrActiuni(Convert.ToUInt32(textBoxNrAct.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }

        private void textBoxValAct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetPretActiune(Convert.ToUInt32(textBoxValAct.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }

        private void textBoxDatorii_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetDatorii(Convert.ToUInt32(textBoxDatorii.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }
    }
}
