using System;
using System.Diagnostics;
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

        private void btnPesoIdeal_Click(object sender, EventArgs e)
        {
            try
            { 
                // Variaveis
                Double Altura, PesoIdeal;

                // Altura recebe o texto da 'txtAltura'
                Altura = double.Parse(txtAltura.Text);

                // Se cmbSexo for igual a "Feminino"
                if (cmbSexo.Text == "Feminino")
                {
                    PesoIdeal = (62.7 * Altura) - 44.7; // Calculo do peso
                    MessageBox.Show(txtNome.Text + "seu peso ideal é: " + PesoIdeal.ToString() + " KG", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbSexo.Text == "Masculino")
                {
                    PesoIdeal = (72.7 * Altura) - 58; // Calculo do peso
                    MessageBox.Show(txtNome.Text + " seu peso ideal é: " + PesoIdeal.ToString() + " KG", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sexo invalido", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os valores informados", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGitGui_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/gui1535");
        
        }
    }
}
