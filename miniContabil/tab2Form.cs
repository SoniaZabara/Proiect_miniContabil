using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CostulProductieProfitDDL;

namespace miniContabil
{
    public partial class tab2Form : Form
    {
        public tab2Form()
        {
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void labelRataProfit_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxPragulRentabilitate_Click(object sender, EventArgs e)
        {

        }

        private void labelCantitate_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCantitate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tab2Form_Load(object sender, EventArgs e)
        {

        }

        private void buttonCalculeazaMasaProfit_Click(object sender, EventArgs e)
        {
            try
            {
                var calculator = new MasaProfit();
                string rezultat = calculator.CalculeazaMasaProfit(textBoxPretVanzare.Text, textBoxCosturi1.Text);
                textBoxMasaProfit1.Text = rezultat;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Eroare la calcul: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxMasaProfit1.Text = "0";
            }
        }
    }
}
