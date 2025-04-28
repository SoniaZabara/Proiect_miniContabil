namespace miniContabil
{
    partial class tabSalariiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMadeBy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nume_Angajat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Functie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salariu_Brut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNumeAngajat = new System.Windows.Forms.TextBox();
            this.textBoxFunctie = new System.Windows.Forms.TextBox();
            this.textBoxSalariuBrut = new System.Windows.Forms.TextBox();
            this.textBoxDepartament = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMadeBy
            // 
            this.labelMadeBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMadeBy.AutoSize = true;
            this.labelMadeBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMadeBy.Location = new System.Drawing.Point(12, 9);
            this.labelMadeBy.Name = "labelMadeBy";
            this.labelMadeBy.Size = new System.Drawing.Size(261, 36);
            this.labelMadeBy.TabIndex = 3;
            this.labelMadeBy.Text = "Salarii si Anagajati";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDepartament);
            this.groupBox1.Controls.Add(this.textBoxSalariuBrut);
            this.groupBox1.Controls.Add(this.textBoxFunctie);
            this.groupBox1.Controls.Add(this.textBoxNumeAngajat);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(18, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 319);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nume_Angajat,
            this.Functie,
            this.Salariu_Brut,
            this.Departament});
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(856, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(868, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adauga angajat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Nume_Angajat
            // 
            this.Nume_Angajat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nume_Angajat.HeaderText = "Nume_Angajat";
            this.Nume_Angajat.MinimumWidth = 6;
            this.Nume_Angajat.Name = "Nume_Angajat";
            // 
            // Functie
            // 
            this.Functie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Functie.HeaderText = "Functie";
            this.Functie.MinimumWidth = 6;
            this.Functie.Name = "Functie";
            // 
            // Salariu_Brut
            // 
            this.Salariu_Brut.HeaderText = "Salariu_Brut";
            this.Salariu_Brut.MinimumWidth = 6;
            this.Salariu_Brut.Name = "Salariu_Brut";
            this.Salariu_Brut.Width = 125;
            // 
            // Departament
            // 
            this.Departament.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departament.HeaderText = "Departament";
            this.Departament.MinimumWidth = 6;
            this.Departament.Name = "Departament";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(7, 291);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(130, 22);
            this.textBoxId.TabIndex = 2;
            // 
            // textBoxNumeAngajat
            // 
            this.textBoxNumeAngajat.Location = new System.Drawing.Point(143, 291);
            this.textBoxNumeAngajat.Name = "textBoxNumeAngajat";
            this.textBoxNumeAngajat.Size = new System.Drawing.Size(192, 22);
            this.textBoxNumeAngajat.TabIndex = 3;
            // 
            // textBoxFunctie
            // 
            this.textBoxFunctie.Location = new System.Drawing.Point(341, 291);
            this.textBoxFunctie.Name = "textBoxFunctie";
            this.textBoxFunctie.Size = new System.Drawing.Size(193, 22);
            this.textBoxFunctie.TabIndex = 4;
            // 
            // textBoxSalariuBrut
            // 
            this.textBoxSalariuBrut.Location = new System.Drawing.Point(540, 291);
            this.textBoxSalariuBrut.Name = "textBoxSalariuBrut";
            this.textBoxSalariuBrut.Size = new System.Drawing.Size(122, 22);
            this.textBoxSalariuBrut.TabIndex = 5;
            // 
            // textBoxDepartament
            // 
            this.textBoxDepartament.Location = new System.Drawing.Point(668, 291);
            this.textBoxDepartament.Name = "textBoxDepartament";
            this.textBoxDepartament.Size = new System.Drawing.Size(194, 22);
            this.textBoxDepartament.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nume Angajat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Functie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(537, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salariu Brut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Departament";
            // 
            // tabSalariiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 586);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelMadeBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tabSalariiForm";
            this.Text = "tabSalariiForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMadeBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume_Angajat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Functie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salariu_Brut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departament;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDepartament;
        private System.Windows.Forms.TextBox textBoxSalariuBrut;
        private System.Windows.Forms.TextBox textBoxFunctie;
        private System.Windows.Forms.TextBox textBoxNumeAngajat;
        private System.Windows.Forms.TextBox textBoxId;
    }
}