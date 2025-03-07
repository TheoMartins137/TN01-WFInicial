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
    public partial class FormEx010 : Form
    {
        public FormEx010()
        {
            InitializeComponent();
        }

        private void FormEx010_Load(object sender, EventArgs e)
        {

        }

        private void txt_num_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txt_num_Leave(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txt_num.Text);
            string tabuada = "";

            for (int i = 1; i < 10; i++)
            {
                tabuada = tabuada + $"{numero} X {i} = {numero * i}\r\n";

            }
            txt_resultado.Text = tabuada;
        }
    }
}
