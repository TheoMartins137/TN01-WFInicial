namespace WFInicial
{
    public partial class FormEx001 : Form
    {
        public FormEx001()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nota2_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txt_nota1.Text);
            double nota2 = double.Parse(txt_nota2.Text);

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                MessageBox.Show("Aprovado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (media <5)
            {
                MessageBox.Show("Reprovado", "Deu Ruim!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Recuperação", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
