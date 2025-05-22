namespace MiniContaBill
{
    partial class DataForm
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
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.buttonPrev2 = new System.Windows.Forms.Button();
            this.labelAtribute = new System.Windows.Forms.Label();
            this.labelCA = new System.Windows.Forms.Label();
            this.labelCF = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.labelNrAct = new System.Windows.Forms.Label();
            this.labelValAct = new System.Windows.Forms.Label();
            this.textBoxCA = new System.Windows.Forms.TextBox();
            this.textBoxCF = new System.Windows.Forms.TextBox();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.textBoxNrAct = new System.Windows.Forms.TextBox();
            this.textBoxValAct = new System.Windows.Forms.TextBox();
            this.labelDatorii = new System.Windows.Forms.Label();
            this.textBoxDatorii = new System.Windows.Forms.TextBox();
            this.labelFirma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNext2
            // 
            this.buttonNext2.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext2.Location = new System.Drawing.Point(1118, 579);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(85, 40);
            this.buttonNext2.TabIndex = 1;
            this.buttonNext2.Text = ">";
            this.buttonNext2.UseVisualStyleBackColor = false;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext2_Click);
            // 
            // buttonPrev2
            // 
            this.buttonPrev2.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrev2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev2.Location = new System.Drawing.Point(81, 579);
            this.buttonPrev2.Name = "buttonPrev2";
            this.buttonPrev2.Size = new System.Drawing.Size(85, 40);
            this.buttonPrev2.TabIndex = 2;
            this.buttonPrev2.Text = "<";
            this.buttonPrev2.UseVisualStyleBackColor = false;
            this.buttonPrev2.Click += new System.EventHandler(this.buttonPrev2_Click);
            // 
            // labelAtribute
            // 
            this.labelAtribute.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAtribute.AutoSize = true;
            this.labelAtribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAtribute.Location = new System.Drawing.Point(84, 162);
            this.labelAtribute.Name = "labelAtribute";
            this.labelAtribute.Size = new System.Drawing.Size(216, 29);
            this.labelAtribute.TabIndex = 3;
            this.labelAtribute.Text = "Atribute societate";
            // 
            // labelCA
            // 
            this.labelCA.AutoSize = true;
            this.labelCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCA.Location = new System.Drawing.Point(87, 227);
            this.labelCA.Name = "labelCA";
            this.labelCA.Size = new System.Drawing.Size(117, 16);
            this.labelCA.TabIndex = 4;
            this.labelCA.Text = "Cifra de afaceri:";
            // 
            // labelCF
            // 
            this.labelCF.AutoSize = true;
            this.labelCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCF.Location = new System.Drawing.Point(87, 298);
            this.labelCF.Name = "labelCF";
            this.labelCF.Size = new System.Drawing.Size(79, 16);
            this.labelCF.TabIndex = 5;
            this.labelCF.Text = "Capital fix:";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCC.Location = new System.Drawing.Point(87, 375);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(122, 16);
            this.labelCC.TabIndex = 6;
            this.labelCC.Text = "Capital circulant:";
            // 
            // labelNrAct
            // 
            this.labelNrAct.AutoSize = true;
            this.labelNrAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNrAct.Location = new System.Drawing.Point(87, 442);
            this.labelNrAct.Name = "labelNrAct";
            this.labelNrAct.Size = new System.Drawing.Size(105, 16);
            this.labelNrAct.TabIndex = 7;
            this.labelNrAct.Text = "Numar actiuni:";
            // 
            // labelValAct
            // 
            this.labelValAct.AutoSize = true;
            this.labelValAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValAct.Location = new System.Drawing.Point(416, 298);
            this.labelValAct.Name = "labelValAct";
            this.labelValAct.Size = new System.Drawing.Size(115, 16);
            this.labelValAct.TabIndex = 8;
            this.labelValAct.Text = "Valoare actiuni:";
            // 
            // textBoxCA
            // 
            this.textBoxCA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxCA.Location = new System.Drawing.Point(90, 258);
            this.textBoxCA.Name = "textBoxCA";
            this.textBoxCA.Size = new System.Drawing.Size(172, 22);
            this.textBoxCA.TabIndex = 15;
            this.textBoxCA.TextChanged += new System.EventHandler(this.textBoxCA_TextChanged);
            // 
            // textBoxCF
            // 
            this.textBoxCF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxCF.Location = new System.Drawing.Point(90, 327);
            this.textBoxCF.Name = "textBoxCF";
            this.textBoxCF.Size = new System.Drawing.Size(172, 22);
            this.textBoxCF.TabIndex = 16;
            this.textBoxCF.TextChanged += new System.EventHandler(this.textBoxCF_TextChanged);
            // 
            // textBoxCC
            // 
            this.textBoxCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxCC.Location = new System.Drawing.Point(90, 401);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.Size = new System.Drawing.Size(172, 22);
            this.textBoxCC.TabIndex = 17;
            this.textBoxCC.TextChanged += new System.EventHandler(this.textBoxCC_TextChanged);
            // 
            // textBoxNrAct
            // 
            this.textBoxNrAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNrAct.Location = new System.Drawing.Point(90, 473);
            this.textBoxNrAct.Name = "textBoxNrAct";
            this.textBoxNrAct.Size = new System.Drawing.Size(172, 22);
            this.textBoxNrAct.TabIndex = 18;
            this.textBoxNrAct.TextChanged += new System.EventHandler(this.textBoxNrAct_TextChanged);
            // 
            // textBoxValAct
            // 
            this.textBoxValAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxValAct.Location = new System.Drawing.Point(419, 327);
            this.textBoxValAct.Name = "textBoxValAct";
            this.textBoxValAct.Size = new System.Drawing.Size(172, 22);
            this.textBoxValAct.TabIndex = 19;
            this.textBoxValAct.TextChanged += new System.EventHandler(this.textBoxValAct_TextChanged);
            // 
            // labelDatorii
            // 
            this.labelDatorii.AutoSize = true;
            this.labelDatorii.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDatorii.Location = new System.Drawing.Point(416, 401);
            this.labelDatorii.Name = "labelDatorii";
            this.labelDatorii.Size = new System.Drawing.Size(57, 16);
            this.labelDatorii.TabIndex = 20;
            this.labelDatorii.Text = "Datorii:";
            // 
            // textBoxDatorii
            // 
            this.textBoxDatorii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxDatorii.Location = new System.Drawing.Point(419, 423);
            this.textBoxDatorii.Name = "textBoxDatorii";
            this.textBoxDatorii.Size = new System.Drawing.Size(172, 22);
            this.textBoxDatorii.TabIndex = 21;
            this.textBoxDatorii.TextChanged += new System.EventHandler(this.textBoxDatorii_TextChanged);
            // 
            // labelFirma
            // 
            this.labelFirma.AutoSize = true;
            this.labelFirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirma.Location = new System.Drawing.Point(81, 85);
            this.labelFirma.Name = "labelFirma";
            this.labelFirma.Size = new System.Drawing.Size(177, 42);
            this.labelFirma.TabIndex = 14;
            this.labelFirma.Text = "labelTitlu";
            // 
            // dataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiniContaBill.Properties.Resources.Screenshot_2025_05_11_203409_removebg_preview;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.textBoxDatorii);
            this.Controls.Add(this.labelDatorii);
            this.Controls.Add(this.textBoxValAct);
            this.Controls.Add(this.textBoxNrAct);
            this.Controls.Add(this.textBoxCC);
            this.Controls.Add(this.textBoxCF);
            this.Controls.Add(this.textBoxCA);
            this.Controls.Add(this.labelFirma);
            this.Controls.Add(this.labelValAct);
            this.Controls.Add(this.labelNrAct);
            this.Controls.Add(this.labelCC);
            this.Controls.Add(this.labelCF);
            this.Controls.Add(this.labelCA);
            this.Controls.Add(this.labelAtribute);
            this.Controls.Add(this.buttonPrev2);
            this.Controls.Add(this.buttonNext2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dataForm";
            this.Text = "dataForm";
            this.Load += new System.EventHandler(this.dataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Button buttonPrev2;
        private System.Windows.Forms.Label labelAtribute;
        private System.Windows.Forms.Label labelCA;
        private System.Windows.Forms.Label labelCF;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Label labelNrAct;
        private System.Windows.Forms.Label labelValAct;
        private System.Windows.Forms.TextBox textBoxCA;
        private System.Windows.Forms.TextBox textBoxCF;
        private System.Windows.Forms.TextBox textBoxCC;
        private System.Windows.Forms.TextBox textBoxNrAct;
        private System.Windows.Forms.TextBox textBoxValAct;
        private System.Windows.Forms.Label labelDatorii;
        private System.Windows.Forms.TextBox textBoxDatorii;
        private System.Windows.Forms.Label labelFirma;
    }
}