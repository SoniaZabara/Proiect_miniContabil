using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniContabil
{
    public partial class tabSalariiForm : Form
    {
        public tabSalariiForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int n= dataGridView1.Rows.Add();

            
            dataGridView1.Rows[n].Cells[0].Value = textBoxId.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBoxNumeAngajat.Text;
            dataGridView1.Rows[n].Cells[2].Value = textBoxFunctie.Text;
            dataGridView1.Rows[n].Cells[3].Value = textBoxSalariuBrut.Text;
            dataGridView1.Rows[n].Cells[4].Value = textBoxDepartament.Text;
        }
    }
}
