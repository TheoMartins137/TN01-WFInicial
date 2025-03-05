using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFInicial
{
    public partial class FormEx007 : Form
    {
        string[] nome = new string[6];
        double[] valor = new double[6];
        public FormEx007()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                nome[i] = txt_valor.Text;
                try
                {
                    valor[i] = Convert.ToDouble(txt_nome.Text[0]);
                    valor[i] = Convert.ToDouble(txt_nome.Text[1]);
                }
                catch
                {
                }
                if (valor[i] < valor[0])
                {
                    valor[0] = valor[i];
                    nome[0] = nome[i];
                }
            }
            //MessageBox.Show("Repita", "Novamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            MessageBox.Show($"{nome[0]} {valor[0]}", "Atenção");
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
