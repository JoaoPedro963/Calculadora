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
        decimal valor1 = 0, valor2 = 0;
        string operacao = " ";

        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "3";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "5";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "6";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            if (txtBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                operacao = "SOMA";
                labelOperacao.Text = "+";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a soma");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                operacao = "SUB";
                labelOperacao.Text = "-";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Subtração");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                operacao = "MULT";
                labelOperacao.Text = "X";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Multiplicação");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                operacao = "DIV";
                labelOperacao.Text = "/";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Divisão");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text += ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
    
            if (operacao == "SOMA")
            {
                txtBoxResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtBoxResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtBoxResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIV")
            {
                txtBoxResultado.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "POR")
            {
                txtBoxResultado.Text = Convert.ToString((valor1 / 100) * valor2);
            }
            else if (operacao =="EXP")
            {
                txtBoxResultado.Text = Convert.ToString(Math.Pow(Convert.ToDouble(valor1), Convert.ToDouble(valor2)));
                
            }
            else
             {
                txtBoxResultado.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(valor1)));
            }


        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            labelOperacao.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                operacao = "POR";
                labelOperacao.Text = "%";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Porcentagem");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (txtBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = "";
                operacao = "EXP";
                labelOperacao.Text = "^";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Porcentagem");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {

            if (txtBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
                txtBoxResultado.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(valor1)));
                labelOperacao.Text = "√";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtBoxResultado.Text, CultureInfo.InvariantCulture);
            txtBoxResultado.Text = Convert.ToString(1 / valor1);
            labelOperacao.Text = "^";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtBoxResultado.Text = "";
            labelOperacao.Text = "";
        }
    }
}
