using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_PesoIdeial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha programa

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear(); // Limpa TXTNOME
            txtAltura.Clear(); // Limpa TXTALTURA
            cmbSexo.Text = ""; // Limpa CMBSEXO

        }

        private void btnSairX_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha programa
        }
    }
}
