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
            int durataViata = Convert.ToInt32(Math.Round(numericUpDownLifeTime.Value, 0)); // converteste valoare din selectorul numeric in int
            double valoareaReziduala;
            string amortizare = comboBoxAmortizare.Text;

            try
            {
                valoareInitiala = Convert.ToDouble(textBoxInitialValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă pentru Valoarea Inițială!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                valoareaReziduala = Convert.ToDouble(textBoxRezidualValue.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vă rugăm să introduceți o valoare numerică validă pentru Valoarea Reziduală!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (comboBoxAmortizare.SelectedIndex == -1)
                {
                    throw new InvalidOperationException("Nu a fost selectată nicio metodă de amortizare.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vă rugăm selectați un tip de amortizare din listă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBoxAmortizare.SelectedIndex)
            {
                case 0:
                    var amortizariLiniare = AmortizareCalculator.Liniara(valoareInitiala, durataViata, valoareaReziduala); // calcul valoare amortizare liniara folosind functia specifica din dll
                    dataGridViewAmortizari.DataSource = amortizariLiniare;
                    ActualizeazaGrafic(amortizariLiniare, "Amortizare anuala", "Amortizare liniara",Color.SteelBlue);
                    break;
                case 1:
                    var amortizariProgresive = AmortizareCalculator.Progresiva(valoareInitiala, durataViata, valoareaReziduala); // calcul valoare amortizare progresiva folosind functia specifica din dll
                    dataGridViewAmortizari .DataSource = amortizariProgresive;
                    ActualizeazaGrafic(amortizariProgresive, "Amortizare anuala", "Amortizare progresiva",Color.Green);
                    break;
                case 2:
                    var amortizariDegresive = AmortizareCalculator.Degresiva (valoareInitiala, durataViata, valoareaReziduala); // calcul valoare amortizare degresiva folosind functia specifica din dll
                    dataGridViewAmortizari.DataSource = amortizariDegresive;
                    ActualizeazaGrafic(amortizariDegresive, "Amortizare anuala", "Amortizare degresiva", Color.Yellow);
                    break;
            }

            dataGridViewAmortizari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAmortizari.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAmortizari.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

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
            decimal rezultat = 0;
            decimal profit;
            decimal ct;
            
            ct = Dividente.Dividente.CalculCheltuieliTotale(ConvertText.ConvertText.ConvertToDecimal(textBoxAmortizareTotala.Text), FormManager.builder.GetResult().GetCC(), ConvertText.ConvertText.ConvertToDecimal(textBoxSalariiTotal.Text));
            profit = Dividente.Dividente.CalculProfit(FormManager.builder.GetResult().GetCA(), ct);
            rezultat = Dividente.Dividente.CalculDivident(profit, numericProcent.Value, FormManager.builder.GetResult().GetNrAct());

            if(rezultat == 0)
            {
                MessageBox.Show("O posibilă eroare cauzată de introducerea necorespunzătoare a unei valori", "Atenție!");
            }

            textBoxDivident.Text = "" + rezultat;
        }
    }   
}
