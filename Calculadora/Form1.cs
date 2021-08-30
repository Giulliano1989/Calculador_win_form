using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdição_Click(object sender, EventArgs e)
        {

            int N1 = Convert.ToInt32(Valor1.Text);
            int N2 = Convert.ToInt32(Valor2.Text);
            int Valor = N1 + N2;
            Resultado.Text = Convert.ToString(Valor);
        }

        private void btnSubtração_Click(object sender, EventArgs e)
        {
            int N1 = Convert.ToInt32(Valor1.Text);
            int N2 = Convert.ToInt32(Valor2.Text);
            int Valor = N1 - N2;
            Resultado.Text = Convert.ToString(Valor);
        }

        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            int N1 = Convert.ToInt32(Valor1.Text);
            int N2 = Convert.ToInt32(Valor2.Text);
            int Valor = N1 * N2;
            Resultado.Text = Convert.ToString(Valor);
        }

        private void btnDivisão_Click(object sender, EventArgs e)
        {
            int N1 = Convert.ToInt32(Valor1.Text);
            int N2 = Convert.ToInt32(Valor2.Text);
            int Valor = N1 / N2;
            Resultado.Text = Convert.ToString(Valor);

        }
    }
}
