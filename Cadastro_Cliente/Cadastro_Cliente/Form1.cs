using Cadastro_Cliente.Operacoes;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var cadastrar = new CadastrarCliente();
            cadastrar.Cadastrar(txtNome.Text, txtEmail.Text, txtTelefone.Text, txtNascimento.Text);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
            var alterar = new ModificarCliente();
            alterar.Modificar();
        }
    }
}
