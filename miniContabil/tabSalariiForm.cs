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
        private int _index;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _index = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[_index];

            textBoxId.Text = row.Cells[0].Value.ToString();
            textBoxNumeAngajat.Text = row.Cells[1].Value.ToString();
            textBoxFunctie.Text = row.Cells[2].Value.ToString();
            textBoxSalariuBrut.Text = row.Cells[3].Value.ToString();
            textBoxDepartament.Text = row.Cells[4].Value.ToString();

        }
    }
}
