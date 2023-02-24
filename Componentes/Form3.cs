using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class calcularPontos : Form
    {
        int soma;
        float total,ponto;
        public calcularPontos()
        {
            InitializeComponent();
        }

        private void rb_a_CheckedChanged(object sender, EventArgs e)
        {
            soma = 1650;
        }

        private void rb_B_CheckedChanged(object sender, EventArgs e)
        {
            soma = 1060;
        }

        private void rb_C_CheckedChanged(object sender, EventArgs e)
        {
            soma = 749;
        }

        private void tb_pontos_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            try
            {
                string valor = tb_pontos.Text;
                ponto = float.Parse(valor);

                total = (ponto * 0.135804f) + soma;
                MessageBox.Show("R$ " + total, "Salário");

            }
            catch(FormatException)
            {
                MessageBox.Show("Digite somente números.", "Erro de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            tb_pontos.Clear();
                tb_pontos.Focus();
            
        }
    }
}
