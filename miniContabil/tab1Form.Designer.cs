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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLifeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmortizari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmortizare)).BeginInit();
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
            this.dataGridViewAmortizari.Size = new System.Drawing.Size(590, 233);
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
            // tab1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 633);
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
    }
}