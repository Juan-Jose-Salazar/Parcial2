using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        
        public long ClienteId { get; set; }
        public Cliente Cliente { get; set; }


        public int AsesorId { get; set; }
        public Asesor Asesor { get; set; }
    }
}
