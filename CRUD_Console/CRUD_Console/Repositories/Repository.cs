using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace CRUD_Console.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection;
        public Repository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<T> Read(string sql, string nome)
            => _connection.Query<T>(sql, new { teste = $"%{nome}%" });

        public IEnumerable<T> ReadAll()
            => _connection.GetAll<T>();

        public void Create(T cliente2)
            => _connection.Insert<T>(cliente2);

        public IEnumerable<T> Delete(string sql, string nome)
            => _connection.Query<T>(sql, new { teste = $"%{nome}%" });

        public void Update(string sql, string novoNome, string antigoNome)
            => _connection.Execute(sql, new { novoNome = $"{novoNome}", antigoNome = $"%{antigoNome}%" });

        public void Update(string sql, DateTime novoNome, string antigoNome)
            => _connection.Execute(sql, new { novoNome = novoNome, antigoNome = $"%{antigoNome}%" });
    }
}
