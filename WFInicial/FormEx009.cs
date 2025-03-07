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
    public partial class FormEx009 : Form
    {
        public FormEx009()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

            if (usuario == senha)
            {
                MessageBox.Show("Senha ou usuário inválidos ", "LOGIN INVÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_senha.Text = "";
                txt_usuario.Text = "";
            }
            else
            {
                MessageBox.Show("Seja Bem-Vindo", "LOGIN COMPLETO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
        }
    }
}
