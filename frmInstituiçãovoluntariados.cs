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
         public partial class frmBuscaInstituicao : Form
    {
        int idInstituicao = 0;

        public frmBuscaInstituicao(int idInstituicao)
        { 
    
        public frmInstituiçãovoluntariados()
        {
            InitializeComponent();
            this.idInstituicao = idInstituicao;

            if (this.idInstituicao > 0)
                Getinstituicao(idInstituicao);
        }
        private void Getinstituicao(int idInstituicao)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from instituicao where idInstituicao=" + idInstituicao;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtnomeInstituicao.Text = dr["nomeInstituicao"].ToString();
                                    txtsetorInstituicao.Text = dr["setorInstituicao"].ToString();
                                    txtcidadelInstituicao.Text = dr["cidadeInstituicao"].ToString();
                                    txtenderecoInstituicao.Text = dr["enderecoInstituicao"].ToString();
                                    txtemailInstituicao.Text = dr["emailInstituicao"].ToString();
                                    txtcontatoInstituicao.Text = dr["contatoInstituicap"].ToString();
                                    txttelefoneInstituicao.Text = dr["telefoneInstituicao"].ToString();
                                    txtCNPJInstituicao.Text = dr["CNPJInstituicao"].ToString();


                                }

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados não atualizado.\n\n" + ex.Message);
            }
        }
    
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

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            DataTable instituicao = BuscarInstituicao();
            frmRelatorioInstituicao relatorio = new frmRelatorioInstituicao();
            relatorio.CarregarDados(instituicao);
            relatorio.ShowDialog();
        }

        private DataTable BuscarInstituicao()
        {
            string query = "SELECT idInstituicao, nomeInstituicao, emailInstituicao, enderecoInstituicao FROM instituicao";
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
