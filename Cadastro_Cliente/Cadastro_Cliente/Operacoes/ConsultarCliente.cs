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
              
        public List<Cliente> Consultar(string nome)
        {

           
            
            const string connectionString = "Server=localhost,1433;Database=TesteCadastro;User ID=sa;Password=Teste@123";

            using (var connection = new SqlConnection(connectionString))
            {
                var sql = $"SELECT [Nome], [Phone], [Email] FROM [Cliente] WHERE [Nome] LIKE @teste";
                return connection.Query<Cliente>(sql, new { teste = $"%{nome}%" }).ToList();
            }
            
        }
    }
}
