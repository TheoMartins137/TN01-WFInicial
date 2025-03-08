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
    public partial class FormEx012 : Form
    {
        public int[] numeros = new int[20];
        public int[] pares = new int[1];
        public int[] impares = new int[1];
        public int contagem = 0;

        public FormEx012()
        {
            InitializeComponent();
        }

        private void lbl_cont_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txt_num.Text);
            numeros[contagem] = numero;

            if (numero % 2 == 0)
            {
                Array.Resize(ref pares, pares.Length + 1);
                pares[pares.Length] = numero;
            }
            else
            {
                Array.Resize(ref impares, impares.Length + 1);
                impares[impares.Length] = numero;
            }


            if (contagem == 20)
            {
                for (int i = 0; i < numeros.Length; i++)
                {
                    lbl_numeros.Text += numeros[i] + ","; 
                }
                for (int i = 0; i < pares.Length; i++)
                {
                    lbl_par.Text += pares[i] + ",";
                }
                for (int i = 0; i < impares.Length; i++)
                {
                    lbl_impar.Text += impares[i] + ",";
                }
            }
            contagem++;
            txt_num.Text = "";

        }
    }
}
