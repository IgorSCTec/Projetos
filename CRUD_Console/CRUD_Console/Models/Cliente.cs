using Dapper.Contrib.Extensions;
using System;

namespace CRUD_Console.Models
{
    [Table("[Cliente]")]
    public class Cliente
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime Birthdate { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
