using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Funcional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculadora calculadora = new Calculadora();
        private void btn_N0_Click(object sender, EventArgs e)
        {
            tbx_Screen.Text = tbx_Screen.Text + "0";
        }

        private void btn_N1_Click(object sender, EventArgs e)
        {
            tbx_Screen.Text = tbx_Screen.Text + "1";
        }

        private void btn_N2_Click(object sender, EventArgs e)
        {
            tbx_Screen.Text = tbx_Screen.Text + "2";
        }

        private void btn_N3_Click(object sender, EventArgs e)
        {
            tbx_Screen.Text = tbx_Screen.Text + "3";
        }

        private void btn_N4_Click(object sender, EventArgs e)
        {
            tbx_Screen.Text = tbx_Screen.Text + "4";
        }

        private void btn_N5_Click(object sender, EventArgs e)
        {
            tbx_Screen.Text = tbx_Screen.Text + "5";
        }

        private void btn_N6_Click(object sender, EventArgs e)
        {
            tbx_Screen.Text = tbx_Screen.Text + "6";
        }

        private void btn_N7_Click(object sender, EventArgs e)
        {
            tbx_Screen.Text = tbx_Screen.Text + "7";
        }

        private void btn_N8_Click(object sender, EventArgs e)
        {
            tbx_Screen.Text = tbx_Screen.Text + "8";
        }

        private void btn_N9_Click(object sender, EventArgs e)
        {
            tbx_Screen.Text = tbx_Screen.Text + "9";
        }

        private void btn_Punto_Click(object sender, EventArgs e)
        {
            tbx_Screen.Text = tbx_Screen.Text + ".";
        }

        private void btn_Mas_Click(object sender, EventArgs e)
        {
            calculadora._operador = "+";
            calculadora._numero_1 = double.Parse(tbx_Screen.Text);
            tbx_Screen.Clear();
        }

        private void btn_Menos_Click(object sender, EventArgs e)
        {
            calculadora._operador = "-";
            calculadora._numero_1 = double.Parse(tbx_Screen.Text);
            tbx_Screen.Clear();
        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {
            calculadora._operador = "*";
            calculadora._numero_1 = double.Parse(tbx_Screen.Text);
            tbx_Screen.Clear();
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {
            calculadora._operador = "/";
            calculadora._numero_1 = double.Parse(tbx_Screen.Text);
            tbx_Screen.Clear();
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            calculadora._numero_2 = double.Parse(tbx_Screen.Text);

            switch (calculadora._operador)
            {
                case "+": 
                    tbx_Screen.Text = calculadora.Sumar((calculadora._numero_1), (calculadora._numero_2)).ToString();
                    break;
                case "-":
                    tbx_Screen.Text = calculadora.Restar((calculadora._numero_1), (calculadora._numero_2)).ToString();
                    break;
                case "*":
                    tbx_Screen.Text = calculadora.Multiplicar((calculadora._numero_1), (calculadora._numero_2)).ToString();
                    break;
                case "/":
                    tbx_Screen.Text = calculadora.Dividir((calculadora._numero_1), (calculadora._numero_2)).ToString();
                    break;
            }
        }

        private void btn_Eliminar_Todo_Click(object sender, EventArgs e)
        {
            tbx_Screen.Clear();
        }

        private void btn_Eliminar_Uno_Click(object sender, EventArgs e)
        {
            if (tbx_Screen.Text.Length == 1)
                tbx_Screen.Text = "";
            else
                tbx_Screen.Text = tbx_Screen.Text.Substring(0, tbx_Screen.Text.Length - 1);
        }
    }
}
