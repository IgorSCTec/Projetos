using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro_Cliente.Modelos;
using Microsoft.Build.Framework.XamlTypes;
using Dapper;

namespace Cadastro_Cliente
{
    public class ConsultarCliente
    {
         
        public List<Cliente> Consultar()
        {
            var nome = new NomeConsult();
            MessageBox.Show($"3 {nome.Nome}");
            var teste = nome.Nome;
            MessageBox.Show($"4 {teste}");
            
            const string connectionString = "Server=localhost,1433;Database=TesteCadastro;User ID=sa;Password=Teste@123";

            using (var connection = new SqlConnection(connectionString))
            {
                return connection.Query<Cliente>($"SELECT [Nome], [Phone], [Email] FROM [Cliente] WHERE [Nome] Like '%{teste}%'").ToList();
            }

        }
    }
}
