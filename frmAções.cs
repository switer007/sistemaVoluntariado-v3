using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVoluntariado
{
    public partial class frmAções : Form
    {
        public frmAções()
        {
            InitializeComponent();
        }

        private void frmAções_Load(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaAcoes frm = new frmBuscaAcoes();
            frm.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "insert into acoes (idAcoes, nomeAcoes, instituicaoBeneficada,funcionarioResponsavel,qtdDepessoasimpactadas , descricaoDaacoes" +
                        ",itensParaacao,verbaDosenac,valorDedoacao,itensConfeccionados,qtdColaboradoresenvolvidos, qtdAlunosenvolvidos, cursosParticipantes, " +
                        "qtdDeitensarrecadados, colaboradosQueparticiparam, publicoBeneficados, impactoSocialGerado, " +
                        "depoimentoDeparticipantes, obeservacoes) values (@idAcoes ,@nomeAcao, @instituicaoBeneficiada, @funcionarioResponsavel," +
                        " @qtdDepessoasimpactadas, @descricaoDaacoes, @itensParaacao, @verbaDoSenac, @valorDedoacao, " +
                        "@itensConfeccionados, @qtdColaboradoresenvolvidos, @qtdAlunosenvovidos, @cursosParticipantes, " +
                        "@qtdDeitensarrecadados, @colaboradosQueparticiparam, @publicoBeneficiados, @impactoSocialGerado, " +
                        "@depoimentoDeparticipantes, @observarcoes)";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@idAcoes", (txtidacoes.Text));
                        cmd.Parameters.AddWithValue("@nomeAcao", (txtnomeAcao.Text));
                        cmd.Parameters.AddWithValue("@instituicaoBeneficiada", (txtinstituicaoBeneficiada.Text));
                        cmd.Parameters.AddWithValue("@funcionarioResponsavel", (txtfuncionarioResponsavel.Text));
                        cmd.Parameters.AddWithValue("@qtdDepessoasimpactadas", (txtqtdDepessoasimpactadas.Text));
                        cmd.Parameters.AddWithValue("@descricaoDaacoes", (txtdescricaoDaacoes.Text));
                        cmd.Parameters.AddWithValue("@itensParaacao", (txtitensParaacao.Text));
                        cmd.Parameters.AddWithValue("@verbaDosenac", (txtverbaDosenac.Text));
                        cmd.Parameters.AddWithValue("@valorDedoacao", (txtvalorDedoacao.Text));
                        cmd.Parameters.AddWithValue("@itensConfeccionados", (txtItensConfeccionados.Text));
                        cmd.Parameters.AddWithValue("@qtdColaboradoresenvolvidos", (txtqtdColaboradoresenvolvidos.Text));
                        cmd.Parameters.AddWithValue("@qtdAlunosenvovidos", (txtqtdAlunosenvolvidos.Text));
                        cmd.Parameters.AddWithValue("@cursosParticipantes", (txtcursosParticipantes.Text));
                        cmd.Parameters.AddWithValue("@qtdDeitensarrecadados", (txtQuantidadeDeItensArrecadados.Text));
                        cmd.Parameters.AddWithValue("@colaboradosQueparticiparam", (txtcolaboradosQueparticiparam.Text));
                        cmd.Parameters.AddWithValue("@publicoBeneficiados", (txtpublicoBeneficiados.Text));
                        cmd.Parameters.AddWithValue("@impactoSocialGerado", (txtimpactoSocialGerado.Text));
                        cmd.Parameters.AddWithValue("@depoimentoDeparticipantes", (txtdepoimentoDeparticipantes.Text));
                        cmd.Parameters.AddWithValue("@observarcoes", (txtobservacoes.Text));
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Salvo com sucesso");
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show("dados nao salvos.\n\n" + ex.Message);
            }
         }
        

      

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            DataTable acoes = BuscarAcao();
            frmRelatorioAcoes relacoes = new frmRelatorioAcoes();
            relacoes.CarregarDados(acoes);
            relacoes.ShowDialog();
        }

        private DataTable BuscarAcao()
        {
            string query = "SELECT idAcoes, nomeAcoes, instituicaoBeneficada, funcionarioResponsavel FROM acoes";
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            frmBuscaUsuario frm = new frmBuscaUsuario();
            frm.ShowDialog();
        }
    }
}