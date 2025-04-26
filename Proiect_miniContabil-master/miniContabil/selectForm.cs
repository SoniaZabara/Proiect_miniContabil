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
    public partial class selectForm : Form
    {
        public selectForm()
        {
            InitializeComponent();
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            FormManager.MainForm.loadForm(new dataForm());
        }
    }
}
