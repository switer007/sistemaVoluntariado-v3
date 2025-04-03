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
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //validação dos campos
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    MessageBox.Show("Por favor, preencha ambos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return;
                }

                //Autenticação
                if (AutenticarUsuario(txtUsuario.Text, txtSenha.Text))
                {
                    //login bem-sucedido
                    this.Hide();
                    var formPrincipal = new frmPrincipal();
                    formPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Erro ao acessar o banco de dados:\n {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado:\n {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     private bool AutenticarUsuario(string usuario, string senha)
        {
            using (SqlConnection conn = new SqlConnection(conexao.IniciarCon))
            {
                string query = "Select idusuario FROM usuario WHERE usuario = @Usuario AND senhaUsuario = @Senha";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    conn.Open();
                    var result = cmd.ExecuteScalar();

                    //Se retornar um ID, o usuário existe e as credenciais estão corretas
                    return result != null && result != DBNull.Value;
                }
            }
     }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
