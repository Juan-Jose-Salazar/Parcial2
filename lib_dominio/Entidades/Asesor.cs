using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Asesor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int SucursalId { get; set; }
        public Sucursal Sucursal { get; set; }

        public ICollection<Factura> Facturas { get; set; }
    }
}
