/**************************************************************************
 *                                                                        *
 *  File:        tabSalariiForm.cs                                        *
 *  Copyright:   (c) 2025, Bran Ioana -Andreea                            *
 *  E-mail:      ioana-andreea.bran@student.tuiasi.ro                     *
 *  Description:  Windows Forms UI pentru gestionarea salariilor          *
 *       angajaților unei firme selectate.Permite adăugarea, modificarea, *
 *       ștergerea și salvarea angajaților în format JSON.Afișează un     *
 *   DataGridView cu angajații firmei și calculează salariul net,salariul *
 *   mediu,costul total pentru angajator și suma totală a salariilor.     *
 *  Project: miniContaBill                                                *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using SalariiAngajati;

namespace miniContabil
{
    public partial class TabSalariiForm : Form
    {
        private int _index;
        private readonly List<Angajat> _angajati = new List<Angajat>();
        public string SelectedFirm { get; set; }

        /// <summary>
        /// Constructorul primeste firma selectata si incarca angajatii care sunt salvati pentru acea firma
        /// </summary>
        /// <param name="selectedFirm"></param>
        public TabSalariiForm(string selectedFirm)
        {
            InitializeComponent();
            CustomizeDataGridView();
            SelectedFirm = selectedFirm;

            LoadAllEmployees();
            FilterEmployeesByFirm();
            if (_angajati.Count == 0)
            {
                MessageBox.Show($"Nu s-au gasit angajati pentru firma {selectedFirm}. Va rugam adaugati angajati sau incarcati fisierul cu angajati.");
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        /// <summary>
        /// Functie ce adauga un angajat in dataGrid- ul cu angajati, face verificarile necesare pentru nu a fi dublat un id sau un nume
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double salariuBrut;
            if (!double.TryParse(textBoxSalariuBrut.Text, out salariuBrut))
            {
                MessageBox.Show("Va rugam sa introduceti o valoare numerica pentru salariul brut");
                return;
            }

            int id;
            string numeAngajat = textBoxNumeAngajat.Text.Trim();

            if (!int.TryParse(textBoxId.Text, out id))
            {
                MessageBox.Show("Va rugam sa introduceti un Id valid.");
                return;
            }

            if (_angajati.Any(a => a.Id == id))
            {
                MessageBox.Show($"Angajatul cu id-ul {id} există deja. Vă rugăm să introduceți un Id unic.");
                return;
            }

            if (_angajati.Any(a => a.NumeAngajat.Equals(numeAngajat, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Angajatul '{numeAngajat}' există deja in lista.");
                return;
            }

            var newAngajat = new Angajat(
                id,
                textBoxNumeAngajat.Text,
                textBoxFunctie.Text,
                salariuBrut,
                textBoxDepartament.Text
            );

            _angajati.Add(newAngajat);

            textBoxId.Clear();
            textBoxNumeAngajat.Clear();
            textBoxFunctie.Clear();
            textBoxSalariuBrut.Clear();
            textBoxDepartament.Clear();


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _angajati;
        }

        /// <summary>
        /// Functie ce descrie callback-ul evenimentului de apasare a unei celule din dataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                _index = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[_index];

                textBoxId.Text = row.Cells[0].Value?.ToString() ?? string.Empty;
                textBoxNumeAngajat.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                textBoxFunctie.Text = row.Cells[2].Value?.ToString() ?? string.Empty;
                textBoxSalariuBrut.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                textBoxDepartament.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
            }
        }

        private void tabSalariiForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Functie pentru a actualiza datele unui angajat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_index >= 0 && _index < _angajati.Count)
            {
                var angajat = _angajati[_index];

                double salariuBrut;

                if (!double.TryParse(textBoxSalariuBrut.Text, out salariuBrut))
                {
                    MessageBox.Show("Va rugam sa introduceti o valoare numerica pentru salariul brut");
                    return;
                }

                int id;
                string numeAngajat = textBoxNumeAngajat.Text.Trim();

                if (!int.TryParse(textBoxId.Text, out id))
                {
                    MessageBox.Show("Va rugam sa introduceti un Id valid.");
                    return;
                }

                if (!string.IsNullOrWhiteSpace(textBoxId.Text))
                    angajat.Id = id;

                if (!string.IsNullOrWhiteSpace(textBoxNumeAngajat.Text))
                    angajat.NumeAngajat = numeAngajat;

                if (!string.IsNullOrWhiteSpace(textBoxFunctie.Text))
                    angajat.Functie = textBoxFunctie.Text;

                if (!string.IsNullOrWhiteSpace(textBoxSalariuBrut.Text))
                    angajat.SalariuBrut =salariuBrut;

                if (!string.IsNullOrWhiteSpace(textBoxDepartament.Text))
                    angajat.Departament = textBoxDepartament.Text;

                textBoxId.Clear();
                textBoxNumeAngajat.Clear();
                textBoxFunctie.Clear();
                textBoxSalariuBrut.Clear();
                textBoxDepartament.Clear();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _angajati;
            }
            else
            {
                MessageBox.Show("Selectați un angajat pentru actualizare.");
            }
        }

        /// <summary>
        /// Functie pentru a sterge un angajat din dataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_index >= 0 && _index < _angajati.Count)
            {
                _angajati.RemoveAt(_index);

                textBoxId.Clear();
                textBoxNumeAngajat.Clear();
                textBoxFunctie.Clear();
                textBoxSalariuBrut.Clear();
                textBoxDepartament.Clear();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _angajati;
            }
            else
            {
                MessageBox.Show("Nu mai sunt date de șters.");
            }
        }

        /// <summary>
        /// Functie pentru a salva lista cu angajati intr-un fisier JSON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSaveToJson_Click(object sender, EventArgs e)
        {
            try
            {
                string firmName = FormManager.builder?.GetResult()?.GetName();

                if (string.IsNullOrWhiteSpace(firmName))
                {
                    MessageBox.Show("Numele firmei nu este setat. Vă rugăm să introduceți un nume valid.");
                    return;
                }

                string sanitizedFirmName = string.Concat(firmName.Where(c => !Path.GetInvalidFileNameChars().Contains(c)));

                string filePath = $"{sanitizedFirmName}_angajati.json";

                string json = System.Text.Json.JsonSerializer.Serialize(_angajati, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(filePath, json);

                MessageBox.Show($"Datele au fost salvate cu succes în fișierul {filePath}.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la salvarea datelor: {ex.Message}");
            }
        }

        /// <summary>
        /// Functie ce filtreaza angajatii in functie de firma selectata
        /// </summary>
        private void FilterEmployeesByFirm()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _angajati;

            AdjustDataGridViewHeight(); 
        }

        /// <summary>
        /// Functie ce incarca toti angajatii firmei selectate
        /// </summary>
        private void LoadAllEmployees()
        {
            string fileNamePattern = $"{SelectedFirm}_angajati.json";
            string directoryPath = AppContext.BaseDirectory;

            string constructedPath = Path.Combine(directoryPath, fileNamePattern);
            Console.WriteLine($"Constructed file path: {constructedPath}");

            string[] matchingFiles = Directory.GetFiles(directoryPath, fileNamePattern);

            if (matchingFiles.Length > 0)
            {
                string filePath = matchingFiles[0];
                string json = File.ReadAllText(filePath);
                var allEmployees = System.Text.Json.JsonSerializer.Deserialize<List<Angajat>>(json);
                _angajati.AddRange(allEmployees);
            }
            else
            {
                MessageBox.Show($"Fișierul pentru firma '{SelectedFirm}' nu a fost găsit.");
            }
        }

        /// <summary>
        /// Functie pentru a incarca in dataGrid lista cu angajatii firmei selectate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                LoadAllEmployees(); 
                FilterEmployeesByFirm(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la încărcarea datelor: {ex.Message}");
            }
        }
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _angajati.Count)
                return;
        }
        private void CustomizeDataGridView()
        {
            // Alternating row colors
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;

            // Header style
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);

            // Gridline color
            dataGridView1.GridColor = Color.LightBlue;

            // Selected row style
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Optional: Remove cell borders
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Stretch columns to fit the DataGridView width
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Enable vertical scrollbar
            dataGridView1.ScrollBars = ScrollBars.Vertical;

            // Disable automatic row resizing
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void AdjustDataGridViewHeight()
        {
            int maxRows = 8; // Numărul maxim de rânduri vizibile
            int rowHeight = dataGridView1.RowTemplate.Height; // Înălțimea unui singur rând
            int headerHeight = dataGridView1.ColumnHeadersHeight; // Înălțimea antetului

            // Setează înălțimea pentru 8 rânduri
            dataGridView1.Dock = DockStyle.None;
            int targetHeight = (rowHeight * maxRows) + headerHeight + 2; // Adaugă 2 pentru margini

            // Limitează înălțimea DataGridView
            dataGridView1.Height = targetHeight;

            // Poziționează DataGridView la jumătatea GroupBox-ului
            int groupBoxHeight = groupBox1.Height;
            dataGridView1.Top = 0;
        }

        /// <summary>
        /// Functie calcul salariu mediu folosind functia specifica din dll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalariuMediu_Click(object sender, EventArgs e)
        {
            double averageSalary=SalaryCalculator.CalculateAverageSalary(_angajati);

            textBoxAverageSalary.Text = averageSalary.ToString("F2");

        }

        /// <summary>
        /// Functie calcul totatl salarii folosind functia specifica din dll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTotalSalarii_Click(object sender, EventArgs e)
        {
            if (_angajati.Count == 0)
            {
                MessageBox.Show("Nu există angajați pentru a calcula totalul salariilor.");
            }

            double totalSalary = SalaryCalculator.CalculateTotalSalary(_angajati);
            textBoxTotalSalary.Text = totalSalary.ToString("F2");
        }

        /// <summary>
        /// Functie calcul salariu net pentru un abgajat selectat, folosind functia specifica din dll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalariuNet_Click(object sender, EventArgs e)
        {
            if (_angajati.Count == 0)
            {
                MessageBox.Show("Nu ati selectat un angajat pentru a calcula salariul NET.");
            }

            if (_index >= 0 && _index < _angajati.Count)
            {
                var angajat = _angajati[_index];

                if (angajat.SalariuBrut < 6050)
                {
                    MessageBox.Show("Angajatul are un salariu brut mai mare decat salariul minim brut plus 2000 lei, deci are deducere personală.");
                }

                double netSalary=SalaryCalculator.CalculateNetSalary(_angajati[_index]);
                textBoxNetSalary.Text = netSalary.ToString("F2");
            }
        }

        /// <summary>
        /// Functie pentru calcul cost total angajator folosind functia specifica din dll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCostTotalAngajator_Click(object sender, EventArgs e)
        {
            if (_index >= 0 && _index < _angajati.Count)
            {
                var angajat = _angajati[_index];

                double costTotal = SalaryCalculator.CalculateTotalEmployerCost(_angajati[_index]); 
                
                textBoxCostTotalAngajator.Text = costTotal.ToString("F2");

            }
        }
    }
}
