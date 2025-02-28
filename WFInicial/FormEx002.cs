using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WFInicial
{
    public partial class FormEx002 : Form
    {
        public FormEx002()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_escolher_Click(object sender, EventArgs e)
        {
            byte opcao = byte.Parse(txt_diaSemana.Text);

            switch (opcao)
            {
                case 1:
                    MessageBox.Show("Domingo");
                    break;
                case 2:
                    MessageBox.Show("Segunda-feira");
                    break;
                case 3:
                    MessageBox.Show("Terça-feira");
                    break;
                case 4:
                    MessageBox.Show("Quarta-feira");
                    break;
                case 5:
                    MessageBox.Show("Quinta-feira");
                    break;
                case 6:
                    MessageBox.Show("Sexta-feira");
                    break;
                case 7:
                    MessageBox.Show("Sábado");
                    break;
                default:
                    MessageBox.Show("Inválido");
                    break;
            }
        }
    }
}
