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
    public partial class FormEx007 : Form
    {
        public string[] Nome = new string[6];
        public double[] valor = new double[6];
        public int contador = 0;
        public FormEx007()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            contador = contador + 1;
            Nome[contador - 1] = txt_nome.Text;
            valor[contador - 1] = Convert.ToDouble(txt_valor.Text);

            txt_nome.Text = "";
            txt_valor.Text = "";

            if (contador == 6)
            {
                double menor = valor.Min();
                int pos_menor = Array.IndexOf(valor, menor);
                string mensagem = $"O produto mais barato é {Nome[pos_menor]} de valor R${menor}";

                MessageBox.Show(mensagem);
            }
        }
    }
}
