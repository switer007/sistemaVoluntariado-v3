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
using System.Xml.Linq;

namespace sistemaVoluntariado
{
    public partial class frmRelatorioResponsavel : Form
    {
        private PrintDocument documento = new PrintDocument();

        public frmRelatorioResponsavel()
        {
            InitializeComponent();
            documento.PrintPage += Documento_PrintPage;
        }
        public void CarregarDados(DataTable dados)
        {
            dgvRelatorioResponsavel.DataSource = dados;
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
            e.Graphics.DrawString("Relatório de Responsavel", fonteTitulo, Brushes.Black, margemEsquerda, y);
            y += linhaAltura * 2;

            // Cabeçalhos
            e.Graphics.DrawString("ID", fonteCabecalho, Brushes.Black, margemEsquerda, y);
            e.Graphics.DrawString("Nome", fonteCabecalho, Brushes.Black, margemEsquerda + 50, y);
            e.Graphics.DrawString("Email", fonteCabecalho, Brushes.Black, margemEsquerda + 250, y);
            y += linhaAltura;

            // Dados do DataGridView
            foreach (DataGridViewRow row in dgvRelatorioResponsavel.Rows)
            {
                if (row.IsNewRow) continue;

                e.Graphics.DrawString(row.Cells["idResponsavel"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda, y);
                e.Graphics.DrawString(row.Cells["nomeResponsavel"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 50, y);
                e.Graphics.DrawString(row.Cells["emailResponsavel"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);

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
            e.Graphics.DrawString("Total de responsavel: " + (dgvRelatorioResponsavel.Rows.Count - 1), fonteCorpo, Brushes.Black, margemEsquerda, y);
        }
        
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = documento;
            preview.ShowDialog();
        }

    }
}

