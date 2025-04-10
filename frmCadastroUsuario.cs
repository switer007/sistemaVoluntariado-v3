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
    public partial class frmCadastroUsuario: Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarCliente();
            this.Close();
        }
        private void SalvarCliente()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();

                    var sql = "";

               
                        sql = "INSERT INTO usuario (idusuario, nomeUsuario, telefoneUsuario, emailUsuario, enderecoUsuario, usuario, senhaUsuario) " +
                            "VALUES (@id, @nome, @telefone, @email, @endereco, @usuario, @senha)";

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
            string query = "SELECT idusuario, nomeUsuario, emailUsuario, enderecoUsuario FROM usuario";
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

