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
    public partial class dashboardForm : Form
    {
        public dashboardForm()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.dashboardMainpanel.Controls.Count > 0)
                this.dashboardMainpanel.Controls.Clear();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.dashboardMainpanel.Controls.Add(f);
            this.dashboardMainpanel.Tag = f;
            f.Show();
        }

        private void buttonPrev3_Click(object sender, EventArgs e)
        {
            FormManager.MainForm.loadForm(new dataForm());
        }

        private void buttonTab1_Click(object sender, EventArgs e)
        {
            loadForm(new tab1Form());
        }

        private void buttonTab2_Click(object sender, EventArgs e)
        {
            loadForm(new tab2Form());
        }

        private void buttonTab3_Click(object sender, EventArgs e)
        {
            loadForm(new tab3Form());
        }

        private void dashboardMainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm(new tabSalariiForm());
        }
    }
}
