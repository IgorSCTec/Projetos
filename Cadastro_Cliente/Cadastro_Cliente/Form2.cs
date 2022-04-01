using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Cliente
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtNomeConsult_TextChanged(object sender, EventArgs e)
        {

        }


        public void txtNomeConsult_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                var cliente = new ConsultarCliente();
                cliente.Consultar(txtNomeConsult.Text);
                var consultar = new ConsultarCliente();
                clienteBindingSource.DataSource = consultar.Consultar(txtNomeConsult.Text);
            }
           

        }
    }
}
