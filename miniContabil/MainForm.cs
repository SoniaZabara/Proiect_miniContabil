/**************************************************************************
 *                                                                        *
 *  File:        MainForm.cs                                                 *
 *  Copyright:   (c) 2025, Sonia Zabara                                   *
 *  E-mail:      sonia.zabara@student.tuiasi.ro                           *
 *  Description: Windows Forms UI for building the main form from which   *
 *               the others will emerge.                                  *
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

namespace miniContabil
{
    /// <summary>
    /// Clasă pentru primul form din aplicație
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Metodă ce inițializează MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            FormManager.mainForm = this;
        }

        /// <summary>
        /// Metodă ce incarcă in MainForm alte form-uri
        /// </summary>
        /// <param name="Form">Form-ul ce va fii incărcat</param>
        public void loadForm(object Form)
        {
            if(this.mainpanel.Controls.Count > 0)
                mainpanel.Controls.Clear();
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Buton de start - Încarcă primul form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            loadForm(new SelectForm());
        }


        /// <summary>
        /// Buton de exit - închide aplicația
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Buton de help - deschide help-ul asociat aplicației
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("miniContabilHelp.chm");
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    /// <summary>
    /// Clasă statică ce genstionează form-ul
    /// </summary>
    public static class FormManager
    {
        public static MainForm mainForm { get; set; }
        public static IFirmBuilder builder;
    }
}
