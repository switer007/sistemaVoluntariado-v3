using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVoluntariado
{
    public partial class frmCadastroUsuario: Form
    
    {
        int idusuario = 0;
        public frmCadastroUsuario(int idusuario)
        {
            InitializeComponent();
            this.idusuario = idusuario;

            if (this.idusuario > 0)
                Getusuario(idusuario);
        }

     

        private void Getusuario (int idusuario)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();
                    var sql = "select * from usuario where idusuario=" + idusuario;
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    txtnomeUsuario.Text = dr["nomeUsuario"].ToString();
                                    txttelefoneUsuario.Text = dr["telefoneUsuario"].ToString();
                                    txtemailUsuario.Text = dr["emailUsuario"].ToString();
                                    txtenderecoUsuario.Text = dr["enderecoUsuario"].ToString();
                                    txtusuario.Text = dr["usuario"].ToString();
                                    txtsenhaUsuario.Text = dr["senhaUsuario"].ToString();


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
    
      

             private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarUsuario();
            this.Close();
        }
        private void SalvarUsuario()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();

                    var sql = "";

                    if (this.idusuario == 0)

                        sql = "INSERT INTO usuario (idusuario, nomeUsuario, telefoneUsuario, emailUsuario, enderecoUsuario, usuario, senhaUsuario) " +
                            "VALUES (@id, @nome, @telefone, @email, @endereco, @usuario, @senha)";
                    else
                        sql = "update usuario set idusuario=@id, nomeUsuario=@nome, telefoneUsuario=@telefone, emailUsuario=@email, enderecoUsuario=@endereco, usuario=@usuario, senha=@senha where idusuario=" + this.idusuario;

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id", txtidUsuario.Text);
                        cmd.Parameters.AddWithValue("@nome", txtnomeUsuario.Text);
                        cmd.Parameters.AddWithValue("@telefone", txttelefoneUsuario.Text);
                        cmd.Parameters.AddWithValue("@email", txtemailUsuario.Text);
                        cmd.Parameters.AddWithValue("@endereco", txtenderecoUsuario.Text);
                        cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);
                        cmd.Parameters.AddWithValue("@senha", txtsenhaUsuario.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Salvo com sucesso");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados não salvos.\n\n" + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaUsuario frm = new frmBuscaUsuario();
            frm.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            DataTable usuario = BuscarUsuario();
            frmRelatorio relatorio = new frmRelatorio();
            relatorio.CarregarDados(usuario);
            relatorio.ShowDialog();
        }

        private DataTable BuscarUsuario() 
        {
            string query = "SELECT idusuario, nomeUsuario, emailUsuario, enderecoUsuario, usuario, senhaUsuario FROM usuario";
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

