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
    public partial class FormEx003 : Form
    {
        public FormEx003()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt_num1.Text);
            int num2 = Convert.ToInt32(txt_num2.Text);

            int maior = Math.Max(num1, num2);

            MessageBox.Show($"O maior valor é: {maior}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
