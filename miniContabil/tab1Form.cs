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

namespace miniContabil
{
    public partial class tab1Form : Form
    {
        public tab1Form()
        {
            InitializeComponent();
        }
        private void tab1Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcAmortizare_Click(object sender, EventArgs e)
        {
            double valoareInitiala;
            int durataViata = Convert.ToInt32(Math.Round(numericUpDownLifeTime.Value, 0));
            double valoareaReziduala;
            string amortizare = comboBoxAmortizare.Text;

            if (!double.TryParse(textBoxInitialValue.Text, out valoareInitiala))
            {
                MessageBox.Show("Va rugam sa introduceti o valoare numerica pentru Valoarea Initiala!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(textBoxRezidualValue.Text, out valoareaReziduala))
            {
                MessageBox.Show("Va rugam sa introduceti o valoare numerica pentru Valoarea Reziduala!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxAmortizare.SelectedIndex == -1)
            {
                MessageBox.Show("Va rugam selectati un tip de amortizare.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBoxAmortizare.SelectedIndex)
            {
                case 0:
                    var amortizariLiniare = AmortizareCalculator.Liniara(valoareInitiala, durataViata, valoareaReziduala);
                    dataGridViewAmortizari.DataSource = amortizariLiniare;
                    ActualizeazaGrafic(amortizariLiniare, "Amortizare anuala", "Amortizare liniara",Color.SteelBlue);
                    break;
                case 1:
                    var amortizariProgresive = AmortizareCalculator.Progresiva(valoareInitiala, durataViata, valoareaReziduala);
                    dataGridViewAmortizari .DataSource = amortizariProgresive;
                    ActualizeazaGrafic(amortizariProgresive, "Amortizare anuala", "Amortizare progresiva",Color.Green);
                    break;
                case 2:
                    var amortizariDegresive = AmortizareCalculator.Degresiva(valoareInitiala, durataViata, valoareaReziduala);
                    dataGridViewAmortizari.DataSource = amortizariDegresive;
                    ActualizeazaGrafic(amortizariDegresive, "Amortizare anuala", "Amortizare degresiva", Color.Yellow);
                    break;
            }

            dataGridViewAmortizari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAmortizari.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAmortizari.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }
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

    }
}
