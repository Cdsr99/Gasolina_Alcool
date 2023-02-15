using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gas_Alc
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void cálculoDetalhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 janela = new Form1();
            janela.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpar
            limpar();
        }

        public void limpar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label4.Text = "....";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Calcular
            calcular();
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
                    Double preco_gas = Convert.ToDouble(textBox1.Text);
                    Double preco_alc = Convert.ToDouble(textBox2.Text);
                    Double gasolina_km = Convert.ToDouble(textBox3.Text);
                    Double alcool_km = Convert.ToDouble(textBox4.Text);
                    Double viagem = Convert.ToDouble(textBox5.Text);

                    Double resultGasolina = (viagem / gasolina_km) * preco_gas;
                    Double resultAlcool = (viagem / alcool_km) * preco_alc;

                    if (resultGasolina <= resultAlcool)
                    {
                        label4.Text = "A Gasolina é a melhor opção";
                    }
                    else
                    {
                        label4.Text = "O Álcool é a melhor opção";

                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo deu errado, poderia verificar e tentar novamente?", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
