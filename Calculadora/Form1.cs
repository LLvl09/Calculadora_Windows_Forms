using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        //definindo valor 1 e 2
        decimal valor1 = 0;
        decimal valor2 = 0;
        //definindo a operacao (+, -, *, /)
        string operacao;
        //definido resultado
        decimal resultado = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox.Text += "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {

            textBox.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox.Text += "9";
        }
        private void button_virgula_Click(object sender, EventArgs e)
        {
            textBox.Text += ".";
        }
        private void button_soma_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                textBox.Text = "";
                operacao = "SOMA";
                label_Operacao.Text = "+";
            }
        }
        private void button_subtracao_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                textBox.Text = "";
                operacao = "SUBTRACAO";
                label_Operacao.Text = "-";
            }
        }
        private void button_multiplicacao_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                textBox.Text = "";
                operacao = "MULTIPLICACAO";
                label_Operacao.Text = "x";
            }
        }
        private void button_divisao_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                valor1 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
                textBox.Text = "";
                operacao = "DIVISAO";
                label_Operacao.Text = "/";
            }
        }
        private void button_resultado_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(textBox.Text, CultureInfo.InvariantCulture);
            FazCalculo(operacao, resultado, valor1, valor2);

        }
       

        private void button_C_Click(object sender, EventArgs e)
        {
            ApagaTextBox();
        }
        private void button_CE_Click(object sender, EventArgs e)
        {
            ApagaTextBox();
        }
        private void ApagaTextBox()
        {
            textBox.Text = "";
            valor1 = 0;
            valor2 = 0;
            label_Operacao.Text = "";
        }
        public void FazCalculo(String operacao, decimal resultado, decimal valor1, decimal valor2)
        {
            switch (operacao)
            {
                case "SOMA":
                    resultado = valor1 + valor2;
                    textBox.Text = resultado.ToString();
                    break;

                case "SUBTRACAO":
                    resultado = valor1 - valor2;
                    textBox.Text = resultado.ToString();
                    break;

                case "MULTIPLICACAO":
                    resultado = valor1 * valor2;
                    textBox.Text = resultado.ToString();
                    break;

                case "DIVISAO":
                    resultado = valor1 / valor2;
                    textBox.Text = resultado.ToString();
                    break;

                default:
                    resultado = valor1 + valor2;
                    textBox.Text = resultado.ToString();
                    break;

            }
        }

        
    }
}
