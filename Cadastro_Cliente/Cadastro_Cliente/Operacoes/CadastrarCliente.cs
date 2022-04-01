using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro_Cliente.Modelos;
using Dapper;

namespace Cadastro_Cliente 
{
    class CadastrarCliente
    {
        public void Cadastrar(string nome, string email, string telefone, string nascimento)
        {
            var cadastrar = new Cliente();
            cadastrar.Id = Guid.NewGuid();
            cadastrar.Nome = nome;
            cadastrar.Email = email;
            cadastrar.Phone = telefone;
            cadastrar.Birthdate = Convert.ToDateTime(nascimento);
            cadastrar.CreateDate = DateTime.Now;

            const string connectionString = "Server=localhost,1433;Database=TesteCadastro;User ID=sa;Password=Teste@123";

            var insertSql = @"INSERT INTO   
                [Cliente] 
            VALUES(

                @Id, 
                @Nome, 
                @Email, 
                @Phone, 
                @Birthdate, 
                @CreateDate)";

            using (var connection = new SqlConnection(connectionString))
            {

                var rows = connection.Execute(insertSql, new
                {
                    cadastrar.Id,
                    cadastrar.Nome,
                    cadastrar.Email,
                    cadastrar.Phone,
                    cadastrar.Birthdate,
                    cadastrar.CreateDate,
                }); 
                
                MessageBox.Show("Cliente Cadastrado");
            }
        }
    }
}
