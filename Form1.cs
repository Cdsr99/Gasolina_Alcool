namespace Gas_Alc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular();
        }

        public void limpar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "....";
        }

        public void calcular()
        {
            try
            {
                if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
                {
                    MessageBox.Show("Favor preencher os campos conforme solicitado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Double gas = Convert.ToDouble(textBox1.Text);
                    Double alc = Convert.ToDouble(textBox2.Text);
                    Double result = alc / gas;

                    if (result < 0.7)
                    {
                        label4.Text = "O Álcool é a melhor opção";
                    }
                    else
                    {
                        label4.Text = "A Gasolina é a melhor opção";
                    }
                }


                }catch (Exception ex) {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Algo deu errado, poderia verificar e tentar novamente?", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void cálculoDetalhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 janela = new Form2();
            janela.Show();
            this.Hide();
        }
    }
}