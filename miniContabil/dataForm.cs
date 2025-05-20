/**************************************************************************
 *                                                                        *
 *  File:        DataForm.cs                                              *
 *  Copyright:   (c) 2025, Sonia Zabara                                   *
 *  E-mail:      sonia.zabara@student.tuiasi.ro                           *
 *  Description: Windows Forms UI for setting the atributes of the firm.  *
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
using ReaLTaiizor.Controls;
using FirmUtil;

namespace miniContabil
{
    /// <summary>
    /// Clasă pentru form-ul care setează atributele firmei
    /// </summary>
    public partial class DataForm : Form
    {
        /// <summary>
        /// Metodă ce inițializează form-ul
        /// </summary>
        public DataForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodă ce  Metodă ce inițializează form-ul cu câteva valori deja definite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataForm_Load(object sender, EventArgs e)
        {
            Firm firm = FormManager.builder.GetResult();
            labelFirma.Text = firm.GetName() + " ." + firm.GetFirmType();

            textBoxCA.Text = "" + firm.GetCA();
            textBoxCF.Text = "" + firm.GetCF();
            textBoxCC.Text = "" + firm.GetCC();
            textBoxNrAct.Text = "" + firm.GetNrAct();
            textBoxValAct.Text = "" + firm.GetValAct();
            textBoxDatorii.Text = "" + firm.GetDatorii();

            if(FormManager.builder.GetResult().GetFirmType()!=FirmType.SA)
            {
                textBoxNrAct.Enabled = false;
                textBoxValAct.Enabled = false;
            }
            
        }

        /// <summary>
        /// Buton de înapoi - se merge la form-ul ce era înainte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrev2_Click(object sender, EventArgs e)
        {
            FormManager.mainForm.loadForm(new SelectForm());
        }

        /// <summary>
        /// Buton de next - se merge la următorul form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext2_Click(object sender, EventArgs e)
        {
            FormManager.mainForm.loadForm(new DashboardForm());
        }

        /// <summary>
        /// Metodă ce setează cifra de afaceri a firmei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetCA(Convert.ToUInt32(textBoxCA.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }

        /// <summary>
        /// Metodă ce setează capitalul fix al firmei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetCF(Convert.ToUInt32(textBoxCF.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }

        /// <summary>
        /// Metodă ce setează capitalul circulant al firmei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetCC(Convert.ToUInt32(textBoxCC.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }

        /// <summary>
        /// Metodă ce setează numărul de acțiuni ale firmei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxNrAct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetNrActiuni(Convert.ToUInt32(textBoxNrAct.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }

        /// <summary>
        /// Metodă ce setează valoarea unei acțiuni ale firmei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxValAct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetPretActiune(Convert.ToUInt32(textBoxValAct.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }

        /// <summary>
        /// Metodă ce setează valoarea datoriilor firmei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDatorii_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FormManager.builder.SetDatorii(Convert.ToUInt32(textBoxDatorii.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Va rugam introduceti o valoare valida.");
            }
        }
    }
}
