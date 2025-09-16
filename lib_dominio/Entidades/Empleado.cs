using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }

        public ICollection<Sucursal> Sucursales { get; set; }
    }
}
