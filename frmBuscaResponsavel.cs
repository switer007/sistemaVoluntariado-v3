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
    public partial class frmBuscaResponsavel : Form
    {
        public frmBuscaResponsavel()
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

                    var SqlQuery = "select * from responsavel where nomeResponsavel like '%" + txtBuscaResponsavel.Text + "%'";
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
                int idResponsavel = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idResponsavel"].Value);
                var confirm = MessageBox.Show("Tem certeza que deseja excluir este Responsável?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                        {
                            cn.Open();
                            string sql = "DELETE FROM responsavel WHERE idResponsavel = @id";
                            using (SqlCommand cmd = new SqlCommand(sql, cn))
                            {
                                cmd.Parameters.AddWithValue("@id", idResponsavel);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Responsavel excluído com sucesso!");
                                BuscarNovamenteReponsavel(); //recarrega a tabela após exclusão
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
        private void BuscarNovamenteReponsavel()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var SqlQuery = "select * from responsavel where nomeResponsavel like '%" + txtBuscaResponsavel.Text + "%'";
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
                int idReponsavel = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idReponsavel"].Value);
                //abre o formulario de cadastro com os dados do Usuario
                frmResponsavel frm = new frmResponsavel(idReponsavel);
                frm.ShowDialog();

                //atualiza a lista após edição
                BuscarNovamenteReponsavel();
            }
            else
            {
                MessageBox.Show("Selecione um responsavel para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

