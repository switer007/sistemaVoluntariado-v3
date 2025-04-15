namespace sistemaVoluntariado
{
    partial class frmRelatorioResponsavel
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.panelRelatorio = new System.Windows.Forms.Panel();
            this.dgvRelatorioResponsavel = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioResponsavel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(742, 493);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 34;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panelRelatorio
            // 
            this.panelRelatorio.Controls.Add(this.dgvRelatorioResponsavel);
            this.panelRelatorio.Controls.Add(this.label8);
            this.panelRelatorio.Controls.Add(this.pictureBox6);
            this.panelRelatorio.Location = new System.Drawing.Point(74, 31);
            this.panelRelatorio.Name = "panelRelatorio";
            this.panelRelatorio.Size = new System.Drawing.Size(743, 447);
            this.panelRelatorio.TabIndex = 33;
            // 
            // dgvRelatorioResponsavel
            // 
            this.dgvRelatorioResponsavel.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRelatorioResponsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioResponsavel.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvRelatorioResponsavel.Location = new System.Drawing.Point(46, 160);
            this.dgvRelatorioResponsavel.Name = "dgvRelatorioResponsavel";
            this.dgvRelatorioResponsavel.Size = new System.Drawing.Size(653, 251);
            this.dgvRelatorioResponsavel.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(152, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Relatório Responsável";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::sistemaVoluntariado.Properties.Resources.Captura_de_tela_2025_04_02_112843;
            this.pictureBox6.Location = new System.Drawing.Point(28, 17);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(85, 76);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // frmRelatorioResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(930, 582);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panelRelatorio);
            this.Name = "frmRelatorioResponsavel";
            this.Text = "frmRelatorioResponsavel";
            this.panelRelatorio.ResumeLayout(false);
            this.panelRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioResponsavel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panelRelatorio;
        private System.Windows.Forms.DataGridView dgvRelatorioResponsavel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}