using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversao_Escalas_Temperatura
{
    class Kelvin
    {
        public void GrausKelvin(double temperatura, bool eCelsius, bool eKelvin, bool eFahrennheit)
        {
                       
            if (eCelsius == true)
            {
                double celsius = temperatura - 273.15;
                MessageBox.Show("Graus em Celsius: " + celsius);
            }

            if (eKelvin == true)
            {
                MessageBox.Show("O valor informado já está em Kelvin");
            }

            if (eFahrennheit == true)
            {
                double fahrennheit = 32 + (temperatura - 273.15) * 1.8;
                MessageBox.Show("Graus em Fahrennheit: " + fahrennheit);
            }
        }
    }
}
