using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha))
                {
                    MessageBox.Show("Por favor, preencha ambos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsuario.Focus();
                    return;
                }

                //Autenticação
                if (AutenticarUsuario(txtUsuarioUsuario.Text, txtSenha.Text))
                {
                    //login bem-sucedido
                    this.Hide();
                    var formPrincipal = new MenuPrincipal();
                    formPrincipal.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.", "Falha no login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
