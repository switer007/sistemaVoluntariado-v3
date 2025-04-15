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
    public partial class frmVoluntariados: Form
    {
        public frmVoluntariados()
        {
            InitializeComponent();
        }

        private void frmVoluntariados_Load(object sender, EventArgs e)
        {

        }

        private void idVoluntario_Click(object sender, EventArgs e)
        {

        }

        private void nomeVoluntario_Click(object sender, EventArgs e)
        {

        }

        private void telefoneVoluntario_Click(object sender, EventArgs e)
        {

        }

        private void emailVoluntario_Click(object sender, EventArgs e)
        {

        }

        private void enderecoVoluntario_Click(object sender, EventArgs e)
        {

        }

        private void profissaoVoluntario_Click(object sender, EventArgs e)
        {

        }

        private void nomedeloginVoluntario_Click(object sender, EventArgs e)
        {

        }

        private void senhaVoluntario_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaVoluntarios frm = new frmBuscaVoluntarios();
            frm.ShowDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                SalvarVoluntario();
                this.Close();
            }
        }
        private void SalvarVoluntario()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conexao.IniciarCon))
                {
                    cn.Open();

                    var sql = "";

                    sql = "INSERT INTO voluntario (idVoluntario, nomeVoluntario, telefoneVoluntario, emailVoluntario, enderecoVoluntario," +
                        " profissaoVoluntario, observacaoVoluntario) " +
                        "VALUES (@idVoluntario, @nomeVoluntario, @telefoneVoluntario, @emailVoluntario, @enderecoVoluntario," +
                        " @profissaoVoluntario, @observacaoVoluntario)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@idVoluntario", (txtidVoluntario.Text));
                        cmd.Parameters.AddWithValue("@nomeVoluntario", (txtnomeVoluntario.Text));
                        cmd.Parameters.AddWithValue("@telefoneVoluntario", (txttelefoneVoluntario.Text));
                        cmd.Parameters.AddWithValue("@emailVoluntario", (txtemailVoluntario.Text));
                        cmd.Parameters.AddWithValue("@enderecoVoluntario", (txtenderecoVoluntario.Text));
                        cmd.Parameters.AddWithValue("@profissaoVoluntario", (txtprofissaoVoluntario.Text));
                        cmd.Parameters.AddWithValue("@observacaoVoluntario", (txtobsVoluntario.Text));
                        cmd.ExecuteNonQuery();
                        { 
                            MessageBox.Show("Salvo com sucesso");
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dados não salvos.\n\n" + ex.Message);
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            DataTable voluntario = BuscarVoluntarios();
            frmRelatorioVoluntarios relatorio = new frmRelatorioVoluntarios();
            relatorio.CarregarDados(voluntario);
            relatorio.ShowDialog();
        }

            private DataTable BuscarVoluntarios()
        {
            string query = "SELECT idVoluntario, nomeVoluntario, emailVoluntario, enderecoVoluntario FROM voluntario";
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