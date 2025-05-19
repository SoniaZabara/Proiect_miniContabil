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
            DezactiveazaControalele();
            DoarReadOnly();
            this.AutoScroll = true;
        }

        private void DezactiveazaControalele()
        {
            textBoxPretUnitateProdus.Enabled = false;
            textBoxCostFix.Enabled = false;
            textBoxCostVariabileMedii.Enabled = false;
            buttonCalculeazaPregdeRentabilitate.Enabled = false;
            textBoxProfit1.Enabled = false;
            textBoxCantitate.Enabled = false;
            textBoxProfit2.Enabled = false;
            buttonCalculeazaImpozitProfit.Enabled = false;
            textBoxImpozitProfit.Enabled = false;

            if(FormManager.builder.GetResult().GetFirmType()==FirmType.PFA)
            {
                radioButtonCuPFA.Checked = true;
                radioButtonFaraPFA.Enabled = false;
            }
            else
            {
                radioButtonFaraPFA.Checked = true;
                radioButtonCuPFA.Enabled = false;
            }
        }

        private void DoarReadOnly()
        {
            textBoxMasaProfit1.ReadOnly = true;
            textBoxRataProfit.ReadOnly = true;
            textBoxCT.ReadOnly = true;
            textBoxCostMediu.ReadOnly = true;
            textBoxPretFinal.ReadOnly = true;
            textBoxCantitate.ReadOnly = true;
            textBoxImpozitProfit.ReadOnly = true;
            textBoxPretTVA.ReadOnly = true;
        }

        private void groupBoxPragulRentabilitate_Click(object sender, EventArgs e)
        {
          
        }

        private void labelRataProfit_Click(object sender, EventArgs e)
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

        private void buttonCalculeazaRataProfit_Click(object sender, EventArgs e)
        {
            try
            {
                var calculator = new RataProfit();
                string rezultat = calculator.CalculeazaRataProfit(textBoxMasaProfit2.Text, textBoxCosturiCa2.Text);
                textBoxRataProfit.Text = rezultat;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la calcul: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRataProfit.Text = "0";
            }
        }

        private void buttonCalculeazaPretFinal_Click(object sender, EventArgs e)
        {         
            try
            {
                var calculator = new PretFinal();
                string rezultatCt = calculator.CalculeazaCostTotal(textBoxAmortizare.Text, textBoxMateriiPrime.Text, textBoxSalarii.Text, textBoxMaterialeAuxiliare.Text, textBoxChiria.Text);
                textBoxCT.Text = rezultatCt;

                string rezultatCm = calculator.CalculeazaCostMediu(textBoxCT.Text, textBoxNrUnitatiProduse.Text);
                textBoxCostMediu.Text = rezultatCm;

                string rezultatPf = calculator.CalculeazaPretFinal(textBoxCostMediu.Text, textBoxProfitMediu.Text);
                textBoxPretFinal.Text = rezultatPf;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la calcul: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCT.Text = "0";
                textBoxCostMediu.Text = "0";
                textBoxPretFinal.Text = "0";
            }
        }

        private void radioButtonRentabilitateCazA_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPretUnitateProdus.Enabled = true;
            textBoxCostFix.Enabled = true;
            textBoxCostVariabileMedii.Enabled = true;
            buttonCalculeazaPregdeRentabilitate.Enabled = true;
            textBoxCantitate.Enabled = true;
            textBoxProfit1.Enabled = false;
            textBoxProfit1.Clear();
            textBoxPretUnitateProdus.Clear();
            textBoxCostFix.Clear();
            textBoxCostVariabileMedii.Clear();
            textBoxCantitate.Clear();
        }

        private void radioButtonRentabilitateCazB_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPretUnitateProdus.Enabled = true;
            textBoxCostFix.Enabled = true;
            textBoxCostVariabileMedii.Enabled = true;
            buttonCalculeazaPregdeRentabilitate.Enabled = true;
            textBoxCantitate.Enabled = true;
            textBoxProfit1.Enabled = true;
            textBoxPretUnitateProdus.Clear();
            textBoxCostFix.Clear();
            textBoxCostVariabileMedii.Clear();
            textBoxCantitate.Clear();
        }

        private void buttonCalculeazaPregdeRentabilitate_Click(object sender, EventArgs e)
        {
            try
            {
                var calculator = new PragRentabilitate();
                string rezultat = calculator.CalculeazaPragRentabilitate(textBoxPretUnitateProdus.Text, textBoxCostFix.Text, textBoxProfit1.Text, textBoxCostVariabileMedii.Text, radioButtonRentabilitateCazA.Checked);
                textBoxCantitate.Text = rezultat;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la calcul: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCantitate.Text = "0";
            }
        }

        private void radioButtonCuPFA_CheckedChanged(object sender, EventArgs e)
        {
            textBoxProfit2.Enabled = true;
            buttonCalculeazaImpozitProfit.Enabled = true;
            textBoxImpozitProfit.Enabled = true;
            textBoxProfit2.Clear();
            textBoxImpozitProfit.Clear();
        }

        private void radioButtonFaraPFA_CheckedChanged(object sender, EventArgs e)
        {
            textBoxProfit2.Enabled = true;
            buttonCalculeazaImpozitProfit.Enabled = true;
            textBoxImpozitProfit.Enabled = true;
            textBoxProfit2.Clear();
            textBoxImpozitProfit.Clear();
        }

        private void buttonCalculeazaImpozitProfit_Click(object sender, EventArgs e)
        {
            try
            {
                var calculator = new ImpozitProfit();
                string rezultat = calculator.CalculeazaImpozitProfit(textBoxProfit2.Text, radioButtonCuPFA.Checked);
                textBoxImpozitProfit.Text = rezultat;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la calcul: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxImpozitProfit.Text = "0";
            }
        }

        private void buttonCalculeazaTVA_Click(object sender, EventArgs e)
        {
            try
            {
                var calculator = new PretTva();
                string rezultat = calculator.CalculeazaPretCuTva(textBoxPretBrut.Text, textBoxCotaTVA.Text);
                textBoxPretTVA.Text = rezultat;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la calcul: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPretTVA.Text = "0";
            }
        }
    }
}
