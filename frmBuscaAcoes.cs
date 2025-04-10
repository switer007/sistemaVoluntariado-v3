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
    public partial class frmBuscaAcoes : Form
    {
        public frmBuscaAcoes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();

                    var SqlQuery = "select * from acoes where nomeAcoes like '%" + txtBuscaAcoes.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar conectar\n\n" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //pega o idAluno da linha selecionada
                int idAcoes = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idAcoes"].Value);
                var confirm = MessageBox.Show("Tem certeza que deseja excluir este Ação?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM acoes WHERE idAcoes = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idAcoes);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Usuario excluído com sucesso!");
                                BuscarNovamente(); //recarrega a tabela após exclusão
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir usuario.\n\n" + ex.Message);
                    }
                }
            }
        }

        private void BuscarNovamente()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var SqlQuery = "select * from acoes where nomeAcoes like '%" + txtBuscaAcoes.Text + "%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(SqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados. \n\n" + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //pega o ID do usuario selecionado
                int idAcoes = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idAcoes"].Value);
                //abre o formulario de cadastro com os dados do Usuario
                frmBuscaAcoes frm = new frmBuscaAcoes ();
                frm.ShowDialog();

                //atualiza a lista após edição
                BuscarNovamente();
            }
            else
            {
                MessageBox.Show("Selecione um aluno para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}