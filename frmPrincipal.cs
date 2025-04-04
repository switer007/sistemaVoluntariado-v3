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
    public partial class frmPrincipal: Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmCadastroUsuario frm = new frmCadastroUsuario();
            frm.ShowDialog();
        }

        private void btnInstituicao_Click(object sender, EventArgs e)
        {
            frmInstituiçãovoluntariados frm = new frmInstituiçãovoluntariados();
            frm.ShowDialog();
        }

        private void btnVoluntario_Click(object sender, EventArgs e)
        {
            frmVoluntariados frm = new frmVoluntariados();
            frm.ShowDialog();
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            frmAções frm = new frmAções();
            frm.ShowDialog();
        }

        private void btnResponsavel_Click(object sender, EventArgs e)
        {
            frmResponsavel frm = new frmResponsavel();
            frm.ShowDialog();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorio frm = new frmRelatorio();
            frm.ShowDialog();
        }
    }
}
