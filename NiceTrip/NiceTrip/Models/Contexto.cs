using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using NiceTrip.Models;

namespace NiceTrip.Models
{
    public class Contexto:DbContext
    {
        public Contexto():base (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        { }
        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
    }
}