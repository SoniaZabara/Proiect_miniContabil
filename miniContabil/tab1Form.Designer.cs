namespace miniContabil
{
    partial class tab1Form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelInitialValue = new System.Windows.Forms.Label();
            this.labelLifeTime = new System.Windows.Forms.Label();
            this.labelRezidualValue = new System.Windows.Forms.Label();
            this.labelAmortizare = new System.Windows.Forms.Label();
            this.textBoxInitialValue = new System.Windows.Forms.TextBox();
            this.textBoxRezidualValue = new System.Windows.Forms.TextBox();
            this.numericUpDownLifeTime = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAmortizare = new System.Windows.Forms.ComboBox();
            this.dataGridViewAmortizari = new System.Windows.Forms.DataGridView();
            this.buttonCalcAmortizare = new System.Windows.Forms.Button();
            this.chartAmortizare = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxDividente = new System.Windows.Forms.GroupBox();
            this.textBoxDivident = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericProcent = new System.Windows.Forms.NumericUpDown();
            this.textBoxProfitTotal = new System.Windows.Forms.TextBox();
            this.textBoxSalariiTotal = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.textBoxAmortizareTotala = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLifeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmortizari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmortizare)).BeginInit();
            this.groupBoxDividente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericProcent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInitialValue
            // 
            this.labelInitialValue.AutoSize = true;
            this.labelInitialValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitialValue.Location = new System.Drawing.Point(53, 67);
            this.labelInitialValue.Name = "labelInitialValue";
            this.labelInitialValue.Size = new System.Drawing.Size(124, 16);
            this.labelInitialValue.TabIndex = 0;
            this.labelInitialValue.Text = "Valoare initiala : ";
            this.labelInitialValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLifeTime
            // 
            this.labelLifeTime.AutoSize = true;
            this.labelLifeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLifeTime.Location = new System.Drawing.Point(53, 110);
            this.labelLifeTime.Name = "labelLifeTime";
            this.labelLifeTime.Size = new System.Drawing.Size(121, 16);
            this.labelLifeTime.TabIndex = 1;
            this.labelLifeTime.Text = "Durata de viata: ";
            // 
            // labelRezidualValue
            // 
            this.labelRezidualValue.AutoSize = true;
            this.labelRezidualValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRezidualValue.Location = new System.Drawing.Point(53, 161);
            this.labelRezidualValue.Name = "labelRezidualValue";
            this.labelRezidualValue.Size = new System.Drawing.Size(138, 16);
            this.labelRezidualValue.TabIndex = 2;
            this.labelRezidualValue.Text = "Valoare reziduala: ";
            // 
            // labelAmortizare
            // 
            this.labelAmortizare.AutoSize = true;
            this.labelAmortizare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmortizare.Location = new System.Drawing.Point(53, 208);
            this.labelAmortizare.Name = "labelAmortizare";
            this.labelAmortizare.Size = new System.Drawing.Size(81, 16);
            this.labelAmortizare.TabIndex = 3;
            this.labelAmortizare.Text = "Amortizare";
            // 
            // textBoxInitialValue
            // 
            this.textBoxInitialValue.Location = new System.Drawing.Point(226, 64);
            this.textBoxInitialValue.Name = "textBoxInitialValue";
            this.textBoxInitialValue.Size = new System.Drawing.Size(121, 22);
            this.textBoxInitialValue.TabIndex = 4;
            // 
            // textBoxRezidualValue
            // 
            this.textBoxRezidualValue.Location = new System.Drawing.Point(226, 155);
            this.textBoxRezidualValue.Name = "textBoxRezidualValue";
            this.textBoxRezidualValue.Size = new System.Drawing.Size(120, 22);
            this.textBoxRezidualValue.TabIndex = 5;
            // 
            // numericUpDownLifeTime
            // 
            this.numericUpDownLifeTime.Location = new System.Drawing.Point(226, 108);
            this.numericUpDownLifeTime.Name = "numericUpDownLifeTime";
            this.numericUpDownLifeTime.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLifeTime.TabIndex = 6;
            // 
            // comboBoxAmortizare
            // 
            this.comboBoxAmortizare.FormattingEnabled = true;
            this.comboBoxAmortizare.Items.AddRange(new object[] {
            "Liniara",
            "Progresiva",
            "Degresiva (Accentuata)"});
            this.comboBoxAmortizare.Location = new System.Drawing.Point(226, 200);
            this.comboBoxAmortizare.Name = "comboBoxAmortizare";
            this.comboBoxAmortizare.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAmortizare.TabIndex = 7;
            // 
            // dataGridViewAmortizari
            // 
            this.dataGridViewAmortizari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAmortizari.Location = new System.Drawing.Point(393, 64);
            this.dataGridViewAmortizari.Name = "dataGridViewAmortizari";
            this.dataGridViewAmortizari.RowHeadersWidth = 51;
            this.dataGridViewAmortizari.RowTemplate.Height = 24;
            this.dataGridViewAmortizari.Size = new System.Drawing.Size(614, 233);
            this.dataGridViewAmortizari.TabIndex = 8;
            // 
            // buttonCalcAmortizare
            // 
            this.buttonCalcAmortizare.Location = new System.Drawing.Point(56, 248);
            this.buttonCalcAmortizare.Name = "buttonCalcAmortizare";
            this.buttonCalcAmortizare.Size = new System.Drawing.Size(291, 31);
            this.buttonCalcAmortizare.TabIndex = 9;
            this.buttonCalcAmortizare.Text = "Calculeaza";
            this.buttonCalcAmortizare.UseVisualStyleBackColor = true;
            this.buttonCalcAmortizare.Click += new System.EventHandler(this.buttonCalcAmortizare_Click);
            // 
            // chartAmortizare
            // 
            this.chartAmortizare.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartAmortizare.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAmortizare.Legends.Add(legend2);
            this.chartAmortizare.Location = new System.Drawing.Point(-8, 303);
            this.chartAmortizare.Name = "chartAmortizare";
            this.chartAmortizare.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAmortizare.Series.Add(series2);
            this.chartAmortizare.Size = new System.Drawing.Size(577, 245);
            this.chartAmortizare.TabIndex = 10;
            this.chartAmortizare.Text = "chartAmortizare";
            // 
            // groupBoxDividente
            // 
            this.groupBoxDividente.Controls.Add(this.textBoxDivident);
            this.groupBoxDividente.Controls.Add(this.label4);
            this.groupBoxDividente.Controls.Add(this.label3);
            this.groupBoxDividente.Controls.Add(this.label2);
            this.groupBoxDividente.Controls.Add(this.label1);
            this.groupBoxDividente.Controls.Add(this.numericProcent);
            this.groupBoxDividente.Controls.Add(this.textBoxProfitTotal);
            this.groupBoxDividente.Controls.Add(this.textBoxSalariiTotal);
            this.groupBoxDividente.Controls.Add(this.buttonCalc);
            this.groupBoxDividente.Controls.Add(this.textBoxAmortizareTotala);
            this.groupBoxDividente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDividente.Location = new System.Drawing.Point(562, 322);
            this.groupBoxDividente.Name = "groupBoxDividente";
            this.groupBoxDividente.Size = new System.Drawing.Size(445, 288);
            this.groupBoxDividente.TabIndex = 11;
            this.groupBoxDividente.TabStop = false;
            this.groupBoxDividente.Text = "Calcul Dividente";
            // 
            // textBoxDivident
            // 
            this.textBoxDivident.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDivident.Location = new System.Drawing.Point(251, 166);
            this.textBoxDivident.Name = "textBoxDivident";
            this.textBoxDivident.ReadOnly = true;
            this.textBoxDivident.Size = new System.Drawing.Size(145, 26);
            this.textBoxDivident.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Profit redistribuit (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Profit total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Salarii total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Amortizare totala";
            // 
            // numericProcent
            // 
            this.numericProcent.Location = new System.Drawing.Point(42, 237);
            this.numericProcent.Name = "numericProcent";
            this.numericProcent.Size = new System.Drawing.Size(100, 26);
            this.numericProcent.TabIndex = 23;
            // 
            // textBoxProfitTotal
            // 
            this.textBoxProfitTotal.Location = new System.Drawing.Point(42, 177);
            this.textBoxProfitTotal.Name = "textBoxProfitTotal";
            this.textBoxProfitTotal.Size = new System.Drawing.Size(100, 26);
            this.textBoxProfitTotal.TabIndex = 22;
            // 
            // textBoxSalariiTotal
            // 
            this.textBoxSalariiTotal.Location = new System.Drawing.Point(42, 123);
            this.textBoxSalariiTotal.Name = "textBoxSalariiTotal";
            this.textBoxSalariiTotal.Size = new System.Drawing.Size(100, 26);
            this.textBoxSalariiTotal.TabIndex = 21;
            // 
            // buttonCalc
            // 
            this.buttonCalc.ForeColor = System.Drawing.Color.Black;
            this.buttonCalc.Location = new System.Drawing.Point(251, 102);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(145, 38);
            this.buttonCalc.TabIndex = 20;
            this.buttonCalc.Text = "Calculează";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // textBoxAmortizareTotala
            // 
            this.textBoxAmortizareTotala.Location = new System.Drawing.Point(42, 62);
            this.textBoxAmortizareTotala.Name = "textBoxAmortizareTotala";
            this.textBoxAmortizareTotala.Size = new System.Drawing.Size(100, 26);
            this.textBoxAmortizareTotala.TabIndex = 0;
            // 
            // tab1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 633);
            this.Controls.Add(this.groupBoxDividente);
            this.Controls.Add(this.chartAmortizare);
            this.Controls.Add(this.buttonCalcAmortizare);
            this.Controls.Add(this.dataGridViewAmortizari);
            this.Controls.Add(this.comboBoxAmortizare);
            this.Controls.Add(this.numericUpDownLifeTime);
            this.Controls.Add(this.textBoxRezidualValue);
            this.Controls.Add(this.textBoxInitialValue);
            this.Controls.Add(this.labelAmortizare);
            this.Controls.Add(this.labelRezidualValue);
            this.Controls.Add(this.labelLifeTime);
            this.Controls.Add(this.labelInitialValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tab1Form";
            this.Text = "tab1Form";
            this.Load += new System.EventHandler(this.tab1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLifeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmortizari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmortizare)).EndInit();
            this.groupBoxDividente.ResumeLayout(false);
            this.groupBoxDividente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericProcent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInitialValue;
        private System.Windows.Forms.Label labelLifeTime;
        private System.Windows.Forms.Label labelRezidualValue;
        private System.Windows.Forms.Label labelAmortizare;
        private System.Windows.Forms.TextBox textBoxInitialValue;
        private System.Windows.Forms.TextBox textBoxRezidualValue;
        private System.Windows.Forms.NumericUpDown numericUpDownLifeTime;
        private System.Windows.Forms.ComboBox comboBoxAmortizare;
        private System.Windows.Forms.DataGridView dataGridViewAmortizari;
        private System.Windows.Forms.Button buttonCalcAmortizare;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAmortizare;
        private System.Windows.Forms.GroupBox groupBoxDividente;
        private System.Windows.Forms.TextBox textBoxAmortizareTotala;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.TextBox textBoxProfitTotal;
        private System.Windows.Forms.TextBox textBoxSalariiTotal;
        private System.Windows.Forms.NumericUpDown numericProcent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDivident;
    }
}