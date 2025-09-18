using lib_dominio.Entidades;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public partial class Conexion : DbContext, IConexion
    {
        public string? StringConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.StringConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Lutiers> Lutiers { get; set; }
        public DbSet<Ciudades> Ciudades { get; set; }
        public DbSet<Sucursales> Sucursales { get; set; }
        public DbSet<Asesores> Asesores { get; set; }
        public DbSet<Facturas> Facturas { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Instrumentos> Instrumentos { get; set; }
        public DbSet<Accesorios> Accesorios { get; set; }
        public DbSet<Instrumentos_Accesorios> Instrumentos_Accesorios { get; set; }
        public DbSet<Instrumentos_Facturas> Instrumentos_Facturas { get; set; }
        public DbSet<Clientes_Instrumentos> Clientes_Instrumentos { get; set; }


    }
    
}

