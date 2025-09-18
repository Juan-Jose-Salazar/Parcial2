using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Clientes_Instrumentos
    {
        public int Id { get; set; }
        public int Instrumento { get; set; }
        
        public long Cliente { get; set; }
        
        public DateTime Fecha_Compra { get; set; }
        public string? Estado { get; set; }

        [ForeignKey("Cliente")] public Clientes? _Cliente { get; set; }
        [ForeignKey("Instrumento")] public Instrumentos? _Instrumento { get; set; }


    }
}
