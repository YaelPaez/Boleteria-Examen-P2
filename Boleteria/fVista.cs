﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boleteria
{
    public partial class fVista : Form
    {
        public fVista()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fVista_Load(object sender, EventArgs e)
        {
            dgBoletos.DataSource = Classes.Acciones.CargarBoletos();
        }
    }
}
