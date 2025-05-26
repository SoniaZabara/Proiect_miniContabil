/**************************************************************************
 *                                                                        *
 *  File:        DashboardForm.cs                                         *
 *  Copyright:   (c) 2025, Sonia Zabara                                   *
 *  E-mail:      sonia.zabara@student.tuiasi.ro                           *
 *  Description: Windows Forms UI functioning like a dashboard for        *
 *               selecting another form.                                  *
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
using FirmUtil;

namespace MiniContaBill
{
    /// <summary>
    /// Clasă pentru form-ul în care se poate face selecția la ce form va fii încărcat în acesta
    /// </summary>
    public partial class DashboardForm : Form
    {
        /// <summary>
        /// Metodă ce inițializează form-ul
        /// </summary>
        public DashboardForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodă care încarcă in Dashboard alte form-uri
        /// </summary>
        /// <param name="Form"></param>
        public void loadForm(object Form)
        {
            if (this.dashboardMainpanel.Controls.Count > 0)
                this.dashboardMainpanel.Controls.Clear();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.dashboardMainpanel.Controls.Add(f);
            this.dashboardMainpanel.Tag = f;
            f.Show();
        }

        /// <summary>
        /// Buton de înapoi - se merge la form-ul ce era înainte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPrev3_Click(object sender, EventArgs e)
        {
            FormManager.mainForm.LoadForm(new DataForm());
        }

        /// <summary>
        /// Buton încărcare - form capital
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTab1_Click(object sender, EventArgs e)
        {
            loadForm(new TabCapitalForm());
        }

        /// <summary>
        /// Buton Încărcare - form cost și profit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTab2_Click(object sender, EventArgs e)
        {
            loadForm(new TabCostProfitForm());
        }

        /// <summary>
        /// Buton încărcare - form cerere și ofertă
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTab3_Click(object sender, EventArgs e)
        {
            loadForm(new TabCerereOfertaForm());
        }

        /// <summary>
        /// Buton incărcare - form salarii
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTab4_Click(object sender, EventArgs e)
        {
            string firmName = FormManager.builder?.GetResult()?.GetName();
            if (string.IsNullOrWhiteSpace(firmName))
            {
                MessageBox.Show("Nu exista un nume de firma setat.");
                return;
            }
            loadForm(new TabSalariiForm(firmName));
        }

       
        /// <summary>
        /// Metodă ce inițializează form-ul cu câteva valori deja definite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dashboardForm_Load(object sender, EventArgs e)
        {
            Firm firm = FormManager.builder.GetResult();
            labelFirma.Text = firm.GetName() + "." + firm.GetFirmType();
            loadForm(new TabCapitalForm());
        }
    }
}
