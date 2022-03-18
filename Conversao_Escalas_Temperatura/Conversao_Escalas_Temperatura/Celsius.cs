using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversao_Escalas_Temperatura
{
    class Celsius
    {
        public void GrausCelsius(double temperatura, bool eCelsius, bool eKelvin, bool eFahrennheit)
        {
          
            if (eCelsius == true)
            {
                MessageBox.Show("O valor informado já está em Celsius");
            }

            if (eKelvin == true)
            {
                double kelvin = 273.15 + temperatura;
                MessageBox.Show("Graus em Kelvin: " + kelvin);

            }

            if (eFahrennheit == true)
            {
                double fahrennheit = (temperatura * 1.8) + 32;
                MessageBox.Show("Graus em Fahrennheit: " + fahrennheit);
            }
        }
    }
}
