using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Atribute firma
•	Tip: SRL, SA, PFA
•	Nume firma
•	Cifra de afaceri
•	Capital fix: constructii(cladirea, hale, magazine etc), echipamente, utilaje
•	Capital circulant: materii prime, energie, combustibil, semifabricate etc
•	Daca e societate de tip SA are si actiuni
•	Numar angajati
•	Salarii (suma tuturor salariilor pe care firma trebuie sa le plateasca)
•	Datorii
 

 */
namespace miniContabil
{
    public partial class tab3Form : Form
    {
        public tab3Form()
        {
            InitializeComponent();
        }

        private void tab3Form_Load(object sender, EventArgs e)
        {
            crownLabel1.Visible = false;
            crownLabel2.Visible = false;
            crownLabel3.Visible = false;
            crownLabel4.Visible = false;

            crownLabel5.Visible = false;
            crownLabel6.Visible = false;
            crownLabel7.Visible = false;
            crownLabel8.Visible = false;


            hopeTextBox1.Visible = false;
            hopeTextBox2.Visible = false;
            hopeTextBox3.Visible = false;
            hopeTextBox4.Visible = false;

            hopeTextBox5.Visible = false;
            hopeTextBox6.Visible = false;
            hopeTextBox7.Visible = false;
            hopeTextBox8.Visible = false;

            hopeComboBox1.Visible = false;
            hopeButton1.Visible = false;
            hopeButton2.Visible = false;

        }

        private void hopeRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            hopeComboBox1.Visible = true;

            crownLabel5 .Visible = false;
            crownLabel6.Visible = false;
            crownLabel7.Visible = false;
            crownLabel8.Visible = false;


            hopeTextBox5.Visible = false;
            hopeTextBox6.Visible = false;
            hopeTextBox7.Visible = false;
            hopeTextBox8.Visible = false;

            hopeButton2.Visible = false;
        }

        private void hopeRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hopeRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void hopeGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hopeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            crownLabel1.Visible = true;
            crownLabel2.Visible = true;
            crownLabel3.Visible = true;
            crownLabel4.Visible = true;

            hopeButton1.Visible=true;

            hopeButton1.Visible = true;
            hopeTextBox1.Visible = true;
            crownLabel1.Text = "cantitate cerută inițial";
            hopeTextBox2.Visible = true;
            crownLabel2.Text = "cantitate cerută după modificare";
            hopeTextBox3.Visible = true;
            hopeTextBox4.Visible = true;

            switch (hopeComboBox1.SelectedItem.ToString())
            {
                case "în funcție de preț":

                    crownLabel3.Text = "preț inițial";
                    crownLabel4.Text = "preț după modificare"; 
                    break;
                case "în funcție de venit":
                    crownLabel3.Text = "venit inițial";
                    crownLabel4.Text = "venit după modificare";
                    break;
            }
        }

        private void hopeRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            crownLabel1.Visible = false;
            crownLabel2.Visible = false;
            crownLabel3.Visible = false;
            crownLabel4.Visible = false;


            hopeTextBox1.Visible = false;
            hopeTextBox2.Visible = false;
            hopeTextBox3.Visible = false;
            hopeTextBox4.Visible = false;

            hopeButton1.Visible = false;
            hopeComboBox1.Visible = false;

            crownLabel5.Visible = true;
            crownLabel6.Visible = true;
            crownLabel7.Visible = true;
            crownLabel8.Visible = true;

            hopeTextBox5.Visible = true;
            hopeTextBox6.Visible = true;
            hopeTextBox7.Visible = true;
            hopeTextBox8.Visible = true;

            hopeButton2.Visible = true;

            crownLabel5.Text = "cantitate oferită inițial";
            crownLabel6.Text = "cantitate oferită după modificare";

            crownLabel7.Text = "preț inițial";
            crownLabel8.Text = "preț după modificare";
        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            try
            {

                float qc0, qc1, p0, p1;
                string c = "";
                if (float.TryParse(hopeTextBox1.Text, out qc0) == false ||
                    float.TryParse(hopeTextBox2.Text, out qc1) == false ||
                    float.TryParse(hopeTextBox3.Text, out p0) == false ||
                    float.TryParse(hopeTextBox4.Text, out p1) == false)
                {

                    throw new FormatException();
                }
                float ecp = ((qc1 - qc0) / qc0) / ((p1 - p0) / p0);
                switch (hopeComboBox1.SelectedItem.ToString())
                {
                    case "în funcție de preț":
                        if (ecp == 0)
                        {
                            c = "\nCerere rigidă.";
                        }
                        else if (ecp == -1)
                        {
                            c = "\nCererea elastică are elasticitate egală cu unitatea.";
                        }
                        else if (ecp < -1)
                        {
                            c = "\nCerere elastică";
                        }
                        else if (ecp > -1 && ecp < 0)
                        {
                            c = "\nCerere inelastică sau slab elastică.";
                        }
                        break;
                    case "în funcție de venit":
                        if (ecp < 0)
                        {
                            c = "\nBun inferior.";
                        }
                        else if (ecp > 0 && ecp < 1)
                        {
                            c = "\nBun necesar.";
                        }
                        else if (ecp > 1)
                        {
                            c = "\nBun superior.";
                        }
                        break;
                }

                System.Windows.Forms.MessageBox.Show("Elasticitatea cererii este: " + ecp.ToString() + c, "Rezultat");
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Valori incorecte!", "EROARE!");
            }
            
        }

        private void hopeGroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void hopeGroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void hopeButton2_Click(object sender, EventArgs e)
        {
            try
            {
                float qo0, qo1, p0, p1;
                string c = "";
                if (float.TryParse(hopeTextBox5.Text, out qo0) == false ||
                    float.TryParse(hopeTextBox6.Text, out qo1) == false ||
                    float.TryParse(hopeTextBox7.Text, out p0) == false ||
                    float.TryParse(hopeTextBox8.Text, out p1) == false)
                {

                    throw new FormatException();
                }
                float eop = ((qo1 - qo0) / qo0) / ((p1 - p0) / p0);
                if (eop > 1)
                {
                    c = "\nOfertă elastică.";
                }
                else if (eop < 1)
                {
                    c = "\nOfertă inelastică";
                }
                else if (eop == 1)
                {
                    c = "\nOfertă unitar elastică";
                }
                System.Windows.Forms.MessageBox.Show("Elasticitatea ofertei este: " + eop.ToString() + c, "Rezultat");
            }
            catch(FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Valori incorecte!", "EROARE!");
            }
        }

        private void hopeTextBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
