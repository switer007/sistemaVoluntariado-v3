namespace sistemaVoluntariado
{
    partial class frmRelatorio
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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelRelatorio = new System.Windows.Forms.Panel();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(152, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Relatório Usuario";
            // 
            // panelRelatorio
            // 
            this.panelRelatorio.Controls.Add(this.dgvRelatorio);
            this.panelRelatorio.Controls.Add(this.label8);
            this.panelRelatorio.Controls.Add(this.pictureBox6);
            this.panelRelatorio.Location = new System.Drawing.Point(62, 26);
            this.panelRelatorio.Name = "panelRelatorio";
            this.panelRelatorio.Size = new System.Drawing.Size(743, 447);
            this.panelRelatorio.TabIndex = 29;
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvRelatorio.Location = new System.Drawing.Point(46, 160);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.Size = new System.Drawing.Size(653, 251);
            this.dgvRelatorio.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(711, 495);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 30;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(141)))));
            this.ClientSize = new System.Drawing.Size(864, 541);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panelRelatorio);
            this.Name = "frmRelatorio";
            this.Text = "frmRelatorio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelRelatorio.ResumeLayout(false);
            this.panelRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelRelatorio;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Button btnImprimir;
    }
}