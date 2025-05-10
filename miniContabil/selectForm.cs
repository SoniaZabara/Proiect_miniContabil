using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            if (FormManager.builder == null || bigTextBox1.Text == "")
            {
                MessageBox.Show("Va rugam completati campurile", "!!ATENTIE!!");
            }
            else
            {
                FormManager.mainForm.loadForm(new dataForm());
            }
        }

        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(FormManager.builder != null)
                FormManager.builder.SetName(bigTextBox1.Text);
        }

        private void poisonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(poisonComboBox1.SelectedIndex == 0) //"Societate cu Răspundere Limitată"
            {
                FormManager.builder = new SRLBuilder(); 
            }
            else if (poisonComboBox1.SelectedIndex == 1) //"Persoană Fizica Autorizată"
            {
                FormManager.builder = new PFABuilder();
            }
            else if (poisonComboBox1.SelectedIndex == 2) //"Societate pe acțiuni"
            {
                FormManager.builder = new SABuilder();
            }

            if (poisonComboBox1.SelectedIndex != -1 && FormManager.builder != null)
                FormManager.builder.SetName(bigTextBox1.Text);
        }

        private void selectForm_Load(object sender, EventArgs e)
        {
            if (FormManager.builder == null)
            {
                bigTextBox1.Text = "Bilibic";
                poisonComboBox1.SelectedIndex = 0;
            }
            else
            {
                bigTextBox1.Text = FormManager.builder.GetResult().GetName();
                poisonComboBox1.SelectedIndex = (int)FormManager.builder.GetResult().GetFirmType();
            }
        }
    }
}
