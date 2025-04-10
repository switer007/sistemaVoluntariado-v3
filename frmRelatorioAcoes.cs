using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sistemaVoluntariado
{
    public partial class frmRelatorioAcoes : Form
    {
        private PrintDocument documento = new PrintDocument();

        public frmRelatorioAcoes()
        {
            InitializeComponent();
            documento.PrintPage += Documento_PrintPage;
        }
        public void CarregarDados(DataTable dados)
        {
            dgvRelatorioAcoes.DataSource = dados;
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
            e.Graphics.DrawString("Relatório de Ações", fonteTitulo, Brushes.Black, margemEsquerda, y);
            y += linhaAltura * 2;

            // Cabeçalhos
            e.Graphics.DrawString("ID", fonteCabecalho, Brushes.Black, margemEsquerda, y);
            e.Graphics.DrawString("Nome", fonteCabecalho, Brushes.Black, margemEsquerda + 50, y);
            e.Graphics.DrawString("instituicaoBeneficada", fonteCabecalho, Brushes.Black, margemEsquerda + 250, y);
            y += linhaAltura;

            // Dados do DataGridView
            foreach (DataGridViewRow row in dgvRelatorioAcoes.Rows)
            {
                if (row.IsNewRow) continue;

                e.Graphics.DrawString(row.Cells["idAcoes"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda, y);
                e.Graphics.DrawString(row.Cells["nomeAcoes"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 50, y);
                e.Graphics.DrawString(row.Cells["intituicaoBeneficada"].Value?.ToString(), fonteCorpo, Brushes.Black, margemEsquerda + 250, y);

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
            e.Graphics.DrawString("Total de Ações: " + (dgvRelatorioAcoes.Rows.Count - 1), fonteCorpo, Brushes.Black, margemEsquerda, y);
        }






        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = documento;
            preview.ShowDialog();

        }


      

             private DataTable BuscarAcoes()
        {
            string query = "SELECT idacoes, nomeAcoes, instituicaoBeneficada, funcionarioResponsavel, qtdDepessoasimpactadas, descricaoDaacoes," +
                "itensParaacao, qtcDecolaboradoresenvolvidos, qtdAlunosenvolvidos, cursosParticipantes, qtdDeitensarrecadados, colaboradosQueparticiparam," +
                "publicoBeneficados, impactoSocialGerado FROM acoes";
            DataTable tabela = new DataTable();
        
            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                conn.Open();
                da.Fill(tabela);
            }
            return tabela;
        }

     
    }
}
