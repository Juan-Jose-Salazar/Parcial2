using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_dominio.Entidades;

namespace lib_repositorios.Interfaces
{
    public interface IConexion
    {
        string? StringConexion { get; set; }

         DbSet<Clientes> Clientes { get; set; }
        DbSet<Admin> Admin { get; set; }
        DbSet<Lutiers> Lutiers { get; set; }
        DbSet<Ciudades> Ciudades { get; set; }
        DbSet<Sucursales> Sucursales { get; set; }
        DbSet<Asesores> Asesores { get; set; }
        DbSet<Facturas> Facturas { get; set; }
        DbSet<Empleado> Empleado { get; set; }
        DbSet<Categorias> Categorias { get; set; }
        DbSet<Instrumentos> Instrumentos { get; set; }
        DbSet<Accesorios> Accesorios { get; set; }
        DbSet<Instrumentos_Accesorios> Instrumentos_Accesorios { get; set; }
        DbSet<Instrumentos_Facturas> Instrumentos_Facturas { get; set; }
        DbSet<Clientes_Instrumentos> Clientes_Instrumentos { get; set; }

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
