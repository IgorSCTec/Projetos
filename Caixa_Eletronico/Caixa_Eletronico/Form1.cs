using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //double valorDigitado = double.Parse(txtbox1.Text);
                //string strDados = string.Join("\n", valorDigitado);
                // MessageBox.Show(strDados);
                //Operacao();
            }
        }

        public void Operacao()
        {
            double valorDigitado = double.Parse(textBox1.Text);
            double nota200 = 0;
            double nota100 = 0;
            double nota50 = 0;
            double nota20 = 0;
            double nota10 = 0;
            double nota05 = 0;
            double nota02 = 0;
            double moeda1 = 0;
            double moeda50 = 0;
            double moeda25 = 0;
            double moeda10 = 0;
            double moeda05 = 0;

            string[] notas = new string[12];
            List<string> notas2 = new List<string>();

            while (valorDigitado >= 200)
            {
                double variavelApoio = valorDigitado - 200;
                valorDigitado = variavelApoio;
                nota200++;
                notas[0] = "Notas de Duzentos: " + nota200;
            }


            while (valorDigitado >= 100)
            {
                double variavelApoio = valorDigitado - 100;
                valorDigitado = variavelApoio;
                nota100++;
                notas[1] = "Notas de Cem: " + nota100;
            }

            while (valorDigitado >= 50)
            {
                double variavelApoio = valorDigitado - 50;
                valorDigitado = variavelApoio;
                nota50++;
                notas[2] = "Notas de Cinquenta: " + nota50;
            }

            while (valorDigitado >= 20)
            {
                double variavelApoio = valorDigitado - 20;
                valorDigitado = variavelApoio;
                nota20++;
                notas[3] = "Notas de Vinte: " + nota20;
            }

            while (valorDigitado >= 10)
            {
                double variavelApoio = valorDigitado - 10;
                valorDigitado = variavelApoio;
                nota10++;
                notas[4] = "Notas de Dez: " + nota10;
            }

            while (valorDigitado >= 5)
            {
                double variavelApoio = valorDigitado - 5;
                valorDigitado = variavelApoio;
                nota05++;
                notas[5] = "Notas de Cinco: " + nota05;
            }

            while (valorDigitado >= 2)
            {
                double variavelApoio = valorDigitado - 2;
                valorDigitado = variavelApoio;
                nota02++;
                notas[6] = "Notas de Dois: " + nota02;
            }

            while (valorDigitado >= 1)
            {
                double variavelApoio = valorDigitado - 1;
                valorDigitado = variavelApoio;
                moeda1++;
                notas[7] = "Moedas de Um: " + moeda1;
            }

            /*while (valorDigitado >= 0.50)
            {
                double variavelApoio = valorDigitado - 0.50;
                valorDigitado = variavelApoio;
                moeda50++;
                notas[8] = "Notas de Dois: " + moeda50;
            }

            while (valorDigitado >= 2)
            {
                double variavelApoio = valorDigitado - 2;
                valorDigitado = variavelApoio;
                nota02++;
                notas[6] = "Notas de Dois: " + nota02;
            }

            while (valorDigitado >= 2)
            {
                double variavelApoio = valorDigitado - 2;
                valorDigitado = variavelApoio;
                nota02++;
                notas[6] = "Notas de Dois: " + nota02;
            }

            while (valorDigitado >= 2)
            {
                double variavelApoio = valorDigitado - 2;
                valorDigitado = variavelApoio;
                nota02++;
                notas[6] = "Notas de Dois: " + nota02;
            }*/

            if (nota200 != 0)
            {
                notas2.Add(notas[0]);
            }

            if (nota100 != 0)
            {
                notas2.Add(notas[1]);
            }

            if (nota50 != 0)
            {
                notas2.Add(notas[2]);
            }

            if (nota20 != 0)
            {
                notas2.Add(notas[3]);
            }

            if (nota10 != 0)
            {
                notas2.Add(notas[4]);
            }

            if (nota05 != 0)
            {
                notas2.Add(notas[5]);
            }

            if (nota02 != 0)
            {
                notas2.Add(notas[6]);
            }

            string strDados = string.Join("\n", notas2);
            MessageBox.Show(strDados);

        }

    }
}


