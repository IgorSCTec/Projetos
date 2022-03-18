using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Caixa_Eletronico
{
    public class Operacao : Form
    {
        public void OperacaoNotas(double valorDigitado)
        {            
            List<string> notas2 = new List<string>();

            if (valorDigitado >= 200)
            {
                double resto = valorDigitado % 200;
                double variavelApoio = valorDigitado - resto;
                double nota200 = variavelApoio / 200;
                valorDigitado = resto;
                notas2.Add("Notas de Duzentos: " + nota200);
            }

            if (valorDigitado >= 100)
            {
                double resto = valorDigitado % 100;
                double variavelApoio = valorDigitado - resto;
                double nota100 = variavelApoio / 100;
                valorDigitado = resto;
                notas2.Add("Notas de Cem: " + nota100);
            }

            if (valorDigitado >= 50)
            {
                double resto = valorDigitado % 50;
                double variavelApoio = valorDigitado - resto;
                double nota50 = variavelApoio / 50;
                valorDigitado = resto;
                notas2.Add("Notas de Cinquenta: " + nota50);
            }

            if (valorDigitado >= 20)
            {
                double resto = valorDigitado % 20;
                double variavelApoio = valorDigitado - resto;
                double nota20 = variavelApoio / 20;
                valorDigitado = resto;
                notas2.Add("Notas de Vinte: " + nota20);
            }

            if (valorDigitado >= 10)
            {
                double resto = valorDigitado % 10;
                double variavelApoio = valorDigitado - resto;
                double nota10 = variavelApoio / 10;
                valorDigitado = resto;
                notas2.Add("Notas de Dez: " + nota10);
            }

            if (valorDigitado >= 5)
            {
                double resto = valorDigitado % 5;
                double variavelApoio = valorDigitado - resto;
                double nota5 = variavelApoio / 5;
                valorDigitado = resto;
                notas2.Add("Notas de Cinco: " + nota5);
            }

            if (valorDigitado >= 2)
            {
                double resto = valorDigitado % 2;
                double variavelApoio = valorDigitado - resto;
                double nota2 = variavelApoio / 2;
                valorDigitado = resto;
                notas2.Add("Notas de Dois: " + nota2);
            }

            if (valorDigitado >= 1)
            {
                double resto = valorDigitado % 1;
                double variavelApoio = valorDigitado - resto;
                double moeda1 = variavelApoio / 1;
                valorDigitado = resto;
                notas2.Add("Moedas de Um: " + moeda1);
            }

            if (valorDigitado >= 0.50)
            {
                double resto = valorDigitado % 0.50;
                double variavelApoio = valorDigitado - resto;
                double moeda50 = variavelApoio / 0.50;
                valorDigitado = resto;
                notas2.Add("Moedas de Ciquenta Centavos: " + moeda50);
            }

            if (valorDigitado >= 0.25)
            {
                double resto = valorDigitado % 0.25;
                double variavelApoio = valorDigitado - resto;
                double moeda25 = variavelApoio / 0.25;
                valorDigitado = resto;
                notas2.Add("Moedas de Vinte e Cinco Centavos: " + moeda25);
            }

            if (valorDigitado >= 0.10)
            {
                double resto = valorDigitado % 0.10;
                double variavelApoio = valorDigitado - resto;
                double moeda10 = variavelApoio / 0.10;
                valorDigitado = resto;
                notas2.Add("Moedas de Dez Centavos: " + moeda10);
            }

            if (valorDigitado >= 0.05)
            {
                double resto = valorDigitado % 0.05;
                double variavelApoio = valorDigitado - resto;
                double moeda5 = variavelApoio / 0.05;
                valorDigitado = resto;
                notas2.Add("Moedas de Cinco Centavos: " + moeda5);
            }
            
            string strDados = string.Join("\n", notas2);
            MessageBox.Show(strDados);
        }
    }
}
