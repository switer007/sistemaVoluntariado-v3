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
    public partial class frmInstituiçãovoluntariados: Form
    {
        public frmInstituiçãovoluntariados()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaInstituicao frm = new frmBuscaInstituicao();
            frm.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
                try
                {
                    using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                    {
                        cn.Open();
                        var sql = "insert into instituicao (idInstituicao, nomeInstituicao, setorInstituicao, cidadeInstituicao, enderecoInstituicao, emailInstituicao, " +
                        "contatoInstituicao ,telefoneInstituicao ,CNPJInstituicao) " +
                        "VALUES (@idInstituicao, @nomeinstituicao, @setorInstituicao,@cidadeInstituicao,@enderecoInstituicao,@emailInstituicao,@contatoInstituicao,@telefoneInstituicao,@CNPJInstituicao)";
                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@idInstituicao", (txtidInstituicao.Text));
                            cmd.Parameters.AddWithValue("@nomeInstituicao", (txtnomeInstituicao.Text));
                            cmd.Parameters.AddWithValue("@setorInstituicao", (txtsetorInstituicao.Text));
                            cmd.Parameters.AddWithValue("@cidadeInstituicao", (txtcidadelInstituicao.Text));
                            cmd.Parameters.AddWithValue("@enderecoInstituicao", (txtenderecoInstituicao.Text));
                            cmd.Parameters.AddWithValue("@emailInstituicao", (txtemailInstituicao.Text));
                            cmd.Parameters.AddWithValue("@contatoInstituicao", (txtcontatoInstituicao.Text));
                            cmd.Parameters.AddWithValue("@telefoneInstituicao", (txttelefoneInstituicao.Text));
                            cmd.Parameters.AddWithValue("@CNPJInstituicao", (txtCNPJInstituicao.Text));
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
}
