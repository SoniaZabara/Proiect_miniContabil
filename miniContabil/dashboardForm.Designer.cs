namespace miniContabil
{
    partial class dashboardForm
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
            this.dashboardSidepanel = new System.Windows.Forms.Panel();
            this.buttonTab3 = new System.Windows.Forms.Button();
            this.buttonTab2 = new System.Windows.Forms.Button();
            this.buttonTab1 = new System.Windows.Forms.Button();
            this.buttonPrev3 = new System.Windows.Forms.Button();
            this.dashboardMainpanel = new System.Windows.Forms.Panel();
            this.dashboardSidepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboardSidepanel
            // 
            this.dashboardSidepanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dashboardSidepanel.Controls.Add(this.buttonTab3);
            this.dashboardSidepanel.Controls.Add(this.buttonTab2);
            this.dashboardSidepanel.Controls.Add(this.buttonTab1);
            this.dashboardSidepanel.Controls.Add(this.buttonPrev3);
            this.dashboardSidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardSidepanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardSidepanel.Name = "dashboardSidepanel";
            this.dashboardSidepanel.Size = new System.Drawing.Size(200, 633);
            this.dashboardSidepanel.TabIndex = 0;
            // 
            // buttonTab3
            // 
            this.buttonTab3.FlatAppearance.BorderSize = 0;
            this.buttonTab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTab3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab3.ForeColor = System.Drawing.Color.White;
            this.buttonTab3.Location = new System.Drawing.Point(0, 327);
            this.buttonTab3.Name = "buttonTab3";
            this.buttonTab3.Size = new System.Drawing.Size(200, 50);
            this.buttonTab3.TabIndex = 3;
            this.buttonTab3.Text = "Cerere oferta";
            this.buttonTab3.UseVisualStyleBackColor = true;
            this.buttonTab3.Click += new System.EventHandler(this.buttonTab3_Click);
            // 
            // buttonTab2
            // 
            this.buttonTab2.FlatAppearance.BorderSize = 0;
            this.buttonTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTab2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab2.ForeColor = System.Drawing.Color.White;
            this.buttonTab2.Location = new System.Drawing.Point(0, 271);
            this.buttonTab2.Name = "buttonTab2";
            this.buttonTab2.Size = new System.Drawing.Size(200, 50);
            this.buttonTab2.TabIndex = 2;
            this.buttonTab2.Text = "Cost productie profit";
            this.buttonTab2.UseVisualStyleBackColor = true;
            this.buttonTab2.Click += new System.EventHandler(this.buttonTab2_Click);
            // 
            // buttonTab1
            // 
            this.buttonTab1.FlatAppearance.BorderSize = 0;
            this.buttonTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTab1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTab1.ForeColor = System.Drawing.Color.White;
            this.buttonTab1.Location = new System.Drawing.Point(0, 215);
            this.buttonTab1.Name = "buttonTab1";
            this.buttonTab1.Size = new System.Drawing.Size(200, 50);
            this.buttonTab1.TabIndex = 1;
            this.buttonTab1.Text = "Capital";
            this.buttonTab1.UseVisualStyleBackColor = true;
            this.buttonTab1.Click += new System.EventHandler(this.buttonTab1_Click);
            // 
            // buttonPrev3
            // 
            this.buttonPrev3.FlatAppearance.BorderSize = 0;
            this.buttonPrev3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev3.ForeColor = System.Drawing.Color.White;
            this.buttonPrev3.Location = new System.Drawing.Point(0, 159);
            this.buttonPrev3.Name = "buttonPrev3";
            this.buttonPrev3.Size = new System.Drawing.Size(200, 50);
            this.buttonPrev3.TabIndex = 0;
            this.buttonPrev3.Text = "< Back";
            this.buttonPrev3.UseVisualStyleBackColor = true;
            this.buttonPrev3.Click += new System.EventHandler(this.buttonPrev3_Click);
            // 
            // dashboardMainpanel
            // 
            this.dashboardMainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardMainpanel.Location = new System.Drawing.Point(200, 0);
            this.dashboardMainpanel.Name = "dashboardMainpanel";
            this.dashboardMainpanel.Size = new System.Drawing.Size(1062, 633);
            this.dashboardMainpanel.TabIndex = 1;
            // 
            // dashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 633);
            this.Controls.Add(this.dashboardMainpanel);
            this.Controls.Add(this.dashboardSidepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboardForm";
            this.Text = "dashboardForm";
            this.dashboardSidepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dashboardSidepanel;
        private System.Windows.Forms.Panel dashboardMainpanel;
        private System.Windows.Forms.Button buttonPrev3;
        private System.Windows.Forms.Button buttonTab3;
        private System.Windows.Forms.Button buttonTab2;
        private System.Windows.Forms.Button buttonTab1;
    }
}