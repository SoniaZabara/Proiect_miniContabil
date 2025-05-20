/**************************************************************************
 *                                                                        *
 *  File:        SelectForm.cs                                            *
 *  Copyright:   (c) 2025, Sonia Zabara                                   *
 *  E-mail:      sonia.zabara@student.tuiasi.ro                           *
 *  Description: Windows Forms UI for choosing the name and type of       *
 *               firm.                                                    *
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
using System.Collections.Specialized;
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
    /// Clasă pentru form-ul ce face selecția numelui și tipului firmei
    /// </summary>
    public partial class SelectForm : Form
    {
        /// <summary>
        /// Metodă ce inițializează SelectForm
        /// </summary>
        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Buton de next - se merge la următorul form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNext1_Click(object sender, EventArgs e)
        {
            if (FormManager.builder == null || bigTextBox1.Text == "")
            {
                MessageBox.Show("Va rugam completati campurile", "!!ATENTIE!!");
            }
            else
            {
                FormManager.mainForm.loadForm(new DataForm());
            }
        }

        /// <summary>
        /// Metodă ce setează numele firmei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(FormManager.builder != null)
                FormManager.builder.SetName(bigTextBox1.Text);
        }

        /// <summary>
        /// metodă ce setează tipul firmei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void poisonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(poisonComboBox1.SelectedIndex == 0) //"Societate cu Răspundere Limitată"
            {
                FormManager.builder = new SRLBuilder(); 
            }
            else if (poisonComboBox1.SelectedIndex == 1) //"Persoană Fizica Autorizată"
            {
                FormManager.builder = new PFABuilder();
            }
            else if (poisonComboBox1.SelectedIndex == 2) //"Societate pe acțiuni"
            {
                FormManager.builder = new SABuilder();
            }

            if (poisonComboBox1.SelectedIndex != -1 && FormManager.builder != null)
                FormManager.builder.SetName(bigTextBox1.Text);
        }

        /// <summary>
        /// Metodă ce inițializează form-ul cu câteva valori deja definite
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectForm_Load(object sender, EventArgs e)
        {
            if (FormManager.builder == null)
            {
                bigTextBox1.Text = "Bilibic";
                poisonComboBox1.SelectedIndex = 0;
            }
            else
            {
                bigTextBox1.Text = FormManager.builder.GetResult().GetName();
                poisonComboBox1.SelectedIndex = (int)FormManager.builder.GetResult().GetFirmType();
            }
        }
    }
}
