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
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Lutier> Lutiers { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }
        public DbSet<Asesor> Asesores { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Instrumento> Instrumentos { get; set; }
        public DbSet<Accesorio> Accesorios { get; set; }
        public DbSet<Instrumento_Accesorio> Instrumentos_Accesorios { get; set; }
        public DbSet<Instrumento_Factura> Instrumentos_Facturas { get; set; }
        public DbSet<Cliente_Instrumento> Clientes_Instrumentos { get; set; }


    }
    
}

