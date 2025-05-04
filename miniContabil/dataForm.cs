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
    public partial class dataForm : Form
    {
        public dataForm()
        {
            InitializeComponent();
        }

        private void dataForm_Load(object sender, EventArgs e)
        {
            Firm firm = FormManager.builder.GetResult();
            labelFirma.Text = firm.GetName() + "." + firm.type;
        }

        private void buttonPrev2_Click(object sender, EventArgs e)
        {
            FormManager.mainForm.loadForm(new selectForm());
        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            FormManager.mainForm.loadForm(new dashboardForm());
        }

    }
}
