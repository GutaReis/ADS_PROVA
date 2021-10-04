using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Adição_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(valor1.Text);
            double numero2 = Convert.ToDouble(valor2.Text);
            double produto = numero1 + numero2;
            resultado.Text = produto.ToString();
        }

        private void Subtração_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(valor1.Text);
            double numero2 = Convert.ToDouble(valor2.Text);
            double produto = numero1 - numero2;
            resultado.Text = produto.ToString();
        }

        private void Multiplicação_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(valor1.Text);
            double numero2 = Convert.ToDouble(valor2.Text);
            double produto = numero1 * numero2;
            resultado.Text = produto.ToString();
        }

        private void Divisão_CheckedChanged(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(valor1.Text);
            double numero2 = Convert.ToDouble(valor2.Text);
            double produto = numero1 / numero2;
            resultado.Text = produto.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1.Text = "";
            valor2.Text = "";
            resultado.Text = "";
            valor1.Focus();
          
        }

        private void valor1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
