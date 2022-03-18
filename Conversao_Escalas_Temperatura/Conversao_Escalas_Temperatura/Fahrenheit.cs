using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversao_Escalas_Temperatura
{
    class Fahrenheit
    {
        public void GrausFahrenheit(double temperatura, bool eCelsius, bool eKelvin, bool eFahrennheit)
        {

            if (eCelsius == true)
            {
                double celsius = (temperatura - 32) / 1.8;
                MessageBox.Show("Graus em Celsius: " + celsius);
            }

            if (eKelvin == true)
            {
                double kelvin = ((temperatura - 32) * 5 / 9) + 273.15;
                MessageBox.Show("Graus em Kelvin: " + kelvin);
            }

            if (eFahrennheit == true)
            {
                MessageBox.Show("O valor informado já está em Fahrenheit");
            }
        }

    }
}
