using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaVoluntariado.relatorios
{
    public partial class frmRelVoluntario : Form
    {
        public frmRelVoluntario()
        {
            InitializeComponent();
        }

        private void frmRelVoluntario_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
