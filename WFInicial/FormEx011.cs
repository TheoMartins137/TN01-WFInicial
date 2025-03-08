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
    public partial class FormEx011 : Form
    {
        public double[] sal_bruto = new double[5];
        public int indice = 0;

        public FormEx011()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

            if (indice < 5)
            {
                sal_bruto[indice] = double.Parse(txt_salario.Text);
                double liquido = sal_bruto[indice] * 0.88;

                txt_resultado.Text += $"Valor Bruto: {txt_salario.Text} \n Valor Liquído: {liquido} \n";
            }
            else
            {
                MessageBox.Show("Quantidade Máxima!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            indice++;
        }
    }
}
