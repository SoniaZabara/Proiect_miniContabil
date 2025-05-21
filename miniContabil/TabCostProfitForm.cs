/**************************************************************************
 *                                                                        *
 *  File:        RataProfit.cs                                            *
 *  Copyright:   (c) 2025, Chiuariu Vasile Silviu                         *
 *  E-mail:      vasile-silviu.chiuariu@student.tuiasi.ro                 *
 *  Description: Clasa pentru functionalitatea tabului TabCostProfit      *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/
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
using FirmUtil;
using CostulProductieProfitDDL;

namespace miniContabil
{
    public partial class TabCostProfitForm : Form
    {
        /// <summary>
        /// Initializeaza formularul, dezactiveaza controalele si activeaza scroll-ul automat.
        /// </summary>
        public TabCostProfitForm()
        {
            InitializeComponent();
            DezactiveazaControalele();
            DoarReadOnly();
            this.AutoScroll = true;
        }


        /// <summary>
        /// Dezactiveaza controalele pentru introducerea datelor si seteaza tipul firmei in functie de configuratia existenta.
        /// </summary>
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

        /// <summary>
        /// Seteaza anumite campuri ca fiind doar pentru citire.
        /// </summary>
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

        /// <summary>
        /// Calculeaza masa profitului pe baza pretului de vanzare si a costurilor, si afiseaza rezultatul.
        /// </summary>
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

        /// <summary>
        /// Calculeaza rata profitului pe baza masei profitului si a costurilor, si afiseaza rezultatul.
        /// </summary>
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

        /// <summary>
        /// Actualizeaza culorile si valorile graficului tip pie pentru distributia costurilor.
        /// </summary>
        private void UpdatePieChartColorAndSize(double anortizare, double materiiPrim, double salarii, double materialAuxil, double chiria, double profit)
        {
            chartPretFinal.Series.Clear();

            var series = new Series("Costuri");
            series.ChartType = SeriesChartType.Pie;

            series.Points.AddXY($" ({anortizare:F1}%)", anortizare);
            series.Points.AddXY($" ({salarii:F1}%)", salarii);
            series.Points.AddXY($" ({materiiPrim:F1}%)", materiiPrim);
            series.Points.AddXY($" ({materialAuxil:F1}%)", materialAuxil);
            series.Points.AddXY($" ({chiria:F1}%)", chiria);
            series.Points.AddXY($" ({profit:F1}%)", profit);


            series.Points[0].Color = Color.Yellow;      // anortizare
            series.Points[1].Color = Color.Cyan;  // salarii
            series.Points[2].Color = Color.Purple;       // materiiPrime
            series.Points[3].Color = Color.GreenYellow;      // materialeAuxilre
            series.Points[4].Color = Color.Red;      // chiria
            series.Points[5].Color = Color.Gold;      // profit


            chartPretFinal.Series.Add(series);

            chartPretFinal.Refresh();
        }

        /// <summary>
        /// Calculeaza procentele pentru fiecare componenta a costului si actualizeaza graficul tip pie.
        /// </summary>
        private void UpdateValoriPieGraph()
        {
            double pretFinal = Convert.ToDouble(textBoxPretFinal.Text);
            double amortizare = Convert.ToDouble(textBoxAmortizare.Text);
            double materiiPrime = Convert.ToDouble(textBoxMateriiPrime.Text);
            double salarii = Convert.ToDouble(textBoxSalarii.Text);
            double materialeAuxilar = Convert.ToDouble(textBoxMaterialeAuxiliare.Text);
            double chiria = Convert.ToDouble(textBoxChiria.Text);

            double numarUnitatiProd = Convert.ToDouble(textBoxNrUnitatiProduse.Text);

            var calculator = new PretFinal();
            double procentAmortizare = calculator.CalculeazaProcentePie(amortizare, pretFinal, numarUnitatiProd);
            double procentMateriiPrime = calculator.CalculeazaProcentePie(materiiPrime, pretFinal, numarUnitatiProd);
            double procentSalarii = calculator.CalculeazaProcentePie(salarii, pretFinal, numarUnitatiProd);
            double procentMaterialAuxilar = calculator.CalculeazaProcentePie(materialeAuxilar, pretFinal, numarUnitatiProd);
            double procentChiria = calculator.CalculeazaProcentePie(chiria, pretFinal, numarUnitatiProd);
            double procentProfit = 100 - procentAmortizare - procentMateriiPrime - procentSalarii - procentMaterialAuxilar - procentChiria;

            UpdatePieChartColorAndSize(procentAmortizare, procentMateriiPrime, procentSalarii, procentMaterialAuxilar, procentChiria, procentProfit);
        }

        /// <summary>
        /// Calculeaza costul total, costul mediu si pretul final, apoi actualizeaza graficul cu distributia costurilor.
        /// </summary>
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
                UpdateValoriPieGraph();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la calcul: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCT.Text = "0";
                textBoxCostMediu.Text = "0";
                textBoxPretFinal.Text = "0";
            }
        }

        /// <summary>
        /// Activeaza campurile necesare pentru calculul pragului de rentabilitate in cazul A.
        /// </summary>
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

        /// <summary>
        /// Activeaza campurile necesare pentru calculul pragului de rentabilitate in cazul B.
        /// </summary>
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


        /// <summary>
        /// Configureaza graficul de tip bar pentru afisarea valorilor componente in analiza pragului de rentabilitate.
        /// </summary>
        private void SetupBarChartPragRenta(bool ok)
        {
            try
            {
               
                chartPragDeRentabilitate.Series.Clear();
                chartPragDeRentabilitate.ChartAreas.Clear();
                chartPragDeRentabilitate.Titles.Clear();


                ChartArea chartArea = new ChartArea("MainArea");
                chartPragDeRentabilitate.ChartAreas.Add(chartArea);

                chartPragDeRentabilitate.Titles.Add("Analiza Prag de Rentabilitate");
                chartPragDeRentabilitate.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

                Series series = new Series("Valori");
                series.ChartType = SeriesChartType.Column;
                chartPragDeRentabilitate.Series.Add(series);

             
                chartArea.AxisY.Minimum = 0;

                double pretUnitate = Convert.ToDouble(textBoxPretUnitateProdus.Text);
                double costFixTotal = Convert.ToDouble(textBoxCostFix.Text);
                double costVarMediu = Convert.ToDouble(textBoxCostVariabileMedii.Text);
                double cantitate = Convert.ToDouble(textBoxCantitate.Text);
              
                series.Points.AddXY("", pretUnitate);
                series.Points.AddXY("", costFixTotal);
                series.Points.AddXY("", costVarMediu);
                series.Points.AddXY("", cantitate);

                series.Points[0].Color = Color.LightBlue;    // Pret Unitate
                series.Points[1].Color = Color.Salmon;       // Cost Fix
                series.Points[2].Color = Color.LightGreen;   // Cost Variabil
                series.Points[3].Color = Color.Purple;       // Cantitate

                if (!ok)
                {
                    double profit = Convert.ToDouble(textBoxProfit1.Text);
                    series.Points.AddXY("", profit);
                    series.Points[4].Color = Color.Gold;         // Profit
                }

                foreach (DataPoint point in series.Points)
                {
                    point.Label = "#VALY";
                    point.Font = new Font("Arial", 8);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Calculeaza pragul de rentabilitate si actualizeaza graficul corespunzator.
        /// </summary>
        private void buttonCalculeazaPregdeRentabilitate_Click(object sender, EventArgs e)
        {
            try
            {
                var calculator = new PragRentabilitate();
                string rezultat = calculator.CalculeazaPragRentabilitate(textBoxPretUnitateProdus.Text, textBoxCostFix.Text, textBoxProfit1.Text, textBoxCostVariabileMedii.Text, radioButtonRentabilitateCazA.Checked);
                textBoxCantitate.Text = rezultat;
                SetupBarChartPragRenta(radioButtonRentabilitateCazA.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la calcul: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCantitate.Text = "0";
            }
        }

        /// <summary>
        /// Activeaza campurile necesare pentru calculul impozitului pe profit in cazul in care firma este PFA.
        /// </summary>
        private void radioButtonCuPFA_CheckedChanged(object sender, EventArgs e)
        {
            textBoxProfit2.Enabled = true;
            buttonCalculeazaImpozitProfit.Enabled = true;
            textBoxImpozitProfit.Enabled = true;
            textBoxProfit2.Clear();
            textBoxImpozitProfit.Clear();
        }

        /// <summary>
        /// Activeaza campurile necesare pentru calculul impozitului pe profit in cazul in care firma nu este PFA.
        /// </summary>
        private void radioButtonFaraPFA_CheckedChanged(object sender, EventArgs e)
        {
            textBoxProfit2.Enabled = true;
            buttonCalculeazaImpozitProfit.Enabled = true;
            textBoxImpozitProfit.Enabled = true;
            textBoxProfit2.Clear();
            textBoxImpozitProfit.Clear();
        }

        /// <summary>
        /// Calculeaza impozitul pe profit in functie de valoarea profitului si tipul firmei (PFA sau nu).
        /// </summary>
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

        /// <summary>
        /// Calculeaza pretul cu TVA pe baza pretului brut si a cotei de TVA.
        /// </summary>
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
