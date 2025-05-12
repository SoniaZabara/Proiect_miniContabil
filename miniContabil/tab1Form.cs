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
                    var amortizariLiniare = amortizareLiniara(valoareInitiala, durataViata, valoareaReziduala);
                    dataGridViewAmortizari.DataSource = amortizariLiniare;
                    ActualizeazaGrafic(amortizariLiniare, "Amortizare anuala", "Amortizare liniara",Color.SteelBlue);
                    break;
                case 1:
                    var amortizariProgresive = amortizareProgresiva(valoareInitiala, durataViata, valoareaReziduala);
                    dataGridViewAmortizari .DataSource = amortizariProgresive;
                    ActualizeazaGrafic(amortizariProgresive, "Amortizare anuala", "Amortizare progresiva",Color.Green);
                    break;
                case 2:
                    var amortizariDegresive = amortizareDegresiva(valoareInitiala, durataViata, valoareaReziduala);
                    dataGridViewAmortizari.DataSource = amortizariDegresive;
                    ActualizeazaGrafic(amortizariDegresive, "Amortizare anuala", "Amortizare degresiva", Color.Yellow);
                    break;
            }

            dataGridViewAmortizari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAmortizari.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAmortizari.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private List<Amortizare> amortizareLiniara(double initialValue, int lifeTime, double rezidualValue)
        {
            List <Amortizare> amortizari=new List<Amortizare>();

            double amortizareAnuala = (initialValue - rezidualValue) / lifeTime;
            double valoareRamasa = initialValue;

            for (int an = 1; an <= lifeTime; an++)
            {
                valoareRamasa -= amortizareAnuala;
                amortizari.Add(new Amortizare
                {
                    An = an,
                    AmortizareAnuala = amortizareAnuala,
                    ValoareRamasa = valoareRamasa
                });
            }

            return amortizari;
        }

        private List<Amortizare> amortizareProgresiva(double initialValue, int lifeTime, double rezidualValue)
        {
            List<Amortizare> amortizari=new List<Amortizare>();

            double bazaAmortizabila = initialValue - rezidualValue;
            int sumaPonderi = (lifeTime * (lifeTime + 1)) / 2;

            double valoareRamasa = initialValue;

            for (int an = 1; an <= lifeTime; an++)
            {
                double amortizareAnuala = bazaAmortizabila * an / sumaPonderi;
                valoareRamasa -= amortizareAnuala;

                amortizari.Add(new Amortizare
                {
                    An = an,
                    AmortizareAnuala = Math.Round(amortizareAnuala, 2),
                    ValoareRamasa = Math.Round(valoareRamasa, 2)
                });
            }

            return amortizari;
        }

        private List<Amortizare> amortizareDegresiva(double initialValue, int lifeTime, double rezidualValue)
        {
            List<Amortizare> amortizari = new List<Amortizare>();

            double rataDegresiva = 2.0 / lifeTime; 
            double valoareRamasa = initialValue;

            for (int an = 1; an <= lifeTime; an++)
            {
                double amortizareAnuala = valoareRamasa * rataDegresiva;

                if (valoareRamasa - amortizareAnuala < rezidualValue)
                {
                    amortizareAnuala = valoareRamasa - rezidualValue;
                }

                valoareRamasa -= amortizareAnuala;

                amortizari.Add(new Amortizare
                {
                    An = an,
                    AmortizareAnuala = Math.Round(amortizareAnuala, 2),
                    ValoareRamasa = Math.Round(valoareRamasa, 2)
                });

                if (valoareRamasa <= rezidualValue)
                    break; 
            }

            return amortizari;
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

    public class Amortizare
    {
        public int An {  get; set; }
        public double AmortizareAnuala {  get; set; }
        public double ValoareRamasa { get; set; }
    }
}
