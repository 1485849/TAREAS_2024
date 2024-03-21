using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {

        double operando1 = 0;
        double operando2 = 0;
        string operador = "";


        public Form1()
        {
            InitializeComponent();
        }
        private bool resultadoMostrado = false;
        private string ultimoBotonPresionado = "";
        private void btn1_Click(object sender, EventArgs e)
        {
            // boton 1
            tbDisplay.Text = tbDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //boton 2
            tbDisplay.Text = tbDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //boton 3
            tbDisplay.Text = tbDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //boton 4
            tbDisplay.Text = tbDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //boton 5
            tbDisplay.Text = tbDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //boton 6
            tbDisplay.Text = tbDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //boton 7
            tbDisplay.Text = tbDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //boton 8
            tbDisplay.Text = tbDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //boton 9
            tbDisplay.Text = tbDisplay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //boton 0
            tbDisplay.Text = tbDisplay.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            //boton Punto

            // Verifica si el punto ya está presente en el número actual
            if (!tbDisplay.Text.Contains("."))
            {
                // Si no hay un punto presente, agrega uno al número actual
                tbDisplay.Text += ".";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            //boton Igual

            {
                operando2 = double.Parse(tbDisplay.Text);
                double resultado = 0;

                switch (operador)
                {
                    case "+":
                        resultado = operando1 + operando2;
                        break;
                    case "-":
                        resultado = operando1 - operando2;
                        break;
                    case "*":
                        resultado = operando1 * operando2;
                        break;
                    case "/":
                        if (operando2 != 0)
                        {
                            resultado = operando1 / operando2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede dividir entre cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tbDisplay.Clear();
                            return;
                        }
                        break;
                }

                tbDisplay.Text = resultado.ToString();
                resultadoMostrado = true; // Indica que el resultado ha sido mostrado





                tbDisplay.Text = resultado.ToString();
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //botonSuma
            operador = "+";
            operando1 = double.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            //botonResta
            operador = "-";
            operando1 = double.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            //botonMultiplicacion
            operador = "*";
            operando1 = double.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //boton Division
            operador = "/";
            operando1 = double.Parse(tbDisplay.Text);
            tbDisplay.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //boton limpiar
            {
                tbDisplay.Clear();
                operando1 = 0;
                operando2 = 0;
                operador = "";
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // boton borrar

            // Verifica si el cuadro de texto no está vacío
            if (tbDisplay.Text.Length > 0)
            {
                // Elimina el último carácter del cuadro de texto
                tbDisplay.Text = tbDisplay.Text.Remove(tbDisplay.Text.Length - 1, 1);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // boton apagar
            // Limpiar el contenido del cuadro de texto
            tbDisplay.Clear();

            // Reiniciar las variables que almacenan los operandos y el operador
            operando1 = 0;
            operando2 = 0;
            operador = "";
        }
    }
}
