namespace miniContabil
{
    partial class selectForm
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
            this.labelNumeSocietate = new System.Windows.Forms.Label();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.labelTipSocietate = new System.Windows.Forms.Label();
            this.poisonComboBox1 = new ReaLTaiizor.Controls.PoisonComboBox();
            this.bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            this.pictureBoxDecor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecor)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumeSocietate
            // 
            this.labelNumeSocietate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNumeSocietate.AutoSize = true;
            this.labelNumeSocietate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeSocietate.Location = new System.Drawing.Point(58, 134);
            this.labelNumeSocietate.Name = "labelNumeSocietate";
            this.labelNumeSocietate.Size = new System.Drawing.Size(195, 29);
            this.labelNumeSocietate.TabIndex = 0;
            this.labelNumeSocietate.Text = "Nume societate";
            // 
            // buttonNext1
            // 
            this.buttonNext1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNext1.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext1.Location = new System.Drawing.Point(1124, 579);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(85, 40);
            this.buttonNext1.TabIndex = 1;
            this.buttonNext1.Text = ">";
            this.buttonNext1.UseVisualStyleBackColor = false;
            this.buttonNext1.Click += new System.EventHandler(this.buttonNext1_Click);
            // 
            // labelTipSocietate
            // 
            this.labelTipSocietate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTipSocietate.AutoSize = true;
            this.labelTipSocietate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipSocietate.Location = new System.Drawing.Point(58, 283);
            this.labelTipSocietate.Name = "labelTipSocietate";
            this.labelTipSocietate.Size = new System.Drawing.Size(165, 29);
            this.labelTipSocietate.TabIndex = 2;
            this.labelTipSocietate.Text = "Tip societate";
            // 
            // poisonComboBox1
            // 
            this.poisonComboBox1.FormattingEnabled = true;
            this.poisonComboBox1.ItemHeight = 24;
            this.poisonComboBox1.Items.AddRange(new object[] {
            "Societate cu Răspundere Limitată",
            "Persoană Fizica Autorizată",
            "Societate pe acțiuni"});
            this.poisonComboBox1.Location = new System.Drawing.Point(63, 333);
            this.poisonComboBox1.Name = "poisonComboBox1";
            this.poisonComboBox1.Size = new System.Drawing.Size(323, 30);
            this.poisonComboBox1.TabIndex = 10;
            this.poisonComboBox1.UseSelectable = true;
            this.poisonComboBox1.SelectedIndexChanged += new System.EventHandler(this.poisonComboBox1_SelectedIndexChanged);
            // 
            // bigTextBox1
            // 
            this.bigTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bigTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bigTextBox1.ForeColor = System.Drawing.Color.Black;
            this.bigTextBox1.Image = null;
            this.bigTextBox1.Location = new System.Drawing.Point(63, 177);
            this.bigTextBox1.MaxLength = 32767;
            this.bigTextBox1.Multiline = false;
            this.bigTextBox1.Name = "bigTextBox1";
            this.bigTextBox1.ReadOnly = false;
            this.bigTextBox1.Size = new System.Drawing.Size(358, 40);
            this.bigTextBox1.TabIndex = 11;
            this.bigTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bigTextBox1.UseSystemPasswordChar = false;
            this.bigTextBox1.TextChanged += new System.EventHandler(this.bigTextBox1_TextChanged);
            // 
            // pictureBoxDecor
            // 
            this.pictureBoxDecor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDecor.BackgroundImage = global::miniContabil.Properties.Resources.bad445eaa91b27cd07d416aa6edf9516_removebg_preview;
            this.pictureBoxDecor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxDecor.Location = new System.Drawing.Point(541, 56);
            this.pictureBoxDecor.Name = "pictureBoxDecor";
            this.pictureBoxDecor.Size = new System.Drawing.Size(640, 505);
            this.pictureBoxDecor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDecor.TabIndex = 12;
            this.pictureBoxDecor.TabStop = false;
            // 
            // selectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1280, 680);
            this.Controls.Add(this.pictureBoxDecor);
            this.Controls.Add(this.bigTextBox1);
            this.Controls.Add(this.poisonComboBox1);
            this.Controls.Add(this.labelTipSocietate);
            this.Controls.Add(this.buttonNext1);
            this.Controls.Add(this.labelNumeSocietate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "selectForm";
            this.Text = "selectForm";
            this.Load += new System.EventHandler(this.selectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDecor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumeSocietate;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.Label labelTipSocietate;
        private ReaLTaiizor.Controls.PoisonComboBox poisonComboBox1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private System.Windows.Forms.PictureBox pictureBoxDecor;
    }
}