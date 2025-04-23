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
            FormManager.MainForm = this;
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
    }

    public static class FormManager
    {
        public static Form1 MainForm { get; set; }
    }

}
