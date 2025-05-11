using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniContabil
{
    public partial class tabSalariiForm : Form
    {
        private int _index;
        private readonly List<Angajat> _angajati = new List<Angajat>();
        public string SelectedFirm { get; set; }

        public tabSalariiForm(string selectedFirm)
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

        private void FilterEmployeesByFirm()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _angajati;

            AdjustDataGridViewHeight(); // Ajustează înălțimea tabelului
        }
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

        private void buttonSalariuMediu_Click(object sender, EventArgs e)
        {
            double averageSalary=CalculateAverageSalary();

            textBoxAverageSalary.Text = averageSalary.ToString("F2");

        }

        private double CalculateAverageSalary()
        {
            if (_angajati.Count == 0)
            {
                MessageBox.Show("Nu există angajați pentru a calcula salariul mediu.");
            }

            double totalSalary = _angajati.Sum(a => a.SalariuBrut);
            double averageSalary = totalSalary / _angajati.Count;
            return averageSalary;
        }

        private void buttonTotalSalarii_Click(object sender, EventArgs e)
        {
            if (_angajati.Count == 0)
            {
                MessageBox.Show("Nu există angajați pentru a calcula totalul salariilor.");
            }

            double totalSalary = _angajati.Sum(a => a.SalariuBrut);
            textBoxTotalSalary.Text = totalSalary.ToString("F2");
        }

        private void buttonSalariuNet_Click(object sender, EventArgs e)
        {
            if (_angajati.Count == 0)
            {
                MessageBox.Show("Nu ati selectat un angajat pentru a calcula salariul NET.");
            }

            double asigurareSociala;
            double asigurareSanatate;
            double impozit;
            double deducerePersonala;
            double salariuNet;
            double salariuMinimBrut = 4050;

            if (_index >= 0 && _index < _angajati.Count)
            {
                var angajat = _angajati[_index];

              
                    asigurareSociala= 0.25 * angajat.SalariuBrut;
                    asigurareSanatate = 0.10 * angajat.SalariuBrut;
                    impozit = 0.10 * (angajat.SalariuBrut - asigurareSociala - asigurareSanatate);
                    salariuNet = angajat.SalariuBrut - asigurareSociala - asigurareSanatate - impozit;

                    if (angajat.SalariuBrut < salariuMinimBrut + 2000)
                    {
                        MessageBox.Show("Angajatul are un salariu brut mai mare decat salariul minim brut plus 2000 lei, deci are deducere personală.");
                    }

                    textBoxNetSalary.Text = salariuNet.ToString("F2");
            }
        }

        private void buttonCostTotalAngajator_Click(object sender, EventArgs e)
        {
            double costTotal;

            if (_index >= 0 && _index < _angajati.Count)
            {
                var angajat = _angajati[_index];

                costTotal = 0.0225 * angajat.SalariuBrut+ angajat.SalariuBrut;
                
                textBoxCostTotalAngajator.Text = costTotal.ToString("F2");

            }
        }
    }

    public class Angajat
    {
        public int Id { get; set; }
        public string NumeAngajat { get; set; }
        public string Functie { get; set; }
        public double SalariuBrut { get; set; }
        public string Departament { get; set; }

        public Angajat(int id, string numeAngajat, string functie, double salariuBrut, string departament)
        {
            Id = id;
            NumeAngajat = numeAngajat;
            Functie = functie;
            SalariuBrut = salariuBrut;
            Departament = departament;
        }
    }
}
