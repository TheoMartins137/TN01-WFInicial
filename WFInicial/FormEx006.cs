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
    public partial class FormEx006 : Form
    {
        public FormEx006()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            double valor = Convert.ToDouble(txt_valor.Text);
            int hora = Convert.ToInt32(txt_hora.Text);

            double valor_final = valor * hora;

            MessageBox.Show($"Recebendo {valor} e tendo trabalhado por {hora}, a renda de {nome} foi de: R${valor_final:F2}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
