using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVoluntariado
{
    public partial class frmRelatorioVoluntarios : Form
    {
        private PrintDocument documento = new PrintDocument();

        public frmRelatorioVoluntarios()
        {
            InitializeComponent();
            documento.PrintPage += Documento_PrintPage;
        }
        public void CarregarDados(DataTable dados)
        {
            dgvRelatorioVoluntarios.DataSource = dados;
        }
        private void Documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fonteTitulo = new Font("Arial", 18, FontStyle.Bold);
            Font fonteCabecalho = new Font("Arial", 12, FontStyle.Bold);
            Font fonteCorpo = new Font("Arial", 10);

            int margemEsquerda = e.MarginBounds.Left;
            int margemSuperior = e.MarginBounds.Top;

            float linhaAltura = fonteCorpo.GetHeight(e.Graphics) + 4;
            float y = margemSuperior;

            // Título
            e.Graphics.DrawString("Relatório de Voluntario", fonteTitulo, Brushes.Black, margemEsquerda, y);
            y += linhaAltura * 2;

            // Cabeçalhos
            e.Graphics.DrawString("ID", fonteCabecalho, Brushes.Black, margemEsquerda, y);
            e.Graphics.DrawString("Nome", fonteCabecalho, Brushes.Black, margemEsquerda + 50, y);
            e.Graphics.DrawString("Email", fonteCabecalho, Brushes.Black, margemEsquerda + 250, y);
            y += linhaAltura;

            // Dados do DataGridView
            foreach (DataGridViewRow row in dgvRelatorioVoluntarios.Rows)
            {
                if (row.IsNewRow) continue;

                e.Graphics.DrawString(row.Cells["idVoluntario"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda, y);
                e.Graphics.DrawString(row.Cells["nomeVoluntario"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 50, y);
                e.Graphics.DrawString(row.Cells["emailVoluntario"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);

                y += linhaAltura;

                // Evita que ultrapasse a página
                if (y > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Rodapé ou total opcional
            y += linhaAltura;
            e.Graphics.DrawString("Total de Voluntarios: " + (dgvRelatorioVoluntarios.Rows.Count - 1), fonteCorpo, Brushes.Black, margemEsquerda, y);
        }
      

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = documento;
            preview.ShowDialog();
        }
    }
}
