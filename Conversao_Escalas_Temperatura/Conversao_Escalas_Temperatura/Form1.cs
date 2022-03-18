using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversao_Escalas_Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (lbltCelsius.Checked)
            {
                Celsius gcelsius = new Celsius();
                gcelsius.GrausCelsius(double.Parse(textBox1.Text), lblcCelsius.Checked, lblcKelvin.Checked, lblcFahrenheit.Checked);
            }

            if (lbltKelvin.Checked)
            {
                Kelvin gkelvin = new Kelvin();
                gkelvin.GrausKelvin(double.Parse(textBox1.Text), lblcCelsius.Checked, lblcKelvin.Checked, lblcFahrenheit.Checked);
            }

            if (lbltFahrenheit.Checked)
            {
                Fahrenheit gfahrenheit = new Fahrenheit();
                gfahrenheit.GrausFahrenheit(double.Parse(textBox1.Text), lblcCelsius.Checked, lblcKelvin.Checked, lblcFahrenheit.Checked);
            }

        }

        

        

        
    }
}
