using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Facturas
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        
        public long Cliente { get; set; }
        public int Asesor { get; set; }


        [ForeignKey("Cliente")] public Clientes? _Cliente { get; set; }
        [ForeignKey("Asesor")] public Asesores? _Asesor { get; set; }
    }
}
