using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private string operation = "";
        private double number1 = 0;
        private double number2 = 0;
        private double currentResult = 0;


        public Form1()
        {
            InitializeComponent();
        }

        void anyButton_Click(object sender, EventArgs e)    // envia o digito clicado para a caixa de texto
        {
            string digit = ((Button)sender).Text;
            textBox1.Text += digit;

        }

        void operation_Click(object sender, EventArgs e)    // envio o digito de opera��o para a caixa de texto, com
        {                                                   // espa�os e considerando n�meros negativos
            operation = ((Button)sender).Text;
            if (textBox1.Text == "" || textBox1.Text.Last() == ' ')   //tratamento para inclus�o de n�meros negativos
            {
                textBox1.Text += "-";
            }
            else if (!textBox1.Text.Contains(" ")) // nos outros casos, incluir opera��o se outra opera��o n�o existir
            {
                textBox1.Text += " " + operation + " ";                
            }
        }

        void clear_Click(object sender, EventArgs e) // apaga �ltimo envio
        {
            if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.Last() == ' ')
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 3);
                }
                else
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }
        }
        void fullClear_Click(object sender, EventArgs e) //apaga tudo
        {
            if (textBox1.Text.Length > 0 || textBox2.Text.Length > 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        void equals_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) //caso algo tenha sido inserido
            {
                textBox2.Text = textBox1.Text;
                string[] tokens = textBox1.Text.Split(" ");

                if (tokens.Length == 3) // cont�m exatamente dois n�meros e uma opera��o separados por espa�o
                {
                    number1 = Convert.ToDouble(tokens[0]);
                    operation = Convert.ToString(tokens[1]);
                    number2 = Convert.ToDouble(tokens[2]);

                    switch (operation)
                    {
                        case "+":
                            currentResult = number1 + number2;
                            break;
                        case "-":
                            currentResult = number1 - number2;
                            break;
                        case "x":
                            currentResult = number1 * number2;
                            break;
                        case "/":
                            currentResult = number1 / number2;
                            break;
                    }

                    if (currentResult.ToString().Contains(",")) //formata n�meros decimais
                    {
                        textBox1.Text = currentResult.ToString("F4");
                    }
                    else
                    {
                        textBox1.Text = currentResult.ToString();
                    }


                }
            }
        }


    }
}
