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
    public partial class FormEx004 : Form
    {
        public FormEx004()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEx004_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt_num1.Text);
            int num2 = Convert.ToInt32(txt_num2.Text);
            int num3 = Convert.ToInt32(txt_num3.Text);

            int maior = Math.Max(num3, Math.Max(num1, num2));

            MessageBox.Show($"O maior número é: {maior}", "Maior", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }
    }
}
