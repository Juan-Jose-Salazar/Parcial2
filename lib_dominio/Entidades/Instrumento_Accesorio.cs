using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_dominio.Entidades
{
    public class Instrumento_Accesorio
    {
        public int Id { get; set; }
        public int InstrumentoId { get; set; }
        public Instrumento Instrumento { get; set; }
        public int AccesorioId { get; set; }
        public Accesorio Accesorio { get; set; }
    }
}
