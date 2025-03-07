using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class FormEx008 : Form
    {
        public FormEx008()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double resultado, numero1, numero2 = 0;
            bool validonum1 = double.TryParse(txt_num1.Text, out numero1);
            bool validonum2 = double.TryParse(txt_num2.Text, out numero2);

            if (!validonum1 || !validonum2)
            {
                MessageBox.Show("Equação Inválida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdb_soma.Checked)
            {
                resultado = numero1 + numero2;
                MessageBox.Show($"A soma de {numero1} + {numero2} = {resultado}", "SOMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (rdb_sub.Checked)
            {
                resultado = numero1 - numero2;
                MessageBox.Show($"A subtração de {numero1} - {numero2} = {resultado}", "SUBTRAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdb_mult.Checked)
            {
                resultado = numero1 * numero2;
                MessageBox.Show($"A multiplicação de {numero1} X {numero2} = {resultado}", "MULTIPLICAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdb_div.Checked)
            {
                if (numero2 == 0)
                {
                    MessageBox.Show("Equação Inválida", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    resultado = numero1 / numero2;
                    MessageBox.Show($"A multiplicação de {numero1} X {numero2} = {resultado}", "DIVISÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (rdb_pot.Checked)
            {
                resultado = Math.Pow(numero1, numero2);
                MessageBox.Show($"A potenciação de {numero1} elevado á {numero2} = {resultado}", "POTENCIAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdb_rad.Checked)
            {
                if (numero2 == 0)
                {
                    resultado = 1;
                }
                else
                {
                    resultado = Math.Pow(numero1, (1 / numero2));
                }
                MessageBox.Show($"A raiz de {numero1} sob {1 / numero2} = {resultado:F2}", "RAIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Escolha uma operação", "ATENÇÂO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void rdb_sub_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
