/**************************************************************************
 *                                                                        *
 *  File:        tab1Form.cs                                              *
 *  Copyright:   (c) 2025, Bran Ioana -Andreea                            *
 *  E-mail:      ioana-andreea.bran@student.tuiasi.ro                     *
 *  Description:  Windows Forms UI for amortization calculator (linear,   *
 *                  progressive, degressive)                              *
 *  Project: miniContaBill                                                *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

/// <summary>
/// tab1Form este formularul principal pentru calculul amortizării.
/// Permite utilizatorului să introducă valori contabile și să selecteze
/// metoda de amortizare (liniară, progresivă, degresivă).
/// </summary>


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Amortizari;
using Dividente;
using ConvertText;
using FirmUtil;


namespace MiniContaBill
{
    public partial class TabCapitalForm : Form
    {
        public TabCapitalForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evenimentul declansat la incarcarea formularului
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab1Form_Load(object sender, EventArgs e)
        {
            textBoxAmortizareTotala.Text = "" + 0;
            textBoxProfitTotal.Text = "" + 0;
            textBoxSalariiTotal.Text = "" + 0;

            if (FormManager.builder.GetResult().GetFirmType() != FirmType.SA)
            {
                groupBoxDividente.Enabled = false;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Butonul de calcul – apelează metoda corespunzătoare din dll în funcție
        /// de selecția utilizatorului din ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalcAmortizare_Click(object sender, EventArgs e)
        {
            double valoareInitiala;
            int durataViata = Convert.ToInt32(Math.Round(numericUpDownLifeTime.Value, 0));
            double valoareaReziduala;

            // Validare valoare initiala
            if (!double.TryParse(textBoxInitialValue.Text, out valoareInitiala))
            {
                MessageBox.Show("Introduceți o valoare numerică validă pentru Valoarea Inițială.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxInitialValue.Focus();
                return;
            }

            // Validare valoare reziduala
            if (!double.TryParse(textBoxRezidualValue.Text, out valoareaReziduala))
            {
                MessageBox.Show("Introduceți o valoare numerică validă pentru Valoarea Reziduală.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRezidualValue.Focus();
                return;
            }

            // Validare selectie metoda amortizare
            if (comboBoxAmortizare.SelectedIndex == -1)
            {
                MessageBox.Show("Selectați o metodă de amortizare.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxAmortizare.Focus();
                return;
            }

            List<Amortizare> amortizari;

            try
            {
                switch (comboBoxAmortizare.SelectedIndex)
                {
                    case 0:
                        amortizari = AmortizareCalculator.Liniara(valoareInitiala, durataViata, valoareaReziduala);
                        ActualizeazaGrafic(amortizari, "Amortizare anuala", "Amortizare liniara", Color.SteelBlue);
                        break;
                    case 1:
                        amortizari = AmortizareCalculator.Progresiva(valoareInitiala, durataViata, valoareaReziduala);
                        ActualizeazaGrafic(amortizari, "Amortizare anuala", "Amortizare progresiva", Color.Green);
                        break;
                    case 2:
                        amortizari = AmortizareCalculator.Degresiva(valoareInitiala, durataViata, valoareaReziduala);
                        ActualizeazaGrafic(amortizari, "Amortizare anuala", "Amortizare degresiva", Color.Yellow);
                        break;
                    default:
                        MessageBox.Show("Metoda de amortizare selectată nu este validă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                dataGridViewAmortizari.DataSource = amortizari;
                dataGridViewAmortizari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewAmortizari.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridViewAmortizari.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la calcul: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// Functie ce actualizeaza graficul specific fiecarui tip de amortizare
        /// </summary>
        /// <param name="amortizari"></param>
        /// <param name="titlu"></param>
        /// <param name="serieNume"></param>
        /// <param name="culoare"></param>
        private void ActualizeazaGrafic(List<Amortizare> amortizari, string titlu, string serieNume, Color culoare)
        {
            chartAmortizare.Series.Clear();
            chartAmortizare.ChartAreas.Clear();
            chartAmortizare.Titles.Clear();

            chartAmortizare.Titles.Add(titlu);
            chartAmortizare.ChartAreas.Add("MainArea");

            Series serie = new Series(serieNume);
            serie.ChartType = SeriesChartType.Column;  
            serie.Color = culoare;
            serie.BorderWidth = 2;

            foreach (var amortizare in amortizari)
            {
                serie.Points.AddXY($"An {amortizare.An}", amortizare.AmortizareAnuala);
            }

            chartAmortizare.Series.Add(serie);
        }

        /// <summary>
        /// Buton de calcul - se calculeaza si afiseaza valoarea dividentului la apasarea butonului
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amortizareTotala = ConvertText.ConvertText.ConvertToDecimal(textBoxAmortizareTotala.Text);
                decimal salariiTotal = ConvertText.ConvertText.ConvertToDecimal(textBoxSalariiTotal.Text);
                decimal ct = Dividente.Dividente.CalculCheltuieliTotale(amortizareTotala, FormManager.builder.GetResult().GetCC(), salariiTotal);
                decimal profit = Dividente.Dividente.CalculProfit(FormManager.builder.GetResult().GetCA(), ct);
                decimal rezultat = Dividente.Dividente.CalculDivident(profit, numericProcent.Value, FormManager.builder.GetResult().GetNrAct());

                if (rezultat <= 0)
                {
                    MessageBox.Show("Rezultatul calculului este zero sau negativ. Verificați datele introduse.", "Atenție!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                textBoxDivident.Text = rezultat.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduceți valori numerice valide în toate câmpurile.", "Eroare format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
