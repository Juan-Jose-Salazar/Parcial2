using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        
        public int CiudadId { get; set; }

        
        public Ciudad Ciudad { get; set; }

        
        public ICollection<Asesor> Asesores { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}
