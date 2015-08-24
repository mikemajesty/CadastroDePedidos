using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CadastroDePedidos.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base(nameOrConnectionString: ConfigurationManager.ConnectionStrings["Con"].ConnectionString)
        {

        }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Itens> Itens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedidos>().ToTable(nameof(Pedidos));
            modelBuilder.Entity<Itens>().ToTable(nameof(Itens));
        }
    }
}