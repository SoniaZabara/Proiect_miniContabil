/**************************************************************************
 *                                                                        *
 *  File:        TabCerereOfertaForm.cs                                   *
 *  Copyright:   (c) 2025, Negoiță Petru                                  *
 *  E-mail:      petru.negoita@student.tuiasi.ro                          *
 *  Description:  Windows Forms UI folosit drept calculator pentru        *
 *  a stabili tipul de cerere/ofertă în funcție de input-urile dorite     *
 *  de utilizator                                                         *
 *  Project: miniContabil                                                 *
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CerereStrategy;

namespace MiniContaBill
{
    public partial class TabCerereOfertaForm : Form
    {
        public TabCerereOfertaForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Funcție ce ascunde din tab-ul principal la încărcare toate elementele 
        /// aplicației în afară de butoanele radio de selecție a elasticității
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tab3Form_Load_1(object sender, EventArgs e)
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
            hopeButton3.Visible = false;
            hopeButton4.Visible = false;

            hideExampleButtonsCerereVenit();
            hideExampleButtonsOferta();
            hideExampleButtonsCererePret();
        }
        private void hopeGroupBox1_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Funcție ce face calculul efectiv al datelor scrise și afișează
        /// valoarea și tipul de cerere
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            c = "\nCerere unitar elastică.";
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
        /// <summary>
        /// Actualizează interfața utilizatorului în funcție de tipul de elasticitate selectat
        /// (preț sau venit), afișând câmpurile și etichetele relevante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            crownLabel1.Visible = true;
            crownLabel2.Visible = true;
            crownLabel3.Visible = true;
            crownLabel4.Visible = true;

            hopeButton1.Visible = true;

            hopeButton1.Visible = true;
            hopeButton3.Visible = true;

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
        
        private void hopeGroupBox2_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Funcție ce face calculul efectiv al datelor scrise și afișează
        /// valoarea și tipul de ofertă
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                else if (eop==0)
                {
                    c = "\nOfertă perfect inelastică";
                }
                else if (eop == 1)
                {
                    c = "\nOfertă unitar elastică";
                }
                System.Windows.Forms.MessageBox.Show("Elasticitatea ofertei este: " + eop.ToString() + c, "Rezultat");
            }
            catch (FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Valori incorecte!\nIntroduceți valori numerice.", "EROARE!");
            }

        }
        /// <summary>
        /// Funcție ce afișează expres butoanele pentru elasticitatea cererii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            hopeComboBox1.Visible = true;

            crownLabel5.Visible = false;
            crownLabel6.Visible = false;
            crownLabel7.Visible = false;
            crownLabel8.Visible = false;


            hopeTextBox5.Visible = false;
            hopeTextBox6.Visible = false;
            hopeTextBox7.Visible = false;
            hopeTextBox8.Visible = false;

            hopeButton2.Visible = false;
            hopeButton4.Visible = false;


        }
        /// <summary>
        /// Funcție ce afișează expres butoanele pentru elasticitatea ofertei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            hopeButton3.Visible = false;
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
            hopeButton4.Visible = true;

            crownLabel5.Text = "cantitate oferită inițial";
            crownLabel6.Text = "cantitate oferită după modificare";

            crownLabel7.Text = "preț inițial";
            crownLabel8.Text = "preț după modificare";

        }

    

     
        /// <summary>
        /// Funcție ce activează doar butoanele cu exemple de cereri elastice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton3_Click(object sender, EventArgs e)
        {
            hideInterfaceCerere();
            switch (hopeComboBox1.SelectedItem.ToString())
            {
                case "în funcție de preț":

                    showExampleButtonsCererePret();
                    break;
                case "în funcție de venit":
                    showExampleButtonsCerereVenit();
                    break;
            }
            

        }

        /// <summary>
        /// Funcție ce activează doar butoanele cu exemple de oferte elastice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton4_Click(object sender, EventArgs e)
        {
            hideInterfaceOferta();
            showExampleButtonsOferta();
        }
        /// <summary>
        /// Funcție ce ascunde elementele din interfața de cereri elastice
        /// </summary>
        private void hideInterfaceCerere()
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
            hopeButton3.Visible = false;
            hopeComboBox1.Visible = false;

            hopeButton7.Visible = false;
            hopeButton8.Visible = false;
            hopeButton5.Visible = false;
            hopeButton6.Visible = false;
        }
        /// <summary>
        /// Funcție ce activează elementele din interfața de cereri elastice
        /// </summary>
        private void showInterfaceCererere()
        {
            crownLabel1.Visible = true;
            crownLabel2.Visible = true;
            crownLabel3.Visible = true;
            crownLabel4.Visible = true;

            hopeTextBox1.Visible = true;
            hopeTextBox2.Visible = true;
            hopeTextBox3.Visible = true;
            hopeTextBox4.Visible = true;

            hopeButton1.Visible = true;
            hopeButton3.Visible = true;
            hopeComboBox1.Visible = true;



        }
        /// <summary>
        /// Funcție ce ascunde elementele din interfața de oferte elastice
        /// </summary>
        private void hideInterfaceOferta()
        {
            hopeTextBox5.Visible = false;
            hopeTextBox6.Visible = false;
            hopeTextBox7.Visible = false;
            hopeTextBox8.Visible = false;



            hopeComboBox1.Visible = false;
            hopeButton1.Visible = false;
            hopeButton2.Visible = false;
            hopeButton3.Visible = false;
            hopeButton4.Visible = false;

            crownLabel5.Visible = false;
            crownLabel6.Visible = false;
            crownLabel7.Visible = false;
            crownLabel8.Visible = false;
        }
        /// <summary>
        /// Funcție ce afișează elementele din interfața de oferte elastice
        /// </summary>
        private void showInterfaceOferta()
        {
            crownLabel5.Visible = true;
            crownLabel6.Visible = true;
            crownLabel7.Visible = true;
            crownLabel8.Visible = true;

            hopeTextBox5.Visible = true;
            hopeTextBox6.Visible = true;
            hopeTextBox7.Visible = true;
            hopeTextBox8.Visible = true;

            hopeButton2.Visible = true;
            hopeButton4.Visible = true;
        }
        /// <summary>
        /// Funcție ce afișează butoanele cu exemplele de cerere elastică în funcție
        /// de preț
        /// </summary>
        private void showExampleButtonsCererePret()
        {
            hopeButton7.Visible = true;
            hopeButton8.Visible = true;
            hopeButton5.Visible = true;
            hopeButton6.Visible = true;
        }
        /// <summary>
        /// Funcție ce ascunde butoanele cu exemplele de cerere elastică în funcție
        /// de preț
        /// </summary>
        private void hideExampleButtonsCererePret()
        {


            hopeButton7.Visible = false;
            hopeButton8.Visible = false;
            hopeButton5.Visible = false;
            hopeButton6.Visible = false;
        }

        private void hopeRadioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Funcție ce afișează exemplul de cerere elastică
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton5_Click(object sender, EventArgs e)
        {
            hideExampleButtonsCererePret();

            showInterfaceCererere();
            CerereValori cerere = new CerereValori();
            ICerereStrategy ci = new CerereElastica();
            cerere = ci.generateExample();

            hopeTextBox1.Text = cerere.qc0;
            hopeTextBox2.Text = cerere.qc1;
            hopeTextBox3.Text = cerere.p0;
            hopeTextBox4.Text = cerere.p1;

            System.Windows.Forms.MessageBox.Show(cerere.explanation, cerere.typeOfElasticity);
        }

        /// <summary>
        /// Funcție ce afișează exemplul de cerere unitar elastică
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton6_Click(object sender, EventArgs e)
        {
            hideExampleButtonsCererePret();

            showInterfaceCererere();
            CerereValori cerere = new CerereValori();
            ICerereStrategy ci = new CerereUElastica();
            cerere = ci.generateExample();

            hopeTextBox1.Text = cerere.qc0;
            hopeTextBox2.Text = cerere.qc1;
            hopeTextBox3.Text = cerere.p0;
            hopeTextBox4.Text = cerere.p1;

            System.Windows.Forms.MessageBox.Show(cerere.explanation, cerere.typeOfElasticity);
        }

        /// <summary>
        /// Funcție ce afișează exemplul de cerere rigidă
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton8_Click(object sender, EventArgs e)
        {
            hideExampleButtonsCererePret();

            showInterfaceCererere();
            CerereValori cerere = new CerereValori();
            ICerereStrategy ci = new CerereRigida();
            cerere = ci.generateExample();

            hopeTextBox1.Text = cerere.qc0;
            hopeTextBox2.Text = cerere.qc1;
            hopeTextBox3.Text = cerere.p0;
            hopeTextBox4.Text = cerere.p1;

            System.Windows.Forms.MessageBox.Show(cerere.explanation, cerere.typeOfElasticity);
        }

        /// <summary>
        /// Funcție ce afișează exemplul de cerere inelastică
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton7_Click(object sender, EventArgs e)
        {
            hideExampleButtonsCererePret();

            showInterfaceCererere();
            CerereValori cerere = new CerereValori();
            ICerereStrategy ci = new CerereInelastica();
            cerere = ci.generateExample();

            hopeTextBox1.Text = cerere.qc0;
            hopeTextBox2.Text = cerere.qc1;
            hopeTextBox3.Text = cerere.p0;
            hopeTextBox4.Text = cerere.p1;

            System.Windows.Forms.MessageBox.Show(cerere.explanation, cerere.typeOfElasticity);
        }

        /// <summary>
        /// Funcție ce afișează butoanele cu exemplele de cerere elastică în funcție
        /// de venit
        /// </summary>
        private void showExampleButtonsCerereVenit()
        {
            hopeButton12.Visible = true;
            hopeButton11.Visible = true;
            hopeButton10.Visible = true;
        }

        /// <summary>
        /// Funcție ce ascunde butoanele cu exemplele de cerere elastică în funcție
        /// de venit
        /// </summary>
        private void hideExampleButtonsCerereVenit()
        {


            hopeButton12.Visible = false;
            hopeButton11.Visible = false;
            hopeButton10.Visible = false;
            
        }

        /// <summary>
        /// Funcție ce afișează exemplul de bun inferior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton12_Click(object sender, EventArgs e)
        {
            hideExampleButtonsCerereVenit();

            showInterfaceCererere();
            CerereValori cerere = new CerereValori();
            ICerereStrategy ci = new BunInferior();
            cerere = ci.generateExample();

            hopeTextBox1.Text = cerere.qc0;
            hopeTextBox2.Text = cerere.qc1;
            hopeTextBox3.Text = cerere.p0;
            hopeTextBox4.Text = cerere.p1;

            System.Windows.Forms.MessageBox.Show(cerere.explanation, cerere.typeOfElasticity);
        }
        /// <summary>
        /// Funcție ce afișează exemplul de bun necesar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton11_Click(object sender, EventArgs e)
        {
            hideExampleButtonsCerereVenit();

            showInterfaceCererere();
            CerereValori cerere = new CerereValori();
            ICerereStrategy ci = new BunNecesar();
            cerere = ci.generateExample();

            hopeTextBox1.Text = cerere.qc0;
            hopeTextBox2.Text = cerere.qc1;
            hopeTextBox3.Text = cerere.p0;
            hopeTextBox4.Text = cerere.p1;

            System.Windows.Forms.MessageBox.Show(cerere.explanation, cerere.typeOfElasticity);
        }
        /// <summary>
        /// Funcție ce afișează exemplul de bun superior
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton10_Click(object sender, EventArgs e)
        {
            hideExampleButtonsCerereVenit();

            showInterfaceCererere();
            CerereValori cerere = new CerereValori();
            ICerereStrategy ci = new BunSuperior();
            cerere = ci.generateExample();

            hopeTextBox1.Text = cerere.qc0;
            hopeTextBox2.Text = cerere.qc1;
            hopeTextBox3.Text = cerere.p0;
            hopeTextBox4.Text = cerere.p1;

            System.Windows.Forms.MessageBox.Show(cerere.explanation, cerere.typeOfElasticity);
        }

        private void hopeTextBox5_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Funcție ce afișează butoanele cu exemplele de ofertă elastică
        /// </summary>
        private void showExampleButtonsOferta()
        {
            hopeButton9.Visible = true;
            hopeButton13.Visible = true;
            hopeButton14.Visible = true;
            hopeButton15.Visible = true;
        }
        /// <summary>
        /// Funcție ce ascunde butoanele cu exemplele de ofertă elastică
        /// </summary>
        private void hideExampleButtonsOferta()
        {
            hopeButton9.Visible = false;
            hopeButton13.Visible = false;
            hopeButton14.Visible = false;
            hopeButton15.Visible = false;
        }
        /// <summary>
        /// Funcție ce afișează exemplul de ofertă elastică
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton9_Click(object sender, EventArgs e)
        {
            hideExampleButtonsOferta();

            showInterfaceOferta();
            CerereValori oferta = new CerereValori();
            ICerereStrategy ci = new OfertaElastica();
            oferta = ci.generateExample();

            hopeTextBox5.Text = oferta.qc0;
            hopeTextBox6.Text = oferta.qc1;
            hopeTextBox7.Text = oferta.p0;
            hopeTextBox8.Text = oferta.p1;

            System.Windows.Forms.MessageBox.Show(oferta.explanation, oferta.typeOfElasticity);
        }
        /// <summary>
        /// Funcție ce afișează exemplul de ofertă inelastică
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton13_Click(object sender, EventArgs e)
        {
            hideExampleButtonsOferta();

            showInterfaceOferta();
            CerereValori oferta = new CerereValori();
            ICerereStrategy ci = new OfertaInelastica();
            oferta = ci.generateExample();

            hopeTextBox5.Text = oferta.qc0;
            hopeTextBox6.Text = oferta.qc1;
            hopeTextBox7.Text = oferta.p0;
            hopeTextBox8.Text = oferta.p1;

            System.Windows.Forms.MessageBox.Show(oferta.explanation, oferta.typeOfElasticity);
        }
        /// <summary>
        /// Funcție ce afișează exemplul de ofertă inelastică
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton14_Click(object sender, EventArgs e)
        {
            hideExampleButtonsOferta();

            showInterfaceOferta();
            CerereValori oferta = new CerereValori();
            ICerereStrategy ci = new OfertaPInelastica();
            oferta = ci.generateExample();

            hopeTextBox5.Text = oferta.qc0;
            hopeTextBox6.Text = oferta.qc1;
            hopeTextBox7.Text = oferta.p0;
            hopeTextBox8.Text = oferta.p1;

            System.Windows.Forms.MessageBox.Show(oferta.explanation, oferta.typeOfElasticity);
        }
        /// <summary>
        /// Funcție ce afișează exemplul de ofertă unitar elastică
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hopeButton15_Click(object sender, EventArgs e)
        {
            hideExampleButtonsOferta();

            showInterfaceOferta();
            CerereValori oferta = new CerereValori();
            ICerereStrategy ci = new OfertaUElastica();
            oferta = ci.generateExample();

            hopeTextBox5.Text = oferta.qc0;
            hopeTextBox6.Text = oferta.qc1;
            hopeTextBox7.Text = oferta.p0;
            hopeTextBox8.Text = oferta.p1;

            System.Windows.Forms.MessageBox.Show(oferta.explanation, oferta.typeOfElasticity);
        }

    }
}
