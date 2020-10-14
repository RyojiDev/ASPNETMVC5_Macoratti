using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Demo.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext() : base("ClienteContext")
        {
            Database.SetInitializer<ClienteContext>(null);
        }
        public DbSet<Cliente> clientes { get; set; }

        public DbSet<Aluno> aluno { get; set; }

        public System.Data.Entity.DbSet<Business.AlunoBO> AlunoBOes { get; set; }
    }
}