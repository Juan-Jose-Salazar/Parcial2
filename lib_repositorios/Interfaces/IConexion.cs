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

         DbSet<Cliente> Clientes { get; set; }
        DbSet<Admin> Admins { get; set; }
        DbSet<Lutier> Lutiers { get; set; }
        DbSet<Ciudad> Ciudades { get; set; }
        DbSet<Sucursal> Sucursales { get; set; }
        DbSet<Asesor> Asesores { get; set; }
        DbSet<Factura> Facturas { get; set; }
        DbSet<Empleado> Empleados { get; set; }
        DbSet<Categoria> Categorias { get; set; }
        DbSet<Instrumento> Instrumentos { get; set; }
        DbSet<Accesorio> Accesorios { get; set; }
        DbSet<Instrumento_Accesorio> Instrumentos_Accesorios { get; set; }
        DbSet<Instrumento_Factura> Instrumentos_Facturas { get; set; }
        DbSet<Cliente_Instrumento> Clientes_Instrumentos { get; set; }

        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
