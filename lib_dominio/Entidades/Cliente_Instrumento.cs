using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Cliente_Instrumento
    {
        public int Id { get; set; }
        public int InstrumentoId { get; set; }
        public Instrumento Instrumento { get; set; }
        public long ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha_Compra { get; set; }
        public string Estado { get; set; }

        

    }
}
