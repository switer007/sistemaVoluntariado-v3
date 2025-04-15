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
    public partial class frmResponsavel: Form
    {
        public frmResponsavel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaResponsavel frm = new frmBuscaResponsavel();
            frm.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                    {
                        cn.Open();
                        var sql = "insert into Responsavel (idResponsavel, nomeResponsavel,telefoneResponsavel, emailResponsavel, enderecoResponsavel,profissionalResponsavel, observacaoResponsavel) VALUES (@idResponsavel, @nomeResponsavel, @telefoneResponsavel,@emailResponsavel,@enderecoResponsavel,@profissionalResponsavel,@observacaoResponsavel)";
                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@idResponsavel", (txtidResponsavel.Text));
                            cmd.Parameters.AddWithValue("@nomeResponsavel", (txtnomeResponsavel.Text));
                            cmd.Parameters.AddWithValue("telefoneResponsavel", (txttelefoneResponsavel.Text));
                            cmd.Parameters.AddWithValue("@emailResponsavel", (txtemailResponsavel.Text));
                            cmd.Parameters.AddWithValue("@enderecoResponsavel", (txtenderecoResponsavel.Text));
                            cmd.Parameters.AddWithValue("profissionalResponsavel", (txtprofissionalResponsavel.Text));
                            cmd.Parameters.AddWithValue("@observacaoResponsavel", (txtobservacaoResponsavel.Text));
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
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        
        {
            DataTable responsavel = BuscarResponsavel();
            frmRelatorioResponsavel relatorio = new frmRelatorioResponsavel ();
            relatorio.CarregarDados(responsavel);
            relatorio.ShowDialog();
        }

        private DataTable BuscarResponsavel()
        {
            string query = "SELECT idResponsavel, nomeResponsavel, emailResponsavel, enderecoResponsavel FROM responsavel";
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