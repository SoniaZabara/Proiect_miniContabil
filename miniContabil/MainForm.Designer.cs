namespace miniContabil
{
    partial class MainForm
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
            this.panelheader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.labelNume4 = new System.Windows.Forms.Label();
            this.labelNume3 = new System.Windows.Forms.Label();
            this.labelNume2 = new System.Windows.Forms.Label();
            this.labelNume1 = new System.Windows.Forms.Label();
            this.labelMadeBy = new System.Windows.Forms.Label();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelheader.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Gray;
            this.panelheader.Controls.Add(this.labelHeader);
            this.panelheader.Controls.Add(this.buttonHelp);
            this.panelheader.Controls.Add(this.buttonClose);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1280, 40);
            this.panelheader.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(12, 12);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(108, 20);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "miniContaBill";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(1124, 0);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 40);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(1205, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 40);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mainpanel.Controls.Add(this.labelNume4);
            this.mainpanel.Controls.Add(this.labelNume3);
            this.mainpanel.Controls.Add(this.labelNume2);
            this.mainpanel.Controls.Add(this.labelNume1);
            this.mainpanel.Controls.Add(this.labelMadeBy);
            this.mainpanel.Controls.Add(this.labelTitlu);
            this.mainpanel.Controls.Add(this.buttonStart);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 40);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1280, 680);
            this.mainpanel.TabIndex = 1;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // labelNume4
            // 
            this.labelNume4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNume4.AutoSize = true;
            this.labelNume4.BackColor = System.Drawing.Color.Transparent;
            this.labelNume4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.labelNume4.Location = new System.Drawing.Point(39, 425);
            this.labelNume4.Name = "labelNume4";
            this.labelNume4.Size = new System.Drawing.Size(119, 20);
            this.labelNume4.TabIndex = 6;
            this.labelNume4.Text = "Sonia Zabara";
            // 
            // labelNume3
            // 
            this.labelNume3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNume3.AutoSize = true;
            this.labelNume3.BackColor = System.Drawing.Color.Transparent;
            this.labelNume3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelNume3.Location = new System.Drawing.Point(39, 381);
            this.labelNume3.Name = "labelNume3";
            this.labelNume3.Size = new System.Drawing.Size(124, 20);
            this.labelNume3.TabIndex = 5;
            this.labelNume3.Text = "Petru Negoita";
            // 
            // labelNume2
            // 
            this.labelNume2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNume2.AutoSize = true;
            this.labelNume2.BackColor = System.Drawing.Color.Transparent;
            this.labelNume2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume2.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelNume2.Location = new System.Drawing.Point(39, 335);
            this.labelNume2.Name = "labelNume2";
            this.labelNume2.Size = new System.Drawing.Size(131, 20);
            this.labelNume2.TabIndex = 4;
            this.labelNume2.Text = "Silviu Chiuariu";
            // 
            // labelNume1
            // 
            this.labelNume1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNume1.AutoSize = true;
            this.labelNume1.BackColor = System.Drawing.Color.Transparent;
            this.labelNume1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNume1.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.labelNume1.Location = new System.Drawing.Point(39, 290);
            this.labelNume1.Name = "labelNume1";
            this.labelNume1.Size = new System.Drawing.Size(175, 20);
            this.labelNume1.TabIndex = 3;
            this.labelNume1.Text = "Ioana Andreea Bran";
            // 
            // labelMadeBy
            // 
            this.labelMadeBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMadeBy.AutoSize = true;
            this.labelMadeBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMadeBy.Location = new System.Drawing.Point(101, 324);
            this.labelMadeBy.Name = "labelMadeBy";
            this.labelMadeBy.Size = new System.Drawing.Size(0, 36);
            this.labelMadeBy.TabIndex = 2;
            // 
            // labelTitlu
            // 
            this.labelTitlu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.BackColor = System.Drawing.Color.Transparent;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelTitlu.Location = new System.Drawing.Point(378, 104);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(382, 69);
            this.labelTitlu.TabIndex = 1;
            this.labelTitlu.Text = "MiniContaBill";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(1152, 582);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(85, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            this.mainpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.Label labelNume4;
        private System.Windows.Forms.Label labelNume3;
        private System.Windows.Forms.Label labelNume2;
        private System.Windows.Forms.Label labelNume1;
        private System.Windows.Forms.Label labelMadeBy;
    }
}

