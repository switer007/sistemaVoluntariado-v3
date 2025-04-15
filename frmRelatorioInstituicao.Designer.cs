namespace sistemaVoluntariado
{
    partial class frmRelatorioInstituicao
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
            this.dgvRelatorioInstituicao = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioInstituicao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(779, 507);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 38;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // panelRelatorio
            // 
            this.panelRelatorio.Controls.Add(this.dgvRelatorioInstituicao);
            this.panelRelatorio.Controls.Add(this.label8);
            this.panelRelatorio.Controls.Add(this.pictureBox6);
            this.panelRelatorio.Location = new System.Drawing.Point(111, 45);
            this.panelRelatorio.Name = "panelRelatorio";
            this.panelRelatorio.Size = new System.Drawing.Size(743, 447);
            this.panelRelatorio.TabIndex = 37;
            // 
            // dgvRelatorioInstituicao
            // 
            this.dgvRelatorioInstituicao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRelatorioInstituicao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioInstituicao.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvRelatorioInstituicao.Location = new System.Drawing.Point(46, 160);
            this.dgvRelatorioInstituicao.Name = "dgvRelatorioInstituicao";
            this.dgvRelatorioInstituicao.Size = new System.Drawing.Size(653, 251);
            this.dgvRelatorioInstituicao.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(152, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Relatório Instituição";
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
            // frmRelatorioInstituicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(965, 575);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panelRelatorio);
            this.Name = "frmRelatorioInstituicao";
            this.Text = "frmRelatorioInstituicao";
            this.panelRelatorio.ResumeLayout(false);
            this.panelRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioInstituicao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Panel panelRelatorio;
        private System.Windows.Forms.DataGridView dgvRelatorioInstituicao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}