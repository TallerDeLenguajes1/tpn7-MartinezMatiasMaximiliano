using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico7
{
    public partial class Form1 : Form
    {
        char operador;
        float resultado, num1, num2;
        Calculadora nuevo = new Calculadora();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            TBNumero.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TBNumero.Text == "")
            {
                TBNumero.Clear();
            }
            TBNumero.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TBNumero.Text == "")
            {
                TBNumero.Clear();
            }
            TBNumero.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TBNumero.Text == "")
            {
                TBNumero.Clear();
            }
            TBNumero.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (TBNumero.Text == "")
            {
                TBNumero.Clear();
            }
            TBNumero.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (TBNumero.Text == "")
            {
                TBNumero.Clear();
            }
            TBNumero.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (TBNumero.Text == "")
            {
                TBNumero.Clear();
            }
            TBNumero.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TBNumero.Text == "")
            {
                TBNumero.Clear();
            }
            TBNumero.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (TBNumero.Text == "")
            {
                TBNumero.Clear();
            }
            TBNumero.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (TBNumero.Text == "")
            {
                TBNumero.Clear();
            }
            TBNumero.Text += "9";
        }
        private void buttonZero_Click(object sender, EventArgs e)
        {
            if (TBNumero.Text == "")
            {
                TBNumero.Clear();
            }
            TBNumero.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TBNumero.Text += ".";

        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            operador = '+';
            if (TBNumero.Text == "")
            {
                num1 = 0;
            }
            else
            {
                num1 = Convert.ToSingle(TBNumero.Text);
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            operador = '-';
            if (TBNumero.Text == "")
            {
                num1 = 0;
            }
            else
            {
                num1 = Convert.ToSingle(TBNumero.Text);
            }
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            operador = '*';
            if (TBNumero.Text == "") 
            {
                num1 = 0;
            }
            else
            {
                num1 = Convert.ToSingle(TBNumero.Text);
            }
        }


        private void buttonDiv_Click(object sender, EventArgs e)
        {
            operador = '/';
            if (TBNumero.Text == "")
            {
                num1 = 0;
            }
            else
            {
                num1 = Convert.ToSingle(TBNumero.Text);
            }
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            if(TBNumero.Text == "")
            {
                num2 = 0;
            }
            else
            {
                num2 = Convert.ToSingle(TBNumero.Text);
            }
            nuevo.Numero1 = num1;
            nuevo.Numero2 = num2;

            switch (operador)
            {
                case '+':
                    resultado = nuevo.Suma();
                    TBNumero.Text = Convert.ToString(resultado);
                    break;

                case '-':
                    resultado = nuevo.Resta();
                    TBNumero.Text = Convert.ToString(resultado);
                    break;

                case '*':
                    resultado = nuevo.Multiplicacion();
                    TBNumero.Text = Convert.ToString(resultado);
                    break;

                case '/':
                    if (nuevo.Numero2 == 0)
                    {
                        TBNumero.Text = "MATH ERROR";
                        break;
                    }
                    resultado = nuevo.Division();
                    TBNumero.Text = Convert.ToString(resultado);
                    break;
            }
        } 

        
    }
}
