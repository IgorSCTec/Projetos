namespace Cadastro_Cliente
{
    public class ConsultarClienteBase
    {
        public List<Cliente> Consultar()
        {
            var cliente = new Cliente();

            const string connectionString = "Server=localhost,1433;Database=TesteCadastro;User ID=sa;Password=Teste@123";



            using (var connection = new SqlConnection(connectionString))
            {

                //var clientes = connection.Query<Cliente>(@"SELECT [Id], [Nome], [Email], [Phone], [Birthdate], 
                //[CreateDate] FROM [Cliente] WHERE [Nome] Like '%Igor Silva Costa%'");


                Cliente clientes;

                //return clientes = connection.Query<Cliente>(@"SELECT TOP 10 * FROM Cliente");


            }
        }
    }
}