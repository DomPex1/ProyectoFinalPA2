using Microsoft.EntityFrameworkCore;
using ProyectoFinalPA2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPA2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<TipoCliente> TipoClientes { get; set }
        public DbSet<Quejas> Quejas { get; set; }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<PedidosDetalle> PedidosDetalles { get; set; }
        public DbSet<QuejasDetalle> QuejasDetalles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite(@"Data source = Database\ProyectoFinal1Data.db");
        }
    }
}
