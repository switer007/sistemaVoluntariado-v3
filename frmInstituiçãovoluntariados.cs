﻿using System;
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
    }
}
